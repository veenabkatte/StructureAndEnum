using System;
using System.Collections.Generic;
using System.Text;

namespace StructureAndEnum
{
    class Employee
    {
        public int EmpCode { get; set; }

        public string EmpName { get; set; }

        public Gender EmpGender { get; set; }

        public string GetEmp(int empCode, string empName, Gender empGender)
        {
            this.EmpCode = empCode;
            this.EmpName = empName;
            this.EmpGender = empGender;
            return $"Code={this.EmpCode}\nName={this.EmpName}\nGender={this.EmpGender}";
        }
    }
}
