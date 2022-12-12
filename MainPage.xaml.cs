using Microsoft.Maui.Graphics.Text;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}


	private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
	{
		L.Text = e.TotalX + " " + (e.TotalY * -1);

		if (e.StatusType == GestureStatus.Running)
		{
			(sender as BoxView).TranslationX = e.TotalX;
			(sender as BoxView).TranslationY = e.TotalY;
		}
		if (e.StatusType == GestureStatus.Completed)
		{
			(sender as BoxView).Color = Colors.Yellow;
		}
		else if (e.StatusType == GestureStatus.Running)
		{
            (sender as BoxView).Color = Colors.Black;
        }

		
        
    }
   
}