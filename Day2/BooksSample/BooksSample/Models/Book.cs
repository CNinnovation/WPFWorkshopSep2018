using System.ComponentModel;
using TheBestMVVMFrameworkInTown.Core;

namespace BooksSample.Models
{
    public class Book : BindableBase
    {
        public Book()
        {

        }
        public int BookdId { get; set; }
        public string Isbn { get; set; }

        private string _title;

        public string Title
        {
            get => _title;
            set { SetProperty(ref _title, value); }
        }

        private string _publisher;

        public string Publisher
        {
            get => _publisher;
            set => SetProperty(ref _publisher, value);
        }


        public string[] Authors { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString() => Title;
    }
}
