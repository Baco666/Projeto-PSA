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

namespace Interface
{
    public partial class Form1 : Form
    {
        private Plc plc = null;
        public Form1()
        {
            InitializeComponent();                  
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string address = tbAddress.Text;
            object result = plc.Read(address);
            tbCurrentValue.Text = string.Format("{0}", result.ToString());
        }


        //// Write /////
        private void btnWrite_Click(object sender, EventArgs e)
        {
            string address = tbAddress.Text;
            object setpoint = Convert.ToInt32(tbSetpoint.Text);
            plc.Write(address, setpoint);
        }


        //      INPUTS
        private void btnI00_Click(object sender, EventArgs e)
        {
           
        }

        private void btnI00_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI00.Text == "False")
            {
                btnI00.Text = "True";
                btnI00.BackColor = Color.Green;
                string address = "DB1.DBX142.0";
                object setpoint = Convert.ToBoolean(btnI00.Text);
                plc.Write(address, setpoint);
            }
            
            else
            {
                btnI00.Text = "False";
                btnI00.BackColor = Color.Empty;
                string address = "DB1.DBX142.0";
                object setpoint = Convert.ToBoolean(btnI00.Text);
                plc.Write(address, setpoint);
            }
            
        }

        private void btnI01_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI01.Text == "False")
            {
                btnI01.Text = "True";
                btnI01.BackColor = Color.Green;
                string address = "DB1.DBX42.1";
                object setpoint = Convert.ToBoolean(btnI01.Text);
                plc.Write(address, setpoint);
            }
            
            else
            {
                btnI01.Text = "False";
                btnI01.BackColor = Color.Empty;
                string address = "DB1.DBX42.1";
                object setpoint = Convert.ToBoolean(btnI01.Text);
                plc.Write(address, setpoint);
            }

        }

        private void btnI02_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI02.Text == "False")
            {
                btnI02.Text = "True";
                btnI02.BackColor = Color.Green;
                string address = "DB1.DBX42.2";
                object setpoint = Convert.ToBoolean(btnI02.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI02.Text = "False";
                btnI02.BackColor = Color.Empty;
                string address = "DB1.DBX42.2";
                object setpoint = Convert.ToBoolean(btnI02.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI03_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI03.Text == "False")
            {
                btnI03.Text = "True";
                btnI03.BackColor = Color.Green;
                string address = "DB1.DBX42.3";
                object setpoint = Convert.ToBoolean(btnI03.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI03.Text = "False";
                btnI03.BackColor = Color.Empty;
                string address = "DB1.DBX42.3";
                object setpoint = Convert.ToBoolean(btnI03.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI04_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI04.Text == "False")
            {
                btnI04.Text = "True";
                btnI04.BackColor = Color.Green;
                string address = "DB1.DBX42.4";
                object setpoint = Convert.ToBoolean(btnI04.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI04.Text = "False";
                btnI04.BackColor = Color.Empty;
                string address = "DB1.DBX42.4";
                object setpoint = Convert.ToBoolean(btnI04.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI05_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI05.Text == "False")
            {
                btnI05.Text = "True";
                btnI05.BackColor = Color.Green;
                string address = "DB1.DBX42.5";
                object setpoint = Convert.ToBoolean(btnI05.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI05.Text = "False";
                btnI05.BackColor = Color.Empty;
                string address = "DB1.DBX42.5";
                object setpoint = Convert.ToBoolean(btnI05.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI06_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI06.Text == "False")
            {
                btnI06.Text = "True";
                btnI06.BackColor = Color.Green;
                string address = "DB1.DBX42.6";
                object setpoint = Convert.ToBoolean(btnI06.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI06.Text = "False";
                btnI06.BackColor = Color.Empty;
                string address = "DB1.DBX42.6";
                object setpoint = Convert.ToBoolean(btnI06.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI07_MouseClick(object sender, MouseEventArgs e)
        {

            if (btnI07.Text == "False")
            {
                btnI07.Text = "True";
                btnI07.BackColor = Color.Green;
                string address = "DB1.DBX42.7";
                object setpoint = Convert.ToBoolean(btnI07.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI07.Text = "False";
                btnI07.BackColor = Color.Empty;
                string address = "DB1.DBX42.7";
                object setpoint = Convert.ToBoolean(btnI07.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI10_MouseClick(object sender, MouseEventArgs e)
        {

            if (btnI10.Text == "False")
            {
                btnI10.Text = "True";
                btnI10.BackColor = Color.Green;
                string address = "DB1.DBX43.0";
                object setpoint = Convert.ToBoolean(btnI10.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI10.Text = "False";
                btnI10.BackColor = Color.Empty;
                string address = "DB1.DBX43.0";
                object setpoint = Convert.ToBoolean(btnI10.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI11_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI11.Text == "False")
            {
                btnI11.Text = "True";
                btnI11.BackColor = Color.Green;
                string address = "DB1.DBX43.1";
                object setpoint = Convert.ToBoolean(btnI11.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI11.Text = "False";
                btnI11.BackColor = Color.Empty;
                string address = "DB1.DBX43.1";
                object setpoint = Convert.ToBoolean(btnI11.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI12_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI12.Text == "False")
            {
                btnI12.Text = "True";
                btnI12.BackColor = Color.Green;
                string address = "DB1.DBX43.2";
                object setpoint = Convert.ToBoolean(btnI12.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI12.Text = "False";
                btnI12.BackColor = Color.Empty;
                string address = "DB1.DBX43.2";
                object setpoint = Convert.ToBoolean(btnI12.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI13_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI13.Text == "False")
            {
                btnI13.Text = "True";
                btnI13.BackColor = Color.Green;
                string address = "DB1.DBX43.3";
                object setpoint = Convert.ToBoolean(btnI13.Text);
                plc.Write(address, setpoint);

            }

            else
            {
                btnI13.Text = "False";
                btnI13.BackColor = Color.Empty;
                string address = "DB1.DBX43.3";
                object setpoint = Convert.ToBoolean(btnI13.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI14_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI14.Text == "False")
            {
                btnI14.Text = "True";
                btnI14.BackColor = Color.Green;
                string address = "DB1.DBX43.4";
                object setpoint = Convert.ToBoolean(btnI14.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI14.Text = "False";
                btnI14.BackColor = Color.Empty;
                string address = "DB1.DBX43.4";
                object setpoint = Convert.ToBoolean(btnI14.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI15_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI15.Text == "False")
            {
                btnI15.Text = "True";
                btnI15.BackColor = Color.Green;
                string address = "DB1.DBX43.5";
                object setpoint = Convert.ToBoolean(btnI15.Text);
                plc.Write(address, setpoint);

            }

            else
            {
                btnI15.Text = "False";
                btnI15.BackColor = Color.Empty;
                string address = "DB1.DBX43.5";
                object setpoint = Convert.ToBoolean(btnI15.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI16_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI16.Text == "False")
            {
                btnI16.Text = "True";
                btnI16.BackColor = Color.Green;
                string address = "DB1.DBX43.6";
                object setpoint = Convert.ToBoolean(btnI16.Text);
                plc.Write(address, setpoint);
        
             }

            else
            {
                btnI16.Text = "False";
                btnI16.BackColor = Color.Empty;
                string address = "DB1.DBX43.6";
                object setpoint = Convert.ToBoolean(btnI16.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI17_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI17.Text == "False")
            {
                btnI17.Text = "True";
                btnI17.BackColor = Color.Green;
                string address = "DB1.DBX43.7";
                object setpoint = Convert.ToBoolean(btnI17.Text);
                plc.Write(address, setpoint);
        
             }

            else
            {
                btnI17.Text = "False";
                btnI17.BackColor = Color.Empty;
                string address = "DB1.DBX43.7";
                object setpoint = Convert.ToBoolean(btnI17.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI20_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI20.Text == "False")
            {
                btnI20.Text = "True";
                btnI20.BackColor = Color.Green;
                string address = "DB1.DBX44.0";
                object setpoint = Convert.ToBoolean(btnI20.Text);
                plc.Write(address, setpoint);
        
             }

            else
            {
                btnI20.Text = "False";
                btnI20.BackColor = Color.Empty;
                string address = "DB1.DBX44.0";
                object setpoint = Convert.ToBoolean(btnI20.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI21_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI21.Text == "False")
            {
                btnI21.Text = "True";
                btnI21.BackColor = Color.Green;
                string address = "DB1.DBX44.1";
                object setpoint = Convert.ToBoolean(btnI21.Text);
                plc.Write(address, setpoint);
        
             }

            else
            {
                btnI21.Text = "False";
                btnI21.BackColor = Color.Empty;
                string address = "DB1.DBX44.1";
                object setpoint = Convert.ToBoolean(btnI21.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI22_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI22.Text == "False")
            {
                btnI22.Text = "True";
                btnI22.BackColor = Color.Green;
                string address = "DB1.DBX44.2";
                object setpoint = Convert.ToBoolean(btnI22.Text);
                plc.Write(address, setpoint);
        
             }

            else
            {
                btnI22.Text = "False";
                btnI22.BackColor = Color.Empty;
                string address = "DB1.DBX44.2";
                object setpoint = Convert.ToBoolean(btnI22.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI23_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI23.Text == "False")
            {
                btnI23.Text = "True";
                btnI23.BackColor = Color.Green;
                string address = "DB1.DBX44.3";
                object setpoint = Convert.ToBoolean(btnI23.Text);
                plc.Write(address, setpoint);
        
             }

            else
            {
                btnI23.Text = "False";
                btnI23.BackColor = Color.Empty;
                string address = "DB1.DBX44.3";
                object setpoint = Convert.ToBoolean(btnI23.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI24_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI24.Text == "False")
            {
                btnI24.Text = "True";
                btnI24.BackColor = Color.Green;
                string address = "DB1.DBX44.4";
                object setpoint = Convert.ToBoolean(btnI24.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI24.Text = "False";
                btnI24.BackColor = Color.Empty;
                string address = "DB1.DBX44.4";
                object setpoint = Convert.ToBoolean(btnI24.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI25_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI25.Text == "False")
            {
                btnI25.Text = "True";
                btnI25.BackColor = Color.Green;
                string address = "DB1.DBX44.5";
                object setpoint = Convert.ToBoolean(btnI25.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI25.Text = "False";
                btnI25.BackColor = Color.Empty;
                string address = "DB1.DBX44.5";
                object setpoint = Convert.ToBoolean(btnI25.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI26_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI26.Text == "False")
            {
                btnI26.Text = "True";
                btnI26.BackColor = Color.Green;
                string address = "DB1.DBX44.6";
                object setpoint = Convert.ToBoolean(btnI26.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI26.Text = "False";
                btnI26.BackColor = Color.Empty;
                string address = "DB1.DBX44.6";
                object setpoint = Convert.ToBoolean(btnI26.Text);
                plc.Write(address, setpoint);
            }


        }

        private void btnI27_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI27.Text == "False")
            {
                btnI27.Text = "True";
                btnI27.BackColor = Color.Green;
                string address = "DB1.DBX44.7";
                object setpoint = Convert.ToBoolean(btnI27.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI27.Text = "False";
                btnI27.BackColor = Color.Empty;
                string address = "DB1.DBX44.7";
                object setpoint = Convert.ToBoolean(btnI27.Text);
                plc.Write(address, setpoint);
            }
        }              

        private void btnI30_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI30.Text == "False")
            {
                btnI30.Text = "True";
                btnI30.BackColor = Color.Green;
                string address = "DB1.DBX45.0";
                object setpoint = Convert.ToBoolean(btnI30.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI30.Text = "False";
                btnI30.BackColor = Color.Empty;
                string address = "DB1.DBX45.0";
                object setpoint = Convert.ToBoolean(btnI30.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI31_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI31.Text == "False")
            {
                btnI31.Text = "True";
                btnI31.BackColor = Color.Green;
                string address = "DB1.DBX45.1";
                object setpoint = Convert.ToBoolean(btnI31.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI31.Text = "False";
                btnI31.BackColor = Color.Empty;
                string address = "DB1.DBX45.1";
                object setpoint = Convert.ToBoolean(btnI31.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI32_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI32.Text == "False")
            {
                btnI32.Text = "True";
                btnI32.BackColor = Color.Green;
                string address = "DB1.DBX45.2";
                object setpoint = Convert.ToBoolean(btnI32.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI32.Text = "False";
                btnI32.BackColor = Color.Empty;
                string address = "DB1.DBX45.2";
                object setpoint = Convert.ToBoolean(btnI32.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI33_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI33.Text == "False")
            {
                btnI33.Text = "True";
                btnI33.BackColor = Color.Green;
                string address = "DB1.DBX45.3";
                object setpoint = Convert.ToBoolean(btnI33.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI33.Text = "False";
                btnI33.BackColor = Color.Empty;
                string address = "DB1.DBX45.3";
                object setpoint = Convert.ToBoolean(btnI33.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI34_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI34.Text == "False")
            {
                btnI34.Text = "True";
                btnI34.BackColor = Color.Green;
                string address = "DB1.DBX45.4";
                object setpoint = Convert.ToBoolean(btnI34.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI34.Text = "False";
                btnI34.BackColor = Color.Empty;
                string address = "DB1.DBX45.4";
                object setpoint = Convert.ToBoolean(btnI34.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI35_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI35.Text == "False")
            {
                btnI35.Text = "True";
                btnI35.BackColor = Color.Green;
                string address = "DB1.DBX45.5";
                object setpoint = Convert.ToBoolean(btnI35.Text);
                plc.Write(address, setpoint);        
             }

            else
            {
                btnI35.Text = "False";
                btnI35.BackColor = Color.Empty;
                string address = "DB1.DBX45.5";
                object setpoint = Convert.ToBoolean(btnI35.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI36_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI36.Text == "False")
            {
                btnI36.Text = "True";
                btnI36.BackColor = Color.Green;
                string address = "DB1.DBX45.6";
                object setpoint = Convert.ToBoolean(btnI36.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI36.Text = "False";
                btnI36.BackColor = Color.Empty;
                string address = "DB1.DBX45.6";
                object setpoint = Convert.ToBoolean(btnI36.Text);
                plc.Write(address, setpoint);
            }
        }

        private void btnI37_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnI37.Text == "False")
            {
                btnI37.Text = "True";
                btnI37.BackColor = Color.Green;
                string address = "DB1.DBX45.7";
                object setpoint = Convert.ToBoolean(btnI37.Text);
                plc.Write(address, setpoint);
            }

            else
            {
                btnI37.Text = "False";
                btnI37.BackColor = Color.Empty;
                string address = "DB1.DBX45.7";
                object setpoint = Convert.ToBoolean(btnI37.Text);
                plc.Write(address, setpoint);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbStep1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {                      

            if (tbValues.Text == "")
            {
                string[] step1 = new string[] {lbVmin.Text + ":", tbVmin.Text + ", ", lbVmax.Text + ":", tbVmax.Text + ", ", lbVreal.Text + ":", tbVreal.Text };
                tbValues.Text = string.Join(" ", step1);
            }
            else if (tbValues.Text == "")
            {
                string[] step = new string[3] { tbVmin.Text, tbVmax.Text, tbVreal.Text };
                tbValues.Text = string.Join(", ", step);
            }
            else
            {
                string[] step = new string[3] { tbVmin.Text, tbVmax.Text, tbVreal.Text };
                tbValues.Text = string.Join(", ", step);
            }


            //      Input buttons
            string[] varInput = new string[] { btnI00.Text, btnI01.Text, btnI02.Text, btnI03.Text, btnI04.Text, btnI05.Text, btnI06.Text, btnI07.Text, btnI10.Text, btnI11.Text, btnI12.Text, btnI13.Text, btnI14.Text, btnI15.Text, btnI16.Text, btnI17.Text, btnI20.Text, btnI21.Text, btnI22.Text, btnI23.Text, btnI24.Text, btnI25.Text, btnI26.Text, btnI27.Text, btnI30.Text, btnI31.Text, btnI32.Text, btnI33.Text, btnI34.Text, btnI35.Text, btnI36.Text, btnI37.Text };
            string[] varInputName = new string[] { "I0.0", "I0.1", "I0.2", "I0.3", "I0.4", "I0.5", "I0.6", "I0.7", " I1.0", " I1.1", " I1.2", " I1.3", " I1.4", " I1.5", " I1.6", " I1.7", "I2.0", "I2.1", "I2.2", "I2.3", "I2.4", "I2.5", "I2.6", "I2.7", "I3.0", "I3.1", "I3.2", "I3.3", "I3.4", "I3.5", "I3.6", "I3.7" };
            string[] varInputToSend = new string[] { btnI00.Text, btnI01.Text, btnI02.Text, btnI03.Text, btnI04.Text, btnI05.Text, btnI06.Text, btnI07.Text, btnI10.Text, btnI11.Text, btnI12.Text, btnI13.Text, btnI14.Text, btnI15.Text, btnI16.Text, btnI17.Text, btnI20.Text, btnI21.Text, btnI22.Text, btnI23.Text, btnI24.Text, btnI25.Text, btnI26.Text, btnI27.Text, btnI30.Text, btnI31.Text, btnI32.Text, btnI33.Text, btnI34.Text, btnI35.Text, btnI36.Text, btnI37.Text };
            
            
            
            
            //      To Send

            for (int i = 0; i < varInputToSend.Length; i++)
            {
                if (varInputToSend[i] == "True")
                {
                    varInputToSend[i] = "1";
                }
                else varInputToSend[i] = "0";

            }

            

            int[] varInputSend1 = Array.ConvertAll(varInputToSend, int.Parse);
            labelSendArray.Text = string.Join("", varInputSend1);
            //GlobalVariables. = varInputSend1;


            for (int i = 0; i < varInput.Length; i++)
            {
                if (varInput[i] == "True")
                {
                    varInput[i] = varInputName[i];
                }
                else varInput[i] = "";

            }

            
          

                    



            //      Input in Step
            if (tbInputs.Text == "")
            {                
                tbInputs.Text = string.Join("  ", varInput);
            }
            else if (tbInputs.Text == "")
            {
                tbInputs.Text = string.Join("  ", varInput);
            }
            else if(tbInputs.Text == "")
            {
                tbInputs.Text = string.Join("  ", varInput);
            }
                 
            

            //      Step Number
            if (tbStep.Text == "")
            {
                tbStep.Text = tbStepNumb.Text;
            }
            //else if (labelTwo.Text == "")
            //{
            //    labelTwo.Text = tbStepNumb.Text;
            //}
            //else if (labelThree.Text == "")
            //{
            //    labelThree.Text = tbStepNumb.Text;
            //}




            //      Test Type

            int[] testArray = { 1, 0, 0, 0, 0, 0, 0, 0 };  // bit[0] is START, that's why it's value is 1

            if (cbTestType.Text == "Leak")
            {
                testArray[2] = 1;
                tbTestType.Text = "Leak Test";
            }
                
            else if (cbTestType.Text == "Color")
            {
                testArray[3] = 1;
                tbTestType.Text = "Color Test";
            }

            else if (cbTestType.Text == "Current")
            {
                testArray[4] = 1;
                tbTestType.Text = "Current Test";
            }
            else if (cbTestType.Text == "Lights")
            {
                testArray[5] = 1;
                tbTestType.Text = "Lights Test";
            }
            else if (cbTestType.Text == "Eletric")
            {
                testArray[6] = 1;
                tbTestType.Text = "Eletric Test";
            }
            else if (cbTestType.Text == "Inspection")
            {
                testArray[7] = 1;
                tbTestType.Text = "Inspection Test";
            }

            lbTestArray.Text = string.Join("  ", testArray);

           


        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Inês Antunes\Desktop\INTERFACE\Interface1.3\Interface\recipe";

            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                labelRecipe.Text = "File already exists";
            }
            else
            {
                labelRecipe.Text = "File doesn't exists";
                FileStream fs = File.Create(path);

               
            }

            
            File.AppendAllText(path,labelSendArray.Text + Environment.NewLine );

            File.AppendAllText(path,lbTestArray.Text + Environment.NewLine);

            tbRead.Text = File.ReadAllText(path);

            tbLine1.Text = File.ReadLines(path).First();
            tbLine2.Text = File.ReadAllLines(path).Skip(1).First();



            int i = File.ReadAllLines(path).Count();
            string[] var = File.ReadAllLines(path);
            tbNumberLine.Text = Convert.ToString(i);
                
                                        
        }

        private void btnSearchPath_Click(object sender, EventArgs e)
        {
            //Process.Start(@"C:");

            //tbPath.Text = "";

            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    tbPath.Text = folderBrowserDialog1.SelectedPath;
            //}


            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(tbPath.Text);
            System.IO.FileSystemInfo[] files = di.GetFileSystemInfos();
            cbRecipe.Items.AddRange(files);


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Recipe frm = new Recipe();
            frm.Show();
            this.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void tbRead_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
