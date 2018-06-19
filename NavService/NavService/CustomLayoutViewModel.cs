using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NavService
{
    class CustomLayoutViewModel
    {
        public ObservableCollection<string> ImagesSources { get; } = new ObservableCollection<string>();

        public CustomLayoutViewModel()
        {
            ImagesSources.Add("https://www.king.senate.gov/imo/media/image/2013%20Senator%20King%20Official%20Portrait1.jpg");
            ImagesSources.Add("https://www.king.senate.gov/imo/media/image/2013%20Senator%20King%20Official%20Portrait1.jpg");
            ImagesSources.Add("https://www.king.senate.gov/imo/media/image/2013%20Senator%20King%20Official%20Portrait1.jpg");
            ImagesSources.Add("https://www.king.senate.gov/imo/media/image/2013%20Senator%20King%20Official%20Portrait1.jpg");
            ImagesSources.Add("https://www.king.senate.gov/imo/media/image/2013%20Senator%20King%20Official%20Portrait1.jpg");
        }
    }
}
