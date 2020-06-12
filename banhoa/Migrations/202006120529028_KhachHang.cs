namespace banhoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDonHangs",
                c => new
                    {
                        IDDonHang = c.Int(nullable: false),
                        IDHoa = c.Int(nullable: false),
                        SoLuongMua = c.Int(nullable: false),
                        Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDDonHang)
                .PrimaryKey(t => t.IDHoa)
                .ForeignKey("dbo.DonHangs", t => t.IDDonHang)
                .ForeignKey("dbo.Hoas", t => t.IDHoa, cascadeDelete: true)
                .Index(t => t.IDDonHang)
                .Index(t => t.IDHoa);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        IDDonHang = c.Int(nullable: false, identity: true),
                        IDKhachHang = c.Int(nullable: false),
                        NgayBan = c.DateTime(nullable: false),
                        NgayGiao = c.DateTime(nullable: false),
                        TongTien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDDonHang)
                .ForeignKey("dbo.KhachHangs", t => t.IDKhachHang, cascadeDelete: true)
                .Index(t => t.IDKhachHang);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        IDKhachHang = c.Int(nullable: false, identity: true),
                        HoTen = c.String(nullable: false),
                        DiaChi = c.String(nullable: true),
                        GioiTinh = c.String(nullable: true),
                        SDT = c.String(nullable: true),
                    })
                .PrimaryKey(t => t.IDKhachHang);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDonHangs", "IDHoa", "dbo.Hoas");
            DropForeignKey("dbo.DonHangs", "IDKhachHang", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDonHangs", "IDDonHang", "dbo.DonHangs");
            DropIndex("dbo.DonHangs", new[] { "IDKhachHang" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "IDHoa" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "IDDonHang" });
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.ChiTietDonHangs");
        }
    }
}
