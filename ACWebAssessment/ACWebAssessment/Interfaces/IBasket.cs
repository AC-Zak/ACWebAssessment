using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACWebAssessment.Models;

namespace ACWebAssessment.Interfaces
{
    interface IBasket
    {
        List<BasketItem> BasketItems { get; set; }
    }
}
