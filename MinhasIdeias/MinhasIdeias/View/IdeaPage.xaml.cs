using MinhasIdeias.DTOS;
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
    public partial class IdeaPage : ContentPage
    {
        private IdeaDTO EntityDto = new IdeaDTO();
        public IdeaPage(IdeaDTO entityDto)
        {
            InitializeComponent();            
            SetEntityDto(entityDto);
            SetInfo();
        }
        private void SetInfo()
        {
            Description.Text = EntityDto.Description;
            Comment.Text = EntityDto.Comment;
            Brainstorming.Text = EntityDto.Brainstorm == string.Empty || EntityDto.Brainstorm == null ? "Ainda não há brainstorming feito nesta ideia!" : EntityDto.Brainstorm;
        }
        private void SetEntityDto(IdeaDTO entityDto)
        {
            EntityDto = entityDto;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BrainstormingPage(EntityDto));
        }
    }
}