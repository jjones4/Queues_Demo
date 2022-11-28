using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Library
{
    public class CustomQueue<T>
    {
        QueueElement<T>? _firstElement;
        QueueElement<T>? _nextElement;

        public void QueueData(T data)
        {
            Console.WriteLine($"We have queued {data}.");

            if (_firstElement == null)
            {
                _firstElement = new QueueElement<T>(null, data);
            }
            else if (_nextElement == null)
            {
                _nextElement = new QueueElement<T>(null, data);
                _firstElement.Next = _nextElement;
            }
            else
            {
                QueueElement<T> lastElement = new QueueElement<T>(null, data);
                _nextElement.Next = lastElement;
                _nextElement = lastElement;
            }
        }

        public T DequeueData()
        {
            if (_firstElement == null)
            {
                throw new InvalidOperationException();
            }

            T result = _firstElement.Data;
            _firstElement = _firstElement.Next;

            return result;
        }
    }
}
