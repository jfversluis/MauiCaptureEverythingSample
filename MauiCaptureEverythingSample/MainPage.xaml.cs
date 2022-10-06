using Microsoft.Maui.Media;

namespace MauiCaptureEverythingSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        var result = await stack.CaptureAsync();
        //var stream = await result.OpenReadAsync();

        using MemoryStream memoryStream = new();
		//await stream.CopyToAsync(memoryStream);
		await result.CopyToAsync(memoryStream);

#warning ONLY WORKS ON WINDOWS!
		File.WriteAllBytes("C:\\users\\joverslu\\Desktop\\stack.png", memoryStream.ToArray());

    }
}

