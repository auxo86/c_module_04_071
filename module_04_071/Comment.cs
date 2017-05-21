using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
