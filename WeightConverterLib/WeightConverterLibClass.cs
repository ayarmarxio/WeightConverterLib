using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightConverterLib
{
    public class WeightConverterLibClass
    {
        private double ouncesConverter = 0.035274;
        private double gramsConverter = 28.35;

        public WeightConverterLibClass()
        {

        }

        public double fromGramToOunces(double grams)
        {
            
            double ounces = grams * ouncesConverter ;
            return ounces;
        }

        public double fromOuncesToGrams(double ounces)
        {
            double grams = ounces * gramsConverter;
            return grams;
        }
    }
}
