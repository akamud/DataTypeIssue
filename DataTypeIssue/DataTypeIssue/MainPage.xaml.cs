using System;
using Xamarin.Forms;

namespace DataTypeIssue
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

            foreach (var cell in listView.TemplatedItems)
            {
                Console.WriteLine($"Image Source: {((cell as ViewCell).View as Image).Source}");
            }
        }
    }
}