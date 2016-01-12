namespace PixLogic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSubjectMaik : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mail", "subject", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mail", "subject");
        }
    }
}
