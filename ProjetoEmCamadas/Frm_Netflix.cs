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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
   
