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
        bool aperto = true;
        int i = 0;

        Queue<Persona> ingresso = new Queue<Persona>();

        List<Thread> prenotazioni = new List<Thread>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_apriMuseo_Click(object sender, EventArgs e)
        {   
            while (i < 30)
            {
                Persona p = new Persona();
                p.setPersona();
                prenotazioni.Add(new Thread(new ThreadStart(p.saluta)));
                //prenotazioni[i].Start();
                i++;
                ingresso.Enqueue(p);
                lbl_nPersone.Text = "Persone prenotate: " + i;
                //System.Threading.Thread.Sleep(750);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            list_coda.Items.Clear();
            foreach(Persona p in ingresso)
            {
                list_coda.Items.Add(p.getNome() + " " + p.getCognome());
            }
        }
    }
}
