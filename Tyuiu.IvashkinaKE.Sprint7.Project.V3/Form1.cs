using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.IvashkinaKE.Sprint7.Project.V3.Lib;

namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public string openFilePath;

        DataService ds = new DataService();

        
        private void buttonHelp_IKE_Click(object sender, EventArgs e)
            {
                FormAbout formAbout = new FormAbout();
                formAbout.ShowDialog();
            }

        private void buttonUniversity_IKE_Click(object sender, EventArgs e)
            {
                FormAboutUniversity formAbout = new FormAboutUniversity();
                formAbout.ShowDialog();
            }

        private void buttonTeachers_IKE_Click(object sender, EventArgs e)
            {
                FormTeachers formAbout = new FormTeachers();
                formAbout.ShowDialog();
            }

        

            


        }
    }

