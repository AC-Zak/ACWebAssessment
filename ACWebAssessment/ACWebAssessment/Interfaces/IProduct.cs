using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACWebAssessment.Interfaces
{
    interface IProduct
    {
        string Name { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
    }
}
