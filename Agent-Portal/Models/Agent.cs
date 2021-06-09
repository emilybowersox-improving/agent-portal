using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agent_Portal.Models
{
    public class Agent
    {
        //added Id for "primary key" 
        public int Id { get; set; }
        public string AgentCode { get; set; }
        public string AgentName { get; set; }
        public string WorkingArea { get; set; }
        public Decimal Commission { get; set; }
        public string PhoneNo { get; set; }
    }
}
