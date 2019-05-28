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
            //  _monkey = new Monkey();


            _monkey = monk;
            InitializeComponent();
        }

    }

}
