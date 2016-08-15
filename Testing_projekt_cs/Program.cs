using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Testing_projekt_cs
{
    class Program
    {
       
        
        static void Main(string[] args)
        {

 
            Random rnd = new Random(); // обьект для рандомных чисел
            Employee []employee = new Employee [101]; //масив для хранения обьектов
            int numberOfEmpl = rnd.Next(10, 101);// количество работников
            for (int i = 0; i < numberOfEmpl; i++)
            {
                employee[i] = new Employee();
            }
            employee[100] = new Employee();
            Task doing = new Task();
            Money salary = new Money();
            doing.setValueWorkers(numberOfEmpl);
            salary.size = numberOfEmpl;
            ////////////////////////////////////Раздаем должности///////////////////////////////////////////////////////
                                                   
            employee[0].setBusy(false);//Директор
            employee[0].setWorkingHours(0);
            employee[0].setPosition_1(1);
            employee[0].setPosition_2(0);

            employee[1].setBusy(false);//Менеджер
            employee[1].setWorkingHours(0);
            employee[1].setPosition_1(5);
            employee[1].setPosition_2(0);

            employee[2].setBusy(false);//Бухгалтер
            employee[2].setWorkingHours(0);
            employee[2].setPosition_1(6);
            employee[2].setPosition_2(0);

            for (int i = 3; i < numberOfEmpl; i++)// Остальные
            {

                employee[i].setBusy(false);
                employee[i].setWorkingHours(0);
                employee[i].setPosition_1(rnd.Next(1, 8));
                employee[i].setPosition_2(employee[i].randomPosition_2(employee[i].checkPosition_1()));
            }



////////////////////////////////////////////Раздаем задания////////////////////////////////////////////////////////////

            for (int i = 1; i <= 240; i++)
            {
                doing.job(employee, 100);
            }

////////////////////////////////////////////Щитаем зарплату//////////////////////////////////////////////////////////////

            salary.salary_month(employee);
            salary.salary_arr[100] = doing.checkFreelansers() * salary.salary_freelansers;

////////////////////////////////////////////Пишем на консоль////////////////////////////////////////////////////////////	

            string [] position = new string [7] { "Директор", "Программист", "Дизайнер", "Тестировщик", "Менеджер", "Бухгалтер", "Уборщик" };
            string [] position_2 = new string [7] { "совм.Директор", "совм.Программист", "совм.Дизайнер", "совм.Тестировщик", "совм.Менеджер", "совм.Бухгалтер", "совм.Уборщик" };
            
          


                for (int i = 0; i < numberOfEmpl; i++)
            {
                for (int a = 0; a < 7; a++)
                {
                    if (employee[i].checkPosition_1() == a + 1)
                    {
                        if (employee[i].checkPosition_2() == 0)
                        {
                            int t = i + 1;
                            Console.WriteLine ( t + ") " + position[a] + "  -  " + salary.salary_arr[i] );
                        }
                        else {
                            for (int j = 0; j < 7; j++)
                            {
                                if (employee[i].checkPosition_2() == j + 1)
                                {
                                    int t = i + 1;
                                    Console.WriteLine ( t + ") " + position[a] + "-" + position_2[j] + "  -  " + salary.salary_arr[i] );
                                }
                            }
                        }
                    }
                }
            }
            int totalSum = 0;
            for (int i = 0; i < numberOfEmpl; i++)
            {
                totalSum = totalSum + salary.salary_arr[i];
            }
            totalSum = totalSum + salary.salary_arr[100];
            Console.WriteLine ( "    Фрилансеры - " + salary.salary_arr[100]);
            Console.WriteLine ( "    Итого  -  " + totalSum );
            Console.WriteLine ( "    Текстовая версия находится в файле - Salary_Month.txt" );


////////////////////////////////////////////////////////Пишем в файл////////////////////////////////////////////////////////////	

            StreamWriter sw = new StreamWriter("Salary_Month.txt");

            for (int i = 0; i < numberOfEmpl; i++)
            {
                for (int a = 0; a < 7; a++)
                {
                    if (employee[i].checkPosition_1() == a + 1)
                    {
                        if (employee[i].checkPosition_2() == 0)
                            sw.WriteLine((i + 1) + ") " + position[a] + "  -  " + salary.salary_arr[i]);
                        else {
                            for (int j = 0; j < 7; j++)
                            {
                                if (employee[i].checkPosition_2() == j + 1)
                                {
                                    sw.WriteLine((i + 1) + ") " + position[a] + "-" + position_2[j] + "  -  " + salary.salary_arr[i] );
                                }
                            }
                        }
                    }
                }
            }

            sw.WriteLine("    Фрилансеры  -  " + salary.salary_arr[100]);
            sw.WriteLine("    Итого  -  " + totalSum );

            sw.Close();


            Console.ReadKey();
        }
     
        



    }
}
