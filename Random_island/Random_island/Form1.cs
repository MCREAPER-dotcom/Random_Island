using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_island
{

    public partial class Start_window : Form
    {
        int tipe, Formes;
        string name;
        Person p1;
        Random rand = new Random();
        enemy Enemy1;
        HIT Hit = new HIT();
        public Start_window()
        {
            InitializeComponent();
        }
        public void Raschet()
        {
            label10.Text = Convert.ToString(p1.r1.stamina);
            label11.Text = Convert.ToString(p1.r1.agility);
            label12.Text = Convert.ToString(p1.r1.intelegent);
            label13.Text = Convert.ToString(p1.r1.lucky);
            label14.Text = Convert.ToString(p1.r1.community);
            label15.Text = Convert.ToString(p1.H1.hp);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipe = 1;
            p1 = new Person(name, tipe, Formes);
            Raschet();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipe = 2;
            p1 = new Person(name, tipe, Formes);
            Raschet();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Formes = 1;
            p1 = new Person(name, tipe, Formes);
            Raschet();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Formes = 2;
            p1 = new Person(name, tipe, Formes);
            Raschet();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Formes = 3;
            p1 = new Person(name, tipe, Formes);
            Raschet();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            p1 = new Person(name, tipe, Formes);
            Raschet();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Formes == 0 || tipe == 0 || name == "") MessageBox.Show("Введи все параметры!");
            else
            {
                groupBox4.Visible = false;
                Enemy1 = new enemy();
                label27.Text = Convert.ToString(Enemy1.Name);
                label25.Text = Convert.ToString(Enemy1.r2.stamina);
                label26.Text = Convert.ToString(Enemy1.r2.agility);
                label24.Text = Convert.ToString(Enemy1.r2.intelegent);
                label22.Text = Convert.ToString(Enemy1.r2.lucky);
                label20.Text = Convert.ToString(Enemy1.r2.community);
                label18.Text = Convert.ToString(Enemy1.H1.hp);
                groupBox6.Visible = true;
            }
            this.Controls.Remove(groupBox4);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Enemy1 = new enemy();
            label27.Text = Convert.ToString(Enemy1.Name);
            label25.Text = Convert.ToString(Enemy1.r2.stamina);
            label26.Text = Convert.ToString(Enemy1.r2.agility);
            label24.Text = Convert.ToString(Enemy1.r2.intelegent);
            label22.Text = Convert.ToString(Enemy1.r2.lucky);
            label20.Text = Convert.ToString(Enemy1.r2.community);
            label18.Text = Convert.ToString(Enemy1.H1.hp);
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label42.Text = p1.name;
            label53.Text = Convert.ToString(p1.r1.stamina);
            label54.Text = Convert.ToString(p1.r1.agility);
            label52.Text = Convert.ToString(p1.r1.intelegent);
            label50.Text = Convert.ToString(p1.r1.lucky);
            label48.Text = Convert.ToString(p1.r1.community);
            label46.Text = Convert.ToString(p1.H1.hp);

            label29.Text = Convert.ToString(Enemy1.Name);
            label40.Text = Convert.ToString(Enemy1.r2.stamina);
            label41.Text = Convert.ToString(Enemy1.r2.agility);
            label39.Text = Convert.ToString(Enemy1.r2.intelegent);
            label37.Text = Convert.ToString(Enemy1.r2.lucky);
            label35.Text = Convert.ToString(Enemy1.r2.community);
            label33.Text = Convert.ToString(Enemy1.H1.hp);
            groupBox3.Visible = true;



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(groupBox1);
            groupBox4.Visible = true;
        }
    }
}
