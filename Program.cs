using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_Adding_56_then_adding_30_70
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get; set;
        }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodedata)
        {
            this.NodeData = nodedata;
            this.LeftTree = null;
            this.RightTree = null;
        }
        public void Insert(T data)
        {
            //Inserting Data In Binary Search Tree
            T cuurentNodeData = this.NodeData;
            if ((cuurentNodeData.CompareTo(data)) > 0) //checking If The Element Is Big or Small Then Root Node
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(data);
                }
                else
                {
                    this.LeftTree.Insert(data);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(data);
                }
                else
                {
                    this.RightTree.Insert(data);
                }
            }
        }
        public void Display() //Element Will Be Display Like LeftNode-->RootNode-->RightNode
        {
            //Displaying The Values In Binary Search Tree
            if (this.LeftTree != null)
            {
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.RightTree.Display();
            }
        }
    }
    internal class BST1
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
            Console.ReadLine();
        }
    }
}

