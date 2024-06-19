using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1ntp
{

    internal class çikolataStack
    {


        private Stack<int> stack = new Stack<int>();
        private int toplamSatılan = 0;

        public void işlem(int N, int[] C)
        {
            for (int i = 0; i < N; i++)
            {
                if (C[i] == 0)
                {
                    if (stack.Count > 0)
                    {
                        toplamSatılan += stack.Pop();
                    }
                }
                else
                {
                    stack.Push(C[i]);
                }
            }
        }

        public int GetTS()
        {
            return toplamSatılan;
        }

        static void Main(string[] args)
        {
            int N = 5;
            int[] C = { 3, 0, 2, 1, 4 };

            çikolataStack çikolata = new çikolataStack();
            çikolata.işlem(N, C);

            Console.WriteLine("Toplam satılan çikolata sayısı: " + çikolata.GetTS());
            Console.ReadKey();
        }
    }
}

