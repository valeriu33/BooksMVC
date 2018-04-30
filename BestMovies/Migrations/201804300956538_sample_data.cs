namespace BestMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sample_data : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO MembershipTypes VALUES('Pay as You Go',0, 0)");
            Sql("INSERT INTO MembershipTypes VALUES('Monthly',30, 0)");
            Sql("INSERT INTO MembershipTypes VALUES('Quarterly',90, 15)");
            Sql("INSERT INTO MembershipTypes VALUES('Annual',300 , 20)");

            Sql("INSERT INTO Customers VALUES('Valeriu','Seremet','false',1)");
            Sql("INSERT INTO Customers VALUES('Nikita','Cebotari','true', 2)");
            Sql("INSERT INTO Customers VALUES('Alexandru','Mamtev','false', 3)");

            Sql("INSERT INTO Movies VALUES('Game of Thrones','George R. Martin')");
            Sql("INSERT INTO Movies VALUES('Sherlok Holmes','Arthur Conan Doyle')");
            Sql("INSERT INTO Movies VALUES('C sharp','Anders Hejlsberg')");
        }
        
        public override void Down()
        {
        }
    }
}
