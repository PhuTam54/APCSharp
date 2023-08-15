using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment1
{
    internal class VietNamCustomer
    {
        public int customerID;
        public string customerName;
        public DateOnly exportDate;
        public string customerType;
        public double powerConsumption;
        public double powerPrice;

        public VietNamCustomer() 
        {
            this.Total();
        }

        // Property
        public int CustomerID
        { get { return customerID; } set {  customerID = value; } }

        public string CustomerName
        { get { return customerName; } set { customerName = value; } }

        public DateOnly ExportDate
        { get { return exportDate; } set {  exportDate = value; } }

        public string CustomerType
        { get { return customerType; } set { customerType = value; } }

        public double PowerConsumption
        { get { return powerConsumption; } set { powerConsumption = value > 0 ? value : 0; } }

        public double PowerPrice
        { get { return powerPrice; } set { powerPrice = value; } }

        public double Total()
        {
            double total, newPowerPrice;
            int norm;

            if (powerConsumption == 0)
            {
                total = 0;
            }
            else if (powerConsumption <= 50)
            {
                powerPrice = 1000;
                total = (powerPrice * powerConsumption);
            }
            else
            {
                if (powerConsumption <= 100)
                {
                    powerPrice = 1000;
                    newPowerPrice = 1200;
                    norm = 50;
                }
                else if (powerConsumption <= 200)
                {
                    powerPrice = 1200;
                    newPowerPrice = 1500;
                    norm = 100;
                }
                else
                {
                    powerPrice = 1500;
                    newPowerPrice = 2000;
                    norm = 200;
                }
                total = (powerPrice * norm + (powerConsumption - norm) * newPowerPrice);
            }

            return total;
        }
    }
}
