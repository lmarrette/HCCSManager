namespace HCCSManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        WorkdayReferenceId = c.String(),
                        TrainingType = c.Int(nullable: false),
                        DateAssigned = c.DateTime(nullable: false),
                        EmployeeMaster_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeMasters", t => t.EmployeeMaster_Id)
                .Index(t => t.EmployeeMaster_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkdayReferenceId = c.String(),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkdayId = c.String(),
                        UserId = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        WorkEmail = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        ManagementLevel = c.String(),
                        Status = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        LastChangeDate = c.DateTime(nullable: false),
                        InitialLoadDate = c.DateTime(nullable: false),
                        NextTrainDate = c.DateTime(nullable: false),
                        LastTransactionType = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.FieldChanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        WorkdayReferenceId = c.String(),
                        UserId = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        WorkEmail = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        ManagementLevel = c.String(),
                        DateSubmitted = c.DateTime(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.NewHires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        WorkdayReferenceId = c.String(),
                        DateSubmitted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Terminations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        WorkdayReferenceId = c.String(),
                        DateSubmitted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserIdChanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        WorkdayReferenceId = c.String(),
                        OldUserId = c.String(),
                        NewUserId = c.String(),
                        DateSubmitted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FieldChanges", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.EmployeeMasters", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Assignments", "EmployeeMaster_Id", "dbo.EmployeeMasters");
            DropIndex("dbo.FieldChanges", new[] { "Department_Id" });
            DropIndex("dbo.EmployeeMasters", new[] { "Department_Id" });
            DropIndex("dbo.Assignments", new[] { "EmployeeMaster_Id" });
            DropTable("dbo.UserIdChanges");
            DropTable("dbo.Terminations");
            DropTable("dbo.NewHires");
            DropTable("dbo.FieldChanges");
            DropTable("dbo.EmployeeMasters");
            DropTable("dbo.Departments");
            DropTable("dbo.Assignments");
        }
    }
}
