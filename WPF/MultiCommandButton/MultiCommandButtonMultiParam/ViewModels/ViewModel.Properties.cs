using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace MultiCommandButtonMultiParam.ViewModels
{
	/// <summary>
	/// ViewModel notification properties
	/// </summary>
	public partial class ViewModel : INotifyPropertyChanged
	{
		/// <summary>
		/// properties which TextBlock is binded to
		/// </summary>
		#region command manifest properties
		private string _northCommandManifest = string.Empty;
		private string _westCommandManifest = string.Empty;
		private string _southCommandManifest = string.Empty;
		private string _eastCommandManifest = string.Empty;

		public string NorthCommandManifest
		{
			get { return _northCommandManifest; }

			set
			{
				if ( value != _northCommandManifest )
				{
					_northCommandManifest = value;
					RaisePropertyChanged( ( ) => NorthCommandManifest );
				}
			}
		}

		public string WestCommandManifest
		{
			get { return _westCommandManifest; }

			set
			{
				if ( value != _westCommandManifest )
				{
					_westCommandManifest = value;
					RaisePropertyChanged( ( ) => WestCommandManifest );
				}
			}
		}

		public string SouthCommandManifest
		{
			get { return _southCommandManifest; }

			set
			{
				if ( value != _southCommandManifest )
				{
					_southCommandManifest = value;
					RaisePropertyChanged( ( ) => SouthCommandManifest );
				}
			}
		}

		public string EastCommandManifest
		{
			get { return _eastCommandManifest; }

			set
			{
				if ( value != _eastCommandManifest )
				{
					_eastCommandManifest = value;
					RaisePropertyChanged( ( ) => EastCommandManifest );
				}
			}
		}
		#endregion command manifest property

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// call to Helper for get rid of "magic string" of property name
		/// </summary>
		/// <typeparam name="T">for expression needs</typeparam>
		/// <param name="propertyExpression">expression from which a property name can be drawn</param>
		protected void RaisePropertyChanged<T>( Expression<Func<T>> propertyExpression )
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if ( handler != null )
				handler( this, new PropertyChangedEventArgs( ( propertyExpression.Body as MemberExpression ).Member.Name ) );
		}
		#endregion INotifyPropertyChanged
	}
}
