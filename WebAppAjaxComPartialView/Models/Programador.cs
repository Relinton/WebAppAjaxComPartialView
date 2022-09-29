using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAjaxComPartialView.Models
{
    public class Programador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "O E-mail não é válido")]
        public string Email { get; set; }
    }
}
