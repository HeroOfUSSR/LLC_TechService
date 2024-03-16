using System;
using System.Collections.Generic;
using LLC_TechService_Context.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LLC_TechService_Context
{
    public partial class LLCTechServiceContext : DbContext
    {
        public LLCTechServiceContext()
        {
        }

        public LLCTechServiceContext(DbContextOptions<LLCTechServiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; } = null!;
        public virtual DbSet<Malfunction> Malfunctions { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Part> Parts { get; set; } = null!;
        public virtual DbSet<Priority> Priorities { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<UsedPart> UsedParts { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DDO84UQ; Database=LLC TechService; Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.IdEquipment);

                entity.Property(e => e.IdEquipment)
                    .HasColumnName("ID_Equipment");

                entity.Property(e => e.NameEquipment)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Equipment");

                entity.Property(e => e.SerialEquipment).HasColumnName("Serial_Equipment");

                entity.Property(e => e.TypeEquipment).HasColumnName("Type_Equipment");

                entity.HasOne(d => d.TypeEquipmentNavigation)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.TypeEquipment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_EquipmentType");
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.HasKey(e => e.IdEquipType);

                entity.ToTable("EquipmentType");

                entity.Property(e => e.IdEquipType)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_EquipType");

                entity.Property(e => e.NameEquipType)
                    .HasMaxLength(50)
                    .HasColumnName("Name_EquipType");
            });

            modelBuilder.Entity<Malfunction>(entity =>
            {
                entity.HasKey(e => e.IdMalfunction);

                entity.ToTable("Malfunction");

                entity.Property(e => e.IdMalfunction)
                    .HasColumnName("ID_Malfunction");

                entity.Property(e => e.DescMalfunction)
                    .HasMaxLength(50)
                    .HasColumnName("Desc_Malfunction");

                entity.Property(e => e.NameMalfunction)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Malfunction");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("Order");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("ID_Order");

                entity.Property(e => e.ClientOrder).HasColumnName("Client_Order");

                entity.Property(e => e.DateOrder)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Order");

                entity.Property(e => e.DescOrder)
                    .HasMaxLength(100)
                    .HasColumnName("Desc_Order");

                entity.Property(e => e.EquipmentOrder).HasColumnName("Equipment_Order");

                entity.Property(e => e.MalfunctionOrder).HasColumnName("Malfunction_Order");

                entity.Property(e => e.MasterOrder).HasColumnName("Master_Order");

                entity.Property(e => e.PriorityOrder).HasColumnName("Priority_Order");

                entity.Property(e => e.StatusOrder).HasColumnName("Status_Order");

                entity.HasOne(d => d.ClientOrderNavigation)
                    .WithMany(p => p.OrderClientOrderNavigations)
                    .HasForeignKey(d => d.ClientOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_User");

                entity.HasOne(d => d.EquipmentOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EquipmentOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Equipment");

                entity.HasOne(d => d.MalfunctionOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MalfunctionOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Malfunction");

                entity.HasOne(d => d.MasterOrderNavigation)
                    .WithMany(p => p.OrderMasterOrderNavigations)
                    .HasForeignKey(d => d.MasterOrder)
                    .HasConstraintName("FK_Order_User1");

                entity.HasOne(d => d.PriorityOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PriorityOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Priority");

                entity.HasOne(d => d.StatusOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Status");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasKey(e => e.IdPart);

                entity.ToTable("Part");

                entity.Property(e => e.IdPart)
                    .HasColumnName("ID_Part");

                entity.Property(e => e.AmountPart).HasColumnName("Amount_Part");

                entity.Property(e => e.DescPart)
                    .HasMaxLength(50)
                    .HasColumnName("Desc_Part");

                entity.Property(e => e.TitlePart)
                    .HasMaxLength(50)
                    .HasColumnName("Title_Part");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.HasKey(e => e.IdPriority);

                entity.ToTable("Priority");

                entity.Property(e => e.IdPriority)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Priority");

                entity.Property(e => e.NamePriority)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Priority");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasKey(e => e.IdReport);

                entity.ToTable("Report");

                entity.Property(e => e.IdReport)
                    .HasColumnName("ID_Report");

                entity.Property(e => e.CostReport)
                    .HasColumnType("money")
                    .HasColumnName("Cost_Report");

                entity.Property(e => e.DateReport)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Report");

                entity.Property(e => e.DescReport)
                    .HasMaxLength(50)
                    .HasColumnName("Desc_Report");

                entity.Property(e => e.MalfunctionReport).HasColumnName("Malfunction_Report");

                entity.Property(e => e.MasterReport).HasColumnName("Master_Report");

                entity.Property(e => e.OrderReport).HasColumnName("Order_Report");

                entity.Property(e => e.PartAmountReport).HasColumnName("PartAmount_Report");

                entity.Property(e => e.PartReport).HasColumnName("Part_Report");

                entity.HasOne(d => d.MalfunctionReportNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.MalfunctionReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Malfunction");

                entity.HasOne(d => d.MasterReportNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.MasterReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_User");

                entity.HasOne(d => d.OrderReportNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.OrderReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Order");

                entity.HasOne(d => d.PartReportNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.PartReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Part");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("Role");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Role");

                entity.Property(e => e.TitleRole)
                    .HasMaxLength(50)
                    .HasColumnName("Title_Role");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("Status");

                entity.Property(e => e.IdStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Status");

                entity.Property(e => e.NameStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Status");
            });

            modelBuilder.Entity<UsedPart>(entity =>
            {
                entity.HasKey(e => e.IdUsedParts);

                entity.Property(e => e.IdUsedParts)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_UsedParts");

                entity.Property(e => e.AmountUsedParts).HasColumnName("Amount_UsedParts");

                entity.Property(e => e.PartsId).HasColumnName("Parts_ID");

                entity.HasOne(d => d.Parts)
                    .WithMany(p => p.UsedParts)
                    .HasForeignKey(d => d.PartsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsedParts_Part");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_User");

                entity.Property(e => e.LoginUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Login_User");

                entity.Property(e => e.NameUser)
                    .HasMaxLength(50)
                    .HasColumnName("Name_User");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Password_User");

                entity.Property(e => e.PatronymicUser)
                    .HasMaxLength(50)
                    .HasColumnName("Patronymic_User");

                entity.Property(e => e.RoleUser).HasColumnName("Role_User");

                entity.Property(e => e.SurnameUser)
                    .HasMaxLength(50)
                    .HasColumnName("Surname_User");

                entity.HasOne(d => d.RoleUserNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
