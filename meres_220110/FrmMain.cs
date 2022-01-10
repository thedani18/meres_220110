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
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }
        public List<string> id = new List<string>();
        public List<int> sum = new List<int>();
        public List<int> szamlacount = new List<int>();
        public List<int> szamlasum = new List<int>();
        public FrmMain()
        {
            ConnectionString = @"Server = (localdb)\MSSQLLocalDB; Database = palyazatok;";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            fillDGV();
        }


        private void fillDGV()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                var r = new SqlCommand("SELECT palyazat.id,palyazat.tervezetC + palyazat.tervezetA, count(szamla.id), sum(szamla.ertek) "
                    + "FROM koltsegtipus,szamla,palyazat "
                    + "WHERE palyazat.id = szamla.palyazatId "
                    + "and szamla.koltsegtipusId = koltsegtipus.id "
                    + "GROUP BY palyazat.id,palyazat.tervezetC + palyazat.tervezetA order by palyazat.id", conn).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1] + " Ft", r[2]+" db", r[3] + " Ft");
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            new FrmNew(ConnectionString).Show();
        }
    }
}
