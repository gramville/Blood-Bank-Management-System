using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS
{
    class Blood
    {
        public string quantity_of_blood_types()
        {
            BloodDbLayer b = new BloodDbLayer();
            string quantity = b.quantity_of_blood();
            return quantity;
        }
    }
}