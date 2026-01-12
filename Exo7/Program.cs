using Exo7.Models;
// 1. Dans les structures Celsius et Fahrenheit, écrire la fonction de conversion de l’une vers l’autre.
Celsius c1;
c1.Temperature = 23.5;
Console.WriteLine($"Temp (c1) : {c1.Temperature} °C");

Fahrenheit f1 = c1.ToFahrenheit();
Console.WriteLine($"Temp (f1) : {f1.Temperature} °F");

Celsius c2 = f1.ToCelsius();
Console.WriteLine($"Temp (c2) : {c2.Temperature} °C");

Console.WriteLine(new string('=', 20));
/*
  2. Ecrire une structure pour résoudre une équation du second degré.
La structure devra contenir :
◼ Trois variables membres publiques A, B et C de type double.
◼ Une méthode publique « Resoudre » retournant une valeur de type « bool » stipulant si une réponse a été trouvée et devra retourner également les
valeurs de X1 et de X2 de type double.
◼ Si aucune solution n’a été trouvée, les valeurs de X1 et de X2 doivent être égale à « null »
 */
Equation equation = new Equation();

equation.A = 2;
equation.B = 9;
equation.C = -5;

equation.Resoudre(out double? X1, out double? X2);

Console.WriteLine($"X1 ► {X1} , X2 ► {X2}");