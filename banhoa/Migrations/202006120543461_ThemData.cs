namespace banhoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO KhachHangs (HOTEN,DIACHI,GIOITINH,SDT) VALUES ('Nguyen Van A','323/1 Nguyen Trai','Nam','0484638756')");
            Sql("INSERT INTO KhachHangs (HOTEN,DIACHI,GIOITINH,SDT) VALUES('Nguyen Van A','323/1 Nguyen Trai','Nam','0484638756')");
            Sql("INSERT INTO KhachHangs (HOTEN,DIACHI,GIOITINH,SDT)VALUES ('Nguyen Van A','323/1 Nguyen Trai','Nam','0484638756')");

           

        }
        
        public override void Down()
        {
        }
    }
}
