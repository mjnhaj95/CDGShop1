namespace CDGShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContentToSilde : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sildes", "Content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sildes", "Content");
        }
    }
}
