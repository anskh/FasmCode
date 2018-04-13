﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace FasmCode.Utils
{
    public class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
                return (Visibility)value == Visibility.Visible;
            else
                return (bool)value == true ? Visibility.Visible : Visibility.Collapsed;            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
                return (bool)value == true ? Visibility.Visible : Visibility.Collapsed;            
            else
                return (Visibility)value == Visibility.Visible;
        }
    }
}