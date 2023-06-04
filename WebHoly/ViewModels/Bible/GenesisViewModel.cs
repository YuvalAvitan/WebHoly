using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebHoly.ViewModels.Bible
{
    public class GenesisViewModel
    {
        public List<SelectListItem> Perks { get; set; }
        [Required(ErrorMessage = @"*Required")]
        public int Perk { get; set; }
    }
}
