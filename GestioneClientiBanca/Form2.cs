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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            var list = dataGridView1.DataSource as BindingList<Cliente>;

            saveFileDialog1.FileName = Path.GetFileName(saveFileDialog1.FileName);
            var sfdResult = saveFileDialog1.ShowDialog();
            if (sfdResult == DialogResult.OK)
            {
                using (var strWriter = new StreamWriter(saveFileDialog1.FileName,true))
                {
                    foreach (var cliente in list)
                    {
                        strWriter.WriteLine(cliente.GetCSVFormat());
                    }
                }
            }
            Close();
        }
    }
}
