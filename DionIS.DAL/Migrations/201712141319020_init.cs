namespace DionIS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Narudzbas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Narudzbas",
                c => new
                    {
                        NarudzbaId = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.NarudzbaId);
            
        }
    }
}
