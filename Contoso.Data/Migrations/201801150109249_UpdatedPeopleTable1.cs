namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPeopleTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "IsLocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.People", "LastLockedDateTime", c => c.DateTime());
            AddColumn("dbo.People", "AddressLine1", c => c.String());
            AddColumn("dbo.People", "AddressLine2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "AddressLine2");
            DropColumn("dbo.People", "AddressLine1");
            DropColumn("dbo.People", "LastLockedDateTime");
            DropColumn("dbo.People", "IsLocked");
        }
    }
}
