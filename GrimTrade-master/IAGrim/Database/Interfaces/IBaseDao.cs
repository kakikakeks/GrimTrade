using System.Collections.Generic;

namespace IAGrim.Database.Interfaces
{
    public interface IBaseDao<T> {

        long GetNumItems();

        void Save(T obj);
        void Save(IEnumerable<T> objs);

        void Update(T obj);

        IList<T> ListAll();

        void SaveOrUpdate(T obj);
        void SaveOrUpdate(IEnumerable<T> objs);

        void Remove(IEnumerable<T> objs);

        void Remove(T obj);

        T GetById(long id);
    }
}
