﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Harvin.Models {
    [Table("Cargos")]
    public class Cargo {
        [Key]
        public int cargoId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Display(Name = "Inativo")]
        public bool inativo { get; set; }
    }
}