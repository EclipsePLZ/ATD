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
            if (IsElemLastInArray(back)) {
                back = -1;
                numOfElem = 0;
            }
            InsertElemIntoArray(newElem);
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
            if (IsElemLastInArray(front))
                front = 0;
            else
                front++;
            if(numOfElem!=0)
                numOfElem--;
        }
       
        public T Peek() {
            return arr[front];
        }
    }
}
