using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    /*
     * Bibliotca tem que conter uma prateleira
     * Prateleira tem que conter livros e revistas
     * Livros e revistas tem páginas
     * Pagínas tem texto
     * 
     */
    internal class Biblioteca
    {
        private IItensEmprestados _listaDeItens;

        public Colecao Prateleiras { get; set; }
        public Biblioteca (IItensEmprestados itensEmprestados)
        {
            _listaDeItens = itensEmprestados;
        }
        
        public void Adicionar(Publicacao publicacao)
        {
            Prateleiras.AcrescentarItem(publicacao);
        }

        public Publicacao PegarPublicacao(string titulo)
        {
            Publicacao publicacao = Prateleiras.BuscarItem(titulo);

            _listaDeItens.AdicionarItem(publicacao);

            return publicacao;
        }
    }
}
