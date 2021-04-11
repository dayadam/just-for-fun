using System;
using System.Collections;
using System.Collections.Generic;

namespace just_for_fun
{
    class Program
    {
        static void Main(string[] args)
        {

            Program Program = new Program();
            Console.WriteLine(Program.Triangles(2, 2, 2));
            dynamic[] nums1 = { 1, 2, 3, 4, 5, 1 };
            LinkedList<dynamic> list1 = new LinkedList<dynamic>(nums1);
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

            public LinkedListNode<dynamic> Get5thFromLastLinkedList(
                LinkedListNode<dynamic> head)
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

                if (nodeList.Count < 6)
                {
                    return null;
                }
                return (LinkedListNode<dynamic>)nodeList[
                    nodeList.Count - 5 - 1];

            }
    }

}
