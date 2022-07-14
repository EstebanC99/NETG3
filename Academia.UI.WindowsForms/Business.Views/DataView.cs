using Business.Entities;

namespace Business.Views
{
    public class DataView : IIdentificable
    {
        public int ID { get; set; }

        public string Descripcion { get; set; }
    }
}
