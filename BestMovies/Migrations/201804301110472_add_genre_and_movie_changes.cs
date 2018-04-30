namespace BestMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_genre_and_movie_changes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "ReleaseTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumbetInStok", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Genre_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropColumn("dbo.Movies", "Genre_Id");
            DropColumn("dbo.Movies", "NumbetInStok");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseTime");
            DropTable("dbo.Genres");
        }
    }
}
