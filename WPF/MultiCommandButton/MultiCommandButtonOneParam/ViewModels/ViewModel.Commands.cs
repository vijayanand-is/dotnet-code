using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiCommandButtonOneParam.ViewModels
{
	/// <summary>
	/// ViewModel commands
	/// </summary>
	public partial class ViewModel : INotifyPropertyChanged
	{
		#region notification property for use in command parameter binding
		private int _delay = 0;
		public int Delay
		{
			get { return _delay; }
			set
			{
				_delay = value;
				RaisePropertyChanged( ( ) => Delay );
			}
		}
		#endregion notification property for use in command parameter binding

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
			Delay = ir_delay1000;

			Stopwatch w = new Stopwatch( );
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { w.Start( ); Thread.Sleep( ( int )parameter ); } ).
							ContinueWith( t => 
								{ 
									w.Stop( );
									NorthCommandManifest = string.Format( name + sr_wasted, ( int )w.ElapsedMilliseconds );
								} 
							);
		}
		#endregion north

		#region west
		private bool CanWestAction( object parameter )
		{
			return true;
		}

		private void WestAction( object parameter )
		{
			Delay = ir_delay2000; 

			Stopwatch w = new Stopwatch( );
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { w.Start( ); Thread.Sleep( ( int )parameter ); } ).
							ContinueWith( t => 
								{ 
									w.Stop( );
									WestCommandManifest = string.Format( name + sr_wasted, ( int )w.ElapsedMilliseconds );
								} 
							);
		}
		#endregion west

		#region south
		private bool CanSouthAction( object parameter )
		{
			return true;
		}

		private void SouthAction( object parameter )
		{
			Delay = ir_delay3000; 

			Stopwatch w = new Stopwatch( );
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { w.Start( ); Thread.Sleep( ( int )parameter ); } ).
							ContinueWith( t => 
								{ 
									w.Stop( );
									SouthCommandManifest = string.Format( name + sr_wasted, ( int )w.ElapsedMilliseconds );
								} 
							);
		}
		#endregion south

		#region east
		private bool CanEastAction( object parameter )
		{
			return true;
		}

		private void EastAction( object parameter )
		{
			Delay = ir_delay4000; 

			Stopwatch w = new Stopwatch( );
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { w.Start( ); Thread.Sleep( ( int )parameter ); } ).
							ContinueWith( t => 
								{ 
									w.Stop( );
									EastCommandManifest = string.Format( name + sr_wasted, ( int )w.ElapsedMilliseconds );
								} );
		}
		#endregion east

		#endregion command methods
	}
}

