using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintanceTime = "Bakım zamanı.";
        public static string ProductListed = "Ürün Listelendi";
        public static string ProductCountOfCategoryError ="Kategorideki ürün sayısı aşıldı.";
        public static string ProductNameAlreadyExists = "Aynı isimli ürün eklenemez.";
        public static string CheckIfCategoryLimitExist="Kategori sayısı aşıldı.";
        public static string AuthorizationDenied = "Yetkilendirme hatası";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
