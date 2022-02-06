using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data5CapstoneEmployee.Models
{
    public class EmployeeModels
    {
        [Key]
        public int EmployeeNumber { get; set; }       
        public Department Department { get; set; }
        public Education Education { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int JobLevel { get; set; }
        public JobRole JobRole { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int NumCompaniesWorked { get; set; }
        public int PerformanceRating { get; set; }
        public int TrainingTimeLastYear { get; set; }
        public int YearsAtCompany { get; set; }
        public int YearsInCurrentRole { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int YearsWithCurr4 { get; set; }
        public int JobSatisfaction { get; set; }
        public int EnvironmentSatisfaction { get; set; }
        public int WorkLifeBalance { get; set; }
        public int EmployeeCount { get; set; }

    }

    public enum MaritalStatus { Single = 1, Married = 2, Divorced = 2 };
    public enum JobRole { Healthcare_Representative = 1, Laboratory_Technician = 2, Research_Scientist = 3, Manager = 4, Manufacturing_Director = 5, Sales_Executive = 6, Sales_Representative = 7, Human_Resources = 8, Research_Director = 9 }
    public enum Gender { Male = 1, Female = 2, Other = 3 };
    public enum Education { HighSchool = 1, College = 2, Bachelors_Degree = 3, Masters_Degree = 4, };
    public enum Department { Research_And_Development = 1, Sales = 2, Human_Resources = 3 };
}