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
    public partial class NewIdeaPage : ContentPage
    {
        private IdeaDTO EntityDto = new IdeaDTO();
        public NewIdeaPage()
        {
            InitializeComponent();
        }

        public NewIdeaPage(IdeaDTO entityDto)
        {
            InitializeComponent();
            SetEntityDto(entityDto);
            SetEntries(entityDto);
        }

        private void SetEntityDto(IdeaDTO entityDto)
        {
            EntityDto = entityDto;
        }

        private void SetEntries(IdeaDTO entityDto)
        {
            DescriptionEntry.Text = entityDto.Description;
            CommentEntry.Text = entityDto.Comment;
        }

        private IdeaDTO UpdateEntityFromEntries(IdeaDTO entityDto)
        {
            entityDto.Description = DescriptionEntry.Text;
            entityDto.Comment = CommentEntry.Text;
            return entityDto;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(IdeasService.Build().CreateOrUpdate(UpdateEntityFromEntries(EntityDto)) > 0)
            {
                DisplayAlert("Sucesso!", "Ideia cadastrada", "Ok");
                Navigation.PushAsync(new IdeasPage());
            }
        }
    }
}