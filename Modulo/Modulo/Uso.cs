using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo
{
    class Uso
    {

        public int Cantidad { get; set; }
        public string tomas { get; set; }
        public string Advertencia { get; set; }
        public string Caducidad { get; set; }



        public string cantidad()

        {
            return $"La cantidad recomendada es:  {Cantidad} \nCon una toma maxima de {tomas} \nTomar en cuenta su estado: {Advertencia} \n";

        }
       
    }
}


