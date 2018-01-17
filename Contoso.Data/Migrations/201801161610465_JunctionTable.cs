namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JunctionTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "People_Id", c => c.Int());
            CreateIndex("dbo.Roles", "People_Id");
            AddForeignKey("dbo.Roles", "People_Id", "dbo.People", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "People_Id", "dbo.People");
            DropIndex("dbo.Roles", new[] { "People_Id" });
            DropColumn("dbo.Roles", "People_Id");
        }
    }
}
