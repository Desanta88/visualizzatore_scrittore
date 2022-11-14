using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visori_scrittori
{
    public class Visualizzatore
    {
        private RichTextBox RT;
        private bool _grassetto;
        private bool _corsivo;
        private bool _sottolineato;
        private Color _colore;
        private Font _font;

        public Font Font
        {
            set { _font = value; }
            get { return _font; }
        }
        public Visualizzatore(RichTextBox TB)
        {
            RT = TB;   
        }
        public Visualizzatore()
        {
          
        }
        public bool Grassetto
        {
            set { _grassetto = value; }
            get { return _grassetto; }
        }
        public bool Corsivo
        {
            set { _corsivo = value; }
            get { return _corsivo; }
        }
        public bool Sottolineato
        {
            set { _sottolineato = value; }
            get { return _sottolineato; }
        }
        public Color Colore
        {
            set { _colore = value; }
            get { return _colore; } 
        }
        public void visualizza()
        {
            FontStyle f;
            _font = RT.SelectionFont;
            f = _font.Style;
            if (_grassetto == true)
            {
                f ^= FontStyle.Bold;
            }
            if (_sottolineato == true)
            {
                f ^= FontStyle.Underline;
            }
            if (_corsivo == true)
            {
                f ^= FontStyle.Italic;
            }
            RT.ForeColor = _colore;
        }

    }
}
