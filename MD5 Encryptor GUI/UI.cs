using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5_Encryptor_GUI
{
    public partial class UI : Form
    {
        Main main = new Main();
        public UI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
            main.Encrypt(InputField.Text);
            OutputField.Text = main.sb.ToString();
        }

        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
            main.Decrypt(InputField.Text);
            OutputField.Text = main.decrypted;        }

        private void CopyToClipboard_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputField.Text);
            CopiedToClipboard_Label.Visible = true;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            OutputField.Clear();
        }
    }
}
