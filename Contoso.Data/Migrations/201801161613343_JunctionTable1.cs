namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JunctionTable1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "People_Id", "dbo.People");
            DropIndex("dbo.Roles", new[] { "People_Id" });
            CreateTable(
                "dbo.PeopleRoles",
                c => new
                    {
                        People_Id = c.Int(nullable: false),
                        Roles_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.People_Id, t.Roles_Id })
                .ForeignKey("dbo.People", t => t.People_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Roles_Id, cascadeDelete: true)
                .Index(t => t.People_Id)
                .Index(t => t.Roles_Id);
            
            DropColumn("dbo.Roles", "People_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "People_Id", c => c.Int());
            DropForeignKey("dbo.PeopleRoles", "Roles_Id", "dbo.Roles");
            DropForeignKey("dbo.PeopleRoles", "People_Id", "dbo.People");
            DropIndex("dbo.PeopleRoles", new[] { "Roles_Id" });
            DropIndex("dbo.PeopleRoles", new[] { "People_Id" });
            DropTable("dbo.PeopleRoles");
            CreateIndex("dbo.Roles", "People_Id");
            AddForeignKey("dbo.Roles", "People_Id", "dbo.People", "Id");
        }
    }
}
