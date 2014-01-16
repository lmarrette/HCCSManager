namespace HCCSManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeMasters", "TerminationDate", c => c.DateTime());
            AlterColumn("dbo.EmployeeMasters", "LastChangeDate", c => c.DateTime());
            AlterColumn("dbo.EmployeeMasters", "NextTrainDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeMasters", "NextTrainDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeeMasters", "LastChangeDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeeMasters", "TerminationDate", c => c.DateTime(nullable: false));
        }
    }
}
