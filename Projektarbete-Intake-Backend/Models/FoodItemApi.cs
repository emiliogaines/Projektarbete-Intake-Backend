﻿using Projektarbete_Intake_Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projektarbete_Intake_Backend.Models
{
    public class FoodItemApi : FoodItem
    {
        public long UserId { get; set; }
        public string ApiData { get; set; }
    }
}
