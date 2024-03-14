using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2180608005_LeNguyenNhatTan.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="phải nhập tên sách!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "phải nhập tên tác giả!")]
        [StringLength(50, ErrorMessage ="Tên không quá 50 ký tự!")]
        public string Author { get; set; }        
        public int PublicYear { get; set; }
        public double Price { get; set; }
        public string Cover { get; set; }
    }
}