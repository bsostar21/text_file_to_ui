﻿using System;
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


        public Form1()
        {
            InitializeComponent();
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
        private int brojac = 0;
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
                brojOtvaranja();
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

        private void brojOtvaranja()
        {
            brojac++;
            Console.WriteLine($"Broj pristupa datoteci: {brojac}");
        }
    }

}

