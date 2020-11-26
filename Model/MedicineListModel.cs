﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine2.Model
{
    public class MedicineListModel
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
