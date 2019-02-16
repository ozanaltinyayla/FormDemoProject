namespace FormDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormTableUpdated4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form", "CreatedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form", "CreatedBy", c => c.String());
        }
    }
}
