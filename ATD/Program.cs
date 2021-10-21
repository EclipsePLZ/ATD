using System;

namespace ATD {
    class Program {
        static void Main(string[] args) {
            Tests tests = new Tests();
            tests.StartRandomDataTesting(5);
            //tests.TestPresentation(5);
        }
    }
}
