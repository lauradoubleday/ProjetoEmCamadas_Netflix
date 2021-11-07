using ProjetoEmCamadas.Code.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmCamadas
{
    public partial class Frm_Netflix : Form
    {

        MedicamentoBLL medbll = new MedicamentoBLL();
        NetflixDTO meddto = new NetflixDTO();

        public Frm_Netflix()

        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            meddto.Medicamento = txtFilmes.Text;
            meddto.Composicao = txtSeries.Text;
            medbll.Inserir(meddto);

            MessageBox.Show("Cadastrado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtLogin.Clear();
            txtFilmes.Clear();
            txtSeries.Clear();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
   
