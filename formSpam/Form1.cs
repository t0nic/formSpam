//////////////
//// very simple tool that sends http requests with form data
//// to a script, which of course, is over http.
//// 
///  i made it to spam a phishing page, maybe you could 
///  use it for the same! who knows m8
///  
/// 
/// 
/// TODO:
///     [DONE, KINDA] ADD A CHECK FOR INVALID AND EMPTY VALUES GIVEN FROM TEXT INPUT
///     ADD SOME STYLE TO THE GUI
///     LIMIT MEMORY USE BY CHECKING IF ANY VARIABLES/OBJECT THAT DONT HAVE TO BE RECREATED EVERY LOOP
///     
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formSpam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = true;
            this.button1.Enabled = false;

            // collect the variables
            string theTarget = this.theURL.ToString();
            string userVarNameStr = userVarName.ToString();
            string userVarValueStr = userVarValue.ToString();
            string passVarNameStr = passVarName.ToString();
            string passVarValueStr = passVarValue.ToString();

            if (theTarget == "" || userVarNameStr == "" || userVarValueStr == "" || passVarNameStr == "" || passVarValueStr == "")
            {
                MessageBox.Show("You must enter all information!");
                this.button2.Enabled = false;
                this.button1.Enabled = true;
                return;
            }

            while (this.button2.Enabled)
            {
                String result = "";
                String strPost = userVarNameStr + "=" + userVarValueStr + "&" + passVarNameStr + "=" + passVarValueStr;
                StreamWriter myWriter = null;
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(theTarget);
                objRequest.Method = "POST";
                objRequest.ContentLength = strPost.Length;
                objRequest.ContentType = "application/x-www-form-urlencoded";
                try
                {
                    myWriter = new StreamWriter(objRequest.GetRequestStream());
                    myWriter.Write(strPost);
                }
                catch (Exception exc){}
                finally{myWriter.Close();}
                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    sr.Close();
                }
                this.listView1.Items.Add("\r\n {0}", result);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Add("\r\nSTOPPED!");
            this.button2.Enabled = false;
            this.button1.Enabled = true;
            
        }
    }
}
