﻿using System.Windows;
using Caliburn.Micro;

namespace Examples.TelerikWindowManager
{
	public class DialogWithResponceButtonsViewModel : Screen
	{
		public DialogWithResponceButtonsViewModel()
		{
			DisplayName = "Sample dialog view";
		}

		public void Close()
		{
			MessageBox.Show("Closing !\nCancel button action");

			TryClose();
		}

		public void Save()
		{
			MessageBox.Show("Saved ! \nAccept button action");
			TryClose();
		}
	}
}