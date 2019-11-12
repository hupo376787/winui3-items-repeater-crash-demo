using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace winui_items_repeater_crash_demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<string> listName = new List<string>();
        public MainPage()
        {
            this.InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                listName.Add("Name: " + i.ToString());
            }
        }


    }

    public class NameS
    {
        public string name { get; set; }
    }
}
