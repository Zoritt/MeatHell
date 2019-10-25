using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MH.Models
{
    public class Notify
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(100)")]
        public string Message { get; set; }
        public DateTime TimeStamp { get;set;}
    }
}
