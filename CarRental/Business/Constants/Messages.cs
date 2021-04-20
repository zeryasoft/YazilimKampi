using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Arabalar Listelendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string RentalAdded = "Araba Kiralandı";
        public static string RentalUpdated = "Araba Kiralama Güncellendi";
        public static string RentalDeleted = "Kiralanan Araba Sistemden Silindi";
        public static string RentalsListed = "Kiralanan Araçlar Listelendi";
        public static string RentalReturnDateInvalid = "Kiralanmaya Çalışılan Araç Daha Önce Kiraya Verildi Henüz Teslim Alınmadı";
        internal static string CarImageAdded="Araba Resimleri Eklendi";
        internal static string ImagesListed="Araba Resimleri Listelendi";
        internal static string ImageDeleted="Araba Resmi Başarıyla Silindi";
        internal static string CarImageUpdated="Araba resmi Başarıyla Güncellendi";
        internal static string ImageNotFound="Silinecek Resim Bulunamadı";
        internal static string ImageLimitExceeded= "Bir Arabaya Ait resim Sayısı Aşıldığı İçin Yeni Resim Eklenemiyor";
    }
}
