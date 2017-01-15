using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AlterNumerInStockToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumerInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NumerInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
