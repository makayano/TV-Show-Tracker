using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TV_Show_Tracker
{
    public class MasterPage : ContentPage
    {
        public ListView Listview { get; { return listview; } }

        ListView listView;

        public MasterPage()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Browse"
                //TODO: implement searchTVshowsActivity
                //IconSource = ,
                //TargetType = typeof("SearchTVShows")
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "My Shows"
                //IconSource = ,
                //TargetType = typeof("MyShows")
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Settings"
                //IconSource = ,
                //TargetType = typeof("Settings")
            });
            listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
               {
                   var imageCell = new ImageCell();
                   imageCell.SetBinding(TextCell.TextProperty, "Title");
                   imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                   return imageCell;
               }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };
            Padding = new Thickness(0, 40, 0, 0);
            //Icon = "hamburger.png"
            Title = "Personal Organizer";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    listView
                }
            };
        }
    }
}
