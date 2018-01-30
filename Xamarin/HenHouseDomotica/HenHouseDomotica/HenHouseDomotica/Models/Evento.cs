using System;
using System.Collections.Generic;
using System.Text;

namespace HenHouseDomotica.Models
{
    public class Evento
    {
        public int IdDispositivo { get; set; }

        public string Mensagem { get; set; }

        public DateTime Data { get; set; }
    }
}
