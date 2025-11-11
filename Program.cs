namespace Assignment12._2._1
{
    internal class Program
    {
        public Node RemoveElements(Node head, int data)
        {
            Node dummy = new Node(0);
            dummy.Next = head;
            Node current = dummy;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
            return dummy.Next;
        }
        public static Node GetLinkedList()
        {
            Node head = new Node();
            head.Next = new Node(2);
            head.Next.Next = new Node(6);
            head.Next.Next.Next = new Node(3);
            head.Next.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next.Next = new Node(5);
            head.Next.Next.Next.Next.Next.Next = new Node(6);
            return head;
        }

        public static void PrintNode(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Node head = GetLinkedList();
            int data = 6;
            Console.WriteLine("Original LinkedList:");
            PrintNode(head);
            Console.WriteLine($"Value: {data}");
            Node newHead = new Program().RemoveElements(head, data);
            Console.WriteLine("New LinkedList:");
            PrintNode(newHead);
        }
    }
}
