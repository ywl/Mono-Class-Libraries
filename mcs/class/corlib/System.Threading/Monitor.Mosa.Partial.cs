/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;

#if NET_2_0
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
#endif

namespace System.Threading
{
	public partial class Monitor
	{
		private static bool Monitor_try_enter(object obj, int ms)
		{
			throw new System.NotImplementedException();
		}
		public static void Enter(object obj)
		{
			throw new System.NotImplementedException();
		}
		public static void Exit(object obj)
		{
			throw new System.NotImplementedException();
		}
		private static void Monitor_pulse(object obj)
		{
			throw new System.NotImplementedException();
		}
		private static bool Monitor_test_synchronised(object obj)
		{
			throw new System.NotImplementedException();
		}
		private static void Monitor_pulse_all(object obj)
		{
			throw new System.NotImplementedException();
		}
		private static bool Monitor_wait(object obj, int ms)
		{
			throw new System.NotImplementedException();
		}

	}
}
