namespace StokOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        adi = c.String(unicode: false),
                        aktiflik = c.Boolean(nullable: false),
                        eklenmeTarihi = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        urunId = c.Int(nullable: false, identity: true),
                        kategoriId = c.Int(nullable: false),
                        adi = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        kodu = c.String(maxLength: 20, storeType: "nvarchar"),
                        qr = c.String(maxLength: 255, storeType: "nvarchar"),
                        birimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        kdvdahil = c.Boolean(nullable: false),
                        mevcutstok = c.Int(nullable: false),
                        kdvId = c.Int(nullable: false),
                        birim = c.Int(nullable: false),
                        olusturmaTarihi = c.DateTime(nullable: false, precision: 0),
                        aktiflik = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.urunId)
                .ForeignKey("dbo.Kategoris", t => t.kategoriId, cascadeDelete: true)
                .ForeignKey("dbo.KdvOranis", t => t.kdvId, cascadeDelete: true)
                .Index(t => t.kategoriId)
                .Index(t => t.kdvId);
            
            CreateTable(
                "dbo.KdvOranis",
                c => new
                    {
                        kdvId = c.Int(nullable: false, identity: true),
                        oran = c.Decimal(nullable: false, precision: 18, scale: 2),
                        guncellenmeTarihi = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.kdvId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "kdvId", "dbo.KdvOranis");
            DropForeignKey("dbo.Uruns", "kategoriId", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "kdvId" });
            DropIndex("dbo.Uruns", new[] { "kategoriId" });
            DropTable("dbo.KdvOranis");
            DropTable("dbo.Uruns");
            DropTable("dbo.Kategoris");
        }
    }
}
