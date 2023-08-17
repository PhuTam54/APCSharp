using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.demo4
{
    public delegate void UpdateQtyHandler(int n);
    internal class Product
    {
        private int qty;

        public event UpdateQtyHandler QtyChanged;

        public Product() 
        {
            QtyChanged += NotifyChangedQty;
            QtyChanged += SendEmailToAdmin;
            QtyChanged += SendSMSToStoreManager;
        }

        public int Qty
        {
            get => this.qty;
            set => this.qty = value;
        }

        public void NotifyChangedQty(int n) 
        {
            Console.WriteLine("Qty of product was changed: ", n);
        }

        public void SendEmailToAdmin(int n)
        {
            // send Email
        }

        public void SendSMSToStoreManager(int n)
        {
            // send SMS
        }

        public void IncrementQty(int q)
        {
            if (qty > 0)
            {
                qty += q;
                QtyChanged(q);
            }
        }
    }
}
