using CalculoIR.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoIR.Presentation;
using CalculoIR.Services.Interfaces;

namespace CalculoIR.Presentation
{
    public class ScreenPresentations : IScreenPresentations
    {
        private readonly IRegisterInput _registerInput;
        private readonly ITaxCalculator _taxCalculator;

        public ScreenPresentations(IRegisterInput registerInput, ITaxCalculator taxCalculator)
        {
            _registerInput = registerInput;
            _taxCalculator = taxCalculator;
        }


        public void PrintMenu()
        {
            
            int selectedOption;
            do
            {
                Console.WriteLine(@"Selecione a opção que deseja realizar: 
1 - Calculo simples, sem mostrar a aliquota e dedução.
2 - Cálculo completo, mostrando a alíquota e dedução.
3 - Finalizar programa.");
                selectedOption = GetOption();
                double value;
                switch (selectedOption)
                {
                    case 1:
                        value = PrintGetInput();
                        PrintResult(value);
                        break;
                    case 2:
                        value = PrintGetInput();
                        PrintAliquot(value);
                        PrintDeduction(value);
                        PrintResult(value);
                        break;
                    default:
                        break;
                }
            } while (selectedOption != 3);

            Console.WriteLine("Finalizando o programa");
        }

        public double PrintGetInput()
        {
            
            Console.WriteLine("Digite o salário anual para fazer o calculo do Imposto de Renda:");

            double value = _registerInput.GetInput();

            return value;

        }

        public void PrintResult(double value)
        {
            Console.WriteLine($"O valor a ser pago, já com a dedução é: {_taxCalculator.TaxCalculation(value)} ");
        }

        public void PrintAliquot (double value)
        {
            Console.WriteLine($"O valor da alíquota é: {_taxCalculator.Aliquot(value)}");
        }

        public void PrintDeduction(double value)
        {
            Console.WriteLine($"O valor da dedução é: {_taxCalculator.Deduction(value)}");
        }

        public int GetOption()
        {
            string input;

            do
            {
                input = Console.ReadLine().Trim();
                if(!int.TryParse(input, out _) || Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 3)
                    Console.WriteLine("Input is invalid, try again: ");

            } while (!int.TryParse(input, out _) || Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 3);

            return Convert.ToInt32(input); 
        }
    }
}
