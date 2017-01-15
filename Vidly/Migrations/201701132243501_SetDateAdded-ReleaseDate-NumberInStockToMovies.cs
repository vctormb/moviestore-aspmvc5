using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class SetDateAddedReleaseDateNumberInStockToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET DateAdded='10/02/2011', ReleaseDate='01/02/2010', NumerInStock=5 WHERE id=1");
            Sql("UPDATE Movies SET DateAdded='01/03/2012', ReleaseDate='02/03/1999', NumerInStock=10 WHERE id=2");
            Sql("UPDATE Movies SET DateAdded='02/03/2013', ReleaseDate='03/01/1969', NumerInStock=1 WHERE id=3");
            Sql("UPDATE Movies SET DateAdded='04/04/2014', ReleaseDate='04/01/2001', NumerInStock=0 WHERE id=4");
            Sql("UPDATE Movies SET DateAdded='11/04/2015', ReleaseDate='05/01/2005', NumerInStock=2 WHERE id=5");
        }
        
        public override void Down()
        {
        }
    }
}
