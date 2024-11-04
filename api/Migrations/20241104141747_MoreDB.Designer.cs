﻿// <auto-generated />
using System;
using IeltsWebLearn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20241104141747_MoreDB")]
    partial class MoreDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IeltsWebLearn.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("creatOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("IeltsWebLearn.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("HV")
                        .HasColumnType("int");

                    b.Property<string>("courseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseIMG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("courseSignUp")
                        .HasColumnType("int");

                    b.Property<DateTime>("endTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,1)");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("api.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("IdCourse")
                        .HasColumnType("int");

                    b.Property<int>("IdGV")
                        .HasColumnType("int");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("WeakTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("api.Models.CourseCurriculum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("IdCourse")
                        .HasColumnType("int");

                    b.Property<int?>("IdDOC")
                        .HasColumnType("int");

                    b.Property<int?>("IdImg")
                        .HasColumnType("int");

                    b.Property<int?>("IdVideo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseCurricula");
                });

            modelBuilder.Entity("api.Models.DayOfCourseCurriculum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseCurriculumId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("IDCourse")
                        .HasColumnType("int");

                    b.Property<string>("LinkQuiz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayHoc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseCurriculumId");

                    b.HasIndex("CourseId");

                    b.ToTable("DayOfCourseCurricula");
                });

            modelBuilder.Entity("api.Models.EmailLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailLogs");
                });

            modelBuilder.Entity("api.Models.HocVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CacKhoaHocDaHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdClass")
                        .HasColumnType("int");

                    b.Property<int>("IdCourse")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("courseId");

                    b.ToTable("HocViens");
                });

            modelBuilder.Entity("api.Models.ImgLinkCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("IdCourse")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("ImgLinkCourses");
                });

            modelBuilder.Entity("api.Models.ImgLinkCourseCurr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseCurriculumId")
                        .HasColumnType("int");

                    b.Property<int?>("DOC")
                        .HasColumnType("int");

                    b.Property<int?>("DayOfCourseCurriculumId")
                        .HasColumnType("int");

                    b.Property<int?>("IdCourseCurr")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCurriculumId");

                    b.HasIndex("DayOfCourseCurriculumId");

                    b.ToTable("ImgLinkCourseCurrs");
                });

            modelBuilder.Entity("api.Models.SignUpInfor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("creatOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailSt")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nameSt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneSt")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("SignUpInfors");
                });

            modelBuilder.Entity("api.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TaiKhoanHVID")
                        .HasColumnType("int");

                    b.Property<DateTime>("creatOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailSt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameSt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passSt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneSt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TaiKhoanHVID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("api.Models.TaiKhoanHV", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HocVienId")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idHV")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HocVienId");

                    b.ToTable("TaiKhoanHVs");
                });

            modelBuilder.Entity("api.Models.VideoLinkCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("IdCourse")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("VideoLinkCourses");
                });

            modelBuilder.Entity("api.Models.VideoLinkCourseCurr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseCurriculumId")
                        .HasColumnType("int");

                    b.Property<int?>("DayOfCourseCurriculumId")
                        .HasColumnType("int");

                    b.Property<int?>("IdCourseCurr")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCurriculumId");

                    b.HasIndex("DayOfCourseCurriculumId");

                    b.ToTable("VideoLinkCourseCurrs");
                });

            modelBuilder.Entity("IeltsWebLearn.Models.Comment", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany("Comments")
                        .HasForeignKey("CourseId");

                    b.HasOne("api.Models.Student", null)
                        .WithMany("Comments")
                        .HasForeignKey("StudentId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("api.Models.Class", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("api.Models.CourseCurriculum", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("api.Models.DayOfCourseCurriculum", b =>
                {
                    b.HasOne("api.Models.CourseCurriculum", "CourseCurriculum")
                        .WithMany("DayofCC")
                        .HasForeignKey("CourseCurriculumId");

                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");

                    b.Navigation("CourseCurriculum");
                });

            modelBuilder.Entity("api.Models.HocVien", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "course")
                        .WithMany()
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");
                });

            modelBuilder.Entity("api.Models.ImgLinkCourse", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany("courseIMGMore")
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("api.Models.ImgLinkCourseCurr", b =>
                {
                    b.HasOne("api.Models.CourseCurriculum", "CourseCurriculum")
                        .WithMany("ImgLinks")
                        .HasForeignKey("CourseCurriculumId");

                    b.HasOne("api.Models.DayOfCourseCurriculum", "DayOfCourseCurriculum")
                        .WithMany("IdIMGlink")
                        .HasForeignKey("DayOfCourseCurriculumId");

                    b.Navigation("CourseCurriculum");

                    b.Navigation("DayOfCourseCurriculum");
                });

            modelBuilder.Entity("api.Models.SignUpInfor", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("api.Models.Student", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany("Student")
                        .HasForeignKey("CourseId");

                    b.HasOne("api.Models.TaiKhoanHV", "TaiKhoanHV")
                        .WithMany()
                        .HasForeignKey("TaiKhoanHVID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("TaiKhoanHV");
                });

            modelBuilder.Entity("api.Models.TaiKhoanHV", b =>
                {
                    b.HasOne("api.Models.HocVien", "HocVien")
                        .WithMany()
                        .HasForeignKey("HocVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocVien");
                });

            modelBuilder.Entity("api.Models.VideoLinkCourse", b =>
                {
                    b.HasOne("IeltsWebLearn.Models.Course", "Course")
                        .WithMany("videoLinkCourses")
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("api.Models.VideoLinkCourseCurr", b =>
                {
                    b.HasOne("api.Models.CourseCurriculum", "CourseCurriculum")
                        .WithMany("VideoLinks")
                        .HasForeignKey("CourseCurriculumId");

                    b.HasOne("api.Models.DayOfCourseCurriculum", null)
                        .WithMany("IdlinkVideo")
                        .HasForeignKey("DayOfCourseCurriculumId");

                    b.Navigation("CourseCurriculum");
                });

            modelBuilder.Entity("IeltsWebLearn.Models.Course", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Student");

                    b.Navigation("courseIMGMore");

                    b.Navigation("videoLinkCourses");
                });

            modelBuilder.Entity("api.Models.CourseCurriculum", b =>
                {
                    b.Navigation("DayofCC");

                    b.Navigation("ImgLinks");

                    b.Navigation("VideoLinks");
                });

            modelBuilder.Entity("api.Models.DayOfCourseCurriculum", b =>
                {
                    b.Navigation("IdIMGlink");

                    b.Navigation("IdlinkVideo");
                });

            modelBuilder.Entity("api.Models.Student", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
