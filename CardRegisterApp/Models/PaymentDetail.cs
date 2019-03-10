using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardRegisterApp.API.Models
{
    public class PaymentDetail
    {
        //Payment Id
        [Key]
        public int PMId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; } //Format: MM/YY
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}
