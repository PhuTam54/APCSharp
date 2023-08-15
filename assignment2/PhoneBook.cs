using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment2
{
    internal class PhoneBook : Phone
    {
        List<string> PhoneList = new List<string>();

        public override void InsertPhone(string name, string phone)
        {
            bool flag = false;
            for (int i = 0; i < PhoneList.Count; i += 2)
            {
                if (PhoneList[i] == name)
                {
                    PhoneList[i + 1] = phone;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                PhoneList.Add(name);
                PhoneList.Add(phone);
            }
        }

        public override void RemovePhone(string name)
        {
            for (int i = 0; i < PhoneList.Count; i += 2)
            {
                if (PhoneList[i] == name)
                {
                    PhoneList.RemoveAt(i);
                    PhoneList.RemoveAt(i);
                    i -= 2;
                }
            }
        }

        public override void UpdatePhone(string name, string newphone)
        {
            for (int i = 0; i < PhoneList.Count; i += 2)
            {
                if (PhoneList[i] == name)
                {
                    PhoneList[i + 1] = newphone;
                }
            }
        }

        public override void SearchPhone(string name)
        {
            bool flag = false;
            for (int i = 0; i < PhoneList.Count; i += 2)
            {
                if (PhoneList[i] == name)
                {
                    Console.WriteLine($"{name}: {PhoneList[i + 1]}");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"There is no phone number found for {name}");
            }
        }

        public override void Sort()
        {
            for (int i = 0; i < PhoneList.Count - 2; i += 2)
            {
                for (int j = i + 2; j < PhoneList.Count; j += 2)
                {
                    if (string.Compare(PhoneList[i], PhoneList[j]) > 0)
                    {
                        string tempName = PhoneList[i];
                        string tempPhone = PhoneList[i + 1];
                        PhoneList[i] = PhoneList[j];
                        PhoneList[i + 1] = PhoneList[j + 1];
                        PhoneList[j] = tempName;
                        PhoneList[j + 1] = tempPhone;
                    }
                }
            }
        }
    }
}
        
