/*
Exercice "récap" sur les collections, boucle et intéractions console:
Crée une application de console qui gère une liste de tâches (todo list).

Créer un menu avec les options suivantes :
    Ajouter une tâche (demander à l'utilisateur un nom de tâche)
    Afficher les tâches
    Supprimer une tâche via nom
    Supprimer une tâche via l'index
    Fermeture de l'application

Bien sûr l'application ne doit se terminer tant que l'utilisateur ne rentre pas dans l'options "Fermeture de l'application".

BONUS: on n'est plus dans le monde des bisounours 🔥 ☄️ 
vérifier tout ce que l'utilisateur entre
le nom d'une tâche doit faire au moins 5 caractères et les espaces inutilent doit être supprimer (espace inutile = avant et après le nom, ex:                   nom                devient nom.
*/

List<string> todos = new() { "Hello", "World" };
bool stop = false;
while (!stop)
{
    Console.WriteLine("TODO LIST menu:");
    Console.WriteLine("\t1. Ajouter");
    Console.WriteLine("\t2. Afficher");
    Console.WriteLine("\t3. Supprimer via le nom");
    Console.WriteLine("\t4. Supprimer via l'index");
    Console.WriteLine("\t0. Quitter");

    Console.Write("Faites votre choix> ");
    string inputChoice = Console.ReadLine();

    switch (inputChoice)
    {
        case "1":
            { // on crée un bloc de code pour pouvoir réutiliser le nom de variable "taskNane" dans un autre `case`
                Console.WriteLine("Ajouter:");
                Console.Write("Quel est le nom de la tâche (au moins 5caractères): ");
                string taskName = Console.ReadLine();

                // nettoyage de la variable 
                taskName = taskName.Trim(); // trim permet d'enlever les espaces en début et fin de texte

                // vérification de la longeur minimal
                if (taskName.Length >= 5)
                {
                    todos.Add(taskName);
                }
                else
                {
                    Console.WriteLine("Nom invalide (au moins 5caractères)");
                }
            }
            break;
        case "2":
            Console.WriteLine("Lister");
            for (int i = 0; i < todos.Count(); i++)
            {
                Console.WriteLine($"\t{i}. {todos[i]}");
            }
            break;
        case "3":
            {
                Console.WriteLine("Supprimer via le nom");
                Console.Write("Quel est le nom de la tâche (au moins 5caractères): ");
                string taskName = Console.ReadLine();

                // Solution 0: .Remove()
                //todos.Remove(taskName); // probleme: case sensitive

                // Solution 1: on trouve l'index de notre taskName (comparaison lowercase)
                //int index = -1;
                //for(int i =0; i < todos.Count() && index == -1 ; i++)
                //{
                //    if(taskName.ToLower() == todos[i].ToLower())
                //    {
                //        index = i;
                //    }
                //}

                //todos.RemoveAt(index);

                // Solution 2: LinQ (on verra ça plus tard après le cours de POO)
                //int index = todos.FindIndex(
                //    (e) => { return e.ToLower() == taskName.ToLower(); }
                //);
                int index = todos.FindIndex(
                    (e) => e.ToLower() == taskName.ToLower()
                );
                todos.RemoveAt(index);
            }
            break;
        case "4":
            {
                Console.WriteLine("Supprimer via l'index");
                Console.Write("Quel index souhaitez-vous supprimer? ");
                string inputIndex = Console.ReadLine();
                bool success = int.TryParse(inputIndex, out int index);
                if (success)
                {
                    // vérifier que l'index existe
                    if(index >= 0 && index < todos.Count())
                    {
                        todos.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("L'index n'existe pas...");
                    }
                }else
                {
                    Console.WriteLine("Merci d'entrez un nombre.");
                }
            }
            break;
        case "0":
            stop = true;
            break;
        default:
            Console.WriteLine("Choix invalide");
            break;
    }
}

Console.WriteLine("Aurevoir.");