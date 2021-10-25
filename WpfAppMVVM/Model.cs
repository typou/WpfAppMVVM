using System.Collections.ObjectModel;

namespace WpfAppMVVM
{
    class Model
    {
        public class Company
        {
            public string Category { get; set; }
            public ObservableCollection<ElementN> ElementsEx { get; set; }
            public Company()
            {
                ElementsEx = new ObservableCollection<ElementN>();
            }
        }
        public class ElementN
        {
            public string Title { get; set; }
        }
    }
}
