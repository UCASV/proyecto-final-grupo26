using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class ProCitasContext : DbContext
    {
        public ProCitasContext()
        {
        }

        public ProCitasContext(DbContextOptions<ProCitasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeexcabin> Employeexcabins { get; set; }
        public virtual DbSet<InfoVaccination> InfoVaccinations { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }
        public virtual DbSet<VaccinationPlace> VaccinationPlaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = ProCitas; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.Cabins)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABIN__id_direct__5812160E");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.ToTable("CITIZEN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateEffect)
                    .HasColumnType("date")
                    .HasColumnName("date_effect");

                entity.Property(e => e.DateWline)
                    .HasColumnType("date")
                    .HasColumnName("date_wline");

                entity.Property(e => e.Dui)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.IdDiseases).HasColumnName("id_diseases");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdInfoVaccination).HasColumnName("id_info_vaccination");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.IdSideEffects).HasColumnName("id_side_effects");

                entity.Property(e => e.Mail)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.NameCitizen)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nameCitizen");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.TimeEffect).HasColumnName("time_effect");

                entity.Property(e => e.TimeWline).HasColumnName("time_wline");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_cabi__4BAC3F29");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_dire__4D94879B");

                entity.HasOne(d => d.IdDiseasesNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdDiseases)
                    .HasConstraintName("FK__CITIZEN__id_dise__5070F446");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_empl__4AB81AF0");

                entity.HasOne(d => d.IdInfoVaccinationNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdInfoVaccination)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_info__4E88ABD4");

                entity.HasOne(d => d.IdInstitutionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdInstitution)
                    .HasConstraintName("FK__CITIZEN__id_inst__4CA06362");

                entity.HasOne(d => d.IdSideEffectsNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdSideEffects)
                    .HasConstraintName("FK__CITIZEN__id_side__4F7CD00D");
            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.ToTable("DIRECTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Municipality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("municipality");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("street");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASES");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Diseases)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("diseases");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.IdRecord).HasColumnName("id_record");

                entity.Property(e => e.IdTypeEmployee).HasColumnName("id_type_employee");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.NameEmployee)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nameEMPLOYEE");

                entity.Property(e => e.Passwordd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("passwordd");

                entity.Property(e => e.UserG)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("user_g");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_dir__534D60F1");

                entity.HasOne(d => d.IdRecordNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdRecord)
                    .HasConstraintName("FK__EMPLOYEE__id_rec__52593CB8");

                entity.HasOne(d => d.IdTypeEmployeeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdTypeEmployee)
                    .HasConstraintName("FK__EMPLOYEE__id_typ__5441852A");
            });

            modelBuilder.Entity<Employeexcabin>(entity =>
            {
                entity.HasKey(e => new { e.IdEmployee, e.IdCabin })
                    .HasName("PK__EMPLOYEE__44FD7D352EAF24B1");

                entity.ToTable("EMPLOYEEXCABIN");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Employeexcabins)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEEX__id_ca__571DF1D5");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Employeexcabins)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEEX__id_em__5629CD9C");
            });

            modelBuilder.Entity<InfoVaccination>(entity =>
            {
                entity.ToTable("INFO_VACCINATION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateAppointment1)
                    .HasColumnType("date")
                    .HasColumnName("date_appointment1");

                entity.Property(e => e.DateAppointment2)
                    .HasColumnType("date")
                    .HasColumnName("date_appointment2");

                entity.Property(e => e.IdVaccinationPlace).HasColumnName("id_vaccination_place");

                entity.Property(e => e.TimeAppointment1).HasColumnName("time_appointment1");

                entity.Property(e => e.TimeAppointment2).HasColumnName("time_appointment2");

                entity.HasOne(d => d.IdVaccinationPlaceNavigation)
                    .WithMany(p => p.InfoVaccinations)
                    .HasForeignKey(d => d.IdVaccinationPlace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INFO_VACC__id_va__5165187F");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("INSTITUTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdentifierNumber)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("identifier_number");

                entity.Property(e => e.NameInstitution)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nameINSTITUTION");
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.ToTable("RECORD");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateR)
                    .HasColumnType("date")
                    .HasColumnName("dateR");

                entity.Property(e => e.TimeR).HasColumnName("timeR");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SIDE_EFFECTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.SideEffects)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("side_effects");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.ToTable("TYPE_EMPLOYEE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.TypeEmployee1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("type_employee");
            });

            modelBuilder.Entity<VaccinationPlace>(entity =>
            {
                entity.ToTable("VACCINATION_PLACE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("place");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
