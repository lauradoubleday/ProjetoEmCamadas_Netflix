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
    public partial class Frm_Medicamentos : Form
    {

        MedicamentoBLL medbll = new MedicamentoBLL();
        MedicamentoDTO meddto = new MedicamentoDTO();

        public Frm_Medicamentos()

        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            meddto.Medicamento = txtMedicamento.Text;
            meddto.Composicao = txtComposicao.Text;
            medbll.Inserir(meddto);

            MessageBox.Show("Cadastrado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtid.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
   
