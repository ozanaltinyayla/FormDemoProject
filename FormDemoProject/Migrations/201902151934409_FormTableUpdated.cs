namespace FormDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormTableUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "UserName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Password", c => c.String());
            AlterColumn("dbo.User", "UserName", c => c.String());
        }
    }
}
