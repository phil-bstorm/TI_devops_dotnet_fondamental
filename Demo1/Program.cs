// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;

Console.WriteLine("Hello, World!");

#region Demo Console read line et write line
string name = "Alice";
string surname = Console.ReadLine();

Console.WriteLine(name + surname);
Console.WriteLine(name + " " + surname);
Console.WriteLine($"{name} {surname}");
Console.WriteLine("Voici un \"oiseau\"");
Console.WriteLine("C:\\Users\\BStorm\\Documents\\Cours\\dotNet\\Base\\Demo\\TI_DevNet2024_CSharp_Demo_01");
Console.WriteLine(@"C:\Users\BStorm\Documents\Cours\dotNet\Base\Demo\TI_DevNet2024_CSharp_Demo_01");
#endregion

// Commentaire une ligne!
/*
 Bloc de commentaire! 
 */

string testNullStr = null;
//int testNullInt = null;


var test = 2_147_483_650;
Console.WriteLine(test.GetType());

double d1 = 0.1;
double d2 = 0.2;
double d3 = 0.3;
bool comp = d1 + d2 == d3;
Console.WriteLine(comp);
Console.WriteLine(d1 + d2);
Console.WriteLine(d3);


#region Particularité de string
Console.WriteLine("String et les références:");
string s1 = "Hello";
string s2 = s1;

Console.WriteLine(ReferenceEquals(s1, s2));

s2 = "Autre!";
Console.WriteLine(ReferenceEquals(s1, s2));

Console.WriteLine(ReferenceEquals(s1, "Hello"));
Console.WriteLine(ReferenceEquals("hello", "Hello"));
#endregion


#region String concaténation

string total = s1 + s2;
Console.WriteLine(total);

string total2 = $"{s1}{s2}";
Console.WriteLine(total2);

StringBuilder sb1 = new StringBuilder("Hello");
sb1.Append(s2);
Console.WriteLine(sb1);
string total3 = sb1.ToString();



//#region comparatif String builder vs "+"
//const int NB_COUNT = 100_000;

//Stopwatch sw1 = new Stopwatch();
//Stopwatch sw2 = new Stopwatch();

//// Concat « str1 + str2 »
//sw1.Start();
//int count1 = 0;
//string w1 = "Start -> ";
//while (count1 < NB_COUNT)
//{
//    w1 = w1 + " Next, ";
//    count1++;
//}
//sw1.Stop();

//// Concat « StringBuidler »
//sw2.Start();
//int count2 = 0;
//StringBuilder sb = new StringBuilder("Start -> ");
//while (count2 < NB_COUNT)
//{
//    sb.Append(" Next, ");
//    count2++;
//}
//string w2 = sb.ToString();
//sw2.Stop();



//Console.WriteLine($"Concat \"classique\" : {sw1.ElapsedMilliseconds}ms");
//Console.WriteLine($"Concat StringBuilder : {sw2.ElapsedMilliseconds}ms");
//#endregion
#endregion

#region Conversion

string nombre1 = "1";
int nombre1_i = Convert.ToInt32(nombre1);
int nombre1Parse_i = int.Parse(nombre1);

//int nombre1TryParse_i;
//bool success = int.TryParse(nombre1, out nombre1TryParse_i);
bool success = int.TryParse(nombre1, out int nombre1TryParse_i);
#endregion

#region Conversion Int et Float

Console.WriteLine("Exemple division de 2 entiers");
int valeur1 = 5;
int valeur2 = 2;
int div_i = valeur1 / valeur2;
float div_f = valeur1 / valeur2; // donne 2 car la division de 2 entiers donne un entier
float div2_f = (float)valeur1 / valeur2;
Console.WriteLine(div_i);
Console.WriteLine(div_f);
Console.WriteLine(div2_f);

float valeur = 3;
float percent = 50.5f; 
float percentage = (valeur / percent) * 100;

Console.WriteLine("Exemple: passer de float à int");
float f1 = 0.5f;
float f2 = 0.4f;
//int ff = f1 + f2; ne fonctionne pas car perte de donnée (dans le passage de float à int)
int ff = (int)(f1 + f2);
#endregion