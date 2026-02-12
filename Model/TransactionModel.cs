using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_besar_pbo_baihaqi_zidan.Model
{
    public class TransactionModel
    {
        public int IdTransaksi { get; set; }
        public int IdUser { get; set; }
        public string IdPlayer { get; set; } // ID In-Game Player
        public string ServerId { get; set; } // Server ID In-Game
        public string Item { get; set; }
        public int Harga { get; set; }
        public DateTime Tanggal { get; set; }
        public string Status { get; set; }
        public string Game { get; set; } // Nama Game (ML, PUBG, dll)
    }
}
