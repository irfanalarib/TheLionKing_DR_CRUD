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

namespace CRUDMahasiswaADO
{
    public partial class FormReport : Form
    {

        DAL dbLogic = new DAL();

        static string connectionString = "Data Source=DESKTOP-SEGECHR\\MUHIRFAN;Initial Catalog=DBAkademikADO;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;

        CrystalReport listMahasiswa = new CrystalReport();
        string prodi { get; set; }
        DateTime tglmasuk { get; set; }


        public FormReport(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();
            prodi = Prodi;
            tglmasuk = TglMasuk;

            try
            {
                // Logika database dipindah ke class DAL
                DataTable dtMahasiswa = dbLogic.getDataRekap(prodi, tglmasuk);

                listMahasiswa.SetDataSource(dtMahasiswa);
                crystalReportViewer1.ReportSource = listMahasiswa;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                //SimpanLog(ex.Message);
                MessageBox.Show("Gagal Load data: " + ex.Message);
            }
        }
    }
}
