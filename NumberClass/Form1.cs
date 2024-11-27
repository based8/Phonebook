using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberClass
{
    public partial class Form1 : Form
    {
        private List<client> register = new List<client>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string number = textBox3.Text;
            foreach (var client in register)
            {
                if (number == client.number)
                {
                    MessageBox.Show("Number already inside register\nnumber not added!");
                    return;
                }
            }

            client newclient = new client(fname, lname, number);
            register.Add(newclient);
            MessageBox.Show("Added to phonebook succsess");
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                radioButton1.Checked = true;
                radioButton1_CheckedChanged(this, EventArgs.Empty);
            }

        }
        public void UpdateRegister(string mode)
        {
            if (mode == "firstfirst")
            {
                foreach (var user in register)
                {
                    NumberList.Items.Add(user.fname + " - " + user.lname + " - " + user.number);
                }
            }
            if (mode == "firstlast")
            {
                foreach (var user in register)
                {
                    NumberList.Items.Add(user.lname + " - " + user.fname + " - " + user.number);
                }
            }

        }
        public class client
        {
            public string fname { get; set; }
            public string lname { get; set; }
            public string number { get; set; }

            public client(string firstname, string lastname, string phonenumber)
            {
                this.fname = firstname;
                this.lname = lastname;
                this.number = phonenumber;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                NumberList.Items.Clear();
                UpdateRegister("firstfirst");
                Console.WriteLine("button1");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                NumberList.Items.Clear();
                UpdateRegister("firstlast");
                Console.WriteLine("button1");
            }

        }
    }
}
