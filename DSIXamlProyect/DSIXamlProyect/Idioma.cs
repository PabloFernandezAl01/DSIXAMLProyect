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
            amigo,
            //==========================
            ajustes,
            musica, 
            efectos, 
            tutoriales,
            emparejado,
            //==========================
            seleccionEscenario, 
            nombre1,
            nombre2,
            nombre3,
            nombre4,
            nombre5
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

                "Selecciona oponente",
                "Jugador",
                "Amigo",

                "Ajustes de juego",
                "Música",
                "Efectos",
                "Tutoriales",
                "Emparejados",

                "Selecciona estadio",
                "Estadio Espinaca", 
                "Estadio Lechuga", 
                "Estadio Yojhan", 
                "Estadio Estadio", 
                "Amamos XAML"
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
                "Friend",

                "Game options",
                "Music",
                "Visual effects",
                "Tutorials",
                "MatchMaking",

                "Select stadium",
                "Spinach's stadium",
                "Lettuce's stadium",
                "Yojhan's stadium",
                "Stadium Stadium",
                "We Love XAML"
            },
            { //Aleman
                "Adasdaskdj",
                "asdhöS",
                "#~@#€@",
                "Ä'sòí",

                "OCHORCOJOLO",
                "awd36ddd",
                "sñolll",
                "miiiii",
                "Jüghadör vs IA",
                "MultiJüghadör",
                "IOLLD",
                "YEPES",

                "Ö",
                "ÓMÒ",
                "NICHINJAGUER",

                "DO JOU SKUCHER",
                "CHEHZ",
                "KIKIKIKI",
                "PAHRMOOON",
                "ROTANFORTA",

                "Ruthenförd",
                "Estadio Mariposas",
                "Estadio Amor",
                "Estadio Abejita",
                "Estadio Felicidad",
                "<3 XAML"
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
                "Amigo",

                "Paramètres de jeu",
                "Música",
                "Efectos",
                "Tutoriales",
                "Emparejados",

                "Sélectionnez le stade",
                "Stade Épinards",
                "Stade Lechuga",
                "Stade Yojhan",
                "Stade Stade",
                "Nous aimons XAML"
            }};
    }
}
