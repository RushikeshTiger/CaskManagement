using CaskInventory.Application.User;
using CaskInventory.Common.Exceptions;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace CaskInventory.Application.user.Create
{
    public sealed class CreateUserHandler : IRequestHandler<CreateUserCommand, UserDto>
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly string? Role = string.Empty;

        public CreateUserHandler(SignInManager<ApplicationUser> signInManager,
                                UserManager<ApplicationUser> userManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            var config = configuration.GetSection("UserSettings").GetSection("Admin");
            Role = config!.GetValue<string>("Role");
        }



        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var user = new ApplicationUser
            {
                UserName = request.username,
                Email = request.username,
                EmailConfirmed = true
                
            };

            var result = await _userManager.CreateAsync(user, request.password);
            if (result.Succeeded)
            {
                var isRoleExist = await _roleManager.RoleExistsAsync(Role!);
                if (!isRoleExist)
                {
                    await _roleManager.CreateAsync(new IdentityRole(Role!));
                }
                await _userManager.AddToRoleAsync(user, Role!);
                await _signInManager.SignInAsync(user, false);
                //var token = await _jwtService.GenerateJwt(user.Email);
                return new UserDto { Username = user.UserName, Token = "" };
            }

            throw new BadRequestException("User Already Exists");
        }
    }
}
