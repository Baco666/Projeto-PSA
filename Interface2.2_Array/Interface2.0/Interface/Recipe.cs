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
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Interface
{
    public partial class Recipe : Form
    {
        Plc plc = null;
        public Recipe()
        {
            InitializeComponent();
        }
        public static class Globals
        {
            public static string path = "";
            public static string arrIn1 = "";
            public static string arrIn0 = "";
            public static string arrOut1 = "";
            public static string arrOut0 = "";
            public static string arrTest = "";
            public static string arrValues = "";
            public static string step = "Step1";
            public static int stepNumb = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int s = Globals.stepNumb;
            for (int j = s; j < s + 6; j++)
            {
                string str = File.ReadLines(Globals.path).Skip(j + 1).First();
                if (j == 0 + s)
                {
                    Globals.arrIn1 = str;
                }
                if (j == 1 + s)
                {
                    Globals.arrIn0 = str;
                }
                if (j == 2 + s)
                {
                    Globals.arrOut1 = str;
                }
                if (j == 3 + s)
                {
                    Globals.arrOut0 = str;
                }
                if (j == 4 + s)
                {
                    Globals.arrTest = str;
                }
                if (j == 5 + s)
                {
                    Globals.arrValues = str;
                }
               
                //PRINT
                label1.Text = Globals.arrIn1;
                label2.Text = Globals.arrIn0;
                label3.Text = Globals.arrOut1;
                label4.Text = Globals.arrOut0;
                label5.Text = Globals.arrTest;
                label6.Text = Globals.arrValues;


                //Send To PLC directly
                //string addIn1 = "DB1.DBD0";
                //object setIn1 = Globals.arrIn1; // Convert??
                //plc.Write(addIn1, setIn1);

                //string addIn0 = "DB1.DBD4";
                //object setIn0 = Globals.arrIn0;
                //plc.Write(addIn0, setIn0);

                //string addOut1 = "DB1.DBD8";
                //object setOut1 = Globals.arrOut1;
                //plc.Write(addOut1, setOut1);

                //string addOut0 = "DB1.DBD12";
                //object setOut0 = Globals.arrOut0;
                //plc.Write(addOut0, setOut0);

                //string addTest = "DB1.DBD16";
                //object setTest = Globals.arrTest;
                //plc.Write(addTest, setTest);


                string toSend = string.Join(",", Globals.arrIn1, Globals.arrIn0,Globals.arrOut1,Globals.arrOut0,Globals.arrTest,Globals.arrValues);

                //if
                //string addValues = "";
                //object setValues = Globals.arrValues;
                //plc.Write(addValues, setValues);


                //Send in Array
                
                try
                {
                    if (plc != null)
                    {
                        DataType dataType = DataType.DataBlock;
                        int DB = 1;
                        int startByte = 0;
                        //object setIn1 = Globals.arrIn1;
                        //byte[] value = Encoding.ASCII.GetBytes(Globals.arrIn1);
                        plc.Write(dataType, DB, startByte, toSend);
                    }
                }
                catch (Exception ex)
                {

                }
                ////Inputs a 0
                //try
                //{
                //    if (plc != null)
                //    {
                //        DataType dataType = DataType.DataBlock;
                //        int DB = 5;
                //        int startByte = 8;                        
                //        object setIn1 = Globals.arrIn1;
                //        byte[] value = Encoding.ASCII.GetBytes(Globals.arrIn1);
                //        plc.Write(dataType, DB, startByte, value);
                //    }
                //}
                //catch (Exception ex)
                //{

                //}
                ////Outputs a 1
                //try
                //{
                //    if (plc != null)
                //    {
                //        DataType dataType = DataType.DataBlock;
                //        int DB = 7;
                //        int startByte = 0;                        
                //        object setIn1 = Globals.arrIn1;
                //        byte[] value = Encoding.ASCII.GetBytes(Globals.arrIn1);
                //        plc.Write(dataType, DB, startByte, value);
                //    }
                //}
                //catch (Exception ex)
                //{

                //}
                ////Outputs a 0
                //try
                //{
                //    if (plc != null)
                //    {
                //        DataType dataType = DataType.DataBlock;
                //        int DB = 7;
                //        int startByte = 8;
                //        object setIn1 = Globals.arrIn1;
                //        byte[] value = Encoding.ASCII.GetBytes(Globals.arrIn1);
                //        plc.Write(dataType, DB, startByte, value);
                //    }
                //}
                //catch (Exception ex)
                //{

                //}
                ////Etapas
                //try
                //{
                //    if (plc != null)
                //    {
                //        DataType dataType = DataType.DataBlock;
                //        int DB = 1;
                //        int startByte = 0;                        
                //        object setIn1 = Globals.arrIn1;
                //        byte[] value = Encoding.ASCII.GetBytes(Globals.arrIn1);
                //        plc.Write(dataType, DB, startByte, value);
                //    }
                //}
                //catch (Exception ex)
                //{

                //}
                ////Values 
                //try
                //{
                //    if (plc != null)
                //    {
                //        DataType dataType = DataType.DataBlock;
                //        int DB = 5;
                //        int startByte = 0;                       
                //        object setValues = Globals.arrValues;                        
                //        plc.Write(dataType, DB, startByte,setValues);
                //    }
                //}
                //catch (Exception ex)
                //{

                //}


                //    if (testType1 = CurrentTest or testType2 = CurrentTest)
                //    {
                //        // Vmin
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);
                //        // Vmax
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);
                //        // Vreal
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);
                //        // currentTime
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);

                //    }
                //    else if (testType1 = ElectricTest or testType2 = ElectricTest)
                //    {
                //        // Vmin
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);
                //        // Vmax
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);
                //        // Vreal
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);
                //        // currentTime
                //        string address = "db adress";
                //        object setpoint = Convert.ToInt32();
                //        plc.Write(address, setpoint);

                //    }
            }
            //Increment Step Number
            s = s + 7;
            Globals.stepNumb = s;
        }

            private void btnSearchRecipe_Click(object sender, EventArgs e)
            {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //Open search folder to load file
                InitialDirectory = @"C:\",
                Title = "Browse File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Globals.path = filePath;
                tbSearchRecipe.Text = Path.GetFileName(filePath);  //Only shows the file name, not the whole path
                //tbReadFile.Text = File.ReadAllText(filePath);
            }       
        }

        private void btnConnectPLC_Click(object sender, EventArgs e)
        {
            Connect frm = new Connect();
            frm.Show();
            this.Hide();
        }

        private void btnAddRcp_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void tbRead_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
