using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class Student
    {
        [Display(Name = "ID")]
        public int Student_ID { get; set; }

        [Phone]
        [Display(Name="Name")]
        public string Student_Name { get; set; }

        [Display(Name = "Age")]
        public int Student_Age { get; set; }
    }
}