﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength =5, ErrorMessage ="{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display (Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat (DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDay { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Base Sallary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Range(1000.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double BaseSallary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDay, double baseSallary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDay = birthDay;
            BaseSallary = baseSallary;
            Department = department;
        }

        public void Add_Sales (SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void Remove_Sales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotlaSales (DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}