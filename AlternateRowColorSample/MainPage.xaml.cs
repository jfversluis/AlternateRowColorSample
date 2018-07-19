using System.Collections.Generic;
using Xamarin.Forms;

namespace AlternateRowColorSample
{
	public partial class MainPage : ContentPage
	{
		public List<string> Items { get; set; } = new List<string>()
		{
			"R2-D2",
			"3CPO",
			"Luke Skywalker",
			"Darth Vader",
			"Han Solo",
			"Chewbacca",
			"Yoda",
			"Obi-Wan Kenobi"
		};

		public MainPage()
		{
			InitializeComponent();

			BindingContext = this;
		}
	}
}