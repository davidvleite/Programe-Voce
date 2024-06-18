﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Validations.Base
{
    public class Report
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public static Report Create(string message) => new Report(message);

        public Report()
        {
        }

        public Report( string message)
        {            
            Message = message;
        }
    }
}
