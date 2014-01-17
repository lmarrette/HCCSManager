namespace HCCSManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStaging : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkdayId = c.String(),
                        UserId = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        WorkEmail = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        Department = c.String(),
                        ManagementLevel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stagings");
        }
    }
}
