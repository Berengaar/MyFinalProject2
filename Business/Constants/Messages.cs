using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages        //static verildiğinde new'lenmez.Nokta ile direkt gelir
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductName = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Hata";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameAlreadyExist = "İsim kullanılmış";
        public static string CategoryLimitExceded = "Kategori adedi 15'i geçmemeli";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserRegistered = "Kullanıcı kayıt edildi.";
    }
}
