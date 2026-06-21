using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMahasiswaADO
{
    internal class DataMahasiswa1
    {
        public string nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string NamaProdi { get; set; } 
        public DateTime TanggalDaftar { get; set; }

        static string connectionString = "Data Source=DESKTOP-SEGECHR\\MUHIRFAN;Initial Catalog=DBAkademikADO;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;

        CrystalReport listMahasiswa = new CrystalReport();

        string Prodi { get; set; }
        DateTime tanggalMasuk { get; set; }
    }
}
