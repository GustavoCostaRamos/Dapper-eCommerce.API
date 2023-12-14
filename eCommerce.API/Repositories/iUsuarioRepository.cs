using eCommerce.API.Models;

namespace eCommerce.API.Repositories
{
    public interface iUsuarioRepository
    {
        public List<Usuario> Get();
        public Usuario Get(int id);
        public void Insert(Usuario usuario);
        void Update(Usuario usuario); 
        public void Delete(int id);
        
    }
}
