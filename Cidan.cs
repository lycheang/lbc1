using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using static DS_hw4.Program;

namespace DS_hw4
{

    public class Cidan:Vehicle
    {
        //attribute
        String frame;
        String entype;
        public String frameNo
        {
            get { return frame; }
            set
            {
                frame = value;
            }
        }
        public String EngineType
        {
            get { return entype; }
            set { entype = value; }
        }
        public bool IsInsured(bool isinsured)
        {
            if (isinsured== true)
            {
                Console.WriteLine("Cidan Isinsured");
                return true;
            }
            else {
                Console.WriteLine("Cidan is not Isinsured");
            }
            return false;
        }
        public bool roof(bool roofdoor)
        {
            if (roofdoor ==true)
            {
                Console.WriteLine("Cidan have roofdoor");
                
            }
            else {
                Console.WriteLine("Cidan have not roofdoor");
            }
            return false;
        }
    }
        internal class cidan
        {

        }
    
}

