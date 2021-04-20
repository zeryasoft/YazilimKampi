using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountofCategoryError="Bir Kategoride En Fazla 10 Ürün Olabilir";
        public static string ProductNameAlreadyExists = "Benzer Ürün İsmi Zaten Mevcut";
        internal static string CategoryLimitExceed="Kategori Sayısı Aşıldığı için Yeni Ürün Eklenemiyor.";
        internal static SerializationInfo AuthorizationDenied;
    }
}
