using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marmota.Models;

namespace Marmota
{
    public partial class Form2 : Form
    {
        //List<Nome> nome;
        public int y;
        public int z;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //foreach(var p in nome)
            //{
            //    playerdisplay.Text = p.nome;
            //}
        }

        private void começar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Interval = 1000;
            y = 0;
            z = 30;
            mole1.Visible = false;
            mole1.Enabled = false;
            mole2.Visible = false;
            mole2.Enabled = false;
            mole3.Visible = false;
            mole3.Enabled = false;
            mole4.Visible = false;
            mole4.Enabled = false;
            mole5.Visible = false;
            mole5.Enabled = false;
            mole6.Visible = false;
            mole6.Enabled = false;
            mole7.Visible = false;
            mole7.Enabled = false;
            mole8.Visible = false;
            mole8.Enabled = false;
            mole9.Visible = false;
            mole9.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random m = new Random();
            switch(m.Next(0, 9))
            {
                case 1:
                    mole1.Visible = true;
                    mole1.Enabled = true;
                    break;
                case 2:
                    mole2.Visible = true;
                    mole2.Enabled = true;
                    break;
                case 3:
                    mole3.Visible = true;
                    mole3.Enabled = true;
                    break;
                case 4:
                    mole4.Visible = true;
                    mole4.Enabled = true;
                    break;
                case 5:
                    mole5.Visible = true;
                    mole5.Enabled = true;
                    break;
                case 6:
                    mole6.Visible = true;
                    mole6.Enabled = true;
                    break;
                case 7:
                    mole7.Visible = true;
                    mole7.Enabled = true;
                    break;
                case 8:
                    mole8.Visible = true;
                    mole8.Enabled = true;
                    break;
                case 9:
                    mole9.Visible = true;
                    mole9.Enabled = true;
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mole1_Click(object sender, EventArgs e)
        {
            y++;
            mole1.Visible = false;
            mole1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            z--;
            label2.Text = Convert.ToString(z);
            if (z == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            if(z > 10 && z < 21)
            {
                timer1.Interval = 500;
            }
            else if(z > 5 && z < 11)
            {
                timer1.Interval = 250;
            }
            else if(z > 0 && z < 6)
            {
                timer1.Interval = 125;
            }
        }

        private void mole2_Click(object sender, EventArgs e)
        {
            y++;
            mole2.Visible = false;
            mole2.Enabled = false;
        }

        private void mole3_Click(object sender, EventArgs e)
        {
            y++;
            mole3.Visible = false;
            mole3.Enabled = false;
        }

        private void mole4_Click(object sender, EventArgs e)
        {
            y++;
            mole4.Visible = false;
            mole4.Enabled = false;
        }

        private void mole5_Click(object sender, EventArgs e)
        {
            y++;
            mole5.Visible = false;
            mole5.Enabled = false;
        }

        private void mole6_Click(object sender, EventArgs e)
        {
            y++;
            mole6.Visible = false;
            mole6.Enabled = false;
        }

        private void mole7_Click(object sender, EventArgs e)
        {
            y++;
            mole7.Visible = false;
            mole7.Enabled = false;
        }

        private void mole8_Click(object sender, EventArgs e)
        {
            y++;
            mole8.Visible = false;
            mole8.Enabled = false;
        }

        private void mole9_Click(object sender, EventArgs e)
        {
            y++;
            mole9.Visible = false;
            mole9.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            point.Text = Convert.ToString(y);
        }
    }
}
