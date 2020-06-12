using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace banhoa.Models
{
    public class Hoa
    {
        [Key]
        public int IdHoa { get; set; }
        public string Ten { get; set; }
        public int GiaBan { get; set; }
        public int SoLuongCon { get; set; }
        public string MoTa { get; set; }
        public string Hinh { get; set; }
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }

}