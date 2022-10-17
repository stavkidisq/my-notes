using CSharp4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{
    internal class Node<TKey, TValue>
    {
        public TValue Value { get; set; }
        public TKey Key { get; set; }
        public Node<TKey, TValue>? Next { get; set; } = null;

        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }

    internal class LinkedList<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        public Node<TKey, TValue>? Head { get; set; } = null;
        public Node<TKey, TValue> Tail { get; set; } = null!;
        public int Count { get; private set; } = 0;

        public void Add(TKey key, TValue value)
        {
            var node = new Node<TKey, TValue>(key, value);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;

            Count++;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            var current = Head;

            while(current != null)
            {
                yield return new KeyValuePair<TKey, TValue>(current.Key, current.Value);
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class MyHashTable<TKey, TValue>
    {
        private LinkedList<TKey, TValue>[] Buckets { get; set; } = new LinkedList<TKey, TValue>[]
        {
            new LinkedList<TKey, TValue>(),
            new LinkedList<TKey, TValue>(),
            new LinkedList<TKey, TValue>(),
            new LinkedList<TKey, TValue>(),
            new LinkedList<TKey, TValue>(),
            new LinkedList<TKey, TValue>(),
            new LinkedList<TKey, TValue>(),
            new LinkedList<TKey, TValue>()
        };

        public void InsertNode(TKey key, TValue value)
        {
            if (key == null)
                return;

            if (value == null)
                return;

            int hashCode = key.GetHashCode();
            int targetBucket = hashCode % Buckets.Length;

            if (Buckets[targetBucket].Count(item => item.Key?.GetHashCode() == hashCode && item.Key.Equals(key)) == 0)
                Buckets[targetBucket].Add(key, value);
        }

        public TValue? GetValue(TKey key)
        {
            if (key == null)
                return default(TValue);

            int hashCode = key.GetHashCode();
            int targetBucket = hashCode % Buckets.Length;

            return Buckets[targetBucket]
                .FirstOrDefault(item => 
                    item.Key?.GetHashCode() == hashCode && key.Equals(item.Key))
                .Value;
        }

        public void DisplayTree()
        {
            for(int i = 0; i < Buckets.Length; i++)
            {
                Console.Write($"[{i}] ");

                foreach(var bucket in Buckets[i])
                {
                    Console.Write($"({bucket.Key}, {bucket.Value}) -> ");
                }

                Console.Write("null\n");
            }
        }
    }
}
