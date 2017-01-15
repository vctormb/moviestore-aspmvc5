using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Hangover', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Die Hard', 2)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('The Terminator', 2)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Toy Story', 3)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Titanic', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
