using Xamarin.Forms;
using System;
using ListViewHulk.Models;
using ListViewHulk.ViewModels;

namespace ListViewHulk.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Monkey selectedItem = e.SelectedItem as Monkey;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Monkey tappedItem = e.Item as Monkey;
            OnNextPageButtonClicked(sender, e);

        }
        private async void OnNextPageButtonClicked(Object sender, EventArgs e)
        {
            ItemTappedEventArgs itemTappedEventArgslistView = e as ItemTappedEventArgs;

            Monkey monkey = new Monkey();
            monkey = itemTappedEventArgslistView.Item as Monkey;

            //var pageDetail = new PageDetail();
            //pageDetail.BindingContext = monkey;



            await Navigation.PushAsync(new PageDetail(monkey));

        }
    }

}
