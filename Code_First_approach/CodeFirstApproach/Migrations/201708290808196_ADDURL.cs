namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Depts", "ADDURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Depts", "ADDURL");
        }
    }
}
