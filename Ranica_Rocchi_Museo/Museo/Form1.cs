using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Museo
{
    public partial class Form1 : Form
    {
        int i = 0;
        Random r = new Random();

        Queue<Persona> ingresso = new Queue<Persona>();
        List<Thread> threads = new List<Thread>(); //Lista di tutti i thread che si presentano

        List<Persona> ingresso1 = new List<Persona>();
        List<Persona> ingresso2 = new List<Persona>();
        List<Persona> ingresso3 = new List<Persona>();

        List<Persona> museo = new List<Persona>();

        Semaphore semingresso1 = new Semaphore(1, 1);
        Semaphore semingresso2 = new Semaphore(1, 1);
        Semaphore semingresso3 = new Semaphore(1, 1);

        static Quadro Gioconda = new Quadro("Gioconda", "Leondardo da Vinci", "La Gioconda, nota anche come Monna Lisa, è un dipinto a olio su tavola di legno di pioppo realizzato da Leonardo da Vinci, conservato nel Museo del Louvre di Parigi.", 1503);
        static Quadro Napoleone = new Quadro("Bonaparte valica il Gran San Bernardo", "Jacques-Louis David", "Bonaparte valica il Gran San Bernardo è un ritratto equestre del primo console Napoleone Bonaparte dipinto da Jacques-Louis David", 1800);

        static Semaphore semStanza1 = new Semaphore(1, 1);
        static Semaphore semStanza2 = new Semaphore(1, 1);

        Stanza stanza1 = new Stanza(Gioconda, ref semStanza1);
        Stanza stanza2 = new Stanza(Napoleone, ref semStanza2);

        Ingresso ing1 = new Ingresso();
        Ingresso ing2 = new Ingresso();
        Ingresso ing3 = new Ingresso();
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void carica()
        {
            while (i < r.Next(1, 10))
            {
                Persona p = new Persona(ref ingresso, ref ingresso1, ref ingresso2, ref ingresso3, ref museo, ref semingresso1, ref semingresso2, ref semingresso3, ref stanza1, ref stanza2, ref list_eventi, ref ing1, ref ing2, ref ing3);
                p.setPersona();
                threads.Add(new Thread(p.inizio));
                threads[i].Start();
                i++;
                lbl_nPersone.Text = "Persone prenotate: " + i;
                list_coda.Items.Add(p.getNome() + " " + p.getCognome());
                var picture = new PictureBox
                {
                    Name = "pic_" + p.getNome() + p.getCognome(),
                    Size = new Size(15, 20),
                    Location = new Point(311, 292 + 25 * i),
                    Image = Image.FromFile(@"..\..\..\img\red.bmp"),
                };

                p.setImmagine(picture);

                this.Controls.Add(picture);
                //Crea una picturebox per ogni persona ingresso
            }
            threads.Clear();
        }

        private void aggiorna()
        {
            list_ingresso1.Items.Clear();
            list_ingresso2.Items.Clear();
            list_ingresso3.Items.Clear();
            list_museo.Items.Clear();
            int i = 0;

            foreach (Persona p in ingresso1)
            {
                list_ingresso1.Items.Add(p.getNome() + " " + p.getCognome());
                setImmagine(p, 1, ref i);
            }
            i = 0;
            foreach (Persona p in ingresso2)
            {
                list_ingresso2.Items.Add(p.getNome() + " " + p.getCognome());
                setImmagine(p, 2, ref i);
            }
            i = 0;
            foreach (Persona p in ingresso3)
            {
                list_ingresso3.Items.Add(p.getNome() + " " + p.getCognome());
                setImmagine(p, 3, ref i);
            }
            i = 0;
            foreach (Persona p in museo)
            {
                list_museo.Items.Add(p.getNome() + " " + p.getCognome());
                setImmagine(p, 0, ref i);
            }
            if (stanza1.getPersona() != null)
            {
                lbl_stanza1.Text = "Spettatore: " + stanza1.getPersona().getNome() + " " + stanza1.getPersona().getCognome();
            }
            else
            {
                lbl_stanza1.Text = "Spettatore: nessuno";
            }
            if (stanza2.getPersona() != null)
            {
                lbl_stanza2.Text = "Spettatore: " + stanza2.getPersona().getNome() + " " + stanza2.getPersona().getCognome();
            }
            else
            {
                lbl_stanza2.Text = "Spettatore: nessuno";
            }
        }

        private void setImmagine(Persona p, int ingresso, ref int i)
        {
            int y = 0, x = 0;
            Color nuovoColore = Color.Black;
            PictureBox img = p.getImmagine();

            switch (ingresso)
            {
                case 1:
                    x = 407;
                    y = 115;
                    nuovoColore = Color.Blue;
                    img.Location = new Point(x - i * 18, y);
                    break;
                case 2:
                    x = 407;
                    y = 310;
                    nuovoColore = Color.Green;
                    img.Location = new Point(x - i * 18, y);
                    break;
                case 3:
                    x = 407;
                    y = 514;
                    nuovoColore = Color.Orange;
                    img.Location = new Point(x - i * 18, y);
                    break;
                case 0:
                    x = 993;
                    //1603; 229 location museo
                    y = 300;
                    img.Location = new Point(x, y - i * 28);
                    nuovoColore = Color.LightBlue;
                    break;
            }

            img.Image = null;
            img.BackColor = nuovoColore;
            i++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_nuovaPersona_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carica();
        }
        private void timerTornelli_Tick(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void timerMuseo_Tick(object sender, EventArgs e)
        {
            
        }

        private void timerMuseo_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
