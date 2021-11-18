using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATD {
    class Interface {
        public void StartInterface() {
            int size=0;
            MyQueue<int> queue;

            Console.WriteLine("Введите размер очереди:");
            try {
                size = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Не удалось создать очередь!");
                return;
            }

            queue = new MyQueue<int>(size);
            Console.WriteLine("Очередь создана\n");
            ShowHelpInformation();

            while (true) {
                Console.WriteLine("Введите номер операции:");
                string symb = Console.ReadLine();
                Console.WriteLine();

                switch (symb) {
                    case "1":
                        Console.WriteLine("Введите число:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        queue.Add(num);
                        ShowQueueInformation(queue);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "!help":
                        break;
                    default:
                        Console.WriteLine("Операции под таким номером не существует");
                        Console.WriteLine("Введите '!help' для подсказки\n");
                        break;
                }
            }
        }

        private void ShowHelpInformation() {
            Console.WriteLine("1 - Добавить элемент в очередь");
            Console.WriteLine("2 - Удалить элемент из очереди");
            Console.WriteLine("3 - Просмотреть первый элемент");
            Console.WriteLine("4 - Проверить наличие элемента в очереди\n");
        }

        private void ShowQueueInformation(MyQueue<int> queue) {
            Console.WriteLine("Текущий размер очереди: " + queue.GetSize() + "\n");
        }
    }
}
