using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {

        bool IsConnected;
        PullSDK.DeviceManager Manager;
        public Form1()
        {
            InitializeComponent();
            IsConnected = false;
            panel1.Enabled = IsConnected;
            Manager = new PullSDK.DeviceManager();
            
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            string ip = tbIp.Text;

            if (IsConnected)
            {
                bConnect.Text = "Conectar";
                Manager.DisconnectTCP();
                IsConnected = false;
            }
            else
            {
                int ret = Manager.ConnectTCP(ip);
                if (ret == 1)
                {
                    bConnect.Text = "Desconectar";
                    IsConnected = true;
                } 
                else
                {
                    MessageBox.Show("No es posible conectar, error: " + ret);
                }
            }

            panel1.Enabled = IsConnected;

        }

        private void bEnable_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                string code = tbCode.Text;
                string cardNumber = tbCardNumber.Text;

                int ret = Manager.EnableEmploye(code, cardNumber);
                if (ret != 1)
                {
                    MessageBox.Show("Error: " + ret);
                }
                else
                {
                    MessageBox.Show("Enviado!");
                    tbCode.Text = "";
                    tbCardNumber.Text = "";
                }
            }
        }

        private void bDisable_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                string code = tbCode2.Text;

                int ret = Manager.DisableEmploye(code);
                if (ret != 0)
                {
                    MessageBox.Show("Error: " + ret);
                }
                else
                {
                    MessageBox.Show("Eliminado!");
                    tbCode2.Text = "";
                }
            }
        }

        private void bCount_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {

                int ret = Manager.CountEmployes();
                if (ret >= 0)
                {
                    MessageBox.Show("Employes: " + ret);
                }
                else
                {
                    MessageBox.Show("Error: " + ret);
                }
            }
        }
    }
}
