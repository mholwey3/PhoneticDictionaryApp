using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhoneticDictionaryApp.Source
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdditionalInfoView : StackLayout
	{
		public AdditionalInfoView(string infoHeader)
		{
			InitializeComponent();

			InfoHeader.Text = infoHeader;
		}

		public void SetDataOnView(List<DictionaryItem> items)
		{
			BindableLayout.SetItemsSource(InfoList, items);
		}

		public void ClearDataOnView()
		{
			BindableLayout.SetItemsSource(InfoList, null);
		}
	}
}