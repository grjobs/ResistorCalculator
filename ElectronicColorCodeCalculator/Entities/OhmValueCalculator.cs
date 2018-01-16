using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicColorCodeCalculator.Entities
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        public List<ColorAttributes> colors = new List<ColorAttributes>();

        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            string ohmValue = "";
            int val;
            int finalValue;
            var bandA = colors.Find(x => x.code.Contains(bandAColor));
            var bandB = colors.Find(x => x.code.Contains(bandBColor));
            var bandC = colors.Find(x => x.code.Contains(bandCColor));
            var bandD = colors.Find(x => x.code.Contains(bandDColor));

            if (!string.IsNullOrEmpty(bandA.significantFigure))
            {
                ohmValue = bandA.significantFigure;
            }

            if (!string.IsNullOrEmpty(bandB.significantFigure))
            {
                ohmValue += bandB.significantFigure;
            }
            val = (int)(Convert.ToInt32(ohmValue) * bandC.multiplier);
            if (bandD.percent != null)
            {
                double percentage= Convert.ToDouble(bandD.percent)/100;
                double x;
                
               // finalValue = val + (val * ((Convert.ToInt32(bandD.percent)) / 100));
                finalValue = Convert.ToInt32(Convert.ToDouble(val) + (Convert.ToDouble(val) * percentage));
                //finalValue = Convert.ToInt32(x);
            }
            else
            {
                finalValue = Convert.ToInt32(Convert.ToDouble(val) + (Convert.ToDouble(val) * 0.20));//No band is 20%
            }

            return finalValue;
        }



        public OhmValueCalculator()
        {
            colors.Add(new ColorAttributes() { name = "Pink", code = "PK", significantFigure = null, multiplier = 0.001, percent = null });
            colors.Add(new ColorAttributes() { name = "Silver", code = "SR", significantFigure = null, multiplier = 0.01, percent = "10" });
            colors.Add(new ColorAttributes() { name = "Gold", code = "GD", significantFigure = null, multiplier = 0.1, percent = "5" });
            colors.Add(new ColorAttributes() { name = "Black", code = "BK", significantFigure = "0", multiplier = 1, percent = null });
            colors.Add(new ColorAttributes() { name = "Brown", code = "BN", significantFigure = "1", multiplier = 10, percent = "1" });
            colors.Add(new ColorAttributes() { name = "Red", code = "RD", significantFigure = "2", multiplier = 100, percent = "2" });
            colors.Add(new ColorAttributes() { name = "Orange", code = "OG", significantFigure = "3", multiplier = 1000, percent = null });
            colors.Add(new ColorAttributes() { name = "Yellow", code = "YE", significantFigure = "4", multiplier = 10000, percent = "5" });
            colors.Add(new ColorAttributes() { name = "Green", code = "GN", significantFigure = "5", multiplier = 100000, percent = "0.5" });
            colors.Add(new ColorAttributes() { name = "Blue", code = "BU", significantFigure = "6", multiplier = 1000000, percent = "0.25" });
            colors.Add(new ColorAttributes() { name = "Violet", code = "VT", significantFigure = "7", multiplier = 10000000, percent = "0.1" });
            colors.Add(new ColorAttributes() { name = "Gray", code = "GY", significantFigure = "8", multiplier = 100000000, percent = "0.05" });
            colors.Add(new ColorAttributes() { name = "White", code = "WH", significantFigure = "9", multiplier = 1000000000, percent = null });
        }

    }
}