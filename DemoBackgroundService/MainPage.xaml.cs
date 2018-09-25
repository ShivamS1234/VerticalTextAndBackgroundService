using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoBackgroundService
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            try
            {
                string name = "SHIVAM";
                var grid = new Grid
                {
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto }
                }
                };
                grid.RowDefinitions = new RowDefinitionCollection();

                for (int MyCount = 0; MyCount < name.Length; MyCount++)
                {

                    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                }
                foreach (char chr in name)
                {
                    grid.Children.Add(new Label { Text = chr.ToString()  }, 0, name.IndexOf(chr));
                }
             
                this.Content = grid;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

         
        }
    }
}
