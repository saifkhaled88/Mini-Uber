using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber
{
     public class Ticket
    {

        int ticket_ID;
        string type;
        string problem_def;
        string status;
        string user_name;
        string driver_ssn;

        public int Ticket_ID { get => ticket_ID; set => ticket_ID = value; }
        public string Type { get => type; set => type = value; }
        public string Problem_def { get => problem_def; set => problem_def = value; }
        public string Status { get => status; set => status = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Driver_ssn { get => driver_ssn; set => driver_ssn = value; }
    }
}
