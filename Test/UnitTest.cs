using CustomDoubleLinkedList.Extensions;
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
        }

        [Test]
        public void Test_Add_Items_In_Node()
        {

            linkedList.Add(10);
            linkedList.Add(5);
            linkedList.Add(7);
            linkedList.Add(1);
            linkedList.Add(8);


        }
    }
}