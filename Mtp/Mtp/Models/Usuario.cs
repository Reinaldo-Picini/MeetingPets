using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mtp.Models
{
    public class Usuario
    {
        
            [Key]
            public int IdUsuario { get; set; }
            [Required]
            [Display(Name ="Nome")]
            public string Nome { get; set; }
            [Required]
            [Display(Name = "Sobrenome")]
            public string Sobrenome { get; set; }
            [Required]
            [Display(Name ="Telefone")]
            public string Telefone { get; set; }
            [Required]
            [Display(Name ="Cep")]
            public int Cep { get; set; }
            [Required]
            [Display(Name = "Logradouro")]
            public string Logradouro { get; set; }
            [Required]
            [Display(Name ="Numero")]
            public int Numero { get; set; }
            [Required]
            [Display(Name ="Bairro")]
            public string Bairro { get; set; }
            [Required]
            [Display(Name ="Cidade")]
            public string Cidade { get; set; }
            [Required]
            [Display(Name ="Estado")]
            public string Estado { get; set; }
            [Required]
            [Display(Name ="País")]
            public string Pais { get; set; }
            [Required]
            [Display(Name ="E-mail")]
            public string Email { get; set; }
            [Required]
            [Display(Name ="Senha")]
            public string Senha { get; set; }
            [Required]
            [Display(Name = "Digite a Senha Novamente")]
            public string ConfSenha { get; set; }
            
        
    }
}