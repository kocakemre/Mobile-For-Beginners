﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Counties : Base
    {
        public string CountyName { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public Cities Cities { get; set; }
    }
}
