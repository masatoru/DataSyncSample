using System;
using System.Collections.Generic;
using System.Text;

namespace DataSyncSample.Models
{
    public class User
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid(); //generates random id
    }
}
