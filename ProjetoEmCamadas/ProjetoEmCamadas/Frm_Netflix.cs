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

        NetflixBLL medbll = new NetflixBLL();
        NetflixDTO meddto = new NetflixDTO();

        public Frm_Netflix()

        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            meddto.Filmes = txtFilmes.Text;
            meddto.Produtor = txtProdutor.Text;
            medbll.Inserir(meddto);

            MessageBox.Show("Cadastrado com sucesso!","Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtLogin.Clear();
            txtFilmes.Clear();
            txtProdutor.Clear();

        }


        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            meddto.Login = int.Parse(txtLogin.Text);

            medbll.Excluir(meddto);

            MessageBox.Show("Excluído com sucesso!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtLogin.Clear();
            txtFilmes.Clear();
            txtProdutor.Clear();
        }

        private void dgvNetflix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLogin.Text = dgvNetflix.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFilmes.Text = dgvNetflix.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtProdutor.Text = dgvNetflix.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            meddto.Login = int.Parse(txtLogin.Text);
            meddto.Filmes = txtFilmes.Text;
            meddto.Produtor = txtProdutor.Text;

            medbll.Editar(meddto);

            MessageBox.Show("Alterado com sucesso!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtLogin.Clear();
            txtFilmes.Clear();
            txtProdutor.Clear();
        }
    }
}
   
