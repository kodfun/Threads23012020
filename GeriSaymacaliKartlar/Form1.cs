using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriSaymacaliKartlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KartlariOlustur();
        }

        private void KartlariOlustur()
        {
            for (int i = 0; i < 16; i++)
            {
                Button btn = new Button();
                btn.Click += Btn_Click;
                btn.Text = "100";
                btn.Size = new Size(100, 100);
                btn.Left = i % 4 * 120;
                btn.Top = i / 4 * 120;
                btn.BackColor = Color.Orange;
                pnlKartlar.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            new Thread(() =>
            {
                try
                {
                    while (btn.Text != "0")
                    {
                        int sayi = Convert.ToInt32(btn.Text);
                        btn.Invoke(new Action(delegate ()
                        {
                            btn.Text = (sayi - 1).ToString();
                            btn.Refresh();
                        }));
                        Thread.Sleep(10);

                    }
                    btn.Invoke(new Action(() =>
                    {
                        btn.Hide();
                    }));
                }
                catch (Exception)
                {
                    MessageBox.Show("ui thread i benim işim bitmeden ölmüş");
                }
                
            }).Start();

        }
    }
}
