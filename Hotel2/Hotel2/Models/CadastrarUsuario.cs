using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class CadastrarUsuario
    {
        [Key]
        public int id { get; set; }

        public String login { get; set; }

        public String senha { get; set; }

        public String nome { get; set; }

        public String email { get; set; }

        [DisplayFormat(DataFormatString = "{0000-0000-0000-0000}")]
        public String cartao { get; set; }

        public int codigoseg { get; set; }
    }
}