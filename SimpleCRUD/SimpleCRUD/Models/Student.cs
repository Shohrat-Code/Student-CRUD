﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }
        public byte Age{ get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
