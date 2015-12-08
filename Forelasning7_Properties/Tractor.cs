using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Tractor
    {
        int wheels;     //backing-field
        int steeringAngle;  //backing-field

        public int Wheels   //Property - stor bokstav (även UML)!
        {
            get
            {
                return wheels;
            }
            set
            {
                if (value > 3 && value <= 20)
                    wheels = value;         //vi sätter vad vårt backing-field ska vara                         ('wheels'). INTE propertyn ('Wheel)!
                else 
                throw new Exception("Fel värde satt, måste vara 3-20"); 
            }
        }

        public int SteeringAngle //Property - stor bokstav (även UML)!
        {
            get
            {
                return steeringAngle;
            }
            set
            {
                steeringAngle = value % 360;
            }
        }   

        public Tractor()    //Constructor. Alltid public! inget returvärde                      (void). Har exakt samma namn som klassen!
        {
            Wheels = 4;
            SteeringAngle = 880;
        }
        public Tractor(int wheels) //Överlagrad constructor
        {
            Wheels = wheels;    
            SteeringAngle = 0;
        }
        public Tractor (int wheels, int steeringAngle) //Överlagrad constructor
        {
            Wheels = wheels;    //'wheels'- detta är INTE vårt backing-                          field! med den har samma namn. 
            SteeringAngle = steeringAngle;  //'steeringAngle' -detta är INTE                                     vårt backing-field! med den har                                   samma namn. 
        }
        public override string ToString()
        {
            return $"Wheels: {Wheels}, steering angle: {SteeringAngle}";    
        }
        
    }
}
