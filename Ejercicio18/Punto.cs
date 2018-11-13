using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        #region Atributos
        private int x;
        private int y;
        #endregion

        #region Properties
        public int GetX
        {
            get { return this.x; }
        }

        public int GetY
        {
            get { return this.y; }
        }
        #endregion

        #region Builder
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Operators
        public static implicit operator string(Punto p1)
        {
            return p1.ToString();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("X={0} Y={1}",this.GetX,this.GetY);
            
            return sb.ToString();
        }
        #endregion

    }
}
