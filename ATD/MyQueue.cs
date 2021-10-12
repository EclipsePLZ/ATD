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
            if (back == size - 1) {
                back = -1;
                numOfElem = 0;
            }
            InsertElemIntoArray(newElem);
        }

        private void InsertElemIntoArray(T elem) {
            back++;
            arr[back] = elem;
            numOfElem++;
        }

        public void Remove() {

        }

        public T Peek() {
            return arr[front];
        }
    }
}
