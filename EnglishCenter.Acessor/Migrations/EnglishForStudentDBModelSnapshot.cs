// <auto-generated />
using System;
using EnglisCenter.Accessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnglishCenter.Accessor.Migrations
{
    [DbContext(typeof(EnglishForStudentDB))]
    partial class EnglishForStudentDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("AccountId");

                    b.HasIndex("CourseId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeStudy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.DetailResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ok")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("ResultId")
                        .HasColumnType("int");

                    b.Property<string>("SelectedAns")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ResultId");

                    b.ToTable("DetailResults");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.MailBox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MailBoxes");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorectAns")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("ResultId");

                    b.HasIndex("AccountId");

                    b.HasIndex("TestId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Createsby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTest")
                        .HasColumnType("datetime2");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("TestName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<int>("TotalQuestion")
                        .HasColumnType("int");

                    b.HasKey("TestId");

                    b.HasIndex("CourseId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.TestDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestId");

                    b.ToTable("TestDetails");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.TimeTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdZoom")
                        .HasColumnType("int");

                    b.Property<int>("PassZoom")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CourseId");

                    b.ToTable("TimeTables");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Account", b =>
                {
                    b.HasOne("EnglishCenter.Accessor.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishCenter.Accessor.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.DetailResult", b =>
                {
                    b.HasOne("EnglishCenter.Accessor.Entities.Result", null)
                        .WithMany("DetailResults")
                        .HasForeignKey("ResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Result", b =>
                {
                    b.HasOne("EnglishCenter.Accessor.Entities.Account", "Account")
                        .WithMany("Results")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishCenter.Accessor.Entities.Test", "Test")
                        .WithMany("Results")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Test", b =>
                {
                    b.HasOne("EnglishCenter.Accessor.Entities.Course", null)
                        .WithMany("Tests")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.TestDetail", b =>
                {
                    b.HasOne("EnglishCenter.Accessor.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishCenter.Accessor.Entities.Test", null)
                        .WithMany("TestDetails")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.TimeTable", b =>
                {
                    b.HasOne("EnglishCenter.Accessor.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishCenter.Accessor.Entities.Course", null)
                        .WithMany("TimeTables")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Account", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Course", b =>
                {
                    b.Navigation("Tests");

                    b.Navigation("TimeTables");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Result", b =>
                {
                    b.Navigation("DetailResults");
                });

            modelBuilder.Entity("EnglishCenter.Accessor.Entities.Test", b =>
                {
                    b.Navigation("Results");

                    b.Navigation("TestDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
