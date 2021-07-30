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
			InfoList.ItemTapped += ItemTapped;
		}

		public void SetDataOnView(List<DictionaryItem> items)
		{
			InfoList.ItemsSource = items;
		}

		public void ClearDataOnView()
		{
			InfoList.ItemsSource = null;
		}

		private void ItemTapped(Object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
				return;

			if(sender is ListView lv)
			{
				lv.SelectedItem = null;
			}
		}
	}
}