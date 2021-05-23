using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    public static class CalcularNotaFinal
    {
        public static double calculateFinalGrade(List<Evaluacion> evaluations)
        {
            double finalGrade = 0;
                if (evaluations.Count > 0)
                {
                    evaluations.ForEach(ev =>
                    {
                        finalGrade += (ev.Percent() * ev.Grade());
                    });
                }
                else
                {
                throw new EmptyListException("No hay evalaciones que calificar");
                }
            return finalGrade;
        }
    }
}
