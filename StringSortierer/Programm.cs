using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringSortierer
{
    public partial class Programm : Form
    {
        public Programm()
        {
            InitializeComponent();
        }

        private void sortiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Array output = Sort_String(txtbxinput1.Text, txtbxinput2.Text, txtbxinput3.Text, txtbxinput4.Text, txtbxinput5.Text);

            Clear();

            foreach (object item in output)
            {
                lstbxoutput.Items.Add(item);
            }
        }

        private Array Sort_String(string str1, string str2, string str3, string str4, string str5)
        {
            string temp;

            string[] Array = { str1, str2, str3, str4, str5 };

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j].CompareTo(Array[j + 1]) > 0)
                    {
                        temp = Array[j + 1];
                        Array[j + 1] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return Array;
        }

        private void Clear()
        {
            TextBox[] txtbx = { txtbxinput1, txtbxinput2, txtbxinput3, txtbxinput4, txtbxinput5 };

            foreach (TextBox txtbx_ in txtbx)
            {
                txtbx_.Text = "";
            }

            lstbxoutput.Items.Clear();
        }

        private void endeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }    
}
