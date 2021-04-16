using System;
using System.Collections.Generic;

namespace Tutoria_viernes_16_abril
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPercent = 0;
            bool cont = true;
            int auxInt;
            String name = "";
            String auxString;
            List<Evaluacion> evaluations = new List<Evaluacion>();

            do
            {
                Console.Write("---MENU---\n" +
                    "1-) Agregar evaluacion\n" +
                    "2-) Mostrar evaluaciones\n" +
                    "3-) Eliminar una evaluacion\n" +
                    "4-) Calcular nota acumulada\n" +
                    "5-) salir\n" +
                    "opcion: ");
                auxInt = Int32.Parse(Console.ReadLine());

                switch (auxInt)
                {
                    case 1:
                        if (totalPercent < 1)
                        {
                            Console.WriteLine("Nombre de la evaluacion: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Tipo de evaluacion: \n" +
                                "1-) Tarea \n" +
                                "2-) Laboratorio \n" +
                                "3-) Parcial");
                            auxInt = Int32.Parse(Console.ReadLine());

                            switch (auxInt)
                            {
                                case 1:
                                    //new DateTime(yyyy,mm,dd,hh,mm,ss)
                                    //yyyy/mm/dd hh:mm:ss

                                    Console.WriteLine("Fecha de vencimiento de la tarea");
                                    auxString = Console.ReadLine();
                                    DateTime expireDate = new DateTime();
                                    expireDate = DateTime.Parse(auxString);

                                    Console.WriteLine("Se hizo entrega de la tarea? \n" +
                                        "1-) si \n" +
                                        "2-) no \n");
                                    auxInt = Int32.Parse(Console.ReadLine());
                                    DateTime reciveDate = new DateTime();
                                    bool recive;
                                    switch (auxInt)
                                    {
                                        case 1:
                                            recive = true;
                                            Console.WriteLine("Fecha en que se hizo entrega de la tarea");
                                            auxString = Console.ReadLine();
                                            reciveDate = DateTime.Parse(auxString);
                                            evaluations.Add(new Tarea(name, expireDate, reciveDate, recive));
                                            totalPercent += 0.05;
                                            break;
                                        case 2:
                                            recive = false;
                                            evaluations.Add(new Tarea(name, expireDate, reciveDate, recive));
                                            totalPercent += 0.05;
                                            break;
                                        default:
                                            Console.WriteLine("Opcion no valida");
                                            break;
                                    }
                                    break;

                                case 2:
                                    if (totalPercent <= 0.85)
                                    {
                                        Console.WriteLine("Numero de ejercicios que realizo");
                                        auxInt = Int32.Parse(Console.ReadLine());
                                        switch (auxInt)
                                        {
                                            case int x when x >= 0:
                                                evaluations.Add(new Laboratorio(name, auxInt));
                                                totalPercent += 0.15;
                                                break;
                                            default:
                                                Console.WriteLine("No se pueden ingresar numeros negativos");
                                                break;
                                        }
                                    }
                                    else
                                        Console.WriteLine("No se pueden agregar mas laboratorios");
                                    break;

                                case 3:
                                    if (totalPercent <= 0.80)
                                    {
                                        Console.WriteLine("Numero de preguntas:");
                                        int numQuestions = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Numero respuestas correctas:");
                                        int correctAnswers = Int32.Parse(Console.ReadLine());
                                        switch (correctAnswers)
                                        {
                                            case int x when x <= numQuestions && x >= 0:
                                                evaluations.Add(new Parcial(name, numQuestions, correctAnswers));
                                                totalPercent += 0.2;
                                                break;
                                            default:
                                                Console.WriteLine("El numero de respuestas correctas no" +
                                                    "puede superar el numero de preguntas ni pueden ser" +
                                                    " numeros negativos");
                                                break;
                                        }
                                    }
                                    else
                                        Console.WriteLine("No se pueden agregar mas parciales");
                                    break;
                                default:
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("No se pueden agregar mas evaluaciones");
                        break;
                    case 2:
                        evaluations.ForEach(ev => Console.WriteLine(ev.ToString()));
                        break;
                    case 3:
                        Console.WriteLine("Nombre de la evaluacion a eliminar");
                        name = Console.ReadLine();
                        evaluations.RemoveAll(ev=> 
                        {
                            if (ev.Name().Equals(name))
                            {
                                totalPercent -= ev.Percent();
                                return true;
                            }
                            else
                                return false;
                        });
                        break;
                    case 4:
                        Console.WriteLine(CalcularNotaFinal.calculateFinalGrade(evaluations));
                        break;
                    case 5:
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (cont);
        }
    }
}
