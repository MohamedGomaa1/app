using System;
using System.Windows.Forms;

namespace Qr_genrator
{
    public partial class Qr : Form
    {
        public Qr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home form04 = new Home();
            form04.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void START_Click(object sender, EventArgs e)
        {
            var g = Guid.NewGuid();
            label4.Text = Convert.ToString(g) ;

            
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox7.Image = qrcode.Draw(label4.Text, 50);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var g = Guid.NewGuid();
            label4.Text = Convert.ToString(g);


            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox7.Image = qrcode.Draw(label4.Text, 50);
        
                }
    }
}
