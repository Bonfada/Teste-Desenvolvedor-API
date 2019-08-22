using WinApp.Data;

namespace WinApp.Model
{
    public class Cidade : City
    {
        public bool Exist(int id)
        {
            return new Dal().GetById(id) != null;
        }

        public int Insert(City obj)
        {
            Dal dal = new Dal();
            return dal.Insert(obj);
        }

        public int Update(City obj)
        {
            Dal dal = new Dal();
            return dal.Update(obj);
        }
    }
}
