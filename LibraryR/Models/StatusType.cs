﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryR.Models
{
    public class StatusType
    {
        [Key]
        public int Id { get; set; }
        
        public string Type { get; set; }

    }
}
