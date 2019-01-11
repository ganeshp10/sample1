using Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    public class FrontEnd
    {
        public void Add()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
        }
    }
}
