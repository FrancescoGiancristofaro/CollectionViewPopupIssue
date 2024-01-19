using CommunityToolkit.Maui.Views;

namespace CollectionViewPopupIssue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Shell.Current.ShowPopup(new SizedPopup());
        }

        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Shell.Current.ShowPopup(new FramePopup());
        }
    }

}
