using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMT
{
    class Transicion
    {
        public Transicion (int estadoi, string leido, int estadof, string escribir, string mov)
        {
            EstadoInicial = estadoi;
            EstadoFinal = estadof;
            Leido = leido;
            AEscribir = escribir;
            Movimiento = mov;
        }
        public int EstadoInicial { get; set; }
        public string Leido { get; set; }
        public int EstadoFinal { get; set; }
        public string AEscribir { get; set; }
        public string Movimiento { get; set; }
    }
}
