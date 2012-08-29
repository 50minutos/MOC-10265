using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _019_xxxDataAdapter
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            const string sc = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            const string cmd = "SELECT * FROM Person.Contact";

            da = new SqlDataAdapter(cmd, sc);

            ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Button1Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(da);
            
            da.Update(ds);

            MessageBox.Show("Gravei!!!");
        }
    }
}
