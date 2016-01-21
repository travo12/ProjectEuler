using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PEuler_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // gather input
            // Make a Linked List Binary Tree out of the input file
            string file = "C:/data/peuler18.txt";
            NodeTree mytree = gettree(file);
            mytree.FindHighestRoute(0 , mytree.RootNode);

            Console.WriteLine("The Highest value by brute force is "+ mytree.highestroute);
            Console.Read();
        }

        static NodeTree gettree(string filename)
        {
            TextReader reader = File.OpenText(filename);
            string line;
            int depth = 1;
            NodeTree tree = new NodeTree { highestroute = 0 };
            while ((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split(new char[] {' '});

                for (int i = 0; i < fields.Length; i++ )
                {
                    int NodeVal = Int32.Parse(fields[i]);
                    Console.WriteLine("adding to nodetree value " + NodeVal + " at depth " + depth);
                    tree.AddNode(NodeVal);
                }
                depth++;
            }
            return tree;
            
        }

    }

    public class NodeTree
    {
        public Node RootNode { get; set; }
        public int highestroute { get; set; }
        public int length
        {
            get
            {
                int counter = 1;
                if (RootNode == null) return 0;
                Node travelnode = RootNode;
                while (travelnode.LeftChild != null)
                {
                    travelnode = travelnode.LeftChild;
                    counter++;
                }
                return counter;
            }
        }
        public void FindHighestRoute(int currentval, Node CurrentNode)
        {
            currentval += CurrentNode.Value;

            if (CurrentNode.LeftChild == null)
            {
                if(currentval > highestroute) highestroute = currentval;
                return;
            }
            else
            {
                FindHighestRoute(currentval, CurrentNode.LeftChild);
                FindHighestRoute(currentval, CurrentNode.RightChild);
            }

            
        }

        public void AddNode(int NodeValue)
        {
            Node newNode = new Node { Value = NodeValue };
            if (RootNode == null)
            {
                RootNode = newNode;
                RootNode.depth = 1;
                RootNode.rownum = 1;
                return;
            }
            Node SearchNode = RootNode;
            while(true)
            {
                if (SearchNode.LeftChild == null)
                {
                    SearchNode.LeftChild = newNode;
                    newNode.depth = SearchNode.depth + 1;
                    newNode.rownum = SearchNode.rownum;
                    newNode.RightParent = SearchNode;
                    Console.WriteLine("Node added at depth " + newNode.depth + " and row " + newNode.rownum);

                    if (newNode.rownum != 1)
                    {
                        newNode.LeftParent = SearchNode.LeftParent.LeftChild;
                        SearchNode.LeftParent.LeftChild.RightChild = newNode;
                    }
                    break;
                }
                if (SearchNode.RightChild == null)
                {
                    SearchNode.RightChild = newNode;
                    newNode.depth = SearchNode.depth + 1;
                    newNode.rownum = SearchNode.rownum + 1;
                    newNode.LeftParent = SearchNode;
                    Console.WriteLine("Node added at depth " + newNode.depth + " and row " + newNode.rownum);

                    if (newNode.rownum != newNode.depth)
                    {
                        newNode.RightParent = SearchNode.RightParent.RightChild;
                        SearchNode.RightParent.RightChild.LeftChild = newNode;
                    }
                    break;
                }
                // if we are at the far right, go to new row
                if (SearchNode.depth == SearchNode.rownum)
                {
                    int tmp = SearchNode.depth;
                    SearchNode = RootNode;
                    for (int i = 1; i <= tmp; i++) SearchNode = SearchNode.LeftChild;
                }
                else SearchNode = SearchNode.RightParent.RightChild;

            }


        }
    }


    public class Node
    {
        public int depth { get; set; }
        public int rownum { get; set; }
        public Node LeftParent { get; set; }
        public Node RightParent { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Value { get; set; }
    }
}
