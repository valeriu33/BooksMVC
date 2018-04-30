namespace BestMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_bithdate_samples : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1997/07/21' WHERE id = 1");
            Sql("UPDATE Customers SET BirthDate = '1998/07/21' WHERE id = 2");
            Sql("UPDATE Customers SET BirthDate = '1995/07/21' WHERE id = 3");
        }

        public override void Down()
        {
        }
    }
}
