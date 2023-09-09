namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login_table_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Logins", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            AddColumn("dbo.Employees", "Employee_EmployeeId", c => c.Int());
            CreateIndex("dbo.Employees", "Employee_EmployeeId");
            AddForeignKey("dbo.Employees", "Employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "EmployeeId", "dbo.Logins");
            DropForeignKey("dbo.Employees", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Tokens", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "Employee_EmployeeId" });
            DropColumn("dbo.Employees", "Employee_EmployeeId");
            DropTable("dbo.Tokens");
            DropTable("dbo.Logins");
        }
    }
}
