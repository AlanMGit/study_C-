using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso_1931___Dev_App_Web_com_ASP.NET_MVC.Models
{
    public class CreateProductViewModel
    {

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(20, ErrorMessage = "Somente 20 chars.")]
        public string Title { get; set; }
    }
}