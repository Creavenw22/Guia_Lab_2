using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometria
{
    public class Rectangulo
    {
        #region Atributes
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        #endregion

        #region Properties
        public float Area
        {
            get
            {
                bool flag = true;
                if (flag)
                {
                    float area = 0;
                    float b = Math.Abs(this.vertice1.GetX) + Math.Abs(this.vertice2.GetX);
                    float h = Math.Abs(this.vertice1.GetY) + Math.Abs(this.vertice4.GetY);

                    area = b * h;

                    this.area = area;
                    flag = false;
                }
                return this.area;
            }
        }

        public float Perimetro
        {
            get
            {
                bool flag = true;
                if (flag)
                {
                    float perimetro = 0;
                    float b = Math.Abs(this.vertice1.GetX) + Math.Abs(this.vertice2.GetX);
                    float h = Math.Abs(this.vertice1.GetY) + Math.Abs(this.vertice4.GetY);

                    area = b*2 + h*2;

                    this.perimetro = perimetro;
                    flag = false;
                }
                return this.perimetro;
            }
        }
        #endregion

        #region Methods
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Vertice 1: ");
            sb.AppendLine(this.vertice1);
            sb.Append("Vertice 2: ");
            sb.AppendLine(this.vertice2);
            sb.Append("Vertice 3: ");
            sb.AppendLine(this.vertice3);
            sb.Append("Vertice 4: ");
            sb.AppendLine(this.vertice4);

            sb.AppendFormat("\r\nEl area del rectangulo es: {0}", this.Area);
            sb.AppendFormat("\r\nEl perimetro del rectangulo es: {0}", this.Perimetro);


            return sb.ToString();
        }
        #endregion

        #region Builder
        public Rectangulo(Punto v1, Punto v3)
        {
            this.vertice1 = v1;
            this.vertice2 = new Punto(v1.GetX, v3.GetY);
            this.vertice3 = v3;
            this.vertice4 = new Punto(v1.GetY, v3.GetX);
        }
        #endregion

    }
}
