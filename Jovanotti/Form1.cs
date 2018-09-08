using System;
using System.Windows.Forms;

namespace Jovanotti
{
    public partial class Form1 : Form
    {
        private bool m_bInitialifed = false;

        public Form1()
        {
            InitializeComponent();

            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
        }

        static string Tranflate (string text)
        {
            return text.Replace("s", "f").Replace("S","F");
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (!m_bInitialifed)
            textBoxOutput.Text = Tranflate(textBoxInput.Text);
        }

        private void buttonCopyTextToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxOutput.Text);
        }
    }
}
