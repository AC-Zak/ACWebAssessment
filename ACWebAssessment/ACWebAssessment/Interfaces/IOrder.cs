using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACWebAssessment.Models;

namespace ACWebAssessment.Interfaces
{
    interface IOrder
    {
        DateTime OrderDate { get; set; }
        int OrderStatus { get; set; }
        int CustomerId { get; set; }
        List<BasketItem> Basket { get; set; }
        decimal FullPrice { get; }
        decimal PriceAfterDiscount { get; set; }
    }
}
