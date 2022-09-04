namespace Livraria
{
    public class ItensEmprestados : IItensEmprestados
    {
        public List<Publicacao> Publicacoes { get; set; }
        public void AdicionarItem(Publicacao publicacao)
        {
            Publicacoes.Add(publicacao);
        }
    }
}