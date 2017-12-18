namespace DionIS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Narudzbas",
                c => new
                    {
                        NarudzbaId = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.NarudzbaId);
            
            DropTable("dbo.Velibors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Velibors",
                c => new
                    {
                        VeliborId = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        pera = c.String(),
                    })
                .PrimaryKey(t => t.VeliborId);
            
            DropTable("dbo.Narudzbas");
        }
    }
}
