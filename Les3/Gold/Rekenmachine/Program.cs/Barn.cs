using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Barn
    {
        private float surface = 20.0f;
        //toegankelijkheid datatype variabeleNaam = waarde;
        private Horse paard = new Horse();
        private Cow koe = new Cow();
        //toegankelijkheid returnType==datatype functie naam (argumenten) {scope}
        public void vergroting(float newsurface)
        {
            //float newersurface = 30.0f;
            surface = newsurface;
        }
        public void voedsel() 
        {
            Console.WriteLine("alle dieren hebben eten");
        }


    }
}
