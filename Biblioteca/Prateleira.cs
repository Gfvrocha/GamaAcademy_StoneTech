namespace Livraria
{
    public class Prateleira
    {
        private const int CAPACIDADE = 10; 
        public List<Publicacao> Publicacoes { get; set; }

        internal void AcrescentarItem(Publicacao publicacao)
        {
            if (Publicacoes.Count == 10) return;

            Publicacoes.Add(publicacao);
        }

        internal Publicacao BuscarItem(string titulo)
        {
            return Publicacoes.Where(publicacao => publicacao.Titulo == titulo).FirstOrDefault();
        }

        internal bool TemEspaco()
        {
            return Plublicacoes.Count < CAPACIDADE;
        }
    }
}