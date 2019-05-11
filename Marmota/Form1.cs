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
    public partial class Form1 : Form
    {
        List<Nome> name;
        public int x = 0;
        public string nom;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            name = new List<Nome>();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(caixaNome.Text == "asdasdadsad")
            {
                MessageBox.Show("Coloque um nome");
            }
            else
            {
                nom = caixaNome.Text;
                var p = new Nome
                {
                    nome = caixaNome.Text,
                    ponto = 0
                };
                name.Add(p);
                Form2 f = new Form2();
                f.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            string message = "Deseja sair?";
            string caption = "Sair";
            if(MessageBox.Show(message, caption, MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //name = name.OrderByDescending(ponto => ponto).ToList();
            //foreach(var p in name)
            //{

            //}
        }
    }
}
