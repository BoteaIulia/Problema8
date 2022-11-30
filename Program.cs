using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class Globals
{
    public static object ConsoleInput { get; private set; }

    internal static void Main()
	{
		Console.Write("SWAP restrictionat - Introduceti valorile variabilelor:");
		Console.Write("\n");
		int a;
		int b;
		Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());

		a = a + b;
		b = a - b;
		a = a - b;

		Console.Write("Valorile lor schimbate:");
		Console.Write("\n");
		Console.Write("a = ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write("b = ");
		Console.Write(b);
	}
}



