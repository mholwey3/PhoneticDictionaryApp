using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhoneticDictionaryApp.Source
{
	public partial class MainPage : ContentPage
	{
		private const string _FILE_NAME = "PHONETIC_DICTIONARY_BASE_A.csv";

		private IPhoneticDictionary _dictionary;

		private AdditionalInfoView _relatedItemsView;
		private AdditionalInfoView _useCasesView;

		public MainPage()
		{
			InitializeComponent();

			_dictionary = new PhoneticDictionaryFile();
			_relatedItemsView = new AdditionalInfoView("Related Items");
			_useCasesView = new AdditionalInfoView("Use Cases");
		}

		private void TryGetWord(object sender, EventArgs args)
		{
			DictionaryItem item = _dictionary.GetDictionaryItem(UserInput.Text);

			if(item != null)
			{
				SetDataOnView(item);
			}
			else
			{
				// Handle word not found
			}
		}

		private void SetDataOnView(DictionaryItem item)
		{
			Word.Text = item.Word;
			Pronunciation.Text = item.Pronunciation;
			PhoneticSpelling.Text = item.PhoneticSpelling;

			ClearRelatedItemsDataOnView();
			ClearUseCaseItemsDataOnView();

			if (item.RelatedItems.Count > 0)
			{
				SetRelatedItemsDataOnView(item);
			}

			if(item.UseCases.Count > 0)
			{
				SetUseCaseItemsDataOnView(item);
			}
		}

		private void SetRelatedItemsDataOnView(DictionaryItem item)
		{
			_relatedItemsView.SetDataOnView(item.RelatedItems);
			RelatedItemsParent.Children.Add(_relatedItemsView);
		}

		private void ClearRelatedItemsDataOnView()
		{
			_relatedItemsView.ClearDataOnView();
			RelatedItemsParent.Children.Clear();
		}

		private void SetUseCaseItemsDataOnView(DictionaryItem item)
		{
			_useCasesView.SetDataOnView(item.UseCases);
			UseCasesParent.Children.Add(_useCasesView);
		}

		private void ClearUseCaseItemsDataOnView()
		{
			_useCasesView.ClearDataOnView();
			UseCasesParent.Children.Clear();
		}
	}
}
