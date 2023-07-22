using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UniTest.Model;

public partial class UniversityContext : DbContext
{
    public UniversityContext()
    {
    }

    public UniversityContext(DbContextOptions<UniversityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Guardian> Guardians { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SAGA\\SQLEXPRESS;Initial Catalog=university;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__courses__8F1EF7AE2A2675D0");

            entity.ToTable("courses");

            entity.Property(e => e.CourseId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("course_id");
            entity.Property(e => e.CourseField)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("course_field");
            entity.Property(e => e.CourseName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("course_name");
            entity.Property(e => e.CourseType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("course_type");
        });

        modelBuilder.Entity<Guardian>(entity =>
        {
            entity.HasKey(e => e.GuardianId).HasName("PK__guardian__AEFAF4A16B9C38E6");

            entity.ToTable("guardian");

            entity.Property(e => e.GuardianId)
                .ValueGeneratedNever()
                .HasColumnName("guardian_id");
            entity.Property(e => e.GuardianEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("guardian_email");
            entity.Property(e => e.GuardianFname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("guardian_fname");
            entity.Property(e => e.GuardianLname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("guardian_lname");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__students__2A33069AFB1D3EDF");

            entity.ToTable("students");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("student_id");
            entity.Property(e => e.CourseId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("course_id");
            entity.Property(e => e.GuardianId).HasColumnName("guardian_id");
            entity.Property(e => e.StudentDob)
                .HasColumnType("date")
                .HasColumnName("student_dob");
            entity.Property(e => e.StudentEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("student_email");
            entity.Property(e => e.StudentFname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("student_fname");
            entity.Property(e => e.StudentGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("student_gender");
            entity.Property(e => e.StudentLname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("student_lname");
            entity.Property(e => e.StudentNic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("student_nic");

            entity.HasOne(d => d.Course).WithMany(p => p.Students)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_students_courses");

            entity.HasOne(d => d.Guardian).WithMany(p => p.Students)
                .HasForeignKey(d => d.GuardianId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_Guardian");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tests");

            entity.Property(e => e.TestDate)
                .HasColumnType("date")
                .HasColumnName("test_date");
            entity.Property(e => e.TestId).HasColumnName("test_id");
            entity.Property(e => e.TestName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("test_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__B9BE370F54F9604F");

            entity.ToTable("users");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("user_email");
            entity.Property(e => e.UserFname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("user_fname");
            entity.Property(e => e.UserLevel).HasColumnName("user_level");
            entity.Property(e => e.UserLname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("user_lname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
