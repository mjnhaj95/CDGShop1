namespace CDGShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class changekey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.ProductCategories", "Description", c => c.String());
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.ProductCategories", "Description");
        }

        public override void Down()
        {
            AddColumn("dbo.ProductCategories", "Description", c => c.String());
            AddColumn("dbo.Products", "Description", c => c.String());
            DropColumn("dbo.ProductCategories", "Description");
            DropColumn("dbo.Products", "Description");
        }
    }
}