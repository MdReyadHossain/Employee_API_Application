namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_column : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "Employee_EmployeeId" });
            AlterColumn("dbo.Employees", "Password", c => c.String());
            DropColumn("dbo.Employees", "Employee_EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Employee_EmployeeId", c => c.Int());
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.Employees", "Employee_EmployeeId");
            AddForeignKey("dbo.Employees", "Employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
    }
}
