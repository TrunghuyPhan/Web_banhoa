namespace banhoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoa : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");
            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");



            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");

            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");

            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");

            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");

            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");

            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");

            Sql("INSERT INTO Hoas (Ten,Hinh,GiaBan,SoLuongCon,MoTa) VALUES ('Hoa Lan Ho Diep Tim','/Images/tim1.jpg',200000,20,'Lorem Ipsum aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')");
        }

        public override void Down()
        {
        }
    }
}
