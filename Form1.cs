using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_sazka
{
    public partial class Form1 : Form
    {
        string currentid = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(id.Text.Length == 5 & id.Text.All(char.IsDigit)))
            {
                error.Text = "please enter 5 digit ID";
                enter.Text = "RETRY";
            }
            else
            {
                error.Text = "";
                currentid = id.Text;
                id.Text = "";
                print_Table();
                show_boxes();
            }
            //Environment.Exit(0);
        }
        private void show_boxes()
        {
            groupBox1.Visible = true;

        }

        private void print_Table()
        {
            string matchlist = File.ReadAllText(@"zapasy.txt");
            List<string> matchlistlines = matchlist.Split('\n').ToList();
            numbers.Items.Clear();
            home.Items.Clear();
            host.Items.Clear();

            foreach (string line in matchlistlines)
            {
                string[] a = Convert.ToString(line).Split(' ');
                string[] b = Convert.ToString(line).Split('-');
                numbers.Items.Add(a[0].Trim());
                home.Items.Add(b[0].Remove(0, 2).Trim());
                host.Items.Add(b[1].Trim());
            }

            enter.Text = "REFRESH";
        }


        private void submit_Click(object sender, EventArgs e)
        {
            string bet = "";
            List<string> matchlistlines = File.ReadAllText(@"zapasy.txt").Split('\n').ToList();

            for (int i = 0; i < numbers.Items.Count; i++)
            {

                bet = bet + matchlistlines[i].Trim() + "    "+"\n";
            }
            File.WriteAllText(currentid+".TXT", bet);
        }

        private void c_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                if (e.NewValue == CheckState.Checked & d.GetItemChecked(e.Index))
                    d.SetItemChecked(e.Index, false);
        }

        private void d_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                if (e.NewValue == CheckState.Checked & c.GetItemChecked(e.Index))
                    c.SetItemChecked(e.Index, false);

        }
    }
}
