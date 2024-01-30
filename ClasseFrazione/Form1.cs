using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClasseFrazione
{
    public partial class Form1 : Form
    {
        Frazione frazione = new Frazione();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Semplifica_Click(object sender, EventArgs e)
        {
            if (Inserimento())
            {
                frazione.Semplifica();
                Num.Text = frazione._numeratore.ToString();
                Den.Text = frazione._denominatore.ToString();
            }
        }
        public bool Inserimento()
        {
            bool giusto = float.TryParse(Num.Text, out _) == true && float.TryParse(Den.Text, out _) == true && Num.Text != string.Empty && Den.Text != string.Empty && Den.Text != "0";
            if(giusto == true)
            {
                
                frazione._numeratore = float.Parse(Num.Text);
                frazione._denominatore = float.Parse(Den.Text);
                
            }
            else
            {
                Num.Text = " ";
                Den.Text = " ";
                
            }

            return giusto;
        }

        private void Somma_Click(object sender, EventArgs e)
        {
            if(Inserimento())
                MessageBox.Show("La somma è: " + frazione.Somma());
        }

        private void Sottrazione_Click(object sender, EventArgs e)
        {
            if(Inserimento())
                MessageBox.Show("La differenza è: " + frazione.Differenza());
        }

        private void Moltiplicazione_Click(object sender, EventArgs e)
        {
            if (Inserimento())
                MessageBox.Show("Il prodotto è: " + frazione.Moltiplicazione());
        }

        private void Divisione_Click(object sender, EventArgs e)
        {
            if (Inserimento())
                MessageBox.Show("Il quoziente è: " + frazione.Divisione());
        }

        private void Den_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Elevamento_Click(object sender, EventArgs e)
        {
            if (Inserimento())
            {
                frazione.Elevazione();
                Num.Text = frazione._numeratore.ToString();
                Den.Text = frazione._denominatore.ToString();

            }
        }

        private void Num_TextChanged(object sender, EventArgs e)
        {
        }

        private void Decimale_Click(object sender, EventArgs e)
        {
            if(Inserimento())
            frazione.ToDecimale();
        }

        private void Frazion_Click(object sender, EventArgs e)
        {
            
            if (frazione.ToFrazione())
            {
                Num.Text = frazione._numeratore.ToString();
                Den.Text = frazione._denominatore.ToString();
            }
        }
    }
    class Frazione
    {
        public float _numeratore { get; set; }
        public float _denominatore { get; set; }
        public float _minore { get; set; }

        public Frazione() // COSTRUTTORE DI DEFAULT
        {
            _numeratore = 0.0f;
            _denominatore = 0.0f;
            _minore = 0.0f;
        }
        public Frazione(Frazione frazione) // COSTRUTTORE DI COPIA
        {
            _numeratore = frazione._numeratore;
            _denominatore = frazione._denominatore;
            _minore = frazione._minore;
        }


        public void TrovaMinore()
        {
            float b = _denominatore;
            float a = _numeratore;
            if (_numeratore < 0)
            {
                a *= -1;
            }
            if (_denominatore < 0) 
            {
                b *= -1;
            }
            
            
            if (a > b)
            {
                _minore = _denominatore;
            }
            else
            {
                _minore = _numeratore;
            }
        }
        public void Semplifica()
        {
            if (_numeratore < 0 && _denominatore < 0)
            {
                _numeratore *= -1;
                _denominatore *= -1;
            }
            TrovaMinore();
            
            for (int i = 2; i <= _minore; i++)
            {
                if (_numeratore % i == 0 && _denominatore % i == 0)
                {
                    _numeratore = _numeratore / i;
                    _denominatore = _denominatore / i;
                    i = 1;
                }
            }
        }

        public float Somma()
        {
            return _numeratore + _denominatore;
        }

        public float Differenza()
        {
            return _numeratore - _denominatore;
        }
        public float Moltiplicazione()
        {
            return _numeratore * _denominatore;
        }
        public float Divisione()
        {
            return _numeratore / _denominatore;
        }

        public void Elevazione()
        {
            string message, title, defaultValue;
            message = "Inserisci l'esponente ";
            title = "Input esponente";
            defaultValue = "";
            string el = Interaction.InputBox(message, title, defaultValue);

            _numeratore = (float)Math.Pow(Convert.ToDouble(_numeratore), double.Parse(el));
            _denominatore = (float)Math.Pow(Convert.ToDouble(_denominatore), double.Parse(el));
        }
        
        public void ToDecimale()
        {
            MessageBox.Show(Divisione().ToString());
        }

        public bool ToFrazione()
        {
            string message, title, defaultValue;
            message = "Inserisci il numero decimale ";
            title = "Input numero";
            defaultValue = "";
            string num = Interaction.InputBox(message, title, defaultValue);
            if(float.TryParse(num, out _) == true && num != string.Empty)
            {
                _denominatore = (float)Math.Pow(10, Convert.ToDouble(num.Split(',')[1].Length));
                _numeratore = float.Parse(num) * _denominatore;
                return true;
            }

            return false;
        }
    }
}










