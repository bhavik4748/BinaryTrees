using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees 
{
    public class BinnarSearchTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int d)
            {
                this.data = d;
            }
        }
        public Node root;
        public BinnarSearchTree()
        {
            root = null;
        }

        public Node insert(Node root, int d)
        {
            Node n = new Node(d);
            if (root == null)
            {
                root = n;
                return root;
            }
            else
            {
                Node curr;
                if (d <= root.data)
                {
                    curr = insert(root.left, d);
                    root.left = curr;
                }
                else
                {
                    curr = insert(root.right, d);
                    root.right = curr;
                }
                return root;
            }
        }

        public int Height(Node r)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (r.left != null)
            {
                leftHeight = 1 + Height(r.left);
            }

            if (r.right != null)
            {
                rightHeight = 1 + Height(r.right);
            }
            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            BinnarSearchTree t = new BinnarSearchTree();

            t.root = t.insert(t.root, 3);
            t.root = t.insert(t.root, 5);
            t.root = t.insert(t.root, 2);
            t.root = t.insert(t.root, 1);
            t.root = t.insert(t.root, 4);
            t.root = t.insert(t.root, 6);
            t.root = t.insert(t.root, 7);

            int height = t.Height(t.root);
            Console.WriteLine("Height of tree = "+ height);

            Console.WriteLine();
        }
    }
}
