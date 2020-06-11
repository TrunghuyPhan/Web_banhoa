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

                },
                new Hoa()
                {
                    IdHoa = 4,
                    Ten = "Hoa D",
                    Gia = 100000,

                    Hinh = "/images/tim1.jpg"

                },

                new Hoa()
                {
                    IdHoa = 5,
                    Ten = "Hoa E",
                    Gia = 100000,

                    Hinh = "/images/tim1.jpg"

                },
                new Hoa()
                {
                    IdHoa = 6,
                    Ten = "Hoa F",
                    Gia = 100000,

                    Hinh = "/images/tim1.jpg"

                },
                 new Hoa()
                 {
                     IdHoa = 7,
                     Ten = "Hoa G",
                     Gia = 100000,

                     Hinh = "/images/tim1.jpg"

                 },

                new Hoa()
                {
                    IdHoa = 8,
                    Ten = "Hoa H",
                    Gia = 100000,

                    Hinh = "/images/tim1.jpg"

                },
                new Hoa()
                {
                    IdHoa = 9,
                    Ten = "Hoa K",
                    Gia = 100000,

                    Hinh = "/images/tim1.jpg"

                }
                );
        }
    }
}
