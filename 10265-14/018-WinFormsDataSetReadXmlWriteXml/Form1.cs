using System;
using System.Data;
using System.Windows.Forms;

namespace _018_WinFormsDataSetReadXmlWriteXml
{
    public partial class Form1 : Form
    {
        private DataSet ds;
        private String fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = "arquivos de cadastro|*.xml" };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            fileName = ofd.FileName;

            ds = new DataSet();
            ds.ReadXml(fileName);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog { Filter = "arquivos de cadastro|*.xml", FileName = fileName };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            ds.WriteXml(sfd.FileName);

            MessageBox.Show("Salvei a bagaça");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
