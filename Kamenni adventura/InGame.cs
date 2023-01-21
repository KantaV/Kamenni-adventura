using Kamenni_adventura.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kamenni_adventura
{
    public partial class InGame : UserControl
    {
        public InGame()
        {
            InitializeComponent();
            pictureBoxPostava.BringToFront();
        }

        private int speed = 5,gravitace=4;
        private int predchozi=226;
        private bool povolSkok = true,koukaVlevo=true;

        Postava walter = new Postava(true);

        private async void timer1_Tick(object sender, EventArgs e)
        {
            int delay=0;
            if (predchozi != pictureBoxPostava.Top)
            {
                povolSkok = false;
            }
            else povolSkok = true;


            if (Form1.doleva && pictureBoxPostava.Left > 0)
            {
                koukaVlevo = true;
                pictureBoxPostava.Left -= speed;
            }
            if (Form1.doprava && pictureBoxPostava.Left < 833)
            {
                koukaVlevo = false;
                pictureBoxPostava.Left += speed;

            }
            if (Form1.nahoru && pictureBoxPostava.Top > 0 && povolSkok)
            {
                pictureBoxPostava.Top -= speed * 15;
            }
            if (Form1.dolu && pictureBoxPostava.Top < 229)
            {
                pictureBoxPostava.Top += speed;
            }
            if (Form1.attack)
            {
                delay = 100;
                SoundPlayer hankWalte=new SoundPlayer(Resources.Hank_rve);
                hankWalte.Play();

                if (pictureBoxPostava.Location.X >= pictureBoxEnemy.Location.X&&pictureBoxPostava.Location.X<=pictureBoxEnemy.Location.X+20)
                {
                    pictureBoxPostava.Image = Resources.hankAttack;
                    if (!koukaVlevo) pictureBoxPostava.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);              
                    SoundPlayer jaJsemTenKdoKlepe = new SoundPlayer(Resources.JaJsemTenKdoKlepe);
                    jaJsemTenKdoKlepe.Play();
                    pictureBoxEnemy.Image = Resources.WalterSmrtResized;
                    await Task.Delay(2500);
                    for (int i = 0; i < 5; i++)         //pocet bliknuti
                    {
                        await Task.Delay(100);
                        pictureBoxEnemy.Show();
                        await Task.Delay(100);
                        pictureBoxEnemy.Hide();
                    }
                }
            }

            if(koukaVlevo)
            {
                pictureBoxPostava.Image = Resources.hank2;
                if (delay > 0)
                {
                    pictureBoxPostava.Image = Resources.hankAttack;
                    --delay;
                }
            }
            else  //kouka vpravo
            {
                pictureBoxPostava.Image = Resources.hank2;
                pictureBoxPostava.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                if (delay > 0)
                {
                    pictureBoxPostava.Image = Resources.hankAttack;
                    pictureBoxPostava.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    --delay;
                }
            }


            predchozi = pictureBoxPostava.Top;
            if (pictureBoxPostava.Top < 229)
            {
                pictureBoxPostava.Top += gravitace;
            }
        }

    }
}
