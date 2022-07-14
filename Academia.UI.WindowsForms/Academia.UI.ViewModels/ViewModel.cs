namespace Academia.UI.ViewModels
{
    public interface IViewModel
    {
        int ID { get; set; } 
    }

    public class ViewModel : IViewModel
    {
        public ViewModel()
        {

        }

        public int ID { get; set; }

        public string Descripcion { get; set; }
    }
}
