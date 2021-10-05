using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MCommon
{
	// Token: 0x02000031 RID: 49
	public class AutoControl
	{
		// Token: 0x060000C0 RID: 192
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x060000C1 RID: 193
		[DllImport("User32.dll")]
		public static extern bool EnumChildWindows(IntPtr hWndParent, AutoControl.CallBack lpEnumFunc, IntPtr lParam);

		// Token: 0x060000C2 RID: 194
		[DllImport("User32.dll")]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder s, int nMaxCount);

		// Token: 0x060000C3 RID: 195
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		// Token: 0x060000C4 RID: 196
		[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
		private static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

		// Token: 0x060000C5 RID: 197
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060000C6 RID: 198
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);

		// Token: 0x060000C7 RID: 199
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060000C8 RID: 200
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

		// Token: 0x060000C9 RID: 201
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

		// Token: 0x060000CA RID: 202
		[DllImport("user32.dll")]
		private static extern IntPtr GetDlgItem(IntPtr hWnd, int nIDDlgItem);

		// Token: 0x060000CB RID: 203
		[DllImport("user32.dll")]
		private static extern bool SetDlgItemTextA(IntPtr hWnd, int nIDDlgItem, string gchar);

		// Token: 0x060000CC RID: 204
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

		// Token: 0x060000CD RID: 205
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060000CE RID: 206
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool PostMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

		// Token: 0x060000CF RID: 207
		[DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x060000D0 RID: 208
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

		// Token: 0x060000D1 RID: 209
		[DllImport("user32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool EnumChildWindows(IntPtr window, AutoControl.EnumWindowProc callback, IntPtr lParam);

		// Token: 0x060000D2 RID: 210
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);

		// Token: 0x060000D3 RID: 211
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		// Token: 0x060000D4 RID: 212
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputStructure);

		// Token: 0x060000D5 RID: 213
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsWindowVisible(IntPtr hWnd);

		// Token: 0x060000D6 RID: 214 RVA: 0x00009704 File Offset: 0x00007904
		public static IntPtr BringToFront(string className, string windowName = null)
		{
			IntPtr intPtr = AutoControl.FindWindow(className, windowName);
			AutoControl.SetForegroundWindow(intPtr);
			return intPtr;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00009734 File Offset: 0x00007934
		public static IntPtr BringToFront(IntPtr hWnd)
		{
			AutoControl.SetForegroundWindow(hWnd);
			return hWnd;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000975C File Offset: 0x0000795C
		public static bool IsWindowVisible_(IntPtr handle)
		{
			return AutoControl.IsWindowVisible(handle);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000977C File Offset: 0x0000797C
		public static IntPtr FindWindowHandle(string className, string windowName)
		{
			IntPtr zero = IntPtr.Zero;
			return AutoControl.FindWindow(className, windowName);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000097A8 File Offset: 0x000079A8
		public static List<IntPtr> FindWindowHandlesFromProcesses(string className, string windowName, int maxCount = 1)
		{
			Process[] processes = Process.GetProcesses();
			List<IntPtr> list = new List<IntPtr>();
			int num = 0;
			foreach (Process process in from p in processes
			where p.MainWindowHandle != IntPtr.Zero
			select p)
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				string className2 = AutoControl.GetClassName(mainWindowHandle);
				string text = AutoControl.GetText(mainWindowHandle);
				bool flag = className2 == className || text == windowName;
				bool flag2 = flag;
				if (flag2)
				{
					list.Add(mainWindowHandle);
					bool flag3 = num >= maxCount;
					bool flag4 = flag3;
					if (flag4)
					{
						break;
					}
					num++;
				}
			}
			return list;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000098CC File Offset: 0x00007ACC
		public static IntPtr FindWindowHandleFromProcesses(string className, string windowName)
		{
			Process[] processes = Process.GetProcesses();
			IntPtr result = IntPtr.Zero;
			foreach (Process process in from p in processes
			where p.MainWindowHandle != IntPtr.Zero
			select p)
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				string className2 = AutoControl.GetClassName(mainWindowHandle);
				string text = AutoControl.GetText(mainWindowHandle);
				bool flag = className2 == className || text == windowName;
				bool flag2 = flag;
				if (flag2)
				{
					result = mainWindowHandle;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000099BC File Offset: 0x00007BBC
		public static IntPtr FindWindowExFromParent(IntPtr parentHandle, string text, string className)
		{
			return AutoControl.FindWindowEx(parentHandle, IntPtr.Zero, className, text);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000099F0 File Offset: 0x00007BF0
		private static IntPtr FindWindowByIndex(IntPtr hWndParent, int index)
		{
			bool flag = index == 0;
			bool flag2 = flag;
			IntPtr result;
			if (flag2)
			{
				result = hWndParent;
			}
			else
			{
				int num = 0;
				IntPtr intPtr = IntPtr.Zero;
				do
				{
					intPtr = AutoControl.FindWindowEx(hWndParent, intPtr, "Button", null);
					bool flag3 = intPtr != IntPtr.Zero;
					bool flag4 = flag3;
					if (flag4)
					{
						num++;
					}
				}
				while (num < index && intPtr != IntPtr.Zero);
				result = intPtr;
			}
			return result;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00009AB4 File Offset: 0x00007CB4
		public static IntPtr GetControlHandleFromControlID(IntPtr parentHandle, int controlId)
		{
			return AutoControl.GetDlgItem(parentHandle, controlId);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00009ADC File Offset: 0x00007CDC
		public static List<IntPtr> GetChildHandle(IntPtr parentHandle)
		{
			List<IntPtr> list = new List<IntPtr>();
			GCHandle value = GCHandle.Alloc(list);
			IntPtr lParam2 = GCHandle.ToIntPtr(value);
			try
			{
				AutoControl.EnumWindowProc callback = delegate(IntPtr hWnd, IntPtr lParam)
				{
					GCHandle gchandle = GCHandle.FromIntPtr(lParam);
					bool flag = gchandle.Target == null;
					bool flag2 = flag;
					bool result;
					if (flag2)
					{
						result = false;
					}
					else
					{
						List<IntPtr> list2 = gchandle.Target as List<IntPtr>;
						list2.Add(hWnd);
						result = true;
					}
					return result;
				};
				AutoControl.EnumChildWindows(parentHandle, callback, lParam2);
			}
			finally
			{
				value.Free();
			}
			return list;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00009B64 File Offset: 0x00007D64
		public static IntPtr FindHandleWithText(List<IntPtr> handles, string className, string text)
		{
			return handles.Find(delegate(IntPtr ptr)
			{
				string className2 = AutoControl.GetClassName(ptr);
				string text2 = AutoControl.GetText(ptr);
				return className2 == className || text2 == text;
			});
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public static List<IntPtr> FindHandlesWithText(List<IntPtr> handles, string className, string text)
		{
			List<IntPtr> list = new List<IntPtr>();
			IEnumerable<IntPtr> source = handles.Where(delegate(IntPtr ptr)
			{
				string className2 = AutoControl.GetClassName(ptr);
				string text2 = AutoControl.GetText(ptr);
				return className2 == className || text2 == text;
			});
			return source.ToList<IntPtr>();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00009C08 File Offset: 0x00007E08
		public static IntPtr FindHandle(IntPtr parentHandle, string className, string text)
		{
			return AutoControl.FindHandleWithText(AutoControl.GetChildHandle(parentHandle), className, text);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00009C3C File Offset: 0x00007E3C
		public static List<IntPtr> FindHandles(IntPtr parentHandle, string className, string text)
		{
			return AutoControl.FindHandlesWithText(AutoControl.GetChildHandle(parentHandle), className, text);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00009C70 File Offset: 0x00007E70
		public static bool CallbackChild(IntPtr hWnd, IntPtr lParam)
		{
			string text = AutoControl.GetText(hWnd);
			string className = AutoControl.GetClassName(hWnd);
			bool flag = text == "&Options >>" && className.StartsWith("ToolbarWindow32");
			bool flag2 = flag;
			bool result;
			if (flag2)
			{
				AutoControl.SendMessage(hWnd, 0, IntPtr.Zero, IntPtr.Zero);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00009D20 File Offset: 0x00007F20
		public static void SendClickOnControlById(IntPtr parentHWND, int controlID)
		{
			IntPtr dlgItem = AutoControl.GetDlgItem(parentHWND, controlID);
			int wParam = 0 | (controlID & 65535);
			AutoControl.SendMessage(parentHWND, 273, wParam, dlgItem);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00009D68 File Offset: 0x00007F68
		public static void SendClickOnControlByHandle(IntPtr hWndButton)
		{
			AutoControl.SendMessage(hWndButton, 513, IntPtr.Zero, IntPtr.Zero);
			AutoControl.SendMessage(hWndButton, 514, IntPtr.Zero, IntPtr.Zero);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00009DAC File Offset: 0x00007FAC
		public static void SendClickOnPosition(IntPtr controlHandle, int x, int y, EMouseKey mouseButton = EMouseKey.LEFT, int clickTimes = 1)
		{
			int msg = 0;
			int msg2 = 0;
			bool flag = mouseButton == EMouseKey.LEFT;
			bool flag2 = flag;
			if (flag2)
			{
				msg = 513;
				msg2 = 514;
			}
			bool flag3 = mouseButton == EMouseKey.RIGHT;
			bool flag4 = flag3;
			if (flag4)
			{
				msg = 516;
				msg2 = 517;
			}
			IntPtr lParam = AutoControl.MakeLParamFromXY(x, y);
			bool flag5 = mouseButton == EMouseKey.LEFT || mouseButton == EMouseKey.RIGHT;
			bool flag6 = flag5;
			if (flag6)
			{
				for (int i = 0; i < clickTimes; i++)
				{
					AutoControl.PostMessage(controlHandle, 6, new IntPtr(1), lParam);
					AutoControl.PostMessage(controlHandle, msg, new IntPtr(1), lParam);
					AutoControl.PostMessage(controlHandle, msg2, new IntPtr(0), lParam);
				}
			}
			else
			{
				bool flag7 = mouseButton == EMouseKey.DOUBLE_LEFT;
				bool flag8 = flag7;
				if (flag8)
				{
					msg = 515;
					msg2 = 514;
				}
				bool flag9 = mouseButton == EMouseKey.DOUBLE_RIGHT;
				bool flag10 = flag9;
				if (flag10)
				{
					msg = 518;
					msg2 = 517;
				}
				AutoControl.PostMessage(controlHandle, msg, new IntPtr(1), lParam);
				AutoControl.PostMessage(controlHandle, msg2, new IntPtr(0), lParam);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00009F5C File Offset: 0x0000815C
		public static void SendDragAndDropOnPosition(IntPtr controlHandle, int x, int y, int x2, int y2, int stepx = 10, int stepy = 10, double delay = 0.05)
		{
			int msg = 513;
			int msg2 = 514;
			IntPtr lParam = AutoControl.MakeLParamFromXY(x, y);
			IntPtr lParam2 = AutoControl.MakeLParamFromXY(x2, y2);
			bool flag = x2 < x;
			bool flag2 = flag;
			if (flag2)
			{
				stepx *= -1;
			}
			bool flag3 = y2 < y;
			bool flag4 = flag3;
			if (flag4)
			{
				stepy *= -1;
			}
			AutoControl.PostMessage(controlHandle, 6, new IntPtr(1), lParam);
			AutoControl.PostMessage(controlHandle, msg, new IntPtr(1), lParam);
			bool flag5 = false;
			bool flag6 = false;
			for (;;)
			{
				AutoControl.PostMessage(controlHandle, 512, new IntPtr(1), AutoControl.MakeLParamFromXY(x, y));
				bool flag7 = stepx > 0;
				bool flag8 = flag7;
				if (flag8)
				{
					bool flag9 = x < x2;
					bool flag10 = flag9;
					if (flag10)
					{
						x += stepx;
					}
					else
					{
						flag5 = true;
					}
				}
				else
				{
					bool flag11 = x > x2;
					bool flag12 = flag11;
					if (flag12)
					{
						x += stepx;
					}
					else
					{
						flag5 = true;
					}
				}
				bool flag13 = stepy > 0;
				bool flag14 = flag13;
				if (flag14)
				{
					bool flag15 = y < y2;
					bool flag16 = flag15;
					if (flag16)
					{
						y += stepy;
					}
					else
					{
						flag6 = true;
					}
				}
				else
				{
					bool flag17 = y > y2;
					bool flag18 = flag17;
					if (flag18)
					{
						y += stepy;
					}
					else
					{
						flag6 = true;
					}
				}
				bool flag19 = flag5 && flag6;
				bool flag20 = flag19;
				if (flag20)
				{
					break;
				}
				Thread.Sleep(TimeSpan.FromSeconds(delay));
			}
			AutoControl.PostMessage(controlHandle, msg2, new IntPtr(0), lParam2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public static void SendClickDownOnPosition(IntPtr controlHandle, int x, int y, EMouseKey mouseButton = EMouseKey.LEFT, int clickTimes = 1)
		{
			int msg = 0;
			bool flag = mouseButton == EMouseKey.LEFT;
			bool flag2 = flag;
			if (flag2)
			{
				msg = 513;
			}
			bool flag3 = mouseButton == EMouseKey.RIGHT;
			bool flag4 = flag3;
			if (flag4)
			{
				msg = 516;
			}
			IntPtr lParam = AutoControl.MakeLParamFromXY(x, y);
			for (int i = 0; i < clickTimes; i++)
			{
				AutoControl.PostMessage(controlHandle, 6, new IntPtr(1), lParam);
				AutoControl.PostMessage(controlHandle, msg, new IntPtr(1), lParam);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000A2BC File Offset: 0x000084BC
		public static void SendClickUpOnPosition(IntPtr controlHandle, int x, int y, EMouseKey mouseButton = EMouseKey.LEFT, int clickTimes = 1)
		{
			int msg = 0;
			bool flag = mouseButton == EMouseKey.LEFT;
			bool flag2 = flag;
			if (flag2)
			{
				msg = 514;
			}
			bool flag3 = mouseButton == EMouseKey.RIGHT;
			bool flag4 = flag3;
			if (flag4)
			{
				msg = 517;
			}
			IntPtr lParam = AutoControl.MakeLParamFromXY(x, y);
			for (int i = 0; i < clickTimes; i++)
			{
				AutoControl.PostMessage(controlHandle, 6, new IntPtr(1), lParam);
				AutoControl.SendMessage(controlHandle, msg, new IntPtr(0), lParam);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000A384 File Offset: 0x00008584
		public static void SendText(IntPtr handle, string text)
		{
			AutoControl.SendMessage(handle, 12, 0, text);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000A3B0 File Offset: 0x000085B0
		public static void SendKeyBoardPress(IntPtr handle, VKeys key)
		{
			AutoControl.PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
			AutoControl.PostMessage(handle, 256, new IntPtr((int)key), new IntPtr(1));
			AutoControl.PostMessage(handle, 257, new IntPtr((int)key), new IntPtr(0));
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000A430 File Offset: 0x00008630
		public static void SendKeyBoardPressStepByStep(IntPtr handle, string message, float delay = 0.1f)
		{
			foreach (char c in message.ToLower())
			{
				VKeys key = VKeys.VK_0;
				char c2 = c;
				switch (c2)
				{
				case '0':
					key = VKeys.VK_0;
					break;
				case '1':
					key = VKeys.VK_1;
					break;
				case '2':
					key = VKeys.VK_2;
					break;
				case '3':
					key = VKeys.VK_3;
					break;
				case '4':
					key = VKeys.VK_4;
					break;
				case '5':
					key = VKeys.VK_5;
					break;
				case '6':
					key = VKeys.VK_6;
					break;
				case '7':
					key = VKeys.VK_7;
					break;
				case '8':
					key = VKeys.VK_8;
					break;
				case '9':
					key = VKeys.VK_9;
					break;
				default:
					switch (c2)
					{
					case 'a':
						key = VKeys.VK_A;
						break;
					case 'b':
						key = VKeys.VK_B;
						break;
					case 'c':
						key = VKeys.VK_V;
						break;
					case 'd':
						key = VKeys.VK_D;
						break;
					case 'e':
						key = VKeys.VK_E;
						break;
					case 'f':
						key = VKeys.VK_F;
						break;
					case 'g':
						key = VKeys.VK_G;
						break;
					case 'h':
						key = VKeys.VK_H;
						break;
					case 'i':
						key = VKeys.VK_I;
						break;
					case 'j':
						key = VKeys.VK_J;
						break;
					case 'k':
						key = VKeys.VK_K;
						break;
					case 'l':
						key = VKeys.VK_L;
						break;
					case 'm':
						key = VKeys.VK_M;
						break;
					case 'n':
						key = VKeys.VK_N;
						break;
					case 'o':
						key = VKeys.VK_O;
						break;
					case 'p':
						key = VKeys.VK_P;
						break;
					case 'q':
						key = VKeys.VK_Q;
						break;
					case 'r':
						key = VKeys.VK_R;
						break;
					case 's':
						key = VKeys.VK_S;
						break;
					case 't':
						key = VKeys.VK_T;
						break;
					case 'u':
						key = VKeys.VK_U;
						break;
					case 'v':
						key = VKeys.VK_V;
						break;
					case 'w':
						key = VKeys.VK_W;
						break;
					case 'x':
						key = VKeys.VK_X;
						break;
					case 'y':
						key = VKeys.VK_Y;
						break;
					case 'z':
						key = VKeys.VK_Z;
						break;
					}
					break;
				}
				AutoControl.SendKeyBoardPress(handle, key);
				Thread.Sleep(TimeSpan.FromSeconds((double)delay));
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000A6F4 File Offset: 0x000088F4
		public static void SendKeyBoardUp(IntPtr handle, VKeys key)
		{
			AutoControl.PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
			AutoControl.PostMessage(handle, 257, new IntPtr((int)key), new IntPtr(0));
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000A750 File Offset: 0x00008950
		public static void SendKeyChar(IntPtr handle, VKeys key)
		{
			AutoControl.PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
			AutoControl.PostMessage(handle, 258, new IntPtr((int)key), new IntPtr(0));
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000A750 File Offset: 0x00008950
		public static void SendKeyChar(IntPtr handle, int key)
		{
			AutoControl.PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
			AutoControl.PostMessage(handle, 258, new IntPtr(key), new IntPtr(0));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000A7AC File Offset: 0x000089AC
		public static void SendKeyBoardDown(IntPtr handle, VKeys key)
		{
			AutoControl.PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
			AutoControl.PostMessage(handle, 256, new IntPtr((int)key), new IntPtr(0));
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000A808 File Offset: 0x00008A08
		public static void SendTextKeyBoard(IntPtr handle, string text, float delay = 0.1f)
		{
			foreach (char key in text.ToLower())
			{
				AutoControl.SendKeyChar(handle, (int)key);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000A85C File Offset: 0x00008A5C
		public static void SendKeyFocus(KeyCode key)
		{
			AutoControl.SendKeyPress(key);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000A878 File Offset: 0x00008A78
		public static void SendMultiKeysFocus(KeyCode[] keys)
		{
			foreach (KeyCode keyCode in keys)
			{
				AutoControl.SendKeyDown(keyCode);
			}
			foreach (KeyCode keyCode2 in keys)
			{
				AutoControl.SendKeyUp(keyCode2);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		public static void SendStringFocus(string message)
		{
			Clipboard.SetText(message);
			AutoControl.SendMultiKeysFocus(new KeyCode[]
			{
				KeyCode.CONTROL,
				KeyCode.KEY_V
			});
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000A934 File Offset: 0x00008B34
		public static void SendKeyPress(KeyCode keyCode)
		{
			INPUT input = new INPUT
			{
				Type = 1U
			};
			input.Data.Keyboard = new KEYBDINPUT
			{
				Vk = (ushort)keyCode,
				Scan = 0,
				Flags = 0U,
				Time = 0U,
				ExtraInfo = IntPtr.Zero
			};
			INPUT input2 = new INPUT
			{
				Type = 1U
			};
			input2.Data.Keyboard = new KEYBDINPUT
			{
				Vk = (ushort)keyCode,
				Scan = 0,
				Flags = 2U,
				Time = 0U,
				ExtraInfo = IntPtr.Zero
			};
			INPUT[] inputs = new INPUT[]
			{
				input,
				input2
			};
			bool flag = AutoControl.SendInput(2U, inputs, Marshal.SizeOf(typeof(INPUT))) == 0U;
			bool flag2 = flag;
			if (flag2)
			{
				throw new Exception();
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000AA6C File Offset: 0x00008C6C
		public static void SendKeyPressStepByStep(string message, double delay = 0.5)
		{
			for (int i = 0; i < message.Length; i++)
			{
				switch (message[i])
				{
				case '0':
					AutoControl.SendKeyPress(KeyCode.KEY_0);
					break;
				case '1':
					AutoControl.SendKeyPress(KeyCode.KEY_1);
					break;
				case '2':
					AutoControl.SendKeyPress(KeyCode.KEY_2);
					break;
				case '3':
					AutoControl.SendKeyPress(KeyCode.KEY_3);
					break;
				case '4':
					AutoControl.SendKeyPress(KeyCode.KEY_4);
					break;
				case '5':
					AutoControl.SendKeyPress(KeyCode.KEY_5);
					break;
				case '6':
					AutoControl.SendKeyPress(KeyCode.KEY_6);
					break;
				case '7':
					AutoControl.SendKeyPress(KeyCode.KEY_7);
					break;
				case '8':
					AutoControl.SendKeyPress(KeyCode.KEY_8);
					break;
				case '9':
					AutoControl.SendKeyPress(KeyCode.KEY_9);
					break;
				}
				Thread.Sleep(TimeSpan.FromSeconds(delay));
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000ABA0 File Offset: 0x00008DA0
		public static void SendKeyDown(KeyCode keyCode)
		{
			INPUT input = new INPUT
			{
				Type = 1U
			};
			input.Data.Keyboard = default(KEYBDINPUT);
			input.Data.Keyboard.Vk = (ushort)keyCode;
			input.Data.Keyboard.Scan = 0;
			input.Data.Keyboard.Flags = 0U;
			input.Data.Keyboard.Time = 0U;
			input.Data.Keyboard.ExtraInfo = IntPtr.Zero;
			INPUT[] inputs = new INPUT[]
			{
				input
			};
			bool flag = AutoControl.SendInput(1U, inputs, Marshal.SizeOf(typeof(INPUT))) == 0U;
			bool flag2 = flag;
			if (flag2)
			{
				throw new Exception();
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000AC90 File Offset: 0x00008E90
		public static void SendKeyUp(KeyCode keyCode)
		{
			INPUT input = new INPUT
			{
				Type = 1U
			};
			input.Data.Keyboard = default(KEYBDINPUT);
			input.Data.Keyboard.Vk = (ushort)keyCode;
			input.Data.Keyboard.Scan = 0;
			input.Data.Keyboard.Flags = 2U;
			input.Data.Keyboard.Time = 0U;
			input.Data.Keyboard.ExtraInfo = IntPtr.Zero;
			INPUT[] inputs = new INPUT[]
			{
				input
			};
			bool flag = AutoControl.SendInput(1U, inputs, Marshal.SizeOf(typeof(INPUT))) == 0U;
			bool flag2 = flag;
			if (flag2)
			{
				throw new Exception();
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000AD80 File Offset: 0x00008F80
		public static void MouseClick(int x, int y, EMouseKey mouseKey = EMouseKey.LEFT)
		{
			Cursor.Position = new Point(x, y);
			AutoControl.Click(mouseKey);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		public static void MouseDragX(Point startPoint, int deltaX, bool isNegative = false)
		{
			Cursor.Position = startPoint;
			AutoControl.mouse_event(2U, 0, 0, 0, UIntPtr.Zero);
			for (int i = 0; i < deltaX; i++)
			{
				bool flag = !isNegative;
				bool flag2 = flag;
				if (flag2)
				{
					AutoControl.mouse_event(1U, 1, 0, 0, UIntPtr.Zero);
				}
				else
				{
					AutoControl.mouse_event(1U, -1, 0, 0, UIntPtr.Zero);
				}
			}
			AutoControl.mouse_event(32772U, 0, 0, 0, UIntPtr.Zero);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000AE90 File Offset: 0x00009090
		public static void MouseDragY(Point startPoint, int deltaY, bool isNegative = false)
		{
			Cursor.Position = startPoint;
			AutoControl.mouse_event(2U, 0, 0, 0, UIntPtr.Zero);
			for (int i = 0; i < deltaY; i++)
			{
				bool flag = !isNegative;
				bool flag2 = flag;
				if (flag2)
				{
					AutoControl.mouse_event(1U, 0, 1, 0, UIntPtr.Zero);
				}
				else
				{
					AutoControl.mouse_event(1U, 0, -1, 0, UIntPtr.Zero);
				}
			}
			AutoControl.mouse_event(32772U, 0, 0, 0, UIntPtr.Zero);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000AF6C File Offset: 0x0000916C
		public static void MouseScroll(Point startPoint, int deltaY, bool isNegative = false)
		{
			Cursor.Position = startPoint;
			AutoControl.mouse_event(2048U, 0, 0, deltaY, UIntPtr.Zero);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public static void MouseClick(Point point, EMouseKey mouseKey = EMouseKey.LEFT)
		{
			Cursor.Position = point;
			AutoControl.Click(mouseKey);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000AFD0 File Offset: 0x000091D0
		public static void Click(EMouseKey mouseKey = EMouseKey.LEFT)
		{
			switch (mouseKey)
			{
			case EMouseKey.LEFT:
				AutoControl.mouse_event(32774U, 0, 0, 0, UIntPtr.Zero);
				break;
			case EMouseKey.RIGHT:
				AutoControl.mouse_event(32792U, 0, 0, 0, UIntPtr.Zero);
				break;
			case EMouseKey.DOUBLE_LEFT:
				AutoControl.mouse_event(32774U, 0, 0, 0, UIntPtr.Zero);
				AutoControl.mouse_event(32774U, 0, 0, 0, UIntPtr.Zero);
				break;
			case EMouseKey.DOUBLE_RIGHT:
				AutoControl.mouse_event(32792U, 0, 0, 0, UIntPtr.Zero);
				AutoControl.mouse_event(32792U, 0, 0, 0, UIntPtr.Zero);
				break;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000B0D0 File Offset: 0x000092D0
		public static RECT GetWindowRect(IntPtr hWnd)
		{
			RECT result = default(RECT);
			AutoControl.GetWindowRect(hWnd, ref result);
			return result;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000B0FC File Offset: 0x000092FC
		public static Point GetGlobalPoint(IntPtr hWnd, Point? point = null)
		{
			Point result = default(Point);
			RECT windowRect = AutoControl.GetWindowRect(hWnd);
			bool flag = point == null;
			bool flag2 = flag;
			if (flag2)
			{
				point = new Point?(default(Point));
			}
			result.X = point.Value.X + windowRect.Left;
			result.Y = point.Value.Y + windowRect.Top;
			return result;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public static Point GetGlobalPoint(IntPtr hWnd, int x = 0, int y = 0)
		{
			Point result = default(Point);
			RECT windowRect = AutoControl.GetWindowRect(hWnd);
			result.X = x + windowRect.Left;
			result.Y = y + windowRect.Top;
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000B1F4 File Offset: 0x000093F4
		public static string GetText(IntPtr hWnd)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			AutoControl.GetWindowText(hWnd, stringBuilder, 256);
			return stringBuilder.ToString().Trim();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000B234 File Offset: 0x00009434
		public static string GetClassName(IntPtr hWnd)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			AutoControl.GetClassName(hWnd, stringBuilder, 256);
			return stringBuilder.ToString().Trim();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000B274 File Offset: 0x00009474
		public static IntPtr MakeLParam(int LoWord, int HiWord)
		{
			return (IntPtr)(HiWord << 16 | (LoWord & 65535));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000B2A8 File Offset: 0x000094A8
		public static IntPtr MakeLParamFromXY(int x, int y)
		{
			return (IntPtr)(y << 16 | x);
		}

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000109 RID: 265
		public delegate bool CallBack(IntPtr hwnd, IntPtr lParam);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600010D RID: 269
		private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr lParam);

		// Token: 0x02000034 RID: 52
		[Flags]
		public enum MouseEventFlags : uint
		{
			// Token: 0x040001CB RID: 459
			LEFTDOWN = 2U,
			// Token: 0x040001CC RID: 460
			LEFTUP = 4U,
			// Token: 0x040001CD RID: 461
			MIDDLEDOWN = 32U,
			// Token: 0x040001CE RID: 462
			MIDDLEUP = 64U,
			// Token: 0x040001CF RID: 463
			MOVE = 1U,
			// Token: 0x040001D0 RID: 464
			ABSOLUTE = 32768U,
			// Token: 0x040001D1 RID: 465
			RIGHTDOWN = 8U,
			// Token: 0x040001D2 RID: 466
			RIGHTUP = 16U,
			// Token: 0x040001D3 RID: 467
			WHEEL = 2048U,
			// Token: 0x040001D4 RID: 468
			XDOWN = 128U,
			// Token: 0x040001D5 RID: 469
			XUP = 256U,
			// Token: 0x040001D6 RID: 470
			XBUTTON1 = 1U,
			// Token: 0x040001D7 RID: 471
			XBUTTON2 = 2U
		}
	}
}
