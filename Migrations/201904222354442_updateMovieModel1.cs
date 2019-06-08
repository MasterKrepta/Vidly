namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovieModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "QtyInStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "QtyInStock", c => c.Int(nullable: false));
        }
    }
}
