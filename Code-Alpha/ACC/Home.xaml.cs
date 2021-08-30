using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        public Home()
        {
            InitializeComponent();
            //had to do this in code behind because i had an error that wanted to break my app was really annoying when using this later dont forget to add the using 
            //Xamarin.Forms.PlatformConfiguration.AndroidSpecific; because it will not work and will give you errors when trying to implement it 
             //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            NavigationPage.SetHasBackButton(this, false);


            NavigationPage viewFav = new NavigationPage(new Favorites());
            viewFav.IconImageSource = "heartb.png";
            viewFav.Title = "Favorites";

            NavigationPage viewSave = new NavigationPage(new Saved());
            viewSave.IconImageSource = "folderp.png";
           viewSave.Title = "Saved";

            NavigationPage viewSearch = new NavigationPage(new Search());
            viewSearch.IconImageSource = "searchp.png";
           viewSearch.Title = "Search";

            NavigationPage viewSet = new NavigationPage(new Settings());
            viewSet.IconImageSource = "cogp.png";
            viewSet.Title = "Settings";

            NavigationPage viewUse = new NavigationPage(new UserProfile());
            viewUse.IconImageSource = "userp.jpg";
            viewUse.Title = "Profile";



            Children.Add(viewFav);
            Children.Add(viewSave);
            Children.Add(viewSearch);
            Children.Add(viewSet);
            Children.Add(viewUse);
        }
    }
}