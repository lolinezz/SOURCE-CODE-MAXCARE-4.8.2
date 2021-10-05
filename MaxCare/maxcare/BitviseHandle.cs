using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using ManagedWinapi.Windows;

namespace maxcare
{
	// maxcare.BitviseHandle
	using System;
	using System.Collections;
	using System.Diagnostics;
	using System.Runtime.InteropServices;
	using System.Threading;
	using ManagedWinapi.Windows;

	internal class BitviseHandle
	{
		private const int WM_CLOSE = 16;

		private const int BN_CLICKED = 245;

		private const int WM_LBUTTONDOWN = 513;

		private const int WM_LBUTTONUP = 514;

		private static Hashtable BitviseList = new Hashtable();

		public static int TimeoutSeconds = 30;

		private static int PortIndex = 1079;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int SendMessage(int hWnd, int msg, int wParam, IntPtr lParam);

		public static int GetPortAvailable()
		{
			//Discarded unreachable code: IL_0058, IL_0065
			PortIndex++;
			if (PortIndex >= 1280)
			{
				PortIndex = 1079;
			}
			Process value = new Process();
			try
			{
				BitviseList.Add(PortIndex, value);
			}
			catch
			{
			}
			return PortIndex;
		}

		public static bool Connect(string Host, string User, string Pass, int ForwardPort)
		{
			//Discarded unreachable code: IL_0393, IL_03a0
			bool flag = false;
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient\\BvSsh.exe";
			processStartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient";
			processStartInfo.Arguments = "-profile=\"" + AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient\\" + ForwardPort + ".bscp\" -host=" + Host + " -user=" + User + " -password=" + Pass + " -loginOnStartup -hide=main,trayIcon,banner,auth,popups,trayLog,trayWRC,trayTerm,traySFTP,trayRDP,trayPopups";
			Process process = Process.Start(processStartInfo);
			BitviseList[ForwardPort] = process;
			Thread.Sleep(2000);
			for (int i = 0; i < TimeoutSeconds; i++)
			{
				SystemWindow[] array = SystemWindow.FilterToplevelWindows((SystemWindow w) => w.Title == "Host Key Verification");
				if (array.Length != 0)
				{
					SystemWindow[] array2 = array[0].FilterDescendantWindows(directOnly: false, (SystemWindow w) => w.Title == "&Accept for This Session");
					if (array2.Length != 0)
					{
						SendMessage((int)array2[0].HWnd, 513, 0, IntPtr.Zero);
						Thread.Sleep(10);
						SendMessage((int)array2[0].HWnd, 514, 0, IntPtr.Zero);
						SendMessage((int)array2[0].HWnd, 513, 0, IntPtr.Zero);
						Thread.Sleep(10);
						SendMessage((int)array2[0].HWnd, 514, 0, IntPtr.Zero);
					}
				}
				SystemWindow[] array3 = SystemWindow.FilterToplevelWindows((SystemWindow w) => w.Title == "Bitvise SSH Client - " + ForwardPort + ".bscp - " + Host + ":22");
				if (array3.Length != 0)
				{
					flag = true;
					break;
				}
				Thread.Sleep(1000);
			}
			if (!flag)
			{
				try
				{
					process.Kill();
					process.Dispose();
				}
				catch
				{
				}
			}
			return flag;
		}

		public static void Disconnect(int ForwardPort)
		{
			//Discarded unreachable code: IL_0057, IL_0064
			if (BitviseList[ForwardPort] != null)
			{
				try
				{
					Process process = BitviseList[ForwardPort] as Process;
					process.Kill();
					process.Dispose();
				}
				catch
				{
				}
			}
		}

		private static bool GetPort(string Host, int Port)
		{
			return true;
		}

		public static void DisconnectAllBiviseRunning()
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "BvSsh")
				{
					process.Kill();
				}
			}
		}

		public static Process FindProcess(IntPtr yourHandle)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.Handle == yourHandle)
				{
					return process;
				}
			}
			return null;
		}
	}

}