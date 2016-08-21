using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BotManager.Windows
{
	public class Api
	{
		public delegate bool EnumWindowProcess(IntPtr Handle, IntPtr Parameter);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern IntPtr GetParent(IntPtr hWnd);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetActiveWindow();

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetWindowTextA(IntPtr hwnd, StringBuilder lpString, int cch);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		[DllImport("User32.dll")]
		private static extern bool EnumChildWindows(IntPtr WindowHandle, Api.EnumWindowProcess Callback, IntPtr lParam);

		public static IntPtr[] GetChildWindows(IntPtr ParentHandle)
		{
			List<IntPtr> list = new List<IntPtr>();
			GCHandle value = GCHandle.Alloc(list);
			try
			{
				Api.EnumChildWindows(ParentHandle, new Api.EnumWindowProcess(Api.EnumWindow), GCHandle.ToIntPtr(value));
			}
			finally
			{
				if (value.IsAllocated)
				{
					value.Free();
				}
			}
			return list.ToArray();
		}

		private static bool EnumWindow(IntPtr Handle, IntPtr Parameter)
		{
			List<IntPtr> list = (List<IntPtr>)GCHandle.FromIntPtr(Parameter).Target;
			if (list == null)
			{
				throw new Exception("GCHandle Target could not be cast as List(Of IntPtr)");
			}
			list.Add(Handle);
			return true;
		}
	}
}
