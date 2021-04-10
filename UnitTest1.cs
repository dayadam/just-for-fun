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
        // [InlineData("Isosceles", new int[] { 5, 5, "yo" })]
        public void SidesShouldEqualTriangle(
            string expected,
            int side1, int side2, int side3)
        {
            // int[] var = { 2, 2, 2 };
            Assert.Equal(expected, _sut.Triangles(side1,
                side2, side3));
        }

        [Theory]
        // [InlineData(5, params )]
        //[InlineData("Isosceles", 20, 2, 2)]
        [MemberData(nameof(TestData))]

        // [InlineData("Isosceles", new int[] { 5, 5, "yo" })]
        public void FifthFromLastElInLinkedList(
        LinkedListNode<int> expected, LinkedListNode<int> firstNode)
        {
            // int[] var = { 2, 2, 2 };
            Assert.Equal(expected, _sut.
                Get5thFromLastLinkedList(firstNode));
        }

        public static IEnumerable<object[]> TestData()
        {
            int[] nums1 = {1, 2, 3, 4, 5, 1, 1, 1, 1, 1};
            LinkedList<int> list1 = new LinkedList<int>(nums1);
            // int Node1 = List1.First;
            yield return new object[] { list1.Find(5), list1.First };
        }

        //[Fact]
        //public void ThreeEqualIntegersShouldReturnEquilateral()
        //{
        //    int[] var = { 2, 2, 2 };
        //    Assert.Equal("Equilateral", _sut.Triangles(var));
        //}
    }
}
