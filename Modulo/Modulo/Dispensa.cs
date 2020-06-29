using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo
{
    class Dispensa
    {
        public string Nombre { get; set; }
        public string Proveniencia{ get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string dispe()
        {
            return $"Esta a punto de comprar: {Nombre} \nTraida de: {Proveniencia} \nCon la marca: {Marca} \n";
        }

    }
}

