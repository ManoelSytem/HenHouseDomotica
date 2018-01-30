using System;
using System.Collections.Generic;
using System.Text;

namespace HenHouseDomotica.Models
{
   public class Dispositivo
    {
        public string Nome { get; set; }

        public string Pino { get; set; }

        public Boolean Estado { get; set; }

        public string Utilizador { get; set; }
    }
}
