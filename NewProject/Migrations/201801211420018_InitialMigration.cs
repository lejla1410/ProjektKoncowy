namespace NewProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MapsDB",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        AtractionName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Latitude = c.Single(nullable: false),
                        Longitude = c.Single(nullable: false),
                        City = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID, t.AtractionName, t.Latitude, t.Longitude, t.City });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MapsDB");
        }
    }
}
