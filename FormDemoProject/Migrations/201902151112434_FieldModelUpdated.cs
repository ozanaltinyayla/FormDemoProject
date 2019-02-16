namespace FormDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FieldModelUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Field", "Form_Id", "dbo.Form");
            DropIndex("dbo.Field", new[] { "Form_Id" });
            RenameColumn(table: "dbo.Field", name: "Form_Id", newName: "FormId");
            AlterColumn("dbo.Field", "FormId", c => c.Int(nullable: false));
            CreateIndex("dbo.Field", "FormId");
            AddForeignKey("dbo.Field", "FormId", "dbo.Form", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Field", "FormId", "dbo.Form");
            DropIndex("dbo.Field", new[] { "FormId" });
            AlterColumn("dbo.Field", "FormId", c => c.Int());
            RenameColumn(table: "dbo.Field", name: "FormId", newName: "Form_Id");
            CreateIndex("dbo.Field", "Form_Id");
            AddForeignKey("dbo.Field", "Form_Id", "dbo.Form", "Id");
        }
    }
}
