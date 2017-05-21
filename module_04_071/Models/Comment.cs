using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//本主題說明如何使用 System.ComponentModel.DataAnnotations 命名空間的屬性，指定資料模型中個別欄位的驗證。 這些屬性定義常用的驗證規則，例如範圍檢查及必填的欄位等。 System.ComponentModel.DataAnnotations 屬性會讓 MVC 提供用戶端和伺服器驗證檢查，您不需要撰寫其他程式碼。
//System.ComponentModel.DataAnnotations 屬性可搭配實體資料模型 (EDM)、LINQ to SQL 以及其他資料模型使用。 您也可以建立自訂驗證屬性。
using System.ComponentModel.DataAnnotations;

namespace module_04_071
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="subject 不可為空白")]
        public string subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string HtmlComment { get; set; }
        public int Price { get; set; }
        public bool IsApprove { get; set; }
    }
}
