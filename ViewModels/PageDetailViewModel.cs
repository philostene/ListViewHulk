using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using ListViewHulk.Models;
using Toolkit.ErrorManagement;
using Toolkit.ViewServices;
using ListViewHulk.Views;

namespace ListViewHulk.ViewModels
{
    public class PageDetailViewModel : BaseViewModel
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

        private string test;
        public string Test
        {
            get
            { return test; }
            set
            {
                this.test = value;
            }
        }

        public PageDetailViewModel(IDialogService dialogService,
                                IErrorHandler errorHandler) : base(dialogService, errorHandler)
        {
            test = "titi";
        }

        protected override async Task StartAsync(CancellationToken ct)
        {

        }

        public void MainPageTransfertValue(Monkey monk)
        {
            _monkey = monk;
        }
    }
}
