using WinApp.Data;
using System.Collections.Generic;

namespace WinApp.Model 
{
    public class Previsao : Prediction
    {
        public int CidadeCodigo { get; set; }

        public bool Exist(int cidadeCodigo)
        {
            return new Dal().GetByDt(cidadeCodigo) != null;
        }

        public int Insert(Previsao obj)
        {
            Dal dal = new Dal();
            return dal.Insert(obj);
        }

        public int Insert(List<Previsao> obj)
        {
            Dal dal = new Dal();
            return dal.Insert(obj, out bool ErrorOccured);
        }

        public int Update(List<Previsao> obj)
        {
            Dal dal = new Dal();
            return dal.Insert(obj, out bool ErrorOccured);
        }

        public int Exclude(int cidadeCodigo)
        {
            Dal dal = new Dal();
            return dal.Exclude(cidadeCodigo);
        }
    }
}
