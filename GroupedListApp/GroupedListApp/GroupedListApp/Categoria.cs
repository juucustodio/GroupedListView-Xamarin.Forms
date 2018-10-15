using System.Collections.ObjectModel;

namespace GroupedListApp
{
    public class Categoria : ObservableCollection<Transporte>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}
