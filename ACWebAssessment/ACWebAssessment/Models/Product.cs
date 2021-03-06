﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ACWebAssessment.Interfaces;

namespace ACWebAssessment.Models
{
    public class Product : BaseClass, IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}