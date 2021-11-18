using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATD {
    class MyQueue<T> {

        private T[] arr;
        private int size;
        private int front;
        private int back;
        private int numOfElem;
        
        public MyQueue(int size) {
            this.size = size;
            arr = new T[this.size];
            front = 0;
            back = -1;
            numOfElem = 0;
        }

        public void Add(T newElem) {
            if (numOfElem == size) {
                ShowErrorMessage("Невозможно добавить элемент, очередь заполнена");
            }
            else {
                if (IsElemLastInArray(back)) {
                    back = -1;
                }
                InsertElemIntoArray(newElem);
            }
        }

        public int GetSize() {
            return numOfElem;
        }

        private bool IsElemLastInArray(int elemNum) {
            return (elemNum == size - 1);
        }

        private void InsertElemIntoArray(T elem) {
                back++;
                arr[back] = elem;
                numOfElem++;
        }

        public void Remove() {
            if (numOfElem != 0) {
                if (IsElemLastInArray(front))
                    front = -1;
                front++;
                numOfElem--;
            }
            else
                ShowErrorMessage("Невозможно удалить элемент, очередь пуста");
        }

        private void ShowErrorMessage(string mess) {
            Console.WriteLine("Ошибка: " + mess);
        }
       
        public T Peek() {
            if (numOfElem==0)
                ShowErrorMessage("Очередь пуста");
            return arr[front];
        }

        public bool Contains(T elem) {
            int currElem=front;
            int allElem = numOfElem;
            while (allElem>0) {
                if (arr[currElem].Equals(elem))
                    return true;
                if (IsElemLastInArray(currElem))
                    currElem = -1;
                currElem++;
                allElem--;
            }
            return false;
        }
    }
}
