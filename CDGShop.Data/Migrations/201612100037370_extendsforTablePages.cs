namespace CDGShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extendsforTablePages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Pages", "Name", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Pages", "Alias", c => c.String(nullable: false, maxLength: 256, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "Alias", c => c.String(nullable: false, maxLength: 250, unicode: false));
            AlterColumn("dbo.Pages", "Name", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.Pages", "Status");
            DropColumn("dbo.Pages", "MetaDescription");
            DropColumn("dbo.Pages", "MetaKeyword");
            DropColumn("dbo.Pages", "UpdatedBy");
            DropColumn("dbo.Pages", "UpdatedDate");
            DropColumn("dbo.Pages", "CreatedBy");
            DropColumn("dbo.Pages", "CreatedDate");
        }
    }
}
