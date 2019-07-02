using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Nota
    {

        // atributo data
        private DateTime data;

        public DateTime Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        // atributo valor
        private float valor;

        public float Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.valor = value;
                }
            }
        }

    }

}