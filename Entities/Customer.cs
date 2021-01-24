using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Abstract;
using GameDemo.KodlamaIO.HW.Concrete;

namespace GameDemo.KodlamaIO.HW.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityID { get; set; }
    }
}
