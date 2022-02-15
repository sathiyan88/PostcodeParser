using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PostCode_Parser
{
    public class PostcodeBO
    {
        public string outwardCode { get; set; }
        public string outwardNumber { get; set; }
        public string outwardLetter { get; set; }
        public string inwardCode { get; set; }
        public string postCode { get; set; }
    }
}