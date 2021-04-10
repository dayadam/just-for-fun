using System;
using System.Collections;
using System.Collections.Generic;

namespace just_for_fun
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] var = { 2, 2, 2 };
            Program Program = new Program();
            Console.WriteLine(Program.Triangles(2, 2, 2));
            int[] nums1 = { 1, 2, 3, 4, 5, 1 };
            LinkedList<int> list1 = new LinkedList<int>(nums1);
            Console.WriteLine(Program.Get5thFromLastLinkedList
                (list1.First).Value);
        }

        public string Triangles(int side1,
            int side2, int side3)
        {

            if (side1 == side2 && side1 == side3)
            {
                return "Equilateral";
            }

            if (side1 == side2 || side1 == side3
                || side2 == side3)
            {
                return "Isosceles";
            }

            return "Scalene";
        }

        public LinkedListNode<int> Get5thFromLastLinkedList(
            LinkedListNode<int> head)
        {
            if (head == null)
                return null;

            ArrayList nodeList = new ArrayList();

            var currentNode = head;
            while (currentNode != null)
            {
                nodeList.Add(currentNode);
                currentNode = currentNode.Next;
            }

            int count = nodeList.Count;
            return (LinkedListNode<int>)nodeList[count - 5 - 1]; 

        }
    }

}
