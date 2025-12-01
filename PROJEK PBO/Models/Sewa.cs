using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_PBO.Models
{
    public class Sewa
    {
        public int IdSewa { get; set; }
        public string StatusSewa { get; set; }
        public DateTime TanggalSewa { get; set; }
        public int JangkaWaktu { get; set; }
        public int IdLahan { get; set; }
        public int IdUser { get; set; }
    }
}
