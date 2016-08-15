using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_projekt_cs
{
    class Task
    {
        private int valueWorkers = 0;
        private int task_1 = -1;
        private int task_2 = -1;
        private int task_3 = -1;
        private int freelansers = 0;



        Random rnd = new Random();

        public int randomFor1To2(Random rnd)
        {
            int rez;
            do
            {
                rez = rnd.Next( 1 , 4 );
            } while (rez > 3 || rez < 1);

            return rez;


        }

        public int taskForPosition(Random rnd)
        {
            int rez;
            do
            {
                rez = rnd.Next( 1 , 8 ) ;
            } while (rez == 1 || rez == 5 || rez == 6 || rez > 7 || rez < 1);
            return rez;
        }

        public int checkFreelansers()
        {
            int rez;
            rez = freelansers;
            return rez;
        }

        public void setFreelansers(int a)
        {
            freelansers = a;
        }

        public void setValueWorkers(int a)
        {
            valueWorkers = a;
        }


        public void job(Employee [] employee , int size)
        {
            
            int index = 0;
            int workHours = 0;
            index = rnd.Next(1,4);
            workHours = rnd.Next(1,4);


            if (index == 1)
            {
                task_1 = taskForPosition(rnd);
                task_2 = -1;
                task_3 = -1;
            }
            else if (index == 2)
            {
                task_1 = taskForPosition(rnd);
                task_2 = taskForPosition(rnd);
                task_3 = -1;

            }
            else if (index == 3)
            {
                task_1 = taskForPosition(rnd);
                task_2 = taskForPosition(rnd);
                task_3 = taskForPosition(rnd);

            }

            for (int i = 0; i < valueWorkers; i++)
            {
                if (employee[i].checkPosition_1() == 1 || employee[i].checkPosition_1() == 5 || employee[i].checkPosition_1() == 6)
                    employee[i].setWorkingHours(employee[i].checkWorkingHours() + 1);
                if (employee[i].checkPosition_2() == 1 || employee[i].checkPosition_2() == 5 || employee[i].checkPosition_2() == 6)
                    employee[i].setWorkingHours_2(employee[i].checkWorkingHours_2() + 1);
                if (employee[i].checkBusy() == true)
                {
                    employee[i].setWork(employee[i].checkWork() - 1);
                    if (employee[i].checkWork() == 0)
                        employee[i].setBusy(false);

                }


                else if (employee[i].checkPosition_1() == task_1 && employee[i].checkBusy() == false)
                {
                    employee[i].setBusy(true);
                    task_1 = -1;
                    employee[i].setWork(workHours);
                    employee[i].setWorkingHours(employee[i].checkWorkingHours() + workHours);
                }
                else if (employee[i].checkPosition_1() == task_2 && employee[i].checkBusy() == false)
                {
                    employee[i].setBusy(true);
                    task_2 = -1;
                    employee[i].setWork(workHours);
                    employee[i].setWorkingHours(employee[i].checkWorkingHours() + workHours);
                }
                else if (employee[i].checkPosition_1() == task_3 && employee[i].checkBusy() == false)
                {
                    employee[i].setBusy(true);
                    task_3 = -1;
                    employee[i].setWork(workHours);
                    employee[i].setWorkingHours(employee[i].checkWorkingHours() + workHours);
                }
                else if (employee[i].checkPosition_2() == task_2 && employee[i].checkBusy() == false)
                {
                    employee[i].setBusy(true);
                    task_2 = -1;
                    employee[i].setWork(workHours);
                    employee[i].setWorkingHours_2(employee[i].checkWorkingHours_2() + workHours);
                }
                else if (employee[i].checkPosition_2() == task_1 && employee[i].checkBusy() == false)
                {
                    employee[i].setBusy(true);
                    task_1 = -1;
                    employee[i].setWork(workHours);
                    employee[i].setWorkingHours_2(employee[i].checkWorkingHours_2() + workHours);
                }
                else if (employee[i].checkPosition_2() == task_3 && employee[i].checkBusy() == false)
                {
                    employee[i].setBusy(true);
                    task_3 = -1;
                    employee[i].setWork(workHours);
                    employee[i].setWorkingHours_2(employee[i].checkWorkingHours_2() + workHours);

                }
                if ((i == (valueWorkers - 1)) && (!(task_1 == 7)) && (!(task_2 == 7)))
                    freelansers = freelansers + workHours;

            }





        }
    }
}
