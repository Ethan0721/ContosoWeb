namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTableEnrollmentandOffice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grade = c.String(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                        CourseId_Id = c.Int(),
                        StudentId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId_Id)
                .ForeignKey("dbo.Student", t => t.StudentId_Id)
                .Index(t => t.CourseId_Id)
                .Index(t => t.StudentId_Id);
            
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId_Id", "dbo.Student");
            DropForeignKey("dbo.Enrollments", "CourseId_Id", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "StudentId_Id" });
            DropIndex("dbo.Enrollments", new[] { "CourseId_Id" });
            DropTable("dbo.OfficeAssignments");
            DropTable("dbo.Enrollments");
        }
    }
}
