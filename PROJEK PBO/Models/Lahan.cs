using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_PBO.Models
{
    public class Lahan
    {
        public int Id { get; set; }
        public string NamaLahan { get; set; }
        public string Lokasi { get; set; }
        public decimal LuasLahan { get; set; }
        public decimal HargaPerTahun { get; set; }
        public string Deskripsi { get; set; }
        public string Status { get; set; } 
        public DateTime CreatedAt { get; set; }

        public Lahan()
        {
            Status = "Tersedia";
            CreatedAt = DateTime.Now;
        }
    }
}
