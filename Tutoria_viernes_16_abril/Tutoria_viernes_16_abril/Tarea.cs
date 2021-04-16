using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    class Tarea : Evaluacion
    {
        private DateTime expireDate;
        private DateTime reciveDate;
        private bool recive;

        public Tarea(string name,DateTime expireDate,DateTime reciveDate, bool recive) : base(name, 0.05)
        {
            this.expireDate = expireDate;
            this.reciveDate = reciveDate;
            this.recive = recive;
            CalculateGrade();
        }

        public override void CalculateGrade()
        {
            switch (recive)
            {
                case true:
                    if (expireDate >= reciveDate)
                        this.grade = 10;
                    else
                        this.grade = 8;
                    break;
                case false:
                    this.grade = 0;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{nameof(name)}:{name}, {nameof(percent)}:{percent}, " +
                $"{nameof(grade)}:{grade}, {nameof(expireDate)}:{expireDate}, " +
                $"{nameof(reciveDate)}:{reciveDate}, {nameof(recive)}:{recive}";
        }
    }
}
