using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages        //static verildiğinde new'lenmez.Nokta ile direkt gelir
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductName = "Ürün ismi geçersiz";
        internal static string MaintenanceTime="Sistem bakımda";
        internal static string ProductsListed="Ürünler Listelendi";
    }
}
