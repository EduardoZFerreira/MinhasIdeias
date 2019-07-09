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
        public IdeaPage(IdeaDTO entityDto)
        {
            InitializeComponent();
            Description.Text = entityDto.Description;
            Comment.Text = entityDto.Comment;
        }
    }
}