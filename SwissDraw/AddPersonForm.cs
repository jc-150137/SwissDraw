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
    public partial class AddPersonForm : Form
    {
        public AddPersonForm(Form1 f1)
        {
            InitializeComponent();
            parent = f1;
        }

        private Form1 parent;

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                PersonName = textBox1.Text,
                PersonGroup = textBox3.Text,
                LotNumber = int.Parse(textBox2.Text)
            };
            Form1.addPerson(p);
            newGridView();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.Show();
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {
            newGridView();

        }

        private void newGridView()
        {
            var persons = Form1.getPersons();
            dataGridView1.Rows.Clear();
            foreach (int k in persons.Keys)
            {
                Person p = persons[k];

                dataGridView1.Rows.Add(p.PersonName, p.PersonGroup);

            }
        }
    }
}
