using System;

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
    }
}