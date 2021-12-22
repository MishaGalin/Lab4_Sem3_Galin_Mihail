using System.Collections;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class MyLinkedList : IEnumerable
    {
        private readonly string Message;
        public MyLinkedListItem Head { get; private set; }
        public MyLinkedListItem Tail { get; private set; }
        public int Count { get; private set; }

        public MyLinkedList()
        {
            Clear();
        }

        public MyLinkedList(string data)
        {
            SetHeadAndTail(data);
        }

        public void Add(string data)
        {
            if (Tail != null)
            {
                var item = new MyLinkedListItem(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else SetHeadAndTail(data);
        }

        private void SetHeadAndTail(string data)
        {
            var item = new MyLinkedListItem(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        void DeleteFirst()
        {
            Head = Head.Next;
            Count--;
        }

        void DeleteLast()
        {
        }

        public void Delete(string data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    DeleteFirst();
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AppendHead(string data)
        {
            var item = new MyLinkedListItem(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }

        public void InsertAfter(string target, string data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new MyLinkedListItem(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }
    }
}