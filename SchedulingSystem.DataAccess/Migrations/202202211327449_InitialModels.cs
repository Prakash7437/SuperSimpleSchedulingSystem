namespace SchedulingSystem.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        EnrolledDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.CourseID })
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "CourseID", "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "CourseID" });
            DropIndex("dbo.StudentCourses", new[] { "StudentID" });
            DropTable("dbo.Students");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Courses");
        }
    }
}
