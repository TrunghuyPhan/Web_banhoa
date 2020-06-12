using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace banhoa.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Hoa> hoas { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<DonHang> donHangs { get; set; }
        public DbSet<ChiTietDonHang> chiTietDonHangs { get; set; }
        
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
           
            return new ApplicationDbContext();
        }
    }
}