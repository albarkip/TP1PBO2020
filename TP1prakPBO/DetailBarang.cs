using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1prakPBO
{
    class DetailBarang
    {
        public String namaBarang;
        public int harga;
        public String tipe;
        public DetailBarang(String nambar, int har, String tip) {
            this.namaBarang = nambar;
            this.harga = har;
            this.tipe = tip;
        }
        public DetailBarang() { }
    }
}
