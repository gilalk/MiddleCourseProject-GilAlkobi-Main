using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.DB.Models
{
    public partial class SchoolManagementContext : DbContext
    {
        public SchoolManagementContext()
        {
        }

        public SchoolManagementContext(DbContextOptions<SchoolManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<CrewMember> CrewMembers { get; set; } = null!;
        public virtual DbSet<HomeWork> HomeWorks { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentClass> StudentClasses { get; set; } = null!;
        public virtual DbSet<StudentParent> StudentParents { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassName).HasMaxLength(20);

                entity.Property(e => e.CrewMemberId).HasColumnName("crewMemberId");

                entity.Property(e => e.SubjectName).HasMaxLength(50);

                entity.HasOne(d => d.CrewMember)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.CrewMemberId)
                    .HasConstraintName("FK_Class_CrewMembers");
            });

            modelBuilder.Entity<CrewMember>(entity =>
            {
                entity.Property(e => e.Adress).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CrewMembers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrewMembers_Accounts");
            });

            modelBuilder.Entity<HomeWork>(entity =>
            {
                entity.HasKey(e => e.HwId);

                entity.ToTable("HomeWork");

                entity.Property(e => e.HwId)
                    .ValueGeneratedNever()
                    .HasColumnName("HW_Id");

                entity.Property(e => e.Hwcontent).HasColumnName("HWContent");

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.HomeWorks)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_HomeWork_Student");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("Parent");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.WorkAddress).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Parent_Accounts");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergacyContactName).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Accounts");
            });

            modelBuilder.Entity<StudentClass>(entity =>
            {
                entity.ToTable("Student_Class");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Class_Class");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentClasses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Class_Student");
            });

            modelBuilder.Entity<StudentParent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student_parent");

                entity.HasOne(d => d.Parent)
                    .WithMany()
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamilyConnection_Parent");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamilyConnection_Student");
            });

            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<CrewMember>().HasData(
                new CrewMember { Id = 1, 
                    FirstName = "Yehuda", LastName = "Dan", 
                    Gender = "male", Role = "manager", 
                    Adress = "Rakefet 23", City = "Modi'in", 
                    Email = "yehudanmanage@gmail.com", AccountId = 1 });

            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, UserName = "yehudan", Password = "y1234" });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
