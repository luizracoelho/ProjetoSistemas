using Projeto.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Ui.Desktop
{
    public partial class Equipes : Form
    {
        public Equipes()
        {
            InitializeComponent();
        }

        private void Equipes_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = EquipeApp.Listar();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
