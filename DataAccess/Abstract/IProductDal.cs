using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    #region
    //Veri operasyonlarının gerçekleştiği katmanın interface'idir.
    //Interface'in operasyonları publictir.Kendisi değil.
    #endregion
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

        
    }
}

//Code Refactoring = Kodun iyileştirilmesi
