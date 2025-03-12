using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300038
{
    internal class KodeProduk
    {
        //private static Dictionary<String, String> getKodeProduk = new Dictionary<string, string>()
        //{
        //    {"Laptop", "E100"},
        //    {"Smartphone", "E101"},
        //    {"Tablet", "E102"},
        //    {"Headset", "E103"},
        //    {"Keyboard", "E104" },
        //    {"Mouse", "E105"},
        //    {"Printer", "E106"},
        //    {"Monitor", "E107"},
        //    {"Smartwatch", "E108"},
        //    {"Kamera", "E109" }
        //};

        //public static string getKodeProduk(String produk)
        //{
        //    return KodeProduk.ContainKey(produk) ? KodeProduk[produk] : "Kode Produk tidak ditemukan!";
        //}

        public enum Produk
        {
            Laptop, Smatphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera
        }

        public static string[] kodeProduk =
        {
            "E100","E101","E102","E103","E104","E105","E106","E107","E108","E109"
        };

        public static string getKodeProduk(Produk produk)
        {
            return kodeProduk[(int)produk];
        }



    }
}
