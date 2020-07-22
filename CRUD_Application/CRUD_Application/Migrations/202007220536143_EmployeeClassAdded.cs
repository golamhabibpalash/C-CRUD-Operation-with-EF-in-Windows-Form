namespace CRUD_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Dob = c.String(maxLength: 50),
                        Address = c.String(maxLength: 255),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
