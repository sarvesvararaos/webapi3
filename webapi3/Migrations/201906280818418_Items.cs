namespace webapi3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Items : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CName = c.String(),
                        itemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.itemId, cascadeDelete: true)
                .Index(t => t.itemId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        itemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                    })
                .PrimaryKey(t => t.itemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "itemId", "dbo.Items");
            DropIndex("dbo.Customers", new[] { "itemId" });
            DropTable("dbo.Items");
            DropTable("dbo.Customers");
        }
    }
}
