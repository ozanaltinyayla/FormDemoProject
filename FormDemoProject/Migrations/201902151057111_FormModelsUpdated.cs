namespace FormDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormModelsUpdated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Field",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Required = c.Boolean(nullable: false),
                        DataTypeId = c.Int(nullable: false),
                        Form_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataType", t => t.DataTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Form", t => t.Form_Id)
                .Index(t => t.DataTypeId)
                .Index(t => t.Form_Id);
            
            CreateTable(
                "dbo.Form",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Field", "Form_Id", "dbo.Form");
            DropForeignKey("dbo.Field", "DataTypeId", "dbo.DataType");
            DropIndex("dbo.Field", new[] { "Form_Id" });
            DropIndex("dbo.Field", new[] { "DataTypeId" });
            DropTable("dbo.Form");
            DropTable("dbo.Field");
            DropTable("dbo.DataType");
        }
    }
}
