using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_CSharp
{
    class Proizvod
    {
        private string Naziv;
        private decimal BrojProizvodaUPaketu;
        private decimal BrojPaketa; 
        private bool Hitno;
        private StatusProizvoda Status;

        public enum StatusProizvoda { Narucen, USkladistu, UProdaji }; //status proizvoda (definisati enumeraciju za taj atribut)

        public void DodajNaziv(string Naziv)
        {
            this.Naziv = Naziv;
        }

        public void SetBPUP(decimal BrojProizvodaUPaketu)
        {
            this.BrojProizvodaUPaketu = BrojProizvodaUPaketu;
        }

        public void SetBP(decimal BrojPaketa)
        {
            this.BrojPaketa = BrojPaketa;
        }

        public void SetStatus(StatusProizvoda Status)
        {
            this.Status = Status;
        }

        public string ReturnProizvod()
        {
            if (Hitno == true)
            {
                return (Naziv + " " + Status + " hitno kolicina:" + BrojProizvodaUPaketu);
            }
            return (Naziv + " " + Status + " kolicina:" + BrojProizvodaUPaketu);
        }

        public StatusProizvoda GetStatus()
        {
            return 0;
        }

        public void SetHitno()
        {
            this.Hitno = true;
        }
        
    }
}
