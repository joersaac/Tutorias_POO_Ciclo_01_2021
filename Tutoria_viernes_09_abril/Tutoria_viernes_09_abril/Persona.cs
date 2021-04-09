using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_09_abril
{
    class Persona
    {
        private String name;
        private int age;
        private char gender;
        private String DNI;
        private Double weight;
        private Double height;

        public Persona()
        {
            this.name = "";
            this.age = 0;
            this.gender = 'H';
            this.weight = 0;
            this.height = 0;
            GenerateDNI();
        }

        public Persona(String name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            ValidGender(gender);
            this.weight = 0;
            this.height = 0;
            GenerateDNI();
        }

        public Persona(String name, int age, char gender, Double weight, Double height)
        {
            this.name = name;
            this.age = age;
            ValidGender(gender);
            this.weight = weight;
            this.height = height;
            GenerateDNI();
        }

        public int CalculateIMC()
        {
            Double IMC = this.weight / Math.Pow(this.height, 2);

            switch (IMC)
            {
                case double x when x < 20:
                    return -1;
                case double x when x > 25:
                    return 1;
                default:
                    return 0;
            }
        }

        public bool Adult()
        {
            switch (this.age)
            {
                case int x when x < 18:
                    return false;
                default:
                    return true;
            }
        }

        private void ValidGender(char gender)
        {
            switch (gender)
            {
                case 'H':
                case 'M':
                case 'm':
                case 'h':
                    this.gender = gender;
                    break;
                default:
                    this.gender = 'H';
                    break;
            }
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(age)}: {age}, {nameof(gender)}: {gender}, " +
                $"{nameof(DNI)}: {DNI}, {nameof(weight)}: {weight}, {nameof(height)}: {height}";
        }

        private void GenerateDNI()
        {
            this.DNI = "";

            var seed = Environment.TickCount;
            var random = new Random(seed);

            for (int i = 0; i < 8; i++)
            {
                var value = random.Next(0, 9);

                this.DNI += value.ToString();
            }
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetGender(char gender)
        {
            ValidGender(gender);
        }

        public void SetWeight(Double weight)
        {
            this.weight = weight;
        }

        public void SetHeight(Double height)
        {
            this.height = height;
        }

        public String GetName()
        {
            return this.name;
        }
    }
}
