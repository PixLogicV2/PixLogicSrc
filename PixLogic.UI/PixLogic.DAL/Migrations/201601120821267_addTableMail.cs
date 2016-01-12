namespace PixLogic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableMail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mail",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        nameUser = c.String(),
                        nicknameUser = c.String(),
                        mailUser = c.String(),
                        text = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MailId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mail");
        }
    }
}
