namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDept : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Depts", name: "Name", newName: "DeptName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Depts", name: "DeptName", newName: "Name");
        }
    }
}
