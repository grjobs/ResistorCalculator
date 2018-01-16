using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicColorCodeCalculator.Entities
{
    public interface IOhmValueCalculator
    {
        int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }
}