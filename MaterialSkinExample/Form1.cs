using MaterialSkin;
using MaterialSkin.Controls;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkinExample
{

    public partial class Form1 : MaterialForm

    {
        public Form1()
        {
            InitializeComponent();
            materialButtonOk.DialogResult = DialogResult.OK;
        }

        private void materialButtonOk_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
