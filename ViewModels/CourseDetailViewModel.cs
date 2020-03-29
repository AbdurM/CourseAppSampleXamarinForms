using System;
using System.Collections.ObjectModel;
using CourseAppSampleXamarinForms.Models;

namespace CourseAppSampleXamarinForms.ViewModels
{
    public class CourseDetailViewModel
    {
        public ObservableCollection<Video> VideoList { get; set; }

        public CourseDetailViewModel()
        {
            VideoList = new ObservableCollection<Video>();

            for (int i= 1; i<20; i++)
            {
                var video = new Video
                {
                    VideoNumber = $"0{i}",
                    Title = $"Sample Title {i}",
                    Duration = $"{i}{i}:{i}{i} mins"
                };

                VideoList.Add(video);
            }
            
        }
    }
}
