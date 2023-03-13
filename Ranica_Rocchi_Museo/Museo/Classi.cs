using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Museo
{
    class Classi
    {
    }

    class Persona
    {
        protected string nome;
        protected string cognome;

        Ingresso ing1, ing2, ing3;
        Stanza stanza1, stanza2;

        PictureBox immagine;

        ListBox list_eventi;

        string picturebox;

        Random r = new Random();

        Queue<Persona> coda;
        List<Persona> ingresso1 = new List<Persona>();
        List<Persona> ingresso2 = new List<Persona>();
        List<Persona> ingresso3 = new List<Persona>();

        public List<Persona> museo = new List<Persona>();


        protected string[] nomi = new string[] { "Mattia", "Andrea", "Simone", "Stefano", "Riccardo", "Filippo", "Loris", "Edoardo", "Manuel", "Omar", "Weikai", "Marco", "Giacomo", "Andrian", "Chengzhou", "Destiny", "Alessandro", "Michael", "Mario", "Massimo", "Paola", "Federico", "Luigi", "Francesca", "Francesco", "Alessandra", "Giulia",  "Paolo", "Elisa", "Michele" };
        protected string[] cognomi = new string[] { "Rocchi", "Ji", "Ranica", "Cattaneo", "Pezzotta", "Nasatti", "Graziano", "Rota", "Stroppa", "Riva", "Samii", "Salvi", "Previtali", "Elizarov", "Hu", "Omagu", "Tommasi", "Locatelli", "Poddi", "Milesi", "Rossi", "Ferrari", "Bianchi", "Esposito", "Chiesa", "Fontana", "Conti", "Barbieri", "Longo", "Colombi", "Fontana" };


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
        public Persona(ref Queue<Persona> coda, ref List<Persona> t1, ref List<Persona> t2, ref List<Persona> t3, ref List<Persona> museo, ref Semaphore semingresso1, ref Semaphore semingresso2, ref Semaphore semingresso3, ref Stanza stanza1, ref Stanza stanza2, ref ListBox listeventi, ref Ingresso i1, ref Ingresso i2, ref Ingresso i3)
        {
            this.coda = coda;
            this.ingresso1 = t1;
            this.ingresso2 = t2;
            this.ingresso3 = t3;
            this.picturebox = "pic" + nome + cognome;
            this.museo = museo;
            this.stanza1 = stanza1;
            this.stanza2 = stanza2;
            this.list_eventi = listeventi;
            this.ing1 = i1;
            this.ing2 = i2;
            this.ing3 = i3;
        }
        public void setPersona()
        {
            this.nome = nomeRandom();
            this.cognome = cognomeRandom();
        }
        public void inizio()
        {
            coda.Enqueue(this);
            list_eventi.Items.Add(this.nome + " " + this.cognome + ": sono in coda");
            System.Threading.Thread.Sleep(r.Next(100, 10000));
            int pos = r.Next(1, 4);
            list_eventi.Text += this.nome + " " + this.cognome + ": vado all'ingresso" + pos;
            switch (pos)
            {
                case 1:
                    ingresso1.Add(this);
                    System.Threading.Thread.Sleep(r.Next(1, 10000));
                    ing1.entra(pos, this);
                    ingresso1.RemoveAt(ingresso1.IndexOf(this));
                    break;
                case 2:
                    ingresso2.Add(this);
                    System.Threading.Thread.Sleep(r.Next(1, 10000));
                    ing2.entra(pos, this);
                    ingresso2.RemoveAt(ingresso2.IndexOf(this));
                    break;
                case 3:
                    ingresso3.Add(this);
                    System.Threading.Thread.Sleep(r.Next(1, 10000));
                    ing3.entra(pos, this);
                    ingresso3.RemoveAt(ingresso3.IndexOf(this));
                    break;
            }
            System.Threading.Thread.Sleep(r.Next(1000, 10000));
            list_eventi.Items.Add(this.nome + " " + this.cognome + ": sono entrato dall'ingresso " + pos);
            museo.RemoveAt(museo.IndexOf(this));
            System.Threading.Thread.Sleep(r.Next(1000, 10000));

            int i = 0;
            while (i < r.Next(1, 5))
            {
                int nuovaStanza = r.Next(1, 3);
                if (nuovaStanza == 1)
                {
                    list_eventi.Items.Add(nome + " " + cognome + ": voglio entrare nella stanza 1");
                    stanza1.entra(this);
                    list_eventi.Items.Add(nome + " " + cognome + ": sono uscito dalla stanza 1");
                }
                else
                {
                    list_eventi.Items.Add(nome + " " + cognome + ": voglio entrare nella stanza 2");
                    stanza2.entra(this);
                    list_eventi.Items.Add(nome + " " + cognome + ": sono uscito dalla stanza 2");
                }
                i++;
            }
            list_eventi.Items.Add(nome + " " + cognome + ": esco dal museo");
            immagine.Location = new System.Drawing.Point(1016, 553);
            System.Threading.Thread.Sleep(1000);
            immagine.Visible = false;
            list_eventi.Items.Add(nome + " " + cognome + ": sono uscito dal museo");
        }
        public string getNome() { return nome; }
        public string getCognome() { return cognome; }
        //public int getingresso() { return ingresso; }
        public void setImmagine(PictureBox p) { this.immagine = p; }
        public PictureBox getImmagine() { return immagine; }
    }
    class Ingresso
    {
        Semaphore semingresso1 = new Semaphore(1, 1);
        Semaphore semingresso2 = new Semaphore(1, 1);
        Semaphore semingresso3 = new Semaphore(1, 1);
        public void entra(int i, Persona p)
        {
            switch (i)
            {
                case 1:
                    semingresso1.WaitOne();
                    p.museo.Add(p);
                    semingresso1.Release();
                    break;
                case 2:
                    semingresso2.WaitOne();
                    p.museo.Add(p);
                    semingresso2.Release();
                    break;
                case 3:
                    semingresso3.WaitOne();
                    p.museo.Add(p);
                    semingresso3.Release();
                    break;
            }
        }
    }

    class Quadro
    {
        string titolo, autore, descrizione;
        int data;
        public Quadro(string titolo, string autore, string descrizione, int data)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.descrizione = descrizione;
            this.data = data;
        }
        public string getQuadro() { return "Titolo: " + titolo + "\nAutore: " + autore + "\nDescrizione: " + descrizione + "\nData: " + data; }
    }

    class Stanza
    {
        Quadro q;
        Semaphore sem;
        Persona spettatore;
        Random r = new Random();

        public Stanza(Quadro q, ref Semaphore sem)
        {
            this.q = q;
            this.sem = sem;
            spettatore = null;
        }

        public void entra(Persona p)
        {
            sem.WaitOne();
            spettatore = p;
            System.Threading.Thread.Sleep(r.Next(1000, 10000));
            spettatore = null;
            sem.Release();
        }

        public Persona getPersona()
        {
            return spettatore;
        }
    }


} 