namespace PaperseedPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeDobNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserProfile", "Dob", c => c.DateTime(nullable:true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserProfile", "Dob", c => c.DateTime(nullable: false));
        }
    }
}
