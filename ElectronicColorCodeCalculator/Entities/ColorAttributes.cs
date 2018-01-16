using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicColorCodeCalculator.Entities
{
    public class ColorAttributes
    {
        public string name { get; set; }
        public string code { get; set; }
        public double multiplier { get; set; }
        public string percent { get; set; }
        public string significantFigure { get; set; }
        public ColorAttributes()
        {
        }
        public IEnumerable<ColorAttributes> GetColors()
        {
            return new List<ColorAttributes>
                            {
                                    new ColorAttributes() { name = "Silver", code = "SR", significantFigure = null, multiplier = 0.01, percent = "10" },
            new ColorAttributes() { name = "Gold", code = "GD", significantFigure = null, multiplier = 0.1, percent = "5" },
            new ColorAttributes() { name = "Black", code = "BK", significantFigure = "0", multiplier = 1, percent = null },
            new ColorAttributes() { name = "Brown", code = "BN", significantFigure = "1", multiplier = 10, percent = "1" },
            new ColorAttributes() { name = "Red", code = "RD", significantFigure = "2", multiplier = 100, percent = "2" },
            new ColorAttributes() { name = "Orange", code = "OG", significantFigure = "3", multiplier = 1000, percent = null },
            new ColorAttributes() { name = "Yellow", code = "YE", significantFigure = "4", multiplier = 10000, percent = "5" },
            new ColorAttributes() { name = "Green", code = "GN", significantFigure = "5", multiplier = 100000, percent = "0.5" },
            new ColorAttributes() { name = "Blue", code = "BU", significantFigure = "6", multiplier = 1000000, percent = "0.25" },
            new ColorAttributes() { name = "Violet", code = "VT", significantFigure = "7", multiplier = 10000000, percent = "0.1" },
            new ColorAttributes() { name = "Gray", code = "GY", significantFigure = "8", multiplier = 100000000, percent = "0.05" },
            new ColorAttributes() { name = "White", code = "WH", significantFigure = "9", multiplier = 1000000000, percent = null }
     
                            };
        }
    }
}