using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIXamlProyect
{
    static class Idioma
    {
        public enum Idiomas { Castellano, Ingles, Aleman, Esparanto }
        public static Idiomas actual;


        public enum Texto
        {
            jugar,
            opciones,
            idioma,
            salir
        }

        public static string getText(Texto texto)
        {
            return textos[(int)actual, (int)texto];
        }

        public static string getText(Idiomas idioma, Texto texto)
        {
            return textos[(int)idioma, (int)texto];
        }

        public static string[,] textos = {
            { //Español
                "Jugar",
                "Opciones",
                "Idioma",
                "Salir"
            },
            { //Ingles
                "Play",
                "Options",
                "Language",
                "Exit"
            },
            { //Aleman
                "Adasdaskdj",
                "asdhöS",
                "#~@#€@",
                "Ä'sòí"
            },
            { //Esperanto
                "Ulala",
                "Tacos",
                "UwU",
                "Oni chan"
            }};
    }
}
