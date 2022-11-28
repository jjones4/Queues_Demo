using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Library
{
    public class QueueElement<T>
    {
        public QueueElement<T>? Next { get; set; }
        public T Data { get; set; }

        public QueueElement(QueueElement<T>? next, T data)
        {
            Next = next;
            Data = data;
        }
    }
}
