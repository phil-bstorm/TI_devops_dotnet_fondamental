//Ecrire une structure pour définir un point possédant deux entier X, Y et créer un tableau deux dimensions de 5 sur 5 de type « Point » (nullable)
//et remplir une des diagonales, ensuite à l’aide de deux boucles afficher les valeurs dans la console comme suit :
//« X: 1 - Y : 1 »
//«  X: 2 - Y : 2 »
//«  X: 3 - Y : 3 »
//...

using Exo6.Models;


//      0;0   0;1   0;2    0;3
//      1;0   1;1   1;2    1;3
//      2;0   2;1   2;2    2;3
//      3;0   3;1   3;2    3;3

// Création du tableau
int size = 5;
Point?[,] tableauDePoints = new Point?[size, size];

// écriture sur la diagonale

// Solution 1 : on parcours TOUTES les cases
//for(int line = 0; line < size; line++)
//{
//    for(int column = 0; column < size; column++)
//    {
//        if(line == column)
//        {
//            tableauDePoints[line, column] = new Point(line, column);
//        }
//    }
//}

// Solution 2 : on sait que la diagonale c'est quand line et la colonne sont identique (et qu'on est dans un carré)
for(int i = 0; i < size; i++)
{
    tableauDePoints[i, i] = new Point(i, i);
}

// Affichage
for (int line = 0; line < size; line++)
{
    for (int column = 0; column < size; column++)
    {
        // si j'ai un point, je l'affiche
        if (tableauDePoints[line, column] is not null)
        {
            Point e = (Point)tableauDePoints[line, column]!; // le "!" premet d'affirmer au compilateur que la valeur n'est pas NULL et permet d'enlever le "warning".
            Console.Write($"X:{e.X}-Y:{e.Y}");
        }
        // sinon je met une tabulation
        else
        {
            Console.Write("\t");
        }
    }
    // A la fin de chaque ligne; on fait un retour à la ligne avec \n
    Console.Write("\n");
}