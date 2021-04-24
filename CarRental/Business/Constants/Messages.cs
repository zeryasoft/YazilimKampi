using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public static string CarImageAdded="Araba Resimleri Eklendi";
        public static string ImagesListed="Araba Resimleri Listelendi";
        public static string ImageDeleted="Araba Resmi Başarıyla Silindi";
        public static string CarImageUpdated="Araba resmi Başarıyla Güncellendi";
        public static string ImageNotFound="Silinecek Resim Bulunamadı";
        public static string ImageLimitExceeded= "Bir Arabaya Ait resim Sayısı Aşıldığı İçin Yeni Resim Eklenemiyor";
        public static string AuthorizationDenied="Erişim Engellendi";
        public static string AccessTokenCreated="Token Oluşturuldu";
        public static string UserRegistered="Kullanıcı Kaydı Gerçekleşti";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Şifre Hatası";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExists="Girilen Kullanıcı Mevcut";
    }
}
