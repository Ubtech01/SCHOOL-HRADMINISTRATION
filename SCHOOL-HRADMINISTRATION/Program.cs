﻿using System.Linq;
using System.Collections.Generic;
using System;
using HR_ADMIN_API;

namespace SCHOOL_HRADMINISTRATION
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
        HeadMaster,
    }
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;

            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);

            Console.WriteLine($"Total Annual salaries of all the staff: {employees.Sum(e=>e.Salary)} ");
            Console.ReadKey();
        }
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Ubong",
                LastName = "Akpan",
                Salary = 30000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                Salary = 40000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Isaac",
                LastName = "Oguche",
                Salary = 60000
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Shalom",
                LastName = "Gar",
                Salary = 50000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "John",
                LastName = "Doe",
                Salary = 40000
            };
            employees.Add(headMaster);
        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }
    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }

    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
        {
            IEmployee employee = null!;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                case EmployeeType.DeputyHeadMaster:
                    employee = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                case EmployeeType.HeadMaster:
                    employee = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                default:
                    break;
            }
            return employee!;
        }
    }
}