using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ACWebAssessment.Interfaces;

namespace ACWebAssessment.Models
{
    public class OrderStatus : BaseClass, IOrderStatus
    {
        public string Description { get; set; }
    }
}