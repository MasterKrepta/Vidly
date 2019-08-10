namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatMovieClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "QtyInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "QtyInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
