using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace conway
{
    class Program
    {
        static bool[,] cells;
        static int[,] adj;
        static int x = 35;
        static int y = 25;

        static void Main(string[] args)
        {
            cells = new bool[x,y];
            adj = new int[x,y];

            for(int i = 0; i < x-1; i++)
            {
                for (int j = 0; j < y - 1; j++)
                {
                    Debug.Write(Convert.ToString(i), Convert.ToString(j));
                    cells[i,j] = false;
                    adj[i, j] = 0;
                }
            }

            cells[10, 10] = true;
            cells[10, 11] = true;
            cells[10, 12] = true;
            //cells[10, 13] = true;
            cells[10, 14] = true;
            cells[10, 15] = true;

            output();
            Console.ReadLine();
            do
            {
                check_call();
                change();
                Console.Clear();
                output();
                Thread.Sleep(750);
            } while (true != false);

        }

        static void check_call()
        {
            tl_check();
            tr_check();
            bl_check();
            br_check();
            t_check();
            l_check();
            r_check();
            b_check();
            c_check();
        }
        static void tl_check()
        {
            int count = 0;

            if (cells[0, 1] == true)
            {
                count++;
            }
            if (cells[1, 0] == true)
            {
                count++;
            }
            if (cells[1, 1] == true)
            {
                count++;
            }

            adj[0, 0] = count;
        }
        static void tr_check()
        {
            int count = 0;

            if (cells[x - 2, 0] == true)
            {
                count++;
            }
            if (cells[x - 1, 1] == true)
            {
                count++;
            }
            if (cells[x - 2, 1] == true)
            {
                count++;
            }

            adj[x - 1, 0] = count;
        }
        static void bl_check()
        {
            int count = 0;

            if (cells[0, y - 2] == true)
            {
                count++;
            }
            if (cells[1, y - 1] == true)
            {
                count++;
            }
            if (cells[1, y - 2] == true)
            {
                count++;
            }

            adj[0, y - 1] = count;
        }
        static void br_check()
        {
            int count = 0;

            if (cells[x - 1, y - 2] == true)
            {
                count++;
            }
            if (cells[x - 2, y - 1] == true)
            {
                count++;
            }
            if (cells[x - 2, y - 2] == true)
            {
                count++;
            }

            adj[x - 1, y - 1] = count;
        }
        static void t_check()
        {
            for (int i = 1; i < x - 1; i++)
            {
                int count = 0;

                if (cells[i - 1, 0] == true)
                {
                    count++;
                }
                if (cells[i - 1, 1] == true)
                {
                    count++;
                }
                if (cells[i, 1] == true)
                {
                    count++;
                }
                if (cells[i + 1, 1] == true)
                {
                    count++;
                }
                if (cells[i + 1, 0] == true)
                {
                    count++;
                }
                adj[i, 0] = count;
            }
        }
        static void l_check()
        {
            for (int i = 1; i < y - 1; i++)
            {
                int count = 0;
                if (cells[0, i - 1] == true)
                {
                    count++;
                }
                if (cells[0, i + 1] == true)
                {
                    count++;
                }
                if (cells[1, i - 1] == true)
                {
                    count++;
                }
                if (cells[1, i] == true)
                {
                    count++;
                }
                if (cells[1, i + 1] == true)
                {
                    count++;
                }
                adj[0, i] = count;
            }
        }
        static void r_check()
        {
            for (int i = 1; i < y - 1; i++)
            {
                int count = 0;
                if (cells[x - 2, i - 1] == true)
                {
                    count++;
                }
                if (cells[x - 2, i] == true)
                {
                    count++;
                }
                Debug.WriteLine(Convert.ToString(i), " ", x);
                if (cells[x - 2, i + 1] == true)
                {
                    count++;
                }
                Debug.WriteLine(Convert.ToString(i), " ", x);
                if (cells[x - 1, i - 1] == true)//
                {
                    count++;
                }
                if (cells[x - 1, i + 1] == true)
                {
                    count++;
                }
                adj[x - 1, i] = count;
            }
        }
        static void b_check()
        {
            for (int i = 1; i < x - 1; i++)
            {
                int count = 0;
                if (cells[i - 1, y - 1] == true)
                {
                    count++;
                }
                if (cells[i + 1, y - 1] == true)
                {
                    count++;
                }
                if (cells[i - 1, y - 2] == true)
                {
                    count++;
                }
                if (cells[i, y - 2] == true)
                {
                    count++;
                }
                if (cells[i + 1, y - 2] == true)
                {
                    count++;
                }
                adj[i, y - 1] = count;
            }
        }
        static void c_check()
        {
            int count = 0;
            for (int i = 1; i < x - 1; i++)
            {
                for (int j = 1; j < y - 1; j++)
                {
                    count = 0;
                    if (cells[i - 1, j - 1] == true)
                    {
                        count++;
                    }
                    if (cells[i - 1, j] == true)
                    {
                        count++;
                    }
                    if (cells[i - 1, j + 1] == true)
                    {
                        count++;
                    }
                    if (cells[i, j - 1] == true)
                    {
                        count++;
                    }
                    if (cells[i, j + 1] == true)
                    {
                        count++;
                    }
                    if (cells[i + 1, j - 1] == true)
                    {
                        count++;
                    }
                    if (cells[i + 1, j] == true)
                    {
                        count++;
                    }
                    if (cells[i + 1, j + 1] == true)
                    {
                        count++;
                    }
                    adj[i, j] = count;
                }
            }
        }
        static void change()
        {
            for (int i = 0; i < x - 1; i++)
            {
                for (int j = 0; j < y - 1; j++)
                {
                    if (cells[i, j] == true)
                    {
                        if (adj[i, j] < 2 || adj[i, j] > 3)
                        {
                            cells[i, j] = false;
                        }
                    }
                    else
                    {
                        if (adj[i, j] == 3)
                        {
                            cells[i, j] = true;
                        }
                    }
                }
            }
        }
        static void output()
        {
            for (int i = 0; i < x - 1; i++)
            {
                for (int j = 0; j < y - 1; j++)
                {
                    if (cells[i, j] == true)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
