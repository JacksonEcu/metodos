using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo
{
    class Factura
    {

        public string Gerente { get; set; }
        public int numfact { get; set; }
        public string Inventario { get; set; }

        public string estimado { get; set; }



        public string Fact()
        {
            return $"Buenas tardes soy el gerente: {Gerente} Su factura del dia de hoy es: {numfact} \nla Devolucion se realiza durante: {estimado}";
    

    }
      
}
}