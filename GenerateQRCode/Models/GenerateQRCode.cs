using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QRLGenerator.Models
{
    public class GenerateQRCodeModel
    {

        [Display(Name = "Enter Text")]
        public string QRCodeText { get; set; }
    }
}
