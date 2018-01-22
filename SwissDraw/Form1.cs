using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissDraw
{
    public partial class Form1 : Form
    {
        static private Dictionary<int, Person> persons = new Dictionary<int, Person>();

        internal static bool addPerson(Person p)
        {
            if(persons.ContainsKey(p.LotNumber) == false)
            {
                persons.Add(p.LotNumber, p);
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static Dictionary<int, Person> getPersons()
        {
            return persons;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            var apf = new AddPersonForm(this);
            apf.Visible = true;
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
