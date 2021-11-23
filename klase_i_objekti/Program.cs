using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            osoba.setime("Pero");
            osoba.setgodinaRođenja(1997);
            osoba.setprezime("Perić");
            osoba.setvisina(182);
            osoba.settezina(85);
            osoba.SetSpol('M');

            Console.WriteLine("Ime i prezime: " + osoba.getime() + " " +  osoba.getprezime());
         
            Console.WriteLine("Godina rođenja: "+ osoba.getgodinaRođenja());
            
            Console.WriteLine("Visina: "+ osoba.getvisina() + " cm");
            
            Console.WriteLine("Težina: " + osoba.gettezina() + " kg");

            Console.WriteLine("Spol: " + osoba.GetSpol());


            Osoba osoba1 = new Osoba("Ana", "Anić", 2001, 164, 62, 'Ž');

            Console.WriteLine(osoba1.ToString());

            Console.ReadKey();
        }
    }
    class Osoba {

        String ime, prezime;
        int godinaRođenja, visina, tezina;
        char spol;


        public override string ToString()
        {
            string ispis = "Ime i prezime: " + this.getime() + " " + this.getprezime() + "\n"
                + "Godina rođenja: " + this.getgodinaRođenja() + "\n"
                + "Visina: " + this.getvisina() + " cm" + "\n"
            + "Težina: " + this.gettezina() + " kg" + "\n"
            + "Spol: " + this.GetSpol() + "\n";
            return ispis;
        }

        public Osoba()
        {

        }
       
        public Osoba(String ime, String prezime, int godinaRođenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinaRođenja = godinaRođenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;

        }



        public char GetSpol()
        {
            return spol;
        }

        public void SetSpol(char value)
        {
            spol = value;
        }

        public void setime (String ime)
        {
            this.ime = ime;
        }
        public void setprezime(String prezime)
        {
            this.prezime = prezime;
        }
        public void setvisina(int visina)
        {
            this.visina = visina;
        }
        public void settezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void setgodinaRođenja (int godinaRođenja)
        {
            this.godinaRođenja = godinaRođenja;
        }

        public String getime()
        {
            return this.ime;
        }
        public String getprezime()
        {
            return this.prezime;
        }
        public int getvisina()
        {
            return this.visina;
        }
        public int gettezina()
        {
            return this.tezina;
        }
        public int getgodinaRođenja()
        {
            return this.godinaRođenja;
        }

    
    }
}
