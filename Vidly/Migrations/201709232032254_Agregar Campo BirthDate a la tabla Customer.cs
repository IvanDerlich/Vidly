namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarCampoBirthDatealatablaCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}