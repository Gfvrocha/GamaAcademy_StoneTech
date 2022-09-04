namespace Livraria
{
    public class Colecao
    {
       public List<Prateleira> Prateleiras { get; set; }

        internal void AcrescentarItem(Publicacao publicacao)
        {
            foreach (var prateleira in Prateleiras)
            {
                if(prateleira.TemEspaco())
                {
                    prateleira.AcrescentarItem(publicacao);
                    return;
                }
            }
        }

        internal Publicacao BuscarItem(string titulo)
        {
            var publicacao = new Publicacao();
            publicacao = Prateleiras.Select(prateleira => prateleira.BuscarItem(titulo)).FirstOrDefault();
            return publicacao;
        }
    }
}