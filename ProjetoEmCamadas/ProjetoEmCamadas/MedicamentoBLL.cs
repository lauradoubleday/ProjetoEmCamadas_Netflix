using System;

namespace ProjetoEmCamadas.Code.BLL
{
    class MedicamentoBLL
    {
        private object conexao;
        private object tabela;

        public MedicamentoBLL()
        {
        }

        public void Inserir(MedicamentoDTO meddto)
        {
            string inserir = $"insert into {tabela} values(null,'{meddto.Medicamento}','{meddto.Composicao}')";
            conexao.ExecutarComando(inserir);
        }
    }
}