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
        private List<IdeaDTO> entityDtos = new List<IdeaDTO>();
        public IdeasPage()
        {
            InitializeComponent();            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetIdeas();
            RefreshList();
        }

        private async void GetIdeas()
        {
            entityDtos = await IdeasService.Build().GetAll();
        }

        private void RefreshList()
        {
            IdeasListView.ItemsSource = new ObservableCollection<IdeaDTO>(entityDtos);
        }

        private void Edit(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Image)sender).ClassId);
            IdeaDTO entityDto = entityDtos.Find(x => x.Id == id);
            Navigation.PushAsync(new NewIdeaPage(entityDto));
        }

        private async void Delete(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Image)sender).ClassId);
            IdeaDTO entityDto = entityDtos.Find(x => x.Id == id);
            string confirm = await DisplayActionSheet("Tem certeza que deseja excluir este item?", "Voltar", null, "Sim", "Não");
            if (confirm == "Sim")
            {
                if (IdeasService.Build().Delete(entityDto) > 0)
                {
                    await DisplayAlert("Sucesso", "Ideia " + entityDto.Description + " deletada", "Ok");
                    entityDtos.Remove(entityDto);
                    RefreshList();
                }
            }
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewIdeaPage());
        }
    }
}