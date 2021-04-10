using System;
using System.Collections;
using System.Collections.Generic;

namespace just_for_fun
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("New");

            //if (args[0] == "Triangles")
            // {
            int[] var = { 2, 2, 2 };
            Program Program = new Program();
            Console.WriteLine(Program.Triangles(2, 2, 2));
            int[] nums1 = { 1, 2, 3, 4, 5, 1 };
            LinkedList<int> list1 = new LinkedList<int>(nums1);
            Console.WriteLine(Program.Get5thFromLastLinkedList
                (list1.First).Value);
            // }
        }

        //private object Get5thFromLastLinkedList(LinkedListNode<int> first)
        //{
        //    throw new NotImplementedException();
        //}

        public string Triangles(int side1,
            int side2, int side3)

        {
            //int firstItem;
            //foreach (int item in lengthOfSides)
            //{
            //    firstItem = item;
            //    Console.WriteLine(item);
            //}

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
        //LinkedList<int> linkedList
        public LinkedListNode<int> Get5thFromLastLinkedList(
            LinkedListNode<int> head)
        {
            if (head == null)
                return null;

            ArrayList nodeList = new ArrayList();
            int length = 0;

            var currentNode = head;
            while (currentNode != null)
            {
                nodeList.Add(currentNode);
                length++;
                currentNode = currentNode.Next;
            }

            int count = nodeList.Count;
            return (LinkedListNode<int>)nodeList[count - 5 - 1]; 

            //LinkedListNode<int> prev = null;
            //LinkedListNode<int> next = head.Next;
            //while (next != null)
            //{
            //    head.Next = prev;
            //    prev = head;
            //    head = next;
            //    next = head.Next;
            //}

            //int counter = 0;
            //prev = null;
            //next = head.next;
            //while (counter < 5)
            //{
            //    head.next = prev;
            //    prev = head;
            //    head = next;
            //    next = head.next;
            //    counter++;
            //}
            //return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
