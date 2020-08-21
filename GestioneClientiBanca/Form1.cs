using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestioneClientiBanca.Code;

namespace GestioneClientiBanca
{
    public partial class Form1 : Form
    {

        public BindingList<Cliente> listaClienti = new BindingList<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            listaClienti.Add(new Cliente()
            {
                Nome = tbxNome.Text,
                Cognome = tbxCognome.Text,
                DataNascita = dtpDataNascita.Value,
                NumeroConto = int.Parse(tbxNumeroConto.Text),
                Valuta = cmbxValuta.Text
            });
            ClearTBX();
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            //se non ho ancora inserito nessun cliente, non ho nulla da mostrare
            if (listaClienti.Count == 0) return;
            var f = new Form2();
            f.Text = "Salva";
            f.dataGridView1.DataSource = listaClienti;
            f.ShowDialog();
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.Text = "Mostra CSV";
            BindingList<Cliente> list = new BindingList<Cliente>();
            var sfdResult = openFileDialog1.ShowDialog();
            if (sfdResult == DialogResult.OK)
            {
                GetDataFromCSV(openFileDialog1.FileName);
                f.dataGridView1.DataSource = list;
                f.btnOk.Visible = false;
                f.ShowDialog();
            }
           
        }

        //pulizia di tutte le textbox e altri oggetti vari
        public void ClearTBX()
        {
            tbxCognome.Clear();
            tbxNome.Clear();
            tbxNumeroConto.Clear();
            dtpDataNascita.Value = DateTime.Now;
            cmbxValuta.ResetText();
        }

        //metodo che serve per leggere i dati dal CSV e restituisce una lista tipizzata(cliente)
        private BindingList<Cliente> GetDataFromCSV(string filePath)
        {
            var list = new BindingList<Cliente>();
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (true)
                {
                    var line = streamReader.ReadLine();
                    if (line == null) break;
                    if (line == string.Empty) continue;

                    string[] splittedLine = line.Split(',');
                    list.Add(new Cliente
                    {
                        Nome = splittedLine[0],
                        Cognome = splittedLine[1],
                        DataNascita = DateTime.Parse(splittedLine[2]),
                        NumeroConto = int.Parse(splittedLine[3]),
                        Valuta = splittedLine[4]
                    });
                }
            }
            return list;
        }

        //per gestire il fatto che nel numero conto devono esserci solo numeri,
        //se l'utente scrive spazi o lettere devo annullare l'evento. Per farlo utilizzo
        //la property Handled dell'oggetto e. Impostandolo a true
        //la pressione del tasto viene soppressa e quindi non verrà scritto il carattere.
        private void tbxNumeroConto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se al momento della pressione del tasto la lunghezza è già 8, annulle l'evento
            if (!char.IsControl(e.KeyChar) && tbxNumeroConto.Text.Length == 8)
            {
                e.Handled = true;
            }
            //se sto premendo un tasto diverso da quelli controllo (cancella, alt, invio ecc ecc)
            //e se sto premendo un tasto diverso da un numero, annullo l'evento
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbxNumeroConto_KeyUp(object sender, KeyEventArgs e)
        {
            //Ad ogni pressione del tasto, se la mia lunghezza non va bene,
            //mostro l'errore e disabilito il pulsante aggiungi
            bool isValid = tbxNumeroConto.Text.Length == 8;
            btnAggiungi.Enabled = isValid;
            lbl_error.Visible = !isValid;

            
            

        }
    }
}
