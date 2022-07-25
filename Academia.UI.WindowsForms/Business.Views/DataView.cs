using Business.Entities;

namespace Business.Views
{
    public class DataView : IIdentificable, IDataView
    {
        public int ID { get; set; }

        public string Descripcion { get; set; }
    }

    public interface IDataView
    {
        int ID { get; set; }

        string Descripcion { get; set; }
    }
}
