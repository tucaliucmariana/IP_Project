using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLicenceForm
{
    public partial class FormQuiz : Form
    {
        public FormQuiz()
        {
            InitializeComponent();
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            panelQuestion.BringToFront();
            resetAnswers();
        }

        private void resetAnswers()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }
    }
}
