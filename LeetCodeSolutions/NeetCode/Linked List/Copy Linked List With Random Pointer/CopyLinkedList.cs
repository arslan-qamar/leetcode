namespace Copy_Linked_List_With_Random_Pointer
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class CopyLinkedList
    {
        public static Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node curr = head;

            Dictionary<Node, Node> copyNodes = new Dictionary<Node, Node>();

            while (curr != null)
            {
                Node newCopy = new Node(curr.val);

                copyNodes[curr] = newCopy;

                curr = curr.next;
            }

            curr = head;

            while (curr != null)
            {
                Node newNode = copyNodes[curr];

                Node randomNode = curr.random != null ? copyNodes[curr.random] : null;
                Node nextNode = curr.next != null ? copyNodes[curr.next] : null;

                newNode.next = nextNode;
                newNode.random = randomNode;

                curr = curr.next;
            }

            return copyNodes[head];
        }
    }
}
