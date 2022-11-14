using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visori_scrittori
{
    public class Scrittore
    {
        private string _utente;
        private Visualizzatore _visore;

        public string Utente
        {
            set { _utente = value; }
            get { return _utente; }
        }        
        private Visualizzatore Visore
        {
            set { _visore = value; }
            get { return _visore; }
        }
        public Scrittore(string user,Visualizzatore vis)
        {
            _utente = user;
            _visore = vis;
        }
        public void aggiungiTesto(string testo)
        {
            _visore.visualizza();
        }
    }
}
