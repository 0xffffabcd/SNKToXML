using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SNKToXML
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenSNKFileButtonClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
                {
                    Title = "Open your SNK file",
                    Filter = "Strong Name Key file (*.snk)|*.snk|All Files (*.*)|*.*"
                };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                publicKeyTextBox.Clear();
                privateKeyTextBox.Clear();
                try
                {
                    var snkBytes = File.ReadAllBytes(openFileDialog.FileName);

                    using (var provider = new RSACryptoServiceProvider())
                    {
                        provider.ImportCspBlob(snkBytes);
                        publicKeyTextBox.Text = Beautify(provider.ToXmlString(false));
                        privateKeyTextBox.Text = Beautify(provider.ToXmlString(true));
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string Beautify(string xmlString)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xmlString);
            var sb = new StringBuilder();
            var settings = new XmlWriterSettings { Indent = true, IndentChars = "  ", NewLineChars = Environment.NewLine, NewLineHandling = NewLineHandling.Replace };
            using (var writer = XmlWriter.Create(sb, settings))
            {
                doc.Save(writer);
            }
            return sb.ToString();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            SaveFile(publicKeyTextBox.Text);
        }

        private void Button2Click(object sender, EventArgs e)
        {
            SaveFile(privateKeyTextBox.Text);
        }

        private static void SaveFile(string fileContent)
        {
            var saveFileDialog = new SaveFileDialog
                {
                    Title = "Save XML Public Key",
                    Filter = "XML File (*.xml)|*.xml"
                };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog.FileName, Encoding.UTF8.GetBytes(fileContent));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Saving the file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PublicKeyTextBoxTextChanged(object sender, EventArgs e)
        {
            if (publicKeyTextBox.Text.Trim().Length > 0)
            {
                savePublicKeyButton.Enabled = true;
            }
        }

        private void PrivateKeyTextBoxTextChanged(object sender, EventArgs e)
        {
            if (privateKeyTextBox.Text.Trim().Length > 0)
            {
                savePrivateKeyButton.Enabled = true;
            }
        }

        private void ShowAboutBoxButtonClick(object sender, EventArgs e)
        {
            using (var aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog();
            }
        }
    }
}