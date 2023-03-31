using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using библиотека14pr;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace pr14_form
{
    public partial class Form1 : Form
    {
        List<PersonalContacts> listcontactpersonal = new List<PersonalContacts>();
        List<Business> listcontactbus = new List<Business>();
        contact a1;
        string name;
        string telephone;
        string address;
        string type;
        string congratulation;
        string relation;
        string organization;
        string post;
        string userdate; 
        DateTime date1;
        DateTime date;
        StreamWriter fileper = File.CreateText("Личные контакты.txt");
        StreamWriter filebus = File.CreateText("Деловые контакты.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") MessageBox.Show("Заполните все поля", "");
            else
            {
                name = this.textBox1.Text;
                telephone = this.textBox2.Text;
                address = this.textBox3.Text;
                type = this.textBox4.Text;

                if (radioButton1.Checked)
                {

                    PersonalContacts contacts1 = new PersonalContacts(name, telephone, address, type, date1, congratulation, relation);
                    listcontactpersonal.Add(contacts1);

                }
                if (radioButton2.Checked)
                {
                    Business contacts = new Business(name, telephone, address, type, organization, post, date);
                    listcontactbus.Add(contacts);
                }
                for (int i = 0; i < listcontactpersonal.Count; i++)
                {
                    listBox1.Items.Add(listcontactpersonal[i].Name);
                    fileper.WriteLine(listcontactpersonal[i].Info());
                }
                for (int i = 0; i < listcontactbus.Count; i++)
                {
                    listBox1.Items.Add(listcontactbus[i].Name);
                    filebus.WriteLine(listcontactbus[i].Info());
                }
                fileper.Close();
                filebus.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            if (groupBox1.Visible == true)
            {
               
                    date1 = DateTime.Parse(this.dateTimePicker1.Text);
                    congratulation = this.textBox6.Text;
                    relation = this.textBox5.Text;
            }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            if (groupBox2.Visible == true)
            {
                organization = this.textBox10.Text;
                post = this.textBox9.Text;
                date = DateTime.Parse(this.dateTimePicker2.Text);


            }
        }
    }
}
