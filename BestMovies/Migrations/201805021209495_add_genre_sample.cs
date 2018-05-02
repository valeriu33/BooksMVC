namespace BestMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_genre_sample : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES('Detective')");
            Sql("INSERT INTO Genres VALUES('Medieval')");
            Sql("INSERT INTO Genres VALUES('Programming')");

            Sql("UPDATE Movies SET ReleaseTime = '1995/07/21' WHERE id = 1");
            Sql("UPDATE Movies SET ReleaseTime = '1999/05/13' WHERE id = 2");
            Sql("UPDATE Movies SET ReleaseTime = '2000/09/26' WHERE id = 3");

            Sql("UPDATE Movies SET DateAdded = '2000/07/21' WHERE id = 1");
            Sql("UPDATE Movies SET DateAdded = '2003/06/21' WHERE id = 2");
            Sql("UPDATE Movies SET DateAdded = '2005/08/21' WHERE id = 3");

            Sql("UPDATE Movies SET NumbetInStok = 9 WHERE id = 1");
            Sql("UPDATE Movies SET NumbetInStok = 4 WHERE id = 2");
            Sql("UPDATE Movies SET NumbetInStok = 24 WHERE id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
