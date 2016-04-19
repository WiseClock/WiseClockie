using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WiseClockie.System;
using WiseClockie.Media;
using WiseClockie.Utils;

namespace WiseClockieTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wiseButton1_Click(object sender, EventArgs e)
        {
            OpenDirectoryDialog odd = new OpenDirectoryDialog();
            if (odd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(odd.Folder);
            }
        }

        private void wiseButton2_Click(object sender, EventArgs e)
        {
            WiseSoundPlayer.Play(WiseMidiFile.Nyancat, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WiseList<string> x = new WiseList<string>();
            x.Add("a", 5);
            x.Add("b", 0.1);
            x.Add("c", 0.1);
            x.Add("d", 0.1);
            x.Add("e", 0.1);
            Console.WriteLine(x.GetRandom());
        }
    }
}
