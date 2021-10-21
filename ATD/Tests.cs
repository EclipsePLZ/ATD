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

            //start Remove elements
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

        public void TestPresentation(int size) {
            MyQueue<int> queue = new MyQueue<int>(size);
            for (int i = 1; i <= size; i++) {
                queue.Add(i);
                ShowInformation("Add", queue, i);
            }
            queue.Remove();
            ShowInformation("Remove", queue);
            for (int i=1; i <= 2; i++) {
                queue.Add(size + i);
                ShowInformation("Add", queue, size + i);
            }
            queue.Remove();
            ShowInformation("Remove", queue);
            queue.Remove();
            ShowInformation("Remove", queue);
            queue.Add(8);
            ShowInformation("Add", queue, 8);
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
