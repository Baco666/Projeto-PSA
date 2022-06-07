using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace Interface
{
    public partial class Connect : Form
    {
        private Plc plc = null;
        public Connect()
        {
            InitializeComponent();
            cbCpuType_.DataSource = Enum.GetNames(typeof(CpuType));
        }            

        private void Connect_Load(object sender, EventArgs e)
        {
            
        }

        ////////      GO BACK BUTTON    /////////
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Recipe frm = new Recipe();
            frm.Show();
            this.Hide();
        }

        ////////      CONNECT BUTTON    /////////
        private void btnConnect_Click(object sender, EventArgs e)
        {          
            try
            {
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), cbCpuType_.SelectedValue.ToString());
                plc = new Plc(cpu, tbIPadd.Text, Convert.ToInt16(tbRack_.Text), Convert.ToInt16(tbSlot_.Text));
                plc.Open();
                if (plc.IsConnected)
                    {
                        lbStatus_.Text = "Connected";
                    }
            }
                        
            catch(Exception ex) 
            {
                // Error message
                MessageBox.Show(this,ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }            
        }
              

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            plc.Close();
            lbStatus_.Text = "Disconnected";
        }
    }
}
