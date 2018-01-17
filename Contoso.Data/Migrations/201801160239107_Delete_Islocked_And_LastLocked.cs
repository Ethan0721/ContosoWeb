namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Islocked_And_LastLocked : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "IsLocked");
            DropColumn("dbo.People", "LastLockedDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "LastLockedDateTime", c => c.DateTime());
            AddColumn("dbo.People", "IsLocked", c => c.Boolean(nullable: false));
        }
    }
}
