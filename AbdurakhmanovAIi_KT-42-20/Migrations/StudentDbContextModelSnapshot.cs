﻿// <auto-generated />
using System;
using AbdurakhmanovAIi_KT_42_20.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AbdurakhmanovAIi_KT_42_20.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Идентификатор записи зачета");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                    b.Property<DateTime?>("DateOfTest")
                        .IsRequired()
                        .HasColumnType("datetime")
                        .HasColumnName("DateOfTest")
                        .HasComment("Дата проведения зачета");

                    b.Property<string>("ExamCondition")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("ExamCondition")
                        .HasComment("Состояние зачета (сдан/не сдан)");

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("ExamName")
                        .HasComment("Название зачета");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("ExamId")
                        .HasName("pk_Exam_Id");

                    b.HasIndex(new[] { "StudentId" }, "idx_Examfk_f_student_id");

                    b.HasIndex(new[] { "SubjectId" }, "idx_Examfk_f_subject_id");

                    b.ToTable("Exam", (string)null);
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Идентификатор записи зачета");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<DateTime?>("GradeDate")
                        .IsRequired()
                        .HasColumnType("datetime")
                        .HasColumnName("GradeDate")
                        .HasComment("Дата получения оценки");

                    b.Property<int?>("GradeNumber")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("GradeNumber")
                        .HasComment("Оценка");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("GradeId")
                        .HasName("pk_Grade_Id");

                    b.HasIndex(new[] { "StudentId" }, "idx_Gradefk_f_student_id");

                    b.HasIndex(new[] { "SubjectId" }, "idx_Gradefk_f_subject_id");

                    b.ToTable("Grade", (string)null);
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Идентификатор записи группы");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<string>("GroupJob")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("GroupJob")
                        .HasComment("Специальность группы");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("GroupName")
                        .HasComment("Название группы");

                    b.Property<string>("GroupYear")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("GroupYear")
                        .HasComment("Год поступления");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted")
                        .HasComment("Статус удаления");

                    b.Property<int?>("StudentQuantity")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("StudentQuantity")
                        .HasComment("Количество студентов в группе");

                    b.HasKey("GroupId")
                        .HasName("pk_Groups_Id");

                    b.ToTable("Groups", (string)null);
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Идентификатор записи студента");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int?>("GroupId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("GroupId")
                        .HasComment("Идентификатор группы");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted")
                        .HasComment("Статус удаления");

                    b.Property<string>("Midname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Midname")
                        .HasComment("Отчество студента");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Name")
                        .HasComment("Фамилия студента");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Surname")
                        .HasComment("Имя студента");

                    b.HasKey("StudentId")
                        .HasName("pk_Students_Id");

                    b.HasIndex(new[] { "GroupId" }, "idx_Students_fk_f_group_id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Идентификатор записи дисциплины");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted")
                        .HasComment("Статус удаления");

                    b.Property<string>("SubjectDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("SubjectDescription")
                        .HasComment("Направление дисциплины");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("SubjectName")
                        .HasComment("Название дисциплины");

                    b.HasKey("SubjectId")
                        .HasName("pk_Subject_Id");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Exam", b =>
                {
                    b.HasOne("AbdurakhmanovAIi_KT_42_20.Models.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_f_student_id");

                    b.HasOne("AbdurakhmanovAIi_KT_42_20.Models.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_f_subject_id");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Grade", b =>
                {
                    b.HasOne("AbdurakhmanovAIi_KT_42_20.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_f_student_id");

                    b.HasOne("AbdurakhmanovAIi_KT_42_20.Models.Subject", "Subject")
                        .WithMany("Grades")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_f_subject_id");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Student", b =>
                {
                    b.HasOne("AbdurakhmanovAIi_KT_42_20.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_group_id");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Student", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Grades");
                });

            modelBuilder.Entity("AbdurakhmanovAIi_KT_42_20.Models.Subject", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
