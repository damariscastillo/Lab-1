using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_2_b
{
    internal class Parcela
    {
        private string siembra;
        private int mesesCrecer;
        private int mesesTranscurridos;
        private double ingresosCosecha;
        private bool estaOcupada;

        
        public string Siembra
        {
            get { return siembra; }
            set { siembra  = value; }
        }
        public int MesesCrecer
        {
            get { return mesesCrecer; }
            set { mesesCrecer = value; }
        }
        public int mtranscurridos
        {
            get { return mesesTranscurridos; }
            set { mesesTranscurridos = value; }
        }
        public double Icosecha
        {
            get { return ingresosCosecha; }
            set { ingresosCosecha = value; }
        }
        public bool estaocupada
        {
            get { return estaOcupada; }
            set { estaOcupada = value; }
        }
    }
}
