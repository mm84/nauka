using System;
using System.Collections.Generic;
using System.Linq;


namespace Student
{
    class dziennik
    {
        //stan
        List<float> oceny;

        //Zachownia
        public void dodawanieOcen(float ocena)
        {
            oceny.Add(ocena);
        }
         
        public float Obliczanieslredniej()
        {
            float sum = 0, avg = 0;

            foreach (var ocena in oceny)
            {
                sum = sum + ocena;
            }

            avg = sum / oceny.Count();

            return avg;

        }

        public float maxOcena()
        {
            return oceny.Max();
        }

        public float minOcena()
        {
            return oceny.Min();

        }
    }
}
