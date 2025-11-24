using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_PBO.Models
{
    public class Pesanan
    {
        public int Id { get; set; }
        public int IdAkun { get; set; }
        public int IdLahan { get; set; }
        public decimal TotalHarga { get; set; }
        public int JangkaWaktuTahun { get; set; }
        public string Status { get; set; } 
        public DateTime TanggalPesan { get; set; }

        public string NamaPenyewa { get; set; }
        public string NamaLahan { get; set; }

        public Pesanan()
        {
            Status = "pending";
            TanggalPesan = DateTime.Now;
        }
    }
}
