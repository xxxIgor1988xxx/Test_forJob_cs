using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_projekt_cs
{
    class Money
    {
       public int [] salary_arr = new int [101];
       public int [] salary = new int [7] { 10, 9, 8, 7, 6, 5, 4 }; 

       public int salary_total = 0;
       public int salary_freelansers = 6;

       public int size = 0;




       public void salary_month(Employee [] employee)
        {
            for (int i = 0; i < size; i++)
            {
                for (int a = 1; a < 8; a++)
                {
                    if (employee[i].checkPosition_1() == a)
                    {
                        salary_arr[i] = employee[i].checkWorkingHours() * salary[a - 1];
                    }
                }
                for (int a = 1; a < 8; a++)
                {
                    if (employee[i].checkPosition_2() == a)
                    {
                        salary_arr[i] = salary_arr[i] + (employee[i].checkWorkingHours_2() * salary[a - 1]);
                    }
                }
            }

        }
    }
}
