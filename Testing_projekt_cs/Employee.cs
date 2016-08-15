using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_projekt_cs
{
    class Employee
    {

        private int position_1 = 0;
        private int position_2 = 0;
        private int working_hours = 0;
        private int working_hours_2 = 0;
        private bool busy = false;
        private int work = 0;

        Random rnd = new Random();

        public int checkPosition_1()
        {
            int rez = position_1;
            return rez;
        }

        public int checkPosition_2()
        {
            int rez = position_2;
            return rez;
        }

        public void setPosition_1(int a)
        {
            position_1 = a;

        }

        public void setPosition_2(int a)
        {
            position_2 = a;

        }

        public bool checkBusy()
        {
            bool rez = busy;
            return rez;
        }

        public void setBusy(bool a)
        {
            busy = a;
        }

        public void setWorkingHours_2(int a)
        {
            working_hours_2 = a;
        }

        public void setWorkingHours(int a)
        {
            working_hours = a;
        }

        public int checkWorkingHours()
        {
            int rez;
            rez = working_hours;
            return rez;
        }

        public int checkWorkingHours_2()
        {
            int rez;
            rez = working_hours_2;
            return rez;
        }

        public int checkWork()
        {
            int rez = work;
            return rez;
        }

        public void setWork(int a)
        {
            work = a;
        }
        
        public int randomPosition_2 (int first  )
        {
            int a = 0;
            int index = 0;

            do
            {
               index = rnd.Next() % 10;
            } while (index > 2 || index < 1);

            if (index == 2) 
                return 0;
            else if (index == 1)
            {
                if (first == 1)
                {
                    return 5;
                }

                if (first == 2)
                {

                    do
                    {
                        a = rnd.Next(1,8);
                    } while (a == 1 || a == 2 || a == 6 || a == 7);
                    return a;
                }

                if (first == 3)
                {

                    do
                    {
                        a = rnd.Next(1, 8);
                    } while (a == 1 || a == 3 || a == 6 || a == 7);
                    return a;
                }

                if (first == 4)
                {

                    do
                    {
                        a = rnd.Next(1, 8);
                    } while (a == 1 || a == 4 || a == 6 || a == 7);
                    return a;
                }

                if (first == 5)
                {

                    do
                    {
                        a = rnd.Next(1, 8);
                    } while (a == 5 || a == 7);
                    return a;
                }

                if (first == 6)
                {
                    return 5;
                }

                if (first == 7)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
