using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Recursion
{
	class Program
	{
		static void Main(string[] args)
		{
			BST bst = new BST();
			Random rand = new Random();
			for (int i = 0; i < 10; i++)
			{
				bst.InsertRecursively(rand.Next(200));
			}
			Console.WriteLine("Tree:");
			bst.PrintTree();

			Console.ReadKey();
		}
	}
}
