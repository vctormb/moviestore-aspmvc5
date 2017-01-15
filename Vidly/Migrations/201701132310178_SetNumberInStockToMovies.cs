using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class SetNumberInStockToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberInStock = 0 WHERE id = 1");
            Sql("UPDATE Movies SET NumberInStock = 10 WHERE id = 2");
            Sql("UPDATE Movies SET NumberInStock = 50 WHERE id = 3");
            Sql("UPDATE Movies SET NumberInStock = 1 WHERE id = 4");
            Sql("UPDATE Movies SET NumberInStock = 5 WHERE id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
