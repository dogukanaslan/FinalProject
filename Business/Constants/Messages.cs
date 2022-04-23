using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInValid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist = "Bu isimde bir ürün zaten var";
        public static string CategoryLimitExceded = "Kategori sayısı 15'den fazla olduğu için ürün eklenemez";
    }
}
