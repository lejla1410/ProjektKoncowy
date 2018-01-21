namespace NewProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorMapsDBMarkers : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MapsDB");
            AlterColumn("dbo.MapsDB", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.MapsDB", "AtractionName", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.MapsDB", "Latitude", c => c.Double(nullable: false));
            AlterColumn("dbo.MapsDB", "Longitude", c => c.Double(nullable: false));
            AlterColumn("dbo.MapsDB", "City", c => c.String(maxLength: 50, unicode: false));
            AddPrimaryKey("dbo.MapsDB", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MapsDB");
            AlterColumn("dbo.MapsDB", "City", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.MapsDB", "Longitude", c => c.Single(nullable: false));
            AlterColumn("dbo.MapsDB", "Latitude", c => c.Single(nullable: false));
            AlterColumn("dbo.MapsDB", "AtractionName", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.MapsDB", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.MapsDB", new[] { "ID", "AtractionName", "Latitude", "Longitude", "City" });
        }
    }
}
