namespace PixLogic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managers", "name", c => c.String());
            AddColumn("dbo.Managers", "nickname", c => c.String());
            AddColumn("dbo.Managers", "phone", c => c.String());
            AddColumn("dbo.Managers", "pseudo", c => c.String());
            AddColumn("dbo.Managers", "mdp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managers", "name");
            DropColumn("dbo.Managers", "nickname");
            DropColumn("dbo.Managers", "phone");
            DropColumn("dbo.Managers", "pseudo");
            DropColumn("dbo.Managers", "mdp");
        }
    }
}
