using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    class Laboratorio : Evaluacion
    {
        private int cantE;
        public Laboratorio(string name,int cantE) : base(name, 0.15)
        {
            this.cantE = cantE;
            CalculateGrade();
        }

        public override void CalculateGrade()
        {
            switch (cantE)
            {
                case int x when x >= 3:
                    this.grade = 10;
                    break;
                case 2:
                    this.grade = 6;
                    break;
                case 1:
                    this.grade = 3;
                    break;
                default:
                    this.grade = 0;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{nameof(name)}:{name}, {nameof(percent)}:{percent}, " +
                $"{nameof(grade)}:{grade}, {nameof(cantE)}:{cantE}";
        }
    }
}
