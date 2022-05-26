using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shablon
{
    public partial class Кабинет : Form
    {
        public static Class1[] element1 = new Class1[3];
        public static Class2[] element2 = new Class2[3];
        
        public Кабинет()
        {
            InitializeComponent();

            element1[0] = new Class1();
            element1[0].set("1", "Физика");

            element1[1] = new Class1();
            element1[1].set("2", "Химия");


            element1[2] = new Class1();
            element1[2].set("3", "Информатика");




            element2[0] = new Class2();
            element2[0].set("LG", "Intel Core i7", "1998", "333");

            element2[1] = new Class2();
            element2[1].set("ASUS", "Intel Core i5", "2000", "321");

            element2[2] = new Class2();
            element2[2].set("Acer", "Intel Core i3", "2002", "304");



            label1.Text = element1[0].StringID;
            for (int i = 0; i < 3; i++)
                tabControl1.Controls["tabPage1"].Controls["label" + (1 + i)].Text = element1[i].StringID;

            lab1.Text = element1[0].String2;
            for (int i = 0; i < 3; i++)
                tabControl1.Controls["tabPage1"].Controls["lab" + (1 + i)].Text = element1[i].String2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Состав form1 = new Состав();
            form1.stringid = "LG";
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Состав form1 = new Состав();
            form1.stringid = "ASUS";
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Состав form1 = new Состав();
            form1.stringid = "Acer";
            form1.Show();
        }
    }
}
