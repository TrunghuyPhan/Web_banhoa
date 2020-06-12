using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace banhoa.Models
{
    public class KhachHang
    {
        [Key]
        public int IDKhachHang { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public ICollection<DonHang> DonHangs { get; set; }
    }
    public class DonHang
    {
        [Key]
        public int IDDonHang { get; set; }
        public int IDKhachHang { get; set; }
        public DateTime NgayBan { get; set; }
        public DateTime NgayGiao { get; set; }
        public int TongTien { get; set; }
        [ForeignKey("IDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
    public class ChiTietDonHang
    {
       [Key, Column(Order =1)]
        public int IDDonHang { get; set; }
        [Key, Column(Order =2)]
        public int IDHoa { get; set; }
        public int SoLuongMua { get; set; }
        public int Gia { get; set; }
        [ForeignKey("IDDonHang")]
        public virtual DonHang DonHang { get; set; }
        [ForeignKey("IDHoa")]
        public virtual Hoa Hoa { get; set; }

    }
}