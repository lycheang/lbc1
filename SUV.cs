using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_hw4
{
    public class SUV : Vehicle
    {
        //attribute
        int nodoor;
        float gas;
        public int door
        {
            get { return nodoor; }
            set { nodoor = value; }
        }
        public float Gas
        {
            get { return gas; }
            set { gas = value; }
        }
        //method
        public bool hasCamera(bool hasCamera)
        {
            if (hasCamera == true)
            {
                Console.WriteLine("This Model has Camera");
                return true;
            }
            else
            {
                Console.WriteLine("This model has not Camera");
                
            }
            return false;
        }
        public bool addDoor(bool addDoor)
        {
            if (addDoor == true)
            {
                Console.WriteLine("This model can  add more Seat");
                return true;
            }
            else
            {
                Console.WriteLine("This mode can not add more Seat");
            }
            return false;
        }
        internal class sUV
        {
        }
    }
}
