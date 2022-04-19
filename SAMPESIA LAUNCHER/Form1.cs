using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace SAMPESIA_LAUNCHER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(guna2TextBox1.Text))
            {
                MessageBox.Show("Kullanıcı Adı Girmelisin Dostum !");
            }
            else
            {
                guna2TextBox1.Visible = false;
                guna2Button1.Visible = false;
                label3.Text = guna2TextBox1.Text;
                label3.Visible = true;
                guna2Button2.Visible = true;
                guna2ComboBox1.Visible = true;
                guna2CirclePictureBox4.Visible = true;
                label9.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label10.Visible = true;
                guna2CirclePictureBox5.Visible = true;
                label7.Visible = true;
                guna2PictureBox8.Visible = false;
                guna2CirclePictureBox1.Visible = true;
                guna2CirclePictureBox2.Visible = true;
                guna2CirclePictureBox3.Visible = true;
                guna2PictureBox3.Visible = true;
                label2.Visible = true;
                guna2Button3.Visible = true;
            }
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            {
                if (String.IsNullOrEmpty(guna2ComboBox1.Text))
                {
                    MessageBox.Show("Sürüm Seçmelisin Adamım !");
                }
            }
            guna2Button2.Text = "Başlat";
            guna2Button2.Enabled = false;
            guna2Button3.Text = "Çıkış Yap";
            guna2Button3.Enabled = false;
            guna2ComboBox1.Enabled = false;

            Thread thread = new Thread(() => SampesiaNW())
            {
                IsBackground = false
            };
            thread.Start();
        }
        async private void SampesiaNW()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            var ayar = new MLaunchOption
            {
                MaximumRamMb = 2048,
                Session = MSession.GetOfflineSession(guna2TextBox1.Text),
            };
            var proceess = await launcher.CreateProcessAsync(guna2ComboBox1.Text,ayar);
            proceess.Start();
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            guna2CirclePictureBox1.Visible = false;
            guna2CirclePictureBox2.Visible = false;
            guna2CirclePictureBox5.Visible = false;
            guna2CirclePictureBox3.Visible = false;
            guna2PictureBox8.Visible = true;
            guna2CirclePictureBox4.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2Button1.Visible = true;
            guna2ComboBox1.Visible = false;

        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
