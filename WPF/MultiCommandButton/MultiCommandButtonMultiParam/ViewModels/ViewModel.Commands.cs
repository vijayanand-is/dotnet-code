using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiCommandButtonMultiParam.ViewModels
{
	/// <summary>
	/// ViewModel commands
	/// </summary>
	public partial class ViewModel : INotifyPropertyChanged
	{
		#region the properties which command parameters are binded to
		public int NorthDelay
		{
			get { return ir_delay1000; }
		}

		public int WestDelay
		{
			get { return ir_delay2000; }
		}

		public int SouthDelay
		{
			get { return ir_delay3000; }
		}

		public int EastDelay
		{
			get { return ir_delay4000; }
		}
		#endregion the properties which command parameters are binded to

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
			Stopwatch w = new Stopwatch( );
			string name = MethodBase.GetCurrentMethod( ).Name;
			Task.Factory.StartNew( ( ) => { w.Start( ); Thread.Sleep( ( int )parameter ); } ).
							ContinueWith( t =>
								{
									w.Stop( );
									EastCommandManifest = string.Format( name + sr_wasted, ( int )w.ElapsedMilliseconds );
								}
							);
		}
		#endregion east
		#endregion command methods
	}
}