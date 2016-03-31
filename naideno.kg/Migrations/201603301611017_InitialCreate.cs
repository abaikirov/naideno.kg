namespace naideno.kg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SecondName = c.String(),
                        ThirdName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        UploadDate = c.DateTime(nullable: false),
                        Category = c.String(),
                        Status = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Universals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        UploadDate = c.DateTime(nullable: false),
                        Category = c.String(),
                        Status = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Universals", "UserID", "dbo.Users");
            DropForeignKey("dbo.Passports", "UserID", "dbo.Users");
            DropIndex("dbo.Universals", new[] { "UserID" });
            DropIndex("dbo.Passports", new[] { "UserID" });
            DropTable("dbo.Universals");
            DropTable("dbo.Users");
            DropTable("dbo.Passports");
        }
    }
}
