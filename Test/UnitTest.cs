using CustomDoubleLinkedList.Models;

namespace Test
{
    public class Tests
    {
        private DoubleLinkedList linkedList;
        [SetUp]
        public void Setup()
        {
            linkedList = new DoubleLinkedList();

            linkedList.Add(10);
            linkedList.Add(5);
            linkedList.Add(7);
        }

        [Test]
        public void Test_Add_Nodes()
        {
            //arrange
            var expected = 5;

            // act
            linkedList.Add(1);
            linkedList.Add(8);

            // assert
            Assert.AreEqual(linkedList.Length, expected);
        }

        [Test]
        public void Test_Add_First_Node()
        {
            //arrange
            var expectedLength = 4;
            var expectedFirstNode = 5;

            //act
            linkedList.AddFirst(5);

            // assert
            Assert.AreEqual(linkedList.First.Value, expectedFirstNode);
            Assert.AreEqual(linkedList.Length, expectedLength);

        }

        [Test]
        public void Test_Add_Last_Node()
        {
            // arrange
            var expectedLastNode = 5;
            var expectedLength = 4;

            //act
            linkedList.AddLast(5);

            // assert
            Assert.AreEqual(linkedList.Last.Value, expectedLastNode);
            Assert.AreEqual(linkedList.Length, expectedLength);

        }

        [Test]
        public void Test_Remove_Node_At_Position_1()
        {
            //arrange
            var expectedLastNode = 2;

            //act
            linkedList.RemoveAt(1);

            //assert
            Assert.AreEqual(linkedList.Length, expectedLastNode);

        }

        [Test]
        public void Test_Remove_Node_At_Last_Position()
        {
            //arrange
            var expectedLastNode = 5;
            var expectedLength = 2;

            //act
            linkedList.RemoveAt(3);

            //assert
            Assert.AreEqual(linkedList.Length, expectedLength);
            Assert.AreEqual(linkedList.Last.Value, expectedLastNode);

        }
    }
}