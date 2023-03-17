using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    internal class CalcularRect
    {
        public double Alto { get; set; }
        public double Largo { get; set; }
        public double SuperfeciFrontal { get { return Alto * Largo; } }

    }
}
