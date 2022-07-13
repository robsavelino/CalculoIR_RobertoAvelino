using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoIR.Presentation.Interfaces;

namespace CalculoIR.Presentation
{
    public class RegisterInput : IRegisterInput
    {
        public double GetInput()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                
                if (!IsInputValid(input) || Convert.ToDouble(input) < 0)
                {
                    Console.WriteLine("Input is not valid, try again:");
                    return GetInput();
                }

            } while (!IsInputValid(input) || Convert.ToDouble(input) < 0);
            
            return Convert.ToDouble(input);
        }

        public static bool IsInputValid(string input)
        {
            if(!double.TryParse(input, out _))
                return false;
            return true;
        }
    }
}
