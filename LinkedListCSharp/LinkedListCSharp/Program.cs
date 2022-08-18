using System;

namespace LinkedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Node('A');
            var b = new Node('B');
            var c = new Node('C');
            var d = new Node('D');
            var e = new Node('E');
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            //printLinkedList(a);
            printLinkedListRecursively(a);
        }

        public static void printLinkedList(Node head) {
            var curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.val);
                curr = curr.next;
            }
        }

        public static void printLinkedListRecursively(Node head) {
            if (head == null) return;
            Console.WriteLine(head.val);
            printLinkedListRecursively(head.next);
        }
    }

    public class Node {
        public char val;
        public Node next;

        public Node(char val) {
            this.val = val;
            this.next = null;
        }
    }
}

