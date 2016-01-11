namespace PixLogic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManagerInLog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Log", "managerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Log", "managerName");
        }
    }
}
