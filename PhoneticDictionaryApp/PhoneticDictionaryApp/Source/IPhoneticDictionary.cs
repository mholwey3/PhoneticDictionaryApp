using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneticDictionaryApp.Source
{
	interface IPhoneticDictionary
	{
		Dictionary<string, DictionaryItem> PhoneticDictionary { get; set; }

		void LoadDictionary();

		DictionaryItem GetDictionaryItem(string sWordToFind);
	}
}
