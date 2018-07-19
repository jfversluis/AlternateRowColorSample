using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AlternateRowColorSample
{
	public class AlternateColorDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate EvenTemplate { get; set; }
		public DataTemplate UnevenTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			// TODO: Maybe some more error handling here
			return ((List<string>)((ListView)container).ItemsSource).IndexOf(item as string) % 2 == 0 ? EvenTemplate : UnevenTemplate;
		}
	}
}