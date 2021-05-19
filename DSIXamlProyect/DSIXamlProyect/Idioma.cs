using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIXamlProyect
{
    static class Idioma
    {
        public enum Idiomas { Castellano, Ingles, Aleman, Frances }
        public static Idiomas actual;


        public enum Texto
        {
            //===========================
            jugar,
            opciones,
            idioma,
            salir,
            //===========================
            seleccionModoDeJuego,
            facil,
            medio,
            dificil,
            jugadorVsIA,
            multijugador,
            local,
            online,
            //==========================
            seleccionaOponente,
            jugador, 
            amigo
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
                "Salir",

                "Seleccion Modo de juego",
                "Facil",
                "Medio",
                "Dificil",
                "Jugador vs IA",
                "Multijugador",
                "Local",
                "Online",

                "Seleccion oponente",
                "Jugador",
                "Amigo"
            },
            { //Ingles
                "Play",
                "Options",
                "Language",
                "Exit",

                "Select game mode",
                "Easy",
                "Medium",
                "Difficult",
                "Player vs IA",
                "Mutiplayer",
                "Local",
                "Online",

                "Select oponent",
                "Player",
                "Friend"
            },
            { //Aleman
                "Adasdaskdj",
                "asdhöS",
                "#~@#€@",
                "Ä'sòí",

                 "Seleccion Modo de juego",
                "Facil",
                "Medio",
                "Dificil",
                "Jugador vs IA",
                "Multijugador",
                "Local",
                "Online",

                "Seleccion oponente",
                "Jugador",
                "Amigo"
            },
            { //Frances
                "Ulala",
                "Tacos",
                "UwU",
                "Oni chan",

                "Seleccion Modo de juego",
                "Facil",
                "Medio",
                "Dificil",
                "Jugador vs IA",
                "Multijugador",
                "Local",
                "Online",

                "Seleccion oponente",
                "Jugador",
                "Amigo"
            }};
    }
}
