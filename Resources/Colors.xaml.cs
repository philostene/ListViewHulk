using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewHulk.Resources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Colors : ResourceDictionary
    {
        public Colors()
        {
            InitializeComponent();
        }

        public static Color ListViewHulkYellow => (Color)Application.Current.Resources[nameof(ListViewHulkYellow)];
    }
}
