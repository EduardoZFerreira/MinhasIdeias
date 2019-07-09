using MinhasIdeias.DTOS;
using MinhasIdeias.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhasIdeias.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrainstormingPage : ContentPage
    {
        private IdeaDTO EntityDto = new IdeaDTO();
        public BrainstormingPage(IdeaDTO entityDto)
        {
            InitializeComponent();
            SetEntityDto(entityDto);
            BrainstormingEditor.Text += entityDto.Brainstorm;
        }
        private void SetEntityDto(IdeaDTO entityDto)
        {
            EntityDto = entityDto;
        }

        private IdeaDTO UpdateEntityFromEntries(IdeaDTO entityDto)
        {
            entityDto.Brainstorm = BrainstormingEditor.Text;
            return entityDto;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(IdeasService.Build().Update(UpdateEntityFromEntries(EntityDto)) > 0)
            {
                DisplayAlert("Sucesso!", "Brainstorming salvo", "Ok");
                Navigation.PopAsync();
            }
        }
    }
}