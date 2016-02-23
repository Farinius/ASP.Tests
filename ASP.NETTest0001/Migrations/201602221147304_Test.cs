namespace ASP.NETTest0001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        ProductTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeID, cascadeDelete: true)
                .Index(t => t.ProductTypeID);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ProductTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductTypeID", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductTypeID" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
