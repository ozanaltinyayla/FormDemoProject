namespace FormDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormTableUpdated5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Form", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form", "Description", c => c.String());
            AlterColumn("dbo.Form", "Name", c => c.String());
        }
    }
}
