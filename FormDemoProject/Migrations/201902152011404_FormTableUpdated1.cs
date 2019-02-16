namespace FormDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormTableUpdated1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false));
        }
    }
}
