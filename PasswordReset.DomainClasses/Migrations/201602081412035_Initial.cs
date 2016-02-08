namespace PasswordReset.DomainClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KBAD_USERS_AD",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FullName = c.String(maxLength: 50, fixedLength: true),
                        LogOnName = c.String(maxLength: 50, fixedLength: true),
                        PhoneNumber = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
                //"dbo.KBAD_USERS_DB",
                //c => new
                //    {
                //        Id = c.Guid(nullable: false),
                //        FullName = c.String(maxLength: 50, fixedLength: true),
                //        LogOnName = c.String(maxLength: 50, fixedLength: true),
                //        PhoneNumber = c.Long(),
                //    })
                //.PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.KBAD_USERS_DB");
            DropTable("dbo.KBAD_USERS_AD");
        }
    }
}
