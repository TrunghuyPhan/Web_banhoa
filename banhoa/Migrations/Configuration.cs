namespace banhoa.Migrations
{
    using banhoa.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<banhoa.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(banhoa.Models.ApplicationDbContext context)
        {
            

            context.hoas.AddOrUpdate(x => x.IdHoa,
                new Hoa()
                {
                    IdHoa = 1,
                    Ten = "Hoa A",
                    Gia = 100000,
                   
                    Hinh = "/images/tim1.jpg"
                 
                },
                  
                new Hoa()
                {
                    IdHoa = 2,
                    Ten = "Hoa B",
                    Gia = 100000,

                    Hinh = "/images/tim1.jpg"

                },
                new Hoa()
                {
                    IdHoa = 3,
                    Ten = "Hoa C",
                    Gia = 100000,

                    Hinh = "/images/tim1.jpg"

                }
                );
        }
    }
}
