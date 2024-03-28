using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BlueAnaliticsWarehouse.model;

public partial class BlueAnaliticsContext : DbContext
{
    public BlueAnaliticsContext()
    {
    }

    public BlueAnaliticsContext(DbContextOptions<BlueAnaliticsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<OrderingPriceHistory> OrderingPriceHistories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SellingPriceHistory> SellingPriceHistories { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WarProduct> WarProducts { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK_Supplier");

            entity.ToTable("contact");

            entity.Property(e => e.ContactId)
                .ValueGeneratedNever()
                .HasColumnName("contact_id");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .HasColumnName("contact_name");
        });

        modelBuilder.Entity<OrderingPriceHistory>(entity =>
        {
            entity.HasKey(e => e.PriceChangeId);

            entity.ToTable("ordering_price_history");

            entity.Property(e => e.PriceChangeId).HasColumnName("price_change_id");
            entity.Property(e => e.FromDt)
                .HasColumnType("datetime")
                .HasColumnName("from_dt");
            entity.Property(e => e.OrderingPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ordering_price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UntilDt)
                .HasColumnType("datetime")
                .HasColumnName("until_dt");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderingPriceHistories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ordering_price_history_product");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("product");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("product_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.PruductName)
                .HasMaxLength(50)
                .HasColumnName("pruduct_name");
            entity.Property(e => e.QtyPerUnit)
                .HasMaxLength(50)
                .HasColumnName("qty_per_unit");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_product_Supplier");
        });

        modelBuilder.Entity<SellingPriceHistory>(entity =>
        {
            entity.HasKey(e => e.ShChangeId);

            entity.ToTable("selling_price_history");

            entity.Property(e => e.ShChangeId)
                .ValueGeneratedNever()
                .HasColumnName("sh_change_id");
            entity.Property(e => e.FromDt)
                .HasColumnType("datetime")
                .HasColumnName("from_dt");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.SellingPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("selling_price");
            entity.Property(e => e.UntilDt)
                .HasColumnType("datetime")
                .HasColumnName("until_dt");

            entity.HasOne(d => d.Product).WithMany(p => p.SellingPriceHistories)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selling_price_history_product");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransId);

            entity.ToTable("transactions");

            entity.Property(e => e.TransId).HasColumnName("trans_id");
            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.TransDate)
                .HasComment("in or out ")
                .HasColumnType("datetime")
                .HasColumnName("trans_date");
            entity.Property(e => e.TransType)
                .HasMaxLength(10)
                .HasComment("in or out")
                .HasColumnName("trans_type");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.WarProdId).HasColumnName("war_prod_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_transactions_contact");

            entity.HasOne(d => d.User).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("FK_transactions_user");

            entity.HasOne(d => d.WarProd).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.WarProdId)
                .HasConstraintName("FK_transactions_war_products");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userId");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<WarProduct>(entity =>
        {
            entity.HasKey(e => e.WarProdId);

            entity.ToTable("war_products");

            entity.Property(e => e.WarProdId).HasColumnName("war_prod_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UnitsInStock).HasColumnName("units_in_stock");
            entity.Property(e => e.WarId).HasColumnName("war_id");

            entity.HasOne(d => d.Product).WithMany(p => p.WarProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_war_products_product");

            entity.HasOne(d => d.War).WithMany(p => p.WarProducts)
                .HasForeignKey(d => d.WarId)
                .HasConstraintName("FK_war_products_warehouse");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarId);

            entity.ToTable("warehouse");

            entity.Property(e => e.WarId)
                .ValueGeneratedNever()
                .HasColumnName("war_id");
            entity.Property(e => e.WarLocation)
                .HasMaxLength(50)
                .HasColumnName("war_location");
            entity.Property(e => e.WarName)
                .HasMaxLength(50)
                .HasColumnName("war_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
