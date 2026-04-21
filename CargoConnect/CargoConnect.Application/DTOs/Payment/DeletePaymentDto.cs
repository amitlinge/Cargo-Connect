using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.DTOs.Payment
{
    internal class DeletePaymentDto
    {
        [Required]
        public Guid Id { get; set; }
    }
}
