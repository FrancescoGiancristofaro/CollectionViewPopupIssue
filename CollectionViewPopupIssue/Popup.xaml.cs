namespace CollectionViewPopupIssue;

public partial class SizedPopup
{
	public SizedPopup()
	{
		InitializeComponent();
		ListView.ItemsSource = new int[250];
	}
}