using OzIMDB.Models;
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

namespace OzIMDB
{
    public partial class Form1 : Form
    {
        string dbName = "OzImdb";
        SqlConnection con = new SqlConnection("server=.; uid = sa; pwd=123;");
        List<Film> filmler;
        bool guncellemeAcik = false;

        public Form1()
        {
            con.Open();
            VeriTabaniYoksaOlustur();
            InitializeComponent();
            FilmleriListele();
            
            FilmleriListele();
            
        }
        //sorguyu oluştur
        //sorguyu çalıştır
        // sorgu sonucunu döndür
        // okuyucuyu kapat
        private void FilmleriListele()
        {
            guncellemeAcik = false;
            var cmd =new SqlCommand("SELECT * FROM Filmler", con);
            var dr = cmd.ExecuteReader();
            filmler = new List<Film>();

            while (dr.Read())
            {
                //satır satır filmler listesine film ekleyeceğiz
                filmler.Add(new Film
                {
                    Id = (int)dr["Id"],
                    FilmAd = (string) dr["FilmAd"],
                    Puan = dr["Puan"] as int?,
                    Foto = ConvertToImage(dr["Foto"] as byte[])

                });
            }
            dr.Close();
            lstFilmler.DataSource = filmler;
            guncellemeAcik = true;
            
        }

        private void VeriTabaniYoksaOlustur()
        {
            var cmd = new SqlCommand($"SELECT DB_ID('{dbName}')", con);
            short? sonuc = cmd.ExecuteScalar() as short?;

            if (!sonuc.HasValue)    // sonuc ==null
            {
                cmd = new SqlCommand($"CREATE DATABASE {dbName}", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"USE {dbName};"   
                    + @"CREATE TABLE Filmler
(
    Id INT PRIMARY KEY IDENTITY,
    FilmAd NVARCHAR(200) NOT NULL,
    Puan   INT NULL,
    Foto VARBINARY(MAX) NULL
);
"
                    , con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand($"USE {dbName}", con);
                cmd.ExecuteNonQuery();
            }
        }

        private Image ConvertToImage(byte[] data)
        {
            if (data==null)
                return null;
            return (Image)new ImageConverter().ConvertFrom(data);
        }


        private void pboFoto_Click(object sender, EventArgs e)
        {
            Image img;
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(f.FileName);
                pboFoto.Image = img;
            }
        }

        private void btnYeniFilm_Click(object sender, EventArgs e)
        {
           int id= YeniFilmEkle();
            FilmleriListele();

            lstFilmler.SelectedValue = id;  // ben sana bir değer vericem id lerine eşleşeni seç


        }

        private int YeniFilmEkle()
        {
            var cmd = new SqlCommand("INSERT INTO Filmler(FilmAd) VALUES(N'Yeni Film'); SELECT SCOPE_IDENTITY();", con);
            return  Convert.ToInt32(cmd.ExecuteScalar());

        }

        private void lstFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstFilmler.SelectedIndex == -1)
                return;
            guncellemeAcik = false;
            Film film = (Film)lstFilmler.SelectedItem;

            txtFilmId.Text =film.Id.ToString();
            txtFilmAd.Text = film.FilmAd;

            #region Puanı Göster
            if (film.Puan == null)
            {
                rbPuanYok.Checked = true;
            }
            else
            {
                //Her taşın altına bakmak
                //foreach (Control control in gboPuan.Controls)  // gbo nun içinde controller var bunu tek tek alırız
                //        // aldığımız zaman türü control olarak geçiyor, bu yüzden içinde her şey olabilir
                //        // Ayırt etmemiz lazım , foreach le donenle controllerin radiobutton oldugna emn olmak lazm
                //{
                //    //robost kod yazdım. (sağlam)
                //    if (control is RadioButton && control.Tag.ToString()==film.Puan.ToString() && control.Tag!=null)         
                //        // burdan radiobuttonsa  bunu radiobuttona çevir diyoruz
                //    {
                //        ((RadioButton)control).Checked = true;
                //        break;
                //    }
                //}
                //Taşların yerini bilip index no ile erişmek
                RadioButton[] rbDizi = { rbPuanYok, rbPuan1, rbPuan2, rbPuan3, rbPuan4, rbPuan5 };
                rbDizi[film.Puan.Value].Checked = true;
            }
            #endregion

            pboFoto.Image = film.Foto;
            guncellemeAcik = true;
        }

        private void txtFilmAd_TextChanged(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (guncellemeAcik && lstFilmler.SelectedIndex >-1)
            {
                Film film = (Film)lstFilmler.SelectedItem;    // elimize alalım
                //textboxtaki değerlerle değiştirelim
                film.FilmAd = txtFilmAd.Text;
                //todo : puanı ve resmi güncelle
                var cmd = new SqlCommand("UPDATE Filmler SET FilmAd=@p1 WHERE Id=@p4", con);
                cmd.Parameters.AddWithValue("@p1", film.FilmAd);
                cmd.Parameters.AddWithValue("@p4", film.Id);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
