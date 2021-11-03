using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SFDL.Entities
{
    public partial class _211004restonnetdemoContext : DbContext
    {
        public _211004restonnetdemoContext()
        {
        }

        public _211004restonnetdemoContext(DbContextOptions<_211004restonnetdemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<OrderList> OrderLists { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CusCustomerId)
                    .HasName("cus_PK");

                entity.ToTable("Customer");

                entity.Property(e => e.CusCustomerId).HasColumnName("cus_customerID");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("customer_address");

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("customer_email");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("customer_phone");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.HasKey(e => e.LineItemnameId)
                    .HasName("lin_PK");

                entity.ToTable("LineItem");

                entity.Property(e => e.LineItemnameId)
                    .ValueGeneratedNever()
                    .HasColumnName("line_itemnameID");

                entity.Property(e => e.LineItemquantity).HasColumnName("line_itemquantity");

                entity.Property(e => e.LineOrderListId).HasColumnName("line_orderListID");

                entity.Property(e => e.LineStoreId).HasColumnName("line_storeID");

                entity.HasOne(d => d.LineItemname)
                    .WithOne(p => p.LineItem)
                    .HasForeignKey<LineItem>(d => d.LineItemnameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lin_pro_FK");

                entity.HasOne(d => d.LineOrderList)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.LineOrderListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lin_ord_FK");

                entity.HasOne(d => d.LineStore)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.LineStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lin_sto_FK");
            });

            modelBuilder.Entity<OrderList>(entity =>
            {
                entity.HasKey(e => e.OrderOrderListId)
                    .HasName("ord_PK");

                entity.ToTable("OrderList");

                entity.Property(e => e.OrderOrderListId).HasColumnName("order_orderListID");

                entity.Property(e => e.OrderCustomerId).HasColumnName("order_customerID");

                entity.Property(e => e.OrderStoreId).HasColumnName("order_storeID");

                entity.Property(e => e.OrderTotalprice)
                    .HasColumnType("money")
                    .HasColumnName("order_totalprice")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OrderCustomer)
                    .WithMany(p => p.OrderLists)
                    .HasForeignKey(d => d.OrderCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ord_cus_FK");

                entity.HasOne(d => d.OrderStore)
                    .WithMany(p => p.OrderLists)
                    .HasForeignKey(d => d.OrderStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ord_sto_FK");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductProductnameId)
                    .HasName("pro_PK");

                entity.ToTable("Product");

                entity.Property(e => e.ProductProductnameId).HasColumnName("product_productnameID");

                entity.Property(e => e.ProductCategory)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("product_category");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("product_description");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("money")
                    .HasColumnName("product_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.StoreStoreId).HasColumnName("store_storeID");

                entity.HasOne(d => d.StoreStore)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StoreStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pro_sto_FK");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.HasKey(e => e.StoreStoreId)
                    .HasName("sto_PK");

                entity.ToTable("StoreFront");

                entity.HasIndex(e => e.StoreAddress, "sto_UC_address")
                    .IsUnique();

                entity.HasIndex(e => e.StoreName, "sto_UC_name")
                    .IsUnique();

                entity.Property(e => e.StoreStoreId).HasColumnName("store_storeID");

                entity.Property(e => e.StoreAddress)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("store_address");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("store_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
