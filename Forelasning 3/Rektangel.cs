using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_3
{
    class Rektangel
    {
        int width;
        int height;

        public void SetWidth(int width)
        {
            this.width = width;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetCircumference()
        {
            int circumferenceResult = 2 * width + 2 * height;
            return circumferenceResult;
        }
        public int GetArea()
        {
            int areaResult = width * height;
            return areaResult;
        }

        internal string PrintOut()
        {
            return $"Your circumference is: {this.GetCircumference()} and your area is {this.GetArea()}";
        }
    }
}
