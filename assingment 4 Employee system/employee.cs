using System;
using System.Collections.Generic;
using System.Text;

namespace assingment_4_Employee_system
{
    class employee
    {
        private string name;
        private int age;
        private string job;
        private DateTime dateofbirth;
        private double salary;
        private int yearsuntilretirement;
        public static int employeecount;

        private static int retirementage = 65;

        public Employee(string name, DateTime dateofbirth, string job, double salary)
        {
            this.name = name;
            this.dateofbirth = dateofbirth;
            this.job = job;
            this.salary = salary;
            employeecount = employeecount + 1;
        }

        public bool Isbirthday()
        {
            int month = dateofbirth.Month;
            int day = dateofbirth.Day;


            if (month == DateTime.Now.Month && day == DateTime.Now.Day)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Setage()
        {
            age = DateTime.Now.Year - dateofbirth.Year;
        }

        public int Getyearsuntilretirement()
        {
            Setage();

            yearsuntilretirement = retirementage - age;
            return yearsuntilretirement;
        }

        public string Getinformation()
        {
            string information = "Name: " + name + "Age: " + age + "Job: " + job + "Salary " + salary;
            return information;
        }

        public void Setjob(string job)
        {
            this.job = job
        }

        public void Setsalary(double salary)
        {
            this.salary = salary;
        }






    }
}