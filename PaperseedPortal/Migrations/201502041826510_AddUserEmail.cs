namespace PaperseedPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Email", c => c.String(unicode: false, nullable:true, maxLength:50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "Email");
        }
    }
}
