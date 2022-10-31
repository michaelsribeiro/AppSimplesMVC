﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplierRegistrationMVC.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        [DisplayName("Nome do Produto")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        [DisplayName("Imagem")]
        public string Image { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Preço unitário")]
        public decimal Price { get; set; }

        [DisplayName("Data de cadastro")]
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }

        // Relations

        public Supplier Supplier { get; set; }

    }
}
