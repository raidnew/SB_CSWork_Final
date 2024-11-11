using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Interfaces;

namespace AuthClasses.Models
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }
        public int status { get; set; }
    }
}
