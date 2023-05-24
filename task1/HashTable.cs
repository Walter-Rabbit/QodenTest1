using System.Text;
using System.Collections.Generic;

namespace task1
{
    public class HashTable
    {
        public int Divider { get; }
        public List<ListNode> Values { get; }

        public HashTable(int divider)
        {
            Divider = divider;

            Values = new List<ListNode>(Divider);
            for (var i = 0; i < Divider; i++)
            {
                Values.Add(new ListNode());
            }
        }

        public void Insert(int value)
        {
            var hash = value % Divider;
            Values[hash].Insert(value);
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            for (var i = 0; i < Values.Count; i++)
            {
                output.Append(i);
                output.Append(':');

                var node = Values[i];
                while (node.Next != null)
                {
                    output.Append(' ');
                    output.Append(node.Next.Value);

                    node = node.Next;
                }

                output.Append('\n');
            }

            return output.ToString();
        }
    }
}