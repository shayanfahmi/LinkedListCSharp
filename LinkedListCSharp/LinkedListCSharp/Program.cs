using System;

namespace LinkedListCSharp
{
    public class Node<T>
    {
        public T val;
        public Node<T> next;

        public Node(T val)
        {
            this.val = val;
            this.next = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var a = new Node<char>('A');
            //var b = new Node<char>('B');
            //var c = new Node<char>('C');
            //var d = new Node<char>('D');
            //var e = new Node<char>('E');
            //a.next = b;
            //b.next = c;
            //c.next = d;
            //d.next = e;
            //printLinkedList(a);
            //printLinkedListRecursively(a);

            //Sum Of linked List
            //var a = new Node<int>(1);
            //var b = new Node<int>(2);
            //var c = new Node<int>(3);
            //var d = new Node<int>(4);
            //var e = new Node<int>(5);
            //a.next = b;
            //b.next = c;
            //c.next = d;
            //d.next = e;
            ////Console.WriteLine(SumLinkedList(a));
            //Console.WriteLine(SumLinkedListRecursively(a));

            //Find element in linked list
            var a = new Node<char>('A');
            var b = new Node<char>('B');
            var c = new Node<char>('C');
            var d = new Node<char>('D');
            var e = new Node<char>('E');
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            //Console.WriteLine(FindElementInLinkedList(a, 'A'));
            Console.WriteLine(FindElementInLinkedListRecursively(a, 'P'));
        }

        private static bool FindElementInLinkedListRecursively(Node<char> head, char check)
        {
            if (head == null) return false;
            if (head.val == check) return true;
            return FindElementInLinkedListRecursively(head.next, check);
        }

        private static bool FindElementInLinkedList(Node<char> head, char find)
        {
            var curr = head;
            while (curr != null) {
                if (curr.val == find) {
                    return true;
                }
                curr = curr.next;
            }

            return false;
        }

        private static int SumLinkedListRecursively(Node<int> head)
        {
            if (head == null) return 0;
            return head.val + SumLinkedListRecursively(head.next);
        }

        public static int SumLinkedList(Node<int> head)
        {
            var curr = head;
            int sum = 0;

            while (curr != null)
            {
                sum += curr.val;
                curr = curr.next;
            }

            return sum;
        }

        public static void printLinkedList(Node<char> head) {
            var curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.val);
                curr = curr.next;
            }
        }

        public static void printLinkedListRecursively(Node<char> head) {
            if (head == null) return;
            Console.WriteLine(head.val);
            printLinkedListRecursively(head.next);
        }
    }

}

