using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WEILSI.Models
{
    public class Cat
    {
        [Required(ErrorMessage = "Please specify whether timid or not")]
        public bool? Timid { get; set; }
        [Required(ErrorMessage = "Please specify whether rash present")]
        public bool? Rash { get; set; }
        public bool? Fast { get; set; }



    }
}
