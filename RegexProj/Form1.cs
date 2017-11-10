using RegexProj.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexProj
{
    public partial class RietEmailExtracter : Form
    {
        OpenFileDialog dialog = new OpenFileDialog();
        public int count { get; set; }
        public RietEmailExtracter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialog.Filter ="txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.RestoreDirectory = false;
           
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string fname = dialog.FileName;
                ThreadPool.QueueUserWorkItem(delegate {
                    ExtractEmails(fname);
                });
            }

        }

        public void ExtractEmails(String filename)
        {
            count = 0;
           // string data = File.ReadAllText(filename);
            string[] dataLine = File.ReadAllLines(filename);
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",RegexOptions.IgnoreCase);
            Regex hash = null;
            if (comboBox1.Text.Equals("MD5")) {
                 hash = new Regex(@"[0-9a-f]{32}", RegexOptions.IgnoreCase);
                MessageBox.Show("The program will try to return MD5 hashed passwords together with the email! Please give it time to scan the file and load the results.");
            }
            else if(comboBox1.Text.Equals("SHA1"))
            {
                //sha 1
                hash = new Regex(@"([a-f0-9]{40})", RegexOptions.IgnoreCase);
                MessageBox.Show("The program will try to return sha-1 hashed passwords together with the email! Please give it time to scan the file and load the results.");
            }else if (comboBox1.Text.Equals("Plaintext"))
            {
                hash = null;
                MessageBox.Show("The program will try to return plaintext passwords together with the email! Please give it time to scan the file and load the results.");
            }


            //MatchCollection emailMatches = emailRegex.Matches(dataLine);
            //  MatchCollection md5Matches = hash.Matches(dataLine);
            aevionLabel4.Text = "" + dataLine.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataLine.Length; i++)
            {
                Match email = emailRegex.Match(dataLine[i]);
                Match HashLine = null;
                if (hash != null) {
                     HashLine = hash.Match(dataLine[i]);
                }

                if (HashLine != null && HashLine.Success && email.Success || comboBox1.Text.Equals("Plaintext") && hash == null && email.Success)
                {
                    String mail = email.Value ?? "";
                    String[] breakApart = mail.Split('.');
                    string filter = breakApart[1];
                    string filterName = comboBox2.Text.ToString();

       
           

                    if (aevionCheckBox1.Checked) {
                        if (breakApart[1] != null && breakApart[1].Equals(filterName)) {
                            if (hash != null && HashLine != null)
                            {
                                string s = (email.Value + ":" + HashLine.Value);
                                listBox1.Items.Add(s);
                                count++;
                            } else
                            {
                                String fullLine = dataLine[i].ToString() ?? "";
                                String[] plainLine = fullLine.Split(':');
                                if (plainLine.Count() > 1) {
                                    string plainPass = plainLine[1] ?? "";
                                    string sPlain = (email.Value + ":" + plainPass);
                                    listBox1.Items.Add(sPlain);
                                    count++;
                                }else
                                {
                                     MessageBox.Show("There was an error trying to get the plaintext. This can happen if the file you tried to get plaintext from doesn't use the email:text format that is required for extracting plaintext!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    return; 
                            }
                            }
                        }


                    }else
                    {
                        if (hash != null && HashLine != null)
                        {
                            string s = (email.Value + ":" + HashLine.Value);
                            listBox1.Items.Add(s);
                            count++;
                        }else
                        {
                            String fullLine = dataLine[i].ToString() ?? "";
                            String[] plainLine = fullLine.Split(':');
                            string plainPass = plainLine[1] ?? "";
                            string sPlain = (email.Value + ":" + plainPass);
                            listBox1.Items.Add(sPlain);
                            count++;
                        }
                    }
                 }

                aevionLabel4.Text = "Done loading " + count + " items found.";
            } 
         }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBox1.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Success");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (aevionCheckBox1.Checked)
            {
                comboBox2.Enabled = true;
            }else
            {
                comboBox2.Enabled = false;
            }
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBox1.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Success");
            }
        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                ExtractEmails(fname);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                ExtractEmails(fname);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBox1.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Success");
            }
        }

        private void aevionCheckBox1_Click(object sender, EventArgs e)
        {
            if (!aevionCheckBox1.Checked)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void RietEmailExtracter_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
