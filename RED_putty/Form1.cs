using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace RED_putty
{
    public partial class Form1 : Form
    {

        public Process myprocess;
        public bool flag;
      
        public Form1()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            
            
            notifyIcon1.Visible = true;
           // notifyIcon1.Icon = System.Drawing.SystemIcons.Error;
        }

        
       

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            notifyIcon1.BalloonTipTitle = "RED Putty";
            notifyIcon1.BalloonTipText = "Network Status: ONLINE";
        
            
            notifyIcon1.ShowBalloonTip(2000);
           // this.ShowInTaskbar = true;
            //notifyIcon1.Visible = false;
        }
        
        public void putty_start(string id, string password)
        {
          
            string argumenty;
            

            if (File.Exists(Application.StartupPath + @"\putty.exe"))
            {
                ProcessStartInfo pinfo = new ProcessStartInfo(@"putty.exe");
                pinfo.WindowStyle = ProcessWindowStyle.Minimized;

               
                argumenty = id + "@stud.uni.torun.pl@router.akademiki.uni.torun.pl -pw " + password;
                pinfo.Arguments = argumenty;
                myprocess = Process.Start(pinfo);
                //myprocess.BeginOutputReadLine();
               //StreamReader sr = myprocess.StandardOutput;
                  
            }
            
            else
            {
                MessageBox.Show("Missing putty.exe", "AHTUNG!", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
            }
        }
        
        IPStatus ping_call(string adress)
        {
            
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            int timeout = 200;

            Ping sendPing = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            PingReply reply = sendPing.Send(adress, timeout, buffer, options);
            label1.Text = "Ping: "+reply.RoundtripTime.ToString()+"ms";
            return reply.Status;

        }
        
        private void Connect_Click(object sender, EventArgs e)
        {

            if (idbox.TextLength == 0 || passbox.TextLength == 0)
            {
                MessageBox.Show("Missing ID or Password","AHTUNG!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            else
            {
                Connect.Enabled = false;
                disconnect.Enabled = true;
                putty_start(idbox.Text, passbox.Text);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {       
                myprocess.CloseMainWindow();
                myprocess.Close();
                
            }
            catch 
            {
                statusStrip1.Text = "No process to close."; //bez sensu, FLAGA!
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
                                                                //158.75.88.5 nie moze byc obiektem testowym bo odpowiada nawet bez autoryzacji
            if(ping_call("212.191.227.88")==IPStatus.Success)   //powinno byc asynchronicznie ale niby dziala
            {
                statusStrip1.ForeColor = System.Drawing.Color.Green;
                toolStripStatusLabel1.Text = "Network Status: ONLINE";
            }
            else 
            {
                statusStrip1.ForeColor = System.Drawing.Color.Red;
                toolStripStatusLabel1.Text = "Network Status: OFFLINE";
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                myprocess.CloseMainWindow();    //samo close() pewno wystraczy, zamiast try powinna byc flaga z informacja czy proces putty.exe dziala
                myprocess.Close();              //w trybie hidden myprocess.closemainwindow() nie zadziala bo wymaga interakcji
                disconnect.Enabled = false;
                Connect.Enabled=true;
            }
            catch
            {
                MessageBox.Show("No connection do disconnect :D");

            }
        }

        public byte[] RSA_coder(string password)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            

            byte[] dataToEncrypt = ByteConverter.GetBytes(password);
            byte[] encryptedData;
            byte[] decryptedData;


           // encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false); //dupa


            return null;// encryptedData;
        }

       
        
    }
}
