using SupplierRegistrationMVC.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SupplierRegistrationMVC.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 11)]
        [DisplayName("Documento CPF/CNPJ")]
        public string Document { get; set; }

        public SupplierType SupplierType { get; private set; }
        public Address Address { get; set; }


        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        // Relations

        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
