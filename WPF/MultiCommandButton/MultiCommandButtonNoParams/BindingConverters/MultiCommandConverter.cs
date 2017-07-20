using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using MultiCommandButtonNoParams.Commands;

namespace MultiCommandButtonNoParams.BindingConverters
{
	public class MultiCommandConverter : IMultiValueConverter
	{
		private List<object> _value = new List<object>( );

		/// <summary>
		/// dobbin of the converter
		/// </summary>
		/// <param name="value">commands binded by means of multibiniding</param>
		/// <returns>compound Relay command</returns>
		public object Convert( object[ ] value, Type targetType,
			object parameter, CultureInfo culture )
		{
			_value.AddRange( value );
			return new RelayCommand( GetCompoundExecute( ), GetCompoundCanExecute( ) );
		}

		/// <summary>
		/// here - mandatory duty
		/// </summary>
		public object[ ] ConvertBack( object value, Type[ ] targetTypes,
			object parameter, CultureInfo culture )
		{
			return null;
		}

		/// <summary>
		/// for execution of all commands
		/// </summary>
		/// <returns>Action<object> that plays a role of the joint Execute</returns>
		private Action<object> GetCompoundExecute( )
		{
			return ( parameter ) =>
			{
				foreach ( RelayCommand command in _value )
				{
					if ( command != default( RelayCommand ) )
						command.Execute( parameter );
				}
			};
		}

		/// <summary>
		/// for check if execution of all commands is possible
		/// </summary>
		/// <returns>Predicate<object> that plays a role of the joint CanExecute</returns>
		private Predicate<object> GetCompoundCanExecute( )
		{
			return ( parameter ) =>
			{
				bool res = true;
				foreach ( RelayCommand command in _value )
					if ( command != default( RelayCommand ) )
						res &= command.CanExecute( parameter );
				return res;
			};
		}
	}
}
