using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIR.Services.Interfaces
{
    public interface ITaxCalculator
    {
        double TaxCalculation(double value);
        double Aliquot (double value);
        double Deduction (double value);
    }
}
