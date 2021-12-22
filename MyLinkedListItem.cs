using System;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class MyLinkedListItem
    {
        private string data = default;

        public MyLinkedListItem(string data)
        {
            Data = data;
        }

        public string Data
        {
            get => data;
            set => data = value ?? throw new ArgumentNullException(nameof(value));
        }

        public MyLinkedListItem Next { get; set; }
    }
}