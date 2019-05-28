using GalaSoft.MvvmLight.Ioc;
using ListViewHulk.Services;
using ListViewHulk.ViewModels;
using ListViewHulk.ViewServices;
using Toolkit.ErrorManagement;
using Toolkit.ViewServices;

namespace ListViewHulk.IOC
{
    public abstract class BootstrapBase
    {
        public abstract void Start();

        protected virtual void Setup(ISimpleIoc simpleIoc)
        {
            simpleIoc.Register<IDialogService, DialogService>();
            simpleIoc.Register<IErrorHandler, ErrorHandler>();

            simpleIoc.Register<MainViewModel>();
            simpleIoc.Register<PageDetailViewModel>();
        }
    }
}
