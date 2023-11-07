/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur

            bool correctMenu = false;
            bool correctSaisie = false;

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                while (!correctMenu)
                {
                    try
                    {
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        correctMenu = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie");
                    }

                }

                // remise à zéro de la vérification des erreurs, pour éviter d'ignorer l'affichage de menu
                correctMenu = false;

                // traitement des choix
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);

                        // saisie de la réponse
                        while (!correctSaisie)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correctSaisie = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }

                        // remise à zéro de la vérification des erreurs de saisie
                        correctSaisie = false;
                        
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else if (choix == 2)
                    {
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        while (!correctSaisie)
                        {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correctSaisie = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }
                        correctSaisie = false;

                        
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erreur de saisie");
                    }
                }

                
            }
        }
    }
}
