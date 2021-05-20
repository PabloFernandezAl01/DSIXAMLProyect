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
            nombre5,
            //==========================
            seleccionDePersonaje
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
                "Amamos XAML",

                "Seleccion de personaje"
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
                "We Love XAML",

                "Choose your character"
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
                "<3 XAML",

                "Fürhtenthon"
            },
            { //Frances
                "Jouer",
                "Options",
                "Langage",
                "Ulala",

                "Sélectionnez le mode de jeu",
                "Facile",
                "Moitié",
                "Difficile",
                "Joueur vs IA",
                "Multijoueur",
                "Local",
                "Online",

                "Sélectionnez un adversaire",
                "Joueur",
                "Ami",

                "Paramètres de jeu",
                "Musique",
                "Effets",
                "Tutoriels",
                "Entremise",

                "Sélectionnez le stade",
                "Stade Épinards",
                "Stade Lechuga",
                "Stade Yojhan",
                "Stade Stade",
                "Nous aimons XAML",

                "Sélection de personnage"
            }};
    }
}
