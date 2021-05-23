using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    class Parcial : Evaluacion
    {
        private int numQuestions, correctAnswers;
        public Parcial(string name,int numQuestions, int correctAnswers) 
            : base(name, 0.20)
        {
            this.numQuestions = numQuestions;
            this.correctAnswers = correctAnswers;
            CalculateGrade();
        }

        public override void CalculateGrade()
        {
            this.grade = (correctAnswers * 10) / numQuestions;
        }

        public override string ToString()
        {
            return $"{nameof(name)}:{name}, {nameof(percent)}:{percent}, " +
                $"{nameof(grade)}:{grade}, {nameof(numQuestions)}:{numQuestions}, " +
                $"{nameof(correctAnswers)}:{correctAnswers}";
        }
    }
}
