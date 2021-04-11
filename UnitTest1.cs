using System;
using System.Collections.Generic;
using Xunit;

namespace just_for_fun
{
    public class ProgramTests
    {
        private readonly just_for_fun.Program _sut;

        public ProgramTests()
        {
            _sut = new just_for_fun.Program();
        }

        [Theory]
        [InlineData("Equilateral",  2, 2, 2 )]
        [InlineData("Isosceles",  20, 2, 2 )]
        [InlineData("Isosceles",  10, 3, 10 )]
        [InlineData("Isosceles", 5, 5, 3 )]
        [InlineData("Scalene",  4, 5, 3 )]
        public void SidesShouldEqualTriangle(
            string expected,
            int side1, int side2, int side3)
        {
            Assert.Equal(expected, _sut.Triangles(side1,
                side2, side3));
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void FifthFromLastElInLinkedListInt(
        LinkedListNode<dynamic> expected, LinkedListNode<dynamic> firstNode)
        {
            Assert.Equal(expected, _sut.
                Get5thFromLastLinkedList(firstNode));
        }

        public static IEnumerable<object[]> TestData()
        {
            dynamic[] nums1 = {1, 2, 3, 4, 5, 1, 1, 1, 1, 1};
            LinkedList<dynamic> list1 = new LinkedList<dynamic>(nums1);
            yield return new object[] { list1.Find(5), list1.First };
            LinkedList<dynamic> list2 = new LinkedList<dynamic>();
            yield return new object[] { null, list2.First };
            dynamic[] nums3 = { 1, 2, 3 };
            LinkedList<dynamic> list3 = new LinkedList<dynamic>(nums3);
            yield return new object[] { null, list3.First };
        }

        [Theory]
        [MemberData(nameof(TestDataString))]
        public void FifthFromLastElInLinkedListString(
            LinkedListNode<dynamic> expected, LinkedListNode<dynamic> firstNode)
        {
            Assert.Equal(expected, _sut.
                Get5thFromLastLinkedList(firstNode));
        }

        public static IEnumerable<object[]> TestDataString()
        {
            dynamic[] strings1 = { "1", "2", "3", "4", "5",
                "1", "1", "1", "1", "1" };
            LinkedList<dynamic> list1 = new LinkedList<dynamic>(strings1);
            yield return new object[] { list1.Find("5"), list1.First };
            LinkedList<dynamic> list2 = new LinkedList<dynamic>();
            yield return new object[] { null, list2.First };
            dynamic[] strings3 = { "1", "2", "3" };
            LinkedList<dynamic> list3 = new LinkedList<dynamic>(strings3);
            yield return new object[] { null, list3.First };
        }

        [Theory]
        [MemberData(nameof(TestDataPrime))]
        public void ReturnsPrimeList(List<int> expected,
            string number)
        {
            Assert.Equal(expected, _sut.GetPrimeFactors(number));
        }

        public static IEnumerable<object[]> TestDataPrime()
        {
            int[] ints1 = { 2 };
            List<int> list1 = new List<int>(ints1);
            yield return new object[] { list1, "2" };
            int[] ints2 = { 3, 5 };
            List<int> list2 = new List<int>(ints2);
            yield return new object[] { list2, "15" };
            int[] ints3 = { 3, 7 };
            List<int> list3 = new List<int>(ints3);
            yield return new object[] { list3, "21" };
            List<int> list4 = new List<int>();
            yield return new object[] { list4, "-21" };
        }

    }
}
