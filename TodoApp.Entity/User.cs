﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }
    }
}
