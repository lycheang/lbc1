using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DS_hw4
{
    public class Vehicle
    {
        String bra;
        String mod;
        int NofSe;
        float hp;
        public string brand
        {
            get { return bra; }
            set { bra = value; }
        }
        public string model
        {
            get { return mod; }
            set { mod = value; }
        }
        public int Seat
        {
            get { return NofSe; }
            set { NofSe = value; }
        }
        public float Horsepower
        {
            get { return hp; }
            set { hp = value; }
        }
        //method
        public bool WarrantyAdded()
        {
            // Logic to check if warranty is added (for simplicity, returning true here)
            Console.WriteLine("Warranty has been added.");
            return true;
        }
        public string PayBilling()
        {
            // Logic to generate billing (returning a simple message for illustration)
            return $"Billing for {brand} {model} has been paid.";
        }
        public void displayinfo()
        {
            Console.WriteLine("Vehicle Information");
            Console.WriteLine("Brand Vehicle: " + brand);
            Console.WriteLine("Model Vehicle: " + model);
            Console.WriteLine("Number of Seat: " + Seat);
            Console.WriteLine("Horsepower: " + Horsepower);
            Console.WriteLine(WarrantyAdded());
            Console.WriteLine(PayBilling());
        }
    }
    internal class Program
    {
        
            static void Main(string[] args)
            {
            Vehicle v = new Vehicle();
            v.brand = "Honda";
            v.model = "Civic";
            v.Seat = 4;
            v.Horsepower = 200;
            v.displayinfo();


            Cidan c = new Cidan();
            c.frameNo = "Yes";
            c.EngineType = "V6";


            //output
            Console.WriteLine("Cidan frame: " + c.frameNo);
            Console.WriteLine("EngineType: " + c.EngineType);
            c.IsInsured(true);
            c.roof(true);
            //SUV s = new SUV();
            ////process
            //s.door = 4;
            //s.Gas = 11;
            ////output
            //Console.WriteLine("This SUV have Door" + s.door);
            //Console.WriteLine("This SUV Gas/100km:" + s.Gas + "l");
            //s.hasCamera(true);
            //s.addDoor(true);
            Console.ReadKey();
           
            }
        
    }
}
