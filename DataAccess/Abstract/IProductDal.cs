using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Productla ilgili veri tabanımda yapacağım operasyonlar
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
