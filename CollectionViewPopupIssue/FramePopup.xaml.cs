namespace CollectionViewPopupIssue;

public partial class FramePopup 
{
	public FramePopup()
	{
		InitializeComponent();
		ListView.ItemsSource = new int[250];
    }
}