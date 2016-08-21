using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BotManager.Windows
{
	public class CmdLine
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct STARTUPINFO
		{
			public int cb;

			public string lpReserved;

			public string lpDesktop;

			public string lpTitle;

			public int dwX;

			public int dwY;

			public int dwXSize;

			public int dwYSize;

			public int dwXCountChars;

			public int dwYCountChars;

			public int dwFillAttribute;

			public int dwFlags;

			public short wShowWindow;

			public short cbReserved2;

			public int lpReserved2;

			public int hStdInput;

			public int hStdOutput;

			public int hStdError;
		}

		public struct PROCESS_INFORMATION
		{
			public IntPtr hProcess;

			public IntPtr hThread;

			public int dwProcessId;

			public int dwThreadId;
		}

		private const int STARTF_USESHOWWINDOW = 1;

		private const int SW_SHOWNOACTIVATE = 4;

		private const int SW_SHOWMINNOACTIVE = 7;

		public static Process Run(ref ProcessStartInfo pInfo)
		{
			int processId = CmdLine.StartProcessNoActivate(pInfo);
			Process result;
			try
			{
				result = Process.GetProcessById(processId);
			}
			catch (Exception arg_11_0)
			{
				ProjectData.SetProjectError(arg_11_0);
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		[DllImport("kernel32.dll")]
		private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref CmdLine.STARTUPINFO lpStartupInfo, ref CmdLine.PROCESS_INFORMATION lpProcessInformation);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr hObject);

		public static int StartProcessNoActivate(ProcessStartInfo pInfo)
		{
			CmdLine.STARTUPINFO structure = default(CmdLine.STARTUPINFO);
			structure.cb = Marshal.SizeOf<CmdLine.STARTUPINFO>(structure);
			structure.dwFlags = 1;
			structure.wShowWindow = 7;
			CmdLine.PROCESS_INFORMATION pROCESS_INFORMATION = default(CmdLine.PROCESS_INFORMATION);
			CmdLine.CreateProcess(null, pInfo.WorkingDirectory + "\\" + pInfo.FileName, IntPtr.Zero, IntPtr.Zero, true, 0u, IntPtr.Zero, pInfo.WorkingDirectory, ref structure, ref pROCESS_INFORMATION);
			CmdLine.CloseHandle(pROCESS_INFORMATION.hProcess);
			CmdLine.CloseHandle(pROCESS_INFORMATION.hThread);
			return pROCESS_INFORMATION.dwProcessId;
		}
	}
}
