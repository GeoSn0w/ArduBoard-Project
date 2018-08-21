using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduBoard_Plus
{
    public partial class Form1 : Form
    {
        string com_port = "COM20";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToShortTimeString();
            date.Text = DateTime.Now.ToShortDateString();
            arduino.Open();
            mechanism.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Should have removed this.
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            if (arduino.IsOpen)
            {
                int temperature = (int)(Math.Round(Convert.ToDecimal(
                                   arduino.ReadLine()), 0));
                temperature_indicator.Text = temperature.ToString() + "° C";  
            }
            
        }
        public void notificationtemperature(string str)
        {
            Font fontToUse = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush brushToUse = new SolidBrush(Color.White);
            Bitmap bitmapText = new Bitmap(16, 16);
            Graphics g = System.Drawing.Graphics.FromImage(bitmapText);

            IntPtr hIcon;

            g.Clear(Color.Transparent);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(str, fontToUse, brushToUse, -4, -2);
            hIcon = (bitmapText.GetHicon());
            notifyIcon1.Icon = System.Drawing.Icon.FromHandle(hIcon);
           
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer.Text = DateTime.Now.ToShortTimeString();
            date.Text = DateTime.Now.ToShortDateString();
            int temperature = (int)(Math.Round(Convert.ToDecimal(
                                   arduino.ReadLine()), 0));
            temperature_indicator.Text = temperature.ToString() + "° C";
            mechanism.RunWorkerAsync();
            notificationtemperature(temperature.ToString());
           
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void set_com_port_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Close();
                com_port = comport.Text;
                arduino.PortName = com_port;
                settings_panel.Visible = false;
                arduino.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            
            }

        }

        private void settings_Click(object sender, EventArgs e)
        {
            settings_panel.Visible = true;
        }

        private void comport_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
