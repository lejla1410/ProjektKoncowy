namespace NewProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCityReference : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MapsDB", "CityData_Id", c => c.Int());
            CreateIndex("dbo.MapsDB", "CityData_Id");
            AddForeignKey("dbo.MapsDB", "CityData_Id", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MapsDB", "CityData_Id", "dbo.Cities");
            DropIndex("dbo.MapsDB", new[] { "CityData_Id" });
            DropColumn("dbo.MapsDB", "CityData_Id");
        }
    }
}
