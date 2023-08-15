using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment1
{
    internal class ForeignerCustomer
    {
        public int customerID;
        public string customerName;
        public DateOnly exportDate;
        public string customerCountry;
        public double powerConsumption;
        public double powerPrice;

        public ForeignerCustomer() 
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

        public string CustomerCountry
        { get { return customerCountry; } set { customerCountry = value; } }

        public double PowerConsumption
        { get { return powerConsumption; } set { powerConsumption = value > 0 ? value : 0; } }

        public double PowerPrice
        { get { return powerPrice; } set { powerPrice = value; } }

        public double Total()
        {
            double total, powerPrice;

            if (powerConsumption == 0)
            {
                total = 0;
            }
            else
            {
                powerPrice = 2000;
                total = (powerPrice * powerConsumption);
            }
            return total;
        }
    }
}
