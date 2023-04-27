using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SuportManager
{
    public class Employees
    {
        private string tabelNumber;
        private string lastName;
        private string firstName;
        private string patronymic;

        public string TabelNumber
        {
            get { return tabelNumber; }
            set { tabelNumber = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
    }

}

   
