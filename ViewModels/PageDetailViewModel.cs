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
        private Monkey _monkey = new Monkey();

        public Monkey monkey
        {
            get
            {
                return _monkey;
            }
            set => Set(ref _monkey, value);
            //{
            //    this._monkey = value;
            //    RaisePropertyChanged("monkey");
            //}
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

    }
}
