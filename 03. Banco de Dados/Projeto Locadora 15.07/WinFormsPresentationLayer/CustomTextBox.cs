using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPresentationLayer
{
    class CustomTextBox : TextBox
    {
        public TextBoxType TextType { get; set; }

        public CustomTextBox()
        {
            this.Leave += CustomTextBox_Leave;
        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            if (this.TextType == TextBoxType.Moeda)
            {
                this.Text = double.Parse(this.Text).ToString("C2");
            }
        }
    }
    enum TextBoxType
    {
        Normal,
        Email,
        CPF,
        CNPJ,
        Moeda
    }
}
