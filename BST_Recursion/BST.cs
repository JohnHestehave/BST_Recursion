using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BST_Recursion
{
	public class BST
	{
		public BSTNode root;

		public int count;

		public void Insert(IComparable data)
		{
			if (root == null)
			{
				root = new BSTNode();
				root.data = data;
				count = 1;
			}
			else
			{
				BSTNode node = root;
				while (node != null)
				{
					if (data.CompareTo(node.data) < 0)
					{
						if (node.left == null)
						{
							node.left = new BSTNode();
							node.left.data = data;
							count++;
							break;
						}
						node = node.left;
					}
					else
					{
						if (node.right == null)
						{
							node.right = new BSTNode();
							node.right.data = data;
							count++;
							break;
						}
						node = node.right;
					}
				}

			}
		}

		public void InsertRecursively(IComparable data)
		{
			InsertRecursively(ref root, data);
		}
		public void InsertRecursively(ref BSTNode n, IComparable data)
		{
			if(n == null)
			{
				n = new BSTNode();
				n.data = data;
			}else
			{
				if (data.CompareTo(n.data) < 0)
				{
					InsertRecursively(ref n.left, data);
				}else
				{
					InsertRecursively(ref n.right, data);
				}
			}
		}

		public bool Search(IComparable data)
		{
			BSTNode node = root;
			while (node != null)
			{
				if (data.CompareTo(node.data) < 0)
				{
					node = node.left;
				}
				else if (data.CompareTo(node.data) > 0)
				{
					node = node.right;
				}
				else
				{
					return true;
				}
			}
			return false;

		}

		public void PrintTree()
		{
			if (root != null)
			{
				root.PrintData();
			}
		}
	}
}
