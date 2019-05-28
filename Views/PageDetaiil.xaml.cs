using ListViewHulk.Models;
using Xamarin.Forms;
using System.Xml;

namespace ListViewHulk.Views
{
    public partial class PageDetail
    {

        private Monkey _monkey;

        public Monkey monkey
        {
            get
            {
                return _monkey;
            }
            set
            {
                this._monkey = value;
            }
        }

        public PageDetail(Monkey monk)
        {
            _monkey = monk;
            // ViewModel.monkey = _monkey;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.monkey = _monkey;

        }
    }

}
