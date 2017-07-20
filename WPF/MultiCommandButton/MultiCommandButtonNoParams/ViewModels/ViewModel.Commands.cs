using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Reflection;

namespace MultiCommandButtonNoParams.ViewModels
{
	/// <summary>
	/// ViewModel commands
	/// </summary>
	public partial class ViewModel : INotifyPropertyChanged
	{
		/// <summary>
		/// RelayCommands that are started by the Button
		/// </summary>
		#region commands
		public ICommand NorthActionCommand { get; private set; }
		public ICommand WestActionCommand { get; private set; }
		public ICommand SouthActionCommand { get; private set; }
		public ICommand EastActionCommand { get; private set; }
		#endregion commands

		/// <summary>
		/// obligatory parameter's values for RelayCommand
		/// each Can...Action simply returns true
		/// each executable ...Action starts appropriate Task for delayed asynchronous input into TextBlock
		/// all Can...Actions and all ...Action are collected together in the MultiCommandConverter
		/// </summary>
		/// <param name="parameter">button's command parameter</param>
		/// <returns></returns>
		#region command methods
		#region north
		private bool CanNorthAction( object parameter )
		{
			return true;
		}

		private void NorthAction( object parameter )
		{
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { Thread.Sleep( ir_delay1000 ); } ).
							ContinueWith( t => { NorthCommandManifest = name + sr_executed; } );
		}
		#endregion north

		#region west
		private bool CanWestAction( object parameter )
		{
			return true;
		}

		private void WestAction( object parameter )
		{
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { Thread.Sleep( ir_delay2000 ); } ).
							ContinueWith( t => { WestCommandManifest = name + sr_executed; } );
		}
		#endregion west

		#region south
		private bool CanSouthAction( object parameter )
		{
			return true;
		}

		private void SouthAction( object parameter )
		{
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { Thread.Sleep( ir_delay3000 ); } ).
							ContinueWith( t => { SouthCommandManifest = name + sr_executed; } );
		}
		#endregion south

		#region east
		private bool CanEastAction( object parameter )
		{
			return true;
		}

		private void EastAction( object parameter )
		{
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { Thread.Sleep( ir_delay4000 ); } ).
							ContinueWith( t => { EastCommandManifest = name + sr_executed; } );
		}
		#endregion east
		#endregion command methods
	}
}