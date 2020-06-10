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
        public int Gia { get; set; }
        public string Hinh { get; set; }
    }
}