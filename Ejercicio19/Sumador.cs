using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador
    {
        #region Atributes
        private int cantidadSumas;
        #endregion

        #region Methods
        public long Sumar(long n1, long n2)
        {
            long resul = long.MinValue;

            this.cantidadSumas++;

            resul = n1 + n2;

            return resul;
        }

        public string Sumar(string c1, string c2)
        {
            string resul = "";

            this.cantidadSumas++;

            resul = c1 + " " + c2;

            return resul;
        }
        #endregion

        #region Builder
        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidad) : this()
        {
            this.cantidadSumas = cantidad;
        }
        #endregion

        #region Operators
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool flag = false;

            if (s1.cantidadSumas==s2.cantidadSumas)
            {
                flag = true;
            }

            return flag;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        #endregion


    }
}
