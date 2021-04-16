using System;
using System.Collections.Generic;

namespace Tutoria_viernes_09_abril
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Nombre:");
            String name = Console.ReadLine(); 
            Console.WriteLine("Ingrese Edad:");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Genero (H para hombre, M para mujer)");
            char gender = Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Peso en kg");
            Double weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura en m");
            Double height = Double.Parse(Console.ReadLine());

            List<Persona> Personas = new List<Persona>();

            Personas.Add(new Persona(name, age, gender, weight, height));
            Personas.Add(new Persona(name, age, gender));
            Persona emptyPersona = new Persona();

            Console.WriteLine("Ingrese Nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese Edad:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Genero (H para hombre, M para mujer)");
            gender = Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Peso en kg");
            weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura en m");
            height = Double.Parse(Console.ReadLine());

            emptyPersona.SetName(name);
            emptyPersona.SetAge(age);
            emptyPersona.SetGender(gender);
            emptyPersona.SetWeight(weight);
            emptyPersona.SetHeight(height);

            Personas.Add(emptyPersona);

            Personas.ForEach(obj =>
            {
                if (obj.Adult())
                    Console.WriteLine($"{obj.GetName()} es mayor de edad");
                else
                    Console.WriteLine($"{obj.GetName()} es menor de edad");

                switch (obj.CalculateIMC())
                {
                    case -1:
                        Console.WriteLine($"{obj.GetName()} posee un peso abajo del ideal");
                        break;
                    case 0:
                        Console.WriteLine($"{obj.GetName()} posee un peso ideal");
                        break;
                    case 1:
                        Console.WriteLine($"{obj.GetName()} tiene sobre peso");
                        break;
                }

                Console.WriteLine(obj.ToString());
                Console.WriteLine(typeof(obj));
            });

        }
    }
}

/* Haz una clase llamada Persona que siga las siguientes condiciones:

Sus atributos son: nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura. No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo. Si quieres añadir algún atributo puedes hacerlo.
Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una constante para ello.
Se implantaran varios constructores:
Un constructor por defecto.
Un constructor con el nombre, edad y sexo, el resto por defecto.
Un constructor con todos los atributos como parámetro.
Los métodos que se implementaran son:
calcularIMC(): calculara si la persona esta en su peso ideal (peso en kg/(altura^2  en m)), si esta fórmula devuelve un valor menor que 20, la función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que esta por debajo de su peso ideal la función devuelve un 0  y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. Te recomiendo que uses constantes para devolver estos valores.
esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
comprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, sera H. No sera visible al exterior.
toString(): devuelve toda la información del objeto.
generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de este su número su letra correspondiente. Este método sera invocado cuando se construya el objeto. Puedes dividir el método para que te sea más fácil. No será visible al exterior.
Métodos set de cada parámetro, excepto de DNI.
Ahora, crea una clase ejecutable que haga lo siguiente:

Pide por teclado el nombre, la edad, sexo, peso y altura.
Crea 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor.
Para cada objeto, deberá comprobar si esta en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.
Indicar para cada objeto si es mayor de edad.
Por último, mostrar la información de cada objeto.
Puedes usar métodos en la clase ejecutable, para que os sea mas fácil.*/
