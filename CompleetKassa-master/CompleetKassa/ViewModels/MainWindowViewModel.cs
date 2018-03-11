using CompleetKassa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Interactivity;

namespace CompleetKassa.ViewModels
{
    public class MainWindowViewModel
    {
        private List<Category> categories = new List<Category>
        {
            new Category
            {
                Color = Colors.AliceBlue,
                Name = "Socks"
            },
            new Category
            {
                Color = Colors.MediumVioletRed,
                Name = "Milk"
            },
            new Category
            {
                Color = Colors.MediumSlateBlue,
                Name = "Planes"
            },
              new Category
            {
                Color = Colors.AliceBlue,
                Name = "Pants"
            },
            new Category
            {
                Color = Colors.MediumVioletRed,
                Name = "Shoes"
            },
            new Category
            {
                Color = Colors.MediumSlateBlue,
                Name = "Graphics"
            },
              new Category
            {
                Color = Colors.AliceBlue,
                Name = "Keyboards"
            },
            new Category
            {
                Color = (Color)ColorConverter.ConvertFromString("#F48024"),
                Name = "Shirts"
            },
            new Category
            {
                Color = Colors.MediumSlateBlue,
                Name = "Shorts"
            },
        };
        public ObservableViewModelCollection<CategoryViewModel, Category> CategoryViewModels { get; }
        public MainWindowViewModel()
        {
            CategoryViewModels = new ObservableViewModelCollection<CategoryViewModel, Category>(categories, c => new CategoryViewModel(c));
        }
    }
}
