using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meres_220110
{
    public partial class FrmNew : Form
    {
        public string ConnectionString { get; set; }
        public FrmNew(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmNew_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {

                c.Open();
                var r = new SqlCommand("SELECT COUNT(palyazat.id)+1 "
                    + "FROM palyazat"
                    + ";", c).ExecuteReader();
                while (r.Read())
                {
                    tb_id.Text = ($"{r[0]}");
                }
                
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    int Akeret = Convert.ToInt32(tb_Akeret.Text);
                    int Ckeret = Convert.ToInt32(tb_Ckeret.Text);
                    if (Akeret < 0 || Ckeret < 0)
                    {
                        MessageBox.Show("Hibás adatbevitel");
                    }
                    else
                    {
                        new SqlCommand($"INSERT INTO palyazat VALUES ({tb_id.Text}, {Akeret}, {Ckeret})",conn).ExecuteNonQuery();
                        this.Close();
                        MessageBox.Show("Sikeres adatbevitel");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hibás adatbevitel");
                    conn.Close();
                }
            }
        }
    }
}
