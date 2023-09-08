namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeAttendances",
                c => new
                    {
                        AttendanceId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        AttendanceDate = c.DateTime(nullable: false),
                        IsPresent = c.Boolean(nullable: false),
                        IsAbsent = c.Boolean(nullable: false),
                        IsOffday = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmpoyeeName = c.String(nullable: false),
                        EmployeeCode = c.String(nullable: false),
                        EmployeeSalary = c.Double(nullable: false),
                        EmployeeSupervisor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeAttendances", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeAttendances", new[] { "EmployeeId" });
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeAttendances");
        }
    }
}
