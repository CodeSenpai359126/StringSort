using System;
using System.Windows.Forms;

namespace StringSortierer
{
    public partial class Programm : Form
    {
        public Programm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sortiert die Eingaben aus der Forms Anwendung mit dem Menu Item "Sortiere"
        /// </summary>
        private void sortiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] array = { txtbxinput1.Text, txtbxinput2.Text, txtbxinput3.Text, txtbxinput4.Text, txtbxinput5.Text };            

            Array output = Sort_String(array);
            
            Clear();

            foreach (object item in output)
            {
                lstbxoutput.Items.Add(item);
            }
        }

        /// <summary>
        /// Die Funktion sortiert eine Liste an Zahlen oder Strings
        /// </summary>
        /// <param name="array"> Eine Liste an Strings mit Zahlen oder Worten</param>
        /// <returns>Sortierte Liste</returns>
        private Array Sort_String(string[] array)
        { 
            try
            {
                int[] int_array = Array.ConvertAll(array, int.Parse);

                int temp;

                for (int i = 0; i < int_array.Length; i++)
                {
                    for (int j = 0; j < int_array.Length - 1; j++)
                    {
                        if (int_array[j] > int_array[j + 1])
                        {
                            temp = int_array[j + 1];
                            int_array[j + 1] = int_array[j];
                            int_array[j] = temp;
                        }
                    }
                }
                return int_array;
            }
            catch
            {
                string temp;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
        }

        /// <summary>
        /// Löscht alle Eingaben aus der Form Anwendung
        /// </summary>
        private void Clear()
        {
            TextBox[] txtbx = { txtbxinput1, txtbxinput2, txtbxinput3, txtbxinput4, txtbxinput5 };

            foreach (TextBox txtbx_ in txtbx)
            {
                txtbx_.Text = "";
            }

            lstbxoutput.Items.Clear();
        }

        /// <summary>
        /// Beendet das Programm mit dem Menu Item "Ende"
        /// </summary>
        private void endeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Löscht alle Eingaben aus der Forms Anwendung mit dem Menu Item "Clear"
        /// </summary>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }    
}
