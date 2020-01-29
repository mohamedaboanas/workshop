using System;
using System.Windows.Forms;

namespace MetaData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_dialog_Click(object sender, EventArgs e)
        {
            if (get_dll_name.ShowDialog() == DialogResult.OK)
            {
                txt_filename.Text = get_dll_name.FileName;

                ReflectDll.Reflect(txt_filename.Text);
            }
        }
    }
}
