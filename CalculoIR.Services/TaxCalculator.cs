using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoIR.Services.Interfaces;

namespace CalculoIR.Services
{
    public class TaxCalculator : ITaxCalculator
    {        
        public double TaxCalculation(double value)
        {
            return value * Aliquot(value) - Deduction(value);
        }
        public double Aliquot(double value)
        {
            double aliquot = 0;

            if (value >= 22847.77 && value <= 33919.80)
                aliquot = 0.075;
            if (value >= 33919.81 && value <= 45012.60)
                aliquot = 0.150;
            if (value >= 45012.61 && value <= 55976.15)
                aliquot = 0.225;
            if (value >= 55976.16)
                aliquot = 0.275;

            return aliquot;
        }
        public double Deduction(double value)
        {
            double deduction = 0;

            if (value >= 22847.77 && value <= 33919.80)
                deduction = 1713.58;
            if (value >= 33919.81 && value <= 45012.60)
                deduction = 4257.57;
            if (value >= 45012.61 && value <= 55976.15)
                deduction = 7633.51;
            if (value >= 55976.16)
                deduction = 10432.32;

            return deduction;

        }
    }
}
