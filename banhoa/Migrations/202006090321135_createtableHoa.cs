namespace banhoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtableHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hoas",
                c => new
                    {
                        IdHoa = c.Int(nullable: false, identity: true),
                        Ten = c.String(),
                        Gia = c.Int(nullable: false),
                        Hinh = c.String(),
                    })
                .PrimaryKey(t => t.IdHoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hoas");
        }
    }
}
