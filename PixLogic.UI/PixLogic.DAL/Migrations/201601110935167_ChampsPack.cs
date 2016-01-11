namespace PixLogic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChampsPack : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservable", "isPack", c => c.Boolean());
            AddColumn("dbo.Reservable", "temp", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservable", "isPack");
            DropColumn("dbo.Reservable", "temp");
        }
    }
}
