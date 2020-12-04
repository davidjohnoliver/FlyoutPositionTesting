﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace FlyoutPositionTesting
{
	public class StringConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			string str = value?.ToString();
			return str;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotSupportedException();
		}
	}
}
