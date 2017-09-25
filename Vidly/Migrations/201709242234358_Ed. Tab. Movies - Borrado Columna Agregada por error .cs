namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EdTabMoviesBorradoColumnaAgregadaporerror : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
