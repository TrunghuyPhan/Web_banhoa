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
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(banhoa.Models.ApplicationDbContext context)
        {
           
            
            /*

            context.hoas.AddOrUpdate(x => x.IdHoa,
                new Hoa()
                {
                    IdHoa = 1,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                   MoTa="dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"
                 
                },
                  
                new Hoa()
                {
                    IdHoa = 2,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                    MoTa = "dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"

                },
                new Hoa()
                {
                    IdHoa = 3,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                    MoTa = "dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"
                },
                new Hoa()
                {
                    IdHoa = 4,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                    MoTa = "dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"

                },

                new Hoa()
                {
                    IdHoa = 5,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                    MoTa = "dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"

                },
                new Hoa()
                {
                    IdHoa = 6,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                    MoTa = "dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"

                },
                 new Hoa()
                 {
                     IdHoa = 7,
                     Ten = "Hoa A",
                     GiaBan = 100000,
                     MoTa = "dkfsdhfksjhdfjksdf",
                     Hinh = "/images/tim1.jpg"

                 },

                new Hoa()
                {
                    IdHoa = 8,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                    MoTa = "dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"

                },
                new Hoa()
                {
                    IdHoa = 9,
                    Ten = "Hoa A",
                    GiaBan = 100000,
                    MoTa = "dkfsdhfksjhdfjksdf",
                    Hinh = "/images/tim1.jpg"

                }
                );
            */
        }
    }
}
