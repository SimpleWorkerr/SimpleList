using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList
{
    internal class MyList<T>
    {
        private int _listSize = 0;
        public Node<T>? _pHead = null;
        
        public T this[int index]
        {
            get 
            {
                Node<T>? tempNode = _pHead;
                int indexHelper = 0;

                if (tempNode != null)
                {
                    while (indexHelper < index && tempNode.pNext != null)
                    {
                        indexHelper++;
                        tempNode = tempNode.pNext;
                    }

                    return tempNode.Value;
                }
                else
                {
                    throw new Exception("В списке ничего нет");
                }
            }
            set
            {
                Node<T>? tempNode = _pHead;
                int indexHelper = 0;

                if (tempNode != null)
                {
                    while (indexHelper < index && tempNode.pNext != null)
                    {
                        indexHelper++;
                        tempNode = tempNode.pNext;
                    }

                    tempNode.Value = value;
                };
            }
        }

        public void PushBack(T value)
        {
            if(_pHead == null)
                _pHead = new Node<T>(value);

            else
            {
                Node<T> pTemp = _pHead;

                while (pTemp.pNext != null)
                    pTemp = pTemp.pNext;

                pTemp.pNext = new Node<T>(value);
            }
            _listSize++;
        }
        public void PushFront(T value)
        {
            _pHead = new Node<T>(value, _pHead);
            _listSize++;
        }
 
        public T PopFront()
        {
            if(_pHead == null)
            {
                throw new Exception("В списке ничего нет");
            }

            else
            {
                T resultValue = _pHead.Value;
                _pHead = _pHead.pNext;
                _listSize--;
                return resultValue;
            }
            
        }
        public void DisplayInfo()
        {
            Node<T>? pTemp = _pHead;

            while (pTemp != null)
            {
                Console.WriteLine(pTemp.Value);
                pTemp = pTemp.pNext;
            }
            Console.WriteLine($"Размер списка: {_listSize}");
        }
       
    }
}
