namespace naideno.kg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassportMatchIDProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passports", "MatchID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Passports", "MatchID");
        }
    }
}
