using MinhasIdeias.DTOS;
using MinhasIdeias.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhasIdeias.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IdeasPage : ContentPage
    {
        public IdeasPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            IdeasListView.ItemsSource = new ObservableCollection<IdeaDTO>(IdeasService.Build().GetAll()); 
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewIdeaPage());
        }
    }
}