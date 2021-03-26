using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    //static olanlar newlenemez, newlenmeye gerek duyulmasın diye static yaparız. Message diyip direkt çağırabiliriz
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string CategoryLimitExceded = "Katagori limiti aşıldığı için yeni ürün ekleyemezsiniz."

    }
}
