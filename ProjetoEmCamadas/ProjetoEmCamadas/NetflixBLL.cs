using System;
using System.Data;

namespace ProjetoEmCamadas.Code.BLL
{
    class NetflixBLL
    {
        private object conexao;
        private object tabela;

        public NetflixBLL()
        {
        }

        public void Inserir(NetflixDTO meddto)
        {
            string inserir = $"insert into {tabela} values(null,'{meddto.Filmes}','{meddto.Produtor}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by login;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(NetflixDTO meddto)
        {
            string alterar = $"update {tabela} set medicamento = '{meddto.Netflix}', composicao = '{meddto.Produtor}' where id = '{meddto.Login}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(NetflixDTO meddto)
        {
            string excluir = $"delete from {tabela} where id = '{meddto.Login}';";
            conexao.ExecutarComando(excluir);
        }
    }
}