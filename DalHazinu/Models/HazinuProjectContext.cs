using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DalHazinu.Models
{
    public partial class HazinuProjectContext : DbContext
    {
        public HazinuProjectContext()
        {


        }

        public HazinuProjectContext(DbContextOptions<HazinuProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Apply> Apply { get; set; }
        public virtual DbSet<DetailsAsker> DetailsAsker { get; set; }
        public virtual DbSet<EducationalInstitution> EducationalInstitution { get; set; }
        public virtual DbSet<EducationalInstitutionsApplicant> EducationalInstitutionsApplicant { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<InstitutionsCategory> InstitutionsCategory { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<MatureCharacter> MatureCharacter { get; set; }
        public virtual DbSet<PatientDetails> PatientDetails { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StffDetails> StffDetails { get; set; }
        public virtual DbSet<StylesInstitution> StylesInstitution { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TheCauseReferral> TheCauseReferral { get; set; }
        public virtual DbSet<TreatmentDetails> TreatmentDetails { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WIN-PEQ4MMCHCT3;Database=HazinuProject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Neighborhood)
                    .HasColumnName("neighborhood")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.NumberApartment).HasColumnName("numberApartment");

                entity.Property(e => e.NumberHome).HasColumnName("numberHome");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Apply>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplyCausedId).HasColumnName("applyCausedId");

                entity.Property(e => e.AskerId).HasColumnName("askerId");

                entity.Property(e => e.DateNow)
                    .HasColumnName("dateNow")
                    .HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.ApplyCaused)
                    .WithMany(p => p.Apply)
                    .HasForeignKey(d => d.ApplyCausedId)
                    .HasConstraintName("FK_Apply_TheCauseReferral");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Apply)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Apply_User");
            });

            modelBuilder.Entity<DetailsAsker>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Affinity)
                    .HasColumnName("affinity")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.IdResone).HasColumnName("idResone");

                entity.Property(e => e.ReferredBy)
                    .HasColumnName("referredBy")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.IdResoneNavigation)
                    .WithMany(p => p.DetailsAsker)
                    .HasForeignKey(d => d.IdResone)
                    .HasConstraintName("FK_DetailsAsker_TheCauseReferral");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DetailsAsker)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_DetailsAsker_User");
            });

            modelBuilder.Entity<EducationalInstitution>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EducationKind)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EnotherName)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NumStudent).HasColumnName("numStudent");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.EducationalInstitution)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_EducationalInstitution_Address");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.EducationalInstitution)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_EducationalInstitution_InstitutionsCategory");

                entity.HasOne(d => d.IdStyleNavigation)
                    .WithMany(p => p.EducationalInstitution)
                    .HasForeignKey(d => d.IdStyle)
                    .HasConstraintName("FK_EducationalInstitution_stylesInstitution");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.EducationalInstitution)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_EducationalInstitution_Sector");
            });

            modelBuilder.Entity<EducationalInstitutionsApplicant>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.InstitutionId).HasColumnName("institutionId");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.EducationalInstitutionsApplicant)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_EducationalInstitutionsApplicant_EducationalInstitution");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EducationalInstitutionsApplicant)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_EducationalInstitutionsApplicant_User");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employees");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.JobId).HasColumnName("jobId");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_employees_User");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_employees_jobs");
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.ToTable("family");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChildrenNumber).HasColumnName("childrenNumber");

                entity.Property(e => e.FamilyDetails)
                    .HasColumnName("familyDetails")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ParentStatus)
                    .HasColumnName("parentStatus")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FilesName)
                    .HasColumnName("filesName")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.IdApply).HasColumnName("idApply");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.HasOne(d => d.IdApplyNavigation)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.IdApply)
                    .HasConstraintName("FK_Files_Apply");
            });

            modelBuilder.Entity<InstitutionsCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgeRange)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.DetailsCategory)
                    .HasColumnName("detailsCategory")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.ToTable("jobs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MatureCharacter>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Framwork)
                    .HasColumnName("framwork")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.IdApplicant).HasColumnName("idApplicant");

                entity.Property(e => e.IdMature).HasColumnName("idMature");

                entity.Property(e => e.PermissionContact).HasColumnName("permissionContact");

                entity.HasOne(d => d.IdApplicantNavigation)
                    .WithMany(p => p.MatureCharacter)
                    .HasForeignKey(d => d.IdApplicant)
                    .HasConstraintName("FK_MatureCharacter_Apply");

                entity.HasOne(d => d.IdMatureNavigation)
                    .WithMany(p => p.MatureCharacter)
                    .HasForeignKey(d => d.IdMature)
                    .HasConstraintName("FK_MatureCharacter_User");
            });

            modelBuilder.Entity<PatientDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("patientDetails");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.FamilyId).HasColumnName("familyId");

                entity.Property(e => e.FamilyPlace).HasColumnName("familyPlace");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsContact).HasColumnName("isContact");

                entity.Property(e => e.IsInstition).HasColumnName("isInstition");

                entity.Property(e => e.IsMatureCharacter).HasColumnName("isMatureCharacter");

                entity.Property(e => e.IsTherapeutic).HasColumnName("isTherapeutic");

                entity.Property(e => e.Mounth)
                    .HasColumnName("mounth")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SectorId).HasColumnName("sectorId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.YearBorn)
                    .HasColumnName("yearBorn")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PatientDetails)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_patientDetails_Address");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.PatientDetails)
                    .HasForeignKey(d => d.FamilyId)
                    .HasConstraintName("FK_patientDetails_family");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.PatientDetails)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_patientDetails_Sector");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PatientDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_patientDetails_User");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DetailsSector)
                    .HasColumnName("detailsSector")
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StffDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stffDetails");

                entity.Property(e => e.AnotherPhone)
                    .HasColumnName("anotherPhone")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EducationId).HasColumnName("educationId");

                entity.Property(e => e.JobId).HasColumnName("jobId");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.StffDetails)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("FK_stffDetails_EducationalInstitution");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.StffDetails)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_stffDetails_jobs");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StffDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_stffDetails_User");
            });

            modelBuilder.Entity<StylesInstitution>(entity =>
            {
                entity.ToTable("stylesInstitution");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.StyleDescripion)
                    .HasColumnName("styleDescripion")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("task");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descreption)
                    .HasColumnName("descreption")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.TaskName)
                    .HasColumnName("taskName")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TheCauseReferral>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descreption)
                    .HasColumnName("descreption")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TreatmentDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApplyId).HasColumnName("applyId");

                entity.Property(e => e.DateNow)
                    .HasColumnName("dateNow")
                    .HasColumnType("date");

                entity.Property(e => e.DateTask)
                    .HasColumnName("dateTask")
                    .HasColumnType("date");

                entity.Property(e => e.Documentation)
                    .HasColumnName("documentation")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NextStepId).HasColumnName("nextStepId");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.TaskId).HasColumnName("taskId");

                entity.HasOne(d => d.Apply)
                    .WithMany(p => p.TreatmentDetails)
                    .HasForeignKey(d => d.ApplyId)
                    .HasConstraintName("FK_TreatmentDetails_Apply");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TreatmentDetails)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TreatmentDetails_status");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TreatmentDetails)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TreatmentDetails_task");

                entity.HasOne(d => d.Therapist)
                    .WithMany(p => p.TreatmentDetails)
                    .HasForeignKey(d => d.TherapistId)
                    .HasConstraintName("FK_TreatmentDetails_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
