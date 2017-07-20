using System.ComponentModel;
using MultiCommandButtonMultiParam.Commands;

namespace MultiCommandButtonMultiParam.ViewModels
{
	/// <summary>
	/// ViewModel ctor and fields
	/// </summary>
	public partial class ViewModel : INotifyPropertyChanged
	{
		#region fields
		private readonly string sr_wasted = " wasted {0} milliseconds";
		private readonly int ir_delay1000 = 1000;
		private readonly int ir_delay2000 = 2000;
		private readonly int ir_delay3000 = 3000;
		private readonly int ir_delay4000 = 4000;
		#endregion fields

		#region constructor
		public ViewModel( )
		{
			NorthActionCommand = new RelayCommand( NorthAction, CanNorthAction );
			WestActionCommand = new RelayCommand( WestAction, CanWestAction );
			SouthActionCommand = new RelayCommand( SouthAction, CanSouthAction );
			EastActionCommand = new RelayCommand( EastAction, CanEastAction );
		}
		#endregion constructor
	}
}
