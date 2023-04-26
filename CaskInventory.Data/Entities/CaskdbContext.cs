using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CaskInventory.Data.Entities;

public partial class CaskdbContext : IdentityDbContext<ApplicationUser>
{
    public CaskdbContext()
    {
    }

    public CaskdbContext(DbContextOptions<CaskdbContext> options) : base(options)
    {
    }


    public virtual DbSet<Cask> Casks { get; set; }

    public virtual DbSet<Caskfilling> Caskfillings { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Distillery> Distilleries { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Salesperson> Salespeople { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Transfer> Transfers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cask>(entity =>
        {
            entity.HasKey(e => e.CaskId).HasName("PRIMARY");

            entity.ToTable("cask");

            entity.Property(e => e.CaskId).HasColumnName("caskId");
            entity.Property(e => e.CaskDescription)
                .HasMaxLength(25)
                .HasColumnName("caskDescription");
            entity.Property(e => e.CaskType)
                .HasMaxLength(25)
                .HasColumnName("caskType");
        });

        modelBuilder.Entity<Caskfilling>(entity =>
        {
            entity.HasKey(e => e.CfId).HasName("PRIMARY");

            entity.ToTable("caskfilling");

            entity.HasIndex(e => e.CaskId, "FK_caskcaskfill");

            entity.HasIndex(e => e.DistilleryId, "FK_distcaskfill");

            entity.Property(e => e.CfId).HasColumnName("cfId");
            entity.Property(e => e.Abv)
                .HasPrecision(10)
                .HasColumnName("ABV");
            entity.Property(e => e.BulkLiture)
                .HasPrecision(10)
                .HasColumnName("bulkLiture");
            entity.Property(e => e.CaskId).HasColumnName("caskId");
            entity.Property(e => e.CaskPrice)
                .HasPrecision(10)
                .HasColumnName("caskPrice");
            entity.Property(e => e.DistilleryId).HasColumnName("distilleryId");
            entity.Property(e => e.FillingDate)
                .HasColumnType("date")
                .HasColumnName("fillingDate");
            entity.Property(e => e.Region)
                .HasMaxLength(25)
                .HasColumnName("region");
            entity.Property(e => e.Rlaola)
                .HasPrecision(10)
                .HasColumnName("RLAOLA");

            entity.HasOne(d => d.Cask).WithMany(p => p.Caskfillings)
                .HasForeignKey(d => d.CaskId)
                .HasConstraintName("FK_caskcaskfill");

            entity.HasOne(d => d.Distillery).WithMany(p => p.Caskfillings)
                .HasForeignKey(d => d.DistilleryId)
                .HasConstraintName("FK_distcaskfill");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.ClientAddress)
                .HasMaxLength(25)
                .HasColumnName("clientAddress");
            entity.Property(e => e.ClientEmail)
                .HasMaxLength(25)
                .HasColumnName("clientEmail");
            entity.Property(e => e.ClientName)
                .HasMaxLength(25)
                .HasColumnName("clientName");
        });

        modelBuilder.Entity<Distillery>(entity =>
        {
            entity.HasKey(e => e.DistilleryId).HasName("PRIMARY");

            entity.ToTable("distillery");

            entity.Property(e => e.DistilleryId).HasColumnName("distilleryId");
            entity.Property(e => e.DistilleryIlocation)
                .HasMaxLength(25)
                .HasColumnName("distilleryILocation");
            entity.Property(e => e.DistilleryName)
                .HasMaxLength(25)
                .HasColumnName("distilleryName");
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PRIMARY");

            entity.ToTable("purchases");

            entity.HasIndex(e => e.CaskId, "FK_caskfillclientprchase");

            entity.HasIndex(e => e.ClientId, "FK_clientpurchase");

            entity.HasIndex(e => e.SalesPersonId, "FK_salesprsnclientpurchase");

            entity.HasIndex(e => e.SupplierId, "FK_supplierclientpurchase");

            entity.Property(e => e.PurchaseId).HasColumnName("purchaseId");
            entity.Property(e => e.AmountPaid).HasPrecision(10);
            entity.Property(e => e.BeingMovedTo).HasMaxLength(25);
            entity.Property(e => e.CaskId).HasColumnName("caskId");
            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.DoDate).HasColumnType("date");
            entity.Property(e => e.DoLocation).HasMaxLength(25);
            entity.Property(e => e.DoRecorded).HasMaxLength(10);
            entity.Property(e => e.DoSignedReturnedDate).HasColumnType("date");
            entity.Property(e => e.InvoiceDate)
                .HasColumnType("date")
                .HasColumnName("invoiceDate");
            entity.Property(e => e.InvoiceDescription)
                .HasMaxLength(25)
                .HasColumnName("invoiceDescription");
            entity.Property(e => e.InvoiceLocation).HasMaxLength(25);
            entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");
            entity.Property(e => e.SalesPersonId).HasColumnName("salesPersonId");
            entity.Property(e => e.SupplierId).HasColumnName("supplierId");
            entity.Property(e => e.TransferComplete).HasMaxLength(25);

            entity.HasOne(d => d.Cask).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.CaskId)
                .HasConstraintName("FK_caskfillclientprchase");

            entity.HasOne(d => d.Client).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_clientpurchase");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_salesprsnclientpurchase");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_supplierclientpurchase");
        });

        modelBuilder.Entity<Salesperson>(entity =>
        {
            entity.HasKey(e => e.SalespersonId).HasName("PRIMARY");

            entity.ToTable("salesperson");

            entity.Property(e => e.SalespersonId).HasColumnName("salespersonId");
            entity.Property(e => e.SalespersonName)
                .HasMaxLength(25)
                .HasColumnName("salespersonName");
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.HasKey(e => e.StorageId).HasName("PRIMARY");

            entity.ToTable("storage");

            entity.HasIndex(e => e.CaskId, "FK_CaskStorage");

            entity.Property(e => e.StorageAnniversary)
                .HasMaxLength(25)
                .HasColumnName("Storage_Anniversary");
            entity.Property(e => e.StorageInventorySent)
                .HasMaxLength(25)
                .HasColumnName("Storage_Inventory_Sent");
            entity.Property(e => e.StorageReminder)
                .HasMaxLength(25)
                .HasColumnName("Storage_Reminder");

            entity.HasOne(d => d.Cask).WithMany(p => p.Storages)
                .HasForeignKey(d => d.CaskId)
                .HasConstraintName("FK_CaskStorage");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PRIMARY");

            entity.ToTable("supplier");

            entity.Property(e => e.SupplierId).HasColumnName("supplierId");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(25)
                .HasColumnName("supplierName");
        });

        modelBuilder.Entity<Transfer>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PRIMARY");

            entity.ToTable("transfers");

            entity.HasIndex(e => e.CaskId, "FK_casktransfer");

            entity.HasIndex(e => e.ToClientId, "FK_clienttotransfer");

            entity.HasIndex(e => e.FromClientId, "FK_clienttransfer");

            entity.Property(e => e.TransferId).HasColumnName("transferId");
            entity.Property(e => e.CaskId).HasColumnName("caskId");
            entity.Property(e => e.FromClientId).HasColumnName("From_Client_ID");
            entity.Property(e => e.ToClientId).HasColumnName("To_Client_ID");
            entity.Property(e => e.TransferDate)
                .HasColumnType("date")
                .HasColumnName("transferDate");

            entity.HasOne(d => d.Cask).WithMany(p => p.Transfers)
                .HasForeignKey(d => d.CaskId)
                .HasConstraintName("FK_casktransfer");

            entity.HasOne(d => d.FromClient).WithMany(p => p.TransferFromClients)
                .HasForeignKey(d => d.FromClientId)
                .HasConstraintName("FK_clienttransfer");

            entity.HasOne(d => d.ToClient).WithMany(p => p.TransferToClients)
                .HasForeignKey(d => d.ToClientId)
                .HasConstraintName("FK_clienttotransfer");
        });

        base.OnModelCreating(modelBuilder);
    }
}
