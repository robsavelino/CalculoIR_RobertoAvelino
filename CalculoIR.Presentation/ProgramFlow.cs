using CalculoIR.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIR.Presentation
{
    public class ProgramFlow : IProgramFlow
    {
        public readonly IScreenPresentations _screenPresentation;

        public ProgramFlow(IScreenPresentations screenPresentation)
        {
            _screenPresentation = screenPresentation;
        }

        public void Begin()
        {
            _screenPresentation.PrintMenu();
        }
    }
}
