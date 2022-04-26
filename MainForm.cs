using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokiWord
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            doubleBuffer(MainPanel);
            doubleBuffer(PlayPanel);
        }

        private void play_Click(object sender, EventArgs e)
        {
            doubleBuffer(answer_box);
            doubleBuffer(ok_box);
            PlayPanel.BringToFront();
        }
        
        // Method to Avoid Flickering of Images
        public void doubleBuffer(Panel panel)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           panel, new object[] { true });
        }
    }
}
