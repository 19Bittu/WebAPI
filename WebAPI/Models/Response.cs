using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Response
    {
        public bool is_success { get; set; }
        public string user_id { get; set; }
            public string email { get; set; }
        public string roll_number { get; set; }
        public string[] numbers { get; set; }
        public string[] alphabets { get; set; }
            
    }
}