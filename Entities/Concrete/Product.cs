using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    #region Description
    //Tüm katmanların entities katmanına erişmesi gerektiğinden public yaparız.
    //Public:Bu sınıfa diğer katmanlar da ulaşabilsin
    //Class'ların default erişim belirteçleri internal'dır.
    //Internal:Sadece entities erişebilir.
    //Short:Small int
    //Para birimleri decimal ile tutulur
    #endregion
    public class Product:IEntity        
    {

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
