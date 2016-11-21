﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Employee
    {
        public string FistName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FistName + " " + LastName;
        }
    }


    /// <summary>
    /// Not thread safe Singleton
    /// </summary>
    public class EmployeeService
    {
        private List<Employee> _employees;
        private static EmployeeService _empService;

        private EmployeeService()
        {
            _employees = new List<Employee>();
        }

        public static EmployeeService EmployeeServiceInstance()
        {
            return _empService ?? (_empService = new EmployeeService());
        }


        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public List<Employee> GetEmployeeByLastName(string name)
        {
            return _employees.Where(e => e.LastName == name).ToList();
        }

    }

    public class EmployeeServiceThreadSafe : NavyEmployee, IEmployeeAddress
    {

       

        private List<Employee> _employees;
        private static EmployeeServiceThreadSafe _empService;

        private static readonly object SyncRoot = new object();

        private EmployeeServiceThreadSafe()
        {
           
            _employees = new List<Employee>();
        }

        /// <summary>
        /// ThreadSafe Singleton
        /// </summary>
        /// <returns></returns>
        public static EmployeeServiceThreadSafe EmployeeServiceInstance()
        {
            if (_empService == null) //First thread enter
            {
                lock (SyncRoot) // second thread see it is lock
                {
                    if (_empService == null) // second thread verify that instance created
                    {
                        _empService = new EmployeeServiceThreadSafe();
                    }
                }
            }

            return _empService;
        }


        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public List<Employee> GetEmployeeByLastName(string name)
        {
            return _employees.Where(e => e.LastName == name).ToList();
        }

        public string County { get; set; }
    }


    public class NavyEmployee : Employee
    {
        public string City { get; set; }
    }

    public interface IEmployeeAddress
    {
        string County { get; set; }
    }
}


