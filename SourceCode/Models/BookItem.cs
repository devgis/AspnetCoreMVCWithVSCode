using System;
using System.ComponentModel.DataAnnotations;

namespace Temp.Models
{
    public class BookItem
    {
        [Required(ErrorMessage="Please enter ID")]
        public string ID { get; set; }
        [Required(ErrorMessage="Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please enter Author")]
        public string Autor { get; set; }
    }
}
