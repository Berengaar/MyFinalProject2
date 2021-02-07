﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }      //veritabanında bu şekilde tutuluyor
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Shipcity { get; set; }
    }
}
