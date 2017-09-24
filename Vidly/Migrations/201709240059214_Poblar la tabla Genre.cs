namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoblarlatablaGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Terror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Suspense')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romantic')");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres (Name) VALUES ('Science Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
