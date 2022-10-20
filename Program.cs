using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Create_Binary_Tree
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
        static int lcnt = 0;
        static int rcnt = 0;
        public void Insert(T data)
        {
            //Inserting Data In Binary Search Tree
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(data)) > 0) //checking If The Element Is Big or Small Then Root Node
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
                lcnt++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                rcnt++;
                this.RightTree.Display();
            }
        }
        public int size() //For Counting The Elements In Binary Search Tree
        {
            return (1 + lcnt + rcnt);
        }
    }
    internal class BST2
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            bst.Display();
            Console.WriteLine("Size Of Binary Search Tree Is:" + bst.size());
            Console.ReadLine();
        }
    }
}
