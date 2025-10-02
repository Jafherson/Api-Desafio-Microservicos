using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosProduto.Interfaces.Repositories;

namespace ApiDesafioMicroservicos.Infraestrutura
{
    public class ProdutoRepository : IProdutoRepository
    {   
        private readonly ConnectionContext _context;

        public ProdutoRepository()
        {
            _context = new ConnectionContext();
        }

        public void Add(Produto produto)
        {
           _context.Produtos.Add(produto);
           _context.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public Produto? GetById(long id)
        {
            return _context.Produtos.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Produto produto)
        {
            //_context.Entry(produto).Property(p => p.Quantidade).IsModified = true;
            _context.SaveChanges();
        }
    }
}
