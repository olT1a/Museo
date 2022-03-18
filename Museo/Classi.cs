using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo
{
    class Classi
    {
    }

    class Biglietto
    {
        string codice;
        public Biglietto(string codice)
        {
            this.codice = codice;
        }
        public string getBiglietto() { return codice; }
    }

    class Persona
    {
        protected string nome;
        protected string cognome;
        protected string codiceFiscale;
        Biglietto biglietto;

        string[] nomi = new string[] { "Mattia", "Andrea", "Simone", "Stefano", "Riccardo", "Filippo", "Loris", "Edoardo", "Manuel", "Omar", "Weikai", "Marco", "Giacomo", "Andrian", "Chengzhou", "Destiny", "Alessandro", "Michael", "Diego" };
        string[] cognomi = new string[] { "Ji", "Ranica", "Cattaneo", "Pezzotta", "Nasatti", "Graziano", "Rota", "Stroppa", "Riva", "Samii", "Salvi", "Previtali", "Elizarov", "Hu", "Omagu", "Tommasi", "Chef Locatelli", "Poddi", "Milesi", "Bernini" };

        private string nomeRandom()
        {
            Random r = new Random();
            return nomi[r.Next(0, nomi.Length)];
        }

        private string cognomeRandom()
        {
            Random r = new Random();
            return cognomi[r.Next(0, cognomi.Length)];
        }

        public Persona()
        {
            
            //this.codiceFiscale = codiceFiscale;
        }
        public void setPersona()
        {
            this.nome = nomeRandom();
            this.cognome = cognomeRandom();
        }
        public void saluta()
        {
            //l.Text = "Ciao sono " + nome + " " + cognome + ", vado in coda";
            MessageBox.Show("Ciao sono " + nome + " " + cognome + ", vado in coda");
        }
        public string getNome() { return nome; }
        public string getCognome() { return cognome; }
    }
}
