// See https://aka.ms/new-console-template for more information
Console.WriteLine("Les tableaux!");
#region tableau de base
{
    // on remplit le tableau en même temps que l'on le crée
    int[] tabInts = { 39, 42, 66 };
    string[] listeDeCourses = { "eaux", "viandes", "patates" };
    bool[] bools = { true, false, true, false };

    // crée un tableau vide (valeur par défaut du type), on place des valeurs
    int[] tab2Ints = new int[10]; // default de int = 0
    string[] tab2Strings = new string[4]; // default de string = null

    tab2Ints[5] = 56;
    tab2Strings[2] = "hello";

    // crée un tableau de nullable
    int?[] tabNullInt = new int?[10]; 

    Console.WriteLine();
}
#endregion

#region tableau matriciel
{
    // matrice de 3 sur 3 remplie de 0
    int[,] matriceCarreDef = new int[3, 3];

    // matrice pré-remplie
                          //y 0  1  2
    int[,] matriceCarre = { { 1, 2, 3 },  //x 0
                            { 4, 5, 6 },  //  1
                            { 7, 8, 9 }   //  2
    };


    int x = 1;
    int y = 2;
    Console.WriteLine(matriceCarre[1, 2]);
}
#endregion

#region orthogonale
{
    int[][] matriceCarre = { new int[] { 1, 2, 3 },
                            new int[] { 4, 5, 6 },
                            new int[] { 7, 8, 9 },
    };
    int x = 1;
    int y = 2;
    Console.WriteLine(matriceCarre[1][2]);

    int[][][] matriceCube = {
                    new int[][]{ new int[]{ 1,  2,  3 }, new int[] { 4,  5,  6 }, new int[] { 7,  8,  9 } },  // Tranche 0
                    new int[][]{ new int[] { 10, 11, 12 }, new int[] { 13, 14, 15 }, new int[] { 16, 17, 18 } }, // Tranche 1
                    new int[][]{ new int[] { 19, 20, 21 }, new int[] { 22, 23, 24 }, new int[] { 25, 26, 27 } }  // Tranche 2
                };
    int xCube = 1;
    int yCube = 2;
    int zCube = 0;
    Console.WriteLine(matriceCube[xCube][yCube][zCube]);
}
#endregion

#region List
{
    // 1. instanciation de la liste
    //List<int> lotto = new List<int>();
    List<int> lotto = new();

    bool stop = false;
    do
    {
        int rng = Random.Shared.Next(0, 101);
        // 2. ajout de l'élément
        lotto.Add(rng);

        // 3. afficher le nombre d'élément de la liste
        Console.WriteLine(lotto.Count);

        Console.WriteLine("Veux-tu t'arrêter? ");
        string input = Console.ReadLine();
        if(input == "stop")
        {
            stop = true;
        }
    } while (!stop);

    Console.WriteLine("FOR I:");
    for(int i = 0; i < lotto.Count; i++)
    {
        Console.WriteLine(lotto[i]);
    }

    Console.WriteLine("FOR each");
    foreach (int numero in lotto) {
        Console.WriteLine(numero);
    }
}
#endregion

#region Dictionnaire
{
    Dictionary<string, string> larousse /* le dictionnaire hein! */ = new Dictionary<string, string>();

    larousse.Add("noob", "Il est nul.");
    larousse.Add("Good", "il joue bien.");

    if (larousse.ContainsKey("Good"))
    {
        Console.WriteLine("La clé existe!");
    }

    Console.WriteLine($"Que veux dire noob? {larousse["noob"]}");

    // parcourir tout le dictionnaire
    //foreach (string key in larousse.Keys)
    //{
     // TODO
    //}

    foreach(KeyValuePair<string, string> ligne in larousse)
    {
        Console.WriteLine($"{ligne.Key} - {ligne.Value}");
    }
}
#endregion

#region Queue (FIFO - First In First Out)
{
    Queue<int> eliminations = new();

    eliminations.Enqueue(888);
    eliminations.Enqueue(0);
    eliminations.Enqueue(42);
    eliminations.Enqueue(123);

    while(eliminations.Count > 0)
    {
        int current = eliminations.Dequeue();
        Console.WriteLine(current);
    }
}
#endregion

#region Stack (LIFO - Last In First Out)
{
    Stack<string> pays = new();

    pays.Push("France");
    pays.Push("Belgique");
    pays.Push("Canada");

    while (pays.Count > 0)
    {
        string current = pays.Pop();
        Console.WriteLine(current);
    }
}
#endregion