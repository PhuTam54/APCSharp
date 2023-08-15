using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment2
{
    internal class PhoneBook : Phone
    {
        private List<string> phoneList;

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneBook(string Name, string PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return "Name: " + Name + "   Phone: " + PhoneNumber;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            PhoneBook objAsPhoneBook = obj as PhoneBook;
            if (objAsPhoneBook == null) return false;
            else return Equals(objAsPhoneBook);
        }
        public override int GetHashCode()
        {
            return 1; ////////////////////////////////////
        }
        public bool Equals(PhoneBook other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
        // Should also override == and != operators.

        public PhoneBook()
        {
            phoneList = new List<string>();
        }

        public List<string> PhoneList
        {
            get => phoneList; 
            set => phoneList = value;
        }

        // indexer
        public string this[int index]
        {
            get => phoneList[index];
            set => phoneList[index] = value;
        }

        public override void InsertPhone(string name, string phone)
        {
            phoneList.Add(new PhoneBook() { Name = name, PhoneNumber = phone });
        }

        public override void RemovePhone(string Name)
        {
            phoneList.Remove(Name);
        }

        public override void UpdatePhone(string Name, string newPhone)
        {
            throw new NotImplementedException();
        }

        public override void SearchPhone(string Name)
        {
            throw new NotImplementedException();
        }

        public override void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
