using la_cantina_backend.Models;

namespace la_cantina_backend.DAO
{
    public abstract class DAO
    {

        private Database database { get; set; }

        public abstract void Add();

        public abstract void GetAll();

        public abstract void Get(int id);

        public abstract void Modify(int id);

        public abstract void Delete(int id);
    }
}
