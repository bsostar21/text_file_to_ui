using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PI_Zadaća1
{


    public partial class Form1 : Form
    {
        private UserFileReader fileReader;
        private UserParser userParser;
        private UserDisplayer userDisplayer;


        public Form1()
        {
            InitializeComponent();


            fileReader = new UserFileReader("");
            userParser = new UserParser();
            userDisplayer = new UserDisplayer();

            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tekstualne datoteke (*.txt)|*.txt|Sve datoteke (*.*)|*.*";
            openFileDialog.Title = "Odaberi datoteku";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string putDat = openFileDialog.FileName;
                LoadFileContent(putDat);
            }
        }

        private void LoadFileContent(string putDat)
        {

            string fileContent = File.ReadAllText(putDat);


            string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


            textBox7.Text = lines[0].Substring(lines[0].IndexOf("=") + 1).Trim();
            textBox2.Text = lines[1].Substring(lines[1].IndexOf("=") + 1).Trim();
            textBox3.Text = lines[2].Substring(lines[2].IndexOf("=") + 1).Trim();
            textBox4.Text = lines[3].Substring(lines[3].IndexOf("=") + 1).Trim();
            textBox5.Text = lines[4].Substring(lines[4].IndexOf("=") + 1).Trim();
            textBox6.Text = lines[5].Substring(lines[5].IndexOf("=") + 1).Trim();
            textBox8.Text = lines[6].Substring(lines[6].IndexOf("=") + 1).Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina { get; set; }
        public string Grad { get; set; }
        public string Fakultet { get; set; }
        public string Uloga { get; set; }
        public string Ostalo { get; set; }
        public Korisnik(string ime, string prezime, int godina, string grad, string fakultet, string uloga, string ostalo)
        {
            Ime = ime;
            Prezime = prezime;
            Godina = godina;
            Grad = grad;
            Fakultet = fakultet;
            Uloga = uloga;
            Ostalo = ostalo;
        }
    }
    public class UserFileReader
    {
        
        private string putDat;
        public UserFileReader(string putDat)
        {
            this.putDat = putDat;
        }
        public string ReadFile()
        {
            try
            {
                string sadrzaj = File.ReadAllText(putDat);
                return sadrzaj;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Datoteka nije pronađena.");
                return string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Došlo je do pogreške prilikom čitanja datoteke: " + ex.Message);
                return string.Empty;
            }
        }
        
    }
    public class UserParser
    {
        public Korisnik ParseData(string datKorisnik)
        {
            string[] fields = datKorisnik.Split(';');
            string ime = fields[0];
            string prezime = fields[1];
            int godinaRodjenja;
            int.TryParse(fields[2], out godinaRodjenja);
            string gradRodjenja = fields[3];
            string fakultet = fields[4];
            string uloga = fields[5];
            string ovisi = fields[6];
            Korisnik user = new Korisnik(ime, prezime, godinaRodjenja, gradRodjenja, fakultet, uloga, ovisi);
            return user;
        }
    }
    public class UserDisplayer
    {
        public void DisplayUser(Korisnik user)
        {
            Console.WriteLine($"{user.Ime}");
            Console.WriteLine($"{user.Prezime}");
            Console.WriteLine($"{user.Godina}");
            Console.WriteLine($"{user.Grad}");
            Console.WriteLine($"{user.Fakultet}");
            Console.WriteLine($"{user.Uloga}");
            Console.WriteLine($"{user.Ostalo}");
        }
    }
}
