using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamenni_adventura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inGame1.Hide();
            ovladani1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inGame1.Show();
            inGame1.Enabled = true;
            button2.Show();
            inGame1.BringToFront();
            button2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(inGame1.Enabled)     //vypnutí hry
            {
                inGame1.Hide();
                button2.Hide();
                inGame1.Enabled=false;
            }
            if(ovladani1.Enabled)   //vypnutí ovádání
            {
                ovladani1.Hide();
                button2.Hide();
                ovladani1.Enabled=false;
            }
        }
        public static bool doprava, doleva, dolu, nahoru,attack;

        private void button3_Click(object sender, EventArgs e)
        {
            ovladani1.Show();
            ovladani1.Enabled = true;
            button2.Show();
            ovladani1.BringToFront();
            button2.BringToFront();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) doprava = false;
            if (e.KeyCode == Keys.A) doleva = false;
            if (e.KeyCode == Keys.W) nahoru = false;
            if (e.KeyCode == Keys.S) dolu = false;
            if (e.KeyCode == Keys.E) attack = false;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) doprava = true;
            if (e.KeyCode==Keys.A) doleva = true;
            if (e.KeyCode==Keys.W) nahoru = true;
            if (e.KeyCode==Keys.S) dolu = true;
            if(e.KeyCode==Keys.E) attack= true;
            
        }
    }
}
