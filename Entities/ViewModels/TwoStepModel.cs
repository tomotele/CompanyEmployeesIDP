using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.IDP.Entities.ViewModels
{
    public class TwoStepModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string TwoFactorCode { get; set; }
        public bool RememberLogin { get; set; }
    }
}
