using System;

namespace Collections
{
    class CollectionsExamples
    {
        static void Main()
        {
            Console.WriteLine("CircularQueue<T> Examples");
            Console.WriteLine("=========================");
            Console.WriteLine();

            var queue = new CircularQueue<int>();
            Console.WriteLine(queue);
            Console.WriteLine();

            queue.Enqueue(1);
            Console.WriteLine(queue);
            Console.WriteLine();

            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Console.WriteLine(queue);
            Console.WriteLine();

            var first = queue.Dequeue();
            Console.WriteLine("First = {0}", first);
            Console.WriteLine(queue);
            Console.WriteLine();

            queue.Enqueue(-7);
            queue.Enqueue(-8);
            queue.Enqueue(-9);
            Console.WriteLine(queue);
            Console.WriteLine($"Count = {queue.Count}. Capacity = {queue.Capacity}");
            Console.WriteLine($"StartIndex = {queue.StartIndex}. EndIndex = {queue.EndIndex}");
            Console.WriteLine();

            first = queue.Dequeue();
            Console.WriteLine("First = {0}", first);
            Console.WriteLine(queue);
            Console.WriteLine();

            queue.Enqueue(-10);
            Console.WriteLine("Count = {0}", queue.Count);
            Console.WriteLine(queue);
            Console.WriteLine();

            first = queue.Dequeue();
            Console.WriteLine("First = {0}", first);
            Console.WriteLine(queue);
            Console.WriteLine($"Count = {queue.Count}. Capacity = {queue.Capacity}");
            Console.WriteLine($"StartIndex = {queue.StartIndex}. EndIndex = {queue.EndIndex}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Collection<T> Examples");
            Console.WriteLine("======================");
            Console.WriteLine();

            Collection<int> nums = new Collection<int>();
            Console.WriteLine($"Empty collection: {nums}");
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();

            nums = new Collection<int>(new int[] { 10, 20, 30, 40, 50 });
            Console.WriteLine(nums);
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();

            nums.Add(60);
            Console.WriteLine("Added: 60");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums[1] = 2000;
            nums[5] = 6000;
            Console.WriteLine("Changed: nums[1] and nums[5]");
            Console.WriteLine(nums);
            Console.WriteLine();

            Console.WriteLine($"num[0] = {nums[0]}");
            Console.WriteLine($"num[3] = {nums[3]}");
            Console.WriteLine();

            var removedItem = nums.RemoveAt(0);
            Console.WriteLine($"Removed item from position #0. Value = {removedItem}");
            Console.WriteLine(nums);
            Console.WriteLine();

            removedItem = nums.RemoveAt(4);
            Console.WriteLine($"Removed item from position #4. Value = {removedItem}");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums.Exchange(0, 1);
            Console.WriteLine("Exchanged positions #0 and #1");
            Console.WriteLine(nums);
            Console.WriteLine();

            for (int i = 1; i <= 20; i++)
                nums.Add(i);
            Console.WriteLine("Added numbers [1...20]");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums.InsertAt(0, 10);
            nums.InsertAt(1, 15);
            Console.WriteLine("Inserted 10 at the start and 15 after it");
            Console.WriteLine(nums);
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();
        }
    }
}
