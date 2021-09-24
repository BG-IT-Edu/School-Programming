using NUnit.Framework;
using System.Linq;

namespace Collections.Tests
{
    class CircularQueueTests
    {
        [Test]
        public void Test_CircularQueue_ConstructorDefault()
        {
            var queue = new CircularQueue<int>();
            Assert.That(queue.ToString() == "[]");
            Assert.That(queue.Count == 0);
            Assert.That(queue.Capacity > 0);
            Assert.That(queue.StartIndex == 0);
            Assert.That(queue.EndIndex == 0);
        }

        [Test]
        public void Test_CircularQueue_ConstructorWithCapacity()
        {
            var queue = new CircularQueue<int>(3);
            Assert.That(queue.ToString() == "[]");
            Assert.That(queue.Count == 0);
            Assert.That(queue.Capacity == 3);
            Assert.That(queue.StartIndex == 0);
            Assert.That(queue.EndIndex == 0);
        }

        [Test]
        public void Test_CircularQueue_Enqueue()
        {
            var queue = new CircularQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Assert.That(queue.ToString() == "[10, 20, 30]");
            Assert.That(queue.Count == 3);
            Assert.That(queue.Capacity >= queue.Count);
        }

        [Test]
        public void Test_CircularQueue_EnqueueWithGrow()
        {
            const int initialCapacity = 4;
            var queue = new CircularQueue<int>(initialCapacity);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            Assert.That(queue.ToString() == "[10, 20, 30, 40, 50]");
            Assert.That(queue.Count == 5);
            Assert.That(queue.Capacity >= initialCapacity);
        }

        [Test]
        public void Test_CircularQueue_Dequeue()
        {
            var queue = new CircularQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            var firstElement = queue.Dequeue();
            Assert.That(firstElement == 10);
            var secondElement = queue.Dequeue();
            Assert.That(secondElement == 20);
            Assert.That(queue.ToString() == "[30, 40]");
            Assert.That(queue.Count == 2);
            Assert.That(queue.Capacity >= queue.Count);
        }

        [Test]
        public void Test_CircularQueue_DequeueEmpty()
        {
            var queue = new CircularQueue<int>();
            Assert.That(() => queue.Dequeue(), Throws.InvalidOperationException);

            queue.Enqueue(10);
            queue.Dequeue();
            Assert.That(() => queue.Dequeue(), Throws.InvalidOperationException);
        }

        [Test]
        public void Test_CircularQueue_EnqueueDequeue_WithRangeCross()
        {
            var queue = new CircularQueue<int>(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            var firstElement = queue.Dequeue();
            Assert.That(firstElement, Is.EqualTo(10));
            var secondElement = queue.Dequeue();
            Assert.That(secondElement, Is.EqualTo(20));
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            Assert.That(queue.ToString() == "[30, 40, 50, 60]");
            Assert.That(queue.Count == 4);
            Assert.That(queue.Capacity == 5);
            Assert.That(queue.StartIndex > queue.EndIndex);
        }

        [Test]
        public void Test_CircularQueue_Peek()
        {
            var queue = new CircularQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.That(queue.Peek() == 10);
            Assert.That(queue.Count == 3);
            Assert.That(queue.ToString() == "[10, 20, 30]");

            queue.Dequeue();
            Assert.That(queue.Peek() == 20);
            Assert.That(queue.Count == 2);
            Assert.That(queue.ToString() == "[20, 30]");
        }

        [Test]
        public void Test_CircularQueue_PeekEmpty()
        {
            var queue = new CircularQueue<int>();
            Assert.That(() => queue.Peek(), Throws.InvalidOperationException);

            queue.Enqueue(10);
            queue.Dequeue();
            Assert.That(() => queue.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Test_CircularQueue_ToArray()
        {
            var queue = new CircularQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var array = queue.ToArray();

            CollectionAssert.AreEqual(new int[] { 10, 20, 30 }, array);
        }

        [Test]
        public void Test_CircularQueue_ToArray_WithRangeCross()
        {
            var queue = new CircularQueue<int>(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);

            var array = queue.ToArray();

            CollectionAssert.AreEqual(new int[] { 30, 40, 50, 60 }, array);
            Assert.That(queue.StartIndex > queue.EndIndex);
        }

        [Test]
        public void Test_CircularQueue_ToString()
        {
            var queue = new CircularQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var queueStr = queue.ToString();

            Assert.AreEqual("[10, 20, 30]", queueStr);
        }

        [Test]
        public void Test_CircularQueue_MultipleOperations()
        {
            const int initialCapacity = 2;
            const int iterationsCount = 300;
            var queue = new CircularQueue<int>(initialCapacity);
            int addedCount = 0;
            int removedCount = 0;
            int counter = 0;
            for (int i = 0; i < iterationsCount; i++)
            {
                Assert.That(queue.Count == addedCount - removedCount);

                queue.Enqueue(++counter);
                addedCount++;
                Assert.That(queue.Count == addedCount - removedCount);

                queue.Enqueue(++counter);
                addedCount++;
                Assert.That(queue.Count == addedCount - removedCount);

                var firstElement = queue.Peek();
                Assert.That(firstElement == removedCount + 1);

                var removedElement = queue.Dequeue();
                removedCount++;
                Assert.That(removedElement == removedCount);
                Assert.That(queue.Count == addedCount - removedCount);

                var expectedElements = Enumerable.Range(
                    removedCount + 1, addedCount - removedCount).ToArray();
                var expectedStr = "[" + string.Join(", ", expectedElements) + "]";

                var queueAsArray = queue.ToArray();
                var queueAsString = queue.ToString();

                CollectionAssert.AreEqual(expectedElements, queueAsArray);
                Assert.AreEqual(expectedStr, queueAsString);

                Assert.That(queue.Capacity >= queue.Count);
            }

            Assert.That(queue.Capacity > initialCapacity);
        }

        [Test]
        public void Test_CircularQueue_1MillionItems()
        {
            const int iterationsCount = 1000000;
            var queue = new CircularQueue<int>();
            int addedCount = 0;
            int removedCount = 0;
            int counter = 0;
            for (int i = 0; i < iterationsCount / 2; i++)
            {
                queue.Enqueue(++counter);
                addedCount++;

                queue.Enqueue(++counter);
                addedCount++;

                queue.Dequeue();
                removedCount++;
            }
            Assert.That(queue.Count == addedCount - removedCount);
        }
    }
}
