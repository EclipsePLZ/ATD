using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATD {
    class Tests {
        public void StartRandomDataTesting(int size) {
            MyQueue<int> queue = new MyQueue<int>(size);
            Random rnd = new Random();

            //start Add elements
            for (int i = 0; i < size; i++) {
                int newElem = rnd.Next(0, 100);
                queue.Add(newElem);
                ShowInformation("Add", queue,newElem);
            }

            //start Contains elements
            for(int i = 0; i <= 100; i++) {
                bool result = queue.Contains(i);
                ShowInformation("Contains", i, result);
            }

            //start Remove half elements
            for (int i=0; i<size; i++) {
                queue.Remove();
                ShowInformation("Remove", queue);
            }

            int elem = rnd.Next(0, 100);
            queue.Add(elem);
            ShowInformation("Add", queue, elem);

            //start new Contains elements
            for (int i = 0; i <= 100; i++) {
                bool result = queue.Contains(i);
                ShowInformation("Contains", i, result);
            }
        }

        private void ShowInformation(string opearation, MyQueue<int> queue, int element) {
            Console.WriteLine("Successful <" + opearation + " " + element + "> operation\nFront queue element: " + queue.Peek()+'\n');
        }

        private void ShowInformation(string opearation, MyQueue<int> queue) {
            Console.WriteLine("Successful <" + opearation + "> operation\nFront queue element: " + queue.Peek() + '\n');
        }

        private void ShowInformation(string opearation, int element, bool result) {
            Console.WriteLine("Successful <" + opearation + " " + element + "> operation\nOperation result: " + result + '\n');
        }
    }
}
