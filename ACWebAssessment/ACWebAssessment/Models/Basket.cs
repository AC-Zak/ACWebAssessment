using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ACWebAssessment.Interfaces;

namespace ACWebAssessment.Models
{
    public class Basket : BaseClass, IBasket
    {
        public List<BasketItem> BasketItems { get ; set; }
    }
}