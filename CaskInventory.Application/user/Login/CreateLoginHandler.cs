using CaskInventory.Application.User;
using CaskInventory.Common.Exceptions;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CaskInventory.Application.user.Login
{
    public class CreateLoginHandler : IRequestHandler<CreateLoginCommand, UserDto>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public CreateLoginHandler(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<UserDto> Handle(CreateLoginCommand request, CancellationToken cancellationToken)
        {
            var result = await _signInManager.PasswordSignInAsync(request.Email, request.Password, false, true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(request.Email);
                IList<string> roles = await _userManager.GetRolesAsync(user);
                return new UserDto
                {
                    Username = user.Email,
                    Token = "" //await _jwtService.GenerateJwt(user.Email)
                };
            }

            throw new BadRequestException("Invalid User");
        }
    }
}
