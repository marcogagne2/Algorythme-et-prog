using System;

namespace projetspidermanoctopus
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int choix = 0;
            string maPhrase;
            //DÉBUT
            Console.WriteLine("Bienvenue spider-man!Veuillez écrire votre phrase:");

            maPhrase=Convert.ToString(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Menu");
            Console.WriteLine("Veuillez sélectionner un choix parmis les options suivantes:");
            Console.WriteLine("");
            Console.WriteLine("1-Afficher la longueur de la chaîne de caractères");
            Console.WriteLine("2-Déterminer si la phrase contient « octopus »");
            Console.WriteLine("3-Connaître la position du premier ‘e’ ( indice, IndexOf)");
            Console.WriteLine("4-’Afficher une sous phrase");
            Console.WriteLine("5-Transforme la chaîne en majuscule puis l’affiche");
            Console.WriteLine("6-Transforme la chaîne en minuscule puis l’affiche");
           
            choix = Convert.ToInt32(Console.ReadLine());

            switch(choix)
            {
                 case 1 :
               
                 int length = maPhrase.Length;
                    Console.WriteLine("Votre nombre de lettre est de "+length); 

                 break;

                 case 2 :
                    if (maPhrase.Contains("octopus")==true)
                    {
                        Console.WriteLine("Votre phrase contien octopus");                     
                    }
                    if (maPhrase.Contains("octopus")==false)
                    {
                        Console.WriteLine("votre phrase ne contien pas ocopus");
                    }              
                 break;

                 case 3 : /*code*/
                 break;
                 case 4 : /*code*/
                 break;
                 case 5 : /*code*/
                 break;
            }






            //Attendre avant de fermer la fenêtre
            Console.ReadKey();

        }
    }
}
