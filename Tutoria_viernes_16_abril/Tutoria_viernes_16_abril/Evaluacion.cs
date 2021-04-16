using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    public abstract class Evaluacion
    {
        protected String name;
        protected double percent;
        protected double grade;

        public Evaluacion(String name, double percent)
        {
            this.name = name;
            this.percent = percent;
        }

        public String Name()
        {
            return this.name;
        }

        public double Percent()
        {
            return this.percent;
        }

        public double Grade()
        {
            return this.grade;
        }

        public abstract void CalculateGrade();
    }
}
