namespace DionIS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Kasa_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kasas",
                c => new
                    {
                        KasaId = c.Int(nullable: false, identity: true),
                        ImeRadnika = c.String(),
                        Racun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DatumIzdavanja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KasaId);
           
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Narudzbas");
            DropTable("dbo.Kasas");
        }
    }
}
