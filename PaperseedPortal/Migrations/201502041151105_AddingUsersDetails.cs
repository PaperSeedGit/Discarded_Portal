namespace PaperseedPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUsersDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "FirstName", c => c.String(maxLength: 100, unicode: false, storeType: "nvarchar"));
            AddColumn("dbo.UserProfile", "LastName", c => c.String(maxLength: 100, unicode: false, storeType: "nvarchar"));
            AddColumn("dbo.UserProfile", "Dob", c => c.DateTime(nullable: false));

            //CreateTable(
            //    "dbo.UserProfile",
            //    c => new
            //        {
            //            UserId = c.Int(nullable: false, identity: true),
            //            UserName = c.String(unicode: false),
            //            FirstName = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
            //            LastName = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
            //            Dob = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "Dob");
            DropColumn("dbo.UserProfile", "LastName");
            DropColumn("dbo.UserProfile", "FirstName");
        }
    }
}
