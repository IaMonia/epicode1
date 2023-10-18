using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using AutoPico;
using AutoPico.Activador;
using AutoPico.Activador.Keys;
using AutoPico.Activador.WMI;
using AutoPico.FakeClient;
using AutoPico.KMS;
using AutoPico.KMSEmulator;
using AutoPico.Logging;
using AutoPico.My;
using AutoPico.Network;
using AutoPico.Patcher;
using AutoPico.RPC;
using AutoPico.RPC.Request;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using NetFwTypeLib;
using Vestris.ResourceLib;

[assembly: AssemblyCopyright("")]
[assembly: ComVisible(false)]
[assembly: AssemblyCompany("@ByELDI")]
[assembly: AssemblyTrademark("")]
[assembly: Guid("892d5768-497e-4232-a15c-fa9f29e06a03")]
[assembly: AssemblyFileVersion("15.0.0.7")]
[assembly: TargetFramework(".NETFramework,Version=v4.0,Profile=Client", FrameworkDisplayName = ".NET Framework 4 Client Profile")]
[assembly: AssemblyProduct("AutoPico")]
[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyTitle("AutoPico")]
[assembly: AssemblyDescription("Portable")]
[assembly: AssemblyVersion("15.0.0.7")]
namespace AutoPico.Activador
{
	public class Activador
	{
		[CompilerGenerated]
		internal sealed class Class0
		{
			public Variables variables_0;

			internal void method_0()
			{
				smethod_2(ref variables_0);
			}

			internal void method_1()
			{
				smethod_3(ref variables_0);
			}

			internal void method_2()
			{
				smethod_4(ref variables_0);
			}

			internal void method_3()
			{
				smethod_5(ref variables_0);
			}
		}

		internal static void smethod_0(ref Variables variables_0)
		{
			if (variables_0.IsWindowsChecked.Value && variables_0.IsOffice2016Checked.Value && variables_0.IsOffice2013Checked.Value && variables_0.IsOffice2010Checked.Value && !variables_0.ActivadorIniciado && !variables_0.IsPaused)
			{
				variables_0.IsGui = false;
				variables_0.ActivadorIniciado = true;
				smethod_1(ref variables_0);
			}
		}

		private static void smethod_1(ref Variables variables_0)
		{
			Variables variables_ = variables_0;
			new Thread((ThreadStart)delegate
			{
				smethod_2(ref variables_);
			}).Start();
			new Thread((ThreadStart)delegate
			{
				smethod_3(ref variables_);
			}).Start();
			new Thread((ThreadStart)delegate
			{
				smethod_4(ref variables_);
			}).Start();
			new Thread((ThreadStart)delegate
			{
				smethod_5(ref variables_);
			}).Start();
		}

		internal static void smethod_2(ref Variables variables_0)
		{
			if (variables_0.IsWindowsActivable.Value && !variables_0.IsWindowsListo.Value)
			{
				FileLogger logger = variables_0.Logger;
				string message = "Activating Windows";
				logger.LogMessage(ref message);
				new Class17().method_0(ref variables_0, ref variables_0.ColeccionWindowsActivable);
			}
		}

		internal static void smethod_3(ref Variables variables_0)
		{
			if (!variables_0.IsOffice2016Activable.Value || variables_0.IsOffice2016Listo.Value)
			{
				return;
			}
			FileLogger logger = variables_0.Logger;
			string message = "Activating Office 2016";
			logger.LogMessage(ref message);
			Class17 @class = new Class17();
			if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
			{
				if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
				{
					List<OfficeSoftwareProtectionProduct> list_ = variables_0.ColeccionOffice2016W7;
					@class.method_1(ref variables_0, ref list_);
				}
			}
			else
			{
				List<SoftwareLicensingProduct> list_2 = variables_0.ColeccionOffice2016W8;
				@class.method_0(ref variables_0, ref list_2);
			}
		}

		internal static void smethod_4(ref Variables variables_0)
		{
			if (!variables_0.IsOffice2013Activable.Value || variables_0.IsOffice2013Listo.Value)
			{
				return;
			}
			FileLogger logger = variables_0.Logger;
			string message = "Activating Office 2013";
			logger.LogMessage(ref message);
			Class17 @class = new Class17();
			if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
			{
				if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
				{
					List<OfficeSoftwareProtectionProduct> list_ = variables_0.ColeccionOffice2013W7;
					@class.method_1(ref variables_0, ref list_);
				}
			}
			else
			{
				List<SoftwareLicensingProduct> list_2 = variables_0.ColeccionOffice2013W8;
				@class.method_0(ref variables_0, ref list_2);
			}
		}

		internal static void smethod_5(ref Variables variables_0)
		{
			if (variables_0.IsOffice2010Activable.Value && !variables_0.IsOffice2010Listo.Value)
			{
				FileLogger logger = variables_0.Logger;
				string message = "Activating Office 2010";
				logger.LogMessage(ref message);
				new Class17().method_1(ref variables_0, ref variables_0.ColeccionOffice2010);
			}
		}
	}
}
internal class Class1
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _Closure$__3<$CLS0>
	{
		public static readonly _Closure$__3<$CLS0> $I;

		public static Func<$CLS0[], int> $I3-0;

		static _Closure$__3()
		{
			$I = new _Closure$__3<$CLS0>();
		}

		internal int method_0($CLS0[] gparam_0)
		{
			return gparam_0.Length;
		}
	}

	public static T[] smethod_0<T>(T[] gparam_0, T[] gparam_1)
	{
		T[] array = new T[checked(gparam_0.Length + (gparam_1.Length - 1) + 1)];
		Buffer.BlockCopy(gparam_0, 0, array, 0, gparam_0.Length);
		Buffer.BlockCopy(gparam_1, 0, array, gparam_0.Length, gparam_1.Length);
		return array;
	}

	public static T[] smethod_1<T>(T[] gparam_0, T[] gparam_1, T[] gparam_2)
	{
		checked
		{
			T[] array = new T[gparam_0.Length + gparam_1.Length + (gparam_2.Length - 1) + 1];
			Buffer.BlockCopy(gparam_0, 0, array, 0, gparam_0.Length);
			Buffer.BlockCopy(gparam_1, 0, array, gparam_0.Length, gparam_1.Length);
			Buffer.BlockCopy(gparam_2, 0, array, gparam_0.Length + gparam_1.Length, gparam_2.Length);
			return array;
		}
	}

	public static T[] smethod_2<T>(params T[][] gparam_0)
	{
		checked
		{
			T[] array = new T[Enumerable.Sum<T[]>((IEnumerable<T[]>)gparam_0, (_Closure$__3<T>.$I3-0 != null) ? _Closure$__3<T>.$I3-0 : (_Closure$__3<T>.$I3-0 = (T[] gparam_0) => gparam_0.Length)) - 1 + 1];
			int num = 0;
			foreach (T[] array2 in gparam_0)
			{
				Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			return array;
		}
	}

	public static bool smethod_3(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0 == byte_1)
		{
			return true;
		}
		checked
		{
			if (byte_0 != null && byte_1 != null)
			{
				if (byte_0.Length != byte_1.Length)
				{
					return false;
				}
				int num = byte_0.Length - 1;
				int num2 = 0;
				while (true)
				{
					if (num2 <= num)
					{
						if (byte_0[num2] != byte_1[num2])
						{
							break;
						}
						num2++;
						continue;
					}
					return true;
				}
				return false;
			}
			return false;
		}
	}
}
internal class Class2
{
	private static Random random_0;

	private static StaticLocalInitFlag staticLocalInitFlag_0;

	internal static string[] smethod_0(ref Variables variables_0, ref string string_0, string string_1 = null)
	{
		string[] array = new string[2];
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = arrayList;
		if (string_1 != null)
		{
			arrayList2.Add(string_1);
		}
		else
		{
			arrayList2.Add(variables_0.DirectorioActual);
			arrayList2.Add(((ServerComputer)Class79.smethod_0()).get_FileSystem().get_CurrentDirectory());
			if (variables_0.IsServer)
			{
				arrayList2.Add(variables_0.SystemRoot + "\\Sysnative");
			}
			arrayList2.Add(variables_0.SystemRoot + "\\System32");
			arrayList2.Add(variables_0.SystemRoot);
			arrayList2.Add(Environment.GetEnvironmentVariable("ProgramFiles") + "\\KMSpico");
			arrayList2.Add(Environment.GetEnvironmentVariable("ProgramFiles") + "\\KMSpico\\driver");
			arrayList2.Add(variables_0.SystemRoot + "\\SysWOW64");
		}
		arrayList2 = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = arrayList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text = Conversions.ToString(enumerator.Current);
				string text2 = ((!text.EndsWith("\\")) ? (text + "\\" + string_0) : (text + string_0));
				if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text2))
				{
					array[0] = text;
					array[1] = string_0;
					return array;
				}
			}
			return array;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	internal static bool smethod_1(ref string string_0, ref bool bool_0, ref Variables variables_0, ref bool bool_1 = true)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		checked
		{
			try
			{
				ServiceController val = null;
				ServiceController[] services = ServiceController.GetServices();
				for (int i = 0; i < services.Length; i++)
				{
					val = services[i];
					if (string.Equals(val.get_ServiceName(), string_0))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					ServiceController[] devices = ServiceController.GetDevices();
					for (int j = 0; j < devices.Length; j++)
					{
						val = devices[j];
						if (string.Equals(val.get_ServiceName(), string_0))
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					if (val != null)
					{
						ServiceControllerStatus status;
						if (bool_0)
						{
							status = val.get_Status();
							if (!((Enum)(ServiceControllerStatus)(ref status)).Equals((object)(ServiceControllerStatus)1))
							{
								status = val.get_Status();
								if (!((Enum)(ServiceControllerStatus)(ref status)).Equals((object)(ServiceControllerStatus)3))
								{
									return flag;
								}
							}
							val.Start();
							if (bool_1)
							{
								val.WaitForStatus((ServiceControllerStatus)4);
								return flag;
							}
							return flag;
						}
						status = val.get_Status();
						if (!((Enum)(ServiceControllerStatus)(ref status)).Equals((object)(ServiceControllerStatus)1))
						{
							status = val.get_Status();
							if (!((Enum)(ServiceControllerStatus)(ref status)).Equals((object)(ServiceControllerStatus)3))
							{
								if (val.get_CanStop())
								{
									val.Stop();
									if (bool_1)
									{
										val.WaitForStatus((ServiceControllerStatus)1);
										return flag;
									}
									return flag;
								}
								return flag;
							}
							return flag;
						}
						return flag;
					}
					return flag;
				}
				return flag;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + smethod_4(ref exception_);
				FileLogger logger = variables_0.Logger;
				string message = "Error: " + str;
				logger.LogMessage(ref message);
				ProjectData.ClearProjectError();
				return flag;
			}
		}
	}

	internal static int smethod_2(int int_0, int int_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (staticLocalInitFlag_0 == null)
		{
			Interlocked.CompareExchange(ref staticLocalInitFlag_0, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(staticLocalInitFlag_0, ref lockTaken);
			if (staticLocalInitFlag_0.State == 0)
			{
				staticLocalInitFlag_0.State = 2;
				random_0 = new Random(DateTime.Now.Millisecond);
			}
			else if (staticLocalInitFlag_0.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			staticLocalInitFlag_0.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(staticLocalInitFlag_0);
			}
		}
		return random_0.Next(int_0, int_1);
	}

	internal static int smethod_3(ref Variables variables_0)
	{
		FileLogger logger = variables_0.Logger;
		string message = "Looking Office 2013 Missing keys...";
		logger.LogMessage(ref message);
		int num = 0;
		checked
		{
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"WINWORD.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"POWERPNT.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"OUTLOOK.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"INFOPATH.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"GROOVE.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"EXCEL.EXE"))))
			{
				num++;
			}
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"VISIO.EXE"))))
			{
				num++;
			}
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"WINPROJ.EXE"))))
			{
				num++;
			}
			return num;
		}
	}

	internal static string smethod_4(ref Exception exception_0)
	{
		string result = "Unknown";
		StackTrace stackTrace = new StackTrace(exception_0);
		checked
		{
			int num = stackTrace.FrameCount - 1;
			for (int i = 0; i <= num; i++)
			{
				MethodBase method = stackTrace.GetFrame(i)!.GetMethod();
				if (method.DeclaringType!.Assembly == Assembly.GetExecutingAssembly())
				{
					result = method.Name;
					break;
				}
			}
			return result;
		}
	}

	internal static string smethod_5(string string_0)
	{
		string result = string.Empty;
		int length = string_0.Length;
		if (length > 6)
		{
			result = string_0.Substring(checked(length - 6));
		}
		return result;
	}

	internal static string smethod_6()
	{
		string location = Assembly.GetEntryAssembly()!.Location;
		return location.Substring(0, location.LastIndexOf('\\'));
	}

	internal static byte[] smethod_7(ref string string_0, ref ILogger ilogger_0)
	{
		byte[] result = null;
		try
		{
			result = SoapHexBinary.Parse(string_0).get_Value();
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + smethod_4(ref exception_);
			ILogger obj = ilogger_0;
			string message = "Error: " + str;
			obj.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static string smethod_8(ref byte[] byte_0, ref ILogger ilogger_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		string result = string.Empty;
		try
		{
			result = new SoapHexBinary(byte_0).ToString();
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + smethod_4(ref exception_);
			ILogger obj = ilogger_0;
			string message = "Error: " + str;
			obj.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
internal class Class3
{
	[CompilerGenerated]
	internal sealed class Class4
	{
		public Variables variables_0;

		internal void method_0()
		{
			smethod_11(ref variables_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class5
	{
		public Variables variables_0;

		internal void method_0()
		{
			Class15.smethod_0(ref variables_0);
		}

		internal void method_1()
		{
			Class15.smethod_0(ref variables_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class6
	{
		public Variables variables_0;

		internal void method_0()
		{
			Class56.smethod_1(ref variables_0);
		}

		internal void method_1()
		{
			Class56.smethod_1(ref variables_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class7
	{
		public Variables variables_0;

		internal void method_0()
		{
			smethod_23(ref variables_0);
		}
	}

	internal static void smethod_0(ref Variables variables_0)
	{
		TCP.smethod_2(ref variables_0);
		smethod_25(ref variables_0);
		smethod_24(ref variables_0, ref variables_0.AudioBegin);
		Class10.smethod_11(ref variables_0);
		if (variables_0.IsPreview && !variables_0.IsGui)
		{
			if (variables_0.IsWaterMarkRemove)
			{
				Class12.smethod_0(ref variables_0);
			}
			else if (variables_0.IsWaterMarkRestore)
			{
				Class12.smethod_1(ref variables_0);
			}
			else
			{
				variables_0.WaterMarkBasebrd = true;
				variables_0.WaterMarkShell32 = true;
			}
		}
		smethod_7(ref variables_0);
		Check.smethod_0(ref variables_0);
		if (variables_0.IsBackup)
		{
			bool bool_ = false;
			Backup.smethod_0(ref bool_, ref variables_0);
		}
		Check.smethod_1(ref variables_0);
	}

	internal static void smethod_1(ref string[] string_0, ref ArrayList arrayList_0, ref Variables variables_0, ref bool bool_0 = false)
	{
		Class9 @class = new Class9(string_0, arrayList_0);
		Process val = @class.method_3();
		if (string.IsNullOrEmpty(@class.method_5()))
		{
			return;
		}
		val.Start();
		if (!bool_0)
		{
			return;
		}
		while (!val.get_StandardOutput().EndOfStream)
		{
			string message = val.get_StandardOutput().ReadLine();
			if (!string.IsNullOrEmpty(message))
			{
				variables_0.Logger.LogMessage(ref message);
			}
		}
		val.WaitForExit();
	}

	internal static void smethod_2(ref int int_0, ref string[] string_0, ref Variables variables_0)
	{
		if (!TCP.smethod_1(ref int_0, ref variables_0))
		{
			return;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add("-ano");
		Process val = new Class9(string_0, arrayList).method_3();
		val.set_EnableRaisingEvents(true);
		string empty = string.Empty;
		try
		{
			val.Start();
			string[] array = null;
			while (!val.get_StandardOutput().EndOfStream)
			{
				empty = val.get_StandardOutput().ReadLine();
				if (!string.IsNullOrEmpty(empty) && empty.Contains(":" + Conversions.ToString(int_0) + " "))
				{
					array = Regex.Split(empty, "LISTENING");
					break;
				}
			}
			if (array != null && Enumerable.Count<string>((IEnumerable<string>)array) == 2)
			{
				Process processById = Process.GetProcessById(Conversions.ToInteger(array[1].Trim()));
				if (!processById.get_ProcessName().ToLower().Contains("spp"))
				{
					processById.Kill();
					Thread.Sleep(Class2.smethod_2(50, 600));
					variables_0.IsSecohQad.Value = true;
				}
				else
				{
					variables_0.IsWinDivert.Value = true;
					variables_0.IsSecohQad.Value = false;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_3(ref string string_0, ref Variables variables_0)
	{
		try
		{
			Process.GetProcessById(Conversions.ToInteger(string_0)).Kill();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_4(ref string string_0, ref Variables variables_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			foreach (Process val in processesByName)
			{
				FileLogger logger = variables_0.Logger;
				string message = "Killing: " + val.get_ProcessName();
				logger.LogMessage(ref message);
				val.Kill();
				val.WaitForExit();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_5(ref string string_0, ref Variables variables_0)
	{
		if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_0))
		{
			return;
		}
		checked
		{
			try
			{
				ReadOnlyCollection<string> directories = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetDirectories(string_0, (SearchOption)2, new string[0]);
				if (directories.Count > 0)
				{
					int num = directories.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							((ServerComputer)Class79.smethod_0()).get_FileSystem().DeleteDirectory(directories[i], (UIOption)5, (RecycleOption)2, (UICancelOption)2);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception exception_ = ex;
							string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
							FileLogger logger = variables_0.Logger;
							string message = "Error: " + str;
							logger.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
					}
				}
				directories = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)2, new string[1]
				{
					"*.*"
				});
				if (directories.Count <= 0)
				{
					return;
				}
				int num2 = directories.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					try
					{
						((ServerComputer)Class79.smethod_0()).get_FileSystem().DeleteFile(directories[j], (UIOption)2, (RecycleOption)2, (UICancelOption)2);
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception exception_2 = ex2;
						string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
						FileLogger logger2 = variables_0.Logger;
						string message = "Error: " + str2;
						logger2.LogMessage(ref message);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void smethod_6(ref Variables variables_0)
	{
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (variables_0.IsPreview && (!variables_0.WaterMarkBasebrd || !variables_0.WaterMarkShell32))
			{
				FileLogger logger = variables_0.Logger;
				string message = "WaterMark function working...";
				logger.LogMessage(ref message);
			}
			else
			{
				if (variables_0.IsWindowsListo.Value && variables_0.IsOffice2010Listo.Value && variables_0.IsOffice2013Listo.Value && variables_0.IsOffice2016Listo.Value)
				{
					if (variables_0.Closing)
					{
						return;
					}
					variables_0.Closing = true;
					bool bool_ = false;
					string message = ((ApplicationBase)Class79.smethod_1()).get_Info().get_AssemblyName() + ".exe";
					string[] string_ = Class2.smethod_0(ref variables_0, ref message);
					Firewall.smethod_0(ref variables_0, ref bool_, ref string_);
					Class10.smethod_10(ref variables_0);
					smethod_24(ref variables_0, ref variables_0.AudioComplete);
					smethod_12(ref variables_0);
					if (variables_0.IsWindows10 || variables_0.IsWindows81)
					{
						try
						{
							if (variables_0.IsSecohQadLoaded)
							{
								Class11.smethod_1(bool_0: false, ref variables_0);
								message = "SECOH-QAD";
								smethod_4(ref message, ref variables_0);
							}
							if (variables_0.IsWinDivertLoaded)
							{
								Class15.smethod_1(ref variables_0);
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					DateTime tiempo = variables_0.Tiempo;
					variables_0.Tiempo = DateAndTime.get_Now();
					FileLogger logger2 = variables_0.Logger;
					message = "Time Finish: " + variables_0.Tiempo;
					logger2.LogMessage(ref message);
					FileLogger logger3 = variables_0.Logger;
					message = "Total Time: " + Conversions.ToString(DateAndTime.DateDiff((DateInterval)9, tiempo, variables_0.Tiempo, (FirstDayOfWeek)1, (FirstWeekOfYear)1)) + " seconds";
					logger3.LogMessage(ref message);
					if (!variables_0.IsGui)
					{
						if (variables_0.RunAsService)
						{
							return;
						}
						if (Path.GetFileName(Application.get_ExecutablePath())!.Contains("KMSELDI"))
						{
							if (!variables_0.IsWindowsActivable.Value && !variables_0.IsOffice2016Activable.Value && !variables_0.IsOffice2013Activable.Value && !variables_0.IsOffice2010Activable.Value)
							{
								variables_0.ShowMessage.Show("There is nothing to do here", "I am leaving", IFrmShowMessage.enumMessageIcon.Information, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
							}
							variables_0.iactivateMetroForm_0.CloseFormSegura();
						}
						ProjectData.EndApp();
					}
					else if (Path.GetFileName(Application.get_ExecutablePath())!.Contains("KMSELDI") && !variables_0.IsWindowsActivable.Value && !variables_0.IsOffice2016Activable.Value && !variables_0.IsOffice2013Activable.Value && !variables_0.IsOffice2010Activable.Value)
					{
						variables_0.ShowMessage.Show("There is nothing to do here", "I am leaving", IFrmShowMessage.enumMessageIcon.Information, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
						variables_0.iactivateMetroForm_0.CloseFormSegura();
					}
					return;
				}
				Activador.smethod_0(ref variables_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger4 = variables_0.Logger;
			string message = "Error: " + str;
			logger4.LogMessage(ref message);
			Process.GetCurrentProcess().Kill();
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_7(ref Variables variables_0)
	{
		variables_0.ServersOnline = new HostServer[5]
		{
			new HostServer("kms.digiboy.ir", 1688u),
			new HostServer("zh.us.to", 1688u),
			new HostServer("skms.ddns.net", 1688u),
			new HostServer("110.noip.me", 1688u),
			new HostServer("3rss.vicp.net", 20439u)
		};
		checked
		{
			string message;
			while (true)
			{
				HostServer kmsHostForward;
				int int_ = (int)(kmsHostForward = variables_0.KmsHostForward).Port;
				bool num = TCP.smethod_1(ref int_, ref variables_0);
				kmsHostForward.Port = (uint)int_;
				if (!num)
				{
					break;
				}
				FileLogger logger = variables_0.Logger;
				message = "Port: " + Conversions.ToString(variables_0.KmsHostForward.Port) + " is used, changing...";
				logger.LogMessage(ref message);
				variables_0.KmsHostForward.Port = (uint)(unchecked((long)variables_0.KmsHostForward.Port) + 1L);
			}
			variables_0.KmsHostLocal.Port = variables_0.KmsHostForward.Port;
			variables_0.KmsHostForward.ResetIpForward();
			variables_0.KmsHostLocal.ResetIpLocal();
			bool bool_ = true;
			message = ((ApplicationBase)Class79.smethod_1()).get_Info().get_AssemblyName() + ".exe";
			string[] string_ = Class2.smethod_0(ref variables_0, ref message);
			Firewall.smethod_0(ref variables_0, ref bool_, ref string_);
			smethod_10(ref variables_0);
		}
	}

	internal static void smethod_8(ref Variables variables_0)
	{
		checked
		{
			int num = Enumerable.Count<string>((IEnumerable<string>)variables_0.ArgumentosConsola) - 1;
			for (int i = 0; i <= num; i++)
			{
				if (string.Equals(variables_0.ArgumentosConsola[i].ToLower(), "/silent"))
				{
					variables_0.IsSilent = true;
				}
				if (string.Equals(variables_0.ArgumentosConsola[i].ToLower(), "/backup"))
				{
					variables_0.IsBackup = true;
				}
				if (string.Equals(variables_0.ArgumentosConsola[i].ToLower(), "/status"))
				{
					variables_0.IsCheckStatus = true;
				}
				if (string.Equals(variables_0.ArgumentosConsola[i].ToLower(), "/removewatermark"))
				{
					variables_0.IsWaterMarkRemove = true;
				}
				if (string.Equals(variables_0.ArgumentosConsola[i].ToLower(), "/restorewatermark"))
				{
					variables_0.IsWaterMarkRestore = true;
				}
				if (string.Equals(variables_0.ArgumentosConsola[i].ToLower(), "/?"))
				{
					FileLogger logger = variables_0.Logger;
					string message = "/silent : Run in Silent Mode\r/backup : Make a tokens backup\r/status : Check current activation status\r/removewatermark : Remove watermark in previews editions\r/restorewatermark : Remove watermark in previews editions\r/? This Help";
					logger.LogMessage(ref message);
				}
			}
		}
	}

	internal static void smethod_9(ref Variables variables_0)
	{
		if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(variables_0.DirectorioActual + "\\sounds"))
		{
			variables_0.PlaySound = true;
			string text = variables_0.DirectorioActual + "\\sounds\\verified.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioVerified = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\complete.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioComplete = new AudioFile(text);
				variables_0.AudioComplete.Wait = true;
			}
			text = variables_0.DirectorioActual + "\\sounds\\transfer.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioTransfer = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\begin.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioBegin = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\diagnostic.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioDiagnostic = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\warning.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioWarning = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\affirmative.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioAffirmative = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\incomingtransmission.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioIncomingTransmission = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\enterauthorizationcode.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioEnterAuthorizationCode = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\inputok.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioInputOk = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\inputfailed.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioInputFailed = new AudioFile(text);
			}
			text = variables_0.DirectorioActual + "\\sounds\\processing.mp3";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(text))
			{
				variables_0.AudioProcessing = new AudioFile(text);
			}
		}
	}

	internal static void smethod_10(ref Variables variables_0)
	{
		Variables variables_ = variables_0;
		new Thread((ThreadStart)delegate
		{
			smethod_11(ref variables_);
		}).Start();
	}

	private static void smethod_11(ref Variables variables_0)
	{
		try
		{
			FileLogger logger = variables_0.Logger;
			string message = "KMSEmulator Port: " + variables_0.KmsHostForward.Port;
			logger.LogMessage(ref message);
			KMSServerSettings settings = new KMSServerSettings
			{
				CurrentClientCount = 50u,
				DefaultKMSPID = "05426-00206-152-252649-03-1049-9200.0000-3192012",
				GenerateRandomKMSPID = true,
				Port = checked((int)variables_0.KmsHostForward.Port),
				VLActivationInterval = 43200u,
				VLRenewalInterval = 43200u,
				KillProcessOnPort = false
			};
			KMSServer.Start(ref variables_0, settings);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_12(ref Variables variables_0)
	{
		try
		{
			KMSServer.Stop(ref variables_0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_13(ref bool bool_0, ref bool bool_1, ref bool bool_2, ref Variables variables_0)
	{
		string empty = string.Empty;
		FileLogger logger = variables_0.Logger;
		string message = "One o more Office 2013 keys are not found...";
		logger.LogMessage(ref message);
		if (!bool_0 && (((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"WINWORD.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"POWERPNT.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"OUTLOOK.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"INFOPATH.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"GROOVE.EXE"))) || ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"EXCEL.EXE")))))
		{
			empty = "OfficeProPlus";
			FileLogger logger2 = variables_0.Logger;
			message = "Please reinstall: " + empty;
			logger2.LogMessage(ref message);
		}
		if (!bool_1 && ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"VISIO.EXE"))))
		{
			empty = "OfficeVisioPro";
			FileLogger logger3 = variables_0.Logger;
			message = "Please reinstall: " + empty;
			logger3.LogMessage(ref message);
		}
		if (!bool_2 && ((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(Conversions.ToString(Operators.ConcatenateObject(variables_0.RutaOffice2013, (object)"WINPROJ.EXE"))))
		{
			empty = "OfficeProjectPro";
			FileLogger logger4 = variables_0.Logger;
			message = "Please reinstall: " + empty;
			logger4.LogMessage(ref message);
		}
	}

	internal static void smethod_14(ref Variables variables_0, ref int int_0)
	{
		if (variables_0.iactivateMetroForm_0 != null)
		{
			variables_0.iactivateMetroForm_0.SetCircularProgressSegura(value: true, 33, reset: false);
		}
	}

	internal static void smethod_15(ref Variables variables_0, ref string string_0)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		smethod_24(ref variables_0, ref variables_0.AudioWarning);
		if (variables_0.IsGui)
		{
			variables_0.ShowMessage.Show("This product: " + string_0 + " .It is not supported for this KMS activation", "No lucky", IFrmShowMessage.enumMessageIcon.Warning, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
		}
	}

	private static void smethod_16(ref Variables variables_0, ref HostServer hostServer_0 = null)
	{
		if (variables_0.KmsHostForward.IpAddress.StartsWith("127") && hostServer_0 == null)
		{
			variables_0.KmsHostForward.IpAddress = WMINetWorkAdapter.smethod_13();
		}
		Class15.smethod_1(ref variables_0);
		Class11.smethod_0(ref variables_0);
		if (File.Exists(variables_0.SystemRoot + "\\SECOH-QAD.dll") && File.Exists(variables_0.SystemRoot + "\\SECOH-QAD.exe"))
		{
			if (variables_0.IntentosActivacion <= 1)
			{
				if (!variables_0.IsSecohQadLoaded)
				{
					FileLogger logger = variables_0.Logger;
					string message = "Loading SECOH-QAD...";
					logger.LogMessage(ref message);
					Class11.smethod_1(bool_0: true, ref variables_0);
				}
			}
			else
			{
				FileLogger logger2 = variables_0.Logger;
				string message = "Loading SECOH-QAD...";
				logger2.LogMessage(ref message);
				Class11.smethod_1(bool_0: true, ref variables_0);
			}
		}
		else
		{
			Class11.smethod_0(ref variables_0);
			Thread.Sleep(Class2.smethod_2(50, 600));
			HostServer hostServer_ = null;
			smethod_19(ref variables_0, ref hostServer_);
		}
	}

	private static void smethod_17(ref Variables variables_0, ref HostServer hostServer_0 = null)
	{
		if (variables_0.KmsHostForward.IpAddress.StartsWith("127") && hostServer_0 == null)
		{
			variables_0.KmsHostForward.IpAddress = WMINetWorkAdapter.smethod_13();
		}
		variables_0.IsSecohQad.Value = false;
		Class11.smethod_1(bool_0: false, ref variables_0);
		checked
		{
			variables_0.IntentosWinDivert++;
			Class15.smethod_2(ref variables_0);
			if (File.Exists(variables_0.DirectorioActual + "\\WinDivert.dll") && File.Exists(variables_0.DirectorioActual + "\\WinDivert.sys"))
			{
				Variables variables_ = variables_0;
				if (variables_0.IntentosActivacion <= 1)
				{
					if (!variables_0.IsWinDivertLoaded)
					{
						FileLogger logger = variables_0.Logger;
						string message = "Loading WinDivert...";
						logger.LogMessage(ref message);
						message = "WinDivert1.1";
						string string_ = "WinDivert1.1";
						string string_2 = variables_0.DirectorioActual + "\\WinDivert.sys";
						Class15.smethod_4(ref message, ref string_, ref string_2, ref variables_0);
						new Thread((ThreadStart)delegate
						{
							Class15.smethod_0(ref variables_);
						}).Start();
						variables_0.IsWinDivertLoaded = true;
					}
				}
				else
				{
					FileLogger logger2 = variables_0.Logger;
					string string_2 = "Loading WinDivert...";
					logger2.LogMessage(ref string_2);
					string_2 = "WinDivert1.1";
					string string_ = "WinDivert1.1";
					string message = variables_0.DirectorioActual + "\\WinDivert.sys";
					Class15.smethod_4(ref string_2, ref string_, ref message, ref variables_0);
					new Thread((ThreadStart)delegate
					{
						Class15.smethod_0(ref variables_);
					}).Start();
					variables_0.IsWinDivertLoaded = true;
				}
			}
			else
			{
				Class15.smethod_2(ref variables_0);
				Thread.Sleep(Class2.smethod_2(50, 600));
				HostServer hostServer_ = null;
				smethod_19(ref variables_0, ref hostServer_);
			}
		}
	}

	private static void smethod_18(ref Variables variables_0, ref HostServer hostServer_0 = null)
	{
		variables_0.IsSecohQad.Value = false;
		Class11.smethod_1(bool_0: false, ref variables_0);
		variables_0.IsWinDivert.Value = false;
		Class15.smethod_1(ref variables_0);
		if (variables_0.KmsHostForward.IpAddress.StartsWith("127") && hostServer_0 == null)
		{
			variables_0.KmsHostForward.IpAddress = WMINetWorkAdapter.smethod_13();
		}
		checked
		{
			variables_0.IntentosTunTap++;
			if (variables_0.IntentosActivacion > 1)
			{
				return;
			}
			Variables variables_ = variables_0;
			if (!variables_0.IsTapDriverLoaded)
			{
				new Thread((ThreadStart)delegate
				{
					Class56.smethod_1(ref variables_);
				}).Start();
			}
			else
			{
				new Thread((ThreadStart)delegate
				{
					Class56.smethod_1(ref variables_);
				}).Start();
			}
		}
	}

	internal static void smethod_19(ref Variables variables_0, ref HostServer hostServer_0 = null)
	{
		if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
		{
			variables_0.IsSecohQad.Value = false;
			variables_0.IsWinDivert.Value = false;
			variables_0.IsTapDriver.Value = false;
			if (!variables_0.IsOnline.Value)
			{
				if (!variables_0.KmsHostLocal.IpAddress.StartsWith("127"))
				{
					variables_0.KmsHostLocal.ResetIpLocal();
				}
			}
			else if (hostServer_0 == null)
			{
				Variables obj = variables_0;
				obj.KmsHostLocal = obj.ServersOnline[Class2.smethod_2(0, variables_0.ServersOnline.Length)];
			}
			else if (variables_0.IntentosActivacion > 6)
			{
				Variables obj2 = variables_0;
				obj2.KmsHostLocal = obj2.ServersOnline[Class2.smethod_2(0, variables_0.ServersOnline.Length)];
			}
			else
			{
				variables_0.KmsHostLocal = hostServer_0;
			}
			FileLogger logger = variables_0.Logger;
			string message = "Using host: " + variables_0.KmsHostLocal.IpAddress + ":" + Conversions.ToString(variables_0.KmsHostLocal.Port);
			logger.LogMessage(ref message);
			return;
		}
		if (hostServer_0 != null)
		{
			variables_0.KmsHostForward = hostServer_0;
		}
		checked
		{
			if (variables_0.IsSecohQad.Value)
			{
				variables_0.IntentosSecoh++;
				if (variables_0.IntentosSecoh < 8)
				{
					smethod_16(ref variables_0, ref hostServer_0);
				}
				else
				{
					variables_0.IsSecohQad.Value = false;
					if (variables_0.IsSecohQadLoaded)
					{
						Class11.smethod_1(bool_0: false, ref variables_0);
					}
					variables_0.IsWinDivert.Value = true;
					Thread.Sleep(Class2.smethod_2(50, 600));
					HostServer hostServer_ = null;
					smethod_19(ref variables_0, ref hostServer_);
				}
			}
			else if (variables_0.IsWinDivert.Value)
			{
				if (variables_0.IntentosWinDivert < 8)
				{
					smethod_17(ref variables_0, ref hostServer_0);
				}
				else
				{
					variables_0.IsWinDivert.Value = false;
					Class15.smethod_1(ref variables_0);
					variables_0.IsTapDriver.Value = true;
					Thread.Sleep(Class2.smethod_2(50, 600));
					HostServer hostServer_ = null;
					smethod_19(ref variables_0, ref hostServer_);
				}
			}
			else if (variables_0.IsTapDriver.Value)
			{
				if (variables_0.IntentosTunTap < 8)
				{
					smethod_18(ref variables_0, ref hostServer_0);
				}
			}
			else if (variables_0.IsOnline.Value)
			{
				variables_0.IsSecohQad.Value = false;
				Class11.smethod_1(bool_0: false, ref variables_0);
				variables_0.IsWinDivert.Value = false;
				Class15.smethod_1(ref variables_0);
				if (hostServer_0 == null)
				{
					Variables obj3 = variables_0;
					obj3.KmsHostForward = obj3.ServersOnline[Class2.smethod_2(0, variables_0.ServersOnline.Length)];
				}
				else if (variables_0.IntentosActivacion > 6)
				{
					Variables obj4 = variables_0;
					obj4.KmsHostLocal = obj4.ServersOnline[Class2.smethod_2(0, variables_0.ServersOnline.Length)];
				}
				else
				{
					variables_0.KmsHostLocal = hostServer_0;
				}
			}
			FileLogger logger2 = variables_0.Logger;
			string message = "Using host: " + variables_0.KmsHostForward.IpAddress + ":" + Conversions.ToString(variables_0.KmsHostForward.Port);
			logger2.LogMessage(ref message);
			string str = "Online";
			if (variables_0.IsSecohQad.Value)
			{
				str = "SECOH-QAD";
			}
			else if (variables_0.IsWinDivert.Value)
			{
				str = "WinDivert";
			}
			else if (variables_0.IsTapDriver.Value)
			{
				str = "TapDriver";
			}
			FileLogger logger3 = variables_0.Logger;
			message = "Using method: " + str;
			logger3.LogMessage(ref message);
		}
	}

	internal static void smethod_20(ref Variables variables_0)
	{
		checked
		{
			try
			{
				if (variables_0.IsWindows10)
				{
					variables_0.ClientSettings.IPAddress = variables_0.KmsHostForward.IpAddress;
					variables_0.ClientSettings.Port = (int)variables_0.KmsHostForward.Port;
					variables_0.ClientSettings.KMSClientProduct = KMSClientProduct.Windows10;
				}
				else if (variables_0.IsWindows81)
				{
					variables_0.ClientSettings.IPAddress = variables_0.KmsHostForward.IpAddress;
					variables_0.ClientSettings.Port = (int)variables_0.KmsHostForward.Port;
					variables_0.ClientSettings.KMSClientProduct = KMSClientProduct.Windows81;
				}
				else if (variables_0.IsWindows8)
				{
					variables_0.ClientSettings.IPAddress = variables_0.KmsHostLocal.IpAddress;
					variables_0.ClientSettings.Port = (int)variables_0.KmsHostLocal.Port;
					variables_0.ClientSettings.KMSClientProduct = KMSClientProduct.Windows8;
				}
				else if (variables_0.IsWindows7)
				{
					variables_0.ClientSettings.IPAddress = variables_0.KmsHostLocal.IpAddress;
					variables_0.ClientSettings.Port = (int)variables_0.KmsHostLocal.Port;
					variables_0.ClientSettings.KMSClientProduct = KMSClientProduct.Windows7;
				}
				else
				{
					variables_0.ClientSettings.IPAddress = variables_0.KmsHostLocal.IpAddress;
					variables_0.ClientSettings.Port = (int)variables_0.KmsHostLocal.Port;
					variables_0.ClientSettings.KMSClientProduct = KMSClientProduct.Windows;
				}
				new Cliente(variables_0.ClientSettings, variables_0.Logger).Start();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger = variables_0.Logger;
				string message = "Error: " + str;
				logger.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static void smethod_21(ref Variables variables_0, ref bool bool_0)
	{
		checked
		{
			try
			{
				HostServer hostServer = new HostServer();
				hostServer.ResetIpLocal();
				hostServer = ((variables_0.IsWindows10 || variables_0.IsWindows81) ? variables_0.KmsHostForward : variables_0.KmsHostLocal);
				FileLogger logger = variables_0.Logger;
				string message = "Testing Server: " + hostServer.IpAddress + ":" + Conversions.ToString(hostServer.Port) + "...";
				logger.LogMessage(ref message);
				Class24 @class = new Class24(hostServer.IpAddress, (int)hostServer.Port, KMSClientProduct.Windows81);
				int num = 0;
				while (true)
				{
					Class24 class2;
					message = (class2 = @class).AutoPico.KMSEmulator.IKMSClientSettings.IPAddress;
					Class24 class3;
					int int_ = (class3 = @class).AutoPico.KMSEmulator.IKMSClientSettings.Port;
					bool num2 = TCP.smethod_0(ref message, ref int_, ref variables_0);
					class3.AutoPico.KMSEmulator.IKMSClientSettings.Port = int_;
					class2.AutoPico.KMSEmulator.IKMSClientSettings.IPAddress = message;
					if (num2 || num >= 5)
					{
						break;
					}
					Thread.Sleep(Class2.smethod_2(50, 600));
					num++;
				}
				if (num > 4)
				{
					FileLogger logger2 = variables_0.Logger;
					message = "Testing Server Failed: " + hostServer.IpAddress + ":" + Conversions.ToString(hostServer.Port) + "...";
					logger2.LogMessage(ref message);
				}
				else
				{
					new Cliente(@class, variables_0.Logger).Start();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger3 = variables_0.Logger;
				string message = "Error: " + str;
				logger3.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static void smethod_22(ref Variables variables_0, ref KMSClientProduct kmsclientProduct_0)
	{
		checked
		{
			try
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows8)
					{
						variables_0.ClientSettings.IPAddress = variables_0.KmsHostLocal.IpAddress;
						variables_0.ClientSettings.Port = (int)variables_0.KmsHostLocal.Port;
						variables_0.ClientSettings.KMSClientProduct = kmsclientProduct_0;
					}
					else if (variables_0.IsWindows7)
					{
						variables_0.ClientSettings.IPAddress = variables_0.KmsHostLocal.IpAddress;
						variables_0.ClientSettings.Port = (int)variables_0.KmsHostLocal.Port;
						variables_0.ClientSettings.KMSClientProduct = kmsclientProduct_0;
					}
				}
				else
				{
					variables_0.ClientSettings.IPAddress = variables_0.KmsHostForward.IpAddress;
					variables_0.ClientSettings.Port = (int)variables_0.KmsHostForward.Port;
					variables_0.ClientSettings.KMSClientProduct = kmsclientProduct_0;
				}
				Variables variables_ = variables_0;
				new Thread((ThreadStart)delegate
				{
					smethod_23(ref variables_);
				}).Start();
				Thread.Sleep(Class2.smethod_2(50, 600));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger = variables_0.Logger;
				string message = "Error: " + str;
				logger.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static void smethod_23(ref Variables variables_0)
	{
		new Cliente(variables_0.ClientSettings, variables_0.Logger).Start();
	}

	internal static void smethod_24(ref Variables variables_0, ref AudioFile audioFile_0)
	{
		if (variables_0.PlaySound)
		{
			if (variables_0.Sonidos.get_Count() > 1)
			{
				variables_0.Sonidos.Peek().Close();
			}
			variables_0.Sonidos.Push(audioFile_0);
			variables_0.Sonidos.Peek().Play();
		}
	}

	internal static void smethod_25(ref Variables variables_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			variables_0.GObjWmiService = new ManagementScope("\\\\.\\root\\cimv2");
			variables_0.GObjWmiService.Connect();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_26(ref Variables variables_0, ref string string_0)
	{
		bool bool_ = false;
		bool bool_2 = true;
		Class2.smethod_1(ref string_0, ref bool_, ref variables_0, ref bool_2);
		ArrayList arrayList_ = new ArrayList();
		arrayList_.Add("delete \"" + string_0 + "\"");
		string string_ = "sc.exe";
		string[] string_2 = Class2.smethod_0(ref variables_0, ref string_);
		bool_2 = false;
		smethod_1(ref string_2, ref arrayList_, ref variables_0, ref bool_2);
	}

	internal static void smethod_27(ref List<SoftwareLicensingProduct> list_0, ref SoftwareLicensingProduct softwareLicensingProduct_0)
	{
		if (list_0 == null)
		{
			list_0 = new List<SoftwareLicensingProduct>();
		}
		if (!list_0.Contains(softwareLicensingProduct_0))
		{
			list_0.Add(softwareLicensingProduct_0);
		}
	}

	internal static void smethod_28(ref List<OfficeSoftwareProtectionProduct> list_0, ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0)
	{
		if (list_0 == null)
		{
			list_0 = new List<OfficeSoftwareProtectionProduct>();
		}
		if (!list_0.Contains(officeSoftwareProtectionProduct_0))
		{
			list_0.Add(officeSoftwareProtectionProduct_0);
		}
	}
}
internal class Class8
{
	[DllImport("kernel32")]
	private static extern uint EnumSystemFirmwareTables(uint uint_0, IntPtr intptr_0, uint uint_1);

	[DllImport("kernel32")]
	private static extern uint GetSystemFirmwareTable(uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2);

	public bool method_0(ref Variables variables_0)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		string text = variables_0.DirectorioActual + "\\DM.bin";
		try
		{
			if (!File.Exists(text))
			{
				byte[] byte_ = new byte[86];
				string string_ = string.Empty;
				if (method_1(ref byte_, ref variables_0))
				{
					try
					{
						string_ = Encoding.GetEncoding(1252).GetString(count: BitConverter.ToInt32(byte_, 52), bytes: byte_, index: 56);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception exception_ = ex;
						string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
						FileLogger logger = variables_0.Logger;
						string message = "Error: " + str;
						logger.LogMessage(ref message);
						ProjectData.ClearProjectError();
					}
					Regex val = new Regex("^([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})$");
					if (!string.IsNullOrEmpty(string_) & val.IsMatch(string_))
					{
						FileLogger logger2 = variables_0.Logger;
						string text2 = string_;
						string message = "Key found on MSDM: " + text2.Substring(text2.LastIndexOf("-"));
						logger2.LogMessage(ref message);
						bool bool_ = true;
						bool bool_2 = false;
						bool bool_3 = false;
						bool bool_4 = false;
						return Key.smethod_13(ref string_, ref bool_, ref bool_2, ref bool_3, ref bool_4, ref variables_0);
					}
					string_ = Encoding.ASCII.GetString(byte_);
					string_ = string_.Substring(checked(byte_.Length - 29));
					if (!string.IsNullOrEmpty(string_) & val.IsMatch(string_))
					{
						FileLogger logger3 = variables_0.Logger;
						string text3 = string_;
						string message = "Key found on MSDM:: " + text3.Substring(text3.LastIndexOf("-"));
						logger3.LogMessage(ref message);
						bool bool_4 = true;
						bool bool_3 = false;
						bool bool_2 = false;
						bool bool_ = false;
						return Key.smethod_13(ref string_, ref bool_4, ref bool_3, ref bool_2, ref bool_, ref variables_0);
					}
				}
				File.WriteAllText(text, string_);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception exception_2 = ex2;
			string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
			FileLogger logger4 = variables_0.Logger;
			string message = "Error: " + str2;
			logger4.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private bool method_1(ref byte[] byte_0, ref Variables variables_0)
	{
		uint uint_ = 1094930505u;
		uint uint_2 = 1296323405u;
		FileLogger logger = variables_0.Logger;
		string message = "Loading OEM Key Dumper...";
		logger.LogMessage(ref message);
		checked
		{
			try
			{
				uint num = EnumSystemFirmwareTables(uint_, IntPtr.Zero, 0u);
				IntPtr intPtr = Marshal.AllocHGlobal((int)num);
				byte_0 = new byte[(int)(unchecked((long)num) - 1L) + 1];
				EnumSystemFirmwareTables(uint_, intPtr, num);
				Marshal.Copy(intPtr, byte_0, 0, byte_0.Length);
				Marshal.FreeHGlobal(intPtr);
				if (Encoding.ASCII.GetString(byte_0).Contains("MSDM"))
				{
					num = GetSystemFirmwareTable(uint_, uint_2, IntPtr.Zero, 0u);
					byte_0 = new byte[(int)(unchecked((long)num) - 1L) + 1];
					intPtr = Marshal.AllocHGlobal((int)num);
					GetSystemFirmwareTable(uint_, uint_2, intPtr, num);
					Marshal.Copy(intPtr, byte_0, 0, byte_0.Length);
					Marshal.FreeHGlobal(intPtr);
					return true;
				}
				FileLogger logger2 = variables_0.Logger;
				message = "None MSDM table found";
				logger2.LogMessage(ref message);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger3 = variables_0.Logger;
				message = "Error: " + str;
				logger3.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}
}
internal class Class9
{
	private ProcessStartInfo processStartInfo_0;

	private Process process_0;

	private ArrayList arrayList_0;

	private bool bool_0;

	public Class9(string[] string_0, ArrayList arrayList_1, bool bool_1 = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		processStartInfo_0 = new ProcessStartInfo();
		process_0 = new Process();
		arrayList_0 = new ArrayList();
		method_2(string_0, ref arrayList_1);
		process_0.set_StartInfo(processStartInfo_0);
		if (arrayList_1 != null)
		{
			arrayList_0 = arrayList_1;
		}
		else
		{
			arrayList_0.Add(string.Empty);
		}
		bool_0 = bool_1;
	}

	public bool method_0()
	{
		return bool_0;
	}

	public void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	private void method_2(string[] string_0, ref ArrayList arrayList_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			if (string_0[1] != null)
			{
				ProcessStartInfo val = processStartInfo_0;
				val.set_WorkingDirectory(string_0[0]);
				val.set_FileName(val.get_WorkingDirectory() + "\\" + string_0[1]);
				val = null;
				int num = arrayList_1.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					stringBuilder.Append(Conversions.ToString(arrayList_1[i]));
					stringBuilder.Append(" ");
				}
				ProcessStartInfo obj = processStartInfo_0;
				obj.set_Arguments(stringBuilder.ToString());
				obj.set_UseShellExecute(false);
				obj.set_RedirectStandardOutput(true);
				obj.set_WindowStyle((ProcessWindowStyle)1);
				obj.set_CreateNoWindow(true);
			}
		}
	}

	public Process method_3()
	{
		return process_0;
	}

	public object method_4(bool bool_1)
	{
		if (bool_1)
		{
			return arrayList_0;
		}
		return processStartInfo_0.get_Arguments();
	}

	public string method_5()
	{
		return processStartInfo_0.get_FileName();
	}

	public string method_6()
	{
		return processStartInfo_0.get_Arguments();
	}
}
internal class Class10
{
	internal static void smethod_0(ref string string_0, ref bool bool_0, ref Variables variables_0)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (bool_0)
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows7 || variables_0.IsWindows8 || variables_0.IsWindowsVista)
					{
						string string_ = "KeyManagementServiceName";
						HostServer kmsHostLocal;
						object object_ = (kmsHostLocal = variables_0.KmsHostLocal).IpAddress;
						RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
						smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
						kmsHostLocal.IpAddress = Conversions.ToString(object_);
						string_ = "KeyManagementServicePort";
						object_ = (kmsHostLocal = variables_0.KmsHostLocal).Port;
						registryValueKind_ = (RegistryValueKind)1;
						smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
						kmsHostLocal.Port = Conversions.ToUInteger(object_);
					}
				}
				else
				{
					string string_ = "KeyManagementServiceName";
					HostServer kmsHostLocal;
					object object_ = (kmsHostLocal = variables_0.KmsHostForward).IpAddress;
					RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
					kmsHostLocal.IpAddress = Conversions.ToString(object_);
					string_ = "KeyManagementServicePort";
					object_ = (kmsHostLocal = variables_0.KmsHostForward).Port;
					registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
					kmsHostLocal.Port = Conversions.ToUInteger(object_);
				}
			}
			else
			{
				string string_ = "KeyManagementServiceName";
				object object_ = string.Empty;
				RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
				string_ = "KeyManagementServicePort";
				object_ = string.Empty;
				registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string string_ = "Error: " + str;
			logger.LogMessage(ref string_);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_1(ref string string_0, ref bool bool_0, ref Variables variables_0)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (bool_0)
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows7 || variables_0.IsWindows8 || variables_0.IsWindowsVista)
					{
						string string_ = "KeyManagementServiceName";
						HostServer kmsHostLocal;
						object object_ = (kmsHostLocal = variables_0.KmsHostLocal).IpAddress;
						RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
						smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
						kmsHostLocal.IpAddress = Conversions.ToString(object_);
						string_ = "KeyManagementServicePort";
						object_ = (kmsHostLocal = variables_0.KmsHostLocal).Port;
						registryValueKind_ = (RegistryValueKind)1;
						smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
						kmsHostLocal.Port = Conversions.ToUInteger(object_);
					}
				}
				else
				{
					string string_ = "KeyManagementServiceName";
					HostServer kmsHostLocal;
					object object_ = (kmsHostLocal = variables_0.KmsHostForward).IpAddress;
					RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
					kmsHostLocal.IpAddress = Conversions.ToString(object_);
					string_ = "KeyManagementServicePort";
					object_ = (kmsHostLocal = variables_0.KmsHostForward).Port;
					registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
					kmsHostLocal.Port = Conversions.ToUInteger(object_);
				}
			}
			else
			{
				string string_ = "KeyManagementServiceName";
				object object_ = string.Empty;
				RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
				string_ = "KeyManagementServicePort";
				object_ = string.Empty;
				registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_0, ref string_, ref object_, ref registryValueKind_, ref variables_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string string_ = "Error: " + str;
			logger.LogMessage(ref string_);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_2(ref string string_0, ref string string_1, ref object object_0, ref RegistryValueKind registryValueKind_0, ref Variables variables_0)
	{
		try
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				((ServerComputer)Class79.smethod_0()).get_Registry().SetValue(string_0, string_1, RuntimeHelpers.GetObjectValue(object_0), registryValueKind_0);
				string text = string_0.Replace("HKEY_LOCAL_MACHINE\\", string.Empty);
				text = text.Replace("SOFTWARE\\Microsoft\\", string.Empty);
				text = text.Replace("Windows NT\\CurrentVersion\\", string.Empty);
				FileLogger logger = variables_0.Logger;
				string message = "Set Registry : " + text + ":" + string_1;
				logger.LogMessage(ref message);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_3(ref string string_0, ref string string_1, ref Variables variables_0)
	{
		try
		{
			if (string.IsNullOrEmpty(string_0))
			{
				return;
			}
			string_0 = string_0.Replace("HKEY_LOCAL_MACHINE\\", string.Empty);
			if (((ServerComputer)Class79.smethod_0()).get_Registry().get_LocalMachine().OpenSubKey(string_0, false) != null)
			{
				if (string_1 != null)
				{
					((ServerComputer)Class79.smethod_0()).get_Registry().get_LocalMachine().OpenSubKey(string_0, true)
						.DeleteValue(string_1, false);
				}
				else
				{
					((ServerComputer)Class79.smethod_0()).get_Registry().get_LocalMachine().DeleteSubKeyTree(string_0, false);
				}
				FileLogger logger = variables_0.Logger;
				string message = "Del Registry : " + string_0 + ":" + string_1;
				logger.LogMessage(ref message);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
	}

	internal static object smethod_4(string string_0, ref string string_1, ref Variables variables_0)
	{
		object result = null;
		try
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				if (string_0.StartsWith("HKEY_LOCAL_MACHINE"))
				{
					string_0 = string_0.Replace("HKEY_LOCAL_MACHINE\\", string.Empty);
				}
				if (string_1 != null)
				{
					if (((ServerComputer)Class79.smethod_0()).get_Registry().get_LocalMachine().OpenSubKey(string_0, false) != null)
					{
						result = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().get_LocalMachine().OpenSubKey(string_0, false)
							.GetValue(string_1, (object)null));
						FileLogger logger = variables_0.Logger;
						string message = "Get Registry : " + string_0 + ":" + string_1;
						logger.LogMessage(ref message);
						return result;
					}
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static void smethod_5(ref string string_0, ref Variables variables_0)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		object obj = null;
		string string_ = string_0;
		string string_2 = "Start";
		obj = RuntimeHelpers.GetObjectValue(smethod_4(string_, ref string_2, ref variables_0));
		try
		{
			if (obj == null)
			{
				return;
			}
			int result = 0;
			int.TryParse(Conversions.ToString(obj), out result);
			if (result != 2)
			{
				string_2 = "Start";
				object object_ = 2;
				RegistryValueKind registryValueKind_ = (RegistryValueKind)4;
				smethod_2(ref string_0, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				string message = "The Software Protection Service was Fixed, reboot your PC now and try again.";
				variables_0.Logger.LogMessage(ref message);
				if (variables_0.IsGui)
				{
					variables_0.ShowMessage.Show(message, "Software Protection Service", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string_2 = "Error: " + str;
			logger.LogMessage(ref string_2);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_6(ref bool bool_0, ref Variables variables_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		string string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform";
		try
		{
			if (bool_0)
			{
				string string_2 = "KeyManagementServiceName";
				HostServer kmsHostLocal;
				object object_ = (kmsHostLocal = variables_0.KmsHostLocal).IpAddress;
				RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				kmsHostLocal.IpAddress = Conversions.ToString(object_);
				string_2 = "KeyManagementServicePort";
				object_ = (kmsHostLocal = variables_0.KmsHostLocal).Port;
				registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				kmsHostLocal.Port = Conversions.ToUInteger(object_);
			}
			else
			{
				string string_2 = "KeyManagementServiceName";
				object object_ = string.Empty;
				RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				string_2 = "KeyManagementServicePort";
				object_ = string.Empty;
				registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string string_2 = "Error: " + str;
			logger.LogMessage(ref string_2);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_7(ref bool bool_0, ref Variables variables_0)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		string string_ = string.Empty;
		if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8 && !variables_0.IsWindows7)
		{
			if (variables_0.IsWindowsVista)
			{
				string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SL";
			}
		}
		else
		{
			if (bool_0)
			{
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				bool bool_ = true;
				Class17.smethod_47(ref softwareLicensingService_, ref bool_, ref variables_0);
			}
			string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform";
		}
		try
		{
			if (bool_0)
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (!variables_0.IsWindows7 && !variables_0.IsWindows8)
					{
						if (variables_0.IsWindowsVista)
						{
							string string_2 = "KeyManagementServiceName";
							HostServer kmsHostLocal;
							object object_ = (kmsHostLocal = variables_0.KmsHostLocal).IpAddress;
							RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
							smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
							kmsHostLocal.IpAddress = Conversions.ToString(object_);
							string_2 = "KeyManagementServicePort";
							object_ = (kmsHostLocal = variables_0.KmsHostLocal).Port;
							registryValueKind_ = (RegistryValueKind)1;
							smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
							kmsHostLocal.Port = Conversions.ToUInteger(object_);
						}
					}
					else
					{
						string string_2 = "KeyManagementServiceName";
						HostServer kmsHostLocal;
						object object_ = (kmsHostLocal = variables_0.KmsHostLocal).IpAddress;
						RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
						smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
						kmsHostLocal.IpAddress = Conversions.ToString(object_);
						string_2 = "KeyManagementServicePort";
						object_ = (kmsHostLocal = variables_0.KmsHostLocal).Port;
						registryValueKind_ = (RegistryValueKind)1;
						smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
						kmsHostLocal.Port = Conversions.ToUInteger(object_);
					}
				}
				else
				{
					string string_2 = "KeyManagementServiceName";
					HostServer kmsHostLocal;
					object object_ = (kmsHostLocal = variables_0.KmsHostForward).IpAddress;
					RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
					kmsHostLocal.IpAddress = Conversions.ToString(object_);
					string_2 = "KeyManagementServicePort";
					object_ = (kmsHostLocal = variables_0.KmsHostForward).Port;
					registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
					kmsHostLocal.Port = Conversions.ToUInteger(object_);
				}
			}
			else
			{
				string string_2 = "KeyManagementServiceName";
				object object_ = string.Empty;
				RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				string_2 = "KeyManagementServicePort";
				object_ = string.Empty;
				registryValueKind_ = (RegistryValueKind)1;
				smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				if (variables_0.IsWindowsVista)
				{
					string_2 = "KeyManagementServiceName";
					object_ = string.Empty;
					registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
					string_2 = "KeyManagementServicePort";
					object_ = string.Empty;
					registryValueKind_ = (RegistryValueKind)1;
					smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string string_2 = "Error: " + str;
			logger.LogMessage(ref string_2);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_8(ref bool bool_0, ref Variables variables_0)
	{
		if (variables_0.IsWindows7 && bool_0)
		{
			Class17.smethod_48(Class17.smethod_50(ref variables_0), bool_0: true, ref variables_0);
		}
		if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
		{
			string string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\4f414197-0fc2-4c01-b68a-86cbb9ac254c";
			smethod_0(ref string_, ref bool_0, ref variables_0);
			string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\6bf301c1-b94a-43e9-ba31-d494598c47fb";
			smethod_0(ref string_, ref bool_0, ref variables_0);
			string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\b322da9c-a2e2-4058-9e4e-f59a6970bd69";
			smethod_0(ref string_, ref bool_0, ref variables_0);
			string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\d450596f-894d-49e0-966a-fd39ed4c4c64";
			smethod_0(ref string_, ref bool_0, ref variables_0);
			return;
		}
		if (bool_0)
		{
			SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
			bool bool_ = true;
			Class17.smethod_47(ref softwareLicensingService_, ref bool_, ref variables_0);
		}
		string string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\4f414197-0fc2-4c01-b68a-86cbb9ac254c";
		smethod_0(ref string_2, ref bool_0, ref variables_0);
		string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\6bf301c1-b94a-43e9-ba31-d494598c47fb";
		smethod_0(ref string_2, ref bool_0, ref variables_0);
		string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\b322da9c-a2e2-4058-9e4e-f59a6970bd69";
		smethod_0(ref string_2, ref bool_0, ref variables_0);
		string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\d450596f-894d-49e0-966a-fd39ed4c4c64";
		smethod_0(ref string_2, ref bool_0, ref variables_0);
	}

	internal static void smethod_9(ref bool bool_0, ref Variables variables_0)
	{
		if (variables_0.IsWindows7 && bool_0)
		{
			Class17.smethod_48(Class17.smethod_50(ref variables_0), bool_0: true, ref variables_0);
		}
		if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
		{
			string string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\4a5d124a-e620-44ba-b6ff-658961b33b9a";
			smethod_1(ref string_, ref bool_0, ref variables_0);
			string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\b322da9c-a2e2-4058-9e4e-f59a6970bd69";
			smethod_1(ref string_, ref bool_0, ref variables_0);
			string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\e13ac10e-75d0-4aff-a0cd-764982cf541c";
			smethod_1(ref string_, ref bool_0, ref variables_0);
			return;
		}
		if (bool_0)
		{
			SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
			bool bool_ = true;
			Class17.smethod_47(ref softwareLicensingService_, ref bool_, ref variables_0);
		}
		string string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\4a5d124a-e620-44ba-b6ff-658961b33b9a";
		smethod_1(ref string_2, ref bool_0, ref variables_0);
		string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\b322da9c-a2e2-4058-9e4e-f59a6970bd69";
		smethod_1(ref string_2, ref bool_0, ref variables_0);
		string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\0ff1ce15-a989-479d-af46-f275c6370663\\e13ac10e-75d0-4aff-a0cd-764982cf541c";
		smethod_1(ref string_2, ref bool_0, ref variables_0);
	}

	internal static void smethod_10(ref Variables variables_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		string string_ = "HKEY_CURRENT_USER\\Control Panel\\Desktop";
		string string_2 = "PaintDesktopVersion";
		object object_ = "0";
		RegistryValueKind registryValueKind_ = (RegistryValueKind)4;
		smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
	}

	internal static void smethod_11(ref Variables variables_0)
	{
		string text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
		variables_0.EditionID = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "EditionID", (object)null));
		variables_0.ProductName = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "ProductName", (object)null));
		variables_0.CurrentVersion = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "CurrentVersion", (object)null));
		variables_0.CurrentBuild = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "CurrentBuild", (object)null));
		string text2 = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "BuildLabEx", (object)null));
		string[] array = text2.Split(new char[1]
		{
			'.'
		});
		text2 = Enumerable.ElementAt<string>((IEnumerable<string>)array, 0) + "." + Enumerable.ElementAt<string>((IEnumerable<string>)array, 1);
		FileLogger logger = variables_0.Logger;
		string message = "Windows Detected: " + variables_0.ProductName + " : " + variables_0.EditionID + " : " + variables_0.CurrentVersion + " : " + text2;
		logger.LogMessage(ref message);
		Variables obj = variables_0;
		obj.IsServer = obj.ProductName.Contains("Windows Server");
		Variables obj2 = variables_0;
		obj2.IsPreview = obj2.ProductName.Contains("Preview");
		int num = 0;
		num = int.Parse(variables_0.CurrentBuild, NumberStyles.None);
		if (!variables_0.IsServer)
		{
			Variables obj3 = variables_0;
			obj3.IsWindows10 = obj3.CurrentVersion.StartsWith("6.4");
			if (num > 9800)
			{
				variables_0.IsWindows10 = true;
			}
			if (!variables_0.IsWindows10)
			{
				Variables obj4 = variables_0;
				obj4.IsWindows81 = obj4.CurrentVersion.StartsWith("6.3");
				if (!variables_0.IsWindows81)
				{
					Variables obj5 = variables_0;
					obj5.IsWindows8 = obj5.CurrentVersion.StartsWith("6.2");
					if (!variables_0.IsWindows8)
					{
						Variables obj6 = variables_0;
						obj6.IsWindows7 = obj6.CurrentVersion.StartsWith("6.1");
						if (!variables_0.IsWindows7)
						{
							Variables obj7 = variables_0;
							obj7.IsWindowsVista = obj7.CurrentVersion.StartsWith("6.0");
							if (!variables_0.IsWindowsVista)
							{
								Variables obj8 = variables_0;
								obj8.IsWindowsXP = obj8.CurrentVersion.StartsWith("5.");
								if (!variables_0.IsWindowsXP)
								{
									FileLogger logger2 = variables_0.Logger;
									message = "Unknow Windows Version";
									logger2.LogMessage(ref message);
								}
							}
						}
					}
				}
			}
		}
		else
		{
			Variables obj9 = variables_0;
			obj9.IsWindows10 = obj9.CurrentVersion.StartsWith("6.4");
			if (num > 10000)
			{
				variables_0.IsWindows10 = true;
			}
			if (!variables_0.IsWindows10)
			{
				Variables obj10 = variables_0;
				obj10.IsWindows81 = obj10.CurrentVersion.StartsWith("6.3");
				if (!variables_0.IsWindows81)
				{
					Variables obj11 = variables_0;
					obj11.IsWindows8 = obj11.CurrentVersion.StartsWith("6.2");
					if (!variables_0.IsWindows8)
					{
						Variables obj12 = variables_0;
						obj12.IsWindows7 = obj12.CurrentVersion.StartsWith("6.1");
						if (!variables_0.IsWindows7)
						{
							Variables obj13 = variables_0;
							obj13.IsWindowsVista = obj13.CurrentVersion.StartsWith("6.0");
							if (!variables_0.IsWindowsVista)
							{
								Variables obj14 = variables_0;
								obj14.IsWindowsXP = obj14.CurrentVersion.StartsWith("5.");
							}
						}
					}
				}
			}
		}
		HostServer hostServer_ = null;
		Class3.smethod_19(ref variables_0, ref hostServer_);
	}

	internal static ArrayList smethod_12(ref bool bool_0, ref bool bool_1, ref Variables variables_0)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		object obj = null;
		string empty = string.Empty;
		if (bool_0)
		{
			string string_ = "DigitalProductId";
			obj = RuntimeHelpers.GetObjectValue(smethod_4("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", ref string_, ref variables_0));
			if (obj != null)
			{
				empty = Key.smethod_17((IList<byte>)obj);
				arrayList.Add("Microsoft Windows: " + empty);
			}
		}
		else
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WindowsInstaller.Installer", ""));
			StringCollection val = new StringCollection();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(objectValue, (Type)null, "Products", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					object[] array;
					bool[] array2;
					object obj2 = NewLateBinding.LateGet(objectValue, (Type)null, "ProductInfo", array = new object[2]
					{
						objectValue2,
						"ProductName"
					}, (string[])null, (Type[])null, array2 = new bool[2]
					{
						true,
						false
					});
					if (array2[0])
					{
						objectValue2 = RuntimeHelpers.GetObjectValue(array[0]);
					}
					string str = obj2.ToString();
					string text = objectValue2.ToString()!.Substring(10, 9);
					if (Operators.CompareString(Strings.UCase(Strings.Right(Conversions.ToString(objectValue2), 7)), "0FF1CE}", false) == 0)
					{
						if (Operators.CompareString(text, "0011-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0012-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0013-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0014-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0015-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0016-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0017-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0018-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0019-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "001A-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "001B-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "001C-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "002F-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "003A-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "003B-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0044-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0051-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0052-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0053-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0057-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00A1-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00A3-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00BA-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "110B-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "110D-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "110F-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "012B-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "007A-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "008B-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00AF-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0026-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0020-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "002E-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0030-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0031-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0033-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "0035-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00A7-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00A9-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00BA-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
						if (Operators.CompareString(text, "00CA-0000", false) == 0)
						{
							val.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(str + ","), objectValue2), (object)","), (object)objectValue2.ToString()!.Substring(3, 2))));
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			string str2 = null;
			StringEnumerator enumerator2 = val.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string[] array3 = enumerator2.get_Current().Split(new char[1]
				{
					','
				});
				if (Operators.CompareString(array3[2], "12", false) == 0)
				{
					str2 = "\\Microsoft\\Office\\12.0\\Registration\\" + array3[1];
				}
				if (Operators.CompareString(array3[2], "14", false) == 0)
				{
					str2 = "\\Microsoft\\Office\\14.0\\Registration\\" + array3[1];
				}
				if (Operators.CompareString(array3[2], "15", false) == 0)
				{
					str2 = "\\Microsoft\\Office\\15.0\\Registration\\" + array3[1];
				}
				string string_2 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node" + str2;
				string string_ = "DigitalProductId";
				obj = RuntimeHelpers.GetObjectValue(smethod_4(string_2, ref string_, ref variables_0));
				if (obj != null)
				{
					empty = Conversions.ToString(Class20.smethod_0(RuntimeHelpers.GetObjectValue(obj)));
					arrayList.Add(array3[0] + ": " + empty);
				}
				string string_3 = "HKEY_LOCAL_MACHINE\\SOFTWARE" + str2;
				string_ = "DigitalProductId";
				obj = RuntimeHelpers.GetObjectValue(smethod_4(string_3, ref string_, ref variables_0));
				if (obj != null)
				{
					empty = Conversions.ToString(Class20.smethod_0(RuntimeHelpers.GetObjectValue(obj)));
					arrayList.Add(array3[0] + ": " + empty);
				}
			}
		}
		if (arrayList.Count > 1)
		{
			smethod_13(arrayList);
		}
		return arrayList;
	}

	internal static ArrayList smethod_13(ArrayList arrayList_0)
	{
		ArrayList arrayList = new ArrayList();
		string text = string.Empty;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = arrayList_0.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				string text2 = Conversions.ToString(enumerator.Current);
				bool flag = false;
				try
				{
					enumerator2 = arrayList.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string value = Conversions.ToString(enumerator2.Current);
						if (text2.Contains(value))
						{
							flag = true;
							break;
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				if (!text.Contains(text2) && !flag)
				{
					arrayList.Add(text2);
					text = text2;
				}
			}
			return arrayList;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
internal class Class11
{
	internal static void smethod_0(ref Variables variables_0)
	{
		try
		{
			if (Environment.Is64BitOperatingSystem)
			{
				string string_ = "SECOH-QAD.x64.dll";
				string string_2 = variables_0.SystemRoot + "\\SECOH-QAD.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "SECOH-QAD.x64.exe";
				string_ = variables_0.SystemRoot + "\\SECOH-QAD.exe";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
			else
			{
				string string_ = "SECOH-QAD.x86.dll";
				string string_2 = variables_0.SystemRoot + "\\SECOH-QAD.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "SECOH-QAD.x86.exe";
				string_ = variables_0.SystemRoot + "\\SECOH-QAD.exe";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string string_ = "Error: " + str;
			logger.LogMessage(ref string_);
			ProjectData.ClearProjectError();
		}
		if (File.Exists(variables_0.SystemRoot + "\\SECOH-QAD.dll") && File.Exists(variables_0.SystemRoot + "\\SECOH-QAD.exe"))
		{
			return;
		}
		try
		{
			if (Environment.Is64BitOperatingSystem)
			{
				string string_ = "SECOH-QAD.x64.dll";
				string string_2 = Environment.GetEnvironmentVariable("TEMP") + "\\SECOH-QAD.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "SECOH-QAD.x64.exe";
				string_ = Environment.GetEnvironmentVariable("TEMP") + "\\SECOH-QAD.exe";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
			else
			{
				string string_ = "SECOH-QAD.x86.dll";
				string string_2 = Environment.GetEnvironmentVariable("TEMP") + "\\SECOH-QAD.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "SECOH-QAD.x86.exe";
				string_ = Environment.GetEnvironmentVariable("TEMP") + "\\SECOH-QAD.exe";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception exception_2 = ex2;
			string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
			FileLogger logger2 = variables_0.Logger;
			string string_ = "Error: " + str2;
			logger2.LogMessage(ref string_);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_1(bool bool_0, ref Variables variables_0)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		string string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SppExtComObj.exe";
		try
		{
			if (bool_0)
			{
				while (true)
				{
					HostServer kmsHostForward;
					string string_2 = (kmsHostForward = variables_0.KmsHostForward).IpAddress;
					bool num = WMINetWorkAdapter.smethod_12(ref string_2);
					kmsHostForward.IpAddress = string_2;
					if (!num)
					{
						break;
					}
					variables_0.KmsHostForward.IpAddress = WMINetWorkAdapter.smethod_13();
				}
				if (File.Exists(variables_0.SystemRoot + "\\SECOH-QAD.exe"))
				{
					string string_2 = "Debugger";
					object object_ = variables_0.SystemRoot + "\\SECOH-QAD.exe";
					RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
					Class10.smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				}
				else if (File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\SECOH-QAD.exe"))
				{
					string string_2 = "Debugger";
					object object_ = Environment.GetEnvironmentVariable("TEMP") + "\\SECOH-QAD.exe";
					RegistryValueKind registryValueKind_ = (RegistryValueKind)1;
					Class10.smethod_2(ref string_, ref string_2, ref object_, ref registryValueKind_, ref variables_0);
				}
				variables_0.IsSecohQadLoaded = true;
			}
			else
			{
				FileLogger logger = variables_0.Logger;
				string string_2 = "Unloading SECOH-QAD...";
				logger.LogMessage(ref string_2);
				string_2 = null;
				Class10.smethod_3(ref string_, ref string_2, ref variables_0);
				variables_0.IsSecohQadLoaded = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger2 = variables_0.Logger;
			string string_2 = "Error: " + str;
			logger2.LogMessage(ref string_2);
			ProjectData.ClearProjectError();
		}
	}
}
internal class Class12
{
	[CompilerGenerated]
	internal sealed class Class13
	{
		public CultureInfo cultureInfo_0;

		public Variables variables_0;

		internal void method_0()
		{
			string string_ = cultureInfo_0.Name;
			smethod_2(ref string_, ref variables_0);
		}

		internal void method_1()
		{
			string string_ = cultureInfo_0.Name;
			smethod_3(ref string_, ref variables_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class14
	{
		public CultureInfo cultureInfo_0;

		public Variables variables_0;

		internal void method_0()
		{
			string string_ = cultureInfo_0.Name;
			smethod_6(ref string_, ref variables_0);
		}

		internal void method_1()
		{
			string string_ = cultureInfo_0.Name;
			smethod_7(ref string_, ref variables_0);
		}
	}

	internal static void smethod_0(ref Variables variables_0)
	{
		CultureInfo cultureInfo_0 = Thread.CurrentThread.CurrentCulture;
		Variables variables_ = variables_0;
		new Thread((ThreadStart)delegate
		{
			string string_2 = cultureInfo_0.Name;
			smethod_2(ref string_2, ref variables_);
		}).Start();
		new Thread((ThreadStart)delegate
		{
			string string_ = cultureInfo_0.Name;
			smethod_3(ref string_, ref variables_);
		}).Start();
	}

	internal static void smethod_1(ref Variables variables_0)
	{
		CultureInfo cultureInfo_0 = Thread.CurrentThread.CurrentCulture;
		Variables variables_ = variables_0;
		new Thread((ThreadStart)delegate
		{
			string string_2 = cultureInfo_0.Name;
			smethod_6(ref string_2, ref variables_);
		}).Start();
		new Thread((ThreadStart)delegate
		{
			string string_ = cultureInfo_0.Name;
			smethod_7(ref string_, ref variables_);
		}).Start();
	}

	private static void smethod_2(ref string string_0, ref Variables variables_0)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		FileNodo fileNodo_ = new FileNodo();
		string string_ = "basebrd.dll.mui";
		fileNodo_.RutaFile = Class2.smethod_0(ref variables_0, ref string_, Environment.GetEnvironmentVariable("windir") + "\\Branding\\Basebrd\\" + string_0);
		string string_2 = fileNodo_.RutaFile[0] + "\\" + fileNodo_.RutaFile[1];
		if (!File.Exists(string_2))
		{
			fileNodo_.RutaFile = Class2.smethod_0(ref variables_0, ref string_, Environment.GetEnvironmentVariable("windir") + "\\Branding\\Basebrd\\en-US");
			string_2 = fileNodo_.RutaFile[0] + "\\" + fileNodo_.RutaFile[1];
		}
		if (File.Exists(string_2))
		{
			string empty = string.Empty;
			StringResource val = new StringResource();
			try
			{
				((Resource)val).set_Name(new ResourceId((uint)StringResource.GetBlockId(12)));
				((Resource)val).LoadFrom(string_2);
				empty = val.get_Item((ushort)12);
				if (!empty.Contains(Convert.ToChar(0).ToString()) && empty.StartsWith("Windows"))
				{
					string string_3 = "SearchIndexer";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "SearchProtocolHost";
					Class3.smethod_4(ref string_3, ref variables_0);
					FileLogger logger = variables_0.Logger;
					string_3 = "Removing Watermark: " + empty;
					logger.LogMessage(ref string_3);
					int int_ = checked((empty.Length - 1) * 2);
					fileNodo_.Hex = smethod_5(ref int_);
					PatchFile.smethod_3(string_2, ref variables_0);
					FileNodo fileNodo = fileNodo_;
					bool bool_ = false;
					fileNodo.Offset = PatchFile.smethod_5(ref empty, ref string_2, ref variables_0, ref bool_);
					if (fileNodo_.Offset > -1)
					{
						bool_ = false;
						PatchFile.smethod_0(ref fileNodo_, ref bool_, ref variables_0);
					}
					else
					{
						FileLogger logger2 = variables_0.Logger;
						string_3 = "Offset Not Found: " + string_2 + " : " + empty;
						logger2.LogMessage(ref string_3);
					}
					FileNodo fileNodo2 = fileNodo_;
					bool_ = false;
					fileNodo2.Offset = PatchFile.smethod_5(ref empty, ref string_2, ref variables_0, ref bool_);
					if (fileNodo_.Offset > -1)
					{
						bool_ = false;
						PatchFile.smethod_0(ref fileNodo_, ref bool_, ref variables_0);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger3 = variables_0.Logger;
				string string_3 = "Error: " + str;
				logger3.LogMessage(ref string_3);
				ProjectData.ClearProjectError();
			}
		}
		variables_0.WaterMarkBasebrd = true;
		Class3.smethod_6(ref variables_0);
	}

	private static void smethod_3(ref string string_0, ref Variables variables_0)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		variables_0.WaterMarkShell32 = false;
		FileNodo fileNodo_ = new FileNodo();
		string string_ = "shell32.dll.mui";
		fileNodo_.RutaFile = Class2.smethod_0(ref variables_0, ref string_, Environment.GetEnvironmentVariable("windir") + "\\System32\\" + string_0);
		string string_2 = fileNodo_.RutaFile[0] + "\\" + fileNodo_.RutaFile[1];
		if (!File.Exists(string_2))
		{
			fileNodo_.RutaFile = Class2.smethod_0(ref variables_0, ref string_, Environment.GetEnvironmentVariable("windir") + "\\System32\\en-US");
			string_2 = fileNodo_.RutaFile[0] + "\\" + fileNodo_.RutaFile[1];
		}
		bool flag = false;
		if (File.Exists(string_2))
		{
			string empty = string.Empty;
			StringResource val = new StringResource();
			try
			{
				((Resource)val).set_Name(new ResourceId((uint)StringResource.GetBlockId(33108)));
				((Resource)val).LoadFrom(string_2);
				empty = val.get_Item((ushort)33108);
				if (!empty.Contains(Convert.ToChar(0).ToString()) && empty.Contains("ws"))
				{
					string string_3 = "SearchProtocolHost";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "explorer";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "SearchIndexer";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "SearchProtocolHost";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "explorer";
					Class3.smethod_4(ref string_3, ref variables_0);
					FileLogger logger = variables_0.Logger;
					string_3 = "Removing Watermark: " + empty;
					logger.LogMessage(ref string_3);
					int int_ = checked((empty.Length - 1) * 2);
					fileNodo_.Hex = smethod_5(ref int_);
					PatchFile.smethod_3(string_2, ref variables_0);
					FileNodo fileNodo = fileNodo_;
					bool bool_ = false;
					fileNodo.Offset = PatchFile.smethod_5(ref empty, ref string_2, ref variables_0, ref bool_);
					if (fileNodo_.Offset > -1)
					{
						bool_ = false;
						if (PatchFile.smethod_0(ref fileNodo_, ref bool_, ref variables_0))
						{
							flag = true;
						}
					}
					else
					{
						FileLogger logger2 = variables_0.Logger;
						string_3 = "Offset Not Found: " + string_2 + " : " + empty;
						logger2.LogMessage(ref string_3);
					}
					((Resource)val).set_Name(new ResourceId((uint)StringResource.GetBlockId(33109)));
					empty = val.get_Item((ushort)33109);
					string_3 = "SearchProtocolHost";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "explorer";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "SearchIndexer";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "SearchProtocolHost";
					Class3.smethod_4(ref string_3, ref variables_0);
					string_3 = "explorer";
					Class3.smethod_4(ref string_3, ref variables_0);
					FileLogger logger3 = variables_0.Logger;
					string_3 = "Removing Watermark: " + empty;
					logger3.LogMessage(ref string_3);
					int_ = checked((empty.Length - 1) * 2);
					fileNodo_.Hex = smethod_5(ref int_);
					FileNodo fileNodo2 = fileNodo_;
					bool_ = false;
					fileNodo2.Offset = PatchFile.smethod_5(ref empty, ref string_2, ref variables_0, ref bool_);
					if (fileNodo_.Offset > -1)
					{
						bool_ = false;
						if (PatchFile.smethod_0(ref fileNodo_, ref bool_, ref variables_0))
						{
							flag = true;
						}
					}
					else
					{
						FileLogger logger4 = variables_0.Logger;
						string_3 = "Offset Not Found: " + string_2 + " : " + empty;
						logger4.LogMessage(ref string_3);
					}
				}
				if (flag)
				{
					FileLogger logger5 = variables_0.Logger;
					string string_3 = "WaterMark had been removed, restart later to update desktop watermark";
					logger5.LogMessage(ref string_3);
					ArrayList arrayList_ = new ArrayList();
					string_3 = "mcbuilder.exe";
					string[] string_4 = Class2.smethod_0(ref variables_0, ref string_3);
					bool bool_ = true;
					Class3.smethod_1(ref string_4, ref arrayList_, ref variables_0, ref bool_);
					if (variables_0.IsGui)
					{
						variables_0.ShowMessage.Show("WaterMark had been removed, restart later to update desktop watermark", "Removed WaterMark", IFrmShowMessage.enumMessageIcon.Information, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
					}
					string_3 = "explorer.exe";
					string_4 = Class2.smethod_0(ref variables_0, ref string_3, Environment.GetEnvironmentVariable("windir"));
					bool_ = false;
					Class3.smethod_1(ref string_4, ref arrayList_, ref variables_0, ref bool_);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger6 = variables_0.Logger;
				string string_3 = "Error: " + str;
				logger6.LogMessage(ref string_3);
				ProjectData.ClearProjectError();
			}
		}
		variables_0.WaterMarkShell32 = true;
		Class3.smethod_6(ref variables_0);
	}

	public static ushort smethod_4(int int_0)
	{
		return checked((ushort)Math.Round((double)int_0 / 16.0 + 1.0));
	}

	public static string smethod_5(ref int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = int_0;
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			stringBuilder.Append("00");
			if (i < int_0)
			{
				stringBuilder.Append("-");
			}
		}
		return stringBuilder.ToString();
	}

	private static void smethod_6(ref string string_0, ref Variables variables_0)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		FileNodo fileNodo = new FileNodo();
		string string_ = "basebrd.dll.old.mui";
		fileNodo.RutaFile = Class2.smethod_0(ref variables_0, ref string_, Environment.GetEnvironmentVariable("windir") + "\\Branding\\Basebrd\\" + string_0);
		string text = fileNodo.RutaFile[0] + "\\" + fileNodo.RutaFile[1];
		string string_2 = fileNodo.RutaFile[0] + "\\basebrd.dll.mui";
		string text2 = fileNodo.RutaFile[0] + "\\basebrd.dll.old2.mui";
		if (File.Exists(text))
		{
			StringResource val = new StringResource();
			try
			{
				if (File.Exists(string_2))
				{
					((Resource)val).set_Name(new ResourceId((uint)StringResource.GetBlockId(12)));
					((Resource)val).LoadFrom(string_2);
					if (val.get_Item((ushort)12).Contains(Convert.ToChar(0).ToString()))
					{
						string string_3 = "SearchIndexer";
						Class3.smethod_4(ref string_3, ref variables_0);
						string_3 = "SearchProtocolHost";
						Class3.smethod_4(ref string_3, ref variables_0);
						FileLogger logger = variables_0.Logger;
						string_3 = "Restoring Watermark: " + string_2;
						logger.LogMessage(ref string_3);
						try
						{
							TakeOwner.smethod_1(ref string_2, ref variables_0);
							if (File.Exists(text2))
							{
								File.Delete(text2);
							}
							File.Move(string_2, text2);
							File.Copy(text, string_2);
							File.Delete(text);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception exception_ = ex;
							string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
							FileLogger logger2 = variables_0.Logger;
							string_3 = "Error: " + str;
							logger2.LogMessage(ref string_3);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger3 = variables_0.Logger;
				string string_3 = "Error: " + str2;
				logger3.LogMessage(ref string_3);
				ProjectData.ClearProjectError();
			}
		}
		variables_0.WaterMarkBasebrd = true;
		Class3.smethod_6(ref variables_0);
	}

	private static void smethod_7(ref string string_0, ref Variables variables_0)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		variables_0.WaterMarkShell32 = false;
		FileNodo fileNodo = new FileNodo();
		string string_ = "shell32.dll.old.mui";
		fileNodo.RutaFile = Class2.smethod_0(ref variables_0, ref string_, Environment.GetEnvironmentVariable("windir") + "\\System32\\" + string_0);
		string text = fileNodo.RutaFile[0] + "\\" + fileNodo.RutaFile[1];
		string string_2 = fileNodo.RutaFile[0] + "\\shell32.dll.mui";
		string text2 = fileNodo.RutaFile[0] + "\\shell32.dll.old2.mui";
		if (File.Exists(text))
		{
			StringResource val = new StringResource();
			try
			{
				if (File.Exists(string_2))
				{
					((Resource)val).set_Name(new ResourceId((uint)StringResource.GetBlockId(33108)));
					((Resource)val).LoadFrom(string_2);
					if (val.get_Item((ushort)33108).Contains(Convert.ToChar(0).ToString()))
					{
						string string_3 = "explorer";
						Class3.smethod_4(ref string_3, ref variables_0);
						string_3 = "SearchIndexer";
						Class3.smethod_4(ref string_3, ref variables_0);
						string_3 = "SearchProtocolHost";
						Class3.smethod_4(ref string_3, ref variables_0);
						FileLogger logger = variables_0.Logger;
						string_3 = "Restoring Watermark: " + string_2;
						logger.LogMessage(ref string_3);
						try
						{
							TakeOwner.smethod_1(ref string_2, ref variables_0);
							if (File.Exists(text2))
							{
								File.Delete(text2);
							}
							File.Move(string_2, text2);
							File.Copy(text, string_2);
							File.Delete(text);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception exception_ = ex;
							string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
							FileLogger logger2 = variables_0.Logger;
							string_3 = "Error: " + str;
							logger2.LogMessage(ref string_3);
							ProjectData.ClearProjectError();
						}
						FileLogger logger3 = variables_0.Logger;
						string_3 = "WaterMark had been restored, restart later to update desktop watermark";
						logger3.LogMessage(ref string_3);
						ArrayList arrayList_ = new ArrayList();
						string_3 = "explorer.exe";
						string[] string_4 = Class2.smethod_0(ref variables_0, ref string_3, Environment.GetEnvironmentVariable("windir"));
						bool bool_ = false;
						Class3.smethod_1(ref string_4, ref arrayList_, ref variables_0, ref bool_);
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger4 = variables_0.Logger;
				string string_3 = "Error: " + str2;
				logger4.LogMessage(ref string_3);
				ProjectData.ClearProjectError();
			}
		}
		variables_0.WaterMarkShell32 = true;
		Class3.smethod_6(ref variables_0);
	}
}
internal class Class15
{
	[CompilerGenerated]
	internal sealed class Class16
	{
		public Variables variables_0;

		internal void method_0()
		{
			smethod_0(ref variables_0);
		}
	}

	internal static void smethod_0(ref Variables variables_0)
	{
		while (true)
		{
			HostServer kmsHostForward;
			string string_ = (kmsHostForward = variables_0.KmsHostForward).IpAddress;
			bool num = WMINetWorkAdapter.smethod_12(ref string_);
			kmsHostForward.IpAddress = string_;
			if (!num)
			{
				break;
			}
			variables_0.KmsHostForward.IpAddress = WMINetWorkAdapter.smethod_13();
		}
		Thread.Sleep(Class2.smethod_2(50, 600));
		if (!variables_0.InternetConnection)
		{
			Thread.Sleep(Class2.smethod_2(50, 600));
			if (!variables_0.InternetConnection)
			{
				bool bool_ = true;
				HostServer kmsHostForward;
				string string_ = (kmsHostForward = variables_0.KmsHostForward).IpAddress;
				smethod_3(ref bool_, ref string_, ref variables_0);
				kmsHostForward.IpAddress = string_;
			}
		}
		variables_0.IsWinDivertLoaded = true;
		new FakeClient().Run(ref variables_0);
	}

	internal static void smethod_1(ref Variables variables_0)
	{
		if (variables_0.IsWinDivertLoaded)
		{
			FileLogger logger = variables_0.Logger;
			string message = "Unloading WinDivert...";
			logger.LogMessage(ref message);
			bool bool_ = false;
			HostServer kmsHostForward;
			message = (kmsHostForward = variables_0.KmsHostForward).IpAddress;
			smethod_3(ref bool_, ref message, ref variables_0);
			kmsHostForward.IpAddress = message;
			message = "WinDivert1.1";
			bool_ = false;
			bool bool_2 = false;
			Class2.smethod_1(ref message, ref bool_, ref variables_0, ref bool_2);
			message = "WinDivert1.1";
			Class3.smethod_26(ref variables_0, ref message);
			variables_0.IsWinDivertLoaded = false;
		}
	}

	internal static void smethod_2(ref Variables variables_0)
	{
		try
		{
			if (Environment.Is64BitOperatingSystem)
			{
				string string_ = "WinDivert.x64.dll";
				string string_2 = variables_0.DirectorioActual + "\\WinDivert.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "WinDivert.x64.sys";
				string_ = variables_0.DirectorioActual + "\\WinDivert.sys";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
			else
			{
				string string_ = "WinDivert.x86.dll";
				string string_2 = variables_0.DirectorioActual + "\\WinDivert.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "WinDivert.x86.sys";
				string_ = variables_0.DirectorioActual + "\\WinDivert.sys";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string string_ = "Error: " + str;
			logger.LogMessage(ref string_);
			ProjectData.ClearProjectError();
		}
		if (File.Exists(variables_0.DirectorioActual + "\\WinDivert.dll") && File.Exists(variables_0.DirectorioActual + "\\WinDivert.sys"))
		{
			return;
		}
		try
		{
			if (Environment.Is64BitOperatingSystem)
			{
				string string_ = "WinDivert.x64.dll";
				string string_2 = Environment.GetEnvironmentVariable("TEMP") + "\\WinDivert.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "WinDivert.x64.sys";
				string_ = Environment.GetEnvironmentVariable("TEMP") + "\\WinDivert.sys";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
			else
			{
				string string_ = "WinDivert.x86.dll";
				string string_2 = Environment.GetEnvironmentVariable("TEMP") + "\\WinDivert.dll";
				EmbeddedAssembly.smethod_0(ref string_, ref string_2, ref variables_0);
				string_2 = "WinDivert.x86.sys";
				string_ = Environment.GetEnvironmentVariable("TEMP") + "\\WinDivert.sys";
				EmbeddedAssembly.smethod_0(ref string_2, ref string_, ref variables_0);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception exception_2 = ex2;
			string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
			FileLogger logger2 = variables_0.Logger;
			string string_ = "Error: " + str2;
			logger2.LogMessage(ref string_);
			ProjectData.ClearProjectError();
		}
	}

	internal static void smethod_3(ref bool bool_0, ref string string_0, ref Variables variables_0)
	{
		ArrayList arrayList_ = new ArrayList();
		if (bool_0)
		{
			arrayList_.Add("add");
		}
		else
		{
			arrayList_.Add("delete");
		}
		arrayList_.Add("-4");
		arrayList_.Add(string_0);
		arrayList_.Add("0.0.0.0");
		arrayList_.Add("IF 1");
		string string_ = "route.exe";
		string[] string_2 = Class2.smethod_0(ref variables_0, ref string_);
		bool bool_ = true;
		Class3.smethod_1(ref string_2, ref arrayList_, ref variables_0, ref bool_);
	}

	internal static void smethod_4(ref string string_0, ref string string_1, ref string string_2, ref Variables variables_0)
	{
		ArrayList arrayList_ = new ArrayList();
		arrayList_.Add("create \"" + string_0 + "\"");
		arrayList_.Add("type= kernel");
		arrayList_.Add("DisplayName= \"" + string_1 + "\"");
		arrayList_.Add("binPath= \"" + string_2 + "\"");
		string string_3 = "sc.exe";
		string[] string_4 = Class2.smethod_0(ref variables_0, ref string_3);
		bool bool_ = true;
		Class3.smethod_1(ref string_4, ref arrayList_, ref variables_0, ref bool_);
	}

	internal static void smethod_5(ref Variables variables_0)
	{
		if (variables_0.IsSecohQadLoaded)
		{
			variables_0.IsSecohQad.Value = false;
			Class11.smethod_1(bool_0: false, ref variables_0);
		}
		Variables variables_ = variables_0;
		variables_0.IsWinDivert.Value = true;
		smethod_2(ref variables_0);
		bool flag = false;
		if (File.Exists(variables_0.DirectorioActual + "\\WinDivert.dll") && File.Exists(variables_0.DirectorioActual + "\\WinDivert.sys"))
		{
			string string_ = "WinDivert1.1";
			string string_2 = "WinDivert1.1";
			string string_3 = variables_0.DirectorioActual + "\\WinDivert.sys";
			smethod_4(ref string_, ref string_2, ref string_3, ref variables_0);
			flag = true;
		}
		else if (File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\WinDivert.dll") && File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\WinDivert.sys"))
		{
			string string_3 = "WinDivert1.1";
			string string_2 = "WinDivert1.1";
			string string_ = Environment.GetEnvironmentVariable("TEMP") + "\\WinDivert.sys";
			smethod_4(ref string_3, ref string_2, ref string_, ref variables_0);
			flag = true;
		}
		if (flag)
		{
			new Thread((ThreadStart)delegate
			{
				smethod_0(ref variables_);
			}).Start();
		}
	}
}
internal class Class17
{
	[CompilerGenerated]
	internal sealed class Class18
	{
		public Variables variables_0;

		internal void method_0()
		{
			ref Variables reference = ref variables_0;
			bool bool_ = true;
			Class3.smethod_21(ref reference, ref bool_);
		}
	}

	[CompilerGenerated]
	internal sealed class Class19
	{
		public Variables variables_0;

		internal void method_0()
		{
			ref Variables reference = ref variables_0;
			bool bool_ = true;
			Class3.smethod_21(ref reference, ref bool_);
		}
	}

	private const string string_0 = "SoftwareLicensingProduct";

	private const string string_1 = "SoftwareLicensingService";

	private const string string_2 = "OfficeSoftwareProtectionProduct";

	private const string string_3 = "OfficeSoftwareProtectionService";

	private const string string_4 = "Activating %PRODUCTNAME% (%PRODUCTID%)";

	private const string string_5 = "Genuine Status: ";

	private static ManagementObjectCollection smethod_0(ref Variables variables_0)
	{
		return smethod_14("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, VLActivationTypeEnabled, KeyManagementServiceMachine, KeyManagementServicePort, OfflineInstallationId", "SoftwareLicensingProduct", ref variables_0);
	}

	private static SoftwareLicensingProduct smethod_1(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		return smethod_15("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, VLActivationTypeEnabled, KeyManagementServiceMachine, KeyManagementServicePort, OfflineInstallationId", "SoftwareLicensingProduct", ref softwareLicensingProduct_0, ref variables_0);
	}

	private static ManagementObjectCollection smethod_2(ref Variables variables_0)
	{
		return smethod_14("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, VLActivationTypeEnabled, KeyManagementServiceMachine, KeyManagementServicePort, ProductKeyChannel, OfflineInstallationId", "SoftwareLicensingProduct", ref variables_0);
	}

	private static SoftwareLicensingProduct smethod_3(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		return smethod_15("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, VLActivationTypeEnabled, KeyManagementServiceMachine, KeyManagementServicePort, ProductKeyChannel, OfflineInstallationId", "SoftwareLicensingProduct", ref softwareLicensingProduct_0, ref variables_0);
	}

	private static ManagementObjectCollection smethod_4(ref Variables variables_0)
	{
		return smethod_14("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, VLActivationTypeEnabled, KeyManagementServiceMachine, KeyManagementServicePort, ProductKeyChannel, OfflineInstallationId", "SoftwareLicensingProduct", ref variables_0);
	}

	private static SoftwareLicensingProduct smethod_5(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		return smethod_15("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, VLActivationTypeEnabled, KeyManagementServiceMachine, KeyManagementServicePort, ProductKeyChannel, OfflineInstallationId", "SoftwareLicensingProduct", ref softwareLicensingProduct_0, ref variables_0);
	}

	private static ManagementObjectCollection smethod_6(ref Variables variables_0)
	{
		return smethod_14("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, KeyManagementServiceMachine, KeyManagementServicePort", "OfficeSoftwareProtectionProduct", ref variables_0);
	}

	private static OfficeSoftwareProtectionProduct smethod_7(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
	{
		return smethod_16("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, GenuineStatus, KeyManagementServiceMachine, KeyManagementServicePort", "OfficeSoftwareProtectionProduct", ref officeSoftwareProtectionProduct_0, ref variables_0);
	}

	private static ManagementObjectCollection smethod_8(ref Variables variables_0)
	{
		return smethod_14("ID, ApplicationId, PartialProductKey, Description, Name,LicenseStatus, LicenseStatusReason, ProductKeyID, GracePeriodRemaining, KeyManagementServiceMachine, KeyManagementServicePort", "OfficeSoftwareProtectionProduct", ref variables_0);
	}

	private static OfficeSoftwareProtectionProduct smethod_9(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
	{
		return smethod_16("ID, ApplicationId, PartialProductKey, Description, Name,LicenseStatus, LicenseStatusReason, ProductKeyID, GracePeriodRemaining, KeyManagementServiceMachine, KeyManagementServicePort", "OfficeSoftwareProtectionProduct", ref officeSoftwareProtectionProduct_0, ref variables_0);
	}

	private static ManagementObjectCollection smethod_10(ref Variables variables_0)
	{
		return smethod_14("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, KeyManagementServiceMachine, KeyManagementServicePort", "SoftwareLicensingProduct", ref variables_0);
	}

	private static SoftwareLicensingProduct smethod_11(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		return smethod_15("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate, KeyManagementServiceMachine, KeyManagementServicePort", "SoftwareLicensingProduct", ref softwareLicensingProduct_0, ref variables_0);
	}

	private static ManagementObjectCollection smethod_12(ref Variables variables_0)
	{
		return smethod_14("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate", "SoftwareLicensingProduct", ref variables_0);
	}

	private static SoftwareLicensingProduct smethod_13(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		return smethod_15("ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, ProductKeyID, GracePeriodRemaining, LicenseStatus, LicenseStatusReason, EvaluationEndDate", "SoftwareLicensingProduct", ref softwareLicensingProduct_0, ref variables_0);
	}

	private static ManagementObjectCollection smethod_14(string string_6, string string_7, ref Variables variables_0, bool bool_0 = false)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectCollection val = null;
		try
		{
			ObjectQuery val2 = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7 + " WHERE PartialProductKey IS NOT NULL");
			if (bool_0)
			{
				val2 = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7);
			}
			val = new ManagementObjectSearcher(variables_0.GObjWmiService, val2).Get();
			try
			{
				if (val.get_Count() > 0)
				{
					return val;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger = variables_0.Logger;
				string message = "Error: " + str;
				logger.LogMessage(ref message);
				FileLogger logger2 = variables_0.Logger;
				message = "Error: Tokens/WMI may be corrupted or Protection Service is Disable, restart and try again or try Tweaking.com - Windows Repair";
				logger2.LogMessage(ref message);
				ManagementObjectCollection result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception exception_2 = ex2;
			string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
			FileLogger logger3 = variables_0.Logger;
			string message = "Error: " + str2;
			logger3.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
		return val;
	}

	private static SoftwareLicensingProduct smethod_15(string string_6, string string_7, ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0, bool bool_0 = false)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		SoftwareLicensingProduct result = null;
		try
		{
			ObjectQuery val = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7 + " WHERE PartialProductKey = '" + softwareLicensingProduct_0.PartialProductKey + "'");
			if (bool_0)
			{
				val = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7);
			}
			ManagementObject val2 = (ManagementObject)Enumerable.ElementAtOrDefault<object>(Enumerable.Cast<object>((IEnumerable)new ManagementObjectSearcher(variables_0.GObjWmiService, val).Get()), 0);
			if (val2 == null && !bool_0)
			{
				val = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7 + " WHERE Name = '" + softwareLicensingProduct_0.Name + "' AND ApplicationID = '" + softwareLicensingProduct_0.ApplicationID + "' AND OfflineInstallationId IS NOT NULL");
				val2 = (ManagementObject)Enumerable.ElementAtOrDefault<object>(Enumerable.Cast<object>((IEnumerable)new ManagementObjectSearcher(variables_0.GObjWmiService, val).Get()), 0);
			}
			result = new SoftwareLicensingProduct(val2);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static OfficeSoftwareProtectionProduct smethod_16(string string_6, string string_7, ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0, bool bool_0 = false)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		OfficeSoftwareProtectionProduct result = null;
		try
		{
			ObjectQuery val = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7 + " WHERE PartialProductKey = '" + officeSoftwareProtectionProduct_0.PartialProductKey + "'");
			if (bool_0)
			{
				val = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7);
			}
			ManagementObject val2 = (ManagementObject)Enumerable.ElementAtOrDefault<object>(Enumerable.Cast<object>((IEnumerable)new ManagementObjectSearcher(variables_0.GObjWmiService, val).Get()), 0);
			if (val2 == null && !bool_0)
			{
				val = new ObjectQuery("SELECT " + string_6 + " FROM " + string_7 + " WHERE Name = '" + officeSoftwareProtectionProduct_0.Name + "' AND ApplicationID = '" + officeSoftwareProtectionProduct_0.ApplicationID + "' AND OfflineInstallationId IS NOT NULL");
				val2 = (ManagementObject)Enumerable.ElementAtOrDefault<object>(Enumerable.Cast<object>((IEnumerable)new ManagementObjectSearcher(variables_0.GObjWmiService, val).Get()), 0);
			}
			result = new OfficeSoftwareProtectionProduct(val2);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static List<SoftwareLicensingProduct> smethod_17(ref Variables variables_0)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		List<SoftwareLicensingProduct> list = new List<SoftwareLicensingProduct>();
		try
		{
			ManagementObjectCollection val = null;
			if (variables_0.IsWindows10)
			{
				val = smethod_2(ref variables_0);
			}
			else if (variables_0.IsWindows81)
			{
				val = smethod_4(ref variables_0);
			}
			else if (variables_0.IsWindows8)
			{
				val = smethod_0(ref variables_0);
			}
			else if (variables_0.IsWindows7)
			{
				val = smethod_10(ref variables_0);
			}
			else if (variables_0.IsWindowsVista)
			{
				val = smethod_12(ref variables_0);
			}
			if (val != null)
			{
				if (val.get_Count() > 0)
				{
					list = new List<SoftwareLicensingProduct>();
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					try
					{
						enumerator = val.GetEnumerator();
						while (enumerator.MoveNext())
						{
							ManagementObject theObject = (ManagementObject)enumerator.get_Current();
							list.Add(new SoftwareLicensingProduct(theObject));
						}
						return list;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				return list;
			}
			return list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return list;
		}
	}

	internal static SoftwareLicensingProduct smethod_18(SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		try
		{
			if (variables_0.IsWindows10)
			{
				softwareLicensingProduct_0 = smethod_3(ref softwareLicensingProduct_0, ref variables_0);
				return softwareLicensingProduct_0;
			}
			if (variables_0.IsWindows81)
			{
				softwareLicensingProduct_0 = smethod_5(ref softwareLicensingProduct_0, ref variables_0);
				return softwareLicensingProduct_0;
			}
			if (variables_0.IsWindows8)
			{
				softwareLicensingProduct_0 = smethod_1(ref softwareLicensingProduct_0, ref variables_0);
				return softwareLicensingProduct_0;
			}
			if (variables_0.IsWindows7)
			{
				softwareLicensingProduct_0 = smethod_11(ref softwareLicensingProduct_0, ref variables_0);
				return softwareLicensingProduct_0;
			}
			if (variables_0.IsWindowsVista)
			{
				softwareLicensingProduct_0 = smethod_13(ref softwareLicensingProduct_0, ref variables_0);
				return softwareLicensingProduct_0;
			}
			return softwareLicensingProduct_0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return softwareLicensingProduct_0;
		}
	}

	internal static List<OfficeSoftwareProtectionProduct> smethod_19(ref Variables variables_0, ref bool bool_0)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		List<OfficeSoftwareProtectionProduct> list = new List<OfficeSoftwareProtectionProduct>();
		try
		{
			ManagementObjectCollection val = null;
			val = (bool_0 ? smethod_8(ref variables_0) : smethod_6(ref variables_0));
			if (val != null)
			{
				if (val.get_Count() > 0)
				{
					list = new List<OfficeSoftwareProtectionProduct>();
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					try
					{
						enumerator = val.GetEnumerator();
						while (enumerator.MoveNext())
						{
							ManagementObject theObject = (ManagementObject)enumerator.get_Current();
							list.Add(new OfficeSoftwareProtectionProduct(theObject));
						}
						return list;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				return list;
			}
			return list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return list;
		}
	}

	internal static OfficeSoftwareProtectionProduct smethod_20(OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, Variables variables_0, ref bool bool_0)
	{
		try
		{
			if (!bool_0)
			{
				officeSoftwareProtectionProduct_0 = smethod_7(ref officeSoftwareProtectionProduct_0, ref variables_0);
				return officeSoftwareProtectionProduct_0;
			}
			officeSoftwareProtectionProduct_0 = smethod_9(ref officeSoftwareProtectionProduct_0, ref variables_0);
			return officeSoftwareProtectionProduct_0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return officeSoftwareProtectionProduct_0;
		}
	}

	internal static List<SoftwareLicensingService> smethod_21(ref Variables variables_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		List<SoftwareLicensingService> list = new List<SoftwareLicensingService>();
		try
		{
			ManagementObjectCollection val = smethod_23(ref variables_0);
			if (val != null)
			{
				if (val.get_Count() > 0)
				{
					list = new List<SoftwareLicensingService>();
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					try
					{
						enumerator = val.GetEnumerator();
						while (enumerator.MoveNext())
						{
							ManagementObject theObject = (ManagementObject)enumerator.get_Current();
							list.Add(new SoftwareLicensingService(theObject));
						}
						return list;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				return list;
			}
			return list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return list;
		}
	}

	internal static List<OfficeSoftwareProtectionService> smethod_22(ref Variables variables_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		List<OfficeSoftwareProtectionService> list = new List<OfficeSoftwareProtectionService>();
		try
		{
			ManagementObjectCollection val = smethod_24(ref variables_0);
			if (val != null)
			{
				if (val.get_Count() > 0)
				{
					list = new List<OfficeSoftwareProtectionService>();
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					try
					{
						enumerator = val.GetEnumerator();
						while (enumerator.MoveNext())
						{
							ManagementObject theObject = (ManagementObject)enumerator.get_Current();
							list.Add(new OfficeSoftwareProtectionService(theObject));
						}
						return list;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				return list;
			}
			return list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return list;
		}
	}

	private static ManagementObjectCollection smethod_23(ref Variables variables_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			variables_0.GObjWmiService = new ManagementScope("\\\\.\\root\\cimv2");
			variables_0.GObjWmiService.Connect();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
		return smethod_14("Version", "SoftwareLicensingService", ref variables_0, bool_0: true);
	}

	private static ManagementObjectCollection smethod_24(ref Variables variables_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			variables_0.GObjWmiService = new ManagementScope("\\\\.\\root\\cimv2");
			variables_0.GObjWmiService.Connect();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger = variables_0.Logger;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
		return smethod_14("Version", "OfficeSoftwareProtectionService", ref variables_0, bool_0: true);
	}

	internal static List<SoftwareLicensingProduct> smethod_25(ref List<SoftwareLicensingProduct> list_0, ref bool bool_0, ref bool bool_1, ref bool bool_2, ref Variables variables_0)
	{
		List<SoftwareLicensingProduct> list = new List<SoftwareLicensingProduct>();
		if (list_0 != null)
		{
			try
			{
				foreach (SoftwareLicensingProduct item in list_0)
				{
					SoftwareLicensingProduct softwareLicensingProduct_ = item;
					if (smethod_32(ref softwareLicensingProduct_, ref bool_0, ref bool_1, ref bool_2))
					{
						try
						{
							list.Add(softwareLicensingProduct_);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception exception_ = ex;
							string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
							FileLogger logger = variables_0.Logger;
							string message = "Error: " + str;
							logger.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
					}
				}
				return list;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger2 = variables_0.Logger;
				string message = "Error: " + str2;
				logger2.LogMessage(ref message);
				ProjectData.ClearProjectError();
				return list;
			}
		}
		return list;
	}

	internal static List<OfficeSoftwareProtectionProduct> smethod_26(ref List<OfficeSoftwareProtectionProduct> list_0, ref bool bool_0, ref bool bool_1, ref bool bool_2, ref Variables variables_0)
	{
		List<OfficeSoftwareProtectionProduct> list = new List<OfficeSoftwareProtectionProduct>();
		if (list_0 != null)
		{
			try
			{
				foreach (OfficeSoftwareProtectionProduct item in list_0)
				{
					OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_ = item;
					if (smethod_33(ref officeSoftwareProtectionProduct_, ref bool_0, ref bool_1, ref bool_2))
					{
						try
						{
							list.Add(officeSoftwareProtectionProduct_);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception exception_ = ex;
							string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
							FileLogger logger = variables_0.Logger;
							string message = "Error: " + str;
							logger.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
					}
				}
				return list;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger2 = variables_0.Logger;
				string message = "Error: " + str2;
				logger2.LogMessage(ref message);
				ProjectData.ClearProjectError();
				return list;
			}
		}
		return list;
	}

	internal static bool smethod_27(string string_6)
	{
		if (string_6.Contains("KMSCLIENT"))
		{
			return true;
		}
		if (string_6.Contains("KMS_Client"))
		{
			return true;
		}
		return false;
	}

	internal static bool smethod_28(string string_6)
	{
		if (string_6.Contains("OEM"))
		{
			return true;
		}
		return false;
	}

	internal static bool smethod_29(string string_6)
	{
		if (string_6.Contains("RETAIL"))
		{
			return true;
		}
		return false;
	}

	internal static bool smethod_30(string string_6)
	{
		if (string_6.Contains("MAK"))
		{
			return true;
		}
		return false;
	}

	internal static bool smethod_31(object object_0)
	{
		if (Strings.InStr(Conversions.ToString(object_0), "TIMEBASED", (CompareMethod)0) > 0)
		{
			return true;
		}
		return false;
	}

	private static bool smethod_32(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref bool bool_0, ref bool bool_1, ref bool bool_2)
	{
		string applicationID = softwareLicensingProduct_0.ApplicationID;
		string partialProductKey = softwareLicensingProduct_0.PartialProductKey;
		if (bool_0)
		{
			if (applicationID.ToLower().Contains("55c92734-d682-4d71-983e-d6ec3f16059f") && !string.IsNullOrEmpty(partialProductKey))
			{
				return !softwareLicensingProduct_0.LicenseIsAddon;
			}
		}
		else if (applicationID.ToLower().Contains("0ff1ce15-a989-479d-af46-f275c6370663") && !string.IsNullOrEmpty(partialProductKey))
		{
			if (bool_2 && softwareLicensingProduct_0.Description.Contains("Office 16"))
			{
				return !softwareLicensingProduct_0.LicenseIsAddon;
			}
			if (bool_1 && softwareLicensingProduct_0.Description.Contains("Office 15"))
			{
				return !softwareLicensingProduct_0.LicenseIsAddon;
			}
		}
		return false;
	}

	private static bool smethod_33(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref bool bool_0, ref bool bool_1, ref bool bool_2)
	{
		string applicationID = officeSoftwareProtectionProduct_0.ApplicationID;
		string partialProductKey = officeSoftwareProtectionProduct_0.PartialProductKey;
		if (!bool_2 && !bool_1)
		{
			if (bool_0 && applicationID.ToLower().Contains("59a52881-a989-479d-af46-f275c6370663") && !string.IsNullOrEmpty(partialProductKey))
			{
				return true;
			}
		}
		else if (applicationID.ToLower().Contains("0ff1ce15-a989-479d-af46-f275c6370663") && !string.IsNullOrEmpty(partialProductKey))
		{
			if (bool_2 && officeSoftwareProtectionProduct_0.Description.Contains("Office 16"))
			{
				return !officeSoftwareProtectionProduct_0.LicenseIsAddon;
			}
			if (bool_1 && officeSoftwareProtectionProduct_0.Description.Contains("Office 15"))
			{
				return !officeSoftwareProtectionProduct_0.LicenseIsAddon;
			}
		}
		return false;
	}

	public void method_0(ref Variables variables_0, ref List<SoftwareLicensingProduct> list_0)
	{
		bool bool_ = false;
		bool bool_2 = false;
		bool bool_3 = false;
		uint num = 0u;
		bool flag = false;
		Thread.Sleep(Class2.smethod_2(50, 400));
		SoftwareLicensingProduct softwareLicensingProduct_;
		while (true)
		{
			if (list_0.Count <= 0)
			{
				return;
			}
			softwareLicensingProduct_ = Enumerable.ElementAt<SoftwareLicensingProduct>((IEnumerable<SoftwareLicensingProduct>)list_0, 0);
			Class3.smethod_24(ref variables_0, ref variables_0.AudioProcessing);
			if (softwareLicensingProduct_.Name.Contains("Windows"))
			{
				bool_ = true;
			}
			else if (softwareLicensingProduct_.Name.Contains("Office 16"))
			{
				bool_3 = true;
			}
			else if (softwareLicensingProduct_.Name.Contains("Office 15"))
			{
				bool_2 = true;
			}
			if (smethod_27(softwareLicensingProduct_.Description))
			{
				if (softwareLicensingProduct_.GracePeriodRemaining != 259200)
				{
					if (variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8 || variables_0.IsWindows7)
					{
						try
						{
							if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
							{
								if (!softwareLicensingProduct_.KeyManagementServiceMachine.Contains(variables_0.KmsHostLocal.IpAddress))
								{
									num = softwareLicensingProduct_.SetKeyManagementServiceMachine(variables_0.KmsHostLocal.IpAddress);
									flag = true;
									FileLogger logger = variables_0.Logger;
									string message = "SetKeyManagementServiceMachine: " + Conversions.ToString(num) + ": " + variables_0.KmsHostLocal.IpAddress;
									logger.LogMessage(ref message);
								}
							}
							else if (!softwareLicensingProduct_.KeyManagementServiceMachine.Contains(variables_0.KmsHostForward.IpAddress))
							{
								num = softwareLicensingProduct_.SetKeyManagementServiceMachine(variables_0.KmsHostForward.IpAddress);
								flag = true;
								FileLogger logger2 = variables_0.Logger;
								string message = "SetKeyManagementServiceMachine: " + Conversions.ToString(num) + ": " + variables_0.KmsHostForward.IpAddress;
								logger2.LogMessage(ref message);
							}
						}
						catch (COMException ex)
						{
							ProjectData.SetProjectError((Exception)ex);
							COMException ex2 = ex;
							string message2 = ex2.Message;
							Exception exception_ = ex2;
							string str = Class2.smethod_4(ref exception_);
							ex2 = (COMException)exception_;
							string text = message2 + " " + str;
							FileLogger logger3 = variables_0.Logger;
							string message = "Error: " + text + " " + ex2.ErrorCode.ToString("X") + " " + softwareLicensingProduct_.Name;
							logger3.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
						try
						{
							if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
							{
								if (softwareLicensingProduct_.KeyManagementServicePort != variables_0.KmsHostLocal.Port)
								{
									num = softwareLicensingProduct_.SetKeyManagementServicePort(variables_0.KmsHostLocal.Port);
									flag = true;
									FileLogger logger4 = variables_0.Logger;
									string message = "SetKeyManagementServicePort: " + Conversions.ToString(num) + ": " + Conversions.ToString(variables_0.KmsHostLocal.Port);
									logger4.LogMessage(ref message);
								}
							}
							else if (softwareLicensingProduct_.KeyManagementServicePort != variables_0.KmsHostForward.Port)
							{
								num = softwareLicensingProduct_.SetKeyManagementServicePort(variables_0.KmsHostForward.Port);
								flag = true;
								FileLogger logger5 = variables_0.Logger;
								string message = "SetKeyManagementServicePort: " + Conversions.ToString(num) + ": " + Conversions.ToString(variables_0.KmsHostForward.Port);
								logger5.LogMessage(ref message);
							}
						}
						catch (COMException ex3)
						{
							ProjectData.SetProjectError((Exception)ex3);
							COMException ex4 = ex3;
							string message3 = ex4.Message;
							Exception exception_ = ex4;
							string str2 = Class2.smethod_4(ref exception_);
							ex4 = (COMException)exception_;
							string text2 = message3 + " " + str2;
							FileLogger logger6 = variables_0.Logger;
							string message = "Error: " + text2 + " " + ex4.ErrorCode.ToString("X") + " " + softwareLicensingProduct_.Name;
							logger6.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
						try
						{
							if ((variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8) && softwareLicensingProduct_.VLActivationTypeEnabled != 2)
							{
								num = softwareLicensingProduct_.SetVLActivationTypeEnabled(2u);
								flag = true;
								FileLogger logger7 = variables_0.Logger;
								string message = "SetVLActivationTypeEnabled " + Conversions.ToString(num);
								logger7.LogMessage(ref message);
							}
						}
						catch (COMException ex5)
						{
							ProjectData.SetProjectError((Exception)ex5);
							COMException ex6 = ex5;
							string message4 = ex6.Message;
							Exception exception_ = ex6;
							string str3 = Class2.smethod_4(ref exception_);
							ex6 = (COMException)exception_;
							string text3 = message4 + " " + str3;
							FileLogger logger8 = variables_0.Logger;
							string message = "Error: " + text3 + " " + ex6.ErrorCode.ToString("X") + " " + softwareLicensingProduct_.Name;
							logger8.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						if (flag)
						{
							SoftwareLicensingProduct softwareLicensingProduct = smethod_18(softwareLicensingProduct_, ref variables_0);
							list_0.Remove(softwareLicensingProduct_);
							list_0.Add(softwareLicensingProduct);
							softwareLicensingProduct_ = softwareLicensingProduct;
						}
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception exception_2 = ex7;
						string str4 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
						FileLogger logger9 = variables_0.Logger;
						string message = "Error: " + str4 + " " + softwareLicensingProduct_.Name;
						logger9.LogMessage(ref message);
						ProjectData.ClearProjectError();
					}
					try
					{
						num = softwareLicensingProduct_.Activate();
						FileLogger logger10 = variables_0.Logger;
						string message = softwareLicensingProduct_.Name + " Activated " + Conversions.ToString(num);
						logger10.LogMessage(ref message);
					}
					catch (COMException ex8)
					{
						ProjectData.SetProjectError((Exception)ex8);
						COMException ex9 = ex8;
						string message5 = ex9.Message;
						Exception exception_ = ex9;
						string str5 = Class2.smethod_4(ref exception_);
						ex9 = (COMException)exception_;
						string text4 = message5 + " " + str5;
						FileLogger logger11 = variables_0.Logger;
						string message = "Error: " + text4 + " " + ex9.ErrorCode.ToString("X") + " " + softwareLicensingProduct_.Name;
						logger11.LogMessage(ref message);
						message = ex9.ErrorCode.ToString("X");
						method_2(ref variables_0, ref softwareLicensingProduct_, ref message, ref bool_, ref bool_3, ref bool_2, ref list_0);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					FileLogger logger12 = variables_0.Logger;
					string message = softwareLicensingProduct_.Name + " was already Activated";
					logger12.LogMessage(ref message);
				}
			}
			else if (variables_0.IsPreview)
			{
				try
				{
					num = softwareLicensingProduct_.Activate();
					FileLogger logger13 = variables_0.Logger;
					string message = softwareLicensingProduct_.Name + " Activated " + Conversions.ToString(num);
					logger13.LogMessage(ref message);
				}
				catch (COMException ex10)
				{
					ProjectData.SetProjectError((Exception)ex10);
					COMException ex11 = ex10;
					string message6 = ex11.Message;
					Exception exception_ = ex11;
					string str6 = Class2.smethod_4(ref exception_);
					ex11 = (COMException)exception_;
					string text5 = message6 + " " + str6;
					FileLogger logger14 = variables_0.Logger;
					string message = "Error: " + text5 + " " + ex11.ErrorCode.ToString("X") + " " + softwareLicensingProduct_.Name;
					logger14.LogMessage(ref message);
					ProjectData.ClearProjectError();
				}
			}
			list_0.Remove(softwareLicensingProduct_);
			if (list_0.Count != 0)
			{
				Thread.Sleep(Class2.smethod_2(50, 400));
				continue;
			}
			break;
		}
		Class3.smethod_24(ref variables_0, ref variables_0.AudioAffirmative);
		if (bool_)
		{
			variables_0.IsWindowsListo.Value = bool_;
		}
		if (bool_3)
		{
			variables_0.IsOffice2016Listo.Value = bool_3;
		}
		if (bool_2)
		{
			variables_0.IsOffice2013Listo.Value = bool_2;
		}
		if (variables_0.IsWindowsListo.Value && variables_0.IsOffice2013Listo.Value && variables_0.IsOffice2016Listo.Value)
		{
			bool bool_4 = false;
			Class10.smethod_7(ref bool_4, ref variables_0);
			bool_4 = false;
			Class10.smethod_8(ref bool_4, ref variables_0);
			bool_4 = false;
			Class10.smethod_9(ref bool_4, ref variables_0);
		}
		if (variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8 || variables_0.IsWindows7)
		{
			try
			{
				num = softwareLicensingProduct_.ClearKeyManagementServiceMachine();
				FileLogger logger15 = variables_0.Logger;
				string message = "ClearKeyManagementServiceMachine " + Conversions.ToString(num);
				logger15.LogMessage(ref message);
				num = softwareLicensingProduct_.ClearKeyManagementServicePort();
				FileLogger logger16 = variables_0.Logger;
				message = "ClearKeyManagementServicePort " + Conversions.ToString(num);
				logger16.LogMessage(ref message);
			}
			catch (COMException ex12)
			{
				ProjectData.SetProjectError((Exception)ex12);
				COMException ex13 = ex12;
				string message7 = ex13.Message;
				Exception exception_ = ex13;
				string str7 = Class2.smethod_4(ref exception_);
				ex13 = (COMException)exception_;
				string text6 = message7 + " " + str7;
				FileLogger logger17 = variables_0.Logger;
				string message = "Error: " + text6 + " " + ex13.ErrorCode.ToString("X") + " " + softwareLicensingProduct_.Name;
				logger17.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}
		Class3.smethod_6(ref variables_0);
	}

	public void method_1(ref Variables variables_0, ref List<OfficeSoftwareProtectionProduct> list_0)
	{
		bool flag = false;
		bool flag2 = false;
		bool bool_ = false;
		uint num = 0u;
		bool flag3 = false;
		Thread.Sleep(Class2.smethod_2(50, 400));
		OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct;
		while (true)
		{
			if (list_0.Count <= 0)
			{
				return;
			}
			officeSoftwareProtectionProduct = Enumerable.ElementAt<OfficeSoftwareProtectionProduct>((IEnumerable<OfficeSoftwareProtectionProduct>)list_0, 0);
			Class3.smethod_24(ref variables_0, ref variables_0.AudioProcessing);
			if (officeSoftwareProtectionProduct.Name.Contains("Office 16"))
			{
				flag = true;
			}
			else if (officeSoftwareProtectionProduct.Name.Contains("Office 15"))
			{
				flag2 = true;
			}
			else if (officeSoftwareProtectionProduct.Name.Contains("Office 14"))
			{
				bool_ = true;
			}
			if (smethod_27(officeSoftwareProtectionProduct.Description))
			{
				if (officeSoftwareProtectionProduct.GracePeriodRemaining != 259200)
				{
					if (variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8 || variables_0.IsWindows7)
					{
						try
						{
							if ((!flag2 && !flag) || (!variables_0.IsWindows10 && !variables_0.IsWindows81))
							{
								if (!officeSoftwareProtectionProduct.KeyManagementServiceMachine.Contains(variables_0.KmsHostLocal.IpAddress))
								{
									num = officeSoftwareProtectionProduct.SetKeyManagementServiceMachine(variables_0.KmsHostLocal.IpAddress);
									flag3 = true;
									FileLogger logger = variables_0.Logger;
									string message = "SetKeyManagementServiceMachine: " + Conversions.ToString(num) + ": " + variables_0.KmsHostLocal.IpAddress;
									logger.LogMessage(ref message);
								}
							}
							else if (!officeSoftwareProtectionProduct.KeyManagementServiceMachine.Contains(variables_0.KmsHostForward.IpAddress))
							{
								num = officeSoftwareProtectionProduct.SetKeyManagementServiceMachine(variables_0.KmsHostForward.IpAddress);
								flag3 = true;
								FileLogger logger2 = variables_0.Logger;
								string message = "SetKeyManagementServiceMachine: " + Conversions.ToString(num) + ": " + variables_0.KmsHostForward.IpAddress;
								logger2.LogMessage(ref message);
							}
						}
						catch (COMException ex)
						{
							ProjectData.SetProjectError((Exception)ex);
							COMException ex2 = ex;
							string message2 = ex2.Message;
							Exception exception_ = ex2;
							string str = Class2.smethod_4(ref exception_);
							ex2 = (COMException)exception_;
							string text = message2 + " " + str;
							FileLogger logger3 = variables_0.Logger;
							string message = "Error: " + text + " " + ex2.ErrorCode.ToString("X") + " " + officeSoftwareProtectionProduct.Name;
							logger3.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
						try
						{
							if ((!flag2 && !flag) || (!variables_0.IsWindows10 && !variables_0.IsWindows81))
							{
								if (officeSoftwareProtectionProduct.KeyManagementServicePort != variables_0.KmsHostLocal.Port)
								{
									num = officeSoftwareProtectionProduct.SetKeyManagementServicePort(variables_0.KmsHostLocal.Port);
									flag3 = true;
									FileLogger logger4 = variables_0.Logger;
									string message = "SetKeyManagementServicePort: " + Conversions.ToString(num) + ": " + Conversions.ToString(variables_0.KmsHostLocal.Port);
									logger4.LogMessage(ref message);
								}
							}
							else if (officeSoftwareProtectionProduct.KeyManagementServicePort != variables_0.KmsHostForward.Port)
							{
								num = officeSoftwareProtectionProduct.SetKeyManagementServicePort(variables_0.KmsHostForward.Port);
								flag3 = true;
								FileLogger logger5 = variables_0.Logger;
								string message = "SetKeyManagementServicePort: " + Conversions.ToString(num) + ": " + Conversions.ToString(variables_0.KmsHostForward.Port);
								logger5.LogMessage(ref message);
							}
						}
						catch (COMException ex3)
						{
							ProjectData.SetProjectError((Exception)ex3);
							COMException ex4 = ex3;
							string message3 = ex4.Message;
							Exception exception_ = ex4;
							string str2 = Class2.smethod_4(ref exception_);
							ex4 = (COMException)exception_;
							string text2 = message3 + " " + str2;
							FileLogger logger6 = variables_0.Logger;
							string message = "Error: " + text2 + " " + ex4.ErrorCode.ToString("X") + " " + officeSoftwareProtectionProduct.Name;
							logger6.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						if (flag3)
						{
							OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct2 = smethod_20(officeSoftwareProtectionProduct, variables_0, ref bool_);
							list_0.Remove(officeSoftwareProtectionProduct);
							list_0.Add(officeSoftwareProtectionProduct2);
							officeSoftwareProtectionProduct = officeSoftwareProtectionProduct2;
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception exception_2 = ex5;
						string str3 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
						FileLogger logger7 = variables_0.Logger;
						string message = "Error: " + str3 + " " + officeSoftwareProtectionProduct.Name;
						logger7.LogMessage(ref message);
						ProjectData.ClearProjectError();
					}
					try
					{
						num = officeSoftwareProtectionProduct.Activate();
						FileLogger logger8 = variables_0.Logger;
						string message = officeSoftwareProtectionProduct.Name + " Activated " + Conversions.ToString(num);
						logger8.LogMessage(ref message);
					}
					catch (COMException ex6)
					{
						ProjectData.SetProjectError((Exception)ex6);
						COMException ex7 = ex6;
						string message4 = ex7.Message;
						Exception exception_ = ex7;
						string str4 = Class2.smethod_4(ref exception_);
						ex7 = (COMException)exception_;
						string text3 = message4 + " " + str4;
						FileLogger logger9 = variables_0.Logger;
						string message = "Error: " + text3 + " " + ex7.ErrorCode.ToString("X") + " " + officeSoftwareProtectionProduct.Name;
						logger9.LogMessage(ref message);
						method_3(ref variables_0, officeSoftwareProtectionProduct, ex7.ErrorCode.ToString("X"), bool_, flag2, flag, ref list_0);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					FileLogger logger10 = variables_0.Logger;
					string message = officeSoftwareProtectionProduct.Name + " was already Activated";
					logger10.LogMessage(ref message);
				}
			}
			list_0.Remove(officeSoftwareProtectionProduct);
			if (list_0.Count == 0)
			{
				break;
			}
			Thread.Sleep(Class2.smethod_2(50, 600));
		}
		Class3.smethod_24(ref variables_0, ref variables_0.AudioAffirmative);
		if (flag)
		{
			variables_0.IsOffice2016Listo.Value = flag;
		}
		if (flag2)
		{
			variables_0.IsOffice2013Listo.Value = flag2;
		}
		if (bool_)
		{
			variables_0.IsOffice2010Listo.Value = bool_;
		}
		if (variables_0.IsOffice2010Listo.Value && variables_0.IsOffice2013Listo.Value && variables_0.IsOffice2016Listo.Value)
		{
			bool bool_2 = false;
			Class10.smethod_8(ref bool_2, ref variables_0);
			bool_2 = false;
			Class10.smethod_9(ref bool_2, ref variables_0);
			bool_2 = false;
			Class10.smethod_6(ref bool_2, ref variables_0);
		}
		if (variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8 || variables_0.IsWindows7)
		{
			try
			{
				num = officeSoftwareProtectionProduct.ClearKeyManagementServiceMachine();
				FileLogger logger11 = variables_0.Logger;
				string message = "ClearKeyManagementServiceMachine " + Conversions.ToString(num);
				logger11.LogMessage(ref message);
				num = officeSoftwareProtectionProduct.ClearKeyManagementServicePort();
				FileLogger logger12 = variables_0.Logger;
				message = "ClearKeyManagementServicePort " + Conversions.ToString(num);
				logger12.LogMessage(ref message);
			}
			catch (COMException ex8)
			{
				ProjectData.SetProjectError((Exception)ex8);
				COMException ex9 = ex8;
				string message5 = ex9.Message;
				Exception exception_ = ex9;
				string str5 = Class2.smethod_4(ref exception_);
				ex9 = (COMException)exception_;
				string text4 = message5 + " " + str5;
				FileLogger logger13 = variables_0.Logger;
				string message = "Error: " + text4 + " " + ex9.ErrorCode.ToString("X") + " " + officeSoftwareProtectionProduct.Name;
				logger13.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}
		Class3.smethod_6(ref variables_0);
	}

	private void method_2(ref Variables variables_0, ref SoftwareLicensingProduct softwareLicensingProduct_0, ref string string_6, ref bool bool_0, ref bool bool_1, ref bool bool_2, ref List<SoftwareLicensingProduct> list_0)
	{
		checked
		{
			variables_0.IntentosActivacion++;
		}
		if (variables_0.IntentosActivacion <= 20)
		{
			Class3.smethod_24(ref variables_0, ref variables_0.AudioInputFailed);
			if (variables_0.IntentosActivacion % 2 != 0)
			{
				Variables variables_ = variables_0;
				new Thread((ThreadStart)delegate
				{
					ref Variables variables_2 = ref variables_;
					bool bool_4 = true;
					Class3.smethod_21(ref variables_2, ref bool_4);
				}).Start();
			}
			if (bool_0)
			{
				variables_0.IsWindowsListo.Value = false;
			}
			else if (bool_1)
			{
				variables_0.IsOffice2016Listo.Value = false;
			}
			else if (bool_2)
			{
				variables_0.IsOffice2013Listo.Value = false;
			}
			if (bool_0)
			{
				Class3.smethod_20(ref variables_0);
			}
			else if (bool_1)
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows8)
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2016V5;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
					else
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2016V4;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
				}
				else
				{
					KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2016V6;
					Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
				}
			}
			else if (bool_2)
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows8)
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2013V5;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
					else
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2013V4;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
				}
				else
				{
					KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2013V6;
					Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
				}
			}
			if (!string_6.Contains("80070005") && !string_6.Contains("8007000D") && !string_6.Contains("C004F038") && !string_6.Contains("C004F039") && !string_6.Contains("C004F074"))
			{
				if (!string_6.Contains("C004C001") && !string_6.Contains("C004C003") && !string_6.Contains("C004C017") && !string_6.Contains("C004C008") && !string_6.Contains("C004F014") && !string_6.Contains("C004F050") && !string_6.Contains("8007007B") && !string_6.Contains("C004D302") && !string_6.Contains("C004F069") && !string_6.Contains("80072EE7") && !string_6.Contains("8007267C") && !string_6.Contains("8007232B") && !string_6.Contains("8007267C"))
				{
					if (!string_6.Contains("C004F009") && !string_6.Contains("C004F200"))
					{
						if (string_6.Contains("C004F065"))
						{
							if (variables_0.IntentosActivacion < 19)
							{
								Thread.Sleep(Class2.smethod_2(50, 600));
								if (bool_0)
								{
									UndoGenuine.smethod_0(ref variables_0);
									Activador.smethod_2(ref variables_0);
								}
							}
						}
						else if (string_6.Contains("C004F017"))
						{
							Key.smethod_11(ref softwareLicensingProduct_0, bool_0, ref variables_0);
							SoftwareLicensingProduct softwareLicensingProduct = smethod_18(softwareLicensingProduct_0, ref variables_0);
							list_0.Add(softwareLicensingProduct);
							softwareLicensingProduct_0 = softwareLicensingProduct;
							if (variables_0.IntentosActivacion < 19)
							{
								Thread.Sleep(Class2.smethod_2(50, 600));
								if (bool_0)
								{
									Activador.smethod_2(ref variables_0);
								}
								else if (bool_2)
								{
									if (variables_0.IntentosActivacion > 7)
									{
										if (variables_0.ColeccionOffice2013W8.Count > 0)
										{
											variables_0.ColeccionOffice2013W8.Remove(softwareLicensingProduct_0);
										}
									}
									else
									{
										RT2VL.smethod_20(ref softwareLicensingProduct_0, ref variables_0);
									}
									Activador.smethod_4(ref variables_0);
								}
							}
						}
						else if (string_6.Contains("C004E015") || string_6.Contains("C004F069"))
						{
							if (bool_0)
							{
								RT2VL.smethod_1(ref variables_0);
							}
							else if (bool_1)
							{
								string empty = string.Empty;
								string name = softwareLicensingProduct_0.Name;
								RT2VL.smethod_3(ref empty, ref variables_0, ref name);
							}
							else if (bool_2)
							{
								string name = string.Empty;
								RT2VL.smethod_4(ref name, ref variables_0);
							}
							Key.smethod_11(ref softwareLicensingProduct_0, bool_0, ref variables_0);
							SoftwareLicensingProduct softwareLicensingProduct2 = smethod_18(softwareLicensingProduct_0, ref variables_0);
							list_0.Remove(softwareLicensingProduct_0);
							list_0.Add(softwareLicensingProduct2);
							softwareLicensingProduct_0 = softwareLicensingProduct2;
							if (variables_0.IntentosActivacion < 19)
							{
								Thread.Sleep(Class2.smethod_2(50, 600));
								if (bool_0)
								{
									Activador.smethod_2(ref variables_0);
								}
								else if (bool_1)
								{
									if (variables_0.IntentosActivacion > 7)
									{
										if (variables_0.ColeccionOffice2016W8.Count > 0)
										{
											variables_0.ColeccionOffice2016W8.Remove(softwareLicensingProduct_0);
										}
									}
									else
									{
										RT2VL.smethod_13(ref softwareLicensingProduct_0, ref variables_0);
									}
									Activador.smethod_3(ref variables_0);
								}
								else if (bool_2)
								{
									if (variables_0.IntentosActivacion > 7)
									{
										if (variables_0.ColeccionOffice2013W8.Count > 0)
										{
											variables_0.ColeccionOffice2013W8.Remove(softwareLicensingProduct_0);
										}
									}
									else
									{
										RT2VL.smethod_20(ref softwareLicensingProduct_0, ref variables_0);
									}
									Activador.smethod_4(ref variables_0);
								}
							}
						}
					}
					else
					{
						smethod_42(ref softwareLicensingProduct_0, ref variables_0);
						Key.smethod_11(ref softwareLicensingProduct_0, bool_0, ref variables_0);
						SoftwareLicensingProduct softwareLicensingProduct3 = smethod_18(softwareLicensingProduct_0, ref variables_0);
						list_0.Add(softwareLicensingProduct3);
						softwareLicensingProduct_0 = softwareLicensingProduct3;
						if (variables_0.IntentosActivacion < 19)
						{
							Thread.Sleep(Class2.smethod_2(50, 600));
							if (bool_0)
							{
								Activador.smethod_2(ref variables_0);
							}
							else if (bool_1)
							{
								Activador.smethod_3(ref variables_0);
							}
							else if (bool_2)
							{
								Activador.smethod_4(ref variables_0);
							}
						}
					}
				}
				else
				{
					Key.smethod_11(ref softwareLicensingProduct_0, bool_0, ref variables_0);
					SoftwareLicensingProduct softwareLicensingProduct4 = smethod_18(softwareLicensingProduct_0, ref variables_0);
					list_0.Remove(softwareLicensingProduct_0);
					list_0.Add(softwareLicensingProduct4);
					softwareLicensingProduct_0 = softwareLicensingProduct4;
					if (variables_0.IntentosActivacion < 19)
					{
						Thread.Sleep(Class2.smethod_2(50, 600));
						if (bool_0)
						{
							Activador.smethod_2(ref variables_0);
						}
						else if (bool_1)
						{
							Activador.smethod_3(ref variables_0);
						}
						else if (bool_2)
						{
							Activador.smethod_4(ref variables_0);
						}
					}
				}
			}
			else
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.InternetConnection && variables_0.ServersOnline.Length > 0 && variables_0.IntentosActivacion >= 7 && variables_0.IntentosActivacion < 18)
					{
						FileLogger logger = variables_0.Logger;
						string empty = "Using Plan B...";
						logger.LogMessage(ref empty);
						variables_0.IsSecohQad.Value = false;
						variables_0.IsWinDivert.Value = false;
						variables_0.IsTapDriver.Value = false;
						variables_0.IsOnline.Value = true;
						HostServer hostServer_ = null;
						Class3.smethod_19(ref variables_0, ref hostServer_);
					}
				}
				else if (variables_0.IntentosActivacion < 5)
				{
					HostServer hostServer_ = null;
					Class3.smethod_19(ref variables_0, ref hostServer_);
				}
				else if (variables_0.IntentosActivacion >= 6 && variables_0.IntentosActivacion < 10)
				{
					if (variables_0.IsSecohQad.Value)
					{
						FileLogger logger2 = variables_0.Logger;
						string empty = "Using Plan B...";
						logger2.LogMessage(ref empty);
						variables_0.IsSecohQad.Value = false;
						variables_0.IsWinDivert.Value = true;
						HostServer hostServer_ = null;
						Class3.smethod_19(ref variables_0, ref hostServer_);
					}
				}
				else if (variables_0.IntentosActivacion >= 10 && variables_0.IntentosActivacion < 14)
				{
					if (variables_0.IsWinDivert.Value)
					{
						FileLogger logger3 = variables_0.Logger;
						string empty = "Using Plan C...";
						logger3.LogMessage(ref empty);
						variables_0.IsWinDivert.Value = false;
						variables_0.IsTapDriver.Value = true;
						HostServer hostServer_ = null;
						Class3.smethod_19(ref variables_0, ref hostServer_);
					}
				}
				else if (variables_0.IntentosActivacion >= 14 && variables_0.IntentosActivacion < 18 && variables_0.InternetConnection && variables_0.ServersOnline.Length > 0)
				{
					FileLogger logger4 = variables_0.Logger;
					string empty = "Using Plan D...";
					logger4.LogMessage(ref empty);
					variables_0.IsSecohQad.Value = false;
					variables_0.IsWinDivert.Value = false;
					variables_0.IsTapDriver.Value = false;
					variables_0.IsOnline.Value = true;
					HostServer hostServer_ = null;
					Class3.smethod_19(ref variables_0, ref hostServer_);
				}
				if (variables_0.IntentosActivacion < 19)
				{
					Thread.Sleep(Class2.smethod_2(50, 600));
					if (bool_0)
					{
						Activador.smethod_2(ref variables_0);
					}
					else if (bool_1)
					{
						Activador.smethod_3(ref variables_0);
					}
					else if (bool_2)
					{
						Activador.smethod_4(ref variables_0);
					}
				}
			}
		}
		if (bool_0)
		{
			bool bool_3 = false;
			Class10.smethod_7(ref bool_3, ref variables_0);
			variables_0.IsWindowsListo.Value = bool_0;
		}
		if (bool_1)
		{
			bool bool_3 = false;
			Class10.smethod_8(ref bool_3, ref variables_0);
			variables_0.IsOffice2016Listo.Value = bool_1;
		}
		if (bool_2)
		{
			bool bool_3 = false;
			Class10.smethod_9(ref bool_3, ref variables_0);
			variables_0.IsOffice2013Listo.Value = bool_2;
		}
		if (variables_0.IntentosActivacion > 20)
		{
			variables_0.IsWindowsListo.Value = true;
			variables_0.IsOffice2016Listo.Value = true;
			variables_0.IsOffice2013Listo.Value = true;
			variables_0.IsOffice2010Listo.Value = true;
		}
		Class3.smethod_6(ref variables_0);
	}

	private void method_3(ref Variables variables_0, OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, string string_6, bool bool_0, bool bool_1, bool bool_2, ref List<OfficeSoftwareProtectionProduct> list_0)
	{
		checked
		{
			variables_0.IntentosActivacion++;
		}
		if (variables_0.IntentosActivacion <= 20)
		{
			Class3.smethod_24(ref variables_0, ref variables_0.AudioInputFailed);
			if (variables_0.IntentosActivacion % 2 != 0 && variables_0.IsWindowsListo.Value)
			{
				Variables variables_ = variables_0;
				new Thread((ThreadStart)delegate
				{
					ref Variables variables_2 = ref variables_;
					bool bool_4 = true;
					Class3.smethod_21(ref variables_2, ref bool_4);
				}).Start();
			}
			if (bool_2)
			{
				variables_0.IsOffice2016Listo.Value = false;
			}
			else if (bool_1)
			{
				variables_0.IsOffice2013Listo.Value = false;
			}
			else if (bool_0)
			{
				variables_0.IsOffice2010Listo.Value = false;
			}
			if (bool_2)
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows8)
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2016V5;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
					else
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2016V4;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
				}
				else
				{
					KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2016V6;
					Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
				}
			}
			else if (bool_1)
			{
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows8)
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2013V5;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
					else
					{
						KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2013V4;
						Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
					}
				}
				else
				{
					KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2013V6;
					Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
				}
			}
			else if (bool_0)
			{
				KMSClientProduct kmsclientProduct_ = KMSClientProduct.Office2010;
				Class3.smethod_22(ref variables_0, ref kmsclientProduct_);
			}
			if (!string_6.Contains("80070005") && !string_6.Contains("8007000D") && !string_6.Contains("C004F038") && !string_6.Contains("C004F039") && !string_6.Contains("C004F074"))
			{
				if (!string_6.Contains("C004C001") && !string_6.Contains("C004C003") && !string_6.Contains("C004C017") && !string_6.Contains("C004C008") && !string_6.Contains("C004F014") && !string_6.Contains("C004F050") && !string_6.Contains("8007007B") && !string_6.Contains("C004D302") && !string_6.Contains("C004F069") && !string_6.Contains("80072EE7") && !string_6.Contains("8007267C") && !string_6.Contains("8007232B") && !string_6.Contains("8007267C"))
				{
					if (!string_6.Contains("C004F009") && !string_6.Contains("C004F200"))
					{
						if (!string_6.Contains("C004F065"))
						{
							if (string_6.Contains("C004F017"))
							{
								Key.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
								OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct = smethod_20(officeSoftwareProtectionProduct_0, variables_0, ref bool_0);
								list_0.Remove(officeSoftwareProtectionProduct_0);
								list_0.Add(officeSoftwareProtectionProduct);
								officeSoftwareProtectionProduct_0 = officeSoftwareProtectionProduct;
								if (variables_0.IntentosActivacion < 19)
								{
									Thread.Sleep(Class2.smethod_2(50, 600));
									if (bool_2)
									{
										if (variables_0.IntentosActivacion > 7)
										{
											if (variables_0.ColeccionOffice2016W7.Count > 0)
											{
												variables_0.ColeccionOffice2016W7.Remove(officeSoftwareProtectionProduct_0);
											}
										}
										else
										{
											RT2VL.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
										}
										Activador.smethod_3(ref variables_0);
									}
									else if (bool_1)
									{
										if (variables_0.IntentosActivacion > 7)
										{
											if (variables_0.ColeccionOffice2013W7.Count > 0)
											{
												variables_0.ColeccionOffice2013W7.Remove(officeSoftwareProtectionProduct_0);
											}
										}
										else
										{
											RT2VL.smethod_21(ref officeSoftwareProtectionProduct_0, ref variables_0);
										}
										Activador.smethod_4(ref variables_0);
									}
									else if (bool_0)
									{
										if (variables_0.IntentosActivacion > 7)
										{
											if (variables_0.ColeccionOffice2010.Count > 0)
											{
												variables_0.ColeccionOffice2010.Remove(officeSoftwareProtectionProduct_0);
											}
										}
										else
										{
											RT2VL.smethod_24(ref officeSoftwareProtectionProduct_0, ref variables_0);
										}
										Activador.smethod_5(ref variables_0);
									}
								}
							}
							else if (string_6.Contains("C004E015") || string_6.Contains("C004F069"))
							{
								if (bool_2)
								{
									string empty = string.Empty;
									string name = officeSoftwareProtectionProduct_0.Name;
									RT2VL.smethod_3(ref empty, ref variables_0, ref name);
								}
								else if (bool_1)
								{
									string name = string.Empty;
									RT2VL.smethod_4(ref name, ref variables_0);
								}
								Key.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
								OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct2 = smethod_20(officeSoftwareProtectionProduct_0, variables_0, ref bool_0);
								list_0.Remove(officeSoftwareProtectionProduct_0);
								list_0.Add(officeSoftwareProtectionProduct2);
								officeSoftwareProtectionProduct_0 = officeSoftwareProtectionProduct2;
								if (variables_0.IntentosActivacion < 19)
								{
									Thread.Sleep(Class2.smethod_2(50, 600));
									if (bool_2)
									{
										if (variables_0.IntentosActivacion > 7)
										{
											if (variables_0.ColeccionOffice2016W7.Count > 0)
											{
												variables_0.ColeccionOffice2016W7.Remove(officeSoftwareProtectionProduct_0);
											}
										}
										else
										{
											RT2VL.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
										}
										Activador.smethod_3(ref variables_0);
									}
									else if (bool_1)
									{
										if (variables_0.IntentosActivacion > 7)
										{
											if (variables_0.ColeccionOffice2013W7.Count > 0)
											{
												variables_0.ColeccionOffice2013W7.Remove(officeSoftwareProtectionProduct_0);
											}
										}
										else
										{
											RT2VL.smethod_21(ref officeSoftwareProtectionProduct_0, ref variables_0);
										}
										Activador.smethod_4(ref variables_0);
									}
									else if (bool_0)
									{
										if (variables_0.IntentosActivacion > 7)
										{
											if (variables_0.ColeccionOffice2010.Count > 0)
											{
												variables_0.ColeccionOffice2010.Remove(officeSoftwareProtectionProduct_0);
											}
										}
										else
										{
											RT2VL.smethod_24(ref officeSoftwareProtectionProduct_0, ref variables_0);
										}
										Activador.smethod_5(ref variables_0);
									}
								}
							}
						}
					}
					else
					{
						smethod_41(ref officeSoftwareProtectionProduct_0, ref variables_0);
						Key.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
						OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct3 = smethod_20(officeSoftwareProtectionProduct_0, variables_0, ref bool_0);
						list_0.Remove(officeSoftwareProtectionProduct_0);
						list_0.Add(officeSoftwareProtectionProduct3);
						officeSoftwareProtectionProduct_0 = officeSoftwareProtectionProduct3;
					}
				}
				else
				{
					Key.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
					OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct4 = smethod_20(officeSoftwareProtectionProduct_0, variables_0, ref bool_0);
					list_0.Remove(officeSoftwareProtectionProduct_0);
					list_0.Add(officeSoftwareProtectionProduct4);
					officeSoftwareProtectionProduct_0 = officeSoftwareProtectionProduct4;
					if (variables_0.IntentosActivacion < 19)
					{
						Thread.Sleep(Class2.smethod_2(50, 600));
						if (bool_2)
						{
							Activador.smethod_3(ref variables_0);
						}
						else if (bool_1)
						{
							Activador.smethod_4(ref variables_0);
						}
						else if (bool_0)
						{
							Activador.smethod_5(ref variables_0);
						}
					}
				}
			}
			else
			{
				if ((!bool_1 && !bool_2) || (!variables_0.IsWindows10 && !variables_0.IsWindows81))
				{
					if (variables_0.InternetConnection && variables_0.ServersOnline.Length > 0 && variables_0.IntentosActivacion >= 6 && variables_0.IntentosActivacion < 18)
					{
						FileLogger logger = variables_0.Logger;
						string empty = "Using Plan B...";
						logger.LogMessage(ref empty);
						variables_0.IsSecohQad.Value = false;
						variables_0.IsWinDivert.Value = false;
						variables_0.IsTapDriver.Value = false;
						variables_0.IsOnline.Value = true;
						HostServer hostServer_ = null;
						Class3.smethod_19(ref variables_0, ref hostServer_);
					}
				}
				else if (variables_0.IntentosActivacion < 5)
				{
					HostServer hostServer_ = null;
					Class3.smethod_19(ref variables_0, ref hostServer_);
				}
				else if (variables_0.IntentosActivacion >= 6 && variables_0.IntentosActivacion < 10)
				{
					if (variables_0.IsSecohQad.Value)
					{
						FileLogger logger2 = variables_0.Logger;
						string empty = "Using Plan B...";
						logger2.LogMessage(ref empty);
						variables_0.IsSecohQad.Value = false;
						variables_0.IsWinDivert.Value = true;
						HostServer hostServer_ = null;
						Class3.smethod_19(ref variables_0, ref hostServer_);
					}
				}
				else if (variables_0.IntentosActivacion >= 10 && variables_0.IntentosActivacion < 14)
				{
					if (variables_0.IsWinDivert.Value)
					{
						FileLogger logger3 = variables_0.Logger;
						string empty = "Using Plan C...";
						logger3.LogMessage(ref empty);
						variables_0.IsWinDivert.Value = false;
						variables_0.IsTapDriver.Value = true;
						HostServer hostServer_ = null;
						Class3.smethod_19(ref variables_0, ref hostServer_);
					}
				}
				else if (variables_0.IntentosActivacion >= 14 && variables_0.IntentosActivacion < 18 && variables_0.InternetConnection && variables_0.ServersOnline.Length > 0)
				{
					FileLogger logger4 = variables_0.Logger;
					string empty = "Using Plan D...";
					logger4.LogMessage(ref empty);
					variables_0.IsSecohQad.Value = false;
					variables_0.IsWinDivert.Value = false;
					variables_0.IsTapDriver.Value = false;
					variables_0.IsOnline.Value = true;
					HostServer hostServer_ = null;
					Class3.smethod_19(ref variables_0, ref hostServer_);
				}
				if (variables_0.IntentosActivacion < 19)
				{
					Thread.Sleep(Class2.smethod_2(50, 600));
				}
			}
		}
		if (bool_2)
		{
			bool bool_3 = false;
			Class10.smethod_8(ref bool_3, ref variables_0);
			variables_0.IsOffice2016Listo.Value = bool_2;
		}
		if (bool_1)
		{
			bool bool_3 = false;
			Class10.smethod_9(ref bool_3, ref variables_0);
			variables_0.IsOffice2013Listo.Value = bool_1;
		}
		if (bool_0)
		{
			bool bool_3 = false;
			Class10.smethod_6(ref bool_3, ref variables_0);
			variables_0.IsOffice2010Listo.Value = bool_0;
		}
		if (variables_0.IntentosActivacion > 20)
		{
			variables_0.IsWindowsListo.Value = true;
			variables_0.IsOffice2016Listo.Value = true;
			variables_0.IsOffice2013Listo.Value = true;
			variables_0.IsOffice2010Listo.Value = true;
		}
		Class3.smethod_6(ref variables_0);
	}

	internal static uint smethod_34(ref SoftwareLicensingService softwareLicensingService_0, ref string string_6, ref Variables variables_0, ref string string_7)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		uint result = 1u;
		if (softwareLicensingService_0 != null)
		{
			FileLogger logger = variables_0.Logger;
			string message = "Installing Key: " + string_6.Substring(23);
			logger.LogMessage(ref message);
			try
			{
				if (!string_6.StartsWith("BBBBB"))
				{
					if (new Regex("^([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})$").IsMatch(string_6))
					{
						result = softwareLicensingService_0.InstallProductKey(string_6);
						FileLogger logger2 = variables_0.Logger;
						message = "InstallProductKey " + string_6.Substring(23) + " " + Conversions.ToString(result);
						logger2.LogMessage(ref message);
						try
						{
							result = softwareLicensingService_0.RefreshLicenseStatus();
							FileLogger logger3 = variables_0.Logger;
							message = "RefreshLicenseStatus " + Conversions.ToString(result);
							logger3.LogMessage(ref message);
						}
						catch (COMException ex)
						{
							ProjectData.SetProjectError((Exception)ex);
							COMException ex2 = ex;
							string str = ex2.ErrorCode.ToString("X");
							Exception exception_ = ex2;
							string str2 = Class2.smethod_4(ref exception_);
							ex2 = (COMException)exception_;
							string_7 = str + " " + str2;
							FileLogger logger4 = variables_0.Logger;
							message = "Error: " + string_7;
							logger4.LogMessage(ref message);
							ProjectData.ClearProjectError();
						}
						Class3.smethod_24(ref variables_0, ref variables_0.AudioInputOk);
						return result;
					}
					return result;
				}
				return result;
			}
			catch (COMException ex3)
			{
				ProjectData.SetProjectError((Exception)ex3);
				COMException ex4 = ex3;
				string str3 = ex4.ErrorCode.ToString("X");
				Exception exception_ = ex4;
				string str4 = Class2.smethod_4(ref exception_);
				ex4 = (COMException)exception_;
				string_7 = str3 + " " + str4;
				FileLogger logger5 = variables_0.Logger;
				message = "Error: " + string_7;
				logger5.LogMessage(ref message);
				result = 1u;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}

	internal static uint smethod_35(ref OfficeSoftwareProtectionService officeSoftwareProtectionService_0, ref string string_6, ref Variables variables_0, ref string string_7)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		uint result = 1u;
		if (officeSoftwareProtectionService_0 != null)
		{
			FileLogger logger = variables_0.Logger;
			string message = "Installing Key: " + string_6.Substring(23);
			logger.LogMessage(ref message);
			try
			{
				if (!string_6.StartsWith("BBBBB"))
				{
					if (new Regex("^([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})$").IsMatch(string_6))
					{
						result = officeSoftwareProtectionService_0.InstallProductKey(string_6);
						FileLogger logger2 = variables_0.Logger;
						message = "InstallProductKey " + string_6.Substring(23) + " " + Conversions.ToString(result);
						logger2.LogMessage(ref message);
						Class3.smethod_24(ref variables_0, ref variables_0.AudioInputOk);
						return result;
					}
					return result;
				}
				return result;
			}
			catch (COMException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				COMException ex2 = ex;
				string str = ex2.ErrorCode.ToString("X");
				Exception exception_ = ex2;
				string str2 = Class2.smethod_4(ref exception_);
				ex2 = (COMException)exception_;
				string_7 = str + " " + str2;
				FileLogger logger3 = variables_0.Logger;
				message = "Error: " + string_7;
				logger3.LogMessage(ref message);
				result = 1u;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}

	internal static uint smethod_36(ref SoftwareLicensingService softwareLicensingService_0, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = softwareLicensingService_0.RefreshLicenseStatus();
			FileLogger logger = variables_0.Logger;
			string message = "RefreshLicenseStatus " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	internal static uint smethod_37(ref SoftwareLicensingService softwareLicensingService_0, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = softwareLicensingService_0.ClearProductKeyFromRegistry();
			FileLogger logger = variables_0.Logger;
			string message = "ClearProductKeyFromRegistry " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	internal static uint smethod_38(ref OfficeSoftwareProtectionService officeSoftwareProtectionService_0, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = officeSoftwareProtectionService_0.ClearProductKeyFromRegistry();
			FileLogger logger = variables_0.Logger;
			string message = "ClearProductKeyFromRegistry " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	internal static uint smethod_39(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = softwareLicensingProduct_0.UninstallProductKey();
			FileLogger logger = variables_0.Logger;
			string message = softwareLicensingProduct_0.PartialProductKey + " UninstallProductKey " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	internal static uint smethod_40(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = officeSoftwareProtectionProduct_0.UninstallProductKey();
			FileLogger logger = variables_0.Logger;
			string message = officeSoftwareProtectionProduct_0.PartialProductKey + " UninstallProductKey " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	private static void smethod_41(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
	{
		if (officeSoftwareProtectionProduct_0.Description.Contains("Office 16"))
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Microsoft Office\\Office16";
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(text))
			{
				text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft Office\\Office16";
			}
			string text2 = "OSPPREARM.EXE";
			string[] array = Class2.smethod_0(ref variables_0, ref text2, text);
			ArrayList arrayList_ = null;
			bool bool_ = true;
			Class3.smethod_1(ref array, ref arrayList_, ref variables_0, ref bool_);
		}
		else if (officeSoftwareProtectionProduct_0.Description.Contains("Office 15"))
		{
			string text2 = "OSPPREARM.EXE";
			string[] array = Class2.smethod_0(ref variables_0, ref text2, Conversions.ToString(variables_0.RutaOffice2013));
			ArrayList arrayList_ = null;
			bool bool_ = true;
			Class3.smethod_1(ref array, ref arrayList_, ref variables_0, ref bool_);
		}
		else if (officeSoftwareProtectionProduct_0.Description.Contains("Office 14"))
		{
			string text2 = "OSPPREARM.EXE";
			string[] array = Class2.smethod_0(ref variables_0, ref text2, Conversions.ToString(variables_0.RutaOffice2010));
			ArrayList arrayList_ = null;
			bool bool_ = true;
			Class3.smethod_1(ref array, ref arrayList_, ref variables_0, ref bool_);
		}
	}

	private static void smethod_42(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
	{
		if (softwareLicensingProduct_0.Description.Contains("Office 16"))
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Microsoft Office\\Office16";
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(text))
			{
				text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft Office\\Office16";
			}
			string text2 = "OSPPREARM.EXE";
			string[] array = Class2.smethod_0(ref variables_0, ref text2, text);
			ArrayList arrayList_ = null;
			bool bool_ = true;
			Class3.smethod_1(ref array, ref arrayList_, ref variables_0, ref bool_);
		}
		else if (softwareLicensingProduct_0.Description.Contains("Office 15"))
		{
			string text2 = "OSPPREARM.EXE";
			string[] array = Class2.smethod_0(ref variables_0, ref text2, Conversions.ToString(variables_0.RutaOffice2013));
			ArrayList arrayList_ = null;
			bool bool_ = true;
			Class3.smethod_1(ref array, ref arrayList_, ref variables_0, ref bool_);
		}
		else if (softwareLicensingProduct_0.Description.Contains("Windows"))
		{
			smethod_43(ref variables_0);
		}
	}

	internal static uint smethod_43(ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = smethod_49(ref variables_0).ReArmWindows();
			FileLogger logger = variables_0.Logger;
			string message = "ReArmWindows " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	internal static object smethod_44(ref SoftwareLicensingService softwareLicensingService_0, ref string string_6, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = softwareLicensingService_0.InstallLicense(string_6);
			FileLogger logger = variables_0.Logger;
			string message = "InstallLicense " + Conversions.ToString(num);
			logger.LogMessage(ref message);
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	internal static object smethod_45(ref OfficeSoftwareProtectionService officeSoftwareProtectionService_0, ref string string_6, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = officeSoftwareProtectionService_0.InstallLicense(string_6);
			FileLogger logger = variables_0.Logger;
			string message = "InstallLicense " + Conversions.ToString(num);
			logger.LogMessage(ref message);
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	internal static void smethod_46(ref Variables variables_0, ref bool bool_0, ref bool bool_1, ref bool bool_2, ref bool bool_3)
	{
		if (bool_0)
		{
			List<SoftwareLicensingProduct> list_ = smethod_17(ref variables_0);
			variables_0.ColeccionWindows = smethod_25(ref list_, ref bool_0, ref bool_2, ref bool_3, ref variables_0);
		}
		else if (bool_3)
		{
			if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
			{
				if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
				{
					bool bool_4 = false;
					List<OfficeSoftwareProtectionProduct> list_2 = smethod_19(ref variables_0, ref bool_4);
					variables_0.ColeccionOffice2016W7 = smethod_26(ref list_2, ref bool_0, ref bool_2, ref bool_3, ref variables_0);
				}
			}
			else
			{
				List<SoftwareLicensingProduct> list_3 = smethod_17(ref variables_0);
				variables_0.ColeccionOffice2016W8 = smethod_25(ref list_3, ref bool_0, ref bool_2, ref bool_3, ref variables_0);
			}
		}
		else if (bool_2)
		{
			if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
			{
				if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
				{
					bool bool_4 = false;
					List<OfficeSoftwareProtectionProduct> list_4 = smethod_19(ref variables_0, ref bool_4);
					variables_0.ColeccionOffice2013W7 = smethod_26(ref list_4, ref bool_0, ref bool_2, ref bool_3, ref variables_0);
				}
			}
			else
			{
				List<SoftwareLicensingProduct> list_5 = smethod_17(ref variables_0);
				variables_0.ColeccionOffice2013W8 = smethod_25(ref list_5, ref bool_0, ref bool_2, ref bool_3, ref variables_0);
			}
		}
		else if (bool_1)
		{
			bool bool_4 = true;
			List<OfficeSoftwareProtectionProduct> list_6 = smethod_19(ref variables_0, ref bool_4);
			variables_0.ColeccionOffice2010 = smethod_26(ref list_6, ref bool_1, ref bool_2, ref bool_3, ref variables_0);
		}
	}

	internal static uint smethod_47(ref SoftwareLicensingService softwareLicensingService_0, ref bool bool_0, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = softwareLicensingService_0.DisableKeyManagementServiceHostCaching(bool_0);
			FileLogger logger = variables_0.Logger;
			string message = "DisableKeyManagementServiceHostCaching " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	internal static uint smethod_48(OfficeSoftwareProtectionService officeSoftwareProtectionService_0, bool bool_0, ref Variables variables_0)
	{
		uint num = 1u;
		try
		{
			num = officeSoftwareProtectionService_0.DisableKeyManagementServiceHostCaching(bool_0);
			FileLogger logger = variables_0.Logger;
			string message = "DisableKeyManagementServiceHostCaching " + Conversions.ToString(num);
			logger.LogMessage(ref message);
			return num;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			COMException ex2 = ex;
			string str = ex2.ErrorCode.ToString("X");
			Exception exception_ = ex2;
			string str2 = Class2.smethod_4(ref exception_);
			ex2 = (COMException)exception_;
			string str3 = str + " " + str2;
			FileLogger logger2 = variables_0.Logger;
			string message = "Error: " + str3;
			logger2.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return num;
		}
	}

	internal static SoftwareLicensingService smethod_49(ref Variables variables_0)
	{
		List<SoftwareLicensingService> list = smethod_21(ref variables_0);
		if (list.Count > 0)
		{
			return Enumerable.ElementAt<SoftwareLicensingService>((IEnumerable<SoftwareLicensingService>)list, 0);
		}
		return null;
	}

	internal static OfficeSoftwareProtectionService smethod_50(ref Variables variables_0)
	{
		List<OfficeSoftwareProtectionService> list = smethod_22(ref variables_0);
		if (list.Count > 0)
		{
			return Enumerable.ElementAt<OfficeSoftwareProtectionService>((IEnumerable<OfficeSoftwareProtectionService>)list, 0);
		}
		return null;
	}
}
[StandardModule]
internal sealed class Class20
{
	public static object smethod_0(object object_0)
	{
		object obj = null;
		object obj2 = Operators.AndObject(Operators.IntDivideObject(NewLateBinding.LateIndexGet(object_0, new object[1]
		{
			822
		}, (string[])null), (object)6), (object)1);
		NewLateBinding.LateIndexSet(object_0, new object[2]
		{
			822,
			Operators.OrObject(Operators.AndObject(NewLateBinding.LateIndexGet(object_0, new object[1]
			{
				822
			}, (string[])null), (object)247), Operators.MultiplyObject(Operators.AndObject(obj2, (object)2), (object)4))
		}, (string[])null);
		object obj3 = 24;
		object obj4 = "BCDFGHJKMPQRTVWXY2346789";
		object objectValue;
		do
		{
			object obj5 = 0;
			object obj6 = 14;
			do
			{
				obj5 = Operators.MultiplyObject(obj5, (object)256);
				obj5 = Operators.AddObject(NewLateBinding.LateIndexGet(object_0, new object[1]
				{
					Operators.AddObject(obj6, (object)808)
				}, (string[])null), obj5);
				NewLateBinding.LateIndexSet(object_0, new object[2]
				{
					Operators.AddObject(obj6, (object)808),
					Operators.IntDivideObject(obj5, (object)24)
				}, (string[])null);
				obj5 = Operators.ModObject(obj5, (object)24);
				obj6 = Operators.SubtractObject(obj6, (object)1);
			}
			while (Operators.ConditionalCompareObjectGreaterEqual(obj6, (object)0, false));
			obj3 = Operators.SubtractObject(obj3, (object)1);
			obj = Operators.ConcatenateObject((object)Strings.Mid(Conversions.ToString(obj4), Conversions.ToInteger(Operators.AddObject(obj5, (object)1)), 1), obj);
			objectValue = RuntimeHelpers.GetObjectValue(obj5);
		}
		while (Operators.ConditionalCompareObjectGreaterEqual(obj3, (object)0, false));
		if (Operators.ConditionalCompareObjectEqual(obj2, (object)1, false))
		{
			object obj7 = Strings.Mid(Conversions.ToString(obj), 2, Conversions.ToInteger(objectValue));
			object obj8 = "N";
			obj = Strings.Replace(Conversions.ToString(obj), Conversions.ToString(obj7), Conversions.ToString(Operators.ConcatenateObject(obj7, obj8)), 2, 1, (CompareMethod)0);
			if (Operators.ConditionalCompareObjectEqual(objectValue, (object)0, false))
			{
				obj = Operators.ConcatenateObject(obj8, obj);
			}
		}
		string text = Strings.Mid(Conversions.ToString(obj), 1, 5);
		object obj9 = Strings.Mid(Conversions.ToString(obj), 6, 5);
		object obj10 = Strings.Mid(Conversions.ToString(obj), 11, 5);
		object obj11 = Strings.Mid(Conversions.ToString(obj), 16, 5);
		object obj12 = Strings.Mid(Conversions.ToString(obj), 21, 5);
		return Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, (object)"-"), obj9), (object)"-"), obj10), (object)"-"), obj11), (object)"-"), obj12);
	}
}
internal class Class21
{
	[DllImport("WinDivert.dll")]
	public static extern uint DivertHelperCalcChecksums(IntPtr intptr_0, int int_0, ulong ulong_0);

	[DllImport("WinDivert.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DivertHelperParsePacket([In] IntPtr intptr_0, int int_0, ref IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, IntPtr intptr_7, IntPtr intptr_8);

	[DllImport("WinDivert.dll")]
	public static extern IntPtr DivertOpen([In][MarshalAs(UnmanagedType.LPStr)] string string_0, DivertLayer divertLayer_0, short short_0, ulong ulong_0);

	[DllImport("WinDivert.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DivertRecv([In] IntPtr intptr_0, IntPtr intptr_1, int int_0, [Out] IntPtr intptr_2, ref int int_1);

	[DllImport("WinDivert.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DivertSend([In] IntPtr intptr_0, [In] IntPtr intptr_1, int int_0, [In] IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("WinDivert.dll")]
	public static extern void DivertClose(IntPtr intptr_0);
}
internal class Class22
{
	private uint uint_0;

	private uint uint_1;

	private Guid guid_0;

	private Guid guid_1;

	private Guid guid_2;

	public uint method_0()
	{
		return uint_0;
	}

	public void method_1(uint uint_2)
	{
		uint_0 = uint_2;
	}

	public uint method_2()
	{
		return uint_1;
	}

	public void method_3(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public Guid method_4()
	{
		return guid_0;
	}

	public void method_5(Guid guid_3)
	{
		guid_0 = guid_3;
	}

	public Guid method_6()
	{
		return guid_1;
	}

	public void method_7(Guid guid_3)
	{
		guid_1 = guid_3;
	}

	public Guid method_8()
	{
		return guid_2;
	}

	public void method_9(Guid guid_3)
	{
		guid_2 = guid_3;
	}
}
internal class Class23
{
	public Class22 method_0(KMSClientProduct kmsclientProduct_0)
	{
		Class22 @class = new Class22();
		switch (kmsclientProduct_0)
		{
		case KMSClientProduct.Windows7:
			@class.method_1(25u);
			@class.method_3(262144u);
			@class.method_5(new Guid("55c92734-d682-4d71-983e-d6ec3f16059f"));
			@class.method_7(new Guid("ae2ee509-1b34-41c0-acb7-6d4650168915"));
			@class.method_9(new Guid("7fde5219-fbfa-484a-82c9-34d1ad53e856"));
			break;
		case KMSClientProduct.Windows8:
			@class.method_1(25u);
			@class.method_3(327680u);
			@class.method_5(new Guid("55c92734-d682-4d71-983e-d6ec3f16059f"));
			@class.method_7(new Guid("458e1bec-837a-45f6-b9d5-925ed5d299de"));
			@class.method_9(new Guid("3c40b358-5948-45af-923b-53d21fcc7e79"));
			break;
		case KMSClientProduct.Office2010:
			@class.method_1(5u);
			@class.method_3(262144u);
			@class.method_5(new Guid("59a52881-a989-479d-af46-f275c6370663"));
			@class.method_7(new Guid("6f327760-8c5c-417c-9b61-836a98287e0c"));
			@class.method_9(new Guid("e85af946-2e25-47b7-83e1-bebcebeac611"));
			break;
		case KMSClientProduct.Office2013V5:
			@class.method_1(5u);
			@class.method_3(327680u);
			@class.method_5(new Guid("0ff1ce15-a989-479d-af46-f275c6370663"));
			@class.method_7(new Guid("b322da9c-a2e2-4058-9e4e-f59a6970bd69"));
			@class.method_9(new Guid("e6a6f1bf-9d40-40c3-aa9f-c77ba21578c0"));
			break;
		case KMSClientProduct.Office2013V6:
			@class.method_1(5u);
			@class.method_3(393216u);
			@class.method_5(new Guid("0ff1ce15-a989-479d-af46-f275c6370663"));
			@class.method_7(new Guid("b322da9c-a2e2-4058-9e4e-f59a6970bd69"));
			@class.method_9(new Guid("e6a6f1bf-9d40-40c3-aa9f-c77ba21578c0"));
			break;
		case KMSClientProduct.Office2016V5:
			@class.method_1(5u);
			@class.method_3(327680u);
			@class.method_5(new Guid("0ff1ce15-a989-479d-af46-f275c6370663"));
			@class.method_7(new Guid("d450596f-894d-49e0-966a-fd39ed4c4c64"));
			@class.method_9(new Guid("85b5f61b-320b-4be3-814a-b76b2bfafc82"));
			break;
		case KMSClientProduct.Office2016V6:
			@class.method_1(5u);
			@class.method_3(393216u);
			@class.method_5(new Guid("0ff1ce15-a989-479d-af46-f275c6370663"));
			@class.method_7(new Guid("d450596f-894d-49e0-966a-fd39ed4c4c64"));
			@class.method_9(new Guid("85b5f61b-320b-4be3-814a-b76b2bfafc82"));
			break;
		case KMSClientProduct.Windows81:
			@class.method_1(25u);
			@class.method_3(393216u);
			@class.method_5(new Guid("55c92734-d682-4d71-983e-d6ec3f16059f"));
			@class.method_7(new Guid("81671aaf-79d1-4eb1-b004-8cbbe173afea"));
			@class.method_9(new Guid("cb8fc780-2c05-495a-9710-85afffc904d7"));
			break;
		case KMSClientProduct.Windows10:
			@class.method_1(25u);
			@class.method_3(393216u);
			@class.method_5(new Guid("55c92734-d682-4d71-983e-d6ec3f16059f"));
			@class.method_7(new Guid("73111121-5638-40f6-bc11-f1d7b0d64300"));
			@class.method_9(new Guid("58e2134f-8e11-4d17-9cb2-91069c151148"));
			break;
		default:
			throw new ArgumentException(Conversions.ToString(Conversions.ToDouble("mode is invalid") + (double)kmsclientProduct_0));
		case KMSClientProduct.Office2016:
		case KMSClientProduct.Office2016V4:
			@class.method_1(5u);
			@class.method_3(262144u);
			@class.method_5(new Guid("0ff1ce15-a989-479d-af46-f275c6370663"));
			@class.method_7(new Guid("d450596f-894d-49e0-966a-fd39ed4c4c64"));
			@class.method_9(new Guid("85b5f61b-320b-4be3-814a-b76b2bfafc82"));
			break;
		case KMSClientProduct.Office2013:
		case KMSClientProduct.Office2013V4:
			@class.method_1(5u);
			@class.method_3(262144u);
			@class.method_5(new Guid("0ff1ce15-a989-479d-af46-f275c6370663"));
			@class.method_7(new Guid("b322da9c-a2e2-4058-9e4e-f59a6970bd69"));
			@class.method_9(new Guid("e6a6f1bf-9d40-40c3-aa9f-c77ba21578c0"));
			break;
		case KMSClientProduct.Windows:
		case KMSClientProduct.WindowsVista:
			@class.method_1(25u);
			@class.method_3(262144u);
			@class.method_5(new Guid("55c92734-d682-4d71-983e-d6ec3f16059f"));
			@class.method_7(new Guid("cfd8ff08-c0d7-452b-9f60-ef5c70c32094"));
			@class.method_9(new Guid("212a64dc-43b1-4d3d-a30c-2fc69d2095c6"));
			break;
		}
		return @class;
	}
}
internal class Class24 : IKMSClientSettings
{
	private string string_0;

	private int int_0;

	private KMSClientProduct kmsclientProduct_0;

	private string string_1;

	private bool bool_0;

	private Guid guid_0;

	private bool bool_1;

	private LicenseStatus licenseStatus_0;

	string IKMSClientSettings.IPAddress
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	int IKMSClientSettings.Port
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	KMSClientProduct IKMSClientSettings.KMSClientProduct
	{
		get
		{
			return kmsclientProduct_0;
		}
		set
		{
			kmsclientProduct_0 = value;
		}
	}

	string IKMSClientSettings.ClientName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	bool IKMSClientSettings.GenerateRandomClientName
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	Guid IKMSClientSettings.ClientMachineId
	{
		get
		{
			return guid_0;
		}
		set
		{
			guid_0 = value;
		}
	}

	bool IKMSClientSettings.GenerateRandomClientMachineId
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	LicenseStatus IKMSClientSettings.LicenseStatus
	{
		get
		{
			return licenseStatus_0;
		}
		set
		{
			licenseStatus_0 = value;
		}
	}

	public Class24(string string_2, int int_1, KMSClientProduct kmsclientProduct_1)
	{
		AutoPico.KMSEmulator.IKMSClientSettings.IPAddress = string_2;
		AutoPico.KMSEmulator.IKMSClientSettings.Port = int_1;
		AutoPico.KMSEmulator.IKMSClientSettings.KMSClientProduct = kmsclientProduct_1;
		AutoPico.KMSEmulator.IKMSClientSettings.GenerateRandomClientMachineId = true;
		AutoPico.KMSEmulator.IKMSClientSettings.GenerateRandomClientName = true;
		AutoPico.KMSEmulator.IKMSClientSettings.ClientName = "testkmsclient.testdomain.com";
	}
}
namespace AutoPico.KMSEmulator
{
	public interface IKMSClientSettings
	{
		string IPAddress
		{
			get;
			set;
		}

		int Port
		{
			get;
			set;
		}

		KMSClientProduct KMSClientProduct
		{
			get;
			set;
		}

		string ClientName
		{
			get;
			set;
		}

		bool GenerateRandomClientName
		{
			get;
			set;
		}

		Guid ClientMachineId
		{
			get;
			set;
		}

		bool GenerateRandomClientMachineId
		{
			get;
			set;
		}

		LicenseStatus LicenseStatus
		{
			get;
			set;
		}
	}
}
internal class Class25 : IMessageHandler
{
	private Stream stream_0;

	public Class25(Stream stream_1)
	{
		stream_0 = stream_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		stream_0.Write(request, 0, request.Length);
		byte[] array = new byte[1024];
		int num = stream_0.Read(array, 0, array.Length);
		return Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array, num));
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}
}
namespace AutoPico.KMSEmulator
{
	public interface IMessageHandler
	{
		byte[] HandleRequest(ref byte[] request);

		KMSResponse HandleRequest(ref KMSRequest request);
	}
}
internal interface Interface0
{
	KMSResponse imethod_0(ref KMSRequest kmsrequest_0);
}
internal class Class26 : IMessageHandler
{
	private IMessageHandler imessageHandler_0;

	public Class26(ref IMessageHandler imessageHandler_1)
	{
		imessageHandler_0 = imessageHandler_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		byte[] request2 = method_0(ref request);
		byte[] byte_ = imessageHandler_0.HandleRequest(ref request2);
		return method_1(ref byte_);
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}

	private byte[] method_0(ref byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		int value = byte_0.Length;
		binaryWriter.Write(value);
		binaryWriter.Write(value);
		binaryWriter.Write(byte_0);
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	private byte[] method_1(ref byte[] byte_0)
	{
		if (byte_0.Length == 12)
		{
			return byte_0;
		}
		MemoryStream input = new MemoryStream(byte_0);
		BinaryReader binaryReader = new BinaryReader(input);
		uint num = binaryReader.ReadUInt32();
		binaryReader.ReadUInt32();
		binaryReader.ReadUInt32();
		return binaryReader.ReadBytes(checked((int)num));
	}
}
internal class Class27
{
	private static readonly byte[][] byte_0 = new byte[3][]
	{
		new byte[8]
		{
			4,
			17,
			115,
			128,
			56,
			221,
			119,
			252
		},
		new byte[8]
		{
			54,
			79,
			70,
			58,
			136,
			99,
			211,
			95
		},
		new byte[8]
		{
			58,
			28,
			4,
			150,
			0,
			182,
			0,
			118
		}
	};

	private static readonly char[] char_0 = new char[16]
	{
		'0',
		'1',
		'2',
		'3',
		'4',
		'5',
		'6',
		'7',
		'8',
		'9',
		'A',
		'B',
		'C',
		'D',
		'E',
		'F'
	};

	internal static byte[] smethod_0(ref ILogger ilogger_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		do
		{
			stringBuilder.Append(Enumerable.ElementAt<char>((IEnumerable<char>)char_0, Class2.smethod_2(0, char_0.Length)));
			stringBuilder.Append(Enumerable.ElementAt<char>((IEnumerable<char>)char_0, Class2.smethod_2(0, char_0.Length)));
			num = checked(num + 1);
		}
		while (num <= 7);
		string string_ = stringBuilder.ToString();
		byte[] array = Class2.smethod_7(ref string_, ref ilogger_0);
		if (array == null)
		{
			array = Enumerable.ElementAt<byte[]>((IEnumerable<byte[]>)byte_0, Class2.smethod_2(0, byte_0.Length));
		}
		return array;
	}
}
internal class Class28 : IMessageHandler
{
	private IMessageHandler imessageHandler_0;

	private readonly ILogger ilogger_0;

	public Class28(ref IMessageHandler imessageHandler_1, ref ILogger ilogger_1)
	{
		imessageHandler_0 = new Class26(ref imessageHandler_1);
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		byte byte_ = request[2];
		byte byte_2 = request[0];
		try
		{
			return method_1(ref byte_, ref byte_2).HandleRequest(ref request);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result = new byte[0];
			ProjectData.ClearProjectError();
			return result;
		}
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		KMSResponse result = new KMSResponse();
		try
		{
			uint uint_ = request.MajorVersion;
			result = method_0(ref uint_).HandleRequest(ref request);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			ILogger logger = ilogger_0;
			string message = "Error: " + str;
			logger.LogMessage(ref message);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private IMessageHandler method_0(ref uint uint_0)
	{
		IMessageHandler messageHandler = null;
		switch (uint_0)
		{
		default:
			return new Class53();
		case 4u:
		{
			ref IMessageHandler imessageHandler_3 = ref imessageHandler_0;
			ILogger ilogger_ = ilogger_0;
			return new Class39(ref imessageHandler_3, ref ilogger_);
		}
		case 5u:
		{
			ref IMessageHandler imessageHandler_2 = ref imessageHandler_0;
			ILogger ilogger_ = ilogger_0;
			return new Class44(ref imessageHandler_2, ref ilogger_);
		}
		case 6u:
		{
			ref IMessageHandler imessageHandler_ = ref imessageHandler_0;
			ILogger ilogger_ = ilogger_0;
			return new Class49(ref imessageHandler_, ref ilogger_);
		}
		}
	}

	private IMessageHandler method_1(ref byte byte_0, ref byte byte_1)
	{
		IMessageHandler messageHandler = null;
		if (byte_0 == 4 && byte_1 == 0)
		{
			ref IMessageHandler imessageHandler_ = ref imessageHandler_0;
			ILogger ilogger_ = ilogger_0;
			return new Class39(ref imessageHandler_, ref ilogger_);
		}
		if (byte_0 == 5 && byte_1 == 0)
		{
			ref IMessageHandler imessageHandler_2 = ref imessageHandler_0;
			ILogger ilogger_ = ilogger_0;
			return new Class44(ref imessageHandler_2, ref ilogger_);
		}
		if (byte_0 == 6 && byte_1 == 0)
		{
			ref IMessageHandler imessageHandler_3 = ref imessageHandler_0;
			ILogger ilogger_ = ilogger_0;
			return new Class49(ref imessageHandler_3, ref ilogger_);
		}
		return new Class53();
	}
}
internal class Class29
{
	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;
	}

	public string method_0(ref KMSRequest kmsrequest_0)
	{
		int[] array = new int[2];
		int[] array2 = new int[2];
		string[] array3 = new string[4]
		{
			"3612",
			"6401",
			"5426",
			"55041"
		};
		string[] array4 = new string[4]
		{
			"10240",
			"9600",
			"9200",
			"7601"
		};
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		if ((long)kmsrequest_0.MajorVersion == 6L)
		{
			array = new int[2]
			{
				213,
				283
			};
			array2 = new int[2]
			{
				2015,
				2013
			};
		}
		else if ((long)kmsrequest_0.MajorVersion == 5L)
		{
			array = new int[1]
			{
				248
			};
			array2 = new int[1]
			{
				2012
			};
		}
		else
		{
			array = new int[1]
			{
				40
			};
			array2 = new int[1]
			{
				2011
			};
		}
		if (kmsrequest_0.ApplicationId.ToString().ToLower().Contains("59a52881-a989-479d-af46-f275c6370663"))
		{
			arrayList2.Add("96");
			arrayList.Add("199");
		}
		else if (kmsrequest_0.ApplicationId.ToString().ToLower().Contains("0ff1ce15-a989-479d-af46-f275c6370663"))
		{
			arrayList2.Add("206");
			arrayList.Add("234");
			array = new int[1]
			{
				285
			};
			array2 = new int[1]
			{
				2012
			};
		}
		else
		{
			arrayList2.Add("206");
			arrayList2.Add("168");
			arrayList2.Add("152");
			arrayList2.Add("142");
			arrayList2.Add("3308");
			arrayList.Add("26");
			arrayList.Add("152");
			arrayList.Add("199");
			arrayList.Add("234");
			arrayList.Add("305");
			arrayList.Add("312");
			arrayList.Add("313");
			arrayList.Add("314");
			arrayList.Add("339");
			arrayList.Add("381");
			arrayList.Add("271");
			arrayList.Add("311");
			arrayList.Add("310");
			arrayList.Add("330");
			arrayList.Add("109");
		}
		Struct0 @struct = default(Struct0);
		int num = Class2.smethod_2(0, array3.Length);
		@struct.int_0 = Conversions.ToInteger(array3[num]);
		if (arrayList2.Count > 1)
		{
			@struct.int_1 = Conversions.ToInteger(arrayList2[Class2.smethod_2(0, arrayList2.Count)]);
		}
		else
		{
			@struct.int_1 = Conversions.ToInteger(arrayList2[0]);
		}
		if (arrayList.Count > 1)
		{
			@struct.int_2 = Conversions.ToInteger(arrayList[Class2.smethod_2(0, arrayList.Count)]);
		}
		else
		{
			@struct.int_2 = Conversions.ToInteger(arrayList[0]);
		}
		@struct.int_3 = Class2.smethod_2(1, 1000000);
		@struct.int_4 = 3;
		@struct.int_5 = CultureInfo.InstalledUICulture.LCID;
		@struct.int_6 = Conversions.ToInteger(array4[num]);
		int year = DateTime.Now.Year;
		int dayOfYear = DateTime.Now.DayOfYear;
		int num2 = Class2.smethod_2(0, array2.Length);
		checked
		{
			int num3 = Class2.smethod_2(1, year - (array2[num2] - 1)) + array2[num2];
			if (num3 > year)
			{
				num3 = year;
			}
			int num4 = Class2.smethod_2(1, 365);
			if (num3 == year && num4 > dayOfYear)
			{
				num4 = dayOfYear;
			}
			else if (num3 == array2[num2] && num4 < array[num2])
			{
				num4 = array[num2] + 1;
			}
			return $"{@struct.int_0:D5}-{@struct.int_1:D5}-{@struct.int_2:D3}-{@struct.int_3:D6}-{@struct.int_4:D2}-{@struct.int_5}-{@struct.int_6:D4}.0000-{num4:D3}{num3:D4}";
		}
	}
}
internal abstract class Class30
{
	public abstract uint vmethod_0();

	public byte[] method_0()
	{
		return new byte[4]
		{
			0,
			0,
			2,
			0
		};
	}

	public uint method_1()
	{
		return vmethod_0();
	}

	public byte[] method_2()
	{
		long num = (long)vmethod_0() % 8L;
		if (num != 0L)
		{
			return new byte[checked((int)(8L - num - 1L) + 1)];
		}
		return new byte[0];
	}
}
internal class Class37 : Interface0
{
	private readonly IKMSServerSettings ikmsserverSettings_0;

	private readonly ILogger ilogger_0;

	public Class37(ref IKMSServerSettings ikmsserverSettings_1, ref ILogger ilogger_1)
	{
		ikmsserverSettings_0 = ikmsserverSettings_1;
		ilogger_0 = ilogger_1;
	}

	public KMSResponse imethod_0(ref KMSRequest kmsrequest_0)
	{
		return KMSResponse.Parse(kmsrequest_0, ikmsserverSettings_0);
	}
}
internal class Class38
{
	private uint uint_0;

	private uint uint_1;

	private KMSRequest kmsrequest_0;

	private byte[] byte_0;

	public uint method_0()
	{
		return uint_0;
	}

	public void method_1(uint uint_2)
	{
		uint_0 = uint_2;
	}

	public uint method_2()
	{
		return uint_1;
	}

	public void method_3(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public KMSRequest method_4()
	{
		return kmsrequest_0;
	}

	public void method_5(KMSRequest kmsrequest_1)
	{
		kmsrequest_0 = kmsrequest_1;
	}

	public byte[] method_6()
	{
		return byte_0;
	}

	public void method_7(byte[] byte_1)
	{
		byte_0 = byte_1;
	}

	public uint method_8()
	{
		checked
		{
			return (uint)(unchecked((long)method_4().BodyLength) + unchecked((long)method_6().Length));
		}
	}

	public static Class38 smethod_0(ref byte[] byte_1)
	{
		Class38 @class = new Class38();
		MemoryStream input = new MemoryStream(byte_1);
		BinaryReader binaryReader = new BinaryReader(input);
		@class.method_1(binaryReader.ReadUInt32());
		@class.method_3(binaryReader.ReadUInt32());
		byte[] decrypted = binaryReader.ReadBytes(checked(byte_1.Length - 8 - 16));
		@class.method_5(KMSRequest.Parse(ref decrypted));
		@class.method_7(binaryReader.ReadBytes(16));
		return @class;
	}

	public byte[] method_9()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_4().GetByteArray());
		binaryWriter.Write(method_6());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class31 : Class30
{
	private KMSResponse kmsresponse_0;

	private byte[] byte_0;

	public KMSResponse method_3()
	{
		return kmsresponse_0;
	}

	public void method_4(KMSResponse kmsresponse_1)
	{
		kmsresponse_0 = kmsresponse_1;
	}

	public byte[] method_5()
	{
		return byte_0;
	}

	public void method_6(byte[] byte_1)
	{
		byte_0 = byte_1;
	}

	public override uint vmethod_0()
	{
		checked
		{
			return (uint)(unchecked((long)method_3().BodyLength) + unchecked((long)method_5().Length));
		}
	}

	public static Class31 smethod_0(ref byte[] byte_1)
	{
		Class31 @class = new Class31();
		MemoryStream input = new MemoryStream(byte_1);
		BinaryReader binaryReader = new BinaryReader(input);
		@class.method_4(KMSResponse.Parse(binaryReader.ReadBytes(checked(byte_1.Length - 16))));
		@class.method_6(binaryReader.ReadBytes(16));
		return @class;
	}

	public byte[] method_7()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(vmethod_0());
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_1());
		binaryWriter.Write(method_3().GetByteArray());
		binaryWriter.Write(method_5());
		binaryWriter.Write(method_2());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class39 : IMessageHandler
{
	private IMessageHandler imessageHandler_0;

	private static ILogger ilogger_0;

	public Class39(ref IMessageHandler imessageHandler_1, ref ILogger ilogger_1)
	{
		imessageHandler_0 = imessageHandler_1;
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		KMSRequest kmsrequest_ = KMSRequest.Parse(ref request);
		byte[] request2 = smethod_1(ref kmsrequest_).method_9();
		byte[] byte_ = imessageHandler_0.HandleRequest(ref request2);
		return smethod_0(ref byte_).GetByteArray();
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		byte[] request2 = smethod_1(ref request).method_9();
		byte[] byte_ = imessageHandler_0.HandleRequest(ref request2);
		return smethod_0(ref byte_);
	}

	private static KMSResponse smethod_0(ref byte[] byte_0)
	{
		KMSResponse kMSResponse = new KMSResponse();
		if (byte_0.Length == 12)
		{
			kMSResponse = KMSResponse.ParseError(byte_0);
		}
		else
		{
			kMSResponse = Class31.smethod_0(ref byte_0).method_3();
			ILogger logger = ilogger_0;
			string message = string.Format("Test: Received response: v{0}, PID: {1}", kMSResponse.MajorVersion, kMSResponse.KMSPIDString.Replace("\0", string.Empty));
			logger.LogMessage(ref message);
		}
		return kMSResponse;
	}

	private static Class38 smethod_1(ref KMSRequest kmsrequest_0)
	{
		Class38 @class = new Class38();
		@class.method_5(kmsrequest_0);
		Class41 class2 = Class41.smethod_0();
		byte[] byte_ = @class.method_4().GetByteArray();
		@class.method_7(class2.method_0(ref byte_));
		ILogger logger = ilogger_0;
		string message = $"Test: Sending request: v{kmsrequest_0.MajorVersion}, AppID: {kmsrequest_0.ApplicationId}, Machine: {kmsrequest_0.MachineNameString}";
		logger.LogMessage(ref message);
		return @class;
	}
}
internal class Class40 : IMessageHandler
{
	private Interface0 interface0_0;

	private readonly ILogger ilogger_0;

	private Interface0 method_0()
	{
		return interface0_0;
	}

	private void method_1(Interface0 interface0_1)
	{
		interface0_0 = interface0_1;
	}

	public Class40(ref Interface0 interface0_1, ref ILogger ilogger_1)
	{
		method_1(interface0_1);
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		Class38 @class = Class38.smethod_0(ref request);
		ILogger logger = ilogger_0;
		string message = $"Received request: v{@class.method_4().MajorVersion}, AppID: {@class.method_4().ApplicationId}, Machine: {@class.method_4().MachineNameString}";
		logger.LogMessage(ref message);
		Interface0 @interface = method_0();
		Class38 class2;
		KMSRequest kmsrequest_ = (class2 = @class).method_4();
		KMSResponse kMSResponse = @interface.imethod_0(ref kmsrequest_);
		class2.method_5(kmsrequest_);
		KMSResponse kMSResponse2 = kMSResponse;
		Class41 class3 = Class41.smethod_0();
		byte[] byte_ = kMSResponse2.GetByteArray();
		byte[] byte_2 = class3.method_0(ref byte_);
		Class31 class4 = new Class31();
		class4.method_4(kMSResponse2);
		class4.method_6(byte_2);
		ILogger logger2 = ilogger_0;
		message = $"Sending response: v{kMSResponse2.MajorVersion}, PID: {kMSResponse2.KMSPIDString}";
		logger2.LogMessage(ref message);
		return class4.method_7();
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}
}
internal class Class41
{
	private static Class41 class41_0 = new Class41();

	private static byte[] byte_0 = new byte[256]
	{
		99,
		124,
		119,
		123,
		242,
		107,
		111,
		197,
		48,
		1,
		103,
		43,
		254,
		215,
		171,
		118,
		202,
		130,
		201,
		125,
		250,
		89,
		71,
		240,
		173,
		212,
		162,
		175,
		156,
		164,
		114,
		192,
		183,
		253,
		147,
		38,
		54,
		63,
		247,
		204,
		52,
		165,
		229,
		241,
		113,
		216,
		49,
		21,
		4,
		199,
		35,
		195,
		24,
		150,
		5,
		154,
		7,
		18,
		128,
		226,
		235,
		39,
		178,
		117,
		9,
		131,
		44,
		26,
		27,
		110,
		90,
		160,
		82,
		59,
		214,
		179,
		41,
		227,
		47,
		132,
		83,
		209,
		0,
		237,
		32,
		252,
		177,
		91,
		106,
		203,
		190,
		57,
		74,
		76,
		88,
		207,
		208,
		239,
		170,
		251,
		67,
		77,
		51,
		133,
		69,
		249,
		2,
		127,
		80,
		60,
		159,
		168,
		81,
		163,
		64,
		143,
		146,
		157,
		56,
		245,
		188,
		182,
		218,
		33,
		16,
		255,
		243,
		210,
		205,
		12,
		19,
		236,
		95,
		151,
		68,
		23,
		196,
		167,
		126,
		61,
		100,
		93,
		25,
		115,
		96,
		129,
		79,
		220,
		34,
		42,
		144,
		136,
		70,
		238,
		184,
		20,
		222,
		94,
		11,
		219,
		224,
		50,
		58,
		10,
		73,
		6,
		36,
		92,
		194,
		211,
		172,
		98,
		145,
		149,
		228,
		121,
		231,
		200,
		55,
		109,
		141,
		213,
		78,
		169,
		108,
		86,
		244,
		234,
		101,
		122,
		174,
		8,
		186,
		120,
		37,
		46,
		28,
		166,
		180,
		198,
		232,
		221,
		116,
		31,
		75,
		189,
		139,
		138,
		112,
		62,
		181,
		102,
		72,
		3,
		246,
		14,
		97,
		53,
		87,
		185,
		134,
		193,
		29,
		158,
		225,
		248,
		152,
		17,
		105,
		217,
		142,
		148,
		155,
		30,
		135,
		233,
		206,
		85,
		40,
		223,
		140,
		161,
		137,
		13,
		191,
		230,
		66,
		104,
		65,
		153,
		45,
		15,
		176,
		84,
		187,
		22
	};

	private static byte[] byte_1 = new byte[24576]
	{
		54,
		175,
		152,
		50,
		33,
		62,
		38,
		42,
		138,
		163,
		43,
		246,
		92,
		109,
		118,
		58,
		4,
		167,
		173,
		26,
		223,
		151,
		32,
		148,
		249,
		193,
		157,
		47,
		137,
		240,
		242,
		255,
		98,
		107,
		145,
		170,
		160,
		234,
		123,
		206,
		133,
		44,
		72,
		108,
		248,
		105,
		172,
		184,
		203,
		69,
		199,
		88,
		154,
		89,
		158,
		126,
		122,
		182,
		40,
		239,
		79,
		90,
		191,
		221,
		51,
		70,
		253,
		7,
		222,
		84,
		71,
		113,
		190,
		116,
		217,
		114,
		102,
		15,
		238,
		139,
		161,
		125,
		6,
		236,
		140,
		14,
		176,
		93,
		17,
		23,
		146,
		5,
		150,
		55,
		100,
		227,
		16,
		30,
		216,
		110,
		178,
		141,
		166,
		247,
		97,
		13,
		245,
		194,
		164,
		24,
		34,
		95,
		192,
		207,
		168,
		101,
		254,
		12,
		210,
		29,
		162,
		77,
		143,
		174,
		235,
		225,
		124,
		135,
		202,
		2,
		74,
		25,
		81,
		144,
		177,
		78,
		0,
		57,
		46,
		68,
		250,
		153,
		96,
		35,
		119,
		127,
		213,
		205,
		220,
		61,
		129,
		18,
		3,
		131,
		134,
		86,
		179,
		27,
		73,
		229,
		91,
		20,
		1,
		121,
		111,
		189,
		87,
		103,
		200,
		204,
		36,
		185,
		142,
		159,
		63,
		241,
		136,
		208,
		244,
		19,
		149,
		186,
		48,
		106,
		39,
		56,
		85,
		243,
		11,
		49,
		183,
		169,
		251,
		65,
		155,
		233,
		37,
		231,
		115,
		120,
		224,
		22,
		215,
		214,
		128,
		181,
		66,
		41,
		94,
		21,
		83,
		171,
		99,
		45,
		59,
		232,
		156,
		219,
		195,
		64,
		104,
		60,
		228,
		10,
		132,
		52,
		201,
		211,
		165,
		188,
		76,
		197,
		8,
		147,
		130,
		117,
		67,
		198,
		180,
		218,
		187,
		226,
		53,
		31,
		252,
		209,
		80,
		212,
		9,
		237,
		75,
		230,
		196,
		28,
		82,
		112,
		47,
		227,
		125,
		186,
		26,
		15,
		234,
		136,
		158,
		16,
		146,
		13,
		207,
		12,
		203,
		43,
		208,
		121,
		29,
		57,
		173,
		60,
		249,
		237,
		55,
		62,
		196,
		255,
		245,
		191,
		46,
		155,
		172,
		148,
		200,
		122,
		220,
		165,
		167,
		170,
		81,
		242,
		248,
		79,
		138,
		194,
		117,
		193,
		223,
		246,
		126,
		163,
		9,
		56,
		35,
		111,
		99,
		250,
		205,
		103,
		116,
		107,
		115,
		127,
		247,
		24,
		218,
		251,
		190,
		180,
		41,
		210,
		149,
		154,
		253,
		48,
		171,
		89,
		135,
		72,
		52,
		88,
		160,
		151,
		241,
		77,
		119,
		10,
		69,
		75,
		141,
		59,
		231,
		216,
		243,
		162,
		68,
		66,
		199,
		80,
		195,
		98,
		49,
		182,
		244,
		40,
		83,
		185,
		217,
		91,
		229,
		8,
		235,
		33,
		140,
		39,
		51,
		90,
		187,
		222,
		102,
		19,
		168,
		82,
		139,
		1,
		18,
		36,
		114,
		109,
		0,
		166,
		94,
		100,
		226,
		252,
		221,
		133,
		161,
		70,
		192,
		239,
		101,
		63,
		157,
		153,
		113,
		236,
		219,
		202,
		106,
		164,
		14,
		65,
		84,
		44,
		58,
		232,
		2,
		50,
		86,
		214,
		211,
		3,
		230,
		78,
		28,
		176,
		34,
		42,
		128,
		152,
		137,
		104,
		212,
		71,
		85,
		108,
		123,
		17,
		175,
		204,
		53,
		118,
		159,
		87,
		31,
		76,
		4,
		197,
		228,
		27,
		92,
		184,
		30,
		179,
		145,
		73,
		7,
		37,
		238,
		183,
		96,
		74,
		169,
		132,
		5,
		129,
		93,
		198,
		215,
		32,
		22,
		147,
		225,
		143,
		209,
		97,
		156,
		134,
		240,
		233,
		25,
		144,
		201,
		142,
		150,
		21,
		61,
		105,
		177,
		95,
		11,
		64,
		6,
		254,
		54,
		120,
		110,
		189,
		181,
		67,
		130,
		131,
		213,
		224,
		23,
		124,
		174,
		20,
		206,
		188,
		112,
		178,
		38,
		45,
		82,
		173,
		178,
		115,
		169,
		250,
		41,
		225,
		131,
		192,
		25,
		122,
		205,
		167,
		227,
		218,
		98,
		241,
		63,
		222,
		54,
		46,
		148,
		156,
		170,
		6,
		80,
		248,
		101,
		181,
		224,
		96,
		180,
		132,
		140,
		94,
		226,
		154,
		184,
		247,
		220,
		18,
		109,
		124,
		199,
		90,
		43,
		47,
		211,
		137,
		118,
		89,
		23,
		240,
		107,
		51,
		84,
		74,
		232,
		210,
		182,
		16,
		196,
		219,
		144,
		155,
		198,
		4,
		120,
		10,
		24,
		162,
		161,
		202,
		99,
		86,
		52,
		53,
		3,
		245,
		216,
		11,
		128,
		206,
		176,
		72,
		189,
		246,
		7,
		233,
		139,
		223,
		32,
		163,
		127,
		56,
		175,
		38,
		70,
		95,
		42,
		48,
		103,
		215,
		87,
		57,
		160,
		37,
		97,
		150,
		235,
		112,
		179,
		55,
		31,
		50,
		214,
		252,
		88,
		1,
		177,
		147,
		39,
		255,
		168,
		5,
		234,
		14,
		197,
		201,
		194,
		221,
		123,
		209,
		213,
		76,
		149,
		217,
		191,
		142,
		200,
		21,
		105,
		64,
		195,
		119,
		60,
		116,
		78,
		249,
		231,
		68,
		17,
		28,
		106,
		19,
		126,
		204,
		26,
		34,
		152,
		45,
		67,
		9,
		114,
		73,
		129,
		136,
		79,
		91,
		27,
		138,
		171,
		143,
		102,
		207,
		125,
		157,
		121,
		186,
		36,
		187,
		40,
		166,
		92,
		62,
		172,
		185,
		203,
		12,
		153,
		85,
		164,
		146,
		61,
		183,
		30,
		228,
		208,
		165,
		13,
		104,
		133,
		236,
		58,
		145,
		93,
		151,
		83,
		190,
		111,
		237,
		229,
		15,
		66,
		158,
		135,
		0,
		117,
		212,
		113,
		230,
		242,
		244,
		69,
		20,
		81,
		110,
		59,
		141,
		243,
		253,
		193,
		188,
		71,
		251,
		22,
		33,
		130,
		238,
		49,
		254,
		29,
		239,
		75,
		134,
		35,
		44,
		159,
		100,
		8,
		2,
		108,
		77,
		65,
		174,
		81,
		251,
		255,
		102,
		239,
		227,
		232,
		247,
		226,
		63,
		67,
		106,
		191,
		243,
		149,
		164,
		100,
		211,
		205,
		110,
		233,
		93,
		22,
		94,
		84,
		230,
		48,
		8,
		59,
		54,
		64,
		57,
		88,
		99,
		171,
		162,
		178,
		7,
		105,
		35,
		129,
		165,
		76,
		229,
		101,
		113,
		49,
		160,
		14,
		145,
		2,
		140,
		87,
		183,
		83,
		144,
		225,
		38,
		179,
		127,
		118,
		20,
		134,
		147,
		52,
		206,
		250,
		143,
		142,
		184,
		23,
		157,
		16,
		187,
		119,
		189,
		39,
		66,
		175,
		198,
		207,
		37,
		104,
		180,
		121,
		148,
		69,
		199,
		91,
		204,
		216,
		222,
		173,
		42,
		95,
		254,
		17,
		167,
		217,
		215,
		111,
		62,
		123,
		68,
		60,
		11,
		168,
		196,
		235,
		150,
		109,
		209,
		97,
		172,
		9,
		6,
		27,
		212,
		55,
		197,
		70,
		103,
		107,
		132,
		181,
		78,
		34,
		40,
		131,
		208,
		3,
		203,
		120,
		135,
		152,
		89,
		231,
		141,
		201,
		240,
		169,
		234,
		51,
		80,
		28,
		4,
		190,
		182,
		72,
		219,
		21,
		244,
		79,
		159,
		202,
		74,
		128,
		44,
		122,
		210,
		200,
		176,
		146,
		221,
		158,
		174,
		166,
		116,
		237,
		112,
		1,
		5,
		246,
		56,
		71,
		86,
		61,
		218,
		65,
		25,
		249,
		163,
		92,
		115,
		156,
		58,
		238,
		241,
		126,
		96,
		194,
		248,
		82,
		32,
		50,
		136,
		186,
		177,
		236,
		46,
		30,
		31,
		41,
		223,
		139,
		224,
		73,
		124,
		154,
		98,
		151,
		220,
		242,
		33,
		170,
		228,
		10,
		137,
		85,
		18,
		45,
		195,
		161,
		245,
		0,
		26,
		77,
		253,
		133,
		12,
		108,
		117,
		75,
		188,
		193,
		90,
		125,
		19,
		138,
		15,
		252,
		214,
		114,
		43,
		153,
		29,
		53,
		24,
		130,
		47,
		192,
		36,
		155,
		185,
		13,
		213,
		84,
		140,
		194,
		224,
		153,
		125,
		219,
		118,
		108,
		65,
		192,
		68,
		43,
		114,
		165,
		143,
		211,
		86,
		36,
		74,
		152,
		3,
		18,
		229,
		53,
		44,
		220,
		85,
		20,
		164,
		89,
		67,
		248,
		172,
		116,
		154,
		12,
		75,
		83,
		208,
		243,
		189,
		171,
		120,
		206,
		133,
		195,
		59,
		16,
		37,
		210,
		185,
		112,
		134,
		71,
		70,
		181,
		119,
		227,
		232,
		107,
		209,
		11,
		121,
		155,
		161,
		39,
		57,
		183,
		168,
		197,
		99,
		5,
		42,
		160,
		250,
		24,
		64,
		100,
		131,
		30,
		15,
		175,
		97,
		88,
		92,
		180,
		41,
		255,
		45,
		199,
		247,
		203,
		132,
		145,
		233,
		35,
		139,
		217,
		117,
		147,
		19,
		22,
		198,
		76,
		173,
		17,
		130,
		231,
		239,
		69,
		93,
		106,
		9,
		240,
		179,
		144,
		169,
		190,
		212,
		193,
		0,
		33,
		222,
		90,
		146,
		218,
		137,
		123,
		113,
		236,
		23,
		50,
		221,
		31,
		62,
		110,
		156,
		66,
		141,
		80,
		95,
		56,
		245,
		52,
		136,
		178,
		207,
		241,
		157,
		101,
		82,
		34,
		29,
		54,
		103,
		128,
		142,
		72,
		254,
		6,
		167,
		244,
		115,
		129,
		135,
		2,
		149,
		28,
		158,
		32,
		205,
		49,
		237,
		150,
		124,
		246,
		159,
		126,
		27,
		46,
		228,
		73,
		226,
		78,
		196,
		215,
		225,
		163,
		214,
		109,
		151,
		223,
		202,
		47,
		77,
		234,
		38,
		184,
		127,
		10,
		201,
		14,
		238,
		91,
		213,
		87,
		200,
		104,
		249,
		60,
		40,
		21,
		188,
		216,
		252,
		48,
		122,
		235,
		94,
		242,
		251,
		1,
		58,
		25,
		96,
		98,
		111,
		105,
		81,
		13,
		191,
		79,
		7,
		176,
		4,
		148,
		55,
		61,
		138,
		204,
		253,
		230,
		170,
		26,
		51,
		187,
		102,
		177,
		174,
		182,
		186,
		166,
		63,
		8,
		162,
		223,
		111,
		146,
		136,
		254,
		231,
		23,
		158,
		83,
		200,
		217,
		46,
		24,
		157,
		239,
		129,
		224,
		185,
		110,
		68,
		167,
		138,
		11,
		143,
		82,
		182,
		16,
		189,
		159,
		71,
		9,
		43,
		160,
		26,
		192,
		178,
		126,
		188,
		40,
		35,
		187,
		77,
		140,
		141,
		219,
		238,
		25,
		114,
		5,
		78,
		8,
		240,
		56,
		118,
		96,
		179,
		199,
		128,
		152,
		27,
		51,
		103,
		191,
		81,
		0,
		79,
		90,
		34,
		52,
		230,
		12,
		60,
		147,
		151,
		127,
		226,
		213,
		196,
		100,
		170,
		211,
		139,
		175,
		72,
		206,
		225,
		107,
		49,
		124,
		99,
		14,
		168,
		80,
		106,
		236,
		242,
		145,
		89,
		17,
		66,
		10,
		203,
		234,
		21,
		91,
		98,
		117,
		31,
		161,
		194,
		59,
		120,
		44,
		36,
		142,
		150,
		135,
		102,
		218,
		73,
		88,
		216,
		221,
		13,
		232,
		64,
		18,
		190,
		75,
		69,
		131,
		53,
		233,
		214,
		253,
		172,
		58,
		86,
		174,
		153,
		255,
		67,
		121,
		4,
		155,
		148,
		243,
		62,
		165,
		87,
		137,
		70,
		249,
		22,
		212,
		245,
		176,
		186,
		39,
		220,
		104,
		29,
		166,
		92,
		133,
		15,
		28,
		42,
		229,
		47,
		130,
		41,
		61,
		84,
		181,
		208,
		250,
		38,
		93,
		183,
		215,
		85,
		235,
		6,
		74,
		76,
		201,
		94,
		205,
		108,
		63,
		184,
		57,
		48,
		202,
		241,
		251,
		177,
		32,
		149,
		222,
		119,
		19,
		55,
		163,
		50,
		247,
		227,
		144,
		30,
		156,
		3,
		193,
		2,
		197,
		37,
		33,
		237,
		115,
		180,
		20,
		1,
		228,
		134,
		109,
		244,
		195,
		105,
		122,
		101,
		125,
		113,
		209,
		248,
		112,
		173,
		7,
		54,
		45,
		97,
		95,
		252,
		246,
		65,
		132,
		204,
		123,
		207,
		162,
		154,
		198,
		116,
		210,
		171,
		169,
		164,
		178,
		159,
		183,
		51,
		129,
		216,
		124,
		86,
		127,
		167,
		19,
		49,
		142,
		106,
		133,
		40,
		223,
		198,
		166,
		47,
		87,
		231,
		176,
		170,
		165,
		32,
		185,
		215,
		240,
		107,
		22,
		225,
		78,
		0,
		139,
		88,
		118,
		61,
		200,
		48,
		95,
		11,
		105,
		135,
		184,
		255,
		35,
		160,
		132,
		70,
		27,
		16,
		34,
		152,
		138,
		248,
		214,
		227,
		74,
		33,
		117,
		131,
		181,
		180,
		217,
		246,
		9,
		83,
		179,
		235,
		112,
		151,
		82,
		104,
		202,
		212,
		91,
		68,
		144,
		54,
		222,
		12,
		4,
		52,
		119,
		56,
		26,
		98,
		252,
		237,
		146,
		92,
		175,
		171,
		218,
		71,
		94,
		191,
		113,
		226,
		28,
		20,
		174,
		182,
		120,
		208,
		134,
		42,
		224,
		96,
		53,
		229,
		243,
		50,
		45,
		210,
		97,
		169,
		122,
		41,
		250,
		153,
		64,
		3,
		90,
		99,
		39,
		77,
		111,
		157,
		126,
		177,
		172,
		163,
		6,
		203,
		130,
		136,
		228,
		31,
		46,
		193,
		205,
		236,
		238,
		209,
		148,
		197,
		125,
		115,
		13,
		187,
		123,
		199,
		60,
		65,
		110,
		2,
		161,
		150,
		109,
		239,
		62,
		211,
		30,
		194,
		143,
		101,
		84,
		245,
		128,
		7,
		116,
		114,
		102,
		241,
		55,
		189,
		18,
		36,
		37,
		80,
		100,
		158,
		108,
		5,
		232,
		141,
		23,
		221,
		17,
		186,
		58,
		249,
		29,
		253,
		38,
		168,
		59,
		164,
		57,
		44,
		190,
		220,
		213,
		25,
		140,
		75,
		137,
		195,
		173,
		24,
		8,
		1,
		201,
		242,
		10,
		155,
		219,
		207,
		79,
		230,
		15,
		43,
		244,
		188,
		247,
		67,
		196,
		103,
		121,
		206,
		147,
		234,
		156,
		145,
		162,
		154,
		76,
		254,
		93,
		66,
		73,
		69,
		204,
		85,
		81,
		251,
		14,
		63,
		89,
		21,
		192,
		233,
		149,
		72,
		252,
		159,
		70,
		5,
		92,
		101,
		33,
		75,
		245,
		52,
		43,
		212,
		103,
		175,
		124,
		47,
		126,
		214,
		128,
		44,
		230,
		102,
		51,
		227,
		88,
		185,
		119,
		228,
		26,
		18,
		168,
		176,
		250,
		235,
		148,
		90,
		169,
		173,
		220,
		65,
		216,
		10,
		2,
		50,
		113,
		62,
		28,
		100,
		84,
		110,
		204,
		210,
		93,
		66,
		150,
		48,
		223,
		240,
		15,
		85,
		181,
		237,
		118,
		145,
		208,
		229,
		76,
		39,
		115,
		133,
		179,
		178,
		130,
		64,
		29,
		22,
		36,
		158,
		140,
		254,
		89,
		13,
		111,
		129,
		190,
		249,
		37,
		166,
		72,
		6,
		141,
		94,
		112,
		59,
		206,
		54,
		163,
		38,
		191,
		209,
		246,
		109,
		16,
		231,
		217,
		192,
		160,
		41,
		81,
		225,
		182,
		172,
		121,
		161,
		21,
		55,
		136,
		108,
		131,
		46,
		180,
		153,
		177,
		53,
		135,
		222,
		122,
		80,
		8,
		57,
		95,
		19,
		198,
		239,
		147,
		78,
		91,
		68,
		79,
		67,
		202,
		83,
		87,
		253,
		149,
		236,
		154,
		151,
		164,
		156,
		74,
		248,
		242,
		186,
		241,
		69,
		194,
		97,
		127,
		200,
		12,
		157,
		221,
		201,
		73,
		224,
		9,
		45,
		143,
		197,
		171,
		30,
		14,
		7,
		207,
		244,
		63,
		42,
		184,
		218,
		211,
		31,
		138,
		77,
		60,
		255,
		27,
		251,
		32,
		174,
		61,
		162,
		106,
		3,
		238,
		139,
		17,
		219,
		23,
		188,
		49,
		187,
		20,
		34,
		35,
		86,
		98,
		152,
		82,
		243,
		134,
		1,
		114,
		116,
		96,
		247,
		107,
		233,
		56,
		213,
		24,
		196,
		137,
		99,
		125,
		193,
		58,
		71,
		104,
		4,
		167,
		144,
		232,
		215,
		146,
		195,
		123,
		117,
		11,
		189,
		132,
		142,
		226,
		25,
		40,
		199,
		203,
		234,
		105,
		155,
		120,
		183,
		170,
		165,
		0,
		205,
		168,
		198,
		95,
		218,
		158,
		105,
		20,
		143,
		80,
		217,
		185,
		160,
		213,
		207,
		152,
		40,
		78,
		108,
		216,
		0,
		87,
		250,
		21,
		241,
		76,
		200,
		224,
		205,
		41,
		3,
		167,
		254,
		94,
		53,
		156,
		169,
		203,
		202,
		252,
		10,
		111,
		100,
		57,
		251,
		135,
		245,
		231,
		93,
		248,
		22,
		116,
		32,
		223,
		92,
		128,
		199,
		39,
		244,
		127,
		49,
		79,
		183,
		66,
		9,
		35,
		237,
		146,
		131,
		56,
		165,
		212,
		208,
		75,
		123,
		115,
		161,
		29,
		101,
		71,
		8,
		171,
		181,
		23,
		45,
		73,
		239,
		59,
		36,
		44,
		118,
		137,
		166,
		232,
		15,
		148,
		204,
		124,
		63,
		230,
		133,
		50,
		88,
		28,
		37,
		173,
		82,
		77,
		140,
		86,
		5,
		214,
		30,
		85,
		249,
		175,
		7,
		154,
		74,
		31,
		159,
		157,
		14,
		192,
		33,
		201,
		209,
		107,
		99,
		62,
		67,
		184,
		4,
		233,
		222,
		125,
		17,
		186,
		235,
		174,
		145,
		196,
		114,
		12,
		2,
		96,
		155,
		247,
		253,
		147,
		178,
		190,
		81,
		206,
		1,
		226,
		16,
		180,
		121,
		220,
		211,
		242,
		151,
		122,
		19,
		197,
		110,
		162,
		104,
		91,
		109,
		194,
		72,
		225,
		27,
		47,
		90,
		120,
		255,
		138,
		43,
		142,
		25,
		13,
		11,
		172,
		65,
		144,
		18,
		26,
		240,
		189,
		97,
		176,
		164,
		228,
		117,
		84,
		112,
		153,
		48,
		103,
		210,
		188,
		246,
		141,
		182,
		126,
		119,
		163,
		193,
		83,
		70,
		52,
		243,
		102,
		170,
		130,
		98,
		134,
		69,
		219,
		68,
		215,
		89,
		106,
		38,
		64,
		113,
		55,
		234,
		150,
		191,
		58,
		54,
		61,
		34,
		132,
		46,
		42,
		179,
		238,
		227,
		149,
		236,
		129,
		51,
		229,
		221,
		60,
		136,
		195,
		139,
		177,
		6,
		24,
		187,
		186,
		45,
		168,
		174,
		92,
		219,
		136,
		41,
		83,
		185,
		194,
		30,
		226,
		15,
		177,
		51,
		205,
		102,
		203,
		1,
		52,
		81,
		176,
		217,
		184,
		66,
		249,
		140,
		206,
		248,
		235,
		97,
		17,
		48,
		242,
		29,
		56,
		195,
		94,
		84,
		218,
		23,
		112,
		127,
		162,
		109,
		179,
		65,
		125,
		74,
		178,
		222,
		224,
		157,
		167,
		27,
		209,
		103,
		161,
		175,
		72,
		25,
		50,
		13,
		144,
		34,
		126,
		70,
		64,
		77,
		79,
		54,
		165,
		18,
		24,
		187,
		43,
		159,
		40,
		96,
		73,
		148,
		28,
		53,
		133,
		201,
		210,
		227,
		141,
		39,
		16,
		137,
		149,
		153,
		129,
		158,
		80,
		151,
		9,
		197,
		98,
		0,
		229,
		240,
		231,
		120,
		250,
		116,
		193,
		33,
		230,
		37,
		211,
		247,
		147,
		58,
		7,
		19,
		214,
		71,
		21,
		46,
		212,
		221,
		113,
		196,
		85,
		31,
		255,
		124,
		100,
		35,
		181,
		91,
		131,
		215,
		20,
		236,
		170,
		225,
		87,
		132,
		146,
		220,
		105,
		104,
		169,
		95,
		150,
		253,
		10,
		63,
		86,
		36,
		254,
		68,
		199,
		204,
		88,
		154,
		89,
		244,
		82,
		182,
		207,
		237,
		163,
		123,
		160,
		138,
		93,
		4,
		107,
		239,
		110,
		67,
		202,
		61,
		44,
		183,
		101,
		11,
		121,
		252,
		108,
		118,
		139,
		59,
		122,
		243,
		3,
		26,
		233,
		57,
		60,
		188,
		90,
		246,
		164,
		12,
		114,
		106,
		192,
		200,
		173,
		62,
		130,
		99,
		251,
		145,
		134,
		191,
		156,
		223,
		38,
		69,
		166,
		245,
		189,
		117,
		241,
		14,
		47,
		238,
		76,
		234,
		135,
		152,
		22,
		8,
		142,
		180,
		172,
		75,
		111,
		55,
		213,
		143,
		5,
		42,
		6,
		155,
		115,
		119,
		78,
		128,
		32,
		49,
		198,
		190,
		171,
		228,
		216,
		232,
		2,
		208,
		81,
		41,
		60,
		115,
		79,
		127,
		149,
		71,
		145,
		12,
		228,
		224,
		217,
		23,
		183,
		166,
		59,
		220,
		248,
		160,
		66,
		24,
		146,
		189,
		219,
		125,
		16,
		15,
		129,
		159,
		25,
		35,
		49,
		98,
		42,
		226,
		102,
		153,
		184,
		121,
		108,
		6,
		17,
		40,
		11,
		72,
		177,
		210,
		229,
		253,
		87,
		95,
		58,
		169,
		21,
		244,
		126,
		174,
		171,
		43,
		205,
		97,
		51,
		155,
		251,
		225,
		28,
		172,
		237,
		100,
		148,
		141,
		93,
		170,
		187,
		32,
		242,
		156,
		238,
		107,
		55,
		29,
		202,
		147,
		252,
		120,
		249,
		212,
		206,
		99,
		197,
		33,
		88,
		122,
		52,
		236,
		193,
		179,
		105,
		211,
		80,
		91,
		207,
		13,
		254,
		255,
		62,
		200,
		1,
		106,
		157,
		168,
		131,
		123,
		61,
		118,
		192,
		19,
		5,
		75,
		104,
		235,
		243,
		180,
		34,
		204,
		20,
		64,
		130,
		185,
		67,
		74,
		230,
		83,
		194,
		136,
		68,
		96,
		4,
		173,
		144,
		132,
		65,
		208,
		112,
		239,
		109,
		227,
		86,
		182,
		113,
		178,
		199,
		0,
		158,
		82,
		245,
		151,
		114,
		103,
		26,
		176,
		135,
		30,
		2,
		14,
		22,
		9,
		222,
		3,
		139,
		162,
		18,
		94,
		69,
		116,
		50,
		133,
		143,
		44,
		188,
		8,
		191,
		247,
		7,
		181,
		233,
		209,
		215,
		218,
		216,
		161,
		70,
		240,
		54,
		56,
		223,
		142,
		165,
		154,
		234,
		221,
		37,
		73,
		119,
		10,
		48,
		140,
		77,
		128,
		231,
		232,
		53,
		250,
		36,
		214,
		134,
		167,
		101,
		138,
		175,
		84,
		201,
		195,
		47,
		213,
		110,
		27,
		89,
		111,
		124,
		246,
		90,
		241,
		92,
		150,
		163,
		198,
		39,
		78,
		196,
		46,
		85,
		137,
		117,
		152,
		38,
		164,
		45,
		186,
		63,
		57,
		203,
		76,
		31,
		190,
		94,
		226,
		25,
		100,
		75,
		39,
		132,
		179,
		203,
		244,
		177,
		224,
		88,
		86,
		40,
		158,
		167,
		173,
		193,
		58,
		11,
		228,
		232,
		201,
		74,
		184,
		91,
		148,
		137,
		134,
		35,
		238,
		73,
		32,
		205,
		168,
		50,
		248,
		52,
		159,
		18,
		152,
		55,
		1,
		0,
		117,
		65,
		187,
		113,
		208,
		165,
		34,
		81,
		87,
		67,
		212,
		72,
		202,
		27,
		246,
		59,
		231,
		170,
		64,
		47,
		190,
		254,
		234,
		106,
		195,
		42,
		14,
		172,
		230,
		136,
		61,
		45,
		36,
		236,
		215,
		28,
		9,
		155,
		249,
		240,
		60,
		169,
		110,
		31,
		220,
		56,
		216,
		3,
		141,
		30,
		129,
		43,
		26,
		124,
		48,
		229,
		204,
		176,
		109,
		120,
		103,
		108,
		96,
		233,
		112,
		116,
		222,
		182,
		207,
		185,
		180,
		135,
		191,
		105,
		219,
		209,
		153,
		210,
		102,
		225,
		66,
		92,
		235,
		128,
		5,
		156,
		242,
		213,
		78,
		51,
		196,
		250,
		227,
		131,
		10,
		114,
		194,
		149,
		143,
		90,
		130,
		54,
		20,
		171,
		79,
		160,
		13,
		151,
		186,
		146,
		22,
		164,
		253,
		89,
		115,
		243,
		198,
		111,
		4,
		80,
		166,
		144,
		145,
		161,
		99,
		62,
		53,
		7,
		189,
		175,
		221,
		122,
		46,
		76,
		162,
		157,
		218,
		6,
		133,
		107,
		37,
		174,
		125,
		83,
		24,
		237,
		21,
		217,
		200,
		183,
		121,
		138,
		142,
		255,
		98,
		251,
		41,
		33,
		17,
		82,
		29,
		63,
		71,
		119,
		77,
		239,
		241,
		126,
		97,
		181,
		19,
		252,
		211,
		44,
		118,
		150,
		206,
		85,
		178,
		223,
		188,
		101,
		38,
		127,
		70,
		2,
		104,
		214,
		23,
		8,
		247,
		68,
		140,
		95,
		12,
		93,
		245,
		163,
		15,
		197,
		69,
		16,
		192,
		123,
		154,
		84,
		199,
		57,
		49,
		139,
		147,
		42,
		70,
		229,
		210,
		63,
		131,
		120,
		5,
		57,
		55,
		73,
		255,
		170,
		149,
		208,
		129,
		106,
		133,
		137,
		168,
		198,
		204,
		160,
		91,
		232,
		231,
		66,
		143,
		43,
		217,
		58,
		245,
		83,
		153,
		85,
		254,
		40,
		65,
		172,
		201,
		97,
		20,
		32,
		218,
		115,
		249,
		86,
		96,
		48,
		54,
		34,
		181,
		16,
		177,
		196,
		67,
		90,
		134,
		203,
		33,
		41,
		171,
		122,
		151,
		11,
		162,
		75,
		111,
		78,
		223,
		159,
		139,
		76,
		69,
		141,
		182,
		205,
		135,
		233,
		92,
		145,
		93,
		200,
		15,
		125,
		104,
		250,
		152,
		98,
		236,
		127,
		224,
		126,
		189,
		89,
		185,
		132,
		173,
		209,
		12,
		74,
		123,
		29,
		81,
		136,
		17,
		21,
		191,
		25,
		6,
		13,
		1,
		230,
		222,
		8,
		186,
		215,
		174,
		216,
		213,
		128,
		35,
		61,
		138,
		176,
		248,
		179,
		7,
		180,
		47,
		82,
		165,
		225,
		100,
		253,
		147,
		19,
		163,
		244,
		238,
		155,
		130,
		226,
		107,
		202,
		46,
		193,
		108,
		59,
		227,
		87,
		117,
		197,
		156,
		56,
		18,
		246,
		219,
		243,
		119,
		49,
		199,
		241,
		240,
		146,
		167,
		14,
		101,
		102,
		220,
		206,
		188,
		192,
		2,
		95,
		84,
		252,
		187,
		103,
		228,
		27,
		79,
		45,
		195,
		50,
		121,
		140,
		116,
		10,
		68,
		207,
		28,
		235,
		239,
		158,
		3,
		184,
		169,
		214,
		24,
		51,
		124,
		94,
		38,
		154,
		72,
		64,
		112,
		31,
		0,
		212,
		114,
		22,
		44,
		142,
		144,
		247,
		175,
		52,
		211,
		157,
		178,
		77,
		23,
		30,
		39,
		99,
		9,
		190,
		221,
		4,
		71,
		37,
		237,
		62,
		109,
		183,
		118,
		105,
		150,
		164,
		36,
		113,
		161,
		60,
		148,
		194,
		110,
		88,
		80,
		234,
		242,
		26,
		251,
		53,
		166,
		103,
		74,
		98,
		230,
		84,
		13,
		169,
		131,
		170,
		114,
		198,
		228,
		91,
		191,
		80,
		253,
		10,
		19,
		115,
		250,
		130,
		50,
		101,
		127,
		112,
		245,
		108,
		2,
		37,
		190,
		195,
		52,
		155,
		213,
		94,
		141,
		163,
		232,
		29,
		229,
		138,
		222,
		188,
		82,
		109,
		42,
		246,
		117,
		81,
		147,
		206,
		197,
		247,
		77,
		95,
		45,
		3,
		54,
		159,
		244,
		160,
		86,
		96,
		97,
		12,
		35,
		220,
		134,
		102,
		62,
		165,
		66,
		135,
		189,
		31,
		1,
		142,
		145,
		69,
		227,
		11,
		217,
		209,
		225,
		162,
		237,
		207,
		183,
		41,
		56,
		71,
		137,
		122,
		126,
		15,
		146,
		139,
		106,
		164,
		55,
		201,
		193,
		123,
		99,
		173,
		5,
		83,
		255,
		53,
		181,
		224,
		48,
		38,
		231,
		248,
		7,
		180,
		124,
		175,
		252,
		47,
		76,
		149,
		214,
		143,
		182,
		242,
		152,
		186,
		72,
		171,
		100,
		121,
		118,
		211,
		30,
		87,
		93,
		49,
		202,
		251,
		20,
		24,
		57,
		59,
		4,
		65,
		16,
		168,
		166,
		216,
		110,
		174,
		18,
		233,
		148,
		187,
		215,
		116,
		67,
		184,
		58,
		235,
		6,
		203,
		23,
		90,
		176,
		129,
		32,
		85,
		210,
		161,
		167,
		179,
		36,
		226,
		104,
		199,
		241,
		240,
		133,
		177,
		75,
		185,
		208,
		61,
		88,
		194,
		8,
		196,
		111,
		239,
		44,
		200,
		40,
		243,
		125,
		238,
		113,
		236,
		249,
		107,
		9,
		0,
		204,
		89,
		158,
		92,
		22,
		120,
		205,
		221,
		212,
		28,
		39,
		223,
		78,
		14,
		26,
		154,
		51,
		218,
		254,
		33,
		105,
		34,
		150,
		17,
		178,
		172,
		27,
		70,
		63,
		73,
		68,
		119,
		79,
		153,
		43,
		136,
		151,
		156,
		144,
		25,
		128,
		132,
		46,
		219,
		234,
		140,
		192,
		21,
		60,
		64,
		157,
		105,
		246,
		101,
		235,
		48,
		208,
		52,
		247,
		134,
		65,
		212,
		24,
		17,
		115,
		225,
		244,
		63,
		4,
		204,
		197,
		213,
		96,
		14,
		68,
		230,
		194,
		43,
		130,
		2,
		22,
		86,
		199,
		3,
		180,
		170,
		9,
		142,
		58,
		113,
		57,
		51,
		129,
		87,
		111,
		92,
		81,
		39,
		94,
		54,
		156,
		152,
		1,
		136,
		132,
		143,
		144,
		133,
		88,
		36,
		13,
		216,
		148,
		242,
		195,
		6,
		203,
		110,
		97,
		124,
		179,
		80,
		162,
		33,
		0,
		12,
		227,
		210,
		41,
		69,
		79,
		118,
		192,
		190,
		176,
		8,
		89,
		28,
		35,
		91,
		108,
		207,
		163,
		140,
		241,
		10,
		182,
		168,
		66,
		15,
		211,
		30,
		243,
		34,
		160,
		60,
		171,
		191,
		185,
		202,
		77,
		56,
		153,
		83,
		169,
		157,
		232,
		233,
		223,
		112,
		250,
		119,
		220,
		16,
		218,
		64,
		37,
		200,
		161,
		90,
		189,
		38,
		126,
		158,
		196,
		59,
		20,
		251,
		93,
		137,
		150,
		25,
		7,
		165,
		159,
		175,
		215,
		245,
		186,
		249,
		201,
		193,
		19,
		138,
		23,
		102,
		98,
		145,
		95,
		32,
		49,
		123,
		99,
		217,
		209,
		47,
		188,
		114,
		147,
		40,
		248,
		173,
		45,
		231,
		75,
		29,
		181,
		228,
		183,
		100,
		172,
		31,
		224,
		255,
		62,
		128,
		234,
		174,
		151,
		206,
		141,
		84,
		55,
		155,
		177,
		21,
		76,
		254,
		122,
		82,
		127,
		229,
		72,
		167,
		67,
		252,
		222,
		106,
		178,
		103,
		125,
		42,
		154,
		226,
		107,
		11,
		18,
		44,
		219,
		166,
		61,
		26,
		116,
		237,
		104,
		253,
		5,
		240,
		187,
		149,
		70,
		205,
		131,
		109,
		238,
		50,
		117,
		74,
		164,
		198,
		146,
		53,
		71,
		85,
		239,
		221,
		214,
		139,
		73,
		121,
		120,
		78,
		184,
		236,
		135,
		46,
		27,
		231,
		149,
		135,
		61,
		15,
		4,
		89,
		155,
		171,
		170,
		156,
		106,
		62,
		85,
		252,
		201,
		47,
		215,
		34,
		105,
		71,
		148,
		31,
		81,
		191,
		60,
		224,
		167,
		152,
		118,
		20,
		64,
		181,
		175,
		248,
		72,
		48,
		185,
		217,
		192,
		254,
		9,
		116,
		239,
		200,
		166,
		63,
		186,
		73,
		99,
		199,
		158,
		44,
		168,
		128,
		173,
		55,
		154,
		117,
		145,
		46,
		12,
		184,
		96,
		54,
		101,
		182,
		126,
		205,
		50,
		45,
		236,
		82,
		56,
		124,
		69,
		28,
		95,
		134,
		229,
		169,
		177,
		11,
		3,
		253,
		110,
		160,
		65,
		250,
		42,
		127,
		255,
		53,
		153,
		207,
		103,
		125,
		5,
		39,
		104,
		43,
		27,
		19,
		193,
		88,
		197,
		180,
		176,
		67,
		141,
		242,
		227,
		136,
		111,
		244,
		172,
		76,
		22,
		233,
		198,
		41,
		143,
		91,
		68,
		203,
		213,
		119,
		77,
		129,
		123,
		79,
		58,
		59,
		13,
		162,
		40,
		165,
		14,
		194,
		8,
		146,
		247,
		26,
		115,
		122,
		144,
		221,
		1,
		204,
		33,
		240,
		114,
		238,
		121,
		109,
		107,
		24,
		159,
		234,
		75,
		164,
		18,
		108,
		98,
		218,
		139,
		206,
		241,
		137,
		190,
		29,
		113,
		94,
		35,
		216,
		100,
		212,
		25,
		188,
		179,
		174,
		97,
		130,
		112,
		243,
		210,
		222,
		49,
		0,
		251,
		151,
		157,
		228,
		78,
		74,
		211,
		90,
		86,
		93,
		66,
		87,
		138,
		246,
		223,
		10,
		70,
		32,
		17,
		209,
		102,
		120,
		219,
		92,
		232,
		163,
		235,
		225,
		83,
		133,
		189,
		142,
		131,
		245,
		140,
		237,
		214,
		30,
		23,
		7,
		178,
		220,
		150,
		52,
		16,
		249,
		80,
		208,
		196,
		132,
		21,
		187,
		36,
		183,
		57,
		226,
		2,
		230,
		37,
		84,
		147,
		6,
		202,
		195,
		161,
		51,
		38,
		139,
		196,
		209,
		169,
		191,
		109,
		135,
		183,
		24,
		28,
		244,
		105,
		94,
		79,
		239,
		33,
		88,
		0,
		36,
		195,
		69,
		106,
		224,
		186,
		247,
		232,
		133,
		35,
		219,
		225,
		103,
		121,
		26,
		210,
		154,
		201,
		129,
		64,
		97,
		158,
		208,
		233,
		254,
		148,
		42,
		73,
		176,
		243,
		167,
		175,
		5,
		29,
		12,
		237,
		81,
		194,
		211,
		83,
		86,
		134,
		99,
		203,
		153,
		53,
		84,
		228,
		25,
		3,
		117,
		108,
		156,
		21,
		216,
		67,
		82,
		165,
		147,
		22,
		100,
		10,
		107,
		50,
		229,
		207,
		44,
		1,
		128,
		4,
		217,
		61,
		155,
		54,
		20,
		204,
		130,
		160,
		43,
		145,
		75,
		57,
		245,
		55,
		163,
		168,
		48,
		198,
		7,
		6,
		80,
		101,
		146,
		249,
		142,
		197,
		131,
		123,
		179,
		253,
		235,
		56,
		76,
		11,
		19,
		144,
		184,
		236,
		52,
		218,
		178,
		187,
		65,
		122,
		112,
		58,
		171,
		30,
		85,
		252,
		152,
		188,
		40,
		185,
		124,
		104,
		27,
		149,
		23,
		136,
		74,
		137,
		78,
		174,
		170,
		102,
		248,
		63,
		159,
		138,
		111,
		13,
		230,
		127,
		72,
		226,
		241,
		238,
		246,
		250,
		90,
		115,
		251,
		38,
		140,
		189,
		166,
		234,
		212,
		119,
		125,
		202,
		15,
		71,
		240,
		68,
		41,
		17,
		77,
		255,
		89,
		32,
		34,
		47,
		192,
		206,
		8,
		190,
		98,
		93,
		118,
		39,
		177,
		221,
		37,
		18,
		116,
		200,
		242,
		143,
		16,
		31,
		120,
		181,
		46,
		220,
		2,
		205,
		114,
		157,
		95,
		126,
		59,
		49,
		172,
		87,
		227,
		150,
		45,
		215,
		14,
		132,
		151,
		161,
		110,
		164,
		9,
		162,
		182,
		223,
		62,
		91,
		113,
		173,
		214,
		60,
		92,
		222,
		96,
		141,
		193,
		199,
		66,
		213,
		70,
		231,
		180,
		51,
		85,
		94,
		3,
		193,
		189,
		207,
		221,
		103,
		100,
		15,
		166,
		147,
		241,
		240,
		198,
		48,
		29,
		206,
		69,
		11,
		117,
		141,
		120,
		51,
		194,
		44,
		78,
		26,
		229,
		102,
		186,
		253,
		106,
		227,
		131,
		154,
		239,
		245,
		162,
		18,
		146,
		252,
		101,
		224,
		164,
		83,
		46,
		181,
		118,
		242,
		218,
		247,
		19,
		57,
		157,
		196,
		116,
		86,
		226,
		58,
		109,
		192,
		47,
		203,
		151,
		104,
		119,
		182,
		108,
		63,
		236,
		36,
		70,
		5,
		220,
		191,
		8,
		98,
		38,
		31,
		167,
		52,
		250,
		27,
		243,
		235,
		81,
		89,
		111,
		195,
		149,
		61,
		160,
		112,
		37,
		165,
		113,
		65,
		73,
		155,
		39,
		95,
		125,
		50,
		25,
		215,
		168,
		185,
		2,
		159,
		238,
		234,
		22,
		76,
		179,
		156,
		210,
		53,
		174,
		246,
		145,
		143,
		45,
		23,
		115,
		213,
		1,
		30,
		97,
		87,
		248,
		114,
		219,
		33,
		21,
		96,
		200,
		173,
		64,
		41,
		255,
		84,
		152,
		82,
		150,
		123,
		170,
		40,
		32,
		202,
		135,
		91,
		66,
		197,
		176,
		17,
		180,
		35,
		55,
		49,
		128,
		209,
		148,
		171,
		254,
		72,
		54,
		56,
		4,
		121,
		130,
		62,
		211,
		228,
		71,
		43,
		244,
		59,
		216,
		42,
		142,
		67,
		230,
		233,
		90,
		161,
		205,
		199,
		169,
		136,
		132,
		107,
		0,
		12,
		7,
		24,
		190,
		20,
		16,
		137,
		80,
		28,
		122,
		75,
		13,
		208,
		172,
		133,
		6,
		178,
		249,
		177,
		139,
		60,
		34,
		129,
		212,
		217,
		175,
		214,
		187,
		9,
		223,
		231,
		93,
		232,
		134,
		204,
		183,
		140,
		68,
		77,
		138,
		158,
		222,
		79,
		110,
		74,
		163,
		10,
		184,
		88,
		188,
		127,
		225,
		126,
		237,
		99,
		153,
		251,
		105,
		124,
		14,
		201,
		92,
		144,
		10,
		169,
		183,
		0,
		58,
		114,
		57,
		141,
		108,
		84,
		130,
		48,
		93,
		36,
		82,
		95,
		2,
		155,
		159,
		53,
		147,
		140,
		135,
		139,
		14,
		39,
		91,
		134,
		192,
		241,
		151,
		219,
		232,
		102,
		245,
		106,
		244,
		55,
		211,
		51,
		27,
		215,
		66,
		133,
		247,
		226,
		112,
		18,
		198,
		207,
		7,
		60,
		71,
		13,
		99,
		214,
		129,
		40,
		193,
		229,
		196,
		85,
		21,
		1,
		208,
		12,
		65,
		171,
		163,
		33,
		240,
		29,
		186,
		188,
		168,
		63,
		154,
		59,
		78,
		201,
		235,
		158,
		170,
		80,
		249,
		115,
		220,
		234,
		217,
		19,
		223,
		116,
		162,
		203,
		38,
		67,
		98,
		109,
		200,
		5,
		161,
		83,
		176,
		127,
		224,
		15,
		3,
		34,
		76,
		70,
		42,
		209,
		179,
		189,
		195,
		117,
		32,
		31,
		90,
		11,
		160,
		204,
		111,
		88,
		181,
		9,
		242,
		143,
		210,
		218,
		96,
		120,
		144,
		113,
		191,
		44,
		46,
		174,
		251,
		43,
		182,
		30,
		72,
		228,
		175,
		103,
		180,
		231,
		61,
		252,
		227,
		28,
		148,
		173,
		233,
		131,
		52,
		87,
		142,
		205,
		125,
		37,
		190,
		89,
		23,
		56,
		199,
		157,
		149,
		138,
		94,
		248,
		156,
		166,
		4,
		26,
		185,
		246,
		212,
		172,
		16,
		194,
		202,
		250,
		97,
		101,
		20,
		137,
		50,
		35,
		92,
		146,
		184,
		243,
		6,
		254,
		128,
		206,
		69,
		150,
		118,
		49,
		237,
		110,
		145,
		197,
		167,
		73,
		236,
		86,
		68,
		54,
		74,
		136,
		213,
		222,
		187,
		77,
		123,
		122,
		24,
		45,
		132,
		239,
		79,
		22,
		178,
		152,
		124,
		81,
		121,
		253,
		64,
		164,
		75,
		230,
		177,
		105,
		221,
		255,
		153,
		41,
		126,
		100,
		17,
		8,
		104,
		225,
		62,
		165,
		216,
		47,
		107,
		238,
		119,
		25,
		79,
		38,
		199,
		162,
		151,
		93,
		240,
		91,
		247,
		125,
		110,
		88,
		26,
		111,
		212,
		46,
		191,
		30,
		77,
		202,
		56,
		62,
		187,
		44,
		165,
		39,
		153,
		116,
		136,
		84,
		47,
		197,
		141,
		49,
		11,
		118,
		72,
		36,
		220,
		235,
		155,
		164,
		143,
		222,
		57,
		55,
		241,
		71,
		194,
		200,
		85,
		174,
		139,
		100,
		166,
		135,
		215,
		37,
		251,
		52,
		233,
		230,
		129,
		76,
		117,
		68,
		95,
		19,
		163,
		138,
		2,
		223,
		8,
		23,
		15,
		3,
		31,
		134,
		177,
		27,
		160,
		217,
		219,
		214,
		208,
		232,
		180,
		6,
		246,
		190,
		9,
		189,
		45,
		142,
		132,
		51,
		209,
		64,
		133,
		145,
		172,
		5,
		97,
		69,
		137,
		195,
		82,
		231,
		75,
		66,
		184,
		131,
		102,
		115,
		150,
		244,
		83,
		159,
		1,
		198,
		179,
		112,
		183,
		87,
		226,
		108,
		238,
		113,
		169,
		156,
		107,
		0,
		201,
		63,
		254,
		255,
		12,
		206,
		90,
		81,
		210,
		104,
		178,
		192,
		65,
		21,
		205,
		35,
		181,
		242,
		234,
		105,
		74,
		4,
		18,
		193,
		119,
		60,
		122,
		130,
		106,
		239,
		157,
		243,
		33,
		186,
		171,
		92,
		140,
		149,
		101,
		236,
		173,
		29,
		224,
		250,
		237,
		53,
		123,
		89,
		32,
		196,
		98,
		207,
		213,
		248,
		121,
		253,
		146,
		203,
		28,
		54,
		211,
		176,
		73,
		10,
		41,
		16,
		7,
		109,
		120,
		185,
		152,
		103,
		227,
		43,
		99,
		48,
		154,
		50,
		96,
		204,
		42,
		170,
		175,
		127,
		245,
		20,
		168,
		59,
		94,
		86,
		252,
		228,
		167,
		182,
		22,
		216,
		225,
		229,
		13,
		144,
		70,
		148,
		126,
		78,
		114,
		61,
		40,
		80,
		34,
		24,
		158,
		128,
		14,
		17,
		124,
		218,
		188,
		147,
		25,
		67,
		161,
		249,
		221,
		58,
		109,
		231,
		244,
		194,
		128,
		245,
		78,
		180,
		213,
		188,
		93,
		56,
		13,
		199,
		106,
		193,
		63,
		189,
		3,
		238,
		18,
		206,
		181,
		95,
		37,
		132,
		215,
		80,
		162,
		164,
		33,
		182,
		1,
		62,
		21,
		68,
		163,
		173,
		107,
		221,
		23,
		171,
		145,
		236,
		210,
		190,
		70,
		113,
		77,
		191,
		97,
		174,
		115,
		124,
		27,
		214,
		88,
		82,
		207,
		52,
		17,
		254,
		60,
		29,
		146,
		141,
		149,
		153,
		133,
		28,
		43,
		129,
		239,
		222,
		197,
		137,
		57,
		16,
		152,
		69,
		108,
		36,
		147,
		39,
		183,
		20,
		30,
		169,
		58,
		67,
		65,
		76,
		74,
		114,
		46,
		156,
		19,
		89,
		200,
		125,
		209,
		216,
		34,
		25,
		75,
		218,
		31,
		11,
		54,
		159,
		251,
		223,
		41,
		234,
		45,
		205,
		120,
		246,
		116,
		235,
		252,
		233,
		12,
		110,
		201,
		5,
		155,
		92,
		150,
		84,
		192,
		203,
		72,
		242,
		40,
		90,
		51,
		6,
		241,
		154,
		83,
		165,
		100,
		101,
		208,
		158,
		136,
		91,
		237,
		166,
		224,
		24,
		219,
		143,
		87,
		185,
		47,
		104,
		112,
		243,
		22,
		15,
		255,
		118,
		55,
		135,
		122,
		96,
		240,
		117,
		7,
		105,
		187,
		32,
		49,
		198,
		79,
		98,
		227,
		103,
		8,
		81,
		134,
		172,
		119,
		175,
		225,
		195,
		186,
		94,
		248,
		85,
		226,
		35,
		2,
		253,
		121,
		177,
		249,
		170,
		73,
		42,
		211,
		144,
		179,
		138,
		157,
		247,
		111,
		142,
		50,
		161,
		196,
		204,
		102,
		126,
		0,
		168,
		250,
		86,
		176,
		48,
		53,
		229,
		220,
		14,
		228,
		212,
		232,
		167,
		178,
		202,
		61,
		44,
		140,
		66,
		123,
		127,
		151,
		10,
		38,
		9,
		131,
		217,
		59,
		99,
		71,
		160,
		184,
		130,
		4,
		26,
		148,
		139,
		230,
		64,
		205,
		100,
		141,
		169,
		136,
		25,
		89,
		77,
		138,
		131,
		75,
		112,
		11,
		65,
		47,
		154,
		87,
		155,
		14,
		201,
		187,
		174,
		60,
		94,
		164,
		42,
		185,
		38,
		184,
		123,
		159,
		127,
		66,
		107,
		23,
		202,
		140,
		189,
		219,
		151,
		78,
		215,
		211,
		121,
		223,
		192,
		203,
		199,
		32,
		24,
		206,
		124,
		17,
		104,
		30,
		19,
		70,
		229,
		251,
		76,
		118,
		62,
		117,
		193,
		236,
		128,
		35,
		20,
		249,
		69,
		190,
		195,
		255,
		241,
		143,
		57,
		108,
		83,
		22,
		71,
		172,
		67,
		79,
		110,
		0,
		10,
		102,
		157,
		46,
		33,
		132,
		73,
		237,
		31,
		252,
		51,
		149,
		95,
		147,
		56,
		238,
		135,
		106,
		15,
		167,
		210,
		230,
		28,
		181,
		63,
		144,
		166,
		246,
		240,
		228,
		115,
		214,
		119,
		2,
		133,
		156,
		64,
		13,
		231,
		239,
		109,
		188,
		81,
		45,
		41,
		88,
		197,
		126,
		111,
		16,
		222,
		245,
		186,
		152,
		224,
		92,
		142,
		134,
		182,
		217,
		198,
		18,
		180,
		208,
		234,
		72,
		86,
		49,
		105,
		242,
		21,
		91,
		116,
		139,
		209,
		216,
		225,
		165,
		207,
		120,
		27,
		194,
		129,
		227,
		43,
		248,
		171,
		113,
		176,
		175,
		80,
		98,
		226,
		183,
		103,
		250,
		82,
		4,
		168,
		158,
		150,
		44,
		52,
		220,
		61,
		243,
		96,
		114,
		233,
		148,
		99,
		39,
		162,
		59,
		85,
		213,
		101,
		50,
		40,
		93,
		68,
		36,
		173,
		12,
		232,
		7,
		170,
		253,
		37,
		145,
		179,
		3,
		90,
		254,
		212,
		48,
		29,
		53,
		177,
		247,
		1,
		55,
		54,
		84,
		97,
		200,
		163,
		160,
		26,
		8,
		122,
		6,
		196,
		153,
		146,
		58,
		125,
		161,
		34,
		221,
		137,
		235,
		5,
		244,
		191,
		74,
		178,
		204,
		130,
		9,
		218,
		243,
		129,
		91,
		225,
		98,
		105,
		253,
		63,
		204,
		205,
		12,
		250,
		51,
		88,
		175,
		154,
		177,
		73,
		15,
		68,
		242,
		33,
		55,
		121,
		90,
		217,
		193,
		134,
		16,
		254,
		38,
		114,
		201,
		211,
		46,
		158,
		223,
		86,
		166,
		191,
		111,
		152,
		137,
		18,
		192,
		174,
		220,
		89,
		5,
		47,
		248,
		161,
		206,
		74,
		203,
		230,
		252,
		81,
		247,
		19,
		106,
		72,
		6,
		222,
		3,
		80,
		24,
		208,
		84,
		171,
		138,
		75,
		94,
		52,
		35,
		26,
		57,
		122,
		131,
		224,
		215,
		207,
		101,
		109,
		8,
		155,
		39,
		198,
		76,
		156,
		153,
		25,
		255,
		83,
		1,
		169,
		99,
		27,
		14,
		65,
		125,
		77,
		167,
		117,
		163,
		62,
		214,
		210,
		235,
		37,
		133,
		148,
		9,
		238,
		202,
		146,
		112,
		42,
		160,
		143,
		233,
		79,
		34,
		61,
		179,
		173,
		43,
		17,
		29,
		231,
		92,
		41,
		107,
		93,
		78,
		196,
		104,
		195,
		110,
		164,
		145,
		244,
		21,
		124,
		246,
		28,
		103,
		187,
		71,
		170,
		20,
		150,
		31,
		136,
		13,
		11,
		249,
		126,
		45,
		140,
		116,
		194,
		4,
		10,
		237,
		188,
		151,
		168,
		216,
		239,
		23,
		123,
		69,
		56,
		2,
		190,
		127,
		178,
		213,
		218,
		7,
		200,
		22,
		228,
		180,
		149,
		87,
		184,
		157,
		102,
		251,
		241,
		40,
		130,
		181,
		44,
		48,
		60,
		36,
		59,
		236,
		49,
		185,
		144,
		32,
		108,
		119,
		70,
		0,
		183,
		189,
		30,
		142,
		58,
		141,
		197,
		53,
		135,
		219,
		227,
		229,
		232,
		234,
		147,
		176,
		139,
		113,
		120,
		212,
		97,
		240,
		186,
		118,
		82,
		54,
		159,
		162,
		182,
		115,
		226,
		66,
		221,
		95,
		209,
		100,
		132,
		67,
		128,
		245,
		50,
		172,
		96,
		199,
		165,
		64,
		85,
		226,
		50,
		103,
		231,
		45,
		129,
		215,
		127,
		177,
		169,
		19,
		27,
		229,
		118,
		184,
		89,
		74,
		32,
		100,
		93,
		4,
		71,
		158,
		253,
		46,
		125,
		174,
		102,
		213,
		42,
		53,
		244,
		49,
		151,
		67,
		92,
		211,
		205,
		111,
		85,
		144,
		119,
		236,
		180,
		84,
		14,
		241,
		222,
		64,
		221,
		172,
		168,
		91,
		149,
		234,
		251,
		101,
		29,
		63,
		112,
		51,
		3,
		11,
		217,
		167,
		36,
		248,
		191,
		128,
		110,
		12,
		88,
		55,
		207,
		58,
		113,
		95,
		140,
		7,
		73,
		179,
		178,
		132,
		114,
		38,
		77,
		228,
		209,
		255,
		141,
		159,
		37,
		23,
		28,
		65,
		131,
		47,
		130,
		109,
		137,
		54,
		20,
		160,
		120,
		81,
		123,
		223,
		134,
		52,
		176,
		152,
		181,
		230,
		17,
		108,
		247,
		208,
		190,
		39,
		162,
		173,
		183,
		224,
		80,
		40,
		161,
		193,
		216,
		249,
		75,
		157,
		165,
		150,
		155,
		237,
		148,
		201,
		126,
		96,
		195,
		68,
		240,
		187,
		243,
		79,
		146,
		238,
		199,
		18,
		94,
		56,
		9,
		252,
		86,
		82,
		203,
		66,
		78,
		69,
		90,
		76,
		139,
		30,
		210,
		219,
		185,
		43,
		62,
		163,
		60,
		175,
		33,
		250,
		26,
		254,
		61,
		44,
		8,
		225,
		72,
		200,
		220,
		156,
		13,
		245,
		206,
		6,
		15,
		31,
		170,
		196,
		142,
		246,
		97,
		117,
		115,
		0,
		135,
		242,
		83,
		98,
		136,
		197,
		25,
		212,
		57,
		232,
		106,
		189,
		22,
		218,
		16,
		138,
		239,
		2,
		107,
		153,
		99,
		87,
		34,
		35,
		21,
		186,
		48,
		235,
		202,
		198,
		41,
		24,
		227,
		143,
		133,
		204,
		1,
		164,
		171,
		182,
		121,
		154,
		104,
		145,
		166,
		5,
		105,
		70,
		59,
		192,
		124,
		188,
		10,
		116,
		122,
		194,
		147,
		214,
		233,
		18,
		3,
		124,
		178,
		65,
		69,
		52,
		169,
		48,
		226,
		234,
		218,
		153,
		214,
		244,
		140,
		188,
		134,
		36,
		58,
		181,
		170,
		126,
		216,
		55,
		24,
		231,
		189,
		93,
		5,
		158,
		121,
		20,
		119,
		174,
		237,
		180,
		141,
		201,
		163,
		29,
		220,
		195,
		60,
		143,
		71,
		148,
		199,
		150,
		62,
		104,
		196,
		14,
		142,
		219,
		11,
		176,
		81,
		159,
		12,
		242,
		250,
		64,
		88,
		75,
		206,
		87,
		57,
		30,
		133,
		248,
		15,
		49,
		40,
		72,
		193,
		185,
		9,
		94,
		68,
		145,
		73,
		253,
		223,
		96,
		132,
		107,
		198,
		92,
		113,
		89,
		221,
		111,
		54,
		146,
		184,
		56,
		13,
		164,
		207,
		155,
		109,
		91,
		90,
		106,
		168,
		245,
		254,
		204,
		118,
		100,
		22,
		177,
		229,
		135,
		105,
		86,
		17,
		205,
		78,
		160,
		238,
		101,
		182,
		152,
		211,
		38,
		222,
		228,
		117,
		53,
		33,
		161,
		8,
		225,
		197,
		103,
		45,
		67,
		246,
		230,
		239,
		39,
		28,
		215,
		194,
		80,
		50,
		59,
		247,
		98,
		165,
		212,
		23,
		243,
		19,
		200,
		70,
		213,
		74,
		224,
		209,
		183,
		251,
		46,
		7,
		123,
		166,
		179,
		172,
		167,
		171,
		34,
		187,
		191,
		21,
		125,
		4,
		114,
		127,
		76,
		116,
		162,
		16,
		26,
		82,
		25,
		173,
		42,
		137,
		151,
		32,
		149,
		41,
		210,
		175,
		128,
		236,
		79,
		120,
		0,
		63,
		122,
		43,
		147,
		157,
		227,
		85,
		108,
		102,
		10,
		241,
		192,
		47,
		35,
		2,
		129,
		115,
		144,
		95,
		66,
		77,
		232,
		37,
		130,
		235,
		6,
		99,
		249,
		51,
		255,
		84,
		217,
		83,
		252,
		202,
		203,
		190,
		138,
		112,
		186,
		27,
		110,
		233,
		154,
		156,
		136,
		31,
		131,
		1,
		208,
		61,
		240,
		44,
		97,
		139,
		199,
		11,
		158,
		89,
		43,
		62,
		172,
		206,
		52,
		186,
		41,
		182,
		40,
		235,
		15,
		239,
		93,
		244,
		29,
		57,
		24,
		137,
		201,
		221,
		26,
		19,
		219,
		224,
		155,
		209,
		191,
		10,
		176,
		136,
		94,
		236,
		129,
		248,
		142,
		131,
		214,
		117,
		107,
		220,
		230,
		174,
		229,
		81,
		210,
		251,
		135,
		90,
		28,
		45,
		75,
		7,
		222,
		71,
		67,
		233,
		79,
		80,
		91,
		87,
		60,
		211,
		223,
		254,
		144,
		154,
		246,
		13,
		190,
		177,
		20,
		217,
		125,
		143,
		108,
		163,
		124,
		16,
		179,
		132,
		105,
		213,
		46,
		83,
		111,
		97,
		31,
		169,
		252,
		195,
		134,
		215,
		102,
		96,
		116,
		227,
		70,
		231,
		146,
		21,
		12,
		208,
		157,
		119,
		127,
		253,
		44,
		193,
		5,
		207,
		3,
		168,
		126,
		23,
		250,
		159,
		55,
		66,
		118,
		140,
		37,
		175,
		0,
		54,
		73,
		86,
		130,
		36,
		64,
		122,
		216,
		198,
		161,
		249,
		98,
		133,
		203,
		228,
		27,
		65,
		189,
		185,
		200,
		85,
		238,
		255,
		128,
		78,
		101,
		42,
		8,
		112,
		204,
		30,
		22,
		38,
		242,
		114,
		39,
		247,
		106,
		194,
		148,
		56,
		14,
		6,
		188,
		164,
		76,
		173,
		99,
		240,
		72,
		113,
		53,
		95,
		232,
		139,
		82,
		17,
		115,
		187,
		104,
		59,
		225,
		32,
		63,
		192,
		156,
		120,
		151,
		58,
		109,
		181,
		1,
		35,
		147,
		202,
		110,
		68,
		160,
		141,
		165,
		33,
		226,
		121,
		4,
		243,
		183,
		50,
		171,
		197,
		69,
		245,
		162,
		184,
		205,
		212,
		180,
		61,
		170,
		237,
		49,
		178,
		77,
		25,
		123,
		149,
		100,
		47,
		218,
		34,
		92,
		18,
		153,
		74,
		103,
		145,
		167,
		166,
		196,
		241,
		88,
		51,
		48,
		138,
		152,
		234,
		150,
		84,
		9,
		2,
		97,
		252,
		20,
		16,
		41,
		231,
		71,
		86,
		161,
		217,
		204,
		131,
		191,
		143,
		101,
		183,
		43,
		141,
		224,
		255,
		113,
		111,
		233,
		211,
		203,
		44,
		8,
		80,
		178,
		232,
		98,
		77,
		156,
		246,
		225,
		216,
		251,
		184,
		65,
		34,
		193,
		146,
		218,
		18,
		150,
		105,
		72,
		137,
		142,
		94,
		91,
		219,
		61,
		145,
		195,
		107,
		21,
		13,
		167,
		175,
		202,
		89,
		229,
		4,
		173,
		90,
		75,
		208,
		2,
		108,
		30,
		155,
		11,
		17,
		236,
		92,
		29,
		148,
		100,
		125,
		62,
		147,
		53,
		209,
		168,
		138,
		196,
		28,
		199,
		237,
		58,
		99,
		12,
		136,
		9,
		36,
		14,
		15,
		206,
		56,
		241,
		154,
		109,
		88,
		49,
		67,
		153,
		35,
		160,
		171,
		63,
		253,
		152,
		27,
		3,
		68,
		210,
		60,
		228,
		176,
		115,
		139,
		205,
		134,
		48,
		227,
		245,
		187,
		180,
		144,
		244,
		93,
		96,
		116,
		177,
		32,
		114,
		73,
		179,
		186,
		22,
		163,
		50,
		120,
		55,
		240,
		110,
		162,
		5,
		103,
		130,
		151,
		128,
		31,
		157,
		19,
		166,
		70,
		129,
		66,
		46,
		243,
		123,
		82,
		226,
		174,
		181,
		132,
		234,
		64,
		119,
		238,
		242,
		254,
		230,
		249,
		247,
		69,
		25,
		33,
		39,
		42,
		40,
		81,
		194,
		117,
		127,
		220,
		76,
		248,
		79,
		7,
		26,
		45,
		213,
		185,
		135,
		250,
		192,
		124,
		182,
		0,
		198,
		200,
		47,
		126,
		85,
		106,
		118,
		87,
		149,
		122,
		95,
		164,
		57,
		51,
		189,
		112,
		23,
		24,
		197,
		10,
		212,
		38,
		170,
		1,
		172,
		102,
		83,
		54,
		215,
		190,
		223,
		37,
		158,
		235,
		169,
		159,
		140,
		6,
		221,
		74,
		207,
		201,
		59,
		188,
		239,
		78,
		52,
		222,
		165,
		121,
		133,
		104,
		214,
		84,
		36,
		191,
		174,
		89,
		111,
		234,
		152,
		246,
		168,
		24,
		229,
		255,
		137,
		144,
		96,
		233,
		37,
		193,
		103,
		202,
		232,
		48,
		126,
		92,
		151,
		206,
		25,
		51,
		208,
		253,
		124,
		248,
		204,
		58,
		251,
		250,
		172,
		153,
		110,
		5,
		215,
		109,
		183,
		197,
		9,
		203,
		95,
		84,
		176,
		247,
		239,
		108,
		68,
		16,
		200,
		38,
		114,
		57,
		127,
		135,
		79,
		1,
		23,
		196,
		228,
		224,
		8,
		149,
		162,
		179,
		19,
		221,
		119,
		56,
		45,
		85,
		67,
		145,
		123,
		75,
		11,
		20,
		121,
		223,
		39,
		29,
		155,
		133,
		164,
		252,
		216,
		63,
		185,
		150,
		28,
		70,
		44,
		21,
		2,
		104,
		214,
		181,
		76,
		15,
		230,
		46,
		102,
		53,
		125,
		188,
		157,
		98,
		47,
		175,
		170,
		122,
		159,
		55,
		101,
		201,
		91,
		83,
		249,
		225,
		240,
		17,
		173,
		62,
		77,
		33,
		217,
		238,
		136,
		52,
		14,
		115,
		60,
		50,
		244,
		66,
		158,
		161,
		138,
		219,
		142,
		97,
		163,
		130,
		199,
		205,
		80,
		171,
		236,
		227,
		132,
		73,
		210,
		32,
		254,
		49,
		146,
		88,
		245,
		94,
		74,
		35,
		194,
		167,
		31,
		106,
		209,
		43,
		242,
		120,
		107,
		93,
		61,
		59,
		190,
		41,
		186,
		27,
		72,
		207,
		141,
		81,
		42,
		192,
		160,
		34,
		156,
		113,
		169,
		0,
		100,
		64,
		212,
		69,
		128,
		148,
		78,
		71,
		189,
		134,
		140,
		198,
		87,
		226,
		86,
		154,
		4,
		195,
		99,
		118,
		147,
		241,
		231,
		105,
		235,
		116,
		182,
		117,
		178,
		82,
		166,
		143,
		7,
		218,
		112,
		65,
		90,
		22,
		26,
		131,
		180,
		30,
		13,
		18,
		10,
		6,
		213,
		237,
		177,
		3,
		165,
		220,
		222,
		211,
		40,
		139,
		129,
		54,
		243,
		187,
		12,
		184,
		91,
		24,
		225,
		130,
		60,
		86,
		65,
		120,
		54,
		201,
		232,
		41,
		97,
		50,
		122,
		178,
		157,
		49,
		99,
		203,
		46,
		254,
		251,
		123,
		106,
		249,
		69,
		164,
		181,
		173,
		7,
		15,
		137,
		71,
		231,
		246,
		193,
		92,
		180,
		176,
		31,
		47,
		197,
		23,
		1,
		121,
		108,
		35,
		209,
		207,
		73,
		115,
		139,
		45,
		64,
		95,
		18,
		72,
		194,
		237,
		107,
		140,
		168,
		240,
		81,
		58,
		205,
		248,
		174,
		175,
		110,
		152,
		0,
		11,
		159,
		93,
		145,
		227,
		57,
		131,
		114,
		156,
		68,
		16,
		56,
		187,
		163,
		228,
		144,
		67,
		85,
		27,
		211,
		43,
		109,
		38,
		162,
		204,
		190,
		59,
		13,
		250,
		235,
		112,
		189,
		52,
		196,
		221,
		171,
		177,
		76,
		252,
		8,
		42,
		100,
		188,
		158,
		51,
		149,
		113,
		172,
		40,
		169,
		132,
		103,
		77,
		154,
		195,
		66,
		14,
		21,
		36,
		142,
		83,
		219,
		242,
		82,
		94,
		70,
		89,
		74,
		224,
		215,
		78,
		135,
		138,
		136,
		241,
		87,
		229,
		185,
		129,
		236,
		88,
		239,
		167,
		98,
		213,
		223,
		124,
		192,
		212,
		17,
		128,
		20,
		48,
		84,
		253,
		182,
		3,
		146,
		216,
		210,
		233,
		19,
		26,
		165,
		199,
		34,
		55,
		151,
		80,
		206,
		2,
		6,
		230,
		33,
		226,
		32,
		191,
		61,
		179,
		243,
		150,
		119,
		30,
		10,
		161,
		12,
		198,
		9,
		63,
		44,
		166,
		127,
		133,
		62,
		75,
		155,
		28,
		79,
		238,
		125,
		234,
		111,
		105,
		37,
		200,
		118,
		244,
		148,
		126,
		5,
		217,
		39,
		90,
		96,
		220,
		186,
		141,
		117,
		25,
		143,
		222,
		245,
		202,
		22,
		160,
		102,
		104,
		255,
		4,
		153,
		147,
		214,
		247,
		53,
		218,
		101,
		170,
		116,
		134,
		29,
		208,
		183,
		184,
		107,
		233,
		87,
		186,
		70,
		154,
		225,
		11,
		113,
		208,
		131,
		4,
		246,
		240,
		117,
		226,
		57,
		179,
		160,
		150,
		212,
		161,
		26,
		224,
		129,
		232,
		9,
		108,
		89,
		147,
		62,
		149,
		25,
		235,
		53,
		250,
		39,
		40,
		79,
		130,
		12,
		6,
		155,
		96,
		69,
		170,
		104,
		73,
		85,
		106,
		65,
		16,
		247,
		249,
		63,
		137,
		67,
		255,
		197,
		184,
		134,
		234,
		18,
		37,
		56,
		112,
		199,
		115,
		227,
		64,
		74,
		253,
		110,
		23,
		21,
		24,
		30,
		38,
		122,
		200,
		198,
		217,
		193,
		205,
		209,
		72,
		127,
		213,
		187,
		138,
		145,
		221,
		109,
		68,
		204,
		17,
		125,
		190,
		121,
		153,
		44,
		162,
		32,
		191,
		168,
		189,
		88,
		58,
		157,
		81,
		207,
		8,
		71,
		13,
		156,
		41,
		133,
		140,
		118,
		77,
		31,
		142,
		75,
		95,
		98,
		203,
		175,
		139,
		132,
		202,
		220,
		15,
		185,
		242,
		180,
		76,
		143,
		219,
		3,
		237,
		123,
		60,
		36,
		167,
		194,
		0,
		148,
		159,
		28,
		166,
		124,
		14,
		103,
		82,
		165,
		206,
		7,
		241,
		48,
		49,
		27,
		54,
		183,
		51,
		92,
		5,
		210,
		248,
		35,
		251,
		181,
		151,
		238,
		10,
		172,
		1,
		66,
		91,
		171,
		34,
		99,
		211,
		46,
		52,
		164,
		33,
		83,
		61,
		239,
		116,
		101,
		146,
		59,
		218,
		102,
		245,
		144,
		152,
		50,
		42,
		84,
		252,
		174,
		2,
		228,
		100,
		97,
		177,
		182,
		119,
		86,
		169,
		45,
		229,
		173,
		254,
		29,
		126,
		135,
		196,
		231,
		222,
		201,
		163,
		114,
		93,
		215,
		141,
		111,
		55,
		19,
		244,
		236,
		214,
		80,
		78,
		192,
		223,
		178,
		20,
		136,
		90,
		176,
		128,
		188,
		243,
		230,
		158,
		105,
		120,
		216,
		22,
		47,
		43,
		195,
		94,
		208,
		196,
		132,
		21,
		52,
		16,
		249,
		80,
		7,
		178,
		220,
		150,
		237,
		214,
		30,
		23,
		195,
		161,
		51,
		38,
		84,
		147,
		6,
		202,
		226,
		2,
		230,
		37,
		187,
		36,
		183,
		57,
		10,
		70,
		32,
		17,
		87,
		138,
		246,
		223,
		90,
		86,
		93,
		66,
		228,
		78,
		74,
		211,
		142,
		131,
		245,
		140,
		225,
		83,
		133,
		189,
		92,
		232,
		163,
		235,
		209,
		102,
		120,
		219,
		94,
		35,
		216,
		100,
		137,
		190,
		29,
		113,
		218,
		139,
		206,
		241,
		164,
		18,
		108,
		98,
		0,
		251,
		151,
		157,
		243,
		210,
		222,
		49,
		174,
		97,
		130,
		112,
		212,
		25,
		188,
		179,
		146,
		247,
		26,
		115,
		165,
		14,
		194,
		8,
		59,
		13,
		162,
		40,
		129,
		123,
		79,
		58,
		24,
		159,
		234,
		75,
		238,
		121,
		109,
		107,
		204,
		33,
		240,
		114,
		122,
		144,
		221,
		1,
		67,
		141,
		242,
		227,
		88,
		197,
		180,
		176,
		43,
		27,
		19,
		193,
		125,
		5,
		39,
		104,
		203,
		213,
		119,
		77,
		41,
		143,
		91,
		68,
		76,
		22,
		233,
		198,
		136,
		111,
		244,
		172,
		28,
		95,
		134,
		229,
		82,
		56,
		124,
		69,
		205,
		50,
		45,
		236,
		54,
		101,
		182,
		126,
		53,
		153,
		207,
		103,
		250,
		42,
		127,
		255,
		253,
		110,
		160,
		65,
		169,
		177,
		11,
		3,
		200,
		166,
		63,
		186,
		254,
		9,
		116,
		239,
		48,
		185,
		217,
		192,
		181,
		175,
		248,
		72,
		46,
		12,
		184,
		96,
		55,
		154,
		117,
		145,
		44,
		168,
		128,
		173,
		73,
		99,
		199,
		158,
		62,
		85,
		252,
		201,
		171,
		170,
		156,
		106,
		15,
		4,
		89,
		155,
		231,
		149,
		135,
		61,
		152,
		118,
		20,
		64,
		191,
		60,
		224,
		167,
		71,
		148,
		31,
		81,
		47,
		215,
		34,
		105,
		51,
		127,
		25,
		40,
		110,
		179,
		207,
		230,
		99,
		111,
		100,
		123,
		221,
		119,
		115,
		234,
		183,
		186,
		204,
		181,
		216,
		106,
		188,
		132,
		101,
		209,
		154,
		210,
		232,
		95,
		65,
		226,
		233,
		253,
		189,
		44,
		13,
		41,
		192,
		105,
		62,
		139,
		229,
		175,
		212,
		239,
		39,
		46,
		250,
		152,
		10,
		31,
		109,
		170,
		63,
		243,
		219,
		59,
		223,
		28,
		130,
		29,
		142,
		0,
		171,
		206,
		35,
		74,
		156,
		55,
		251,
		49,
		2,
		52,
		155,
		17,
		184,
		66,
		118,
		3,
		33,
		166,
		211,
		114,
		215,
		64,
		84,
		82,
		245,
		24,
		201,
		75,
		67,
		169,
		228,
		56,
		103,
		26,
		225,
		93,
		176,
		135,
		36,
		72,
		227,
		178,
		247,
		200,
		157,
		43,
		85,
		91,
		57,
		194,
		174,
		164,
		202,
		235,
		231,
		8,
		151,
		88,
		187,
		73,
		237,
		32,
		133,
		138,
		37,
		102,
		191,
		220,
		107,
		1,
		69,
		124,
		244,
		11,
		20,
		213,
		15,
		92,
		143,
		71,
		12,
		160,
		246,
		94,
		195,
		19,
		70,
		198,
		196,
		87,
		153,
		120,
		144,
		136,
		50,
		58,
		122,
		180,
		203,
		218,
		97,
		252,
		141,
		137,
		18,
		34,
		42,
		248,
		68,
		60,
		30,
		81,
		242,
		236,
		78,
		116,
		16,
		182,
		98,
		125,
		117,
		47,
		208,
		255,
		177,
		86,
		205,
		149,
		7,
		108,
		197,
		240,
		146,
		147,
		165,
		83,
		54,
		61,
		96,
		162,
		222,
		172,
		190,
		4,
		161,
		79,
		45,
		121,
		134,
		5,
		217,
		158,
		126,
		173,
		38,
		104,
		22,
		238,
		27,
		80,
		241,
		159,
		6,
		131,
		199,
		48,
		77,
		214,
		9,
		128,
		224,
		249,
		140,
		150,
		193,
		113,
		23,
		53,
		129,
		89,
		14,
		163,
		76,
		168,
		21,
		145,
		185,
		148,
		112,
		90,
		254,
		167,
		227,
		24,
		116,
		126,
		16,
		49,
		61,
		210,
		77,
		130,
		97,
		147,
		55,
		250,
		95,
		80,
		189,
		192,
		59,
		135,
		106,
		93,
		254,
		146,
		57,
		104,
		45,
		18,
		71,
		241,
		143,
		129,
		251,
		124,
		9,
		168,
		13,
		154,
		142,
		136,
		47,
		194,
		19,
		145,
		153,
		115,
		62,
		226,
		113,
		20,
		249,
		144,
		70,
		237,
		33,
		235,
		216,
		238,
		65,
		203,
		98,
		152,
		172,
		217,
		32,
		66,
		208,
		197,
		183,
		112,
		229,
		41,
		1,
		225,
		5,
		198,
		88,
		199,
		84,
		218,
		51,
		39,
		103,
		246,
		215,
		243,
		26,
		179,
		228,
		81,
		63,
		117,
		14,
		53,
		253,
		244,
		109,
		96,
		22,
		111,
		2,
		176,
		102,
		94,
		191,
		11,
		64,
		8,
		50,
		133,
		155,
		56,
		233,
		165,
		195,
		242,
		180,
		105,
		21,
		60,
		185,
		181,
		190,
		161,
		7,
		173,
		169,
		48,
		205,
		239,
		91,
		131,
		212,
		121,
		150,
		114,
		207,
		75,
		99,
		78,
		170,
		128,
		36,
		125,
		43,
		69,
		220,
		89,
		29,
		234,
		151,
		12,
		211,
		90,
		58,
		35,
		86,
		76,
		27,
		171,
		123,
		149,
		247,
		163,
		92,
		223,
		3,
		68,
		164,
		119,
		252,
		178,
		204,
		52,
		193,
		138,
		221,
		182,
		31,
		42,
		72,
		73,
		127,
		137,
		236,
		231,
		186,
		120,
		4,
		118,
		100,
		222,
		40,
		54,
		148,
		174,
		202,
		108,
		184,
		167,
		175,
		245,
		10,
		37,
		107,
		140,
		23,
		79,
		160,
		110,
		17,
		0,
		187,
		38,
		87,
		83,
		200,
		248,
		240,
		34,
		158,
		230,
		196,
		139,
		214,
		122,
		44,
		132,
		25,
		201,
		156,
		28,
		30,
		141,
		67,
		162,
		74,
		82,
		232,
		224,
		255,
		188,
		101,
		6,
		177,
		219,
		159,
		166,
		46,
		209,
		206,
		15,
		213,
		134,
		85,
		157,
		56,
		90,
		191,
		170,
		10,
		205,
		83,
		159,
		155,
		123,
		188,
		127,
		189,
		34,
		160,
		46,
		93,
		73,
		140,
		29,
		137,
		173,
		201,
		96,
		43,
		158,
		15,
		69,
		79,
		116,
		142,
		135,
		26,
		23,
		21,
		108,
		202,
		120,
		36,
		28,
		113,
		197,
		114,
		58,
		255,
		72,
		66,
		225,
		223,
		147,
		136,
		185,
		19,
		206,
		70,
		111,
		207,
		195,
		219,
		196,
		215,
		125,
		74,
		211,
		98,
		153,
		4,
		14,
		75,
		106,
		168,
		71,
		248,
		55,
		233,
		27,
		128,
		77,
		42,
		37,
		186,
		199,
		253,
		65,
		39,
		16,
		232,
		132,
		18,
		67,
		104,
		87,
		139,
		61,
		251,
		245,
		6,
		129,
		210,
		115,
		224,
		119,
		242,
		244,
		184,
		85,
		235,
		105,
		9,
		227,
		152,
		68,
		110,
		11,
		234,
		131,
		151,
		60,
		145,
		91,
		148,
		162,
		177,
		59,
		226,
		24,
		163,
		214,
		76,
		82,
		212,
		238,
		22,
		176,
		221,
		194,
		143,
		213,
		95,
		112,
		246,
		17,
		53,
		109,
		20,
		218,
		122,
		107,
		92,
		193,
		41,
		45,
		130,
		178,
		88,
		138,
		156,
		228,
		241,
		190,
		0,
		172,
		254,
		86,
		179,
		99,
		102,
		230,
		247,
		100,
		216,
		57,
		40,
		48,
		154,
		146,
		198,
		133,
		124,
		31,
		161,
		203,
		220,
		229,
		171,
		84,
		117,
		180,
		252,
		175,
		231,
		47,
		149,
		183,
		249,
		33,
		3,
		174,
		8,
		236,
		49,
		181,
		52,
		25,
		250,
		208,
		7,
		94,
		63,
		81,
		35,
		166,
		144,
		103,
		118,
		237,
		32,
		169,
		89,
		64,
		54,
		44,
		209,
		97,
		239,
		1,
		217,
		141,
		165,
		38,
		62,
		121,
		13,
		222,
		200,
		134,
		78,
		182,
		240,
		187,
		204,
		167,
		80,
		101,
		51,
		50,
		243,
		5,
		157,
		150,
		2,
		192,
		12,
		126,
		164,
		30,
		209,
		109,
		150,
		235,
		196,
		168,
		11,
		60,
		68,
		123,
		62,
		111,
		215,
		217,
		167,
		17,
		40,
		34,
		78,
		181,
		132,
		107,
		103,
		70,
		197,
		55,
		212,
		27,
		6,
		9,
		172,
		97,
		198,
		175,
		66,
		39,
		189,
		119,
		187,
		16,
		157,
		23,
		184,
		142,
		143,
		250,
		206,
		52,
		254,
		95,
		42,
		173,
		222,
		216,
		204,
		91,
		199,
		69,
		148,
		121,
		180,
		104,
		37,
		207,
		160,
		49,
		113,
		101,
		229,
		76,
		165,
		129,
		35,
		105,
		7,
		178,
		162,
		171,
		99,
		88,
		147,
		134,
		20,
		118,
		127,
		179,
		38,
		225,
		144,
		83,
		183,
		87,
		140,
		2,
		145,
		14,
		164,
		149,
		243,
		191,
		106,
		67,
		63,
		226,
		247,
		232,
		227,
		239,
		102,
		255,
		251,
		81,
		57,
		64,
		54,
		59,
		8,
		48,
		230,
		84,
		94,
		22,
		93,
		233,
		110,
		205,
		211,
		100,
		15,
		138,
		19,
		125,
		90,
		193,
		188,
		75,
		117,
		108,
		12,
		133,
		253,
		77,
		26,
		0,
		213,
		13,
		185,
		155,
		36,
		192,
		47,
		130,
		24,
		53,
		29,
		153,
		43,
		114,
		214,
		252,
		124,
		73,
		224,
		139,
		223,
		41,
		31,
		30,
		46,
		236,
		177,
		186,
		136,
		50,
		32,
		82,
		245,
		161,
		195,
		45,
		18,
		85,
		137,
		10,
		228,
		170,
		33,
		242,
		220,
		151,
		98,
		154,
		86,
		71,
		56,
		246,
		5,
		1,
		112,
		237,
		116,
		166,
		174,
		158,
		221,
		146,
		176,
		200,
		248,
		194,
		96,
		126,
		241,
		238,
		58,
		156,
		115,
		92,
		163,
		249,
		25,
		65,
		218,
		61,
		80,
		51,
		234,
		169,
		240,
		201,
		141,
		231,
		89,
		152,
		135,
		120,
		203,
		3,
		208,
		131,
		210,
		122,
		44,
		128,
		74,
		202,
		159,
		79,
		244,
		21,
		219,
		72,
		182,
		190,
		4,
		28,
		142,
		144,
		22,
		44,
		212,
		114,
		31,
		0,
		77,
		23,
		157,
		178,
		52,
		211,
		247,
		175,
		214,
		24,
		184,
		169,
		158,
		3,
		235,
		239,
		64,
		112,
		154,
		72,
		94,
		38,
		51,
		124,
		194,
		110,
		60,
		148,
		113,
		161,
		164,
		36,
		53,
		166,
		26,
		251,
		234,
		242,
		88,
		80,
		4,
		71,
		190,
		221,
		99,
		9,
		30,
		39,
		105,
		150,
		183,
		118,
		62,
		109,
		37,
		237,
		87,
		117,
		59,
		227,
		193,
		108,
		202,
		46,
		243,
		119,
		246,
		219,
		56,
		18,
		197,
		156,
		253,
		147,
		225,
		100,
		82,
		165,
		180,
		47,
		226,
		107,
		155,
		130,
		244,
		238,
		19,
		163,
		45,
		195,
		27,
		79,
		103,
		228,
		252,
		187,
		207,
		28,
		10,
		68,
		140,
		116,
		50,
		121,
		14,
		101,
		146,
		167,
		241,
		240,
		49,
		199,
		95,
		84,
		192,
		2,
		206,
		188,
		102,
		220,
		250,
		152,
		125,
		104,
		200,
		15,
		145,
		93,
		89,
		185,
		126,
		189,
		127,
		224,
		98,
		236,
		159,
		139,
		78,
		223,
		75,
		111,
		11,
		162,
		233,
		92,
		205,
		135,
		141,
		182,
		76,
		69,
		216,
		213,
		215,
		174,
		8,
		186,
		230,
		222,
		179,
		7,
		176,
		248,
		61,
		138,
		128,
		35,
		29,
		81,
		74,
		123,
		209,
		12,
		132,
		173,
		13,
		1,
		25,
		6,
		21,
		191,
		136,
		17,
		160,
		91,
		198,
		204,
		137,
		168,
		106,
		133,
		58,
		245,
		43,
		217,
		66,
		143,
		232,
		231,
		120,
		5,
		63,
		131,
		229,
		210,
		42,
		70,
		208,
		129,
		170,
		149,
		73,
		255,
		57,
		55,
		196,
		67,
		16,
		177,
		34,
		181,
		48,
		54,
		122,
		151,
		41,
		171,
		203,
		33,
		90,
		134,
		172,
		201,
		40,
		65,
		85,
		254,
		83,
		153,
		86,
		96,
		115,
		249,
		32,
		218,
		97,
		20,
		23,
		2,
		144,
		242,
		251,
		55,
		162,
		101,
		20,
		215,
		51,
		211,
		8,
		134,
		21,
		138,
		36,
		181,
		245,
		225,
		97,
		200,
		33,
		5,
		167,
		237,
		131,
		54,
		38,
		47,
		231,
		220,
		189,
		196,
		178,
		191,
		140,
		180,
		98,
		208,
		218,
		146,
		217,
		109,
		234,
		73,
		87,
		224,
		32,
		17,
		119,
		59,
		238,
		199,
		187,
		102,
		115,
		108,
		103,
		107,
		226,
		123,
		127,
		213,
		172,
		166,
		202,
		49,
		0,
		239,
		227,
		194,
		65,
		179,
		80,
		159,
		130,
		141,
		40,
		229,
		85,
		233,
		18,
		111,
		64,
		44,
		143,
		184,
		192,
		255,
		186,
		235,
		83,
		93,
		35,
		149,
		122,
		219,
		174,
		41,
		90,
		92,
		72,
		223,
		67,
		193,
		16,
		253,
		48,
		236,
		161,
		75,
		66,
		43,
		198,
		163,
		57,
		243,
		63,
		148,
		25,
		147,
		60,
		10,
		11,
		126,
		74,
		176,
		124,
		70,
		228,
		250,
		117,
		106,
		190,
		24,
		247,
		216,
		39,
		125,
		157,
		197,
		94,
		185,
		210,
		195,
		188,
		114,
		129,
		133,
		244,
		105,
		240,
		34,
		42,
		26,
		89,
		22,
		52,
		76,
		86,
		254,
		168,
		4,
		206,
		78,
		27,
		203,
		112,
		145,
		95,
		204,
		50,
		58,
		128,
		152,
		212,
		183,
		110,
		45,
		116,
		77,
		9,
		99,
		221,
		28,
		3,
		252,
		79,
		135,
		84,
		7,
		81,
		137,
		61,
		31,
		160,
		68,
		171,
		6,
		156,
		177,
		153,
		29,
		175,
		246,
		82,
		120,
		139,
		14,
		151,
		249,
		222,
		69,
		56,
		207,
		241,
		232,
		136,
		1,
		121,
		201,
		158,
		132,
		113,
		37,
		71,
		169,
		150,
		209,
		13,
		142,
		96,
		46,
		165,
		118,
		88,
		19,
		230,
		30,
		248,
		205,
		100,
		15,
		91,
		173,
		155,
		154,
		170,
		104,
		53,
		62,
		12,
		182,
		164,
		214,
		49,
		144,
		229,
		98,
		17,
		23,
		3,
		148,
		8,
		138,
		91,
		182,
		123,
		167,
		234,
		0,
		9,
		96,
		141,
		232,
		114,
		184,
		116,
		223,
		82,
		216,
		119,
		65,
		64,
		53,
		1,
		251,
		231,
		237,
		129,
		122,
		75,
		164,
		168,
		137,
		10,
		248,
		27,
		212,
		201,
		198,
		99,
		174,
		30,
		162,
		89,
		36,
		11,
		103,
		196,
		243,
		139,
		180,
		241,
		160,
		24,
		22,
		104,
		222,
		246,
		143,
		249,
		244,
		199,
		255,
		41,
		155,
		145,
		217,
		146,
		38,
		161,
		2,
		28,
		171,
		107,
		90,
		60,
		112,
		165,
		140,
		240,
		45,
		56,
		39,
		44,
		32,
		169,
		48,
		52,
		158,
		92,
		73,
		219,
		185,
		176,
		124,
		233,
		46,
		95,
		156,
		120,
		152,
		67,
		205,
		94,
		193,
		111,
		254,
		190,
		170,
		42,
		131,
		106,
		78,
		236,
		166,
		200,
		125,
		109,
		100,
		172,
		151,
		58,
		110,
		12,
		226,
		221,
		154,
		70,
		197,
		43,
		101,
		238,
		61,
		19,
		88,
		173,
		85,
		179,
		134,
		47,
		68,
		16,
		230,
		208,
		209,
		225,
		35,
		126,
		117,
		71,
		253,
		239,
		157,
		26,
		194,
		118,
		84,
		235,
		15,
		224,
		77,
		215,
		250,
		210,
		86,
		228,
		189,
		25,
		51,
		192,
		69,
		220,
		178,
		149,
		14,
		115,
		132,
		186,
		163,
		195,
		74,
		50,
		130,
		213,
		207,
		29,
		181,
		227,
		79,
		133,
		5,
		80,
		128,
		59,
		218,
		20,
		135,
		121,
		113,
		203,
		211,
		159,
		252,
		37,
		102,
		63,
		6,
		66,
		40,
		150,
		87,
		72,
		183,
		4,
		204,
		31,
		76,
		55,
		13,
		175,
		177,
		62,
		33,
		245,
		83,
		188,
		147,
		108,
		54,
		214,
		142,
		21,
		242,
		153,
		136,
		247,
		57,
		202,
		206,
		191,
		34,
		187,
		105,
		97,
		81,
		18,
		93,
		127,
		7,
		28,
		35,
		102,
		55,
		143,
		129,
		255,
		73,
		137,
		53,
		206,
		179,
		156,
		240,
		83,
		100,
		157,
		111,
		140,
		67,
		94,
		81,
		244,
		57,
		112,
		122,
		22,
		237,
		220,
		51,
		63,
		30,
		197,
		79,
		224,
		214,
		215,
		162,
		150,
		108,
		158,
		247,
		26,
		127,
		229,
		47,
		227,
		72,
		159,
		29,
		204,
		33,
		236,
		48,
		125,
		151,
		166,
		7,
		114,
		245,
		134,
		128,
		148,
		3,
		123,
		49,
		95,
		234,
		250,
		243,
		59,
		0,
		248,
		105,
		41,
		61,
		189,
		20,
		253,
		217,
		200,
		11,
		239,
		15,
		212,
		90,
		201,
		86,
		203,
		222,
		76,
		46,
		39,
		235,
		126,
		185,
		175,
		176,
		187,
		183,
		62,
		167,
		163,
		9,
		252,
		205,
		171,
		231,
		50,
		27,
		103,
		186,
		6,
		78,
		5,
		177,
		54,
		149,
		139,
		60,
		97,
		24,
		110,
		99,
		80,
		104,
		190,
		12,
		45,
		52,
		84,
		221,
		165,
		21,
		66,
		88,
		87,
		210,
		75,
		37,
		2,
		153,
		228,
		19,
		64,
		109,
		69,
		193,
		115,
		42,
		142,
		164,
		141,
		85,
		225,
		195,
		124,
		152,
		119,
		218,
		118,
		180,
		233,
		226,
		208,
		106,
		120,
		10,
		36,
		17,
		184,
		211,
		135,
		113,
		71,
		70,
		188,
		242,
		121,
		170,
		132,
		207,
		58,
		194,
		173,
		249,
		155,
		117,
		74,
		13,
		209,
		82,
		44,
		254,
		246,
		198,
		133,
		202,
		232,
		144,
		14,
		31,
		96,
		174,
		93,
		89,
		40,
		181,
		43,
		4,
		251,
		161,
		65,
		25,
		130,
		101,
		160,
		154,
		56,
		38,
		169,
		182,
		98,
		196,
		1,
		192,
		223,
		32,
		147,
		91,
		136,
		219,
		8,
		107,
		178,
		241,
		168,
		145,
		213,
		191,
		172,
		77,
		131,
		16,
		238,
		230,
		92,
		68,
		138,
		34,
		116,
		216,
		18,
		146,
		199,
		23,
		101,
		162,
		55,
		251,
		242,
		144,
		2,
		23,
		138,
		21,
		134,
		8,
		211,
		51,
		215,
		20,
		5,
		33,
		200,
		97,
		225,
		245,
		181,
		36,
		220,
		231,
		47,
		38,
		54,
		131,
		237,
		167,
		208,
		98,
		180,
		140,
		191,
		178,
		196,
		189,
		224,
		87,
		73,
		234,
		109,
		217,
		146,
		218,
		102,
		187,
		199,
		238,
		59,
		119,
		17,
		32,
		213,
		127,
		123,
		226,
		107,
		103,
		108,
		115,
		194,
		227,
		239,
		0,
		49,
		202,
		166,
		172,
		229,
		40,
		141,
		130,
		159,
		80,
		179,
		65,
		184,
		143,
		44,
		64,
		111,
		18,
		233,
		85,
		149,
		35,
		93,
		83,
		235,
		186,
		255,
		192,
		223,
		72,
		92,
		90,
		41,
		174,
		219,
		122,
		75,
		161,
		236,
		48,
		253,
		16,
		193,
		67,
		148,
		63,
		243,
		57,
		163,
		198,
		43,
		66,
		176,
		74,
		126,
		11,
		10,
		60,
		147,
		25,
		24,
		190,
		106,
		117,
		250,
		228,
		70,
		124,
		185,
		94,
		197,
		157,
		125,
		39,
		216,
		247,
		105,
		244,
		133,
		129,
		114,
		188,
		195,
		210,
		76,
		52,
		22,
		89,
		26,
		42,
		34,
		240,
		203,
		27,
		78,
		206,
		4,
		168,
		254,
		86,
		152,
		128,
		58,
		50,
		204,
		95,
		145,
		112,
		99,
		9,
		77,
		116,
		45,
		110,
		183,
		212,
		7,
		84,
		135,
		79,
		252,
		3,
		28,
		221,
		6,
		171,
		68,
		160,
		31,
		61,
		137,
		81,
		120,
		82,
		246,
		175,
		29,
		153,
		177,
		156,
		207,
		56,
		69,
		222,
		249,
		151,
		14,
		139,
		132,
		158,
		201,
		121,
		1,
		136,
		232,
		241,
		142,
		13,
		209,
		150,
		169,
		71,
		37,
		113,
		30,
		230,
		19,
		88,
		118,
		165,
		46,
		96,
		154,
		155,
		173,
		91,
		15,
		100,
		205,
		248,
		214,
		164,
		182,
		12,
		62,
		53,
		104,
		170,
		82,
		209,
		201,
		142,
		24,
		246,
		46,
		122,
		185,
		65,
		7,
		76,
		250,
		41,
		63,
		113,
		196,
		197,
		4,
		242,
		59,
		80,
		167,
		146,
		251,
		137,
		83,
		233,
		106,
		97,
		245,
		55,
		244,
		89,
		255,
		27,
		98,
		64,
		14,
		214,
		13,
		39,
		240,
		169,
		198,
		66,
		195,
		238,
		103,
		144,
		129,
		26,
		200,
		166,
		212,
		81,
		193,
		219,
		38,
		150,
		215,
		94,
		174,
		183,
		68,
		148,
		145,
		17,
		247,
		91,
		9,
		161,
		223,
		199,
		109,
		101,
		0,
		147,
		47,
		206,
		86,
		60,
		43,
		18,
		49,
		114,
		139,
		232,
		11,
		88,
		16,
		216,
		92,
		163,
		130,
		67,
		225,
		71,
		42,
		53,
		187,
		165,
		35,
		25,
		1,
		230,
		194,
		154,
		120,
		34,
		168,
		135,
		171,
		54,
		222,
		218,
		227,
		45,
		141,
		156,
		107,
		19,
		6,
		73,
		117,
		69,
		175,
		125,
		23,
		128,
		5,
		3,
		241,
		118,
		37,
		132,
		254,
		20,
		111,
		179,
		79,
		162,
		28,
		158,
		96,
		203,
		102,
		172,
		153,
		252,
		29,
		116,
		21,
		239,
		84,
		33,
		99,
		85,
		70,
		204,
		188,
		157,
		95,
		176,
		149,
		110,
		243,
		249,
		119,
		186,
		221,
		210,
		15,
		192,
		30,
		236,
		208,
		231,
		31,
		115,
		77,
		48,
		10,
		182,
		124,
		202,
		12,
		2,
		229,
		180,
		159,
		160,
		61,
		143,
		211,
		235,
		237,
		224,
		226,
		155,
		8,
		191,
		181,
		22,
		134,
		50,
		133,
		205,
		228,
		57,
		177,
		152,
		40,
		100,
		127,
		78,
		32,
		138,
		189,
		36,
		56,
		52,
		44,
		51,
		253,
		58,
		164,
		104,
		207,
		173,
		72,
		93,
		74,
		213,
		87,
		217,
		108,
		140,
		75,
		136,
		126,
		90,
		62,
		151,
		170,
		190,
		123,
		234,
		184,
		131,
		121,
		112,
		220,
		105,
		248,
		178,
		13,
		213,
		155,
		185,
		192,
		36,
		130,
		47,
		53,
		24,
		153,
		29,
		114,
		43,
		252,
		214,
		138,
		15,
		125,
		19,
		193,
		90,
		75,
		188,
		108,
		117,
		133,
		12,
		77,
		253,
		0,
		26,
		161,
		245,
		45,
		195,
		85,
		18,
		10,
		137,
		170,
		228,
		242,
		33,
		151,
		220,
		154,
		98,
		73,
		124,
		139,
		224,
		41,
		223,
		30,
		31,
		236,
		46,
		186,
		177,
		50,
		136,
		82,
		32,
		194,
		248,
		126,
		96,
		238,
		241,
		156,
		58,
		92,
		115,
		249,
		163,
		65,
		25,
		61,
		218,
		71,
		86,
		246,
		56,
		1,
		5,
		237,
		112,
		166,
		116,
		158,
		174,
		146,
		221,
		200,
		176,
		122,
		210,
		128,
		44,
		202,
		74,
		79,
		159,
		21,
		244,
		72,
		219,
		190,
		182,
		28,
		4,
		51,
		80,
		169,
		234,
		201,
		240,
		231,
		141,
		152,
		89,
		120,
		135,
		3,
		203,
		131,
		208,
		34,
		40,
		181,
		78,
		107,
		132,
		70,
		103,
		55,
		197,
		27,
		212,
		9,
		6,
		97,
		172,
		109,
		209,
		235,
		150,
		168,
		196,
		60,
		11,
		123,
		68,
		111,
		62,
		217,
		215,
		17,
		167,
		95,
		254,
		173,
		42,
		216,
		222,
		91,
		204,
		69,
		199,
		121,
		148,
		104,
		180,
		207,
		37,
		175,
		198,
		39,
		66,
		119,
		189,
		16,
		187,
		23,
		157,
		142,
		184,
		250,
		143,
		52,
		206,
		134,
		147,
		118,
		20,
		179,
		127,
		225,
		38,
		83,
		144,
		87,
		183,
		2,
		140,
		14,
		145,
		49,
		160,
		101,
		113,
		76,
		229,
		129,
		165,
		105,
		35,
		178,
		7,
		171,
		162,
		88,
		99,
		64,
		57,
		59,
		54,
		48,
		8,
		84,
		230,
		22,
		94,
		233,
		93,
		205,
		110,
		100,
		211,
		149,
		164,
		191,
		243,
		67,
		106,
		226,
		63,
		232,
		247,
		239,
		227,
		255,
		102,
		81,
		251,
		1,
		238,
		226,
		195,
		173,
		167,
		203,
		48,
		131,
		140,
		41,
		228,
		64,
		178,
		81,
		158,
		65,
		45,
		142,
		185,
		84,
		232,
		19,
		110,
		82,
		92,
		34,
		148,
		193,
		254,
		187,
		234,
		91,
		93,
		73,
		222,
		123,
		218,
		175,
		40,
		49,
		237,
		160,
		74,
		66,
		192,
		17,
		252,
		56,
		242,
		62,
		149,
		67,
		42,
		199,
		162,
		10,
		127,
		75,
		177,
		24,
		146,
		61,
		11,
		250,
		54,
		163,
		100,
		22,
		3,
		145,
		243,
		9,
		135,
		20,
		139,
		21,
		214,
		50,
		210,
		96,
		201,
		32,
		4,
		37,
		180,
		244,
		224,
		39,
		46,
		230,
		221,
		166,
		236,
		130,
		55,
		141,
		181,
		99,
		209,
		188,
		197,
		179,
		190,
		235,
		72,
		86,
		225,
		219,
		147,
		216,
		108,
		239,
		198,
		186,
		103,
		33,
		16,
		118,
		58,
		227,
		122,
		126,
		212,
		114,
		109,
		102,
		106,
		161,
		69,
		170,
		7,
		80,
		136,
		60,
		30,
		174,
		247,
		83,
		121,
		157,
		176,
		152,
		28,
		223,
		68,
		57,
		206,
		138,
		15,
		150,
		248,
		120,
		200,
		159,
		133,
		240,
		233,
		137,
		0,
		151,
		208,
		12,
		143,
		112,
		36,
		70,
		168,
		89,
		18,
		231,
		31,
		97,
		47,
		164,
		119,
		90,
		172,
		154,
		155,
		249,
		204,
		101,
		14,
		13,
		183,
		165,
		215,
		171,
		105,
		52,
		63,
		116,
		107,
		191,
		25,
		125,
		71,
		229,
		251,
		156,
		196,
		95,
		184,
		246,
		217,
		38,
		124,
		128,
		132,
		245,
		104,
		211,
		194,
		189,
		115,
		88,
		23,
		53,
		77,
		241,
		35,
		43,
		27,
		207,
		79,
		26,
		202,
		87,
		255,
		169,
		5,
		51,
		59,
		129,
		153,
		113,
		144,
		94,
		205,
		117,
		76,
		8,
		98,
		213,
		182,
		111,
		44,
		78,
		134,
		85,
		6,
		220,
		29,
		2,
		253,
		3,
		135,
		175,
		130,
		102,
		76,
		232,
		177,
		1,
		35,
		151,
		79,
		24,
		181,
		90,
		190,
		31,
		150,
		246,
		239,
		154,
		128,
		215,
		103,
		231,
		137,
		16,
		149,
		209,
		38,
		91,
		192,
		104,
		187,
		48,
		126,
		0,
		248,
		13,
		70,
		183,
		89,
		59,
		111,
		144,
		19,
		207,
		136,
		32,
		43,
		118,
		180,
		200,
		186,
		168,
		18,
		17,
		122,
		211,
		230,
		132,
		133,
		179,
		69,
		99,
		57,
		198,
		233,
		167,
		64,
		219,
		131,
		228,
		250,
		88,
		98,
		6,
		160,
		116,
		107,
		4,
		52,
		60,
		238,
		82,
		42,
		8,
		71,
		108,
		162,
		221,
		204,
		119,
		234,
		155,
		159,
		210,
		65,
		143,
		110,
		134,
		158,
		36,
		44,
		26,
		182,
		224,
		72,
		213,
		5,
		80,
		208,
		226,
		29,
		2,
		195,
		25,
		74,
		153,
		81,
		51,
		112,
		169,
		202,
		125,
		23,
		83,
		106,
		129,
		78,
		173,
		95,
		251,
		54,
		147,
		156,
		47,
		212,
		184,
		178,
		220,
		253,
		241,
		30,
		245,
		164,
		225,
		222,
		139,
		61,
		67,
		77,
		113,
		12,
		247,
		75,
		166,
		145,
		50,
		94,
		227,
		14,
		223,
		93,
		85,
		191,
		242,
		46,
		55,
		176,
		197,
		100,
		193,
		86,
		66,
		68,
		20,
		34,
		141,
		7,
		174,
		84,
		96,
		21,
		189,
		216,
		53,
		92,
		138,
		33,
		237,
		39,
		205,
		45,
		201,
		10,
		148,
		11,
		152,
		22,
		236,
		142,
		28,
		9,
		123,
		188,
		41,
		229,
		40,
		157,
		243,
		185,
		194,
		249,
		49,
		56,
		255,
		235,
		171,
		58,
		27,
		63,
		214,
		127,
		115,
		199,
		140,
		196,
		254,
		73,
		87,
		244,
		161,
		172,
		218,
		163,
		206,
		124,
		170,
		146,
		117,
		121,
		114,
		109,
		203,
		97,
		101,
		252,
		37,
		105,
		15,
		62,
		120,
		165,
		217,
		240,
		72,
		66,
		223,
		36,
		1,
		238,
		44,
		13,
		93,
		175,
		113,
		190,
		99,
		108,
		11,
		198,
		7,
		187,
		129,
		252,
		194,
		174,
		86,
		97,
		17,
		46,
		5,
		84,
		179,
		189,
		123,
		205,
		53,
		148,
		199,
		64,
		178,
		180,
		49,
		166,
		47,
		173,
		19,
		254,
		2,
		222,
		165,
		79,
		197,
		172,
		77,
		40,
		29,
		215,
		122,
		209,
		125,
		247,
		228,
		210,
		144,
		229,
		94,
		164,
		236,
		249,
		28,
		126,
		217,
		21,
		139,
		76,
		57,
		250,
		61,
		221,
		104,
		230,
		100,
		251,
		91,
		202,
		15,
		27,
		38,
		143,
		235,
		207,
		3,
		73,
		216,
		109,
		193,
		200,
		50,
		9,
		42,
		83,
		81,
		92,
		90,
		98,
		62,
		140,
		124,
		52,
		131,
		55,
		167,
		4,
		14,
		185,
		255,
		206,
		213,
		153,
		41,
		0,
		136,
		85,
		130,
		157,
		133,
		137,
		149,
		12,
		59,
		145,
		103,
		191,
		241,
		211,
		170,
		78,
		232,
		69,
		95,
		114,
		243,
		119,
		24,
		65,
		150,
		188,
		224,
		101,
		23,
		121,
		171,
		48,
		33,
		214,
		6,
		31,
		239,
		102,
		39,
		151,
		106,
		112,
		203,
		159,
		71,
		169,
		63,
		120,
		96,
		227,
		192,
		142,
		152,
		75,
		253,
		182,
		240,
		8,
		35,
		22,
		225,
		138,
		67,
		181,
		116,
		117,
		134,
		68,
		208,
		219,
		88,
		226,
		56,
		74,
		168,
		146,
		20,
		10,
		132,
		155,
		246,
		80,
		54,
		25,
		147,
		201,
		43,
		115,
		87,
		176,
		45,
		60,
		156,
		82,
		107,
		111,
		135,
		26,
		204,
		30,
		244,
		196,
		248,
		183,
		162,
		218,
		16,
		184,
		234,
		70,
		160,
		32,
		37,
		245,
		127,
		158,
		34,
		177,
		212,
		220,
		118,
		110,
		89,
		58,
		195,
		128,
		163,
		154,
		141,
		231,
		242,
		51,
		18,
		237,
		105,
		161,
		233,
		186,
		117,
		122,
		223,
		18,
		182,
		68,
		167,
		104,
		247,
		24,
		20,
		53,
		91,
		81,
		61,
		198,
		164,
		170,
		212,
		98,
		55,
		8,
		77,
		28,
		183,
		219,
		120,
		79,
		162,
		30,
		229,
		152,
		199,
		27,
		86,
		188,
		180,
		54,
		231,
		10,
		173,
		171,
		191,
		40,
		141,
		44,
		89,
		222,
		252,
		137,
		189,
		71,
		238,
		100,
		203,
		253,
		206,
		4,
		200,
		99,
		181,
		220,
		49,
		84,
		255,
		113,
		226,
		125,
		227,
		32,
		196,
		36,
		12,
		192,
		85,
		146,
		224,
		245,
		103,
		5,
		209,
		216,
		16,
		43,
		80,
		26,
		116,
		193,
		150,
		63,
		214,
		242,
		211,
		66,
		2,
		22,
		29,
		190,
		160,
		23,
		45,
		101,
		46,
		154,
		123,
		67,
		149,
		39,
		74,
		51,
		69,
		72,
		21,
		140,
		136,
		34,
		132,
		155,
		144,
		156,
		25,
		48,
		76,
		145,
		215,
		230,
		128,
		204,
		88,
		1,
		165,
		143,
		107,
		70,
		110,
		234,
		87,
		179,
		92,
		241,
		166,
		126,
		202,
		232,
		142,
		62,
		105,
		115,
		6,
		31,
		127,
		246,
		41,
		178,
		207,
		56,
		124,
		249,
		96,
		14,
		175,
		228,
		17,
		233,
		151,
		217,
		82,
		129,
		97,
		38,
		250,
		121,
		134,
		210,
		176,
		94,
		251,
		65,
		83,
		33,
		93,
		159,
		194,
		201,
		172,
		90,
		108,
		109,
		15,
		58,
		147,
		248,
		106,
		50,
		169,
		78,
		0,
		47,
		208,
		138,
		130,
		157,
		73,
		239,
		139,
		177,
		19,
		13,
		174,
		225,
		195,
		187,
		7,
		213,
		221,
		237,
		118,
		114,
		3,
		158,
		37,
		52,
		75,
		133,
		197,
		205,
		119,
		111,
		135,
		102,
		168,
		59,
		57,
		185,
		236,
		60,
		161,
		9,
		95,
		243,
		184,
		112,
		163,
		240,
		42,
		235,
		244,
		11,
		131,
		186,
		254,
		148,
		35,
		64,
		153,
		218,
		201,
		177,
		164,
		235,
		215,
		231,
		13,
		223,
		9,
		148,
		124,
		120,
		65,
		143,
		47,
		62,
		163,
		68,
		96,
		56,
		218,
		128,
		10,
		37,
		67,
		229,
		136,
		151,
		25,
		7,
		129,
		187,
		169,
		250,
		178,
		122,
		254,
		1,
		32,
		225,
		244,
		158,
		137,
		176,
		147,
		208,
		41,
		74,
		125,
		101,
		207,
		199,
		162,
		49,
		141,
		108,
		230,
		54,
		51,
		179,
		85,
		249,
		171,
		3,
		99,
		121,
		132,
		52,
		117,
		252,
		12,
		21,
		197,
		50,
		35,
		184,
		106,
		4,
		118,
		243,
		175,
		133,
		82,
		11,
		100,
		224,
		97,
		76,
		86,
		251,
		93,
		185,
		192,
		226,
		172,
		116,
		89,
		43,
		241,
		75,
		200,
		195,
		87,
		149,
		102,
		103,
		166,
		80,
		153,
		242,
		5,
		48,
		27,
		227,
		165,
		238,
		88,
		139,
		157,
		211,
		240,
		115,
		107,
		44,
		186,
		84,
		140,
		216,
		26,
		33,
		219,
		210,
		126,
		203,
		90,
		16,
		220,
		248,
		156,
		53,
		8,
		28,
		217,
		72,
		232,
		119,
		245,
		123,
		206,
		46,
		233,
		42,
		95,
		152,
		6,
		202,
		109,
		15,
		234,
		255,
		130,
		40,
		31,
		134,
		154,
		150,
		142,
		145,
		70,
		155,
		19,
		58,
		138,
		198,
		221,
		236,
		170,
		29,
		23,
		180,
		36,
		144,
		39,
		111,
		159,
		45,
		113,
		73,
		79,
		66,
		64,
		57,
		222,
		104,
		174,
		160,
		71,
		22,
		61,
		2,
		114,
		69,
		189,
		209,
		239,
		146,
		168,
		20,
		213,
		24,
		127,
		112,
		173,
		98,
		188,
		78,
		30,
		63,
		253,
		18,
		55,
		204,
		81,
		91,
		183,
		77,
		246,
		131,
		193,
		247,
		228,
		110,
		194,
		105,
		196,
		14,
		59,
		94,
		191,
		214,
		92,
		182,
		205,
		17,
		237,
		0,
		190,
		60,
		181,
		34,
		167,
		161,
		83,
		212,
		135,
		38,
		232,
		58,
		50,
		2,
		65,
		14,
		44,
		84,
		202,
		219,
		164,
		106,
		153,
		157,
		236,
		113,
		239,
		192,
		63,
		101,
		133,
		221,
		70,
		161,
		100,
		94,
		252,
		226,
		109,
		114,
		166,
		0,
		197,
		4,
		27,
		228,
		87,
		159,
		76,
		31,
		204,
		175,
		118,
		53,
		108,
		85,
		17,
		123,
		104,
		137,
		71,
		212,
		42,
		34,
		152,
		128,
		78,
		230,
		176,
		28,
		214,
		86,
		3,
		211,
		233,
		240,
		144,
		25,
		97,
		209,
		134,
		156,
		147,
		22,
		143,
		225,
		198,
		93,
		32,
		215,
		132,
		169,
		129,
		5,
		183,
		238,
		74,
		96,
		73,
		145,
		37,
		7,
		184,
		92,
		179,
		30,
		178,
		112,
		45,
		38,
		20,
		174,
		188,
		206,
		224,
		213,
		124,
		23,
		67,
		181,
		131,
		130,
		120,
		54,
		189,
		110,
		64,
		11,
		254,
		6,
		105,
		61,
		95,
		177,
		142,
		201,
		21,
		150,
		191,
		245,
		155,
		46,
		62,
		55,
		255,
		196,
		60,
		173,
		237,
		249,
		121,
		208,
		57,
		29,
		12,
		207,
		43,
		203,
		16,
		158,
		13,
		146,
		15,
		26,
		136,
		234,
		227,
		47,
		186,
		125,
		107,
		116,
		127,
		115,
		250,
		99,
		103,
		205,
		56,
		9,
		111,
		35,
		246,
		223,
		163,
		126,
		194,
		138,
		193,
		117,
		242,
		81,
		79,
		248,
		165,
		220,
		170,
		167,
		148,
		172,
		122,
		200,
		216,
		231,
		162,
		243,
		75,
		69,
		59,
		141,
		77,
		241,
		10,
		119,
		88,
		52,
		151,
		160,
		89,
		171,
		72,
		135,
		154,
		149,
		48,
		253,
		180,
		190,
		210,
		41,
		24,
		247,
		251,
		218,
		1,
		139,
		36,
		18,
		19,
		102,
		82,
		168,
		90,
		51,
		222,
		187,
		33,
		235,
		39,
		140,
		91,
		217,
		8,
		229,
		40,
		244,
		185,
		83,
		98,
		195,
		182,
		49,
		66,
		68,
		80,
		199,
		189,
		215,
		147,
		170,
		243,
		176,
		105,
		10,
		217,
		138,
		89,
		145,
		34,
		221,
		194,
		3,
		21,
		197,
		144,
		16,
		218,
		118,
		32,
		136,
		70,
		94,
		228,
		236,
		18,
		129,
		79,
		174,
		183,
		42,
		91,
		95,
		172,
		98,
		29,
		12,
		146,
		234,
		200,
		135,
		196,
		244,
		252,
		46,
		198,
		96,
		180,
		171,
		36,
		58,
		152,
		162,
		103,
		128,
		27,
		67,
		163,
		249,
		6,
		41,
		68,
		69,
		115,
		133,
		209,
		186,
		19,
		38,
		8,
		122,
		104,
		210,
		224,
		235,
		182,
		116,
		80,
		211,
		15,
		72,
		119,
		153,
		251,
		175,
		192,
		56,
		205,
		134,
		168,
		123,
		240,
		190,
		17,
		230,
		155,
		0,
		39,
		73,
		208,
		85,
		90,
		64,
		23,
		167,
		223,
		86,
		54,
		47,
		216,
		117,
		154,
		126,
		193,
		227,
		87,
		143,
		166,
		140,
		40,
		113,
		195,
		71,
		111,
		66,
		184,
		101,
		25,
		48,
		229,
		169,
		207,
		254,
		11,
		161,
		165,
		60,
		181,
		185,
		178,
		173,
		14,
		188,
		106,
		82,
		97,
		108,
		26,
		99,
		62,
		137,
		151,
		52,
		179,
		7,
		76,
		4,
		219,
		255,
		22,
		191,
		63,
		43,
		107,
		250,
		2,
		57,
		241,
		248,
		232,
		93,
		51,
		121,
		187,
		124,
		233,
		37,
		44,
		78,
		220,
		201,
		84,
		203,
		88,
		214,
		13,
		237,
		9,
		202,
		74,
		225,
		45,
		231,
		125,
		24,
		245,
		156,
		110,
		148,
		160,
		213,
		212,
		226,
		77,
		199,
		1,
		150,
		130,
		132,
		247,
		112,
		5,
		164,
		149,
		127,
		50,
		238,
		35,
		206,
		31,
		157,
		102,
		81,
		242,
		158,
		177,
		204,
		55,
		139,
		75,
		253,
		131,
		141,
		53,
		100,
		33,
		30,
		28,
		61,
		49,
		222,
		239,
		20,
		120,
		114,
		59,
		246,
		83,
		92,
		65,
		142,
		109,
		159,
		160,
		114,
		122,
		74,
		9,
		70,
		100,
		28,
		130,
		147,
		236,
		34,
		209,
		213,
		164,
		57,
		167,
		136,
		119,
		45,
		205,
		149,
		14,
		233,
		44,
		22,
		180,
		170,
		37,
		58,
		238,
		72,
		141,
		76,
		83,
		172,
		31,
		215,
		4,
		87,
		132,
		231,
		62,
		125,
		36,
		29,
		89,
		51,
		32,
		193,
		15,
		156,
		98,
		106,
		208,
		200,
		6,
		174,
		248,
		84,
		158,
		30,
		75,
		155,
		161,
		184,
		216,
		81,
		41,
		153,
		206,
		212,
		219,
		94,
		199,
		169,
		142,
		21,
		104,
		159,
		204,
		225,
		201,
		77,
		255,
		166,
		2,
		40,
		1,
		217,
		109,
		79,
		240,
		20,
		251,
		86,
		250,
		56,
		101,
		110,
		92,
		230,
		244,
		134,
		168,
		157,
		52,
		95,
		11,
		253,
		203,
		202,
		48,
		126,
		245,
		38,
		8,
		67,
		182,
		78,
		33,
		117,
		23,
		249,
		198,
		129,
		93,
		222,
		247,
		189,
		211,
		102,
		118,
		127,
		183,
		140,
		116,
		229,
		165,
		177,
		49,
		152,
		113,
		85,
		68,
		135,
		99,
		131,
		88,
		214,
		69,
		218,
		71,
		82,
		192,
		162,
		171,
		103,
		242,
		53,
		35,
		60,
		55,
		59,
		178,
		43,
		47,
		133,
		112,
		65,
		39,
		107,
		190,
		151,
		235,
		54,
		138,
		194,
		137,
		61,
		186,
		25,
		7,
		176,
		237,
		148,
		226,
		239,
		220,
		228,
		50,
		128,
		144,
		175,
		234,
		187,
		3,
		13,
		115,
		197,
		5,
		185,
		66,
		63,
		16,
		124,
		223,
		232,
		17,
		227,
		0,
		207,
		210,
		221,
		120,
		181,
		252,
		246,
		154,
		97,
		80,
		191,
		179,
		146,
		73,
		195,
		108,
		90,
		91,
		46,
		26,
		224,
		18,
		123,
		150,
		243,
		105,
		163,
		111,
		196,
		19,
		145,
		64,
		173,
		96,
		188,
		241,
		27,
		42,
		139,
		254,
		121,
		10,
		12,
		24,
		143,
		65,
		179,
		109,
		162,
		127,
		112,
		23,
		218,
		84,
		94,
		195,
		56,
		29,
		242,
		48,
		17,
		13,
		50,
		25,
		72,
		175,
		161,
		103,
		209,
		27,
		167,
		157,
		224,
		222,
		178,
		74,
		125,
		51,
		177,
		15,
		226,
		30,
		194,
		185,
		83,
		41,
		136,
		219,
		92,
		174,
		168,
		45,
		186,
		97,
		235,
		248,
		206,
		140,
		249,
		66,
		184,
		217,
		176,
		81,
		52,
		1,
		203,
		102,
		205,
		37,
		230,
		33,
		193,
		116,
		250,
		120,
		231,
		240,
		229,
		0,
		98,
		197,
		9,
		151,
		80,
		31,
		85,
		196,
		113,
		221,
		212,
		46,
		21,
		71,
		214,
		19,
		7,
		58,
		147,
		247,
		211,
		96,
		40,
		159,
		43,
		187,
		24,
		18,
		165,
		54,
		79,
		77,
		64,
		70,
		126,
		34,
		144,
		158,
		129,
		153,
		149,
		137,
		16,
		39,
		141,
		227,
		210,
		201,
		133,
		53,
		28,
		148,
		73,
		67,
		110,
		239,
		107,
		4,
		93,
		138,
		160,
		123,
		163,
		237,
		207,
		182,
		82,
		244,
		89,
		26,
		3,
		243,
		122,
		59,
		139,
		118,
		108,
		252,
		121,
		11,
		101,
		183,
		44,
		61,
		202,
		220,
		146,
		132,
		87,
		225,
		170,
		236,
		20,
		215,
		131,
		91,
		181,
		35,
		100,
		124,
		255,
		154,
		88,
		204,
		199,
		68,
		254,
		36,
		86,
		63,
		10,
		253,
		150,
		95,
		169,
		104,
		105,
		42,
		5,
		143,
		213,
		55,
		111,
		75,
		172,
		180,
		142,
		8,
		22,
		152,
		135,
		234,
		76,
		208,
		2,
		232,
		216,
		228,
		171,
		190,
		198,
		49,
		32,
		128,
		78,
		119,
		115,
		155,
		6,
		99,
		130,
		62,
		173,
		200,
		192,
		106,
		114,
		12,
		164,
		246,
		90,
		188,
		60,
		57,
		233,
		238,
		47,
		14,
		241,
		117,
		189,
		245,
		166,
		69,
		38,
		223,
		156,
		191,
		134,
		145,
		251,
		150,
		216,
		206,
		29,
		171,
		224,
		166,
		94,
		157,
		201,
		17,
		255,
		105,
		46,
		54,
		181,
		208,
		18,
		134,
		141,
		14,
		180,
		110,
		28,
		117,
		64,
		183,
		220,
		21,
		227,
		34,
		35,
		9,
		36,
		165,
		33,
		78,
		23,
		192,
		234,
		49,
		233,
		167,
		133,
		252,
		24,
		190,
		19,
		80,
		73,
		185,
		48,
		113,
		193,
		60,
		38,
		182,
		51,
		65,
		47,
		253,
		102,
		119,
		128,
		41,
		200,
		116,
		231,
		130,
		138,
		32,
		56,
		70,
		238,
		188,
		16,
		246,
		118,
		115,
		163,
		164,
		101,
		68,
		187,
		63,
		247,
		191,
		236,
		15,
		108,
		149,
		214,
		245,
		204,
		219,
		177,
		96,
		79,
		197,
		159,
		125,
		37,
		1,
		230,
		254,
		196,
		66,
		92,
		210,
		205,
		160,
		6,
		154,
		72,
		162,
		146,
		174,
		225,
		244,
		140,
		123,
		106,
		202,
		4,
		61,
		57,
		209,
		76,
		121,
		251,
		69,
		168,
		84,
		136,
		243,
		25,
		99,
		194,
		145,
		22,
		228,
		226,
		103,
		240,
		43,
		161,
		178,
		132,
		198,
		179,
		8,
		242,
		147,
		250,
		27,
		126,
		75,
		129,
		44,
		135,
		11,
		249,
		39,
		232,
		53,
		58,
		93,
		144,
		30,
		20,
		137,
		114,
		87,
		184,
		122,
		91,
		71,
		120,
		83,
		2,
		229,
		235,
		45,
		155,
		81,
		237,
		215,
		170,
		148,
		248,
		0,
		55,
		42,
		98,
		213,
		97,
		241,
		82,
		88,
		239,
		124,
		5,
		7,
		10,
		12,
		52,
		104,
		218,
		212,
		203,
		211,
		223,
		195,
		90,
		109,
		199,
		169,
		152,
		131,
		207,
		127,
		86,
		222,
		3,
		111,
		172,
		107,
		139,
		62,
		176,
		50,
		173,
		186,
		175,
		74,
		40,
		143,
		67,
		221,
		26,
		85,
		31,
		142,
		59,
		151,
		158,
		100,
		95,
		13,
		156,
		89,
		77,
		112,
		217,
		189,
		153,
		69,
		233,
		191,
		23,
		138,
		90,
		15,
		143,
		141,
		30,
		208,
		49,
		217,
		193,
		123,
		115,
		108,
		47,
		246,
		149,
		34,
		72,
		12,
		53,
		189,
		66,
		93,
		156,
		70,
		21,
		198,
		14,
		187,
		165,
		7,
		61,
		89,
		255,
		43,
		52,
		60,
		102,
		153,
		182,
		248,
		31,
		132,
		220,
		51,
		253,
		130,
		147,
		40,
		181,
		196,
		192,
		91,
		107,
		99,
		177,
		13,
		117,
		87,
		24,
		232,
		6,
		100,
		48,
		207,
		76,
		144,
		215,
		55,
		228,
		111,
		33,
		95,
		167,
		82,
		25,
		78,
		37,
		140,
		185,
		219,
		218,
		236,
		26,
		127,
		116,
		41,
		235,
		151,
		229,
		247,
		77,
		94,
		124,
		200,
		16,
		71,
		234,
		5,
		225,
		92,
		216,
		240,
		221,
		57,
		19,
		183,
		238,
		184,
		214,
		79,
		202,
		142,
		121,
		4,
		159,
		64,
		201,
		169,
		176,
		197,
		223,
		136,
		56,
		254,
		243,
		133,
		252,
		145,
		35,
		245,
		205,
		44,
		152,
		211,
		155,
		161,
		22,
		8,
		171,
		122,
		54,
		80,
		97,
		39,
		250,
		134,
		175,
		42,
		38,
		45,
		50,
		148,
		62,
		58,
		163,
		179,
		209,
		67,
		86,
		36,
		227,
		118,
		186,
		146,
		114,
		150,
		85,
		203,
		84,
		199,
		73,
		160,
		180,
		244,
		101,
		68,
		96,
		137,
		32,
		119,
		194,
		172,
		230,
		157,
		166,
		110,
		103,
		104,
		239,
		154,
		59,
		158,
		9,
		29,
		27,
		188,
		81,
		128,
		2,
		10,
		224,
		173,
		113,
		226,
		135,
		106,
		3,
		213,
		126,
		178,
		120,
		75,
		125,
		210,
		88,
		241,
		11,
		63,
		74,
		112,
		139,
		231,
		237,
		131,
		162,
		174,
		65,
		222,
		17,
		242,
		0,
		164,
		105,
		204,
		195,
		46,
		83,
		168,
		20,
		249,
		206,
		109,
		1,
		170,
		251,
		190,
		129,
		212,
		98,
		28,
		18,
		95,
		196,
		185,
		78,
		10,
		143,
		22,
		120,
		248,
		72,
		31,
		5,
		112,
		105,
		9,
		128,
		33,
		197,
		42,
		135,
		208,
		8,
		188,
		158,
		46,
		119,
		211,
		249,
		29,
		48,
		24,
		156,
		218,
		44,
		26,
		27,
		121,
		76,
		229,
		142,
		141,
		55,
		37,
		87,
		43,
		233,
		180,
		191,
		23,
		80,
		140,
		15,
		240,
		164,
		198,
		40,
		217,
		146,
		103,
		159,
		225,
		175,
		36,
		247,
		0,
		4,
		117,
		232,
		83,
		66,
		61,
		243,
		216,
		151,
		181,
		205,
		113,
		163,
		171,
		155,
		244,
		235,
		63,
		153,
		253,
		199,
		101,
		123,
		28,
		68,
		223,
		56,
		118,
		89,
		166,
		252,
		245,
		204,
		136,
		226,
		85,
		54,
		239,
		172,
		206,
		6,
		213,
		134,
		92,
		157,
		130,
		125,
		79,
		207,
		154,
		74,
		215,
		127,
		41,
		133,
		179,
		187,
		1,
		25,
		241,
		16,
		222,
		77,
		193,
		173,
		14,
		57,
		212,
		104,
		147,
		238,
		210,
		220,
		162,
		20,
		65,
		126,
		59,
		106,
		129,
		110,
		98,
		67,
		45,
		39,
		75,
		176,
		3,
		12,
		169,
		100,
		192,
		50,
		209,
		30,
		184,
		114,
		190,
		21,
		195,
		170,
		71,
		34,
		138,
		255,
		203,
		49,
		152,
		18,
		189,
		139,
		219,
		221,
		201,
		94,
		251,
		90,
		47,
		168,
		177,
		109,
		32,
		202,
		194,
		64,
		145,
		124,
		224,
		73,
		160,
		132,
		165,
		52,
		116,
		96,
		167,
		174,
		102,
		93,
		38,
		108,
		2,
		183,
		122,
		182,
		35,
		228,
		150,
		131,
		17,
		115,
		137,
		7,
		148,
		11,
		149,
		86,
		178,
		82,
		111,
		70,
		58,
		231,
		161,
		144,
		246,
		186,
		99,
		250,
		254,
		84,
		242,
		237,
		230,
		234,
		13,
		53,
		227,
		81,
		60,
		69,
		51,
		62,
		107,
		200,
		214,
		97,
		91,
		19,
		88,
		236,
		31,
		159,
		154,
		74,
		175,
		7,
		85,
		249,
		107,
		99,
		201,
		209,
		192,
		33,
		157,
		14,
		28,
		37,
		50,
		88,
		230,
		133,
		124,
		63,
		214,
		30,
		86,
		5,
		77,
		140,
		173,
		82,
		59,
		36,
		73,
		239,
		23,
		45,
		171,
		181,
		148,
		204,
		232,
		15,
		137,
		166,
		44,
		118,
		212,
		208,
		56,
		165,
		146,
		131,
		35,
		237,
		71,
		8,
		29,
		101,
		115,
		161,
		75,
		123,
		128,
		199,
		223,
		92,
		116,
		32,
		248,
		22,
		66,
		9,
		79,
		183,
		127,
		49,
		39,
		244,
		252,
		10,
		203,
		202,
		156,
		169,
		94,
		53,
		231,
		93,
		135,
		245,
		57,
		251,
		111,
		100,
		21,
		241,
		87,
		250,
		216,
		0,
		78,
		108,
		167,
		254,
		41,
		3,
		224,
		205,
		76,
		200,
		20,
		143,
		158,
		105,
		95,
		218,
		168,
		198,
		152,
		40,
		213,
		207,
		185,
		160,
		80,
		217,
		229,
		221,
		129,
		51,
		149,
		236,
		238,
		227,
		24,
		187,
		177,
		6,
		195,
		139,
		60,
		136,
		150,
		191,
		55,
		234,
		64,
		113,
		106,
		38,
		42,
		179,
		132,
		46,
		61,
		34,
		58,
		54,
		102,
		170,
		52,
		243,
		83,
		70,
		163,
		193,
		215,
		89,
		219,
		68,
		134,
		69,
		130,
		98,
		153,
		48,
		84,
		112,
		228,
		117,
		176,
		164,
		126,
		119,
		141,
		182,
		188,
		246,
		103,
		210,
		13,
		11,
		142,
		25,
		138,
		43,
		120,
		255,
		189,
		97,
		26,
		240,
		144,
		18,
		172,
		65,
		162,
		104,
		197,
		110,
		122,
		19,
		242,
		151,
		47,
		90,
		225,
		27,
		194,
		72,
		91,
		109,
		190,
		81,
		147,
		178,
		247,
		253,
		96,
		155,
		220,
		211,
		180,
		121,
		226,
		16,
		206,
		1,
		125,
		17,
		233,
		222,
		184,
		4,
		62,
		67,
		12,
		2,
		196,
		114,
		174,
		145,
		186,
		235,
		247,
		248,
		93,
		144,
		52,
		198,
		37,
		234,
		117,
		154,
		150,
		183,
		217,
		211,
		191,
		68,
		38,
		40,
		86,
		224,
		181,
		138,
		207,
		158,
		53,
		89,
		250,
		205,
		32,
		156,
		103,
		26,
		69,
		153,
		212,
		62,
		54,
		180,
		101,
		136,
		47,
		41,
		61,
		170,
		15,
		174,
		219,
		92,
		126,
		11,
		63,
		197,
		108,
		230,
		73,
		127,
		76,
		134,
		74,
		225,
		55,
		94,
		179,
		214,
		125,
		243,
		96,
		255,
		97,
		162,
		70,
		166,
		142,
		66,
		215,
		16,
		98,
		119,
		229,
		135,
		83,
		90,
		146,
		169,
		210,
		152,
		246,
		67,
		20,
		189,
		84,
		112,
		81,
		192,
		128,
		148,
		159,
		60,
		34,
		149,
		175,
		231,
		172,
		24,
		249,
		193,
		23,
		165,
		200,
		177,
		199,
		202,
		151,
		14,
		10,
		160,
		6,
		25,
		18,
		30,
		155,
		178,
		206,
		19,
		85,
		100,
		2,
		78,
		218,
		131,
		39,
		13,
		233,
		196,
		236,
		104,
		213,
		49,
		222,
		115,
		36,
		252,
		72,
		106,
		12,
		188,
		235,
		241,
		132,
		157,
		253,
		116,
		171,
		48,
		77,
		186,
		254,
		123,
		226,
		140,
		45,
		102,
		147,
		107,
		21,
		91,
		208,
		3,
		227,
		164,
		120,
		251,
		4,
		80,
		50,
		220,
		121,
		195,
		209,
		163,
		223,
		29,
		64,
		75,
		46,
		216,
		238,
		239,
		141,
		184,
		17,
		122,
		232,
		176,
		43,
		204,
		130,
		173,
		82,
		8,
		0,
		31,
		203,
		109,
		9,
		51,
		145,
		143,
		44,
		99,
		65,
		57,
		133,
		87,
		95,
		111,
		244,
		240,
		129,
		28,
		167,
		182,
		201,
		7,
		71,
		79,
		245,
		237,
		5,
		228,
		42,
		185,
		187,
		59,
		110,
		190,
		35,
		139,
		221,
		113,
		58,
		242,
		33,
		114,
		168,
		105,
		118,
		137,
		1,
		56,
		124,
		22,
		161,
		194,
		27,
		88,
		183,
		244,
		45,
		78,
		249,
		147,
		215,
		238,
		102,
		153,
		134,
		71,
		157,
		206,
		29,
		213,
		158,
		50,
		100,
		204,
		81,
		129,
		212,
		84,
		86,
		197,
		11,
		234,
		2,
		26,
		160,
		168,
		232,
		38,
		89,
		72,
		243,
		110,
		31,
		27,
		128,
		176,
		184,
		106,
		214,
		174,
		140,
		195,
		96,
		126,
		220,
		230,
		130,
		36,
		240,
		239,
		231,
		189,
		66,
		109,
		35,
		196,
		95,
		7,
		149,
		254,
		87,
		98,
		0,
		1,
		55,
		193,
		164,
		175,
		242,
		48,
		76,
		62,
		44,
		150,
		51,
		221,
		191,
		235,
		20,
		151,
		75,
		12,
		236,
		63,
		180,
		250,
		132,
		124,
		137,
		194,
		99,
		13,
		148,
		17,
		85,
		162,
		223,
		68,
		155,
		18,
		114,
		107,
		30,
		4,
		83,
		227,
		133,
		167,
		19,
		203,
		156,
		49,
		222,
		58,
		135,
		3,
		43,
		6,
		226,
		200,
		108,
		53,
		161,
		237,
		139,
		186,
		252,
		33,
		93,
		116,
		241,
		253,
		246,
		233,
		79,
		229,
		225,
		120,
		37,
		40,
		94,
		39,
		74,
		248,
		46,
		22,
		247,
		67,
		8,
		64,
		122,
		205,
		211,
		112,
		123,
		111,
		47,
		190,
		159,
		187,
		82,
		251,
		172,
		25,
		119,
		61,
		70,
		125,
		181,
		188,
		104,
		10,
		152,
		141,
		255,
		56,
		173,
		97,
		73,
		169,
		77,
		142,
		16,
		143,
		28,
		146,
		57,
		92,
		177,
		216,
		14,
		165,
		105,
		163,
		144,
		166,
		9,
		131,
		42,
		208,
		228,
		145,
		179,
		52,
		65,
		224,
		69,
		210,
		198,
		192,
		103,
		138,
		91,
		217,
		209,
		59,
		118,
		170,
		245,
		136,
		115,
		207,
		34,
		21,
		182,
		218,
		113,
		32,
		101,
		90,
		15,
		185,
		199,
		201,
		171,
		80,
		60,
		54,
		88,
		121,
		117,
		154,
		5,
		202,
		41,
		219,
		127,
		178,
		23,
		24,
		34,
		138,
		216,
		116,
		146,
		18,
		23,
		199,
		77,
		172,
		16,
		131,
		230,
		238,
		68,
		92,
		107,
		8,
		241,
		178,
		145,
		168,
		191,
		213,
		192,
		1,
		32,
		223,
		91,
		147,
		219,
		136,
		154,
		160,
		38,
		56,
		182,
		169,
		196,
		98,
		4,
		43,
		161,
		251,
		25,
		65,
		101,
		130,
		31,
		14,
		174,
		96,
		89,
		93,
		181,
		40,
		254,
		44,
		198,
		246,
		202,
		133,
		144,
		232,
		249,
		173,
		117,
		155,
		13,
		74,
		82,
		209,
		242,
		188,
		170,
		121,
		207,
		132,
		194,
		58,
		17,
		36,
		211,
		184,
		113,
		135,
		70,
		71,
		180,
		118,
		226,
		233,
		106,
		208,
		10,
		120,
		85,
		141,
		195,
		225,
		152,
		124,
		218,
		119,
		109,
		64,
		193,
		69,
		42,
		115,
		164,
		142,
		210,
		87,
		37,
		75,
		153,
		2,
		19,
		228,
		52,
		45,
		221,
		84,
		21,
		165,
		88,
		66,
		24,
		97,
		99,
		110,
		104,
		80,
		12,
		190,
		78,
		6,
		177,
		5,
		149,
		54,
		60,
		139,
		205,
		252,
		231,
		171,
		27,
		50,
		186,
		103,
		176,
		175,
		183,
		187,
		167,
		62,
		9,
		163,
		222,
		203,
		46,
		76,
		235,
		39,
		185,
		126,
		11,
		200,
		15,
		239,
		90,
		212,
		86,
		201,
		105,
		248,
		61,
		41,
		20,
		189,
		217,
		253,
		49,
		123,
		234,
		95,
		243,
		250,
		0,
		59,
		7,
		166,
		245,
		114,
		128,
		134,
		3,
		148,
		29,
		159,
		33,
		204,
		48,
		236,
		151,
		125,
		247,
		158,
		127,
		26,
		47,
		229,
		72,
		227,
		79,
		197,
		214,
		224,
		162,
		215,
		108,
		150,
		122,
		112,
		237,
		22,
		51,
		220,
		30,
		63,
		111,
		157,
		67,
		140,
		81,
		94,
		57,
		244,
		53,
		137,
		179,
		206,
		240,
		156,
		100,
		83,
		35,
		28,
		55,
		102,
		129,
		143,
		73,
		255,
		74,
		160,
		219,
		7,
		251,
		22,
		168,
		42,
		163,
		52,
		177,
		183,
		69,
		194,
		145,
		48,
		161,
		91,
		224,
		149,
		215,
		225,
		242,
		120,
		212,
		127,
		210,
		24,
		45,
		72,
		169,
		192,
		195,
		14,
		105,
		102,
		187,
		116,
		170,
		88,
		8,
		41,
		235,
		4,
		33,
		218,
		71,
		77,
		200,
		126,
		184,
		182,
		81,
		0,
		43,
		20,
		100,
		83,
		171,
		199,
		249,
		132,
		190,
		2,
		188,
		11,
		1,
		162,
		50,
		134,
		49,
		121,
		137,
		59,
		103,
		95,
		89,
		84,
		86,
		47,
		148,
		62,
		9,
		144,
		140,
		128,
		152,
		135,
		80,
		141,
		5,
		44,
		156,
		208,
		203,
		250,
		254,
		97,
		227,
		109,
		216,
		56,
		255,
		60,
		73,
		142,
		16,
		220,
		123,
		25,
		252,
		233,
		12,
		55,
		205,
		196,
		104,
		221,
		76,
		6,
		202,
		238,
		138,
		35,
		30,
		10,
		207,
		94,
		13,
		245,
		179,
		248,
		78,
		157,
		139,
		197,
		230,
		101,
		125,
		58,
		172,
		66,
		154,
		206,
		79,
		61,
		231,
		93,
		222,
		213,
		65,
		131,
		112,
		113,
		176,
		70,
		143,
		228,
		19,
		38,
		185,
		147,
		68,
		29,
		114,
		246,
		119,
		90,
		64,
		237,
		75,
		175,
		214,
		244,
		186,
		98,
		117,
		111,
		146,
		34,
		99,
		234,
		26,
		3,
		211,
		36,
		53,
		174,
		124,
		18,
		96,
		229,
		107,
		115,
		217,
		209,
		180,
		39,
		155,
		122,
		240,
		32,
		37,
		165,
		67,
		239,
		189,
		21,
		191,
		236,
		164,
		108,
		232,
		23,
		54,
		247,
		226,
		136,
		159,
		166,
		133,
		198,
		63,
		92,
		181,
		82,
		118,
		46,
		204,
		150,
		28,
		51,
		85,
		243,
		158,
		129,
		15,
		17,
		151,
		173,
		223,
		167,
		178,
		253,
		193,
		241,
		27,
		201,
		31,
		130,
		106,
		110,
		87,
		153,
		57,
		40,
		39,
		18,
		229,
		142,
		71,
		177,
		112,
		113,
		130,
		64,
		212,
		223,
		92,
		230,
		60,
		78,
		207,
		155,
		67,
		173,
		59,
		124,
		100,
		231,
		196,
		138,
		156,
		79,
		249,
		178,
		244,
		12,
		228,
		97,
		19,
		125,
		175,
		52,
		37,
		210,
		2,
		27,
		235,
		98,
		35,
		147,
		110,
		116,
		99,
		187,
		245,
		215,
		174,
		74,
		236,
		65,
		91,
		118,
		247,
		115,
		28,
		69,
		146,
		184,
		93,
		62,
		199,
		132,
		167,
		158,
		137,
		227,
		246,
		55,
		22,
		233,
		109,
		165,
		237,
		190,
		20,
		188,
		238,
		66,
		164,
		36,
		33,
		241,
		123,
		154,
		38,
		181,
		208,
		216,
		114,
		106,
		41,
		56,
		152,
		86,
		111,
		107,
		131,
		30,
		200,
		26,
		240,
		192,
		252,
		179,
		166,
		222,
		172,
		150,
		16,
		14,
		128,
		159,
		242,
		84,
		50,
		29,
		151,
		205,
		47,
		119,
		83,
		180,
		193,
		168,
		73,
		44,
		25,
		211,
		126,
		213,
		121,
		243,
		224,
		214,
		148,
		225,
		90,
		160,
		49,
		144,
		195,
		68,
		182,
		176,
		53,
		162,
		43,
		169,
		23,
		250,
		6,
		218,
		161,
		75,
		3,
		191,
		133,
		248,
		198,
		170,
		82,
		101,
		21,
		42,
		1,
		80,
		183,
		185,
		127,
		201,
		76,
		70,
		219,
		32,
		5,
		234,
		40,
		9,
		89,
		171,
		117,
		186,
		103,
		104,
		15,
		194,
		251,
		202,
		209,
		157,
		45,
		4,
		140,
		81,
		134,
		153,
		129,
		141,
		145,
		8,
		63,
		149,
		46,
		87,
		85,
		88,
		94,
		102,
		58,
		136,
		120,
		48,
		135,
		51,
		163,
		0,
		10,
		189,
		95,
		206,
		11,
		31,
		34,
		139,
		239,
		203,
		7,
		77,
		220,
		105,
		197,
		204,
		54,
		13,
		232,
		253,
		24,
		122,
		221,
		17,
		143,
		72,
		61,
		254,
		57,
		217,
		108,
		226,
		96,
		255,
		255,
		207,
		199,
		21,
		169,
		209,
		243,
		188,
		151,
		89,
		38,
		55,
		140,
		17,
		96,
		100,
		152,
		194,
		61,
		18,
		92,
		187,
		32,
		120,
		31,
		1,
		163,
		153,
		253,
		91,
		143,
		144,
		25,
		230,
		249,
		56,
		226,
		177,
		98,
		170,
		200,
		139,
		82,
		49,
		134,
		236,
		168,
		145,
		41,
		186,
		116,
		149,
		125,
		101,
		223,
		215,
		225,
		77,
		27,
		179,
		46,
		254,
		171,
		43,
		228,
		109,
		13,
		20,
		97,
		123,
		44,
		156,
		28,
		114,
		235,
		110,
		42,
		221,
		160,
		59,
		248,
		124,
		84,
		121,
		157,
		183,
		19,
		74,
		250,
		216,
		108,
		180,
		227,
		78,
		161,
		69,
		219,
		208,
		141,
		79,
		51,
		65,
		83,
		233,
		234,
		129,
		40,
		29,
		127,
		126,
		72,
		190,
		147,
		64,
		203,
		133,
		251,
		3,
		246,
		189,
		76,
		162,
		192,
		148,
		107,
		232,
		52,
		115,
		211,
		102,
		8,
		66,
		57,
		2,
		202,
		195,
		4,
		16,
		80,
		193,
		224,
		196,
		45,
		132,
		54,
		214,
		50,
		241,
		111,
		240,
		99,
		237,
		23,
		117,
		231,
		242,
		128,
		71,
		210,
		30,
		142,
		130,
		137,
		150,
		48,
		154,
		158,
		7,
		222,
		146,
		244,
		197,
		131,
		94,
		34,
		11,
		136,
		60,
		119,
		63,
		5,
		178,
		172,
		15,
		90,
		87,
		33,
		88,
		53,
		135,
		81,
		105,
		14,
		95,
		26,
		37,
		112,
		198,
		184,
		182,
		138,
		247,
		12,
		176,
		93,
		106,
		201,
		165,
		122,
		181,
		86,
		164,
		0,
		205,
		104,
		103,
		212,
		47,
		67,
		73,
		39,
		6,
		10,
		229,
		239,
		217,
		118,
		252,
		85,
		175,
		155,
		238,
		70,
		35,
		206,
		167,
		113,
		218,
		22,
		220,
		24,
		245,
		36,
		166,
		174,
		68,
		9,
		213,
		204,
		75,
		62,
		159,
		58,
		173,
		185,
		191,
		3,
		91,
		192,
		39,
		105,
		70,
		185,
		227,
		235,
		244,
		32,
		134,
		226,
		216,
		122,
		100,
		199,
		136,
		170,
		210,
		110,
		188,
		180,
		132,
		31,
		27,
		106,
		247,
		76,
		93,
		34,
		236,
		172,
		164,
		30,
		6,
		238,
		15,
		193,
		82,
		80,
		208,
		133,
		85,
		200,
		96,
		54,
		154,
		209,
		25,
		202,
		153,
		67,
		130,
		157,
		98,
		234,
		211,
		151,
		253,
		74,
		41,
		240,
		179,
		49,
		104,
		204,
		230,
		2,
		47,
		7,
		131,
		62,
		218,
		53,
		152,
		207,
		23,
		163,
		129,
		231,
		87,
		0,
		26,
		111,
		118,
		22,
		159,
		64,
		219,
		166,
		81,
		21,
		144,
		9,
		103,
		198,
		141,
		120,
		128,
		254,
		176,
		59,
		232,
		8,
		79,
		147,
		16,
		239,
		187,
		217,
		55,
		146,
		40,
		58,
		72,
		52,
		246,
		171,
		160,
		197,
		51,
		5,
		4,
		102,
		83,
		250,
		145,
		150,
		24,
		139,
		20,
		138,
		73,
		173,
		77,
		101,
		169,
		60,
		251,
		137,
		156,
		14,
		108,
		184,
		177,
		121,
		66,
		57,
		115,
		29,
		168,
		255,
		86,
		191,
		155,
		186,
		43,
		107,
		127,
		116,
		215,
		201,
		126,
		68,
		12,
		71,
		243,
		18,
		42,
		252,
		78,
		35,
		90,
		44,
		33,
		124,
		229,
		225,
		75,
		237,
		242,
		249,
		245,
		112,
		89,
		37,
		248,
		190,
		143,
		233,
		165,
		28,
		19,
		182,
		123,
		223,
		45,
		206,
		1,
		158,
		113,
		125,
		92,
		50,
		56,
		84,
		175,
		205,
		195,
		189,
		11,
		94,
		97,
		36,
		117,
		222,
		178,
		17,
		38,
		203,
		119,
		140,
		241,
		174,
		114,
		63,
		213,
		221,
		95,
		142,
		99,
		196,
		194,
		214,
		65,
		228,
		69,
		48,
		183,
		149,
		224,
		212,
		46,
		135,
		13,
		162,
		148,
		167,
		109,
		161,
		10,
		220,
		181,
		88,
		61,
		203,
		47,
		137,
		36,
		6,
		222,
		144,
		178,
		121,
		32,
		247,
		221,
		62,
		19,
		146,
		22,
		202,
		81,
		64,
		183,
		129,
		4,
		118,
		24,
		70,
		246,
		11,
		17,
		103,
		126,
		142,
		7,
		94,
		25,
		1,
		130,
		170,
		254,
		38,
		200,
		156,
		215,
		145,
		105,
		161,
		239,
		249,
		42,
		34,
		212,
		21,
		20,
		66,
		119,
		128,
		235,
		57,
		131,
		89,
		43,
		231,
		37,
		177,
		186,
		229,
		250,
		151,
		49,
		201,
		243,
		117,
		107,
		74,
		18,
		54,
		209,
		87,
		120,
		242,
		168,
		10,
		14,
		230,
		123,
		76,
		93,
		253,
		51,
		153,
		214,
		195,
		187,
		173,
		127,
		149,
		165,
		193,
		65,
		68,
		148,
		113,
		217,
		139,
		39,
		181,
		189,
		23,
		15,
		30,
		255,
		67,
		208,
		194,
		251,
		236,
		134,
		56,
		91,
		162,
		225,
		8,
		192,
		136,
		219,
		147,
		82,
		115,
		140,
		96,
		143,
		77,
		108,
		41,
		35,
		190,
		69,
		2,
		13,
		106,
		167,
		60,
		206,
		16,
		223,
		163,
		207,
		55,
		0,
		102,
		218,
		224,
		157,
		210,
		220,
		26,
		172,
		112,
		79,
		100,
		53,
		211,
		213,
		80,
		199,
		84,
		245,
		166,
		33,
		99,
		191,
		196,
		46,
		78,
		204,
		114,
		159,
		124,
		182,
		27,
		176,
		164,
		205,
		44,
		73,
		241,
		132,
		63,
		197,
		28,
		150,
		133,
		179,
		184,
		116,
		234,
		45,
		141,
		152,
		125,
		31,
		9,
		135,
		5,
		154,
		88,
		155,
		92,
		188,
		71,
		238,
		138,
		174,
		58,
		171,
		110,
		122,
		160,
		169,
		83,
		104,
		98,
		40,
		185,
		12,
		59,
		3,
		95,
		237,
		75,
		50,
		48,
		61,
		198,
		101,
		111,
		216,
		29,
		85,
		226,
		86,
		72,
		97,
		233,
		52,
		158,
		175,
		180,
		248,
		244,
		109,
		90,
		240,
		227,
		252,
		228,
		232,
		50,
		87,
		186,
		211,
		5,
		174,
		98,
		168,
		155,
		173,
		2,
		136,
		33,
		219,
		239,
		154,
		184,
		63,
		74,
		235,
		78,
		217,
		205,
		203,
		108,
		129,
		80,
		210,
		218,
		48,
		125,
		161,
		254,
		131,
		120,
		196,
		41,
		30,
		189,
		209,
		122,
		43,
		110,
		81,
		4,
		178,
		204,
		194,
		160,
		91,
		55,
		61,
		83,
		114,
		126,
		145,
		14,
		193,
		34,
		208,
		116,
		185,
		28,
		19,
		170,
		230,
		128,
		177,
		247,
		42,
		86,
		127,
		250,
		246,
		253,
		226,
		68,
		238,
		234,
		115,
		46,
		35,
		85,
		44,
		65,
		243,
		37,
		29,
		252,
		72,
		3,
		75,
		113,
		198,
		216,
		123,
		112,
		100,
		36,
		181,
		148,
		176,
		89,
		240,
		167,
		18,
		124,
		54,
		77,
		118,
		190,
		183,
		99,
		1,
		147,
		134,
		244,
		51,
		166,
		106,
		66,
		162,
		70,
		133,
		27,
		132,
		23,
		153,
		158,
		245,
		92,
		105,
		11,
		10,
		60,
		202,
		175,
		164,
		249,
		59,
		71,
		53,
		39,
		157,
		56,
		214,
		180,
		224,
		31,
		156,
		64,
		7,
		231,
		52,
		191,
		241,
		143,
		119,
		130,
		201,
		104,
		6,
		159,
		26,
		94,
		169,
		212,
		79,
		144,
		25,
		121,
		96,
		21,
		15,
		88,
		232,
		142,
		172,
		24,
		192,
		151,
		58,
		213,
		49,
		140,
		8,
		32,
		13,
		233,
		195,
		103,
		62,
		188,
		255,
		38,
		69,
		242,
		152,
		220,
		229,
		109,
		146,
		141,
		76,
		150,
		197,
		22,
		222,
		149,
		57,
		111,
		199,
		90,
		138,
		223,
		95,
		93,
		206,
		0,
		225,
		9,
		17,
		171,
		163,
		227,
		45,
		82,
		67,
		248,
		101,
		20,
		16,
		139,
		187,
		179,
		97,
		221,
		165,
		135,
		200,
		107,
		117,
		215,
		237,
		137,
		47,
		251,
		228,
		236,
		182,
		73,
		102,
		40,
		207,
		84,
		12,
		148,
		5,
		192,
		212,
		233,
		64,
		36,
		0,
		204,
		134,
		23,
		162,
		14,
		7,
		253,
		198,
		35,
		54,
		211,
		177,
		22,
		218,
		68,
		131,
		246,
		53,
		242,
		18,
		167,
		41,
		171,
		52,
		48,
		1,
		26,
		86,
		230,
		207,
		71,
		154,
		77,
		82,
		74,
		70,
		90,
		195,
		244,
		94,
		229,
		156,
		158,
		147,
		149,
		173,
		241,
		67,
		179,
		251,
		76,
		248,
		104,
		203,
		193,
		118,
		200,
		116,
		78,
		51,
		13,
		97,
		153,
		174,
		222,
		225,
		202,
		155,
		124,
		114,
		180,
		2,
		135,
		141,
		16,
		235,
		206,
		33,
		227,
		194,
		146,
		96,
		190,
		113,
		172,
		163,
		196,
		9,
		10,
		99,
		130,
		231,
		210,
		24,
		181,
		30,
		178,
		56,
		43,
		29,
		95,
		42,
		145,
		107,
		250,
		91,
		8,
		143,
		125,
		123,
		254,
		105,
		224,
		98,
		220,
		49,
		205,
		17,
		106,
		128,
		226,
		243,
		83,
		157,
		164,
		160,
		72,
		213,
		3,
		209,
		59,
		11,
		55,
		120,
		109,
		21,
		103,
		93,
		219,
		197,
		75,
		84,
		57,
		159,
		249,
		214,
		92,
		6,
		228,
		188,
		152,
		127,
		150,
		245,
		12,
		79,
		108,
		85,
		66,
		40,
		61,
		252,
		221,
		34,
		166,
		110,
		38,
		117,
		223,
		119,
		37,
		137,
		111,
		239,
		234,
		58,
		176,
		81,
		237,
		126,
		27,
		19,
		185,
		161,
		47,
		170,
		216,
		182,
		100,
		255,
		238,
		25,
		201,
		208,
		32,
		169,
		232,
		88,
		165,
		191,
		168,
		112,
		62,
		28,
		101,
		129,
		39,
		138,
		144,
		189,
		60,
		184,
		215,
		142,
		89,
		115,
		236,
		217,
		46,
		69,
		140,
		122,
		187,
		186,
		73,
		139,
		31,
		20,
		151,
		45,
		247,
		133,
		4,
		80,
		136,
		102,
		240,
		183,
		175,
		44,
		15,
		65,
		87,
		132,
		50,
		121,
		63,
		199,
		134,
		94,
		234,
		200,
		119,
		147,
		124,
		209,
		75,
		102,
		78,
		202,
		120,
		33,
		133,
		175,
		92,
		217,
		64,
		46,
		9,
		146,
		239,
		24,
		38,
		63,
		95,
		214,
		174,
		30,
		73,
		83,
		166,
		242,
		144,
		126,
		65,
		6,
		218,
		89,
		183,
		249,
		114,
		161,
		143,
		196,
		49,
		201,
		47,
		26,
		179,
		216,
		140,
		122,
		76,
		77,
		125,
		191,
		226,
		233,
		219,
		97,
		115,
		1,
		171,
		145,
		51,
		45,
		162,
		189,
		105,
		207,
		32,
		15,
		240,
		170,
		74,
		18,
		137,
		110,
		5,
		20,
		107,
		165,
		86,
		82,
		35,
		190,
		39,
		245,
		253,
		205,
		142,
		193,
		227,
		155,
		129,
		41,
		127,
		211,
		25,
		153,
		204,
		28,
		167,
		70,
		136,
		27,
		229,
		237,
		87,
		79,
		3,
		96,
		185,
		250,
		163,
		154,
		222,
		180,
		10,
		203,
		212,
		43,
		152,
		80,
		131,
		208,
		123,
		113,
		29,
		230,
		215,
		56,
		52,
		21,
		150,
		100,
		135,
		72,
		85,
		90,
		255,
		50,
		130,
		62,
		197,
		184,
		151,
		251,
		88,
		111,
		23,
		40,
		109,
		60,
		132,
		138,
		244,
		66,
		173,
		12,
		121,
		254,
		141,
		139,
		159,
		8,
		148,
		22,
		199,
		42,
		231,
		59,
		118,
		156,
		149,
		252,
		17,
		116,
		238,
		36,
		232,
		67,
		206,
		68,
		235,
		221,
		220,
		169,
		157,
		103,
		192,
		213,
		71,
		37,
		44,
		224,
		117,
		178,
		195,
		0,
		228,
		4,
		223,
		81,
		194,
		93,
		243,
		98,
		34,
		54,
		182,
		31,
		246,
		210,
		112,
		58,
		84,
		225,
		241,
		248,
		48,
		11,
		106,
		19,
		101,
		104,
		91,
		99,
		181,
		7,
		13,
		69,
		14,
		186,
		61,
		158,
		128,
		55,
		247,
		198,
		160,
		236,
		57,
		16,
		108,
		177,
		164,
		187,
		176,
		188,
		53,
		172,
		168,
		2,
		158,
		29,
		193,
		134,
		185,
		87,
		53,
		97,
		14,
		246,
		3,
		72,
		102,
		181,
		62,
		112,
		138,
		139,
		189,
		75,
		31,
		116,
		221,
		232,
		198,
		180,
		166,
		28,
		46,
		37,
		120,
		186,
		22,
		187,
		84,
		176,
		15,
		45,
		153,
		65,
		104,
		66,
		230,
		191,
		13,
		137,
		161,
		140,
		223,
		40,
		85,
		206,
		233,
		135,
		30,
		155,
		148,
		142,
		217,
		105,
		17,
		152,
		248,
		225,
		219,
		11,
		94,
		222,
		20,
		184,
		238,
		70,
		136,
		144,
		42,
		34,
		220,
		79,
		129,
		96,
		115,
		25,
		93,
		100,
		61,
		126,
		167,
		196,
		23,
		68,
		151,
		95,
		236,
		19,
		12,
		205,
		8,
		174,
		122,
		101,
		234,
		244,
		86,
		108,
		169,
		78,
		213,
		141,
		109,
		55,
		200,
		231,
		121,
		228,
		149,
		145,
		98,
		172,
		211,
		194,
		92,
		36,
		6,
		73,
		10,
		58,
		50,
		224,
		207,
		88,
		76,
		74,
		57,
		190,
		203,
		106,
		91,
		177,
		252,
		32,
		237,
		0,
		209,
		83,
		132,
		47,
		227,
		41,
		179,
		214,
		59,
		82,
		160,
		90,
		110,
		27,
		26,
		44,
		131,
		9,
		210,
		243,
		255,
		16,
		33,
		218,
		182,
		188,
		245,
		56,
		157,
		146,
		143,
		64,
		163,
		81,
		168,
		159,
		60,
		80,
		127,
		2,
		249,
		69,
		133,
		51,
		77,
		67,
		251,
		170,
		239,
		208,
		192,
		114,
		164,
		156,
		175,
		162,
		212,
		173,
		240,
		71,
		89,
		250,
		125,
		201,
		130,
		202,
		118,
		171,
		215,
		254,
		43,
		103,
		1,
		48,
		197,
		111,
		107,
		242,
		123,
		119,
		124,
		99,
		117,
		178,
		39,
		235,
		226,
		128,
		18,
		7,
		154,
		5,
		150,
		24,
		195,
		35,
		199,
		4,
		21,
		49,
		216,
		113,
		241,
		229,
		165,
		52,
		204,
		247,
		63,
		54,
		38,
		147,
		253,
		183,
		217,
		11,
		225,
		209,
		237,
		162,
		183,
		207,
		56,
		41,
		137,
		71,
		126,
		122,
		146,
		15,
		35,
		12,
		134,
		220,
		62,
		102,
		66,
		165,
		189,
		135,
		1,
		31,
		145,
		142,
		227,
		69,
		231,
		38,
		7,
		248,
		124,
		180,
		252,
		175,
		76,
		47,
		214,
		149,
		182,
		143,
		152,
		242,
		106,
		139,
		55,
		164,
		193,
		201,
		99,
		123,
		5,
		173,
		255,
		83,
		181,
		53,
		48,
		224,
		19,
		10,
		250,
		115,
		50,
		130,
		127,
		101,
		245,
		112,
		2,
		108,
		190,
		37,
		52,
		195,
		74,
		103,
		230,
		98,
		13,
		84,
		131,
		169,
		114,
		170,
		228,
		198,
		191,
		91,
		253,
		80,
		147,
		81,
		197,
		206,
		77,
		247,
		45,
		95,
		54,
		3,
		244,
		159,
		86,
		160,
		97,
		96,
		213,
		155,
		141,
		94,
		232,
		163,
		229,
		29,
		222,
		138,
		82,
		188,
		42,
		109,
		117,
		246,
		22,
		92,
		205,
		120,
		212,
		221,
		39,
		28,
		78,
		223,
		26,
		14,
		51,
		154,
		254,
		218,
		44,
		239,
		40,
		200,
		125,
		243,
		113,
		238,
		249,
		236,
		9,
		107,
		204,
		0,
		158,
		89,
		151,
		136,
		144,
		156,
		128,
		25,
		46,
		132,
		234,
		219,
		192,
		140,
		60,
		21,
		157,
		64,
		105,
		33,
		150,
		34,
		178,
		17,
		27,
		172,
		63,
		70,
		68,
		73,
		79,
		119,
		43,
		153,
		4,
		59,
		16,
		65,
		166,
		168,
		110,
		216,
		18,
		174,
		148,
		233,
		215,
		187,
		67,
		116,
		72,
		186,
		100,
		171,
		118,
		121,
		30,
		211,
		93,
		87,
		202,
		49,
		20,
		251,
		57,
		24,
		104,
		226,
		241,
		199,
		133,
		240,
		75,
		177,
		208,
		185,
		88,
		61,
		8,
		194,
		111,
		196,
		58,
		184,
		6,
		235,
		23,
		203,
		176,
		90,
		32,
		129,
		210,
		85,
		167,
		161,
		36,
		179,
		228,
		11,
		7,
		38,
		72,
		66,
		46,
		213,
		102,
		105,
		204,
		1,
		165,
		87,
		180,
		123,
		164,
		200,
		107,
		92,
		177,
		13,
		246,
		139,
		183,
		185,
		199,
		113,
		36,
		27,
		94,
		15,
		190,
		184,
		172,
		59,
		158,
		63,
		74,
		205,
		212,
		8,
		69,
		175,
		167,
		37,
		244,
		25,
		221,
		23,
		219,
		112,
		166,
		207,
		34,
		71,
		239,
		154,
		174,
		84,
		253,
		119,
		216,
		238,
		31,
		211,
		70,
		129,
		243,
		230,
		116,
		22,
		236,
		98,
		241,
		110,
		240,
		51,
		215,
		55,
		133,
		44,
		197,
		225,
		192,
		81,
		17,
		5,
		194,
		203,
		3,
		56,
		67,
		9,
		103,
		210,
		104,
		80,
		134,
		52,
		89,
		32,
		86,
		91,
		14,
		173,
		179,
		4,
		62,
		118,
		61,
		137,
		10,
		35,
		95,
		130,
		196,
		245,
		147,
		223,
		6,
		159,
		155,
		49,
		151,
		136,
		131,
		143,
		68,
		160,
		79,
		226,
		181,
		109,
		217,
		251,
		75,
		18,
		182,
		156,
		120,
		85,
		125,
		249,
		58,
		161,
		220,
		43,
		111,
		234,
		115,
		29,
		157,
		45,
		122,
		96,
		21,
		12,
		108,
		229,
		114,
		53,
		233,
		106,
		149,
		193,
		163,
		77,
		188,
		247,
		2,
		250,
		132,
		202,
		65,
		146,
		191,
		73,
		127,
		126,
		28,
		41,
		128,
		235,
		232,
		82,
		64,
		50,
		78,
		140,
		209,
		218,
		145,
		142,
		90,
		252,
		152,
		162,
		0,
		30,
		121,
		33,
		186,
		93,
		19,
		60,
		195,
		153,
		101,
		97,
		16,
		141,
		54,
		39,
		88,
		150,
		189,
		242,
		208,
		168,
		20,
		198,
		206,
		254,
		42,
		170,
		255,
		47,
		178,
		26,
		76,
		224,
		214,
		222,
		100,
		124,
		148,
		117,
		187,
		40,
		144,
		169,
		237,
		135,
		48,
		83,
		138,
		201,
		171,
		99,
		176,
		227,
		57,
		248,
		231,
		24,
		36,
		140,
		218,
		118,
		188,
		60,
		105,
		185,
		2,
		227,
		45,
		190,
		64,
		72,
		242,
		234,
		166,
		197,
		28,
		95,
		6,
		63,
		123,
		17,
		175,
		110,
		113,
		142,
		61,
		245,
		38,
		117,
		14,
		52,
		150,
		136,
		7,
		24,
		204,
		106,
		133,
		170,
		85,
		15,
		239,
		183,
		44,
		203,
		160,
		177,
		206,
		0,
		243,
		247,
		134,
		27,
		130,
		80,
		88,
		104,
		43,
		100,
		70,
		62,
		3,
		87,
		53,
		219,
		228,
		163,
		127,
		252,
		18,
		92,
		215,
		4,
		42,
		97,
		148,
		108,
		138,
		191,
		22,
		125,
		41,
		223,
		233,
		232,
		216,
		26,
		71,
		76,
		126,
		196,
		214,
		164,
		35,
		251,
		79,
		109,
		210,
		54,
		217,
		116,
		238,
		195,
		235,
		111,
		221,
		132,
		32,
		10,
		249,
		124,
		229,
		139,
		172,
		55,
		74,
		189,
		131,
		154,
		250,
		115,
		11,
		187,
		236,
		246,
		207,
		182,
		192,
		205,
		254,
		198,
		16,
		162,
		168,
		224,
		171,
		31,
		152,
		59,
		37,
		146,
		82,
		99,
		5,
		73,
		156,
		181,
		201,
		20,
		1,
		30,
		21,
		25,
		144,
		9,
		13,
		167,
		101,
		112,
		226,
		128,
		137,
		69,
		208,
		23,
		102,
		165,
		65,
		161,
		122,
		244,
		103,
		248,
		86,
		199,
		135,
		147,
		19,
		186,
		83,
		119,
		213,
		159,
		241,
		68,
		84,
		93,
		149,
		174,
		8,
		169,
		220,
		91,
		40,
		46,
		58,
		173,
		49,
		179,
		98,
		143,
		66,
		158,
		211,
		57,
		48,
		89,
		180,
		209,
		75,
		129,
		77,
		230,
		107,
		225,
		78,
		120,
		121,
		12,
		56,
		194,
		222,
		212,
		184,
		67,
		114,
		157,
		145,
		176,
		51,
		193,
		34,
		237,
		240,
		255,
		90,
		151,
		39,
		155,
		96,
		29,
		50,
		94,
		253,
		202,
		178,
		141,
		200,
		153,
		33,
		47,
		81,
		231,
		244,
		173,
		122,
		80,
		179,
		158,
		31,
		155,
		70,
		162,
		4,
		169,
		139,
		83,
		29,
		63,
		203,
		123,
		134,
		156,
		234,
		243,
		3,
		138,
		71,
		220,
		205,
		58,
		12,
		137,
		251,
		149,
		17,
		90,
		28,
		228,
		44,
		98,
		116,
		167,
		211,
		148,
		140,
		15,
		39,
		115,
		171,
		69,
		180,
		14,
		212,
		166,
		106,
		168,
		60,
		55,
		175,
		89,
		152,
		153,
		207,
		250,
		13,
		102,
		199,
		159,
		187,
		92,
		218,
		245,
		127,
		37,
		104,
		119,
		26,
		188,
		68,
		126,
		248,
		230,
		20,
		91,
		78,
		54,
		32,
		242,
		24,
		40,
		135,
		131,
		107,
		246,
		193,
		208,
		112,
		190,
		56,
		48,
		154,
		130,
		147,
		114,
		206,
		93,
		76,
		204,
		201,
		25,
		252,
		84,
		6,
		170,
		133,
		77,
		5,
		86,
		30,
		223,
		254,
		1,
		79,
		118,
		97,
		11,
		181,
		214,
		47,
		108,
		143,
		128,
		231,
		42,
		177,
		67,
		157,
		82,
		237,
		2,
		192,
		225,
		164,
		174,
		51,
		200,
		95,
		81,
		151,
		33,
		253,
		194,
		233,
		184,
		46,
		66,
		186,
		141,
		235,
		87,
		109,
		16,
		238,
		50,
		73,
		163,
		195,
		65,
		255,
		18,
		94,
		88,
		221,
		74,
		217,
		120,
		43,
		172,
		124,
		9,
		178,
		72,
		145,
		27,
		8,
		62,
		241,
		59,
		150,
		61,
		41,
		64,
		161,
		196,
		132,
		10,
		136,
		23,
		213,
		22,
		209,
		49,
		53,
		249,
		103,
		160,
		0,
		21,
		240,
		146,
		45,
		36,
		222,
		229,
		239,
		165,
		52,
		129,
		202,
		99,
		7,
		35,
		183,
		38,
		227,
		247,
		75,
		232,
		226,
		85,
		144,
		216,
		111,
		219,
		182,
		142,
		210,
		96,
		198,
		191,
		189,
		176,
		121,
		224,
		215,
		125,
		110,
		113,
		105,
		101,
		197,
		236,
		100,
		185,
		19,
		34,
		57,
		117,
		11,
		167,
		241,
		89,
		196,
		20,
		65,
		193,
		195,
		80,
		158,
		127,
		151,
		143,
		53,
		61,
		34,
		97,
		184,
		219,
		108,
		6,
		66,
		123,
		243,
		12,
		19,
		210,
		8,
		91,
		136,
		64,
		245,
		235,
		73,
		115,
		23,
		177,
		101,
		122,
		114,
		40,
		215,
		248,
		182,
		81,
		202,
		146,
		125,
		179,
		204,
		221,
		102,
		251,
		138,
		142,
		21,
		37,
		45,
		255,
		67,
		59,
		25,
		86,
		166,
		72,
		42,
		126,
		129,
		2,
		222,
		153,
		121,
		170,
		33,
		111,
		17,
		233,
		28,
		87,
		0,
		107,
		194,
		247,
		149,
		148,
		162,
		84,
		49,
		58,
		103,
		165,
		217,
		171,
		185,
		3,
		16,
		50,
		134,
		94,
		9,
		164,
		75,
		175,
		18,
		150,
		190,
		147,
		119,
		93,
		249,
		160,
		246,
		152,
		1,
		132,
		192,
		55,
		74,
		209,
		14,
		135,
		231,
		254,
		139,
		145,
		198,
		118,
		176,
		189,
		203,
		178,
		223,
		109,
		187,
		131,
		98,
		214,
		157,
		213,
		239,
		88,
		70,
		229,
		52,
		120,
		30,
		47,
		105,
		180,
		200,
		225,
		100,
		104,
		99,
		124,
		218,
		112,
		116,
		237,
		253,
		159,
		13,
		24,
		106,
		173,
		56,
		244,
		220,
		60,
		216,
		27,
		133,
		26,
		137,
		7,
		238,
		250,
		186,
		43,
		10,
		46,
		199,
		110,
		57,
		140,
		226,
		168,
		211,
		232,
		32,
		41,
		38,
		161,
		212,
		117,
		208,
		71,
		83,
		85,
		242,
		31,
		206,
		76,
		68,
		174,
		227,
		63,
		172,
		201,
		36,
		77,
		155,
		48,
		252,
		54,
		5,
		51,
		156,
		22,
		191,
		69,
		113,
		4,
		62,
		197,
		169,
		163,
		205,
		236,
		224,
		15,
		144,
		95,
		188,
		78,
		234,
		39,
		130,
		141,
		96,
		29,
		230,
		90,
		183,
		128,
		35,
		79,
		228,
		181,
		240,
		207,
		154,
		44,
		82,
		92,
		219,
		163,
		182,
		249,
		197,
		245,
		31,
		205,
		27,
		134,
		110,
		106,
		83,
		157,
		61,
		44,
		177,
		86,
		114,
		42,
		200,
		146,
		24,
		55,
		81,
		247,
		154,
		133,
		11,
		21,
		147,
		169,
		187,
		232,
		160,
		104,
		236,
		19,
		50,
		243,
		230,
		140,
		155,
		162,
		129,
		194,
		59,
		88,
		111,
		119,
		221,
		213,
		176,
		35,
		159,
		126,
		244,
		36,
		33,
		161,
		71,
		235,
		185,
		17,
		113,
		107,
		150,
		38,
		103,
		238,
		30,
		7,
		215,
		32,
		49,
		170,
		120,
		22,
		100,
		225,
		189,
		151,
		64,
		25,
		118,
		242,
		115,
		94,
		68,
		233,
		79,
		171,
		210,
		240,
		190,
		102,
		75,
		57,
		227,
		89,
		218,
		209,
		69,
		135,
		116,
		117,
		180,
		66,
		139,
		224,
		23,
		34,
		9,
		241,
		183,
		252,
		74,
		153,
		143,
		193,
		226,
		97,
		121,
		62,
		168,
		70,
		158,
		202,
		8,
		51,
		201,
		192,
		108,
		217,
		72,
		2,
		206,
		234,
		142,
		39,
		26,
		14,
		203,
		90,
		250,
		101,
		231,
		105,
		220,
		60,
		251,
		56,
		77,
		138,
		20,
		216,
		127,
		29,
		248,
		237,
		144,
		58,
		13,
		148,
		136,
		132,
		156,
		131,
		84,
		137,
		1,
		40,
		152,
		212,
		207,
		254,
		184,
		15,
		5,
		166,
		54,
		130,
		53,
		125,
		141,
		63,
		99,
		91,
		93,
		80,
		82,
		43,
		204,
		122,
		188,
		178,
		85,
		4,
		47,
		16,
		96,
		87,
		175,
		195,
		253,
		128,
		186,
		6,
		199,
		10,
		109,
		98,
		191,
		112,
		174,
		92,
		12,
		45,
		239,
		0,
		37,
		222,
		67,
		73,
		165,
		95,
		228,
		145,
		211,
		229,
		246,
		124,
		208,
		123,
		214,
		28,
		41,
		76,
		173,
		196,
		78,
		164,
		223,
		3,
		255,
		18,
		172,
		46,
		167,
		48,
		181,
		179,
		65,
		198,
		149,
		52,
		97,
		192,
		181,
		50,
		65,
		71,
		83,
		196,
		88,
		218,
		11,
		230,
		43,
		247,
		186,
		80,
		89,
		48,
		221,
		184,
		34,
		232,
		36,
		143,
		2,
		136,
		39,
		17,
		16,
		101,
		81,
		171,
		183,
		189,
		209,
		42,
		27,
		244,
		248,
		217,
		90,
		168,
		75,
		132,
		153,
		150,
		51,
		254,
		78,
		242,
		9,
		116,
		91,
		55,
		148,
		163,
		219,
		228,
		161,
		240,
		72,
		70,
		56,
		142,
		166,
		223,
		169,
		164,
		151,
		175,
		121,
		203,
		193,
		137,
		194,
		118,
		241,
		82,
		76,
		251,
		59,
		10,
		108,
		32,
		245,
		220,
		160,
		125,
		104,
		119,
		124,
		112,
		249,
		96,
		100,
		206,
		12,
		25,
		139,
		233,
		224,
		44,
		185,
		126,
		15,
		204,
		40,
		200,
		19,
		157,
		14,
		145,
		63,
		174,
		238,
		250,
		122,
		211,
		58,
		30,
		188,
		246,
		152,
		45,
		61,
		52,
		252,
		199,
		106,
		62,
		92,
		178,
		141,
		202,
		22,
		149,
		123,
		53,
		190,
		109,
		67,
		8,
		253,
		5,
		227,
		214,
		127,
		20,
		64,
		182,
		128,
		129,
		177,
		115,
		46,
		37,
		23,
		173,
		191,
		205,
		74,
		146,
		38,
		4,
		187,
		95,
		176,
		29,
		135,
		170,
		130,
		6,
		180,
		237,
		73,
		99,
		144,
		21,
		140,
		226,
		197,
		94,
		35,
		212,
		234,
		243,
		147,
		26,
		98,
		210,
		133,
		159,
		77,
		229,
		179,
		31,
		213,
		85,
		0,
		208,
		107,
		138,
		68,
		215,
		41,
		33,
		155,
		131,
		207,
		172,
		117,
		54,
		111,
		86,
		18,
		120,
		198,
		7,
		24,
		231,
		84,
		156,
		79,
		28,
		103,
		93,
		255,
		225,
		110,
		113,
		165,
		3,
		236,
		195,
		60,
		102,
		134,
		222,
		69,
		162,
		201,
		216,
		167,
		105,
		154,
		158,
		239,
		114,
		235,
		57,
		49,
		1,
		66,
		13,
		47,
		87,
		31,
		130,
		106,
		110,
		87,
		153,
		57,
		40,
		223,
		167,
		178,
		253,
		193,
		241,
		27,
		201,
		85,
		243,
		158,
		129,
		15,
		17,
		151,
		173,
		181,
		82,
		118,
		46,
		204,
		150,
		28,
		51,
		226,
		136,
		159,
		166,
		133,
		198,
		63,
		92,
		191,
		236,
		164,
		108,
		232,
		23,
		54,
		247,
		240,
		32,
		37,
		165,
		67,
		239,
		189,
		21,
		107,
		115,
		217,
		209,
		180,
		39,
		155,
		122,
		211,
		36,
		53,
		174,
		124,
		18,
		96,
		229,
		117,
		111,
		146,
		34,
		99,
		234,
		26,
		3,
		64,
		237,
		75,
		175,
		214,
		244,
		186,
		98,
		185,
		147,
		68,
		29,
		114,
		246,
		119,
		90,
		112,
		113,
		176,
		70,
		143,
		228,
		19,
		38,
		79,
		61,
		231,
		93,
		222,
		213,
		65,
		131,
		230,
		101,
		125,
		58,
		172,
		66,
		154,
		206,
		13,
		245,
		179,
		248,
		78,
		157,
		139,
		197,
		202,
		238,
		138,
		35,
		30,
		10,
		207,
		94,
		12,
		55,
		205,
		196,
		104,
		221,
		76,
		6,
		73,
		142,
		16,
		220,
		123,
		25,
		252,
		233,
		254,
		97,
		227,
		109,
		216,
		56,
		255,
		60,
		80,
		141,
		5,
		44,
		156,
		208,
		203,
		250,
		148,
		62,
		9,
		144,
		140,
		128,
		152,
		135,
		137,
		59,
		103,
		95,
		89,
		84,
		86,
		47,
		188,
		11,
		1,
		162,
		50,
		134,
		49,
		121,
		100,
		83,
		171,
		199,
		249,
		132,
		190,
		2,
		200,
		126,
		184,
		182,
		81,
		0,
		43,
		20,
		8,
		41,
		235,
		4,
		33,
		218,
		71,
		77,
		195,
		14,
		105,
		102,
		187,
		116,
		170,
		88,
		212,
		127,
		210,
		24,
		45,
		72,
		169,
		192,
		161,
		91,
		224,
		149,
		215,
		225,
		242,
		120,
		163,
		52,
		177,
		183,
		69,
		194,
		145,
		48,
		74,
		160,
		219,
		7,
		251,
		22,
		168,
		42,
		18,
		224,
		3,
		204,
		209,
		222,
		123,
		182,
		255,
		245,
		153,
		98,
		83,
		188,
		176,
		145,
		147,
		172,
		233,
		184,
		0,
		14,
		112,
		198,
		6,
		186,
		65,
		60,
		19,
		127,
		220,
		235,
		16,
		146,
		67,
		174,
		99,
		191,
		242,
		24,
		41,
		136,
		253,
		122,
		9,
		15,
		27,
		140,
		74,
		192,
		111,
		89,
		88,
		45,
		25,
		227,
		17,
		120,
		149,
		240,
		106,
		160,
		108,
		199,
		71,
		132,
		96,
		128,
		91,
		213,
		70,
		217,
		68,
		81,
		195,
		161,
		168,
		100,
		241,
		54,
		244,
		190,
		208,
		101,
		117,
		124,
		180,
		143,
		119,
		230,
		166,
		178,
		50,
		155,
		114,
		86,
		137,
		193,
		138,
		62,
		185,
		26,
		4,
		179,
		238,
		151,
		225,
		236,
		223,
		231,
		49,
		131,
		32,
		63,
		52,
		56,
		177,
		40,
		44,
		134,
		115,
		66,
		36,
		104,
		189,
		148,
		232,
		53,
		207,
		226,
		202,
		78,
		252,
		165,
		1,
		43,
		2,
		218,
		110,
		76,
		243,
		23,
		248,
		85,
		162,
		187,
		219,
		82,
		42,
		154,
		205,
		215,
		216,
		93,
		196,
		170,
		141,
		22,
		107,
		156,
		51,
		125,
		246,
		37,
		11,
		64,
		181,
		77,
		34,
		118,
		20,
		250,
		197,
		130,
		94,
		221,
		249,
		59,
		102,
		109,
		95,
		229,
		247,
		133,
		171,
		158,
		55,
		92,
		8,
		254,
		200,
		201,
		164,
		139,
		116,
		46,
		206,
		150,
		13,
		234,
		47,
		21,
		183,
		169,
		38,
		57,
		237,
		75,
		163,
		113,
		121,
		73,
		10,
		69,
		103,
		31,
		129,
		144,
		239,
		33,
		210,
		214,
		167,
		58,
		35,
		194,
		12,
		159,
		97,
		105,
		211,
		203,
		5,
		173,
		251,
		87,
		157,
		29,
		72,
		152,
		142,
		79,
		80,
		175,
		28,
		212,
		7,
		84,
		135,
		228,
		61,
		126,
		39,
		30,
		90,
		48,
		84,
		64,
		0,
		145,
		176,
		148,
		125,
		212,
		131,
		54,
		88,
		18,
		105,
		82,
		154,
		147,
		71,
		37,
		183,
		162,
		208,
		23,
		130,
		78,
		102,
		134,
		98,
		161,
		63,
		160,
		51,
		189,
		142,
		194,
		164,
		149,
		211,
		14,
		114,
		91,
		222,
		210,
		217,
		198,
		96,
		202,
		206,
		87,
		10,
		7,
		113,
		8,
		101,
		215,
		1,
		57,
		216,
		108,
		39,
		111,
		85,
		226,
		252,
		95,
		218,
		167,
		92,
		224,
		13,
		58,
		153,
		245,
		94,
		15,
		74,
		117,
		32,
		150,
		232,
		230,
		132,
		127,
		19,
		25,
		119,
		86,
		90,
		181,
		42,
		229,
		6,
		244,
		80,
		157,
		56,
		55,
		22,
		115,
		158,
		247,
		33,
		138,
		70,
		140,
		191,
		137,
		38,
		172,
		5,
		255,
		203,
		190,
		156,
		27,
		110,
		207,
		106,
		253,
		233,
		239,
		72,
		165,
		116,
		246,
		254,
		20,
		89,
		133,
		199,
		9,
		118,
		103,
		220,
		65,
		48,
		52,
		175,
		159,
		151,
		69,
		249,
		129,
		163,
		236,
		79,
		81,
		243,
		201,
		173,
		11,
		223,
		192,
		200,
		146,
		109,
		66,
		12,
		235,
		112,
		40,
		152,
		219,
		2,
		97,
		214,
		188,
		248,
		193,
		73,
		182,
		169,
		104,
		178,
		225,
		50,
		250,
		177,
		29,
		75,
		227,
		126,
		174,
		251,
		123,
		121,
		234,
		36,
		197,
		45,
		53,
		143,
		135,
		76,
		34,
		187,
		62,
		122,
		141,
		240,
		107,
		180,
		61,
		93,
		68,
		49,
		43,
		124,
		204,
		170,
		136,
		60,
		228,
		179,
		30,
		241,
		21,
		168,
		44,
		4,
		41,
		205,
		231,
		67,
		26,
		186,
		209,
		120,
		77,
		47,
		46,
		24,
		238,
		139,
		128,
		221,
		31,
		99,
		17,
		3,
		185,
		28,
		242,
		144,
		196,
		59,
		184,
		100,
		35,
		195,
		16,
		155,
		213,
		171,
		83,
		166,
		237,
		52,
		247,
		48,
		208,
		101,
		235,
		105,
		246,
		225,
		244,
		17,
		115,
		212,
		24,
		134,
		65,
		14,
		68,
		213,
		96,
		204,
		197,
		63,
		4,
		86,
		199,
		2,
		22,
		43,
		130,
		230,
		194,
		113,
		57,
		142,
		58,
		170,
		9,
		3,
		180,
		39,
		94,
		92,
		81,
		87,
		111,
		51,
		129,
		143,
		144,
		136,
		132,
		152,
		1,
		54,
		156,
		242,
		195,
		216,
		148,
		36,
		13,
		133,
		88,
		80,
		162,
		124,
		179,
		110,
		97,
		6,
		203,
		69,
		79,
		210,
		41,
		12,
		227,
		33,
		0,
		28,
		35,
		8,
		89,
		190,
		176,
		118,
		192,
		10,
		182,
		140,
		241,
		207,
		163,
		91,
		108,
		34,
		160,
		30,
		243,
		15,
		211,
		168,
		66,
		56,
		153,
		202,
		77,
		191,
		185,
		60,
		171,
		112,
		250,
		233,
		223,
		157,
		232,
		83,
		169,
		200,
		161,
		64,
		37,
		16,
		218,
		119,
		220,
		59,
		20,
		158,
		196,
		38,
		126,
		90,
		189,
		165,
		159,
		25,
		7,
		137,
		150,
		251,
		93,
		193,
		19,
		249,
		201,
		245,
		186,
		175,
		215,
		32,
		49,
		145,
		95,
		102,
		98,
		138,
		23,
		114,
		147,
		47,
		188,
		217,
		209,
		123,
		99,
		29,
		181,
		231,
		75,
		173,
		45,
		40,
		248,
		255,
		62,
		31,
		224,
		100,
		172,
		228,
		183,
		84,
		55,
		206,
		141,
		174,
		151,
		128,
		234,
		82,
		127,
		254,
		122,
		21,
		76,
		155,
		177,
		106,
		178,
		252,
		222,
		167,
		67,
		229,
		72,
		11,
		18,
		226,
		107,
		42,
		154,
		103,
		125,
		237,
		104,
		26,
		116,
		166,
		61,
		44,
		219,
		205,
		131,
		149,
		70,
		240,
		187,
		253,
		5,
		198,
		146,
		74,
		164,
		50,
		117,
		109,
		238,
		139,
		73,
		221,
		214,
		85,
		239,
		53,
		71,
		46,
		27,
		236,
		135,
		78,
		184,
		121,
		120,
		178,
		187,
		65,
		122,
		112,
		58,
		171,
		30,
		85,
		252,
		152,
		188,
		40,
		185,
		124,
		104,
		27,
		149,
		23,
		136,
		74,
		137,
		78,
		174,
		170,
		102,
		248,
		63,
		159,
		138,
		111,
		13,
		230,
		127,
		72,
		226,
		241,
		238,
		246,
		250,
		90,
		115,
		251,
		38,
		140,
		189,
		166,
		234,
		212,
		119,
		125,
		202,
		15,
		71,
		240,
		68,
		41,
		17,
		77,
		255,
		89,
		32,
		34,
		47,
		192,
		206,
		8,
		190,
		98,
		93,
		118,
		39,
		177,
		221,
		37,
		18,
		116,
		200,
		242,
		143,
		16,
		31,
		120,
		181,
		46,
		220,
		2,
		205,
		114,
		157,
		95,
		126,
		59,
		49,
		172,
		87,
		227,
		150,
		45,
		215,
		14,
		132,
		151,
		161,
		110,
		164,
		9,
		162,
		182,
		223,
		62,
		91,
		113,
		173,
		214,
		60,
		92,
		222,
		96,
		141,
		193,
		199,
		66,
		213,
		70,
		231,
		180,
		51,
		139,
		196,
		209,
		169,
		191,
		109,
		135,
		183,
		24,
		28,
		244,
		105,
		94,
		79,
		239,
		33,
		88,
		0,
		36,
		195,
		69,
		106,
		224,
		186,
		247,
		232,
		133,
		35,
		219,
		225,
		103,
		121,
		26,
		210,
		154,
		201,
		129,
		64,
		97,
		158,
		208,
		233,
		254,
		148,
		42,
		73,
		176,
		243,
		167,
		175,
		5,
		29,
		12,
		237,
		81,
		194,
		211,
		83,
		86,
		134,
		99,
		203,
		153,
		53,
		84,
		228,
		25,
		3,
		117,
		108,
		156,
		21,
		216,
		67,
		82,
		165,
		147,
		22,
		100,
		10,
		107,
		50,
		229,
		207,
		44,
		1,
		128,
		4,
		217,
		61,
		155,
		54,
		20,
		204,
		130,
		160,
		43,
		145,
		75,
		57,
		245,
		55,
		163,
		168,
		48,
		198,
		7,
		6,
		80,
		101,
		146,
		249,
		142,
		197,
		131,
		123,
		179,
		253,
		235,
		56,
		76,
		11,
		19,
		144,
		184,
		236,
		52,
		218,
		91,
		241,
		245,
		108,
		229,
		233,
		226,
		253,
		232,
		53,
		73,
		96,
		181,
		249,
		159,
		174,
		110,
		217,
		199,
		100,
		227,
		87,
		28,
		84,
		94,
		236,
		58,
		2,
		49,
		60,
		74,
		51,
		82,
		105,
		161,
		168,
		184,
		13,
		99,
		41,
		139,
		175,
		70,
		239,
		111,
		123,
		59,
		170,
		4,
		155,
		8,
		134,
		93,
		189,
		89,
		154,
		235,
		44,
		185,
		117,
		124,
		30,
		140,
		153,
		62,
		196,
		240,
		133,
		132,
		178,
		29,
		151,
		26,
		177,
		125,
		183,
		45,
		72,
		165,
		204,
		197,
		47,
		98,
		190,
		115,
		158,
		79,
		205,
		81,
		198,
		210,
		212,
		167,
		32,
		85,
		244,
		27,
		173,
		211,
		221,
		101,
		52,
		113,
		78,
		54,
		1,
		162,
		206,
		225,
		156,
		103,
		219,
		107,
		166,
		3,
		12,
		17,
		222,
		61,
		207,
		76,
		109,
		97,
		142,
		191,
		68,
		40,
		34,
		137,
		218,
		9,
		193,
		114,
		141,
		146,
		83,
		237,
		135,
		195,
		250,
		163,
		224,
		57,
		90,
		22,
		14,
		180,
		188,
		66,
		209,
		31,
		254,
		69,
		149,
		192,
		64,
		138,
		38,
		112,
		216,
		194,
		186,
		152,
		215,
		148,
		164,
		172,
		126,
		231,
		122,
		11,
		15,
		252,
		50,
		77,
		92,
		55,
		208,
		75,
		19,
		243,
		169,
		86,
		121,
		150,
		48,
		228,
		251,
		116,
		106,
		200,
		242,
		88,
		42,
		56,
		130,
		176,
		187,
		230,
		36,
		20,
		21,
		35,
		213,
		129,
		234,
		67,
		118,
		144,
		104,
		157,
		214,
		248,
		43,
		160,
		238,
		0,
		131,
		95,
		24,
		39,
		201,
		171,
		255,
		10,
		16,
		71,
		247,
		143,
		6,
		102,
		127,
		65,
		182,
		203,
		80,
		119,
		25,
		128,
		5,
		246,
		220,
		120,
		33,
		147,
		23,
		63,
		18,
		136,
		37,
		202,
		46,
		145,
		179,
		7,
		223,
		236,
		86,
		140,
		254,
		50,
		240,
		100,
		111,
		247,
		1,
		192,
		193,
		151,
		162,
		85,
		62,
		73,
		2,
		68,
		188,
		116,
		58,
		44,
		255,
		139,
		204,
		212,
		87,
		127,
		43,
		243,
		29,
		147,
		35,
		222,
		196,
		178,
		171,
		91,
		210,
		31,
		132,
		149,
		98,
		84,
		209,
		163,
		205,
		172,
		245,
		34,
		8,
		235,
		198,
		71,
		195,
		30,
		250,
		92,
		241,
		211,
		11,
		69,
		103,
		221,
		21,
		93,
		14,
		70,
		135,
		166,
		89,
		23,
		46,
		57,
		83,
		237,
		142,
		119,
		52,
		96,
		104,
		194,
		218,
		203,
		42,
		150,
		5,
		20,
		148,
		145,
		65,
		164,
		12,
		94,
		242,
		76,
		3,
		22,
		110,
		120,
		170,
		64,
		112,
		223,
		219,
		51,
		174,
		153,
		136,
		40,
		230,
		159,
		199,
		227,
		4,
		130,
		173,
		39,
		125,
		48,
		47,
		66,
		228,
		28,
		38,
		160,
		190,
		36,
		81,
		234,
		16,
		201,
		67,
		80,
		102,
		169,
		99,
		206,
		101,
		113,
		24,
		249,
		156,
		182,
		106,
		17,
		251,
		155,
		25,
		167,
		74,
		6,
		0,
		133,
		18,
		129,
		32,
		115,
		244,
		7,
		9,
		207,
		121,
		165,
		154,
		177,
		224,
		118,
		26,
		226,
		213,
		179,
		15,
		53,
		72,
		215,
		216,
		191,
		114,
		233,
		27,
		197,
		10,
		181,
		90,
		152,
		185,
		252,
		246,
		107,
		144,
		33,
		184,
		143,
		37,
		54,
		41,
		49,
		61,
		157,
		180,
		60,
		225,
		75,
		122,
		97,
		45,
		19,
		176,
		186,
		13,
		200,
		128,
		55,
		131,
		238,
		214,
		138,
		56,
		158,
		231,
		229,
		232,
		117,
		124,
		134,
		189,
		183,
		253,
		108,
		217,
		146,
		59,
		95,
		123,
		239,
		126,
		187,
		175,
		220,
		82,
		208,
		79,
		141,
		78,
		137,
		105,
		109,
		161,
		63,
		248,
		88,
		77,
		168,
		202,
		169,
		238,
		246,
		117,
		93,
		9,
		209,
		63,
		107,
		32,
		102,
		158,
		86,
		24,
		14,
		221,
		213,
		35,
		226,
		227,
		181,
		128,
		119,
		28,
		206,
		116,
		174,
		220,
		16,
		210,
		70,
		77,
		60,
		216,
		126,
		211,
		241,
		41,
		103,
		69,
		142,
		215,
		0,
		42,
		201,
		228,
		101,
		225,
		61,
		166,
		183,
		64,
		118,
		243,
		129,
		239,
		177,
		1,
		252,
		230,
		144,
		137,
		121,
		240,
		54,
		182,
		179,
		99,
		134,
		46,
		124,
		208,
		66,
		74,
		224,
		248,
		233,
		8,
		180,
		39,
		53,
		12,
		27,
		113,
		207,
		172,
		85,
		22,
		255,
		55,
		127,
		44,
		100,
		165,
		132,
		123,
		18,
		13,
		96,
		198,
		62,
		4,
		130,
		156,
		189,
		229,
		193,
		38,
		160,
		143,
		5,
		95,
		253,
		249,
		17,
		140,
		187,
		170,
		10,
		196,
		110,
		33,
		52,
		76,
		90,
		136,
		98,
		82,
		36,
		34,
		167,
		48,
		163,
		2,
		81,
		214,
		148,
		72,
		51,
		217,
		185,
		59,
		133,
		104,
		139,
		65,
		236,
		71,
		83,
		58,
		219,
		190,
		6,
		115,
		200,
		50,
		235,
		97,
		114,
		68,
		151,
		120,
		186,
		155,
		222,
		212,
		73,
		178,
		245,
		250,
		157,
		80,
		203,
		57,
		231,
		40,
		84,
		56,
		192,
		247,
		145,
		45,
		23,
		106,
		37,
		43,
		237,
		91,
		135,
		184,
		147,
		194,
		204,
		244,
		168,
		26,
		188,
		197,
		199,
		202,
		49,
		146,
		152,
		47,
		234,
		162,
		21,
		161,
		191,
		150,
		30,
		195,
		105,
		88,
		67,
		15,
		3,
		154,
		173,
		7,
		20,
		11,
		19,
		31,
		79,
		131,
		29,
		218,
		122,
		111,
		138,
		232,
		254,
		112,
		242,
		109,
		175,
		108,
		171,
		75,
		176,
		25,
		125,
		89,
		205,
		92,
		153,
		141,
		87,
		94,
		164,
		159,
		149,
		223,
		78,
		251,
		71,
		77,
		208,
		43,
		14,
		225,
		35,
		2,
		82,
		160,
		126,
		177,
		108,
		99,
		4,
		201,
		8,
		180,
		142,
		243,
		205,
		161,
		89,
		110,
		30,
		33,
		10,
		91,
		188,
		178,
		116,
		194,
		58,
		155,
		200,
		79,
		189,
		187,
		62,
		169,
		32,
		162,
		28,
		241,
		13,
		209,
		170,
		64,
		202,
		163,
		66,
		39,
		18,
		216,
		117,
		222,
		114,
		248,
		235,
		221,
		159,
		234,
		81,
		171,
		227,
		246,
		19,
		113,
		214,
		26,
		132,
		67,
		54,
		245,
		50,
		210,
		103,
		233,
		107,
		244,
		84,
		197,
		0,
		20,
		41,
		128,
		228,
		192,
		12,
		70,
		215,
		98,
		206,
		199,
		61,
		6,
		37,
		92,
		94,
		83,
		85,
		109,
		49,
		131,
		115,
		59,
		140,
		56,
		168,
		11,
		1,
		182,
		240,
		193,
		218,
		150,
		38,
		15,
		135,
		90,
		141,
		146,
		138,
		134,
		154,
		3,
		52,
		158,
		104,
		176,
		254,
		220,
		165,
		65,
		231,
		74,
		80,
		125,
		252,
		120,
		23,
		78,
		153,
		179,
		239,
		106,
		24,
		118,
		164,
		63,
		46,
		217,
		9,
		16,
		224,
		105,
		40,
		152,
		101,
		127,
		196,
		144,
		72,
		166,
		48,
		119,
		111,
		236,
		207,
		129,
		151,
		68,
		242,
		185,
		255,
		7,
		44,
		25,
		238,
		133,
		76,
		186,
		123,
		122,
		137,
		75,
		223,
		212,
		87,
		237,
		55,
		69,
		167,
		157,
		27,
		5,
		139,
		148,
		249,
		95,
		57,
		22,
		156,
		198,
		36,
		124,
		88,
		191,
		34,
		51,
		147,
		93,
		100,
		96,
		136,
		21,
		195,
		17,
		251,
		203,
		247,
		184,
		173,
		213,
		31,
		183,
		229,
		73,
		175,
		47,
		42,
		250,
		112,
		145,
		45,
		190,
		219,
		211,
		121,
		97,
		86,
		53,
		204,
		143,
		172,
		149,
		130,
		232,
		253,
		60,
		29,
		226,
		102,
		174,
		230,
		181,
		20,
		190,
		186,
		35,
		170,
		166,
		173,
		178,
		167,
		122,
		6,
		47,
		250,
		182,
		208,
		225,
		33,
		150,
		136,
		43,
		172,
		24,
		83,
		27,
		17,
		163,
		117,
		77,
		126,
		115,
		5,
		124,
		29,
		38,
		238,
		231,
		247,
		66,
		44,
		102,
		196,
		224,
		9,
		160,
		32,
		52,
		116,
		229,
		75,
		212,
		71,
		201,
		18,
		242,
		22,
		213,
		164,
		99,
		246,
		58,
		51,
		81,
		195,
		214,
		113,
		139,
		191,
		202,
		203,
		253,
		82,
		216,
		85,
		254,
		50,
		248,
		98,
		7,
		234,
		131,
		138,
		96,
		45,
		241,
		60,
		209,
		0,
		130,
		30,
		137,
		157,
		155,
		232,
		111,
		26,
		187,
		84,
		226,
		156,
		146,
		42,
		123,
		62,
		1,
		121,
		78,
		237,
		129,
		174,
		211,
		40,
		148,
		36,
		233,
		76,
		67,
		94,
		145,
		114,
		128,
		3,
		34,
		46,
		193,
		240,
		11,
		103,
		109,
		198,
		149,
		70,
		142,
		61,
		194,
		221,
		28,
		162,
		200,
		140,
		181,
		236,
		175,
		118,
		21,
		89,
		65,
		251,
		243,
		13,
		158,
		80,
		177,
		10,
		218,
		143,
		15,
		197,
		105,
		63,
		151,
		141,
		245,
		215,
		152,
		219,
		235,
		227,
		49,
		168,
		53,
		68,
		64,
		179,
		125,
		2,
		19,
		120,
		159,
		4,
		92,
		188,
		230,
		25,
		54,
		217,
		127,
		171,
		180,
		59,
		37,
		135,
		189,
		23,
		101,
		119,
		205,
		255,
		244,
		169,
		107,
		91,
		90,
		108,
		154,
		206,
		165,
		12,
		57,
		223,
		39,
		210,
		153,
		183,
		100,
		239,
		161,
		79,
		204,
		16,
		87,
		104,
		134,
		228,
		176,
		69,
		95,
		8,
		184,
		192,
		73,
		41,
		48,
		14,
		249,
		132,
		31,
		56,
		86,
		207,
		74,
		185,
		147,
		55,
		110,
		220,
		88,
		112,
		93,
		199,
		106,
		133,
		97,
		222,
		252,
		72,
		144,
		98,
		108,
		18,
		164,
		241,
		206,
		139,
		218,
		113,
		29,
		190,
		137,
		100,
		216,
		35,
		94,
		179,
		188,
		25,
		212,
		112,
		130,
		97,
		174,
		49,
		222,
		210,
		243,
		157,
		151,
		251,
		0,
		58,
		79,
		123,
		129,
		40,
		162,
		13,
		59,
		8,
		194,
		14,
		165,
		115,
		26,
		247,
		146,
		1,
		221,
		144,
		122,
		114,
		240,
		33,
		204,
		107,
		109,
		121,
		238,
		75,
		234,
		159,
		24,
		23,
		30,
		214,
		237,
		150,
		220,
		178,
		7,
		80,
		249,
		16,
		52,
		21,
		132,
		196,
		208,
		57,
		183,
		36,
		187,
		37,
		230,
		2,
		226,
		202,
		6,
		147,
		84,
		38,
		51,
		161,
		195,
		211,
		74,
		78,
		228,
		66,
		93,
		86,
		90,
		223,
		246,
		138,
		87,
		17,
		32,
		70,
		10,
		219,
		120,
		102,
		209,
		235,
		163,
		232,
		92,
		189,
		133,
		83,
		225,
		140,
		245,
		131,
		142,
		72,
		248,
		175,
		181,
		192,
		217,
		185,
		48,
		239,
		116,
		9,
		254,
		186,
		63,
		166,
		200,
		158,
		199,
		99,
		73,
		173,
		128,
		168,
		44,
		145,
		117,
		154,
		55,
		96,
		184,
		12,
		46,
		61,
		135,
		149,
		231,
		155,
		89,
		4,
		15,
		106,
		156,
		170,
		171,
		201,
		252,
		85,
		62,
		105,
		34,
		215,
		47,
		81,
		31,
		148,
		71,
		167,
		224,
		60,
		191,
		64,
		20,
		118,
		152,
		104,
		39,
		5,
		125,
		193,
		19,
		27,
		43,
		176,
		180,
		197,
		88,
		227,
		242,
		141,
		67,
		172,
		244,
		111,
		136,
		198,
		233,
		22,
		76,
		68,
		91,
		143,
		41,
		77,
		119,
		213,
		203,
		126,
		182,
		101,
		54,
		236,
		45,
		50,
		205,
		69,
		124,
		56,
		82,
		229,
		134,
		95,
		28,
		3,
		11,
		177,
		169,
		65,
		160,
		110,
		253,
		255,
		127,
		42,
		250,
		103,
		207,
		153,
		53,
		157,
		79,
		71,
		119,
		52,
		123,
		89,
		33,
		191,
		174,
		209,
		31,
		236,
		232,
		153,
		4,
		154,
		181,
		74,
		16,
		240,
		168,
		51,
		212,
		17,
		43,
		137,
		151,
		24,
		7,
		211,
		117,
		176,
		113,
		110,
		145,
		34,
		234,
		57,
		106,
		185,
		218,
		3,
		64,
		25,
		32,
		100,
		14,
		29,
		252,
		50,
		161,
		95,
		87,
		237,
		245,
		59,
		147,
		197,
		105,
		163,
		35,
		118,
		166,
		156,
		133,
		229,
		108,
		20,
		164,
		243,
		233,
		230,
		99,
		250,
		148,
		179,
		40,
		85,
		162,
		241,
		220,
		244,
		112,
		194,
		155,
		63,
		21,
		60,
		228,
		80,
		114,
		205,
		41,
		198,
		107,
		199,
		5,
		88,
		83,
		97,
		219,
		201,
		187,
		149,
		160,
		9,
		98,
		54,
		192,
		246,
		247,
		13,
		67,
		200,
		27,
		53,
		126,
		139,
		115,
		28,
		72,
		42,
		196,
		251,
		188,
		96,
		227,
		202,
		128,
		238,
		91,
		75,
		66,
		138,
		177,
		73,
		216,
		152,
		140,
		12,
		165,
		76,
		104,
		121,
		186,
		94,
		190,
		101,
		235,
		120,
		231,
		122,
		111,
		253,
		159,
		150,
		90,
		207,
		8,
		30,
		1,
		10,
		6,
		143,
		22,
		18,
		184,
		77,
		124,
		26,
		86,
		131,
		170,
		214,
		11,
		183,
		255,
		180,
		0,
		135,
		36,
		58,
		141,
		208,
		169,
		223,
		210,
		225,
		217,
		15,
		189,
		173,
		146,
		215,
		134,
		62,
		48,
		78,
		248,
		56,
		132,
		127,
		2,
		45,
		65,
		226,
		213,
		44,
		222,
		61,
		242,
		239,
		224,
		69,
		136,
		193,
		203,
		167,
		92,
		109,
		130,
		142,
		175,
		116,
		254,
		81,
		103,
		102,
		19,
		39,
		221,
		47,
		70,
		171,
		206,
		84,
		158,
		82,
		249,
		46,
		172,
		125,
		144,
		93,
		129,
		204,
		38,
		23,
		182,
		195,
		68,
		55,
		49,
		37,
		178,
		164,
		133,
		71,
		168,
		141,
		118,
		235,
		225,
		111,
		162,
		197,
		202,
		23,
		216,
		6,
		244,
		200,
		255,
		7,
		107,
		85,
		40,
		18,
		174,
		100,
		210,
		20,
		26,
		253,
		172,
		135,
		184,
		15,
		152,
		29,
		27,
		233,
		110,
		61,
		156,
		230,
		12,
		119,
		171,
		87,
		186,
		4,
		134,
		120,
		211,
		126,
		180,
		129,
		228,
		5,
		108,
		13,
		247,
		76,
		57,
		123,
		77,
		94,
		212,
		229,
		34,
		188,
		112,
		215,
		181,
		80,
		69,
		82,
		205,
		79,
		193,
		116,
		148,
		83,
		144,
		102,
		66,
		38,
		143,
		178,
		166,
		99,
		242,
		160,
		155,
		97,
		104,
		196,
		113,
		224,
		170,
		37,
		151,
		203,
		243,
		245,
		248,
		250,
		131,
		16,
		167,
		173,
		14,
		158,
		42,
		157,
		213,
		252,
		33,
		169,
		128,
		48,
		124,
		103,
		86,
		56,
		146,
		165,
		60,
		32,
		44,
		52,
		43,
		236,
		65,
		231,
		3,
		122,
		88,
		22,
		206,
		21,
		63,
		232,
		177,
		222,
		90,
		219,
		246,
		127,
		136,
		153,
		2,
		208,
		190,
		204,
		73,
		217,
		195,
		62,
		142,
		207,
		70,
		182,
		175,
		74,
		201,
		209,
		150,
		0,
		238,
		54,
		98,
		161,
		89,
		31,
		84,
		226,
		49,
		39,
		105,
		220,
		221,
		28,
		234,
		35,
		72,
		191,
		138,
		227,
		145,
		75,
		241,
		114,
		121,
		237,
		47,
		249,
		95,
		50,
		45,
		163,
		189,
		59,
		1,
		25,
		254,
		218,
		130,
		96,
		58,
		176,
		159,
		179,
		46,
		198,
		194,
		251,
		53,
		149,
		132,
		115,
		11,
		30,
		81,
		109,
		93,
		183,
		101,
		92,
		140,
		137,
		9,
		239,
		67,
		17,
		185,
		199,
		223,
		117,
		125,
		24,
		139,
		55,
		214,
		78,
		36,
		51,
		10,
		41,
		106,
		147,
		240,
		19,
		64,
		8,
		192,
		68,
		187,
		154,
		91,
		188,
		210,
		160,
		37,
		19,
		228,
		245,
		110,
		163,
		42,
		218,
		195,
		181,
		175,
		82,
		226,
		22,
		52,
		122,
		162,
		128,
		45,
		139,
		111,
		178,
		54,
		183,
		154,
		121,
		83,
		132,
		221,
		79,
		36,
		211,
		230,
		176,
		177,
		112,
		134,
		30,
		21,
		129,
		67,
		143,
		253,
		39,
		157,
		108,
		130,
		90,
		14,
		38,
		165,
		189,
		250,
		142,
		93,
		75,
		5,
		205,
		53,
		115,
		56,
		151,
		89,
		249,
		232,
		223,
		66,
		170,
		174,
		1,
		49,
		219,
		9,
		31,
		103,
		114,
		61,
		207,
		209,
		87,
		109,
		149,
		51,
		94,
		65,
		12,
		86,
		220,
		243,
		117,
		146,
		182,
		238,
		69,
		6,
		255,
		156,
		34,
		72,
		95,
		102,
		40,
		215,
		246,
		55,
		127,
		44,
		100,
		172,
		131,
		47,
		125,
		213,
		48,
		224,
		229,
		101,
		116,
		231,
		91,
		186,
		171,
		179,
		25,
		17,
		57,
		68,
		126,
		194,
		164,
		147,
		107,
		7,
		145,
		192,
		235,
		212,
		8,
		190,
		120,
		118,
		225,
		26,
		135,
		141,
		200,
		233,
		43,
		196,
		123,
		180,
		106,
		152,
		3,
		206,
		169,
		166,
		237,
		136,
		105,
		0,
		20,
		191,
		18,
		216,
		23,
		33,
		50,
		184,
		97,
		155,
		32,
		85,
		133,
		2,
		81,
		240,
		99,
		244,
		113,
		119,
		59,
		214,
		104,
		234,
		138,
		96,
		27,
		199,
		222,
		202,
		15,
		158,
		10,
		46,
		74,
		227,
		168,
		29,
		140,
		198,
		204,
		247,
		13,
		4,
		187,
		217,
		60,
		41,
		137,
		78,
		208,
		28,
		24,
		248,
		63,
		252,
		62,
		161,
		35,
		173,
		92,
		16,
		11,
		58,
		144,
		77,
		197,
		236,
		76,
		64,
		88,
		71,
		84,
		254,
		201,
		80,
		153,
		148,
		150,
		239,
		73,
		251,
		167,
		159,
		242,
		70,
		241,
		185,
		124,
		203,
		193,
		98,
		139,
		16,
		109,
		154,
		222,
		91,
		194,
		172,
		44,
		156,
		203,
		209,
		164,
		189,
		221,
		84,
		245,
		17,
		254,
		83,
		4,
		220,
		104,
		74,
		250,
		163,
		7,
		45,
		201,
		228,
		204,
		72,
		14,
		248,
		206,
		207,
		173,
		152,
		49,
		90,
		89,
		227,
		241,
		131,
		255,
		61,
		96,
		107,
		195,
		132,
		88,
		219,
		36,
		112,
		18,
		252,
		13,
		70,
		179,
		75,
		53,
		123,
		240,
		35,
		212,
		208,
		161,
		60,
		135,
		150,
		233,
		39,
		12,
		67,
		97,
		25,
		165,
		119,
		127,
		79,
		32,
		63,
		235,
		77,
		41,
		19,
		177,
		175,
		200,
		144,
		11,
		236,
		162,
		141,
		114,
		40,
		33,
		24,
		92,
		54,
		129,
		226,
		59,
		120,
		26,
		210,
		1,
		82,
		136,
		73,
		86,
		169,
		155,
		27,
		78,
		158,
		3,
		171,
		253,
		81,
		103,
		111,
		213,
		205,
		37,
		196,
		10,
		153,
		21,
		121,
		218,
		237,
		0,
		188,
		71,
		58,
		6,
		8,
		118,
		192,
		149,
		170,
		239,
		190,
		85,
		186,
		182,
		151,
		249,
		243,
		159,
		100,
		215,
		216,
		125,
		176,
		20,
		230,
		5,
		202,
		108,
		166,
		106,
		193,
		23,
		126,
		147,
		246,
		94,
		43,
		31,
		229,
		76,
		198,
		105,
		95,
		15,
		9,
		29,
		138,
		47,
		142,
		251,
		124,
		101,
		185,
		244,
		30,
		22,
		148,
		69,
		168,
		52,
		157,
		116,
		80,
		113,
		224,
		160,
		180,
		115,
		122,
		178,
		137,
		242,
		184,
		214,
		99,
		174,
		98,
		247,
		48,
		66,
		87,
		197,
		167,
		93,
		211,
		64,
		223,
		65,
		130,
		102,
		134,
		187,
		146,
		238,
		51,
		117,
		68,
		34,
		110,
		183,
		46,
		42,
		128,
		38,
		57,
		50,
		62,
		217,
		225,
		55,
		133,
		232,
		145,
		231,
		234,
		191,
		28,
		2,
		181,
		143,
		199,
		140,
		56,
		210,
		219,
		33,
		26,
		16,
		90,
		203,
		126,
		53,
		156,
		248,
		220,
		72,
		217,
		28,
		8,
		123,
		245,
		119,
		232,
		42,
		233,
		46,
		206,
		202,
		6,
		152,
		95,
		255,
		234,
		15,
		109,
		134,
		31,
		40,
		130,
		145,
		142,
		150,
		154,
		58,
		19,
		155,
		70,
		236,
		221,
		198,
		138,
		180,
		23,
		29,
		170,
		111,
		39,
		144,
		36,
		73,
		113,
		45,
		159,
		57,
		64,
		66,
		79,
		160,
		174,
		104,
		222,
		2,
		61,
		22,
		71,
		209,
		189,
		69,
		114,
		20,
		168,
		146,
		239,
		112,
		127,
		24,
		213,
		78,
		188,
		98,
		173,
		18,
		253,
		63,
		30,
		91,
		81,
		204,
		55,
		131,
		246,
		77,
		183,
		110,
		228,
		247,
		193,
		14,
		196,
		105,
		194,
		214,
		191,
		94,
		59,
		17,
		205,
		182,
		92,
		60,
		190,
		0,
		237,
		161,
		167,
		34,
		181,
		38,
		135,
		212,
		83,
		235,
		164,
		177,
		201,
		223,
		13,
		231,
		215,
		120,
		124,
		148,
		9,
		62,
		47,
		143,
		65,
		56,
		96,
		68,
		163,
		37,
		10,
		128,
		218,
		151,
		136,
		229,
		67,
		187,
		129,
		7,
		25,
		122,
		178,
		250,
		169,
		225,
		32,
		1,
		254,
		176,
		137,
		158,
		244,
		74,
		41,
		208,
		147,
		199,
		207,
		101,
		125,
		108,
		141,
		49,
		162,
		179,
		51,
		54,
		230,
		3,
		171,
		249,
		85,
		52,
		132,
		121,
		99,
		21,
		12,
		252,
		117,
		184,
		35,
		50,
		197,
		243,
		118,
		4,
		106,
		11,
		82,
		133,
		175,
		76,
		97,
		224,
		100,
		185,
		93,
		251,
		86,
		116,
		172,
		226,
		192,
		75,
		241,
		43,
		89,
		149,
		87,
		195,
		200,
		80,
		166,
		103,
		102,
		48,
		5,
		242,
		153,
		238,
		165,
		227,
		27,
		211,
		157,
		139,
		88,
		44,
		107,
		115,
		240,
		216,
		140,
		84,
		186,
		44,
		84,
		65,
		14,
		50,
		2,
		232,
		58,
		236,
		113,
		153,
		157,
		164,
		106,
		202,
		219,
		70,
		161,
		133,
		221,
		63,
		101,
		239,
		192,
		166,
		0,
		109,
		114,
		252,
		226,
		100,
		94,
		76,
		31,
		87,
		159,
		27,
		228,
		197,
		4,
		17,
		123,
		108,
		85,
		118,
		53,
		204,
		175,
		152,
		128,
		42,
		34,
		71,
		212,
		104,
		137,
		3,
		211,
		214,
		86,
		176,
		28,
		78,
		230,
		134,
		156,
		97,
		209,
		144,
		25,
		233,
		240,
		32,
		215,
		198,
		93,
		143,
		225,
		147,
		22,
		74,
		96,
		183,
		238,
		129,
		5,
		132,
		169,
		179,
		30,
		184,
		92,
		37,
		7,
		73,
		145,
		188,
		206,
		20,
		174,
		45,
		38,
		178,
		112,
		131,
		130,
		67,
		181,
		124,
		23,
		224,
		213,
		254,
		6,
		64,
		11,
		189,
		110,
		120,
		54,
		21,
		150,
		142,
		201,
		95,
		177,
		105,
		61,
		255,
		196,
		62,
		55,
		155,
		46,
		191,
		245,
		57,
		29,
		121,
		208,
		237,
		249,
		60,
		173,
		13,
		146,
		16,
		158,
		43,
		203,
		12,
		207,
		186,
		125,
		227,
		47,
		136,
		234,
		15,
		26,
		103,
		205,
		250,
		99,
		127,
		115,
		107,
		116,
		163,
		126,
		246,
		223,
		111,
		35,
		56,
		9,
		79,
		248,
		242,
		81,
		193,
		117,
		194,
		138,
		122,
		200,
		148,
		172,
		170,
		167,
		165,
		220,
		59,
		141,
		75,
		69,
		162,
		243,
		216,
		231,
		151,
		160,
		88,
		52,
		10,
		119,
		77,
		241,
		48,
		253,
		154,
		149,
		72,
		135,
		89,
		171,
		251,
		218,
		24,
		247,
		210,
		41,
		180,
		190,
		82,
		168,
		19,
		102,
		36,
		18,
		1,
		139,
		39,
		140,
		33,
		235,
		222,
		187,
		90,
		51,
		185,
		83,
		40,
		244,
		8,
		229,
		91,
		217,
		80,
		199,
		66,
		68,
		182,
		49,
		98,
		195,
		185,
		193,
		212,
		155,
		167,
		151,
		125,
		175,
		121,
		228,
		12,
		8,
		49,
		255,
		95,
		78,
		211,
		52,
		16,
		72,
		170,
		240,
		122,
		85,
		51,
		149,
		248,
		231,
		105,
		119,
		241,
		203,
		217,
		138,
		194,
		10,
		142,
		113,
		80,
		145,
		132,
		238,
		249,
		192,
		227,
		160,
		89,
		58,
		13,
		21,
		191,
		183,
		210,
		65,
		253,
		28,
		150,
		70,
		67,
		195,
		37,
		137,
		219,
		115,
		19,
		9,
		244,
		68,
		5,
		140,
		124,
		101,
		181,
		66,
		83,
		200,
		26,
		116,
		6,
		131,
		223,
		245,
		34,
		123,
		20,
		144,
		17,
		60,
		38,
		139,
		45,
		201,
		176,
		146,
		220,
		4,
		41,
		91,
		129,
		59,
		184,
		179,
		39,
		229,
		22,
		23,
		214,
		32,
		233,
		130,
		117,
		64,
		107,
		147,
		213,
		158,
		40,
		251,
		237,
		163,
		128,
		3,
		27,
		92,
		202,
		36,
		252,
		168,
		106,
		81,
		171,
		162,
		14,
		187,
		42,
		96,
		172,
		136,
		236,
		69,
		120,
		108,
		169,
		56,
		152,
		7,
		133,
		11,
		190,
		94,
		153,
		90,
		47,
		232,
		118,
		186,
		29,
		127,
		154,
		143,
		242,
		88,
		111,
		246,
		234,
		230,
		254,
		225,
		54,
		235,
		99,
		74,
		250,
		182,
		173,
		156,
		218,
		109,
		103,
		196,
		84,
		224,
		87,
		31,
		239,
		93,
		1,
		57,
		63,
		50,
		48,
		73,
		174,
		24,
		222,
		208,
		55,
		102,
		77,
		114,
		2,
		53,
		205,
		161,
		159,
		226,
		216,
		100,
		165,
		104,
		15,
		0,
		221,
		18,
		204,
		62,
		110,
		79,
		141,
		98,
		71,
		188,
		33,
		43,
		199,
		61,
		134,
		243,
		177,
		135,
		148,
		30,
		178,
		25,
		180,
		126,
		75,
		46,
		207,
		166,
		44,
		198,
		189,
		97,
		157,
		112,
		206,
		76,
		197,
		82,
		215,
		209,
		35,
		164,
		247,
		86,
		4,
		125,
		11,
		6,
		53,
		13,
		219,
		105,
		99,
		43,
		96,
		212,
		83,
		240,
		238,
		89,
		153,
		168,
		206,
		130,
		87,
		126,
		2,
		223,
		202,
		213,
		222,
		210,
		91,
		194,
		198,
		108,
		174,
		187,
		41,
		75,
		66,
		142,
		27,
		220,
		173,
		110,
		138,
		106,
		177,
		63,
		172,
		51,
		157,
		12,
		76,
		88,
		216,
		113,
		152,
		188,
		30,
		84,
		58,
		143,
		159,
		150,
		94,
		101,
		195,
		98,
		23,
		144,
		227,
		229,
		241,
		102,
		250,
		120,
		169,
		68,
		137,
		85,
		24,
		242,
		251,
		146,
		127,
		26,
		128,
		74,
		134,
		45,
		160,
		42,
		133,
		179,
		178,
		199,
		243,
		9,
		21,
		31,
		115,
		136,
		185,
		86,
		90,
		123,
		248,
		10,
		233,
		38,
		59,
		52,
		145,
		92,
		236,
		80,
		171,
		214,
		249,
		149,
		54,
		1,
		121,
		70,
		3,
		82,
		234,
		228,
		154,
		44,
		239,
		71,
		17,
		189,
		119,
		247,
		162,
		114,
		201,
		40,
		230,
		117,
		139,
		131,
		57,
		33,
		109,
		14,
		215,
		148,
		205,
		244,
		176,
		218,
		100,
		165,
		186,
		69,
		246,
		62,
		237,
		190,
		197,
		255,
		93,
		67,
		204,
		211,
		7,
		161,
		78,
		97,
		158,
		196,
		36,
		124,
		231,
		0,
		107,
		122,
		5,
		203,
		56,
		60,
		77,
		208,
		73,
		155,
		147,
		163,
		224,
		175,
		141,
		245,
		200,
		156,
		254,
		16,
		47,
		104,
		180,
		55,
		217,
		151,
		28,
		207,
		225,
		170,
		95,
		167,
		65,
		116,
		221,
		182,
		226,
		20,
		34,
		35,
		19,
		209,
		140,
		135,
		181,
		15,
		29,
		111,
		232,
		48,
		132,
		166,
		25,
		253,
		18,
		191,
		37,
		8,
		32,
		164,
		22,
		79,
		235,
		193,
		50,
		183,
		46,
		64,
		103,
		252,
		129,
		118,
		72,
		81,
		49,
		184,
		192,
		112,
		39,
		61,
		74,
		95,
		205,
		175,
		166,
		106,
		255,
		56,
		73,
		138,
		110,
		142,
		85,
		219,
		72,
		215,
		121,
		232,
		168,
		188,
		60,
		149,
		124,
		88,
		250,
		176,
		222,
		107,
		123,
		114,
		186,
		129,
		224,
		153,
		239,
		226,
		209,
		233,
		63,
		141,
		135,
		207,
		132,
		48,
		183,
		20,
		10,
		189,
		125,
		76,
		42,
		102,
		179,
		154,
		230,
		59,
		46,
		49,
		58,
		54,
		191,
		38,
		34,
		136,
		241,
		251,
		151,
		108,
		93,
		178,
		190,
		159,
		28,
		238,
		13,
		194,
		223,
		208,
		117,
		184,
		8,
		180,
		79,
		50,
		29,
		113,
		210,
		229,
		157,
		162,
		231,
		182,
		14,
		0,
		126,
		200,
		39,
		134,
		243,
		116,
		7,
		1,
		21,
		130,
		30,
		156,
		77,
		160,
		109,
		177,
		252,
		22,
		31,
		118,
		155,
		254,
		100,
		174,
		98,
		201,
		68,
		206,
		97,
		87,
		86,
		35,
		23,
		237,
		33,
		27,
		185,
		167,
		40,
		55,
		227,
		69,
		170,
		133,
		122,
		32,
		192,
		152,
		3,
		228,
		143,
		158,
		225,
		47,
		220,
		216,
		169,
		52,
		173,
		127,
		119,
		71,
		4,
		75,
		105,
		17,
		11,
		163,
		245,
		89,
		147,
		19,
		70,
		150,
		45,
		204,
		2,
		145,
		111,
		103,
		221,
		197,
		137,
		234,
		51,
		112,
		41,
		16,
		84,
		62,
		128,
		65,
		94,
		161,
		18,
		218,
		9,
		90,
		12,
		212,
		96,
		66,
		253,
		25,
		246,
		91,
		193,
		236,
		196,
		64,
		242,
		171,
		15,
		37,
		214,
		83,
		202,
		164,
		131,
		24,
		101,
		146,
		172,
		181,
		213,
		92,
		36,
		148,
		195,
		217,
		44,
		120,
		26,
		244,
		203,
		140,
		80,
		211,
		61,
		115,
		248,
		43,
		5,
		78,
		187,
		67,
		165,
		144,
		57,
		82,
		6,
		240,
		198,
		199,
		247,
		53,
		104,
		99,
		81,
		235,
		249,
		139,
		178,
		241,
		40,
		75,
		252,
		150,
		210,
		235,
		99,
		156,
		131,
		66,
		152,
		203,
		24,
		208,
		155,
		55,
		97,
		201,
		84,
		132,
		209,
		81,
		83,
		192,
		14,
		239,
		7,
		31,
		165,
		173,
		237,
		35,
		92,
		77,
		246,
		107,
		26,
		30,
		133,
		181,
		189,
		111,
		211,
		171,
		137,
		198,
		101,
		123,
		217,
		227,
		135,
		33,
		245,
		234,
		226,
		184,
		71,
		104,
		38,
		193,
		90,
		2,
		144,
		251,
		82,
		103,
		5,
		4,
		50,
		196,
		161,
		170,
		247,
		53,
		73,
		59,
		41,
		147,
		54,
		216,
		186,
		238,
		17,
		146,
		78,
		9,
		233,
		58,
		177,
		255,
		129,
		121,
		140,
		199,
		102,
		8,
		145,
		20,
		80,
		167,
		218,
		65,
		158,
		23,
		119,
		110,
		27,
		1,
		86,
		230,
		128,
		162,
		22,
		206,
		153,
		52,
		219,
		63,
		130,
		6,
		46,
		3,
		231,
		205,
		105,
		48,
		164,
		232,
		142,
		191,
		249,
		36,
		88,
		113,
		244,
		248,
		243,
		236,
		74,
		224,
		228,
		125,
		32,
		45,
		91,
		34,
		79,
		253,
		43,
		19,
		242,
		70,
		13,
		69,
		127,
		200,
		214,
		117,
		126,
		106,
		42,
		187,
		154,
		190,
		87,
		254,
		169,
		28,
		114,
		56,
		67,
		120,
		176,
		185,
		109,
		15,
		157,
		136,
		250,
		61,
		168,
		100,
		76,
		172,
		72,
		139,
		21,
		138,
		25,
		151,
		60,
		89,
		180,
		221,
		11,
		160,
		108,
		166,
		149,
		163,
		12,
		134,
		47,
		213,
		225,
		148,
		182,
		49,
		68,
		229,
		64,
		215,
		195,
		197,
		98,
		143,
		94,
		220,
		212,
		62,
		115,
		175,
		240,
		141,
		118,
		202,
		39,
		16,
		179,
		223,
		116,
		37,
		96,
		95,
		10,
		188,
		194,
		204,
		174,
		85,
		57,
		51,
		93,
		124,
		112,
		159,
		0,
		207,
		44,
		222,
		122,
		183,
		18,
		29,
		117,
		135,
		89,
		150,
		75,
		68,
		35,
		238,
		96,
		106,
		247,
		12,
		41,
		198,
		4,
		37,
		57,
		6,
		45,
		124,
		155,
		149,
		83,
		229,
		47,
		147,
		169,
		212,
		234,
		134,
		126,
		73,
		7,
		133,
		59,
		214,
		42,
		246,
		141,
		103,
		29,
		188,
		239,
		104,
		154,
		156,
		25,
		142,
		85,
		223,
		204,
		250,
		184,
		205,
		118,
		140,
		237,
		132,
		101,
		0,
		53,
		255,
		82,
		249,
		17,
		210,
		21,
		245,
		64,
		206,
		76,
		211,
		196,
		209,
		52,
		86,
		241,
		61,
		163,
		100,
		43,
		97,
		240,
		69,
		233,
		224,
		26,
		33,
		115,
		226,
		39,
		51,
		14,
		167,
		195,
		231,
		84,
		28,
		171,
		31,
		143,
		44,
		38,
		145,
		2,
		123,
		121,
		116,
		114,
		74,
		22,
		164,
		170,
		181,
		173,
		161,
		189,
		36,
		19,
		185,
		215,
		230,
		253,
		177,
		1,
		40,
		160,
		125,
		119,
		90,
		219,
		95,
		48,
		105,
		190,
		148,
		79,
		151,
		217,
		251,
		130,
		102,
		192,
		109,
		46,
		55,
		199,
		78,
		15,
		191,
		66,
		88,
		200,
		77,
		63,
		81,
		131,
		24,
		9,
		254,
		232,
		166,
		176,
		99,
		213,
		158,
		216,
		32,
		227,
		183,
		111,
		129,
		23,
		80,
		72,
		203,
		174,
		108,
		248,
		243,
		112,
		202,
		16,
		98,
		11,
		62,
		201,
		162,
		107,
		157,
		92,
		93,
		30,
		49,
		187,
		225,
		3,
		91,
		127,
		152,
		128,
		186,
		60,
		34,
		172,
		179,
		222,
		120,
		228,
		54,
		220,
		236,
		208,
		159,
		138,
		242,
		5,
		20,
		180,
		122,
		67,
		71,
		175,
		50,
		87,
		182,
		10,
		153,
		252,
		244,
		94,
		70,
		56,
		144,
		194,
		110,
		136,
		8,
		13,
		221,
		218,
		27,
		58,
		197,
		65,
		137,
		193,
		146,
		113,
		18,
		235,
		168,
		139,
		178,
		165,
		207
	};

	private Class41()
	{
	}

	public static Class41 smethod_0()
	{
		return class41_0;
	}

	public byte[] method_0(ref byte[] byte_2)
	{
		checked
		{
			uint num = (uint)byte_2.Length;
			byte[] byte_3 = new byte[16];
			byte[] byte_4 = new byte[16];
			uint num2 = num >> 4;
			uint num3 = (uint)(unchecked((long)num) & 0xFL);
			uint num4 = (uint)(unchecked((long)num2) - 1L);
			uint uint_;
			for (uint num5 = 0u; num5 <= num4; num5++)
			{
				uint_ = num5 << 4;
				method_3(ref byte_2, ref uint_, ref byte_4);
				method_1(ref byte_4);
			}
			Buffer.BlockCopy(byte_2, (int)(num2 << 4), byte_3, 0, (int)num3);
			byte_3[(int)num3] = 128;
			uint_ = 0u;
			method_3(ref byte_3, ref uint_, ref byte_4);
			method_1(ref byte_4);
			return byte_4;
		}
	}

	private void method_1(ref byte[] byte_2)
	{
		uint uint_ = 0u;
		method_2(ref byte_2, ref uint_);
		uint num = 1u;
		do
		{
			method_5(ref byte_2);
			method_6(ref byte_2);
			method_4(ref byte_2);
			method_5(ref byte_2);
			method_6(ref byte_2);
			uint_ = num << 12;
			method_2(ref byte_2, ref uint_);
			num = checked(num + 1u);
		}
		while (num <= 5);
		method_5(ref byte_2);
	}

	private void method_2(ref byte[] byte_2, ref uint uint_0)
	{
		uint num = 0u;
		checked
		{
			do
			{
				byte_2[(int)num] = byte_1[(int)(byte_2[(int)num] ^ uint_0 ^ (num << 8))];
				num++;
			}
			while (num <= 15);
		}
	}

	private void method_3(ref byte[] byte_2, ref uint uint_0, ref byte[] byte_3)
	{
		uint num = 0u;
		do
		{
			byte_3[checked((int)num)] = (byte)checked(byte_3[(int)num] ^ byte_2[(int)(num + uint_0)]);
			num = checked(num + 1u);
		}
		while (num <= 15);
	}

	private void method_4(ref byte[] byte_2)
	{
		uint num = 0u;
		checked
		{
			do
			{
				byte_2[(int)num] = byte_0[byte_2[(int)num]];
				num++;
			}
			while (num <= 15);
		}
	}

	private void method_5(ref byte[] byte_2)
	{
		byte[] array = new byte[16];
		uint num = 0u;
		checked
		{
			do
			{
				array[(int)num] = byte_2[(int)num];
				num++;
			}
			while (num <= 15);
			byte_2[0] = array[0];
			byte_2[1] = array[5];
			byte_2[2] = array[10];
			byte_2[3] = array[15];
			byte_2[4] = array[4];
			byte_2[5] = array[9];
			byte_2[6] = array[14];
			byte_2[7] = array[3];
			byte_2[8] = array[8];
			byte_2[9] = array[13];
			byte_2[10] = array[2];
			byte_2[11] = array[7];
			byte_2[12] = array[12];
			byte_2[13] = array[1];
			byte_2[14] = array[6];
			byte_2[15] = array[11];
		}
	}

	private void method_6(ref byte[] byte_2)
	{
		byte[] array = new byte[16];
		uint num = 0u;
		checked
		{
			do
			{
				array[(int)num] = byte_2[(int)num];
				num++;
			}
			while (num <= 15);
		}
		byte_2[0] = (byte)(method_7(ref array[0]) ^ method_8(ref array[1]) ^ array[2] ^ array[3]);
		byte_2[1] = (byte)(array[0] ^ method_7(ref array[1]) ^ method_8(ref array[2]) ^ array[3]);
		byte_2[2] = (byte)(array[0] ^ array[1] ^ method_7(ref array[2]) ^ method_8(ref array[3]));
		byte_2[3] = (byte)(method_8(ref array[0]) ^ array[1] ^ array[2] ^ method_7(ref array[3]));
		byte_2[4] = (byte)(method_7(ref array[4]) ^ method_8(ref array[5]) ^ array[6] ^ array[7]);
		byte_2[5] = (byte)(array[4] ^ method_7(ref array[5]) ^ method_8(ref array[6]) ^ array[7]);
		byte_2[6] = (byte)(array[4] ^ array[5] ^ method_7(ref array[6]) ^ method_8(ref array[7]));
		byte_2[7] = (byte)(method_8(ref array[4]) ^ array[5] ^ array[6] ^ method_7(ref array[7]));
		byte_2[8] = (byte)(method_7(ref array[8]) ^ method_8(ref array[9]) ^ array[10] ^ array[11]);
		byte_2[9] = (byte)(array[8] ^ method_7(ref array[9]) ^ method_8(ref array[10]) ^ array[11]);
		byte_2[10] = (byte)(array[8] ^ array[9] ^ method_7(ref array[10]) ^ method_8(ref array[11]));
		byte_2[11] = (byte)(method_8(ref array[8]) ^ array[9] ^ array[10] ^ method_7(ref array[11]));
		byte_2[12] = (byte)(method_7(ref array[12]) ^ method_8(ref array[13]) ^ array[14] ^ array[15]);
		byte_2[13] = (byte)(array[12] ^ method_7(ref array[13]) ^ method_8(ref array[14]) ^ array[15]);
		byte_2[14] = (byte)(array[12] ^ array[13] ^ method_7(ref array[14]) ^ method_8(ref array[15]));
		byte_2[15] = (byte)(method_8(ref array[12]) ^ array[13] ^ array[14] ^ method_7(ref array[15]));
	}

	private byte method_7(ref byte byte_2)
	{
		byte b = (byte)(byte_2 << 1);
		if ((byte_2 & 0x80u) != 0)
		{
			b = checked((byte)(b ^ 0x1B));
		}
		return b;
	}

	private byte method_8(ref byte byte_2)
	{
		return (byte)(method_7(ref byte_2) ^ byte_2);
	}
}
internal class Class42
{
	private uint uint_0;

	private uint uint_1;

	private byte[] byte_0;

	private byte[] byte_1;

	public uint method_0()
	{
		return uint_0;
	}

	public void method_1(uint uint_2)
	{
		uint_0 = uint_2;
	}

	public uint method_2()
	{
		return uint_1;
	}

	public void method_3(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public byte[] method_4()
	{
		return byte_0;
	}

	public void method_5(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	public byte[] method_6()
	{
		return byte_1;
	}

	public void method_7(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	public static Class42 smethod_0(byte[] byte_2)
	{
		Class42 @class = new Class42();
		using MemoryStream input = new MemoryStream(byte_2);
		using BinaryReader binaryReader = new BinaryReader(input);
		@class.method_1(binaryReader.ReadUInt32());
		@class.method_3(binaryReader.ReadUInt32());
		@class.method_5(binaryReader.ReadBytes(checked(byte_2.Length - 8 - 16)));
		@class.method_7(binaryReader.ReadBytes(16));
		return @class;
	}

	public byte[] method_8()
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			_ = method_4().Length + method_6().Length;
			binaryWriter.Write(method_4());
			binaryWriter.Write(method_6());
			binaryWriter.Flush();
			memoryStream.Position = 0L;
			return memoryStream.ToArray();
		}
	}
}
internal class Class32 : Class30
{
	private byte[] byte_0;

	private byte[] byte_1;

	public byte[] method_3()
	{
		return byte_0;
	}

	public void method_4(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	public byte[] method_5()
	{
		return byte_1;
	}

	public void method_6(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	public override uint vmethod_0()
	{
		return checked((uint)(method_3().Length + method_5().Length));
	}

	public static Class32 smethod_0(byte[] byte_2)
	{
		Class32 @class = new Class32();
		using MemoryStream input = new MemoryStream(byte_2);
		using BinaryReader binaryReader = new BinaryReader(input);
		@class.method_4(binaryReader.ReadBytes(checked(byte_2.Length - 16)));
		@class.method_6(binaryReader.ReadBytes(16));
		return @class;
	}

	public byte[] method_7()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(vmethod_0());
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_1());
		binaryWriter.Write(method_3());
		binaryWriter.Write(method_5());
		binaryWriter.Write(method_2());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class43
{
	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private byte[] byte_0;

	private KMSRequest kmsrequest_0;

	private byte[] byte_1;

	private byte[] byte_2;

	public uint method_0()
	{
		return uint_0;
	}

	public void method_1(uint uint_3)
	{
		uint_0 = uint_3;
	}

	public uint method_2()
	{
		return uint_1;
	}

	public void method_3(uint uint_3)
	{
		uint_1 = uint_3;
	}

	public uint method_4()
	{
		return uint_2;
	}

	public void method_5(uint uint_3)
	{
		uint_2 = uint_3;
	}

	public byte[] method_6()
	{
		return byte_0;
	}

	public void method_7(byte[] byte_3)
	{
		byte_0 = byte_3;
	}

	public KMSRequest method_8()
	{
		return kmsrequest_0;
	}

	public void method_9(KMSRequest kmsrequest_1)
	{
		kmsrequest_0 = kmsrequest_1;
	}

	public byte[] method_10()
	{
		return byte_1;
	}

	public void method_11(byte[] byte_3)
	{
		byte_1 = byte_3;
	}

	public byte[] method_12()
	{
		return byte_2;
	}

	public void method_13(byte[] byte_3)
	{
		byte_2 = byte_3;
	}

	public uint method_14()
	{
		checked
		{
			return (uint)(unchecked((long)checked(Marshal.SizeOf((object)method_4()) + method_6().Length)) + unchecked((long)method_8().BodyLength) + method_10().Length);
		}
	}

	public byte[] method_15()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_4());
		binaryWriter.Write(method_6());
		binaryWriter.Write(method_8().GetByteArray());
		binaryWriter.Write(method_10());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public byte[] method_16()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_6());
		binaryWriter.Write(method_8().GetByteArray());
		binaryWriter.Write(method_10());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public static Class43 smethod_0(ref byte[] byte_3)
	{
		MemoryStream input = new MemoryStream(byte_3);
		BinaryReader binaryReader = new BinaryReader(input);
		Class43 @class = new Class43();
		@class.method_1(binaryReader.ReadUInt32());
		@class.method_3(binaryReader.ReadUInt32());
		@class.method_5(binaryReader.ReadUInt32());
		@class.method_7(binaryReader.ReadBytes(16));
		byte[] encrypted = binaryReader.ReadBytes(checked(byte_3.Length - 8 - 4 - 16 - 4));
		bool isEncrypted = true;
		@class.method_9(KMSRequest.Parse(ref encrypted, ref isEncrypted));
		@class.method_11(binaryReader.ReadBytes(4));
		return @class;
	}

	public static Class43 smethod_1(ref byte[] byte_3, ref Class43 class43_0)
	{
		MemoryStream input = new MemoryStream(byte_3);
		BinaryReader binaryReader = new BinaryReader(input);
		Class43 @class = new Class43();
		@class.method_5(class43_0.method_4());
		@class.method_7(class43_0.method_6());
		byte[] encrypted = binaryReader.ReadBytes(checked(byte_3.Length - 4));
		bool isEncrypted = true;
		@class.method_9(KMSRequest.Parse(ref encrypted, ref isEncrypted));
		@class.method_11(binaryReader.ReadBytes(4));
		class43_0 = @class;
		return class43_0;
	}
}
internal class Class33 : Class30
{
	private uint uint_0;

	private byte[] byte_0;

	private KMSResponse kmsresponse_0;

	private byte[] byte_1;

	private byte[] byte_2;

	private byte[] byte_3;

	public uint method_3()
	{
		return uint_0;
	}

	public void method_4(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public byte[] method_5()
	{
		return byte_0;
	}

	public void method_6(byte[] byte_4)
	{
		byte_0 = byte_4;
	}

	public KMSResponse method_7()
	{
		return kmsresponse_0;
	}

	public void method_8(KMSResponse kmsresponse_1)
	{
		kmsresponse_0 = kmsresponse_1;
	}

	public byte[] method_9()
	{
		return byte_1;
	}

	public void method_10(byte[] byte_4)
	{
		byte_1 = byte_4;
	}

	public byte[] method_11()
	{
		return byte_2;
	}

	public void method_12(byte[] byte_4)
	{
		byte_2 = byte_4;
	}

	public byte[] method_13()
	{
		return byte_3;
	}

	public void method_14(byte[] byte_4)
	{
		byte_3 = byte_4;
	}

	public override uint vmethod_0()
	{
		checked
		{
			return (uint)(unchecked((long)checked(Marshal.SizeOf((object)method_3()) + method_5().Length)) + unchecked((long)method_7().BodyLength) + method_9().Length + method_11().Length + method_13().Length);
		}
	}

	public static Class33 smethod_0(ref byte[] byte_4)
	{
		checked
		{
			int num = byte_4.Length - 4 - 16 - 16 - 32 - 2;
			MemoryStream input = new MemoryStream(byte_4);
			BinaryReader binaryReader = new BinaryReader(input);
			Class33 @class = new Class33();
			@class.method_4(binaryReader.ReadUInt32());
			@class.method_6(binaryReader.ReadBytes(16));
			@class.method_8(KMSResponse.Parse(binaryReader.ReadBytes(num)));
			@class.method_10(binaryReader.ReadBytes(16));
			@class.method_12(binaryReader.ReadBytes(32));
			@class.method_14(binaryReader.ReadBytes(byte_4.Length - 4 - 16 - num - 16 - 32));
			return @class;
		}
	}

	public static Class33 smethod_1(ref byte[] byte_4, bool bool_0)
	{
		new Class33();
		int count = checked(byte_4.Length - 4 - 16 - 16 - 32 - 2);
		MemoryStream input = new MemoryStream(byte_4);
		BinaryReader binaryReader = new BinaryReader(input);
		Class33 @class = new Class33();
		@class.method_4(binaryReader.ReadUInt32());
		@class.method_6(binaryReader.ReadBytes(16));
		@class.method_8(KMSResponse.Parse(binaryReader.ReadBytes(count), bool_0));
		@class.method_10(binaryReader.ReadBytes(16));
		@class.method_12(binaryReader.ReadBytes(32));
		@class.method_14(binaryReader.ReadBytes(2));
		return @class;
	}

	public byte[] method_15()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(vmethod_0());
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_1());
		binaryWriter.Write(method_3());
		binaryWriter.Write(method_5());
		binaryWriter.Write(method_7().GetByteArray());
		binaryWriter.Write(method_9());
		binaryWriter.Write(method_11());
		binaryWriter.Write(method_13());
		binaryWriter.Write(method_2());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public byte[] method_16()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_7().GetByteArray());
		binaryWriter.Write(method_9());
		binaryWriter.Write(method_11());
		binaryWriter.Write(method_13());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class44 : IMessageHandler
{
	private IMessageHandler imessageHandler_0;

	private static ILogger ilogger_0;

	public Class44(ref IMessageHandler imessageHandler_1, ref ILogger ilogger_1)
	{
		imessageHandler_0 = imessageHandler_1;
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		KMSRequest kmsrequest_ = KMSRequest.Parse(ref request);
		byte[] request2 = smethod_1(ref kmsrequest_).method_15();
		byte[] byte_ = imessageHandler_0.HandleRequest(ref request2);
		return smethod_0(ref byte_).GetByteArray();
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		byte[] request2 = smethod_1(ref request).method_15();
		byte[] byte_ = imessageHandler_0.HandleRequest(ref request2);
		return smethod_0(ref byte_);
	}

	private static KMSResponse smethod_0(ref byte[] byte_0)
	{
		KMSResponse kMSResponse = null;
		if (byte_0.Length == 12)
		{
			kMSResponse = KMSResponse.ParseError(byte_0);
		}
		else
		{
			Class33 class33_ = Class33.smethod_1(ref byte_0, bool_0: true);
			class33_ = Class45.smethod_2(ref class33_);
			kMSResponse = class33_.method_7();
			ILogger logger = ilogger_0;
			string message = string.Format("Test: Received response: v{0}, PID: {1}", kMSResponse.MajorVersion, kMSResponse.KMSPIDString.Replace("\0", string.Empty));
			logger.LogMessage(ref message);
		}
		return kMSResponse;
	}

	private static Class43 smethod_1(ref KMSRequest kmsrequest_0)
	{
		Class43 @class = new Class43();
		@class.method_5(327680u);
		@class.method_7(Guid.NewGuid().ToByteArray());
		@class.method_9(kmsrequest_0);
		Class43 class43_ = @class;
		byte[] byte_ = class43_.method_8().GetByteArray();
		Class43 class2;
		byte[] byte_2 = (class2 = class43_).method_6();
		byte[] array = Class45.smethod_4(ref byte_, ref byte_2);
		class2.method_7(byte_2);
		byte[] byte_3 = array;
		class43_ = Class43.smethod_1(ref byte_3, ref class43_);
		ILogger logger = ilogger_0;
		string message = $"Test: Sending request: v{kmsrequest_0.MajorVersion}, AppID: {kmsrequest_0.ApplicationId}, Machine: {kmsrequest_0.MachineNameString}";
		logger.LogMessage(ref message);
		return class43_;
	}
}
internal class Class45
{
	public static readonly byte[] byte_0 = new byte[16]
	{
		205,
		126,
		121,
		111,
		42,
		178,
		93,
		203,
		85,
		255,
		200,
		239,
		131,
		100,
		196,
		112
	};

	public static byte[] smethod_0(ref byte[] byte_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return ((HashAlgorithm)new SHA256Managed()).ComputeHash(byte_1);
	}

	public static Class43 smethod_1(ref Class43 class43_0)
	{
		byte[] byte_ = class43_0.method_16();
		Class43 @class;
		byte[] byte_2 = (@class = class43_0).method_6();
		byte[] array = smethod_3(ref byte_, ref byte_2);
		@class.method_7(byte_2);
		byte[] byte_3 = Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array, class43_0.method_6().Length));
		byte[] decrypted = Enumerable.ToArray<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, class43_0.method_6().Length));
		class43_0.method_13(byte_3);
		class43_0.method_9(KMSRequest.Parse(ref decrypted));
		return class43_0;
	}

	public static Class33 smethod_2(ref Class33 class33_0)
	{
		byte[] byte_ = class33_0.method_16();
		Class33 @class;
		byte[] byte_2 = (@class = class33_0).method_5();
		byte[] array = smethod_3(ref byte_, ref byte_2);
		@class.method_6(byte_2);
		checked
		{
			int num = array.Length - 16 - 32;
			byte[] decrypted = Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array, num));
			byte[] byte_3 = Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, num), 16));
			byte[] byte_4 = Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, num + 16), 32));
			class33_0.method_8(KMSResponse.Parse(decrypted));
			class33_0.method_10(byte_3);
			class33_0.method_12(byte_4);
			return class33_0;
		}
	}

	private static byte[] smethod_3(ref byte[] byte_1, ref byte[] byte_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		RijndaelManaged val = new RijndaelManaged();
		((SymmetricAlgorithm)val).set_Key(byte_0);
		((SymmetricAlgorithm)val).set_IV(byte_2);
		RijndaelManaged val2 = val;
		MemoryStream memoryStream = new MemoryStream();
		new CryptoStream((Stream)memoryStream, ((SymmetricAlgorithm)val2).CreateDecryptor(), (CryptoStreamMode)1).Write(byte_1, 0, byte_1.Length);
		return memoryStream.ToArray();
	}

	public static byte[] smethod_4(ref byte[] byte_1, ref byte[] byte_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		RijndaelManaged val = new RijndaelManaged();
		((SymmetricAlgorithm)val).set_Key(byte_0);
		((SymmetricAlgorithm)val).set_IV(byte_2);
		RijndaelManaged val2 = val;
		MemoryStream memoryStream = new MemoryStream();
		new CryptoStream((Stream)memoryStream, ((SymmetricAlgorithm)val2).CreateEncryptor(), (CryptoStreamMode)1).Write(byte_1, 0, byte_1.Length);
		return memoryStream.ToArray();
	}
}
internal class Class46 : IMessageHandler
{
	private Interface0 interface0_0;

	private readonly ILogger ilogger_0;

	private Interface0 method_0()
	{
		return interface0_0;
	}

	private void method_1(Interface0 interface0_1)
	{
		interface0_0 = interface0_1;
	}

	public Class46(ref Interface0 interface0_1, ref ILogger ilogger_1)
	{
		method_1(interface0_1);
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		Class43 class43_ = Class43.smethod_0(ref request);
		class43_ = Class45.smethod_1(ref class43_);
		ILogger logger = ilogger_0;
		string message = $"Received request: v{class43_.method_8().MajorVersion}, AppID: {class43_.method_8().ApplicationId}, Machine: {class43_.method_8().MachineNameString}";
		logger.LogMessage(ref message);
		Interface0 @interface = method_0();
		Class43 @class;
		KMSRequest kmsrequest_ = (@class = class43_).method_8();
		KMSResponse kMSResponse = @interface.imethod_0(ref kmsrequest_);
		@class.method_9(kmsrequest_);
		KMSResponse kMSResponse2 = kMSResponse;
		byte[] byte_ = Guid.NewGuid().ToByteArray();
		byte[] gparam_ = Class45.smethod_0(ref byte_);
		byte[] array = new byte[16];
		int num = 0;
		do
		{
			array[num] = (byte)(class43_.method_12()[num] ^ class43_.method_6()[num] ^ byte_[num]);
			num = checked(num + 1);
		}
		while (num <= 15);
		byte[] byte_2 = Class1.smethod_1(kMSResponse2.GetByteArray(), array, gparam_);
		byte[] byte_3 = (@class = class43_).method_6();
		byte[] array2 = Class45.smethod_4(ref byte_2, ref byte_3);
		@class.method_7(byte_3);
		byte[] array3 = array2;
		Class33 class2 = new Class33();
		class2.method_4(class43_.method_4());
		class2.method_6(class43_.method_6());
		checked
		{
			class2.method_8(KMSResponse.Parse(Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array3, (int)kMSResponse2.BodyLength)), isEncrypted: true));
			class2.method_10(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array3, (int)kMSResponse2.BodyLength), 16)));
			class2.method_12(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array3, (int)(unchecked((long)kMSResponse2.BodyLength) + unchecked((long)class2.method_9().Length))), 32)));
			class2.method_14(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array3, (int)(unchecked((long)kMSResponse2.BodyLength) + unchecked((long)class2.method_9().Length) + class2.method_11().Length)), 2)));
			ILogger logger2 = ilogger_0;
			message = $"Sending response: v{kMSResponse2.MajorVersion}, PID: {kMSResponse2.KMSPIDString}";
			logger2.LogMessage(ref message);
			return class2.method_15();
		}
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}
}
internal class Class47
{
	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private byte[] byte_0;

	private byte[] byte_1;

	public uint method_0()
	{
		return uint_0;
	}

	public void method_1(uint uint_3)
	{
		uint_0 = uint_3;
	}

	public uint method_2()
	{
		return uint_1;
	}

	public void method_3(uint uint_3)
	{
		uint_1 = uint_3;
	}

	public uint method_4()
	{
		return uint_2;
	}

	public void method_5(uint uint_3)
	{
		uint_2 = uint_3;
	}

	public byte[] method_6()
	{
		return byte_0;
	}

	public void method_7(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	public byte[] method_8()
	{
		return byte_1;
	}

	public void method_9(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	public byte[] method_10()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_4());
		binaryWriter.Write(method_6());
		binaryWriter.Write(method_8());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public static Class47 smethod_0(byte[] byte_2)
	{
		Class47 @class = new Class47();
		using MemoryStream input = new MemoryStream(byte_2);
		using BinaryReader binaryReader = new BinaryReader(input);
		@class.method_1(binaryReader.ReadUInt32());
		@class.method_3(binaryReader.ReadUInt32());
		@class.method_5(binaryReader.ReadUInt32());
		@class.method_7(binaryReader.ReadBytes(16));
		@class.method_9(binaryReader.ReadBytes(checked(byte_2.Length - 8 - 4 - 16)));
		return @class;
	}
}
internal class Class34 : Class30
{
	private uint uint_0;

	private byte[] byte_0;

	private byte[] byte_1;

	public uint method_3()
	{
		return uint_0;
	}

	public void method_4(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public byte[] method_5()
	{
		return byte_0;
	}

	public void method_6(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	public byte[] method_7()
	{
		return byte_1;
	}

	public void method_8(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	public override uint vmethod_0()
	{
		return checked((uint)(4 + method_5().Length + method_7().Length));
	}

	public static Class34 smethod_0(byte[] byte_2)
	{
		Class34 @class = new Class34();
		using MemoryStream input = new MemoryStream(byte_2);
		using BinaryReader binaryReader = new BinaryReader(input);
		@class.method_4(binaryReader.ReadUInt32());
		@class.method_6(binaryReader.ReadBytes(16));
		@class.method_8(binaryReader.ReadBytes(checked(byte_2.Length - 2 - 2 - 16)));
		return @class;
	}

	public byte[] method_9()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(vmethod_0());
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_1());
		binaryWriter.Write(method_3());
		binaryWriter.Write(method_5());
		binaryWriter.Write(method_7());
		binaryWriter.Write(method_2());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class48
{
	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private byte[] byte_0;

	private KMSRequest kmsrequest_0;

	private byte[] byte_1;

	private byte[] byte_2;

	public uint method_0()
	{
		return uint_0;
	}

	public void method_1(uint uint_3)
	{
		uint_0 = uint_3;
	}

	public uint method_2()
	{
		return uint_1;
	}

	public void method_3(uint uint_3)
	{
		uint_1 = uint_3;
	}

	public uint method_4()
	{
		return uint_2;
	}

	public void method_5(uint uint_3)
	{
		uint_2 = uint_3;
	}

	public byte[] method_6()
	{
		return byte_0;
	}

	public void method_7(byte[] byte_3)
	{
		byte_0 = byte_3;
	}

	public KMSRequest method_8()
	{
		return kmsrequest_0;
	}

	public void method_9(KMSRequest kmsrequest_1)
	{
		kmsrequest_0 = kmsrequest_1;
	}

	public byte[] method_10()
	{
		return byte_1;
	}

	public void method_11(byte[] byte_3)
	{
		byte_1 = byte_3;
	}

	public byte[] method_12()
	{
		return byte_2;
	}

	public void method_13(byte[] byte_3)
	{
		byte_2 = byte_3;
	}

	public uint method_14()
	{
		checked
		{
			return (uint)(unchecked((long)checked(Marshal.SizeOf((object)method_4()) + method_6().Length)) + unchecked((long)method_8().BodyLength) + method_10().Length);
		}
	}

	public byte[] method_15()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_4());
		binaryWriter.Write(method_6());
		binaryWriter.Write(method_8().GetByteArray());
		binaryWriter.Write(method_10());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public byte[] method_16()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_6());
		binaryWriter.Write(method_8().GetByteArray());
		binaryWriter.Write(method_10());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public static Class48 smethod_0(ref byte[] byte_3)
	{
		MemoryStream input = new MemoryStream(byte_3);
		BinaryReader binaryReader = new BinaryReader(input);
		Class48 @class = new Class48();
		@class.method_1(binaryReader.ReadUInt32());
		@class.method_3(binaryReader.ReadUInt32());
		@class.method_5(binaryReader.ReadUInt32());
		@class.method_7(binaryReader.ReadBytes(16));
		byte[] encrypted = binaryReader.ReadBytes(checked(byte_3.Length - 8 - 4 - 16 - 4));
		bool isEncrypted = true;
		@class.method_9(KMSRequest.Parse(ref encrypted, ref isEncrypted));
		@class.method_11(binaryReader.ReadBytes(4));
		return @class;
	}

	public static Class48 smethod_1(ref byte[] byte_3, ref Class48 class48_0)
	{
		MemoryStream input = new MemoryStream(byte_3);
		BinaryReader binaryReader = new BinaryReader(input);
		Class48 @class = new Class48();
		@class.method_5(class48_0.method_4());
		@class.method_7(class48_0.method_6());
		byte[] encrypted = binaryReader.ReadBytes(checked(byte_3.Length - 4));
		bool isEncrypted = true;
		@class.method_9(KMSRequest.Parse(ref encrypted, ref isEncrypted));
		@class.method_11(binaryReader.ReadBytes(4));
		class48_0 = @class;
		return class48_0;
	}
}
internal class Class35 : Class30
{
	private uint uint_0;

	private byte[] byte_0;

	private KMSResponse kmsresponse_0;

	private byte[] byte_1;

	private byte[] byte_2;

	private byte[] byte_3;

	private byte[] byte_4;

	private byte[] byte_5;

	private byte[] byte_6;

	public uint method_3()
	{
		return uint_0;
	}

	public void method_4(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public byte[] method_5()
	{
		return byte_0;
	}

	public void method_6(byte[] byte_7)
	{
		byte_0 = byte_7;
	}

	public KMSResponse method_7()
	{
		return kmsresponse_0;
	}

	public void method_8(KMSResponse kmsresponse_1)
	{
		kmsresponse_0 = kmsresponse_1;
	}

	public byte[] method_9()
	{
		return byte_1;
	}

	public void method_10(byte[] byte_7)
	{
		byte_1 = byte_7;
	}

	public byte[] method_11()
	{
		return byte_2;
	}

	public void method_12(byte[] byte_7)
	{
		byte_2 = byte_7;
	}

	public byte[] method_13()
	{
		return byte_3;
	}

	public void method_14(byte[] byte_7)
	{
		byte_3 = byte_7;
	}

	public byte[] method_15()
	{
		return byte_4;
	}

	public void method_16(byte[] byte_7)
	{
		byte_4 = byte_7;
	}

	public byte[] method_17()
	{
		return byte_5;
	}

	public void method_18(byte[] byte_7)
	{
		byte_5 = byte_7;
	}

	public byte[] method_19()
	{
		return byte_6;
	}

	public void method_20(byte[] byte_7)
	{
		byte_6 = byte_7;
	}

	public override uint vmethod_0()
	{
		checked
		{
			return (uint)(unchecked((long)checked(Marshal.SizeOf((object)method_3()) + method_5().Length)) + unchecked((long)method_7().BodyLength) + method_9().Length + method_11().Length + method_13().Length + method_15().Length + method_17().Length + method_19().Length);
		}
	}

	public static Class35 smethod_0(ref byte[] byte_7)
	{
		int count = checked(byte_7.Length - 4 - 16 - 16 - 32 - 8 - 16 - 16 - 10);
		MemoryStream input = new MemoryStream(byte_7);
		BinaryReader binaryReader = new BinaryReader(input);
		Class35 @class = new Class35();
		@class.method_4(binaryReader.ReadUInt32());
		@class.method_6(binaryReader.ReadBytes(16));
		@class.method_8(KMSResponse.Parse(binaryReader.ReadBytes(count)));
		@class.method_10(binaryReader.ReadBytes(16));
		@class.method_12(binaryReader.ReadBytes(32));
		@class.method_14(binaryReader.ReadBytes(8));
		@class.method_16(binaryReader.ReadBytes(16));
		@class.method_18(binaryReader.ReadBytes(16));
		@class.method_20(binaryReader.ReadBytes(10));
		return @class;
	}

	public static Class35 smethod_1(ref byte[] byte_7, ref bool bool_0)
	{
		int count = checked(byte_7.Length - 4 - 16 - 16 - 32 - 8 - 16 - 16 - 10);
		MemoryStream input = new MemoryStream(byte_7);
		BinaryReader binaryReader = new BinaryReader(input);
		Class35 @class = new Class35();
		@class.method_4(binaryReader.ReadUInt32());
		@class.method_6(binaryReader.ReadBytes(16));
		@class.method_8(KMSResponse.Parse(binaryReader.ReadBytes(count), bool_0));
		@class.method_10(binaryReader.ReadBytes(16));
		@class.method_12(binaryReader.ReadBytes(32));
		@class.method_14(binaryReader.ReadBytes(8));
		@class.method_16(binaryReader.ReadBytes(16));
		@class.method_18(binaryReader.ReadBytes(16));
		@class.method_20(binaryReader.ReadBytes(10));
		return @class;
	}

	public byte[] method_21()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(vmethod_0());
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_1());
		binaryWriter.Write(method_3());
		binaryWriter.Write(method_5());
		binaryWriter.Write(method_7().GetByteArray());
		binaryWriter.Write(method_9());
		binaryWriter.Write(method_11());
		binaryWriter.Write(method_13());
		binaryWriter.Write(method_15());
		binaryWriter.Write(method_17());
		binaryWriter.Write(method_19());
		binaryWriter.Write(method_2());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public byte[] method_22()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_7().GetByteArray());
		binaryWriter.Write(method_9());
		binaryWriter.Write(method_11());
		binaryWriter.Write(method_13());
		binaryWriter.Write(method_15());
		binaryWriter.Write(method_17());
		binaryWriter.Write(method_19());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class49 : IMessageHandler
{
	private IMessageHandler imessageHandler_0;

	private static ILogger ilogger_0;

	public Class49(ref IMessageHandler imessageHandler_1, ref ILogger ilogger_1)
	{
		imessageHandler_0 = imessageHandler_1;
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		KMSRequest kmsrequest_ = KMSRequest.Parse(ref request);
		byte[] request2 = smethod_1(ref kmsrequest_).method_15();
		byte[] byte_ = imessageHandler_0.HandleRequest(ref request2);
		return smethod_0(ref byte_).GetByteArray();
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		byte[] request2 = smethod_1(ref request).method_15();
		byte[] byte_ = imessageHandler_0.HandleRequest(ref request2);
		return smethod_0(ref byte_);
	}

	private static KMSResponse smethod_0(ref byte[] byte_0)
	{
		KMSResponse kMSResponse = new KMSResponse();
		if (byte_0.Length == 12)
		{
			kMSResponse = KMSResponse.ParseError(byte_0);
		}
		else
		{
			bool bool_ = true;
			Class35 class35_ = Class35.smethod_1(ref byte_0, ref bool_);
			class35_ = Class50.smethod_3(ref class35_);
			kMSResponse = class35_.method_7();
			ILogger logger = ilogger_0;
			object arg = kMSResponse.MajorVersion;
			string arg2 = kMSResponse.KMSPIDString.Replace("\0", string.Empty);
			Class35 @class;
			byte[] byte_ = (@class = class35_).method_13();
			string arg3 = Class2.smethod_8(ref byte_, ref ilogger_0);
			@class.method_14(byte_);
			string message = $"Test: Received response: v{arg}, PID: {arg2}, HwID: {arg3}";
			logger.LogMessage(ref message);
		}
		return kMSResponse;
	}

	private static Class48 smethod_1(ref KMSRequest kmsrequest_0)
	{
		Class48 @class = new Class48();
		@class.method_5(393216u);
		@class.method_7(Guid.NewGuid().ToByteArray());
		@class.method_9(kmsrequest_0);
		Class48 class48_ = @class;
		byte[] byte_ = class48_.method_8().GetByteArray();
		Class48 class2;
		byte[] byte_2 = (class2 = class48_).method_6();
		byte[] array = Class50.smethod_4(ref byte_, ref byte_2);
		class2.method_7(byte_2);
		byte[] byte_3 = array;
		class48_ = Class48.smethod_1(ref byte_3, ref class48_);
		ILogger logger = ilogger_0;
		string message = $"Test: Sending request: v{kmsrequest_0.MajorVersion}, AppID: {kmsrequest_0.ApplicationId}, Machine: {kmsrequest_0.MachineNameString}";
		logger.LogMessage(ref message);
		return class48_;
	}
}
internal class Class50
{
	public static readonly byte[] byte_0 = new byte[16]
	{
		205,
		126,
		121,
		111,
		42,
		178,
		93,
		203,
		85,
		255,
		200,
		239,
		131,
		100,
		196,
		112
	};

	private static byte[] byte_1 = new byte[256]
	{
		99,
		124,
		119,
		123,
		242,
		107,
		111,
		197,
		48,
		1,
		103,
		43,
		254,
		215,
		171,
		118,
		202,
		130,
		201,
		125,
		250,
		89,
		71,
		240,
		173,
		212,
		162,
		175,
		156,
		164,
		114,
		192,
		183,
		253,
		147,
		38,
		54,
		63,
		247,
		204,
		52,
		165,
		229,
		241,
		113,
		216,
		49,
		21,
		4,
		199,
		35,
		195,
		24,
		150,
		5,
		154,
		7,
		18,
		128,
		226,
		235,
		39,
		178,
		117,
		9,
		131,
		44,
		26,
		27,
		110,
		90,
		160,
		82,
		59,
		214,
		179,
		41,
		227,
		47,
		132,
		83,
		209,
		0,
		237,
		32,
		252,
		177,
		91,
		106,
		203,
		190,
		57,
		74,
		76,
		88,
		207,
		208,
		239,
		170,
		251,
		67,
		77,
		51,
		133,
		69,
		249,
		2,
		127,
		80,
		60,
		159,
		168,
		81,
		163,
		64,
		143,
		146,
		157,
		56,
		245,
		188,
		182,
		218,
		33,
		16,
		255,
		243,
		210,
		205,
		12,
		19,
		236,
		95,
		151,
		68,
		23,
		196,
		167,
		126,
		61,
		100,
		93,
		25,
		115,
		96,
		129,
		79,
		220,
		34,
		42,
		144,
		136,
		70,
		238,
		184,
		20,
		222,
		94,
		11,
		219,
		224,
		50,
		58,
		10,
		73,
		6,
		36,
		92,
		194,
		211,
		172,
		98,
		145,
		149,
		228,
		121,
		231,
		200,
		55,
		109,
		141,
		213,
		78,
		169,
		108,
		86,
		244,
		234,
		101,
		122,
		174,
		8,
		186,
		120,
		37,
		46,
		28,
		166,
		180,
		198,
		232,
		221,
		116,
		31,
		75,
		189,
		139,
		138,
		112,
		62,
		181,
		102,
		72,
		3,
		246,
		14,
		97,
		53,
		87,
		185,
		134,
		193,
		29,
		158,
		225,
		248,
		152,
		17,
		105,
		217,
		142,
		148,
		155,
		30,
		135,
		233,
		206,
		85,
		40,
		223,
		140,
		161,
		137,
		13,
		191,
		230,
		66,
		104,
		65,
		153,
		45,
		15,
		176,
		84,
		187,
		22
	};

	private static byte[] byte_2 = new byte[256]
	{
		82,
		9,
		106,
		213,
		48,
		54,
		165,
		56,
		191,
		64,
		163,
		158,
		129,
		243,
		215,
		251,
		124,
		227,
		57,
		130,
		155,
		47,
		255,
		135,
		52,
		142,
		67,
		68,
		196,
		222,
		233,
		203,
		84,
		123,
		148,
		50,
		166,
		194,
		35,
		61,
		238,
		76,
		149,
		11,
		66,
		250,
		195,
		78,
		8,
		46,
		161,
		102,
		40,
		217,
		36,
		178,
		118,
		91,
		162,
		73,
		109,
		139,
		209,
		37,
		114,
		248,
		246,
		100,
		134,
		104,
		152,
		22,
		212,
		164,
		92,
		204,
		93,
		101,
		182,
		146,
		108,
		112,
		72,
		80,
		253,
		237,
		185,
		218,
		94,
		21,
		70,
		87,
		167,
		141,
		157,
		132,
		144,
		216,
		171,
		0,
		140,
		188,
		211,
		10,
		247,
		228,
		88,
		5,
		184,
		179,
		69,
		6,
		208,
		44,
		30,
		143,
		202,
		63,
		15,
		2,
		193,
		175,
		189,
		3,
		1,
		19,
		138,
		107,
		58,
		145,
		17,
		65,
		79,
		103,
		220,
		234,
		151,
		242,
		207,
		206,
		240,
		180,
		230,
		115,
		150,
		172,
		116,
		34,
		231,
		173,
		53,
		133,
		226,
		249,
		55,
		232,
		28,
		117,
		223,
		110,
		71,
		241,
		26,
		113,
		29,
		41,
		197,
		137,
		111,
		183,
		98,
		14,
		170,
		24,
		190,
		27,
		252,
		86,
		62,
		75,
		198,
		210,
		121,
		32,
		154,
		219,
		192,
		254,
		120,
		205,
		90,
		244,
		31,
		221,
		168,
		51,
		136,
		7,
		199,
		49,
		177,
		18,
		16,
		89,
		39,
		128,
		236,
		95,
		96,
		81,
		127,
		169,
		25,
		181,
		74,
		13,
		45,
		229,
		122,
		159,
		147,
		201,
		156,
		239,
		160,
		224,
		59,
		77,
		174,
		42,
		245,
		176,
		200,
		235,
		187,
		60,
		131,
		83,
		153,
		97,
		23,
		43,
		4,
		126,
		186,
		119,
		214,
		38,
		225,
		105,
		20,
		99,
		85,
		33,
		12,
		125
	};

	private static byte[,] byte_3 = new byte[11, 16]
	{
		{
			169,
			74,
			65,
			149,
			226,
			1,
			67,
			45,
			155,
			203,
			70,
			4,
			5,
			216,
			74,
			33
		},
		{
			201,
			156,
			188,
			254,
			43,
			157,
			255,
			211,
			176,
			86,
			185,
			215,
			181,
			142,
			243,
			246
		},
		{
			210,
			145,
			254,
			43,
			249,
			12,
			1,
			248,
			73,
			90,
			184,
			47,
			252,
			212,
			75,
			217
		},
		{
			158,
			34,
			203,
			155,
			103,
			46,
			202,
			99,
			46,
			116,
			114,
			76,
			210,
			160,
			57,
			149
		},
		{
			5,
			48,
			225,
			46,
			17,
			30,
			43,
			77,
			63,
			106,
			89,
			1,
			237,
			202,
			96,
			148
		},
		{
			18,
			224,
			195,
			123,
			3,
			254,
			232,
			54,
			60,
			148,
			177,
			55,
			209,
			94,
			209,
			163
		},
		{
			99,
			222,
			201,
			69,
			105,
			32,
			33,
			115,
			85,
			180,
			144,
			68,
			132,
			234,
			65,
			231
		},
		{
			173,
			93,
			93,
			26,
			196,
			125,
			124,
			105,
			145,
			201,
			236,
			45,
			21,
			35,
			173,
			202
		},
		{
			239,
			200,
			41,
			67,
			207,
			181,
			85,
			42,
			94,
			124,
			185,
			7,
			75,
			95,
			20,
			205
		},
		{
			223,
			50,
			148,
			240,
			16,
			135,
			193,
			218,
			78,
			251,
			120,
			221,
			5,
			164,
			108,
			16
		},
		{
			160,
			98,
			94,
			155,
			176,
			229,
			159,
			65,
			254,
			30,
			231,
			156,
			251,
			186,
			139,
			140
		}
	};

	public static byte[] smethod_0(byte[] byte_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return ((HashAlgorithm)new SHA256Managed()).ComputeHash(byte_4);
	}

	public static byte[] smethod_1(Class52 class52_0)
	{
		byte[] byte_ = class52_0.method_6();
		byte[] byte_2 = Enumerable.ToArray<byte>(Enumerable.Concat<byte>((IEnumerable<byte>)class52_0.method_6(), (IEnumerable<byte>)class52_0.method_8()));
		return smethod_8(ref byte_2, ref byte_);
	}

	public static Class48 smethod_2(ref Class48 class48_0)
	{
		byte[] byte_ = class48_0.method_16();
		Class48 @class;
		byte[] byte_2 = (@class = class48_0).method_6();
		byte[] array = smethod_8(ref byte_, ref byte_2);
		@class.method_7(byte_2);
		byte[] array2 = Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array, class48_0.method_6().Length));
		byte[] decrypted = Enumerable.ToArray<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, class48_0.method_6().Length));
		class48_0.method_13(array2);
		class48_0.method_9(KMSRequest.Parse(ref decrypted));
		return class48_0;
	}

	public static Class35 smethod_3(ref Class35 class35_0)
	{
		byte[] byte_ = class35_0.method_22();
		Class35 @class;
		byte[] byte_2 = (@class = class35_0).method_5();
		byte[] array = smethod_8(ref byte_, ref byte_2);
		@class.method_6(byte_2);
		checked
		{
			int num = array.Length - 16 - 32 - 8 - 16 - 16;
			byte[] decrypted = Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array, num));
			byte[] byte_3 = Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, num), 16));
			byte[] byte_4 = Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, num + 16), 32));
			byte[] byte_5 = Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, num + 16 + 32), 8));
			byte[] byte_6 = Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, num + 16 + 32 + 8), 16));
			byte[] byte_7 = Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array, num + 16 + 32 + 8 + 16), 16));
			class35_0.method_8(KMSResponse.Parse(decrypted));
			class35_0.method_10(byte_3);
			class35_0.method_12(byte_4);
			class35_0.method_14(byte_5);
			class35_0.method_16(byte_6);
			class35_0.method_18(byte_7);
			return class35_0;
		}
	}

	public static byte[] smethod_4(ref byte[] byte_4, ref byte[] byte_5)
	{
		return smethod_7(ref byte_4, ref byte_5);
	}

	public static byte[] smethod_5(ulong ulong_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			ulong value = unchecked(ulong_0 / 148199999933uL) * 139799999981uL + 3555254745610864506uL;
			return Enumerable.ToArray<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)((HashAlgorithm)new SHA256Managed()).ComputeHash(BitConverter.GetBytes(value)), 16));
		}
	}

	public static byte[] smethod_6(ref byte[] byte_4, ref byte[] byte_5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return ((HashAlgorithm)new HMACSHA256(byte_4)).ComputeHash(byte_5);
	}

	private static byte[] smethod_7(ref byte[] byte_4, ref byte[] byte_5)
	{
		checked
		{
			byte b = (byte)(16 - unchecked(byte_4.Length % 16));
			byte[] byte_6 = Enumerable.ToArray<byte>(Enumerable.Concat<byte>((IEnumerable<byte>)byte_4, Enumerable.Repeat<byte>(b, unchecked((int)b))));
			if (byte_5 != null)
			{
				int num = 0;
				do
				{
					byte_6[num] = unchecked((byte)(byte_6[num] ^ byte_5[num]));
					num++;
				}
				while (num <= 15);
			}
			int int_ = 0;
			byte[] array = smethod_9(ref byte_6, ref int_);
			int_ = byte_6.Length - 1;
			for (int i = 16; i <= int_; i += 16)
			{
				int num2 = 0;
				do
				{
					byte_6[i + num2] = unchecked((byte)checked(byte_6[i + num2] ^ array[i - 16 + num2]));
					num2++;
				}
				while (num2 <= 15);
				array = Enumerable.ToArray<byte>(Enumerable.Concat<byte>((IEnumerable<byte>)array, (IEnumerable<byte>)smethod_9(ref byte_6, ref i)));
			}
			return array;
		}
	}

	public static byte[] smethod_8(ref byte[] byte_4, ref byte[] byte_5)
	{
		int num = byte_4.Length;
		int int_ = 0;
		byte[] array = smethod_10(ref byte_4, ref int_);
		if (byte_5 != null)
		{
			int num2 = 0;
			do
			{
				array[num2] = (byte)(array[num2] ^ byte_5[num2]);
				num2 = checked(num2 + 1);
			}
			while (num2 <= 15);
		}
		checked
		{
			int_ = num - 1;
			for (int i = 16; i <= int_; i += 16)
			{
				array = Enumerable.ToArray<byte>(Enumerable.Concat<byte>((IEnumerable<byte>)array, (IEnumerable<byte>)smethod_10(ref byte_4, ref i)));
				int num3 = 0;
				do
				{
					array[i + num3] = unchecked((byte)checked(array[i + num3] ^ byte_4[i - 16 + num3]));
					num3++;
				}
				while (num3 <= 15);
			}
			if (array.Length == 16)
			{
				return array;
			}
			byte[] array2 = array;
			byte b = array2[array2.Length - 1];
			return Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array, array.Length - unchecked((int)b)));
		}
	}

	private static byte[] smethod_9(ref byte[] byte_4, ref int int_0)
	{
		byte[] byte_5 = new byte[16];
		int num = 0;
		checked
		{
			do
			{
				byte_5[num] = byte_4[int_0 + num];
				num++;
			}
			while (num <= 15);
			int int_ = 0;
			smethod_11(ref byte_5, ref int_);
			int int_2 = 1;
			do
			{
				smethod_20(ref byte_5);
				smethod_22(ref byte_5);
				smethod_11(ref byte_5, ref int_2);
				int_2++;
			}
			while (int_2 <= 9);
			smethod_20(ref byte_5);
			int_ = 10;
			smethod_11(ref byte_5, ref int_);
			return byte_5;
		}
	}

	private static byte[] smethod_10(ref byte[] byte_4, ref int int_0)
	{
		byte[] byte_5 = new byte[16];
		int num = 0;
		checked
		{
			do
			{
				byte_5[num] = byte_4[int_0 + num];
				num++;
			}
			while (num <= 15);
			int int_ = 10;
			smethod_11(ref byte_5, ref int_);
			smethod_21(ref byte_5);
			int int_2 = 9;
			do
			{
				smethod_11(ref byte_5, ref int_2);
				smethod_23(ref byte_5);
				smethod_21(ref byte_5);
				int_2 += -1;
			}
			while (int_2 >= 1);
			int_ = 0;
			smethod_11(ref byte_5, ref int_);
			return byte_5;
		}
	}

	private static void smethod_11(ref byte[] byte_4, ref int int_0)
	{
		int num = 0;
		do
		{
			byte_4[num] = (byte)(byte_4[num] ^ byte_3[int_0, num]);
			num = checked(num + 1);
		}
		while (num <= 15);
	}

	private static byte smethod_12(ref byte byte_4)
	{
		checked
		{
			return (byte)unchecked((byte_4 < 128) ? ((byte)(byte_4 << 1)) : ((byte)(byte_4 << 1) ^ 0x1B));
		}
	}

	private static byte smethod_13(ref byte byte_4)
	{
		return (byte)(smethod_12(ref byte_4) ^ byte_4);
	}

	private static byte smethod_14(ref byte byte_4)
	{
		byte byte_5 = smethod_12(ref byte_4);
		return smethod_12(ref byte_5);
	}

	private static byte smethod_15(ref byte byte_4)
	{
		byte byte_5 = smethod_12(ref byte_4);
		byte byte_6 = smethod_12(ref byte_5);
		return smethod_12(ref byte_6);
	}

	private static byte smethod_16(ref byte byte_4)
	{
		return (byte)(smethod_15(ref byte_4) ^ byte_4);
	}

	private static byte smethod_17(ref byte byte_4)
	{
		return (byte)(smethod_15(ref byte_4) ^ smethod_12(ref byte_4) ^ byte_4);
	}

	private static byte smethod_18(ref byte byte_4)
	{
		return (byte)(smethod_15(ref byte_4) ^ smethod_14(ref byte_4) ^ byte_4);
	}

	private static byte smethod_19(ref byte byte_4)
	{
		return (byte)(smethod_15(ref byte_4) ^ smethod_14(ref byte_4) ^ smethod_12(ref byte_4));
	}

	private static void smethod_20(ref byte[] byte_4)
	{
		byte[] array = new byte[16];
		int num = 0;
		checked
		{
			do
			{
				byte[] array2 = array;
				int num2 = num;
				byte[] obj = byte_4;
				int num3 = num;
				array2[num2] = obj[(num3 + ((num3 & 3) << 2)) & 0xF];
				num++;
			}
			while (num <= 15);
			int num4 = 0;
			do
			{
				byte_4[num4] = byte_1[array[num4]];
				num4++;
			}
			while (num4 <= 15);
			array = null;
		}
	}

	private static void smethod_21(ref byte[] byte_4)
	{
		byte[] array = new byte[16];
		int num = 0;
		checked
		{
			do
			{
				byte[] array2 = array;
				int num2 = num;
				byte[] obj = byte_4;
				int num3 = num;
				array2[num2] = obj[(num3 - ((num3 & 3) << 2)) & 0xF];
				num++;
			}
			while (num <= 15);
			int num4 = 0;
			do
			{
				byte_4[num4] = byte_2[array[num4]];
				num4++;
			}
			while (num4 <= 15);
			array = null;
		}
	}

	private static void smethod_22(ref byte[] byte_4)
	{
		byte[] array = new byte[16];
		int num = 0;
		do
		{
			array[num] = byte_4[num];
			num = checked(num + 1);
		}
		while (num <= 15);
		int num2 = 0;
		do
		{
			byte_4[num2] = (byte)checked(smethod_12(ref array[num2]) ^ smethod_13(ref array[num2 + 1]) ^ array[num2 + 2] ^ array[num2 + 3]);
			byte_4[checked(num2 + 1)] = (byte)checked(array[num2] ^ smethod_12(ref array[num2 + 1]) ^ smethod_13(ref array[num2 + 2]) ^ array[num2 + 3]);
			byte_4[checked(num2 + 2)] = (byte)checked(array[num2] ^ array[num2 + 1] ^ smethod_12(ref array[num2 + 2]) ^ smethod_13(ref array[num2 + 3]));
			byte_4[checked(num2 + 3)] = (byte)checked(smethod_13(ref array[num2]) ^ array[num2 + 1] ^ array[num2 + 2] ^ smethod_12(ref array[num2 + 3]));
			num2 = checked(num2 + 4);
		}
		while (num2 <= 15);
		array = null;
	}

	private static void smethod_23(ref byte[] byte_4)
	{
		byte[] array = new byte[16];
		int num = 0;
		do
		{
			array[num] = byte_4[num];
			num = checked(num + 1);
		}
		while (num <= 15);
		int num2 = 0;
		do
		{
			byte_4[num2] = (byte)checked(smethod_19(ref array[num2]) ^ smethod_17(ref array[num2 + 1]) ^ smethod_18(ref array[num2 + 2]) ^ smethod_16(ref array[num2 + 3]));
			byte_4[checked(num2 + 1)] = (byte)checked(smethod_16(ref array[num2]) ^ smethod_19(ref array[num2 + 1]) ^ smethod_17(ref array[num2 + 2]) ^ smethod_18(ref array[num2 + 3]));
			byte_4[checked(num2 + 2)] = (byte)checked(smethod_18(ref array[num2]) ^ smethod_16(ref array[num2 + 1]) ^ smethod_19(ref array[num2 + 2]) ^ smethod_17(ref array[num2 + 3]));
			byte_4[checked(num2 + 3)] = (byte)checked(smethod_17(ref array[num2]) ^ smethod_18(ref array[num2 + 1]) ^ smethod_16(ref array[num2 + 2]) ^ smethod_19(ref array[num2 + 3]));
			num2 = checked(num2 + 4);
		}
		while (num2 <= 15);
		array = null;
	}
}
internal class Class51 : IMessageHandler
{
	private Interface0 interface0_0;

	private readonly ILogger ilogger_0;

	private Interface0 method_0()
	{
		return interface0_0;
	}

	private void method_1(Interface0 interface0_1)
	{
		interface0_0 = interface0_1;
	}

	public Class51(ref Interface0 interface0_1, ref ILogger ilogger_1)
	{
		method_1(interface0_1);
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		Class48 class48_ = Class48.smethod_0(ref request);
		class48_ = Class50.smethod_2(ref class48_);
		ILogger logger = ilogger_0;
		string message = $"Received request: v{class48_.method_8().MajorVersion}, AppID: {class48_.method_8().ApplicationId}, Machine: {class48_.method_8().MachineNameString}";
		logger.LogMessage(ref message);
		Interface0 @interface = method_0();
		Class48 @class;
		KMSRequest kmsrequest_ = (@class = class48_).method_8();
		KMSResponse kMSResponse = @interface.imethod_0(ref kmsrequest_);
		@class.method_9(kmsrequest_);
		KMSResponse kMSResponse2 = kMSResponse;
		ILogger logger2 = ilogger_0;
		byte[] byte_ = Class27.smethod_0(ref logger2);
		byte[] array = new byte[16];
		int num = 0;
		do
		{
			array[num] = (byte)(class48_.method_12()[num] ^ class48_.method_6()[num]);
			num = checked(num + 1);
		}
		while (num <= 15);
		byte[] array2 = Guid.NewGuid().ToByteArray();
		byte[] array3 = Class50.smethod_0(array2);
		int num2 = 0;
		do
		{
			array2[num2] = (byte)(array2[num2] ^ array[num2]);
			num2 = checked(num2 + 1);
		}
		while (num2 <= 15);
		byte[] byte_2 = Guid.NewGuid().ToByteArray();
		byte[] array4 = Class50.smethod_8(ref byte_2, ref byte_2);
		byte[] array5 = Class1.smethod_2<byte>(kMSResponse2.GetByteArray(), array2, array3, byte_, array);
		byte[] byte_3 = Class50.smethod_5(BitConverter.ToUInt64(class48_.method_8().GetByteArray(), 84));
		byte[] array6 = new byte[16];
		int num3 = 0;
		do
		{
			array6[num3] = (byte)(byte_2[num3] ^ array4[num3]);
			num3 = checked(num3 + 1);
		}
		while (num3 <= 15);
		byte[] byte_4 = Class1.smethod_0(array6, array5);
		byte[] array7 = Class50.smethod_6(ref byte_3, ref byte_4);
		byte[] byte_5 = Class1.smethod_0(array5, Enumerable.ToArray<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array7, 16)));
		byte[] array8 = Class50.smethod_4(ref byte_5, ref byte_2);
		Class35 class2 = new Class35();
		class2.method_4(class48_.method_4());
		class2.method_6(byte_2);
		checked
		{
			class2.method_8(KMSResponse.Parse(Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)array8, (int)kMSResponse2.BodyLength)), isEncrypted: true));
			class2.method_10(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array8, (int)kMSResponse2.BodyLength), 16)));
			class2.method_12(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array8, (int)(unchecked((long)kMSResponse2.BodyLength) + unchecked((long)class2.method_9().Length))), 32)));
			class2.method_14(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array8, (int)(unchecked((long)kMSResponse2.BodyLength) + unchecked((long)class2.method_9().Length) + class2.method_11().Length)), 8)));
			class2.method_16(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array8, (int)(unchecked((long)kMSResponse2.BodyLength) + unchecked((long)class2.method_9().Length) + class2.method_11().Length + class2.method_13().Length)), 16)));
			class2.method_18(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array8, (int)(unchecked((long)kMSResponse2.BodyLength) + unchecked((long)class2.method_9().Length) + class2.method_11().Length + class2.method_13().Length + class2.method_15().Length)), 16)));
			class2.method_20(Enumerable.ToArray<byte>(Enumerable.Take<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)array8, (int)(unchecked((long)kMSResponse2.BodyLength) + unchecked((long)class2.method_9().Length) + class2.method_11().Length + class2.method_13().Length + class2.method_15().Length + class2.method_17().Length)), 10)));
			ILogger logger3 = ilogger_0;
			object arg = kMSResponse2.MajorVersion;
			string kMSPIDString = kMSResponse2.KMSPIDString;
			logger2 = ilogger_0;
			message = $"Sending response: v{arg}, PID: {kMSPIDString}, HwID: {Class2.smethod_8(ref byte_, ref logger2)}";
			logger3.LogMessage(ref message);
			return class2.method_21();
		}
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}
}
internal class Class52
{
	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private byte[] byte_0;

	private byte[] byte_1;

	public uint method_0()
	{
		return uint_0;
	}

	public void method_1(uint uint_3)
	{
		uint_0 = uint_3;
	}

	public uint method_2()
	{
		return uint_1;
	}

	public void method_3(uint uint_3)
	{
		uint_1 = uint_3;
	}

	public uint method_4()
	{
		return uint_2;
	}

	public void method_5(uint uint_3)
	{
		uint_2 = uint_3;
	}

	public byte[] method_6()
	{
		return byte_0;
	}

	public void method_7(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	public byte[] method_8()
	{
		return byte_1;
	}

	public void method_9(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	public byte[] method_10()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_4());
		binaryWriter.Write(method_6());
		binaryWriter.Write(method_8());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public static Class52 smethod_0(byte[] byte_2)
	{
		Class52 @class = new Class52();
		MemoryStream input = new MemoryStream(byte_2);
		BinaryReader binaryReader = new BinaryReader(input);
		@class.method_1(binaryReader.ReadUInt32());
		@class.method_3(binaryReader.ReadUInt32());
		@class.method_5(binaryReader.ReadUInt32());
		@class.method_7(binaryReader.ReadBytes(16));
		@class.method_9(binaryReader.ReadBytes(checked(byte_2.Length - 8 - 4 - 16)));
		return @class;
	}
}
internal class Class36 : Class30
{
	private uint uint_0;

	private byte[] byte_0;

	private byte[] byte_1;

	public uint method_3()
	{
		return uint_0;
	}

	public void method_4(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public byte[] method_5()
	{
		return byte_0;
	}

	public void method_6(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	public byte[] method_7()
	{
		return byte_1;
	}

	public void method_8(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	public override uint vmethod_0()
	{
		return checked((uint)(4 + method_5().Length + method_7().Length));
	}

	public static Class36 smethod_0(byte[] byte_2)
	{
		Class36 @class = new Class36();
		MemoryStream input = new MemoryStream(byte_2);
		BinaryReader binaryReader = new BinaryReader(input);
		@class.method_4(binaryReader.ReadUInt32());
		@class.method_6(binaryReader.ReadBytes(16));
		@class.method_8(binaryReader.ReadBytes(checked(byte_2.Length - 2 - 2 - 16)));
		return @class;
	}

	public byte[] method_9()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(vmethod_0());
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_1());
		binaryWriter.Write(method_3());
		binaryWriter.Write(method_5());
		binaryWriter.Write(method_7());
		binaryWriter.Write(method_2());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class53 : IMessageHandler
{
	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(0u);
		binaryWriter.Write(0u);
		binaryWriter.Write(3221549122u);
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}
}
internal class Class54 : ILogger
{
	void ILogger.LogMessage(ref string message)
	{
		Console.WriteLine(Convert.ToString(DateTime.Now.ToString("s") + "\t") + message);
	}
}
namespace AutoPico.Logging
{
	public interface ILogger
	{
		void LogMessage(ref string message);
	}
}
internal class Class55 : ILogger
{
	private static readonly StringBuilder stringBuilder_0 = new StringBuilder();

	void ILogger.LogMessage(ref string message)
	{
		stringBuilder_0.AppendLine(message);
	}

	public string method_0(bool bool_0 = true)
	{
		string result = stringBuilder_0.ToString();
		if (bool_0)
		{
			stringBuilder_0.Clear();
		}
		return result;
	}
}
internal class Class56
{
	[CompilerGenerated]
	internal sealed class Class57
	{
		public Variables variables_0;

		internal void method_0()
		{
			smethod_1(ref variables_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class58
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public Variables variables_0;

		public string string_4;

		internal void method_0()
		{
			smethod_6(ref string_0, ref string_1, ref string_2, ref string_3, ref variables_0);
		}

		internal void method_1()
		{
			ref string reference = ref string_0;
			ref string reference2 = ref string_2;
			string empty = string.Empty;
			smethod_3(ref reference, ref reference2, ref empty, ref string_3, ref string_4, ref variables_0);
		}
	}

	private const uint uint_0 = 0u;

	private const uint uint_1 = 0u;

	private const uint uint_2 = 34u;

	private const int int_0 = 1073741828;

	private static FileStream fileStream_0 = null;

	private static EventWaitHandle eventWaitHandle_0 = null;

	private static EventWaitHandle eventWaitHandle_1 = null;

	private static int int_1 = 0;

	internal static void smethod_0(ref Variables variables_0)
	{
		Variables variables_ = variables_0;
		variables_0.IsSecohQad.Value = false;
		Class11.smethod_1(bool_0: false, ref variables_0);
		variables_0.IsWinDivert.Value = false;
		Class15.smethod_1(ref variables_0);
		new Thread((ThreadStart)delegate
		{
			smethod_1(ref variables_);
		}).Start();
	}

	internal static void smethod_1(ref Variables variables_0)
	{
		smethod_2(ref variables_0);
	}

	private static void smethod_2(ref Variables variables_0)
	{
		FileLogger logger = variables_0.Logger;
		string message = "Loading TunnelTap...";
		logger.LogMessage(ref message);
		string string_4 = "KMS-Windows ELDI";
		string string_3 = WMINetWorkAdapter.smethod_2(ref string_4, ref variables_0);
		if (string.IsNullOrEmpty(string_3))
		{
			string_4 = "TAP-Windows Adapter V9";
			string_3 = WMINetWorkAdapter.smethod_2(ref string_4, ref variables_0);
		}
		if (string.IsNullOrEmpty(string_3) && variables_0.IntentosTunTap < 8)
		{
			FileLogger logger2 = variables_0.Logger;
			message = "Installing TAP Driver";
			logger2.LogMessage(ref message);
			message = "OpenVPN.cer";
			string[] array = Class2.smethod_0(ref variables_0, ref message, variables_0.DirectorioActual + "\\driver");
			message = array[0] + "\\" + array[1];
			WMINetWorkAdapter.smethod_9(ref message, ref variables_0);
			message = "tap-windows-9.21.0.exe";
			array = Class2.smethod_0(ref variables_0, ref message, variables_0.DirectorioActual + "\\driver");
			ArrayList arrayList_ = new ArrayList();
			arrayList_.Add("/S");
			bool bool_ = true;
			Class3.smethod_1(ref array, ref arrayList_, ref variables_0, ref bool_);
			string_3 = WMINetWorkAdapter.smethod_2(ref string_4, ref variables_0);
			if (string.IsNullOrEmpty(string_3))
			{
				variables_0.IsWinDivert.Value = true;
				variables_0.IsTapDriver.Value = false;
				variables_0.IsSecohQad.Value = false;
				Thread.Sleep(Class2.smethod_2(50, 600));
				HostServer hostServer_ = null;
				Class3.smethod_19(ref variables_0, ref hostServer_);
			}
		}
		string string_0 = variables_0.KmsHostForward.IpAddress;
		string string_1 = string.Empty;
		string[] array2 = string_0.Split(new char[1]
		{
			'.'
		});
		try
		{
			string_0 = $"{array2[0]:D3}.{array2[1]:D3}.{array2[2]:D3}.";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			variables_0.KmsHostForward.IpAddress = WMINetWorkAdapter.smethod_13();
			string_0 = variables_0.KmsHostForward.IpAddress;
			ProjectData.ClearProjectError();
		}
		string_1 = string_0;
		string_0 += "1";
		string_1 += "0";
		string string_2 = "255.255.255.0";
		try
		{
			ref string string_5 = ref string_3;
			int num = 1;
			if (WMINetWorkAdapter.smethod_1(ref string_5, ref num, ref variables_0))
			{
				ref string string_6 = ref string_3;
				bool bool_ = true;
				WMINetWorkAdapter.smethod_4(ref string_6, ref bool_, ref variables_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
			FileLogger logger3 = variables_0.Logger;
			message = "Error: " + str;
			logger3.LogMessage(ref message);
			ProjectData.ClearProjectError();
		}
		variables_0.IsTapDriverLoaded = true;
		Variables variables_ = variables_0;
		new Thread((ThreadStart)delegate
		{
			smethod_6(ref string_0, ref string_1, ref string_2, ref string_3, ref variables_);
		}).Start();
		new Thread((ThreadStart)delegate
		{
			ref string string_7 = ref string_0;
			ref string string_8 = ref string_2;
			string string_9 = string.Empty;
			smethod_3(ref string_7, ref string_8, ref string_9, ref string_3, ref string_4, ref variables_);
		}).Start();
	}

	private static void smethod_3(ref string string_0, ref string string_1, ref string string_2, ref string string_3, ref string string_4, ref Variables variables_0)
	{
		if (!string.IsNullOrEmpty(string_3))
		{
			WMINetWorkAdapter.smethod_5(ref string_3, ref string_4, ref string_0, ref string_1, ref string_2, ref variables_0);
			return;
		}
		FileLogger logger = variables_0.Logger;
		string message = "Error: Not Network TAP Found";
		logger.LogMessage(ref message);
		checked
		{
			variables_0.IntentosTunTap++;
			HostServer hostServer_ = null;
			Class3.smethod_19(ref variables_0, ref hostServer_);
		}
	}

	private static void smethod_4(IAsyncResult iasyncResult_0)
	{
		fileStream_0.EndWrite(iasyncResult_0);
		eventWaitHandle_1.Set();
	}

	private static void smethod_5(IAsyncResult iasyncResult_0)
	{
		int_1 = fileStream_0.EndRead(iasyncResult_0);
		eventWaitHandle_0.Set();
	}

	private static void smethod_6(ref string string_0, ref string string_1, ref string string_2, ref string string_3, ref Variables variables_0)
	{
		checked
		{
			try
			{
				FileLogger logger = variables_0.Logger;
				string message = "Starting TunnelTap : " + string_0;
				logger.LogMessage(ref message);
				int val = (int)WMINetWorkAdapter.smethod_10(string_0);
				int val2 = (int)WMINetWorkAdapter.smethod_10(string_1);
				int val3 = (int)WMINetWorkAdapter.smethod_10(string_2);
				SafeFileHandle safeFileHandle = CreateFile(Convert.ToString("\\\\.\\Global\\") + string_3 + ".tap", 3u, 3u, (IntPtr)0, 3u, 1073741828u, IntPtr.Zero);
				IntPtr intPtr = Marshal.AllocHGlobal(4);
				IntPtr intPtr2 = Marshal.AllocHGlobal(12);
				int num = 0;
				Marshal.WriteInt32(intPtr, 1);
				uint uint_ = smethod_7(6u, 0u);
				uint uint_2 = 0u;
				DeviceIoControl(safeFileHandle, uint_, intPtr, 4u, intPtr, 4, ref uint_2, IntPtr.Zero);
				num = (int)uint_2;
				Marshal.WriteInt32(intPtr2, 0, val);
				Marshal.WriteInt32(intPtr2, 4, val2);
				Marshal.WriteInt32(intPtr2, 8, val3);
				uint uint_3 = smethod_7(10u, 0u);
				uint_2 = (uint)num;
				DeviceIoControl(safeFileHandle, uint_3, intPtr2, 12u, intPtr2, 12, ref uint_2, IntPtr.Zero);
				num = (int)uint_2;
				fileStream_0 = new FileStream(safeFileHandle, FileAccess.ReadWrite, 10000, isAsync: true);
				byte[] array = new byte[10001];
				int num2 = default(int);
				int num3 = default(int);
				eventWaitHandle_0 = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
				eventWaitHandle_1 = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
				AsyncCallback callback = smethod_5;
				AsyncCallback callback2 = smethod_4;
				while (true)
				{
					fileStream_0.BeginRead(array, 0, 10000, callback, num2);
					eventWaitHandle_0.WaitOne();
					int num4 = 0;
					do
					{
						byte b = array[12 + num4];
						array[12 + num4] = array[16 + num4];
						array[16 + num4] = b;
						num4++;
					}
					while (num4 <= 3);
					fileStream_0.BeginWrite(array, 0, int_1, callback2, num3);
					eventWaitHandle_1.WaitOne();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger2 = variables_0.Logger;
				string message = "Error: " + str;
				logger2.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static uint smethod_7(uint uint_3, uint uint_4)
	{
		return smethod_8(34u, uint_3, uint_4, 0u);
	}

	private static uint smethod_8(uint uint_3, uint uint_4, uint uint_5, uint uint_6)
	{
		return (uint_3 << 16) | (uint_6 << 14) | (uint_4 << 2) | uint_5;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeFileHandle CreateFile(string string_0, uint uint_3, uint uint_4, IntPtr intptr_0, uint uint_5, uint uint_6, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint DeviceIoControl(SafeFileHandle safeFileHandle_0, uint uint_3, IntPtr intptr_0, uint uint_4, IntPtr intptr_1, int int_2, ref uint uint_5, IntPtr intptr_2);
}
internal class Class59 : IMessageHandler
{
	private IMessageHandler imessageHandler_0;

	private Class66 class66_0;

	public Class59(IMessageHandler imessageHandler_1, Class66 class66_1)
	{
		imessageHandler_0 = imessageHandler_1;
		class66_0 = class66_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		byte[] request2 = method_0().method_26();
		return imessageHandler_0.HandleRequest(ref request2);
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}

	private Class65 method_0()
	{
		Class65 @class = new Class65();
		@class.method_1(5);
		@class.method_3(0);
		@class.method_5(Enum1.const_14);
		@class.method_7(Enum0.flag_0 | Enum0.flag_1 | Enum0.flag_4);
		@class.method_9(16u);
		@class.method_11(72);
		@class.method_13(0);
		@class.method_15(2u);
		@class.method_21(class66_0.method_20());
		@class.method_19(5840);
		@class.method_17(5840);
		@class.method_23(1u);
		return @class;
	}
}
internal class Class65 : Class64
{
}
internal class Class64 : Class63
{
	private uint uint_3;

	private List<Class71> list_0;

	public uint method_22()
	{
		return uint_3;
	}

	public void method_23(uint uint_4)
	{
		uint_3 = uint_4;
	}

	public List<Class71> method_24()
	{
		return list_0;
	}

	public void method_25(List<Class71> list_1)
	{
		list_0 = list_1;
	}

	public static Class64 smethod_0(byte[] byte_2)
	{
		MemoryStream input = new MemoryStream(byte_2);
		BinaryReader binaryReader = new BinaryReader(input);
		Class64 @class = new Class64();
		@class.method_1(binaryReader.ReadByte());
		@class.method_3(binaryReader.ReadByte());
		@class.method_5((Enum1)binaryReader.ReadByte());
		@class.method_7((Enum0)binaryReader.ReadByte());
		@class.method_9(binaryReader.ReadUInt32());
		@class.method_11(binaryReader.ReadUInt16());
		@class.method_13(binaryReader.ReadUInt16());
		@class.method_15(binaryReader.ReadUInt32());
		@class.method_17(binaryReader.ReadUInt16());
		@class.method_19(binaryReader.ReadUInt16());
		@class.method_21(binaryReader.ReadUInt32());
		@class.method_23(binaryReader.ReadUInt32());
		@class.method_25(new List<Class71>());
		checked
		{
			int num = (int)(unchecked((long)@class.method_22()) - 1L);
			for (int i = 0; i <= num; i++)
			{
				Class71 class2 = new Class71();
				class2.method_1((ushort)binaryReader.ReadInt16());
				class2.method_3((ushort)binaryReader.ReadInt16());
				class2.method_5(new Guid(binaryReader.ReadBytes(16)));
				class2.method_7((ushort)binaryReader.ReadInt16());
				class2.method_9((ushort)binaryReader.ReadInt16());
				class2.method_11(new Guid(binaryReader.ReadBytes(16)));
				class2.method_13((uint)binaryReader.ReadInt32());
				@class.method_24().Add(class2);
			}
			return @class;
		}
	}

	public byte[] method_26()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_2());
		binaryWriter.Write((byte)method_4());
		binaryWriter.Write((byte)method_6());
		binaryWriter.Write(method_8());
		binaryWriter.Write(method_10());
		binaryWriter.Write(method_12());
		binaryWriter.Write(method_14());
		binaryWriter.Write(method_16());
		binaryWriter.Write(method_18());
		binaryWriter.Write(method_20());
		binaryWriter.Write(method_22());
		checked
		{
			int num = (int)(unchecked((long)method_22()) - 1L);
			for (int i = 0; i <= num; i++)
			{
				Class71 @class = method_24()[i];
				binaryWriter.Write(@class.method_0());
				binaryWriter.Write(@class.method_2());
				binaryWriter.Write(@class.method_4().ToByteArray());
				binaryWriter.Write(@class.method_6());
				binaryWriter.Write(@class.method_8());
				binaryWriter.Write(@class.method_10().ToByteArray());
				binaryWriter.Write(@class.method_12());
			}
			binaryWriter.Flush();
			memoryStream.Position = 0L;
			return memoryStream.ToArray();
		}
	}
}
internal class Class67 : Class66
{
	public static Class67 smethod_1(byte[] byte_3)
	{
		MemoryStream input = new MemoryStream(byte_3);
		BinaryReader binaryReader = new BinaryReader(input);
		Class67 @class = new Class67();
		@class.method_1(binaryReader.ReadByte());
		@class.method_3(binaryReader.ReadByte());
		@class.method_5((Enum1)binaryReader.ReadByte());
		@class.method_7((Enum0)binaryReader.ReadByte());
		@class.method_9(binaryReader.ReadUInt32());
		@class.method_11(binaryReader.ReadUInt16());
		@class.method_13(binaryReader.ReadUInt16());
		@class.method_15(binaryReader.ReadUInt32());
		@class.method_17(binaryReader.ReadUInt16());
		@class.method_19(binaryReader.ReadUInt16());
		@class.method_21(binaryReader.ReadUInt32());
		checked
		{
			@class.method_23((ushort)binaryReader.ReadInt16());
			if (@class.method_22() > 0)
			{
				@class.method_25(binaryReader.ReadBytes(@class.method_22()));
				binaryReader.ReadByte();
			}
			else
			{
				binaryReader.ReadByte();
				binaryReader.ReadByte();
			}
			@class.method_27(binaryReader.ReadUInt32());
			@class.method_29(new List<Class72>());
			int num = (int)(unchecked((long)@class.method_26()) - 1L);
			for (int i = 0; i <= num; i++)
			{
				Class72 class2 = new Class72();
				class2.method_1((ushort)binaryReader.ReadInt16());
				class2.method_3((ushort)binaryReader.ReadInt16());
				class2.method_5(new Guid(binaryReader.ReadBytes(16)));
				class2.method_7((uint)binaryReader.ReadInt32());
				@class.method_28().Add(class2);
			}
			return @class;
		}
	}
}
internal class Class66 : Class63
{
	private ushort ushort_4;

	private byte[] byte_2;

	private uint uint_3;

	private List<Class72> list_0;

	public ushort method_22()
	{
		return ushort_4;
	}

	public void method_23(ushort ushort_5)
	{
		ushort_4 = ushort_5;
	}

	public byte[] method_24()
	{
		return byte_2;
	}

	public void method_25(byte[] byte_3)
	{
		byte_2 = byte_3;
	}

	public uint method_26()
	{
		return uint_3;
	}

	public void method_27(uint uint_4)
	{
		uint_3 = uint_4;
	}

	public List<Class72> method_28()
	{
		return list_0;
	}

	public void method_29(List<Class72> list_1)
	{
		list_0 = list_1;
	}

	public byte[] method_30()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_2());
		binaryWriter.Write((byte)method_4());
		binaryWriter.Write((byte)method_6());
		binaryWriter.Write(method_8());
		binaryWriter.Write(method_10());
		binaryWriter.Write(method_12());
		binaryWriter.Write(method_14());
		binaryWriter.Write(method_16());
		binaryWriter.Write(method_18());
		binaryWriter.Write(method_20());
		binaryWriter.Write(method_22());
		binaryWriter.Write(method_24());
		binaryWriter.Write((byte)0);
		binaryWriter.Write(method_26());
		foreach (Class72 item in method_28())
		{
			binaryWriter.Write(item.method_0());
			binaryWriter.Write(item.method_2());
			binaryWriter.Write(item.method_4().ToByteArray());
			binaryWriter.Write(item.method_6());
		}
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public static Class66 smethod_0(byte[] byte_3)
	{
		MemoryStream input = new MemoryStream(byte_3);
		BinaryReader binaryReader = new BinaryReader(input);
		Class66 @class = new Class66();
		@class.method_1(binaryReader.ReadByte());
		@class.method_3(binaryReader.ReadByte());
		@class.method_5((Enum1)binaryReader.ReadByte());
		@class.method_7((Enum0)binaryReader.ReadByte());
		@class.method_9(binaryReader.ReadUInt32());
		@class.method_11(binaryReader.ReadUInt16());
		@class.method_13(binaryReader.ReadUInt16());
		@class.method_15(binaryReader.ReadUInt32());
		@class.method_17(binaryReader.ReadUInt16());
		@class.method_19(binaryReader.ReadUInt16());
		@class.method_21(binaryReader.ReadUInt32());
		checked
		{
			@class.method_23((ushort)binaryReader.ReadInt16());
			@class.method_25(binaryReader.ReadBytes(@class.method_22()));
			binaryReader.ReadByte();
			@class.method_27(binaryReader.ReadUInt32());
			@class.method_29(new List<Class72>());
			int num = (int)(unchecked((long)@class.method_26()) - 1L);
			for (int i = 0; i <= num; i++)
			{
				Class72 class2 = new Class72();
				class2.method_1((ushort)binaryReader.ReadInt16());
				class2.method_3((ushort)binaryReader.ReadInt16());
				class2.method_5(new Guid(binaryReader.ReadBytes(16)));
				class2.method_7((uint)binaryReader.ReadInt32());
				@class.method_28().Add(class2);
			}
			return @class;
		}
	}
}
internal class Class60 : IMessageHandler
{
	private IKMSServerSettings ikmsserverSettings_0;

	public Class60(IKMSServerSettings ikmsserverSettings_1)
	{
		ikmsserverSettings_0 = ikmsserverSettings_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		Class64 request2 = Class64.smethod_0(request);
		return new Class70(ikmsserverSettings_0).AutoPico.KMSEmulator.IMessageHandler<Class64,Class66>.HandleRequest(ref request2).method_30();
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}
}
internal class Class61 : IMessageHandler
{
	private IMessageHandler imessageHandler_0;

	public Class61(IMessageHandler imessageHandler_1)
	{
		imessageHandler_0 = imessageHandler_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		byte[] request2 = smethod_0().method_26();
		return imessageHandler_0.HandleRequest(ref request2);
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}

	private static Class64 smethod_0()
	{
		Class64 @class = new Class64();
		@class.method_1(5);
		@class.method_3(0);
		@class.method_5(Enum1.const_11);
		@class.method_7(Enum0.flag_0 | Enum0.flag_1 | Enum0.flag_4);
		@class.method_9(16u);
		@class.method_11(160);
		@class.method_13(0);
		@class.method_15(2u);
		@class.method_21(0u);
		@class.method_19(5840);
		@class.method_17(5840);
		@class.method_23(3u);
		@class.method_25(new List<Class71>());
		List<Class71> list = @class.method_24();
		Class71 class2 = new Class71();
		class2.method_1(0);
		class2.method_3(1);
		class2.method_5(new Guid("51c82175-844e-4750-b0d8-ec255555bc06"));
		class2.method_7(1);
		class2.method_9(0);
		class2.method_11(new Guid("8a885d04-1ceb-11c9-9fe8-08002b104860"));
		class2.method_13(2u);
		list.Add(class2);
		List<Class71> list2 = @class.method_24();
		Class71 class3 = new Class71();
		class3.method_1(1);
		class3.method_3(1);
		class3.method_5(new Guid("51c82175-844e-4750-b0d8-ec255555bc06"));
		class3.method_7(1);
		class3.method_9(0);
		class3.method_11(new Guid("71710533-beba-4937-8319-b5dbef9ccc36"));
		class3.method_13(1u);
		list2.Add(class3);
		List<Class71> list3 = @class.method_24();
		Class71 class4 = new Class71();
		class4.method_1(2);
		class4.method_3(1);
		class4.method_5(new Guid("51c82175-844e-4750-b0d8-ec255555bc06"));
		class4.method_7(1);
		class4.method_9(0);
		class4.method_11(new Guid("6cb71c2c-9812-4540-0300-000000000000"));
		class4.method_13(1u);
		list3.Add(class4);
		return @class;
	}
}
internal class Class63 : Class62
{
	private ushort ushort_2;

	private ushort ushort_3;

	private uint uint_2;

	public ushort method_16()
	{
		return ushort_2;
	}

	public void method_17(ushort ushort_4)
	{
		ushort_2 = ushort_4;
	}

	public ushort method_18()
	{
		return ushort_3;
	}

	public void method_19(ushort ushort_4)
	{
		ushort_3 = ushort_4;
	}

	public uint method_20()
	{
		return uint_2;
	}

	public void method_21(uint uint_3)
	{
		uint_2 = uint_3;
	}
}
internal class Class62
{
	private byte byte_0;

	private byte byte_1;

	private Enum1 enum1_0;

	private Enum0 enum0_0;

	private uint uint_0;

	private ushort ushort_0;

	private ushort ushort_1;

	private uint uint_1;

	public byte method_0()
	{
		return byte_0;
	}

	public void method_1(byte byte_2)
	{
		byte_0 = byte_2;
	}

	public byte method_2()
	{
		return byte_1;
	}

	public void method_3(byte byte_2)
	{
		byte_1 = byte_2;
	}

	public Enum1 method_4()
	{
		return enum1_0;
	}

	public void method_5(Enum1 enum1_1)
	{
		enum1_0 = enum1_1;
	}

	public Enum0 method_6()
	{
		return enum0_0;
	}

	public void method_7(Enum0 enum0_1)
	{
		enum0_0 = enum0_1;
	}

	public uint method_8()
	{
		return uint_0;
	}

	public void method_9(uint uint_2)
	{
		uint_0 = uint_2;
	}

	public ushort method_10()
	{
		return ushort_0;
	}

	public void method_11(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	public ushort method_12()
	{
		return ushort_1;
	}

	public void method_13(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	public uint method_14()
	{
		return uint_1;
	}

	public void method_15(uint uint_2)
	{
		uint_1 = uint_2;
	}
}
internal class Class70 : IMessageHandler<Class64, Class66>
{
	private IKMSServerSettings ikmsserverSettings_0;

	private static uint uint_0;

	public Class70(IKMSServerSettings ikmsserverSettings_1)
	{
		ikmsserverSettings_0 = ikmsserverSettings_1;
	}

	Class66 IMessageHandler<Class64, Class66>.HandleRequest(ref Class64 request)
	{
		checked
		{
			uint_0 = (uint)(unchecked((long)uint_0) + 1L);
			Class66 @class = new Class66();
			@class.method_1(request.method_0());
			@class.method_3(request.method_2());
			@class.method_5(Enum1.const_12);
			@class.method_7(Enum0.flag_0 | Enum0.flag_1 | Enum0.flag_4);
			@class.method_9(request.method_8());
			@class.method_11(108);
			@class.method_13(request.method_12());
			@class.method_15(request.method_14());
			@class.method_17(request.method_16());
			@class.method_19(request.method_18());
			@class.method_21(uint_0);
			byte[] bytes = Encoding.ASCII.GetBytes(ikmsserverSettings_0.Port + "\0");
			@class.method_23((ushort)bytes.Length);
			@class.method_25(bytes);
			@class.method_27(3u);
			@class.method_29(new List<Class72>());
			List<Class72> list = @class.method_28();
			Class72 class2 = new Class72();
			class2.method_1(0);
			class2.method_3(0);
			class2.method_5(new Guid("8a885d04-1ceb-11c9-9fe8-08002b104860"));
			class2.method_7(2u);
			list.Add(class2);
			List<Class72> list2 = @class.method_28();
			Class72 class3 = new Class72();
			class3.method_1(2);
			class3.method_3(2);
			class3.method_5(Guid.Empty);
			class3.method_7(0u);
			list2.Add(class3);
			List<Class72> list3 = @class.method_28();
			Class72 class4 = new Class72();
			class4.method_1(3);
			class4.method_3(3);
			class4.method_5(Guid.Empty);
			class4.method_7(0u);
			list3.Add(class4);
			return @class;
		}
	}
}
namespace AutoPico.KMSEmulator
{
	public interface IMessageHandler<REQ, RESP>
	{
		RESP HandleRequest(ref REQ request);
	}
}
internal class Class71
{
	private ushort ushort_0;

	private ushort ushort_1;

	private Guid guid_0;

	private ushort ushort_2;

	private ushort ushort_3;

	private Guid guid_1;

	private uint uint_0;

	public ushort method_0()
	{
		return ushort_0;
	}

	public void method_1(ushort ushort_4)
	{
		ushort_0 = ushort_4;
	}

	public ushort method_2()
	{
		return ushort_1;
	}

	public void method_3(ushort ushort_4)
	{
		ushort_1 = ushort_4;
	}

	public Guid method_4()
	{
		return guid_0;
	}

	public void method_5(Guid guid_2)
	{
		guid_0 = guid_2;
	}

	public ushort method_6()
	{
		return ushort_2;
	}

	public void method_7(ushort ushort_4)
	{
		ushort_2 = ushort_4;
	}

	public ushort method_8()
	{
		return ushort_3;
	}

	public void method_9(ushort ushort_4)
	{
		ushort_3 = ushort_4;
	}

	public Guid method_10()
	{
		return guid_1;
	}

	public void method_11(Guid guid_2)
	{
		guid_1 = guid_2;
	}

	public uint method_12()
	{
		return uint_0;
	}

	public void method_13(uint uint_1)
	{
		uint_0 = uint_1;
	}
}
internal class Class72
{
	private ushort ushort_0;

	private ushort ushort_1;

	private Guid guid_0;

	private uint uint_0;

	public ushort method_0()
	{
		return ushort_0;
	}

	public void method_1(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	public ushort method_2()
	{
		return ushort_1;
	}

	public void method_3(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	public Guid method_4()
	{
		return guid_0;
	}

	public void method_5(Guid guid_1)
	{
		guid_0 = guid_1;
	}

	public uint method_6()
	{
		return uint_0;
	}

	public void method_7(uint uint_1)
	{
		uint_0 = uint_1;
	}
}
[Flags]
internal enum Enum0 : byte
{
	flag_0 = 0x1,
	flag_1 = 0x2,
	flag_2 = 0x4,
	flag_3 = 0x8,
	flag_4 = 0x10,
	flag_5 = 0x20,
	flag_6 = 0x40,
	flag_7 = 0x80
}
internal enum Enum1 : byte
{
	const_0 = 0,
	const_1 = 1,
	const_2 = 2,
	const_3 = 3,
	const_4 = 4,
	const_5 = 5,
	const_6 = 6,
	const_7 = 7,
	const_8 = 8,
	const_9 = 9,
	const_10 = 10,
	const_11 = 11,
	const_12 = 12,
	const_13 = 13,
	const_14 = 14,
	const_15 = 0xF,
	const_16 = 17,
	const_17 = 18,
	const_18 = 19
}
internal class Class73 : IMessageHandler
{
	private readonly ILogger ilogger_0;

	private IMessageHandler imessageHandler_0;

	private IMessageHandler method_0()
	{
		return imessageHandler_0;
	}

	private void method_1(IMessageHandler imessageHandler_1)
	{
		imessageHandler_0 = imessageHandler_1;
	}

	public Class73(IMessageHandler imessageHandler_1, ILogger ilogger_1)
	{
		method_1(imessageHandler_1);
		ilogger_0 = ilogger_1;
	}

	byte[] IMessageHandler.HandleRequest(ref byte[] request)
	{
		Class68 request2 = Class68.smethod_0(request);
		return new Class74(method_0(), ilogger_0).AutoPico.KMSEmulator.IMessageHandler<Class68,Class69>.HandleRequest(ref request2).method_26();
	}

	KMSResponse IMessageHandler.HandleRequest(ref KMSRequest request)
	{
		return null;
	}
}
internal class Class68 : Class62
{
	private uint uint_2;

	private ushort ushort_2;

	private ushort ushort_3;

	private byte[] byte_2;

	public uint method_16()
	{
		return uint_2;
	}

	public void method_17(uint uint_3)
	{
		uint_2 = uint_3;
	}

	public ushort method_18()
	{
		return ushort_2;
	}

	public void method_19(ushort ushort_4)
	{
		ushort_2 = ushort_4;
	}

	public ushort method_20()
	{
		return ushort_3;
	}

	public void method_21(ushort ushort_4)
	{
		ushort_3 = ushort_4;
	}

	public byte[] method_22()
	{
		return byte_2;
	}

	public void method_23(byte[] byte_3)
	{
		byte_2 = byte_3;
	}

	public static Class68 smethod_0(byte[] byte_3)
	{
		MemoryStream input = new MemoryStream(byte_3);
		BinaryReader binaryReader = new BinaryReader(input);
		Class68 @class = new Class68();
		@class.method_1(binaryReader.ReadByte());
		@class.method_3(binaryReader.ReadByte());
		@class.method_5((Enum1)binaryReader.ReadByte());
		@class.method_7((Enum0)binaryReader.ReadByte());
		@class.method_9(binaryReader.ReadUInt32());
		@class.method_11(binaryReader.ReadUInt16());
		@class.method_13(binaryReader.ReadUInt16());
		@class.method_15(binaryReader.ReadUInt32());
		@class.method_17(binaryReader.ReadUInt32());
		@class.method_19(binaryReader.ReadUInt16());
		@class.method_21(binaryReader.ReadUInt16());
		@class.method_23(binaryReader.ReadBytes(checked((int)@class.method_16())));
		return @class;
	}

	public byte[] method_24()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_2());
		binaryWriter.Write((byte)method_4());
		binaryWriter.Write((byte)method_6());
		binaryWriter.Write(method_8());
		binaryWriter.Write(method_10());
		binaryWriter.Write(method_12());
		binaryWriter.Write(method_14());
		binaryWriter.Write(method_16());
		binaryWriter.Write(method_18());
		binaryWriter.Write(method_20());
		binaryWriter.Write(method_22());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}
}
internal class Class74 : IMessageHandler<Class68, Class69>
{
	private readonly ILogger ilogger_0;

	private IMessageHandler imessageHandler_0;

	private IMessageHandler method_0()
	{
		return imessageHandler_0;
	}

	private void method_1(IMessageHandler imessageHandler_1)
	{
		imessageHandler_0 = imessageHandler_1;
	}

	public Class74(IMessageHandler imessageHandler_1, ILogger ilogger_1)
	{
		method_1(imessageHandler_1);
		ilogger_0 = ilogger_1;
	}

	Class69 IMessageHandler<Class68, Class69>.HandleRequest(ref Class68 request)
	{
		byte[] request2 = request.method_22();
		byte[] byte_ = method_0().HandleRequest(ref request2);
		Class69 @class = new Class69();
		@class.method_25(byte_);
		int num = @class.method_24().Length;
		@class.method_1(request.method_0());
		@class.method_3(request.method_2());
		@class.method_5(Enum1.const_2);
		@class.method_7(Enum0.flag_0 | Enum0.flag_1);
		@class.method_9(request.method_8());
		checked
		{
			@class.method_11((ushort)(24 + num));
			@class.method_13(request.method_12());
			@class.method_15(request.method_14());
			@class.method_17((uint)num);
			@class.method_19(request.method_18());
			@class.method_21(0);
			@class.method_23((byte)request.method_20());
			return @class;
		}
	}
}
internal class Class69 : Class62
{
	private uint uint_2;

	private ushort ushort_2;

	private byte byte_2;

	private byte byte_3;

	private byte[] byte_4;

	public uint method_16()
	{
		return uint_2;
	}

	public void method_17(uint uint_3)
	{
		uint_2 = uint_3;
	}

	public ushort method_18()
	{
		return ushort_2;
	}

	public void method_19(ushort ushort_3)
	{
		ushort_2 = ushort_3;
	}

	public byte method_20()
	{
		return byte_2;
	}

	public void method_21(byte byte_5)
	{
		byte_2 = byte_5;
	}

	public byte method_22()
	{
		return byte_3;
	}

	public void method_23(byte byte_5)
	{
		byte_3 = byte_5;
	}

	public byte[] method_24()
	{
		return byte_4;
	}

	public void method_25(byte[] byte_5)
	{
		byte_4 = byte_5;
	}

	public byte[] method_26()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(method_0());
		binaryWriter.Write(method_2());
		binaryWriter.Write((byte)method_4());
		binaryWriter.Write((byte)method_6());
		binaryWriter.Write(method_8());
		binaryWriter.Write(method_10());
		binaryWriter.Write(method_12());
		binaryWriter.Write(method_14());
		binaryWriter.Write(method_16());
		binaryWriter.Write(method_18());
		binaryWriter.Write(method_20());
		binaryWriter.Write(method_22());
		binaryWriter.Write(method_24());
		binaryWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream.ToArray();
	}

	public static Class69 smethod_0(byte[] byte_5)
	{
		MemoryStream input = new MemoryStream(byte_5);
		BinaryReader binaryReader = new BinaryReader(input);
		Class69 @class = new Class69();
		@class.method_1(binaryReader.ReadByte());
		@class.method_3(binaryReader.ReadByte());
		@class.method_5((Enum1)binaryReader.ReadByte());
		@class.method_7((Enum0)binaryReader.ReadByte());
		@class.method_9(binaryReader.ReadUInt32());
		@class.method_11(binaryReader.ReadUInt16());
		@class.method_13(binaryReader.ReadUInt16());
		@class.method_15(binaryReader.ReadUInt32());
		@class.method_17(binaryReader.ReadUInt32());
		@class.method_19(binaryReader.ReadUInt16());
		@class.method_21(binaryReader.ReadByte());
		@class.method_23(binaryReader.ReadByte());
		@class.method_25(binaryReader.ReadBytes(checked((int)@class.method_16())));
		return @class;
	}
}
[StandardModule]
internal sealed class Class75
{
	private static Variables variables_0 = null;

	[STAThread]
	public static void Main()
	{
		smethod_0();
		variables_0.IsSecohQad.Value = true;
		int int_ = Conversions.ToInteger("1688");
		string string_ = "NETSTAT.EXE";
		string[] string_2 = Class2.smethod_0(ref variables_0, ref string_);
		Class3.smethod_2(ref int_, ref string_2, ref variables_0);
		Class3.smethod_8(ref variables_0);
		if (!variables_0.IsSilent)
		{
			Class3.smethod_9(ref variables_0);
		}
		FileLogger logger = variables_0.Logger;
		string_ = "Time Start: " + variables_0.Tiempo;
		logger.LogMessage(ref string_);
		Class3.smethod_0(ref variables_0);
	}

	private static void smethod_0()
	{
		variables_0 = new Variables();
		variables_0.SystemRoot = Environment.GetEnvironmentVariable("SystemRoot");
	}
}
[StandardModule]
[CompilerGenerated]
[HideModuleName]
[DebuggerNonUserCode]
internal sealed class Class76
{
	internal static MySettings smethod_0()
	{
		return MySettings.Default;
	}
}
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Class77 : ConsoleApplicationBase
{
	public Class77()
		: this()
	{
	}
}
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Class78 : Computer
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerHidden]
	public Class78()
		: this()
	{
	}
}
[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class79
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class80
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if (gparam_0 != null && !((Control)gparam_0).get_IsDisposed())
			{
				return gparam_0;
			}
			if (hashtable_0 != null)
			{
				if (hashtable_0.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				hashtable_0 = new Hashtable();
			}
			hashtable_0.Add(typeof(T), null);
			TargetInvocationException ex2 = default(TargetInvocationException);
			try
			{
				return new T();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError((Exception)ex);
				ex2 = ex;
				return ex2.InnerException != null;
			}).Invoke())
			{
				throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[1]
				{
					ex2.InnerException!.Message
				}), ex2.InnerException);
			}
			finally
			{
				hashtable_0.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class80()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class80);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class81
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		int object.GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class81);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		string object.ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			if (gparam_0 == null)
			{
				return new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class81()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class82<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		[DebuggerHidden]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class82()
		{
		}
	}

	private static readonly Class82<Class78> class82_0 = new Class82<Class78>();

	private static readonly Class82<Class77> class82_1 = new Class82<Class77>();

	private static readonly Class82<User> class82_2 = new Class82<User>();

	private static Class82<Class80> class82_3 = new Class82<Class80>();

	private static readonly Class82<Class81> class82_4 = new Class82<Class81>();

	[DebuggerHidden]
	internal static Class78 smethod_0()
	{
		return class82_0.method_0();
	}

	[DebuggerHidden]
	internal static Class77 smethod_1()
	{
		return class82_1.method_0();
	}

	[DebuggerHidden]
	internal static User smethod_2()
	{
		return class82_2.method_0();
	}

	[DebuggerHidden]
	internal static Class80 smethod_3()
	{
		return class82_3.method_0();
	}

	[DebuggerHidden]
	internal static Class81 smethod_4()
	{
		return class82_4.method_0();
	}
}
[CompilerGenerated]
internal sealed class Class83
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct1
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
	private struct Struct2
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct3
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 176)]
	private struct Struct4
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
	private struct Struct5
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 24576)]
	private struct Struct6
	{
	}

	internal static readonly Struct5 struct5_0/* Not supported: data(52 09 6A D5 30 36 A5 38 BF 40 A3 9E 81 F3 D7 FB 7C E3 39 82 9B 2F FF 87 34 8E 43 44 C4 DE E9 CB 54 7B 94 32 A6 C2 23 3D EE 4C 95 0B 42 FA C3 4E 08 2E A1 66 28 D9 24 B2 76 5B A2 49 6D 8B D1 25 72 F8 F6 64 86 68 98 16 D4 A4 5C CC 5D 65 B6 92 6C 70 48 50 FD ED B9 DA 5E 15 46 57 A7 8D 9D 84 90 D8 AB 00 8C BC D3 0A F7 E4 58 05 B8 B3 45 06 D0 2C 1E 8F CA 3F 0F 02 C1 AF BD 03 01 13 8A 6B 3A 91 11 41 4F 67 DC EA 97 F2 CF CE F0 B4 E6 73 96 AC 74 22 E7 AD 35 85 E2 F9 37 E8 1C 75 DF 6E 47 F1 1A 71 1D 29 C5 89 6F B7 62 0E AA 18 BE 1B FC 56 3E 4B C6 D2 79 20 9A DB C0 FE 78 CD 5A F4 1F DD A8 33 88 07 C7 31 B1 12 10 59 27 80 EC 5F 60 51 7F A9 19 B5 4A 0D 2D E5 7A 9F 93 C9 9C EF A0 E0 3B 4D AE 2A F5 B0 C8 EB BB 3C 83 53 99 61 17 2B 04 7E BA 77 D6 26 E1 69 14 63 55 21 0C 7D) */;

	internal static readonly Struct2 struct2_0/* Not supported: data(30 00 31 00 32 00 33 00 34 00 35 00 36 00 37 00 38 00 39 00 41 00 42 00 43 00 44 00 45 00 46 00) */;

	internal static readonly Struct3 struct3_0/* Not supported: data(42 00 43 00 44 00 46 00 47 00 48 00 4A 00 4B 00 4D 00 50 00 51 00 52 00 54 00 56 00 57 00 58 00 59 00 32 00 33 00 34 00 36 00 37 00 38 00 39 00) */;

	internal static readonly long long_0/* Not supported: data(36 4F 46 3A 88 63 D3 5F) */;

	internal static readonly Struct2 struct2_1/* Not supported: data(FE 31 98 75 FB 48 84 86 9C F3 F1 CE 99 A8 90 64 AB 57 1F CA 47 04 50 58 30 24 E2 14 62 87 79 A0) */;

	internal static readonly Struct5 struct5_1/* Not supported: data(63 7C 77 7B F2 6B 6F C5 30 01 67 2B FE D7 AB 76 CA 82 C9 7D FA 59 47 F0 AD D4 A2 AF 9C A4 72 C0 B7 FD 93 26 36 3F F7 CC 34 A5 E5 F1 71 D8 31 15 04 C7 23 C3 18 96 05 9A 07 12 80 E2 EB 27 B2 75 09 83 2C 1A 1B 6E 5A A0 52 3B D6 B3 29 E3 2F 84 53 D1 00 ED 20 FC B1 5B 6A CB BE 39 4A 4C 58 CF D0 EF AA FB 43 4D 33 85 45 F9 02 7F 50 3C 9F A8 51 A3 40 8F 92 9D 38 F5 BC B6 DA 21 10 FF F3 D2 CD 0C 13 EC 5F 97 44 17 C4 A7 7E 3D 64 5D 19 73 60 81 4F DC 22 2A 90 88 46 EE B8 14 DE 5E 0B DB E0 32 3A 0A 49 06 24 5C C2 D3 AC 62 91 95 E4 79 E7 C8 37 6D 8D D5 4E A9 6C 56 F4 EA 65 7A AE 08 BA 78 25 2E 1C A6 B4 C6 E8 DD 74 1F 4B BD 8B 8A 70 3E B5 66 48 03 F6 0E 61 35 57 B9 86 C1 1D 9E E1 F8 98 11 69 D9 8E 94 9B 1E 87 E9 CE 55 28 DF 8C A1 89 0D BF E6 42 68 41 99 2D 0F B0 54 BB 16) */;

	internal static readonly long long_1/* Not supported: data(3A 1C 04 96 00 B6 00 76) */;

	internal static readonly long long_2/* Not supported: data(04 11 73 80 38 DD 77 FC) */;

	internal static readonly Struct6 struct6_0/* Not supported: data(36 AF 98 32 21 3E 26 2A 8A A3 2B F6 5C 6D 76 3A 04 A7 AD 1A DF 97 20 94 F9 C1 9D 2F 89 F0 F2 FF 62 6B 91 AA A0 EA 7B CE 85 2C 48 6C F8 69 AC B8 CB 45 C7 58 9A 59 9E 7E 7A B6 28 EF 4F 5A BF DD 33 46 FD 07 DE 54 47 71 BE 74 D9 72 66 0F EE 8B A1 7D 06 EC 8C 0E B0 5D 11 17 92 05 96 37 64 E3 10 1E D8 6E B2 8D A6 F7 61 0D F5 C2 A4 18 22 5F C0 CF A8 65 FE 0C D2 1D A2 4D 8F AE EB E1 7C 87 CA 02 4A 19 51 90 B1 4E 00 39 2E 44 FA 99 60 23 77 7F D5 CD DC 3D 81 12 03 83 86 56 B3 1B 49 E5 5B 14 01 79 6F BD 57 67 C8 CC 24 B9 8E 9F 3F F1 88 D0 F4 13 95 BA 30 6A 27 38 55 F3 0B 31 B7 A9 FB 41 9B E9 25 E7 73 78 E0 16 D7 D6 80 B5 42 29 5E 15 53 AB 63 2D 3B E8 9C DB C3 40 68 3C E4 0A 84 34 C9 D3 A5 BC 4C C5 08 93 82 75 43 C6 B4 DA BB E2 35 1F FC D1 50 D4 09 ED 4B E6 C4 1C 52 70 2F E3 7D BA 1A 0F EA 88 9E 10 92 0D CF 0C CB 2B D0 79 1D 39 AD 3C F9 ED 37 3E C4 FF F5 BF 2E 9B AC 94 C8 7A DC A5 A7 AA 51 F2 F8 4F 8A C2 75 C1 DF F6 7E A3 09 38 23 6F 63 FA CD 67 74 6B 73 7F F7 18 DA FB BE B4 29 D2 95 9A FD 30 AB 59 87 48 34 58 A0 97 F1 4D 77 0A 45 4B 8D 3B E7 D8 F3 A2 44 42 C7 50 C3 62 31 B6 F4 28 53 B9 D9 5B E5 08 EB 21 8C 27 33 5A BB DE 66 13 A8 52 8B 01 12 24 72 6D 00 A6 5E 64 E2 FC DD 85 A1 46 C0 EF 65 3F 9D 99 71 EC DB CA 6A A4 0E 41 54 2C 3A E8 02 32 56 D6 D3 03 E6 4E 1C B0 22 2A 80 98 89 68 D4 47 55 6C 7B 11 AF CC 35 76 9F 57 1F 4C 04 C5 E4 1B 5C B8 1E B3 91 49 07 25 EE B7 60 4A A9 84 05 81 5D C6 D7 20 16 93 E1 8F D1 61 9C 86 F0 E9 19 90 C9 8E 96 15 3D 69 B1 5F 0B 40 06 FE 36 78 6E BD B5 43 82 83 D5 E0 17 7C AE 14 CE BC 70 B2 26 2D 52 AD B2 73 A9 FA 29 E1 83 C0 19 7A CD A7 E3 DA 62 F1 3F DE 36 2E 94 9C AA 06 50 F8 65 B5 E0 60 B4 84 8C 5E E2 9A B8 F7 DC 12 6D 7C C7 5A 2B 2F D3 89 76 59 17 F0 6B 33 54 4A E8 D2 B6 10 C4 DB 90 9B C6 04 78 0A 18 A2 A1 CA 63 56 34 35 03 F5 D8 0B 80 CE B0 48 BD F6 07 E9 8B DF 20 A3 7F 38 AF 26 46 5F 2A 30 67 D7 57 39 A0 25 61 96 EB 70 B3 37 1F 32 D6 FC 58 01 B1 93 27 FF A8 05 EA 0E C5 C9 C2 DD 7B D1 D5 4C 95 D9 BF 8E C8 15 69 40 C3 77 3C 74 4E F9 E7 44 11 1C 6A 13 7E CC 1A 22 98 2D 43 09 72 49 81 88 4F 5B 1B 8A AB 8F 66 CF 7D 9D 79 BA 24 BB 28 A6 5C 3E AC B9 CB 0C 99 55 A4 92 3D B7 1E E4 D0 A5 0D 68 85 EC 3A 91 5D 97 53 BE 6F ED E5 0F 42 9E 87 00 75 D4 71 E6 F2 F4 45 14 51 6E 3B 8D F3 FD C1 BC 47 FB 16 21 82 EE 31 FE 1D EF 4B 86 23 2C 9F 64 08 02 6C 4D 41 AE 51 FB FF 66 EF E3 E8 F7 E2 3F 43 6A BF F3 95 A4 64 D3 CD 6E E9 5D 16 5E 54 E6 30 08 3B 36 40 39 58 63 AB A2 B2 07 69 23 81 A5 4C E5 65 71 31 A0 0E 91 02 8C 57 B7 53 90 E1 26 B3 7F 76 14 86 93 34 CE FA 8F 8E B8 17 9D 10 BB 77 BD 27 42 AF C6 CF 25 68 B4 79 94 45 C7 5B CC D8 DE AD 2A 5F FE 11 A7 D9 D7 6F 3E 7B 44 3C 0B A8 C4 EB 96 6D D1 61 AC 09 06 1B D4 37 C5 46 67 6B 84 B5 4E 22 28 83 D0 03 CB 78 87 98 59 E7 8D C9 F0 A9 EA 33 50 1C 04 BE B6 48 DB 15 F4 4F 9F CA 4A 80 2C 7A D2 C8 B0 92 DD 9E AE A6 74 ED 70 01 05 F6 38 47 56 3D DA 41 19 F9 A3 5C 73 9C 3A EE F1 7E 60 C2 F8 52 20 32 88 BA B1 EC 2E 1E 1F 29 DF 8B E0 49 7C 9A 62 97 DC F2 21 AA E4 0A 89 55 12 2D C3 A1 F5 00 1A 4D FD 85 0C 6C 75 4B BC C1 5A 7D 13 8A 0F FC D6 72 2B 99 1D 35 18 82 2F C0 24 9B B9 0D D5 54 8C C2 E0 99 7D DB 76 6C 41 C0 44 2B 72 A5 8F D3 56 24 4A 98 03 12 E5 35 2C DC 55 14 A4 59 43 F8 AC 74 9A 0C 4B 53 D0 F3 BD AB 78 CE 85 C3 3B 10 25 D2 B9 70 86 47 46 B5 77 E3 E8 6B D1 0B 79 9B A1 27 39 B7 A8 C5 63 05 2A A0 FA 18 40 64 83 1E 0F AF 61 58 5C B4 29 FF 2D C7 F7 CB 84 91 E9 23 8B D9 75 93 13 16 C6 4C AD 11 82 E7 EF 45 5D 6A 09 F0 B3 90 A9 BE D4 C1 00 21 DE 5A 92 DA 89 7B 71 EC 17 32 DD 1F 3E 6E 9C 42 8D 50 5F 38 F5 34 88 B2 CF F1 9D 65 52 22 1D 36 67 80 8E 48 FE 06 A7 F4 73 81 87 02 95 1C 9E 20 CD 31 ED 96 7C F6 9F 7E 1B 2E E4 49 E2 4E C4 D7 E1 A3 D6 6D 97 DF CA 2F 4D EA 26 B8 7F 0A C9 0E EE 5B D5 57 C8 68 F9 3C 28 15 BC D8 FC 30 7A EB 5E F2 FB 01 3A 19 60 62 6F 69 51 0D BF 4F 07 B0 04 94 37 3D 8A CC FD E6 AA 1A 33 BB 66 B1 AE B6 BA A6 3F 08 A2 DF 6F 92 88 FE E7 17 9E 53 C8 D9 2E 18 9D EF 81 E0 B9 6E 44 A7 8A 0B 8F 52 B6 10 BD 9F 47 09 2B A0 1A C0 B2 7E BC 28 23 BB 4D 8C 8D DB EE 19 72 05 4E 08 F0 38 76 60 B3 C7 80 98 1B 33 67 BF 51 00 4F 5A 22 34 E6 0C 3C 93 97 7F E2 D5 C4 64 AA D3 8B AF 48 CE E1 6B 31 7C 63 0E A8 50 6A EC F2 91 59 11 42 0A CB EA 15 5B 62 75 1F A1 C2 3B 78 2C 24 8E 96 87 66 DA 49 58 D8 DD 0D E8 40 12 BE 4B 45 83 35 E9 D6 FD AC 3A 56 AE 99 FF 43 79 04 9B 94 F3 3E A5 57 89 46 F9 16 D4 F5 B0 BA 27 DC 68 1D A6 5C 85 0F 1C 2A E5 2F 82 29 3D 54 B5 D0 FA 26 5D B7 D7 55 EB 06 4A 4C C9 5E CD 6C 3F B8 39 30 CA F1 FB B1 20 95 DE 77 13 37 A3 32 F7 E3 90 1E 9C 03 C1 02 C5 25 21 ED 73 B4 14 01 E4 86 6D F4 C3 69 7A 65 7D 71 D1 F8 70 AD 07 36 2D 61 5F FC F6 41 84 CC 7B CF A2 9A C6 74 D2 AB A9 A4 B2 9F B7 33 81 D8 7C 56 7F A7 13 31 8E 6A 85 28 DF C6 A6 2F 57 E7 B0 AA A5 20 B9 D7 F0 6B 16 E1 4E 00 8B 58 76 3D C8 30 5F 0B 69 87 B8 FF 23 A0 84 46 1B 10 22 98 8A F8 D6 E3 4A 21 75 83 B5 B4 D9 F6 09 53 B3 EB 70 97 52 68 CA D4 5B 44 90 36 DE 0C 04 34 77 38 1A 62 FC ED 92 5C AF AB DA 47 5E BF 71 E2 1C 14 AE B6 78 D0 86 2A E0 60 35 E5 F3 32 2D D2 61 A9 7A 29 FA 99 40 03 5A 63 27 4D 6F 9D 7E B1 AC A3 06 CB 82 88 E4 1F 2E C1 CD EC EE D1 94 C5 7D 73 0D BB 7B C7 3C 41 6E 02 A1 96 6D EF 3E D3 1E C2 8F 65 54 F5 80 07 74 72 66 F1 37 BD 12 24 25 50 64 9E 6C 05 E8 8D 17 DD 11 BA 3A F9 1D FD 26 A8 3B A4 39 2C BE DC D5 19 8C 4B 89 C3 AD 18 08 01 C9 F2 0A 9B DB CF 4F E6 0F 2B F4 BC F7 43 C4 67 79 CE 93 EA 9C 91 A2 9A 4C FE 5D 42 49 45 CC 55 51 FB 0E 3F 59 15 C0 E9 95 48 FC 9F 46 05 5C 65 21 4B F5 34 2B D4 67 AF 7C 2F 7E D6 80 2C E6 66 33 E3 58 B9 77 E4 1A 12 A8 B0 FA EB 94 5A A9 AD DC 41 D8 0A 02 32 71 3E 1C 64 54 6E CC D2 5D 42 96 30 DF F0 0F 55 B5 ED 76 91 D0 E5 4C 27 73 85 B3 B2 82 40 1D 16 24 9E 8C FE 59 0D 6F 81 BE F9 25 A6 48 06 8D 5E 70 3B CE 36 A3 26 BF D1 F6 6D 10 E7 D9 C0 A0 29 51 E1 B6 AC 79 A1 15 37 88 6C 83 2E B4 99 B1 35 87 DE 7A 50 08 39 5F 13 C6 EF 93 4E 5B 44 4F 43 CA 53 57 FD 95 EC 9A 97 A4 9C 4A F8 F2 BA F1 45 C2 61 7F C8 0C 9D DD C9 49 E0 09 2D 8F C5 AB 1E 0E 07 CF F4 3F 2A B8 DA D3 1F 8A 4D 3C FF 1B FB 20 AE 3D A2 6A 03 EE 8B 11 DB 17 BC 31 BB 14 22 23 56 62 98 52 F3 86 01 72 74 60 F7 6B E9 38 D5 18 C4 89 63 7D C1 3A 47 68 04 A7 90 E8 D7 92 C3 7B 75 0B BD 84 8E E2 19 28 C7 CB EA 69 9B 78 B7 AA A5 00 CD A8 C6 5F DA 9E 69 14 8F 50 D9 B9 A0 D5 CF 98 28 4E 6C D8 00 57 FA 15 F1 4C C8 E0 CD 29 03 A7 FE 5E 35 9C A9 CB CA FC 0A 6F 64 39 FB 87 F5 E7 5D F8 16 74 20 DF 5C 80 C7 27 F4 7F 31 4F B7 42 09 23 ED 92 83 38 A5 D4 D0 4B 7B 73 A1 1D 65 47 08 AB B5 17 2D 49 EF 3B 24 2C 76 89 A6 E8 0F 94 CC 7C 3F E6 85 32 58 1C 25 AD 52 4D 8C 56 05 D6 1E 55 F9 AF 07 9A 4A 1F 9F 9D 0E C0 21 C9 D1 6B 63 3E 43 B8 04 E9 DE 7D 11 BA EB AE 91 C4 72 0C 02 60 9B F7 FD 93 B2 BE 51 CE 01 E2 10 B4 79 DC D3 F2 97 7A 13 C5 6E A2 68 5B 6D C2 48 E1 1B 2F 5A 78 FF 8A 2B 8E 19 0D 0B AC 41 90 12 1A F0 BD 61 B0 A4 E4 75 54 70 99 30 67 D2 BC F6 8D B6 7E 77 A3 C1 53 46 34 F3 66 AA 82 62 86 45 DB 44 D7 59 6A 26 40 71 37 EA 96 BF 3A 36 3D 22 84 2E 2A B3 EE E3 95 EC 81 33 E5 DD 3C 88 C3 8B B1 06 18 BB BA 2D A8 AE 5C DB 88 29 53 B9 C2 1E E2 0F B1 33 CD 66 CB 01 34 51 B0 D9 B8 42 F9 8C CE F8 EB 61 11 30 F2 1D 38 C3 5E 54 DA 17 70 7F A2 6D B3 41 7D 4A B2 DE E0 9D A7 1B D1 67 A1 AF 48 19 32 0D 90 22 7E 46 40 4D 4F 36 A5 12 18 BB 2B 9F 28 60 49 94 1C 35 85 C9 D2 E3 8D 27 10 89 95 99 81 9E 50 97 09 C5 62 00 E5 F0 E7 78 FA 74 C1 21 E6 25 D3 F7 93 3A 07 13 D6 47 15 2E D4 DD 71 C4 55 1F FF 7C 64 23 B5 5B 83 D7 14 EC AA E1 57 84 92 DC 69 68 A9 5F 96 FD 0A 3F 56 24 FE 44 C7 CC 58 9A 59 F4 52 B6 CF ED A3 7B A0 8A 5D 04 6B EF 6E 43 CA 3D 2C B7 65 0B 79 FC 6C 76 8B 3B 7A F3 03 1A E9 39 3C BC 5A F6 A4 0C 72 6A C0 C8 AD 3E 82 63 FB 91 86 BF 9C DF 26 45 A6 F5 BD 75 F1 0E 2F EE 4C EA 87 98 16 08 8E B4 AC 4B 6F 37 D5 8F 05 2A 06 9B 73 77 4E 80 20 31 C6 BE AB E4 D8 E8 02 D0 51 29 3C 73 4F 7F 95 47 91 0C E4 E0 D9 17 B7 A6 3B DC F8 A0 42 18 92 BD DB 7D 10 0F 81 9F 19 23 31 62 2A E2 66 99 B8 79 6C 06 11 28 0B 48 B1 D2 E5 FD 57 5F 3A A9 15 F4 7E AE AB 2B CD 61 33 9B FB E1 1C AC ED 64 94 8D 5D AA BB 20 F2 9C EE 6B 37 1D CA 93 FC 78 F9 D4 CE 63 C5 21 58 7A 34 EC C1 B3 69 D3 50 5B CF 0D FE FF 3E C8 01 6A 9D A8 83 7B 3D 76 C0 13 05 4B 68 EB F3 B4 22 CC 14 40 82 B9 43 4A E6 53 C2 88 44 60 04 AD 90 84 41 D0 70 EF 6D E3 56 B6 71 B2 C7 00 9E 52 F5 97 72 67 1A B0 87 1E 02 0E 16 09 DE 03 8B A2 12 5E 45 74 32 85 8F 2C BC 08 BF F7 07 B5 E9 D1 D7 DA D8 A1 46 F0 36 38 DF 8E A5 9A EA DD 25 49 77 0A 30 8C 4D 80 E7 E8 35 FA 24 D6 86 A7 65 8A AF 54 C9 C3 2F D5 6E 1B 59 6F 7C F6 5A F1 5C 96 A3 C6 27 4E C4 2E 55 89 75 98 26 A4 2D BA 3F 39 CB 4C 1F BE 5E E2 19 64 4B 27 84 B3 CB F4 B1 E0 58 56 28 9E A7 AD C1 3A 0B E4 E8 C9 4A B8 5B 94 89 86 23 EE 49 20 CD A8 32 F8 34 9F 12 98 37 01 00 75 41 BB 71 D0 A5 22 51 57 43 D4 48 CA 1B F6 3B E7 AA 40 2F BE FE EA 6A C3 2A 0E AC E6 88 3D 2D 24 EC D7 1C 09 9B F9 F0 3C A9 6E 1F DC 38 D8 03 8D 1E 81 2B 1A 7C 30 E5 CC B0 6D 78 67 6C 60 E9 70 74 DE B6 CF B9 B4 87 BF 69 DB D1 99 D2 66 E1 42 5C EB 80 05 9C F2 D5 4E 33 C4 FA E3 83 0A 72 C2 95 8F 5A 82 36 14 AB 4F A0 0D 97 BA 92 16 A4 FD 59 73 F3 C6 6F 04 50 A6 90 91 A1 63 3E 35 07 BD AF DD 7A 2E 4C A2 9D DA 06 85 6B 25 AE 7D 53 18 ED 15 D9 C8 B7 79 8A 8E FF 62 FB 29 21 11 52 1D 3F 47 77 4D EF F1 7E 61 B5 13 FC D3 2C 76 96 CE 55 B2 DF BC 65 26 7F 46 02 68 D6 17 08 F7 44 8C 5F 0C 5D F5 A3 0F C5 45 10 C0 7B 9A 54 C7 39 31 8B 93 2A 46 E5 D2 3F 83 78 05 39 37 49 FF AA 95 D0 81 6A 85 89 A8 C6 CC A0 5B E8 E7 42 8F 2B D9 3A F5 53 99 55 FE 28 41 AC C9 61 14 20 DA 73 F9 56 60 30 36 22 B5 10 B1 C4 43 5A 86 CB 21 29 AB 7A 97 0B A2 4B 6F 4E DF 9F 8B 4C 45 8D B6 CD 87 E9 5C 91 5D C8 0F 7D 68 FA 98 62 EC 7F E0 7E BD 59 B9 84 AD D1 0C 4A 7B 1D 51 88 11 15 BF 19 06 0D 01 E6 DE 08 BA D7 AE D8 D5 80 23 3D 8A B0 F8 B3 07 B4 2F 52 A5 E1 64 FD 93 13 A3 F4 EE 9B 82 E2 6B CA 2E C1 6C 3B E3 57 75 C5 9C 38 12 F6 DB F3 77 31 C7 F1 F0 92 A7 0E 65 66 DC CE BC C0 02 5F 54 FC BB 67 E4 1B 4F 2D C3 32 79 8C 74 0A 44 CF 1C EB EF 9E 03 B8 A9 D6 18 33 7C 5E 26 9A 48 40 70 1F 00 D4 72 16 2C 8E 90 F7 AF 34 D3 9D B2 4D 17 1E 27 63 09 BE DD 04 47 25 ED 3E 6D B7 76 69 96 A4 24 71 A1 3C 94 C2 6E 58 50 EA F2 1A FB 35 A6 67 4A 62 E6 54 0D A9 83 AA 72 C6 E4 5B BF 50 FD 0A 13 73 FA 82 32 65 7F 70 F5 6C 02 25 BE C3 34 9B D5 5E 8D A3 E8 1D E5 8A DE BC 52 6D 2A F6 75 51 93 CE C5 F7 4D 5F 2D 03 36 9F F4 A0 56 60 61 0C 23 DC 86 66 3E A5 42 87 BD 1F 01 8E 91 45 E3 0B D9 D1 E1 A2 ED CF B7 29 38 47 89 7A 7E 0F 92 8B 6A A4 37 C9 C1 7B 63 AD 05 53 FF 35 B5 E0 30 26 E7 F8 07 B4 7C AF FC 2F 4C 95 D6 8F B6 F2 98 BA 48 AB 64 79 76 D3 1E 57 5D 31 CA FB 14 18 39 3B 04 41 10 A8 A6 D8 6E AE 12 E9 94 BB D7 74 43 B8 3A EB 06 CB 17 5A B0 81 20 55 D2 A1 A7 B3 24 E2 68 C7 F1 F0 85 B1 4B B9 D0 3D 58 C2 08 C4 6F EF 2C C8 28 F3 7D EE 71 EC F9 6B 09 00 CC 59 9E 5C 16 78 CD DD D4 1C 27 DF 4E 0E 1A 9A 33 DA FE 21 69 22 96 11 B2 AC 1B 46 3F 49 44 77 4F 99 2B 88 97 9C 90 19 80 84 2E DB EA 8C C0 15 3C 40 9D 69 F6 65 EB 30 D0 34 F7 86 41 D4 18 11 73 E1 F4 3F 04 CC C5 D5 60 0E 44 E6 C2 2B 82 02 16 56 C7 03 B4 AA 09 8E 3A 71 39 33 81 57 6F 5C 51 27 5E 36 9C 98 01 88 84 8F 90 85 58 24 0D D8 94 F2 C3 06 CB 6E 61 7C B3 50 A2 21 00 0C E3 D2 29 45 4F 76 C0 BE B0 08 59 1C 23 5B 6C CF A3 8C F1 0A B6 A8 42 0F D3 1E F3 22 A0 3C AB BF B9 CA 4D 38 99 53 A9 9D E8 E9 DF 70 FA 77 DC 10 DA 40 25 C8 A1 5A BD 26 7E 9E C4 3B 14 FB 5D 89 96 19 07 A5 9F AF D7 F5 BA F9 C9 C1 13 8A 17 66 62 91 5F 20 31 7B 63 D9 D1 2F BC 72 93 28 F8 AD 2D E7 4B 1D B5 E4 B7 64 AC 1F E0 FF 3E 80 EA AE 97 CE 8D 54 37 9B B1 15 4C FE 7A 52 7F E5 48 A7 43 FC DE 6A B2 67 7D 2A 9A E2 6B 0B 12 2C DB A6 3D 1A 74 ED 68 FD 05 F0 BB 95 46 CD 83 6D EE 32 75 4A A4 C6 92 35 47 55 EF DD D6 8B 49 79 78 4E B8 EC 87 2E 1B E7 95 87 3D 0F 04 59 9B AB AA 9C 6A 3E 55 FC C9 2F D7 22 69 47 94 1F 51 BF 3C E0 A7 98 76 14 40 B5 AF F8 48 30 B9 D9 C0 FE 09 74 EF C8 A6 3F BA 49 63 C7 9E 2C A8 80 AD 37 9A 75 91 2E 0C B8 60 36 65 B6 7E CD 32 2D EC 52 38 7C 45 1C 5F 86 E5 A9 B1 0B 03 FD 6E A0 41 FA 2A 7F FF 35 99 CF 67 7D 05 27 68 2B 1B 13 C1 58 C5 B4 B0 43 8D F2 E3 88 6F F4 AC 4C 16 E9 C6 29 8F 5B 44 CB D5 77 4D 81 7B 4F 3A 3B 0D A2 28 A5 0E C2 08 92 F7 1A 73 7A 90 DD 01 CC 21 F0 72 EE 79 6D 6B 18 9F EA 4B A4 12 6C 62 DA 8B CE F1 89 BE 1D 71 5E 23 D8 64 D4 19 BC B3 AE 61 82 70 F3 D2 DE 31 00 FB 97 9D E4 4E 4A D3 5A 56 5D 42 57 8A F6 DF 0A 46 20 11 D1 66 78 DB 5C E8 A3 EB E1 53 85 BD 8E 83 F5 8C ED D6 1E 17 07 B2 DC 96 34 10 F9 50 D0 C4 84 15 BB 24 B7 39 E2 02 E6 25 54 93 06 CA C3 A1 33 26 8B C4 D1 A9 BF 6D 87 B7 18 1C F4 69 5E 4F EF 21 58 00 24 C3 45 6A E0 BA F7 E8 85 23 DB E1 67 79 1A D2 9A C9 81 40 61 9E D0 E9 FE 94 2A 49 B0 F3 A7 AF 05 1D 0C ED 51 C2 D3 53 56 86 63 CB 99 35 54 E4 19 03 75 6C 9C 15 D8 43 52 A5 93 16 64 0A 6B 32 E5 CF 2C 01 80 04 D9 3D 9B 36 14 CC 82 A0 2B 91 4B 39 F5 37 A3 A8 30 C6 07 06 50 65 92 F9 8E C5 83 7B B3 FD EB 38 4C 0B 13 90 B8 EC 34 DA B2 BB 41 7A 70 3A AB 1E 55 FC 98 BC 28 B9 7C 68 1B 95 17 88 4A 89 4E AE AA 66 F8 3F 9F 8A 6F 0D E6 7F 48 E2 F1 EE F6 FA 5A 73 FB 26 8C BD A6 EA D4 77 7D CA 0F 47 F0 44 29 11 4D FF 59 20 22 2F C0 CE 08 BE 62 5D 76 27 B1 DD 25 12 74 C8 F2 8F 10 1F 78 B5 2E DC 02 CD 72 9D 5F 7E 3B 31 AC 57 E3 96 2D D7 0E 84 97 A1 6E A4 09 A2 B6 DF 3E 5B 71 AD D6 3C 5C DE 60 8D C1 C7 42 D5 46 E7 B4 33 55 5E 03 C1 BD CF DD 67 64 0F A6 93 F1 F0 C6 30 1D CE 45 0B 75 8D 78 33 C2 2C 4E 1A E5 66 BA FD 6A E3 83 9A EF F5 A2 12 92 FC 65 E0 A4 53 2E B5 76 F2 DA F7 13 39 9D C4 74 56 E2 3A 6D C0 2F CB 97 68 77 B6 6C 3F EC 24 46 05 DC BF 08 62 26 1F A7 34 FA 1B F3 EB 51 59 6F C3 95 3D A0 70 25 A5 71 41 49 9B 27 5F 7D 32 19 D7 A8 B9 02 9F EE EA 16 4C B3 9C D2 35 AE F6 91 8F 2D 17 73 D5 01 1E 61 57 F8 72 DB 21 15 60 C8 AD 40 29 FF 54 98 52 96 7B AA 28 20 CA 87 5B 42 C5 B0 11 B4 23 37 31 80 D1 94 AB FE 48 36 38 04 79 82 3E D3 E4 47 2B F4 3B D8 2A 8E 43 E6 E9 5A A1 CD C7 A9 88 84 6B 00 0C 07 18 BE 14 10 89 50 1C 7A 4B 0D D0 AC 85 06 B2 F9 B1 8B 3C 22 81 D4 D9 AF D6 BB 09 DF E7 5D E8 86 CC B7 8C 44 4D 8A 9E DE 4F 6E 4A A3 0A B8 58 BC 7F E1 7E ED 63 99 FB 69 7C 0E C9 5C 90 0A A9 B7 00 3A 72 39 8D 6C 54 82 30 5D 24 52 5F 02 9B 9F 35 93 8C 87 8B 0E 27 5B 86 C0 F1 97 DB E8 66 F5 6A F4 37 D3 33 1B D7 42 85 F7 E2 70 12 C6 CF 07 3C 47 0D 63 D6 81 28 C1 E5 C4 55 15 01 D0 0C 41 AB A3 21 F0 1D BA BC A8 3F 9A 3B 4E C9 EB 9E AA 50 F9 73 DC EA D9 13 DF 74 A2 CB 26 43 62 6D C8 05 A1 53 B0 7F E0 0F 03 22 4C 46 2A D1 B3 BD C3 75 20 1F 5A 0B A0 CC 6F 58 B5 09 F2 8F D2 DA 60 78 90 71 BF 2C 2E AE FB 2B B6 1E 48 E4 AF 67 B4 E7 3D FC E3 1C 94 AD E9 83 34 57 8E CD 7D 25 BE 59 17 38 C7 9D 95 8A 5E F8 9C A6 04 1A B9 F6 D4 AC 10 C2 CA FA 61 65 14 89 32 23 5C 92 B8 F3 06 FE 80 CE 45 96 76 31 ED 6E 91 C5 A7 49 EC 56 44 36 4A 88 D5 DE BB 4D 7B 7A 18 2D 84 EF 4F 16 B2 98 7C 51 79 FD 40 A4 4B E6 B1 69 DD FF 99 29 7E 64 11 08 68 E1 3E A5 D8 2F 6B EE 77 19 4F 26 C7 A2 97 5D F0 5B F7 7D 6E 58 1A 6F D4 2E BF 1E 4D CA 38 3E BB 2C A5 27 99 74 88 54 2F C5 8D 31 0B 76 48 24 DC EB 9B A4 8F DE 39 37 F1 47 C2 C8 55 AE 8B 64 A6 87 D7 25 FB 34 E9 E6 81 4C 75 44 5F 13 A3 8A 02 DF 08 17 0F 03 1F 86 B1 1B A0 D9 DB D6 D0 E8 B4 06 F6 BE 09 BD 2D 8E 84 33 D1 40 85 91 AC 05 61 45 89 C3 52 E7 4B 42 B8 83 66 73 96 F4 53 9F 01 C6 B3 70 B7 57 E2 6C EE 71 A9 9C 6B 00 C9 3F FE FF 0C CE 5A 51 D2 68 B2 C0 41 15 CD 23 B5 F2 EA 69 4A 04 12 C1 77 3C 7A 82 6A EF 9D F3 21 BA AB 5C 8C 95 65 EC AD 1D E0 FA ED 35 7B 59 20 C4 62 CF D5 F8 79 FD 92 CB 1C 36 D3 B0 49 0A 29 10 07 6D 78 B9 98 67 E3 2B 63 30 9A 32 60 CC 2A AA AF 7F F5 14 A8 3B 5E 56 FC E4 A7 B6 16 D8 E1 E5 0D 90 46 94 7E 4E 72 3D 28 50 22 18 9E 80 0E 11 7C DA BC 93 19 43 A1 F9 DD 3A 6D E7 F4 C2 80 F5 4E B4 D5 BC 5D 38 0D C7 6A C1 3F BD 03 EE 12 CE B5 5F 25 84 D7 50 A2 A4 21 B6 01 3E 15 44 A3 AD 6B DD 17 AB 91 EC D2 BE 46 71 4D BF 61 AE 73 7C 1B D6 58 52 CF 34 11 FE 3C 1D 92 8D 95 99 85 1C 2B 81 EF DE C5 89 39 10 98 45 6C 24 93 27 B7 14 1E A9 3A 43 41 4C 4A 72 2E 9C 13 59 C8 7D D1 D8 22 19 4B DA 1F 0B 36 9F FB DF 29 EA 2D CD 78 F6 74 EB FC E9 0C 6E C9 05 9B 5C 96 54 C0 CB 48 F2 28 5A 33 06 F1 9A 53 A5 64 65 D0 9E 88 5B ED A6 E0 18 DB 8F 57 B9 2F 68 70 F3 16 0F FF 76 37 87 7A 60 F0 75 07 69 BB 20 31 C6 4F 62 E3 67 08 51 86 AC 77 AF E1 C3 BA 5E F8 55 E2 23 02 FD 79 B1 F9 AA 49 2A D3 90 B3 8A 9D F7 6F 8E 32 A1 C4 CC 66 7E 00 A8 FA 56 B0 30 35 E5 DC 0E E4 D4 E8 A7 B2 CA 3D 2C 8C 42 7B 7F 97 0A 26 09 83 D9 3B 63 47 A0 B8 82 04 1A 94 8B E6 40 CD 64 8D A9 88 19 59 4D 8A 83 4B 70 0B 41 2F 9A 57 9B 0E C9 BB AE 3C 5E A4 2A B9 26 B8 7B 9F 7F 42 6B 17 CA 8C BD DB 97 4E D7 D3 79 DF C0 CB C7 20 18 CE 7C 11 68 1E 13 46 E5 FB 4C 76 3E 75 C1 EC 80 23 14 F9 45 BE C3 FF F1 8F 39 6C 53 16 47 AC 43 4F 6E 00 0A 66 9D 2E 21 84 49 ED 1F FC 33 95 5F 93 38 EE 87 6A 0F A7 D2 E6 1C B5 3F 90 A6 F6 F0 E4 73 D6 77 02 85 9C 40 0D E7 EF 6D BC 51 2D 29 58 C5 7E 6F 10 DE F5 BA 98 E0 5C 8E 86 B6 D9 C6 12 B4 D0 EA 48 56 31 69 F2 15 5B 74 8B D1 D8 E1 A5 CF 78 1B C2 81 E3 2B F8 AB 71 B0 AF 50 62 E2 B7 67 FA 52 04 A8 9E 96 2C 34 DC 3D F3 60 72 E9 94 63 27 A2 3B 55 D5 65 32 28 5D 44 24 AD 0C E8 07 AA FD 25 91 B3 03 5A FE D4 30 1D 35 B1 F7 01 37 36 54 61 C8 A3 A0 1A 08 7A 06 C4 99 92 3A 7D A1 22 DD 89 EB 05 F4 BF 4A B2 CC 82 09 DA F3 81 5B E1 62 69 FD 3F CC CD 0C FA 33 58 AF 9A B1 49 0F 44 F2 21 37 79 5A D9 C1 86 10 FE 26 72 C9 D3 2E 9E DF 56 A6 BF 6F 98 89 12 C0 AE DC 59 05 2F F8 A1 CE 4A CB E6 FC 51 F7 13 6A 48 06 DE 03 50 18 D0 54 AB 8A 4B 5E 34 23 1A 39 7A 83 E0 D7 CF 65 6D 08 9B 27 C6 4C 9C 99 19 FF 53 01 A9 63 1B 0E 41 7D 4D A7 75 A3 3E D6 D2 EB 25 85 94 09 EE CA 92 70 2A A0 8F E9 4F 22 3D B3 AD 2B 11 1D E7 5C 29 6B 5D 4E C4 68 C3 6E A4 91 F4 15 7C F6 1C 67 BB 47 AA 14 96 1F 88 0D 0B F9 7E 2D 8C 74 C2 04 0A ED BC 97 A8 D8 EF 17 7B 45 38 02 BE 7F B2 D5 DA 07 C8 16 E4 B4 95 57 B8 9D 66 FB F1 28 82 B5 2C 30 3C 24 3B EC 31 B9 90 20 6C 77 46 00 B7 BD 1E 8E 3A 8D C5 35 87 DB E3 E5 E8 EA 93 B0 8B 71 78 D4 61 F0 BA 76 52 36 9F A2 B6 73 E2 42 DD 5F D1 64 84 43 80 F5 32 AC 60 C7 A5 40 55 E2 32 67 E7 2D 81 D7 7F B1 A9 13 1B E5 76 B8 59 4A 20 64 5D 04 47 9E FD 2E 7D AE 66 D5 2A 35 F4 31 97 43 5C D3 CD 6F 55 90 77 EC B4 54 0E F1 DE 40 DD AC A8 5B 95 EA FB 65 1D 3F 70 33 03 0B D9 A7 24 F8 BF 80 6E 0C 58 37 CF 3A 71 5F 8C 07 49 B3 B2 84 72 26 4D E4 D1 FF 8D 9F 25 17 1C 41 83 2F 82 6D 89 36 14 A0 78 51 7B DF 86 34 B0 98 B5 E6 11 6C F7 D0 BE 27 A2 AD B7 E0 50 28 A1 C1 D8 F9 4B 9D A5 96 9B ED 94 C9 7E 60 C3 44 F0 BB F3 4F 92 EE C7 12 5E 38 09 FC 56 52 CB 42 4E 45 5A 4C 8B 1E D2 DB B9 2B 3E A3 3C AF 21 FA 1A FE 3D 2C 08 E1 48 C8 DC 9C 0D F5 CE 06 0F 1F AA C4 8E F6 61 75 73 00 87 F2 53 62 88 C5 19 D4 39 E8 6A BD 16 DA 10 8A EF 02 6B 99 63 57 22 23 15 BA 30 EB CA C6 29 18 E3 8F 85 CC 01 A4 AB B6 79 9A 68 91 A6 05 69 46 3B C0 7C BC 0A 74 7A C2 93 D6 E9 12 03 7C B2 41 45 34 A9 30 E2 EA DA 99 D6 F4 8C BC 86 24 3A B5 AA 7E D8 37 18 E7 BD 5D 05 9E 79 14 77 AE ED B4 8D C9 A3 1D DC C3 3C 8F 47 94 C7 96 3E 68 C4 0E 8E DB 0B B0 51 9F 0C F2 FA 40 58 4B CE 57 39 1E 85 F8 0F 31 28 48 C1 B9 09 5E 44 91 49 FD DF 60 84 6B C6 5C 71 59 DD 6F 36 92 B8 38 0D A4 CF 9B 6D 5B 5A 6A A8 F5 FE CC 76 64 16 B1 E5 87 69 56 11 CD 4E A0 EE 65 B6 98 D3 26 DE E4 75 35 21 A1 08 E1 C5 67 2D 43 F6 E6 EF 27 1C D7 C2 50 32 3B F7 62 A5 D4 17 F3 13 C8 46 D5 4A E0 D1 B7 FB 2E 07 7B A6 B3 AC A7 AB 22 BB BF 15 7D 04 72 7F 4C 74 A2 10 1A 52 19 AD 2A 89 97 20 95 29 D2 AF 80 EC 4F 78 00 3F 7A 2B 93 9D E3 55 6C 66 0A F1 C0 2F 23 02 81 73 90 5F 42 4D E8 25 82 EB 06 63 F9 33 FF 54 D9 53 FC CA CB BE 8A 70 BA 1B 6E E9 9A 9C 88 1F 83 01 D0 3D F0 2C 61 8B C7 0B 9E 59 2B 3E AC CE 34 BA 29 B6 28 EB 0F EF 5D F4 1D 39 18 89 C9 DD 1A 13 DB E0 9B D1 BF 0A B0 88 5E EC 81 F8 8E 83 D6 75 6B DC E6 AE E5 51 D2 FB 87 5A 1C 2D 4B 07 DE 47 43 E9 4F 50 5B 57 3C D3 DF FE 90 9A F6 0D BE B1 14 D9 7D 8F 6C A3 7C 10 B3 84 69 D5 2E 53 6F 61 1F A9 FC C3 86 D7 66 60 74 E3 46 E7 92 15 0C D0 9D 77 7F FD 2C C1 05 CF 03 A8 7E 17 FA 9F 37 42 76 8C 25 AF 00 36 49 56 82 24 40 7A D8 C6 A1 F9 62 85 CB E4 1B 41 BD B9 C8 55 EE FF 80 4E 65 2A 08 70 CC 1E 16 26 F2 72 27 F7 6A C2 94 38 0E 06 BC A4 4C AD 63 F0 48 71 35 5F E8 8B 52 11 73 BB 68 3B E1 20 3F C0 9C 78 97 3A 6D B5 01 23 93 CA 6E 44 A0 8D A5 21 E2 79 04 F3 B7 32 AB C5 45 F5 A2 B8 CD D4 B4 3D AA ED 31 B2 4D 19 7B 95 64 2F DA 22 5C 12 99 4A 67 91 A7 A6 C4 F1 58 33 30 8A 98 EA 96 54 09 02 61 FC 14 10 29 E7 47 56 A1 D9 CC 83 BF 8F 65 B7 2B 8D E0 FF 71 6F E9 D3 CB 2C 08 50 B2 E8 62 4D 9C F6 E1 D8 FB B8 41 22 C1 92 DA 12 96 69 48 89 8E 5E 5B DB 3D 91 C3 6B 15 0D A7 AF CA 59 E5 04 AD 5A 4B D0 02 6C 1E 9B 0B 11 EC 5C 1D 94 64 7D 3E 93 35 D1 A8 8A C4 1C C7 ED 3A 63 0C 88 09 24 0E 0F CE 38 F1 9A 6D 58 31 43 99 23 A0 AB 3F FD 98 1B 03 44 D2 3C E4 B0 73 8B CD 86 30 E3 F5 BB B4 90 F4 5D 60 74 B1 20 72 49 B3 BA 16 A3 32 78 37 F0 6E A2 05 67 82 97 80 1F 9D 13 A6 46 81 42 2E F3 7B 52 E2 AE B5 84 EA 40 77 EE F2 FE E6 F9 F7 45 19 21 27 2A 28 51 C2 75 7F DC 4C F8 4F 07 1A 2D D5 B9 87 FA C0 7C B6 00 C6 C8 2F 7E 55 6A 76 57 95 7A 5F A4 39 33 BD 70 17 18 C5 0A D4 26 AA 01 AC 66 53 36 D7 BE DF 25 9E EB A9 9F 8C 06 DD 4A CF C9 3B BC EF 4E 34 DE A5 79 85 68 D6 54 24 BF AE 59 6F EA 98 F6 A8 18 E5 FF 89 90 60 E9 25 C1 67 CA E8 30 7E 5C 97 CE 19 33 D0 FD 7C F8 CC 3A FB FA AC 99 6E 05 D7 6D B7 C5 09 CB 5F 54 B0 F7 EF 6C 44 10 C8 26 72 39 7F 87 4F 01 17 C4 E4 E0 08 95 A2 B3 13 DD 77 38 2D 55 43 91 7B 4B 0B 14 79 DF 27 1D 9B 85 A4 FC D8 3F B9 96 1C 46 2C 15 02 68 D6 B5 4C 0F E6 2E 66 35 7D BC 9D 62 2F AF AA 7A 9F 37 65 C9 5B 53 F9 E1 F0 11 AD 3E 4D 21 D9 EE 88 34 0E 73 3C 32 F4 42 9E A1 8A DB 8E 61 A3 82 C7 CD 50 AB EC E3 84 49 D2 20 FE 31 92 58 F5 5E 4A 23 C2 A7 1F 6A D1 2B F2 78 6B 5D 3D 3B BE 29 BA 1B 48 CF 8D 51 2A C0 A0 22 9C 71 A9 00 64 40 D4 45 80 94 4E 47 BD 86 8C C6 57 E2 56 9A 04 C3 63 76 93 F1 E7 69 EB 74 B6 75 B2 52 A6 8F 07 DA 70 41 5A 16 1A 83 B4 1E 0D 12 0A 06 D5 ED B1 03 A5 DC DE D3 28 8B 81 36 F3 BB 0C B8 5B 18 E1 82 3C 56 41 78 36 C9 E8 29 61 32 7A B2 9D 31 63 CB 2E FE FB 7B 6A F9 45 A4 B5 AD 07 0F 89 47 E7 F6 C1 5C B4 B0 1F 2F C5 17 01 79 6C 23 D1 CF 49 73 8B 2D 40 5F 12 48 C2 ED 6B 8C A8 F0 51 3A CD F8 AE AF 6E 98 00 0B 9F 5D 91 E3 39 83 72 9C 44 10 38 BB A3 E4 90 43 55 1B D3 2B 6D 26 A2 CC BE 3B 0D FA EB 70 BD 34 C4 DD AB B1 4C FC 08 2A 64 BC 9E 33 95 71 AC 28 A9 84 67 4D 9A C3 42 0E 15 24 8E 53 DB F2 52 5E 46 59 4A E0 D7 4E 87 8A 88 F1 57 E5 B9 81 EC 58 EF A7 62 D5 DF 7C C0 D4 11 80 14 30 54 FD B6 03 92 D8 D2 E9 13 1A A5 C7 22 37 97 50 CE 02 06 E6 21 E2 20 BF 3D B3 F3 96 77 1E 0A A1 0C C6 09 3F 2C A6 7F 85 3E 4B 9B 1C 4F EE 7D EA 6F 69 25 C8 76 F4 94 7E 05 D9 27 5A 60 DC BA 8D 75 19 8F DE F5 CA 16 A0 66 68 FF 04 99 93 D6 F7 35 DA 65 AA 74 86 1D D0 B7 B8 6B E9 57 BA 46 9A E1 0B 71 D0 83 04 F6 F0 75 E2 39 B3 A0 96 D4 A1 1A E0 81 E8 09 6C 59 93 3E 95 19 EB 35 FA 27 28 4F 82 0C 06 9B 60 45 AA 68 49 55 6A 41 10 F7 F9 3F 89 43 FF C5 B8 86 EA 12 25 38 70 C7 73 E3 40 4A FD 6E 17 15 18 1E 26 7A C8 C6 D9 C1 CD D1 48 7F D5 BB 8A 91 DD 6D 44 CC 11 7D BE 79 99 2C A2 20 BF A8 BD 58 3A 9D 51 CF 08 47 0D 9C 29 85 8C 76 4D 1F 8E 4B 5F 62 CB AF 8B 84 CA DC 0F B9 F2 B4 4C 8F DB 03 ED 7B 3C 24 A7 C2 00 94 9F 1C A6 7C 0E 67 52 A5 CE 07 F1 30 31 1B 36 B7 33 5C 05 D2 F8 23 FB B5 97 EE 0A AC 01 42 5B AB 22 63 D3 2E 34 A4 21 53 3D EF 74 65 92 3B DA 66 F5 90 98 32 2A 54 FC AE 02 E4 64 61 B1 B6 77 56 A9 2D E5 AD FE 1D 7E 87 C4 E7 DE C9 A3 72 5D D7 8D 6F 37 13 F4 EC D6 50 4E C0 DF B2 14 88 5A B0 80 BC F3 E6 9E 69 78 D8 16 2F 2B C3 5E D0 C4 84 15 34 10 F9 50 07 B2 DC 96 ED D6 1E 17 C3 A1 33 26 54 93 06 CA E2 02 E6 25 BB 24 B7 39 0A 46 20 11 57 8A F6 DF 5A 56 5D 42 E4 4E 4A D3 8E 83 F5 8C E1 53 85 BD 5C E8 A3 EB D1 66 78 DB 5E 23 D8 64 89 BE 1D 71 DA 8B CE F1 A4 12 6C 62 00 FB 97 9D F3 D2 DE 31 AE 61 82 70 D4 19 BC B3 92 F7 1A 73 A5 0E C2 08 3B 0D A2 28 81 7B 4F 3A 18 9F EA 4B EE 79 6D 6B CC 21 F0 72 7A 90 DD 01 43 8D F2 E3 58 C5 B4 B0 2B 1B 13 C1 7D 05 27 68 CB D5 77 4D 29 8F 5B 44 4C 16 E9 C6 88 6F F4 AC 1C 5F 86 E5 52 38 7C 45 CD 32 2D EC 36 65 B6 7E 35 99 CF 67 FA 2A 7F FF FD 6E A0 41 A9 B1 0B 03 C8 A6 3F BA FE 09 74 EF 30 B9 D9 C0 B5 AF F8 48 2E 0C B8 60 37 9A 75 91 2C A8 80 AD 49 63 C7 9E 3E 55 FC C9 AB AA 9C 6A 0F 04 59 9B E7 95 87 3D 98 76 14 40 BF 3C E0 A7 47 94 1F 51 2F D7 22 69 33 7F 19 28 6E B3 CF E6 63 6F 64 7B DD 77 73 EA B7 BA CC B5 D8 6A BC 84 65 D1 9A D2 E8 5F 41 E2 E9 FD BD 2C 0D 29 C0 69 3E 8B E5 AF D4 EF 27 2E FA 98 0A 1F 6D AA 3F F3 DB 3B DF 1C 82 1D 8E 00 AB CE 23 4A 9C 37 FB 31 02 34 9B 11 B8 42 76 03 21 A6 D3 72 D7 40 54 52 F5 18 C9 4B 43 A9 E4 38 67 1A E1 5D B0 87 24 48 E3 B2 F7 C8 9D 2B 55 5B 39 C2 AE A4 CA EB E7 08 97 58 BB 49 ED 20 85 8A 25 66 BF DC 6B 01 45 7C F4 0B 14 D5 0F 5C 8F 47 0C A0 F6 5E C3 13 46 C6 C4 57 99 78 90 88 32 3A 7A B4 CB DA 61 FC 8D 89 12 22 2A F8 44 3C 1E 51 F2 EC 4E 74 10 B6 62 7D 75 2F D0 FF B1 56 CD 95 07 6C C5 F0 92 93 A5 53 36 3D 60 A2 DE AC BE 04 A1 4F 2D 79 86 05 D9 9E 7E AD 26 68 16 EE 1B 50 F1 9F 06 83 C7 30 4D D6 09 80 E0 F9 8C 96 C1 71 17 35 81 59 0E A3 4C A8 15 91 B9 94 70 5A FE A7 E3 18 74 7E 10 31 3D D2 4D 82 61 93 37 FA 5F 50 BD C0 3B 87 6A 5D FE 92 39 68 2D 12 47 F1 8F 81 FB 7C 09 A8 0D 9A 8E 88 2F C2 13 91 99 73 3E E2 71 14 F9 90 46 ED 21 EB D8 EE 41 CB 62 98 AC D9 20 42 D0 C5 B7 70 E5 29 01 E1 05 C6 58 C7 54 DA 33 27 67 F6 D7 F3 1A B3 E4 51 3F 75 0E 35 FD F4 6D 60 16 6F 02 B0 66 5E BF 0B 40 08 32 85 9B 38 E9 A5 C3 F2 B4 69 15 3C B9 B5 BE A1 07 AD A9 30 CD EF 5B 83 D4 79 96 72 CF 4B 63 4E AA 80 24 7D 2B 45 DC 59 1D EA 97 0C D3 5A 3A 23 56 4C 1B AB 7B 95 F7 A3 5C DF 03 44 A4 77 FC B2 CC 34 C1 8A DD B6 1F 2A 48 49 7F 89 EC E7 BA 78 04 76 64 DE 28 36 94 AE CA 6C B8 A7 AF F5 0A 25 6B 8C 17 4F A0 6E 11 00 BB 26 57 53 C8 F8 F0 22 9E E6 C4 8B D6 7A 2C 84 19 C9 9C 1C 1E 8D 43 A2 4A 52 E8 E0 FF BC 65 06 B1 DB 9F A6 2E D1 CE 0F D5 86 55 9D 38 5A BF AA 0A CD 53 9F 9B 7B BC 7F BD 22 A0 2E 5D 49 8C 1D 89 AD C9 60 2B 9E 0F 45 4F 74 8E 87 1A 17 15 6C CA 78 24 1C 71 C5 72 3A FF 48 42 E1 DF 93 88 B9 13 CE 46 6F CF C3 DB C4 D7 7D 4A D3 62 99 04 0E 4B 6A A8 47 F8 37 E9 1B 80 4D 2A 25 BA C7 FD 41 27 10 E8 84 12 43 68 57 8B 3D FB F5 06 81 D2 73 E0 77 F2 F4 B8 55 EB 69 09 E3 98 44 6E 0B EA 83 97 3C 91 5B 94 A2 B1 3B E2 18 A3 D6 4C 52 D4 EE 16 B0 DD C2 8F D5 5F 70 F6 11 35 6D 14 DA 7A 6B 5C C1 29 2D 82 B2 58 8A 9C E4 F1 BE 00 AC FE 56 B3 63 66 E6 F7 64 D8 39 28 30 9A 92 C6 85 7C 1F A1 CB DC E5 AB 54 75 B4 FC AF E7 2F 95 B7 F9 21 03 AE 08 EC 31 B5 34 19 FA D0 07 5E 3F 51 23 A6 90 67 76 ED 20 A9 59 40 36 2C D1 61 EF 01 D9 8D A5 26 3E 79 0D DE C8 86 4E B6 F0 BB CC A7 50 65 33 32 F3 05 9D 96 02 C0 0C 7E A4 1E D1 6D 96 EB C4 A8 0B 3C 44 7B 3E 6F D7 D9 A7 11 28 22 4E B5 84 6B 67 46 C5 37 D4 1B 06 09 AC 61 C6 AF 42 27 BD 77 BB 10 9D 17 B8 8E 8F FA CE 34 FE 5F 2A AD DE D8 CC 5B C7 45 94 79 B4 68 25 CF A0 31 71 65 E5 4C A5 81 23 69 07 B2 A2 AB 63 58 93 86 14 76 7F B3 26 E1 90 53 B7 57 8C 02 91 0E A4 95 F3 BF 6A 43 3F E2 F7 E8 E3 EF 66 FF FB 51 39 40 36 3B 08 30 E6 54 5E 16 5D E9 6E CD D3 64 0F 8A 13 7D 5A C1 BC 4B 75 6C 0C 85 FD 4D 1A 00 D5 0D B9 9B 24 C0 2F 82 18 35 1D 99 2B 72 D6 FC 7C 49 E0 8B DF 29 1F 1E 2E EC B1 BA 88 32 20 52 F5 A1 C3 2D 12 55 89 0A E4 AA 21 F2 DC 97 62 9A 56 47 38 F6 05 01 70 ED 74 A6 AE 9E DD 92 B0 C8 F8 C2 60 7E F1 EE 3A 9C 73 5C A3 F9 19 41 DA 3D 50 33 EA A9 F0 C9 8D E7 59 98 87 78 CB 03 D0 83 D2 7A 2C 80 4A CA 9F 4F F4 15 DB 48 B6 BE 04 1C 8E 90 16 2C D4 72 1F 00 4D 17 9D B2 34 D3 F7 AF D6 18 B8 A9 9E 03 EB EF 40 70 9A 48 5E 26 33 7C C2 6E 3C 94 71 A1 A4 24 35 A6 1A FB EA F2 58 50 04 47 BE DD 63 09 1E 27 69 96 B7 76 3E 6D 25 ED 57 75 3B E3 C1 6C CA 2E F3 77 F6 DB 38 12 C5 9C FD 93 E1 64 52 A5 B4 2F E2 6B 9B 82 F4 EE 13 A3 2D C3 1B 4F 67 E4 FC BB CF 1C 0A 44 8C 74 32 79 0E 65 92 A7 F1 F0 31 C7 5F 54 C0 02 CE BC 66 DC FA 98 7D 68 C8 0F 91 5D 59 B9 7E BD 7F E0 62 EC 9F 8B 4E DF 4B 6F 0B A2 E9 5C CD 87 8D B6 4C 45 D8 D5 D7 AE 08 BA E6 DE B3 07 B0 F8 3D 8A 80 23 1D 51 4A 7B D1 0C 84 AD 0D 01 19 06 15 BF 88 11 A0 5B C6 CC 89 A8 6A 85 3A F5 2B D9 42 8F E8 E7 78 05 3F 83 E5 D2 2A 46 D0 81 AA 95 49 FF 39 37 C4 43 10 B1 22 B5 30 36 7A 97 29 AB CB 21 5A 86 AC C9 28 41 55 FE 53 99 56 60 73 F9 20 DA 61 14 17 02 90 F2 FB 37 A2 65 14 D7 33 D3 08 86 15 8A 24 B5 F5 E1 61 C8 21 05 A7 ED 83 36 26 2F E7 DC BD C4 B2 BF 8C B4 62 D0 DA 92 D9 6D EA 49 57 E0 20 11 77 3B EE C7 BB 66 73 6C 67 6B E2 7B 7F D5 AC A6 CA 31 00 EF E3 C2 41 B3 50 9F 82 8D 28 E5 55 E9 12 6F 40 2C 8F B8 C0 FF BA EB 53 5D 23 95 7A DB AE 29 5A 5C 48 DF 43 C1 10 FD 30 EC A1 4B 42 2B C6 A3 39 F3 3F 94 19 93 3C 0A 0B 7E 4A B0 7C 46 E4 FA 75 6A BE 18 F7 D8 27 7D 9D C5 5E B9 D2 C3 BC 72 81 85 F4 69 F0 22 2A 1A 59 16 34 4C 56 FE A8 04 CE 4E 1B CB 70 91 5F CC 32 3A 80 98 D4 B7 6E 2D 74 4D 09 63 DD 1C 03 FC 4F 87 54 07 51 89 3D 1F A0 44 AB 06 9C B1 99 1D AF F6 52 78 8B 0E 97 F9 DE 45 38 CF F1 E8 88 01 79 C9 9E 84 71 25 47 A9 96 D1 0D 8E 60 2E A5 76 58 13 E6 1E F8 CD 64 0F 5B AD 9B 9A AA 68 35 3E 0C B6 A4 D6 31 90 E5 62 11 17 03 94 08 8A 5B B6 7B A7 EA 00 09 60 8D E8 72 B8 74 DF 52 D8 77 41 40 35 01 FB E7 ED 81 7A 4B A4 A8 89 0A F8 1B D4 C9 C6 63 AE 1E A2 59 24 0B 67 C4 F3 8B B4 F1 A0 18 16 68 DE F6 8F F9 F4 C7 FF 29 9B 91 D9 92 26 A1 02 1C AB 6B 5A 3C 70 A5 8C F0 2D 38 27 2C 20 A9 30 34 9E 5C 49 DB B9 B0 7C E9 2E 5F 9C 78 98 43 CD 5E C1 6F FE BE AA 2A 83 6A 4E EC A6 C8 7D 6D 64 AC 97 3A 6E 0C E2 DD 9A 46 C5 2B 65 EE 3D 13 58 AD 55 B3 86 2F 44 10 E6 D0 D1 E1 23 7E 75 47 FD EF 9D 1A C2 76 54 EB 0F E0 4D D7 FA D2 56 E4 BD 19 33 C0 45 DC B2 95 0E 73 84 BA A3 C3 4A 32 82 D5 CF 1D B5 E3 4F 85 05 50 80 3B DA 14 87 79 71 CB D3 9F FC 25 66 3F 06 42 28 96 57 48 B7 04 CC 1F 4C 37 0D AF B1 3E 21 F5 53 BC 93 6C 36 D6 8E 15 F2 99 88 F7 39 CA CE BF 22 BB 69 61 51 12 5D 7F 07 1C 23 66 37 8F 81 FF 49 89 35 CE B3 9C F0 53 64 9D 6F 8C 43 5E 51 F4 39 70 7A 16 ED DC 33 3F 1E C5 4F E0 D6 D7 A2 96 6C 9E F7 1A 7F E5 2F E3 48 9F 1D CC 21 EC 30 7D 97 A6 07 72 F5 86 80 94 03 7B 31 5F EA FA F3 3B 00 F8 69 29 3D BD 14 FD D9 C8 0B EF 0F D4 5A C9 56 CB DE 4C 2E 27 EB 7E B9 AF B0 BB B7 3E A7 A3 09 FC CD AB E7 32 1B 67 BA 06 4E 05 B1 36 95 8B 3C 61 18 6E 63 50 68 BE 0C 2D 34 54 DD A5 15 42 58 57 D2 4B 25 02 99 E4 13 40 6D 45 C1 73 2A 8E A4 8D 55 E1 C3 7C 98 77 DA 76 B4 E9 E2 D0 6A 78 0A 24 11 B8 D3 87 71 47 46 BC F2 79 AA 84 CF 3A C2 AD F9 9B 75 4A 0D D1 52 2C FE F6 C6 85 CA E8 90 0E 1F 60 AE 5D 59 28 B5 2B 04 FB A1 41 19 82 65 A0 9A 38 26 A9 B6 62 C4 01 C0 DF 20 93 5B 88 DB 08 6B B2 F1 A8 91 D5 BF AC 4D 83 10 EE E6 5C 44 8A 22 74 D8 12 92 C7 17 65 A2 37 FB F2 90 02 17 8A 15 86 08 D3 33 D7 14 05 21 C8 61 E1 F5 B5 24 DC E7 2F 26 36 83 ED A7 D0 62 B4 8C BF B2 C4 BD E0 57 49 EA 6D D9 92 DA 66 BB C7 EE 3B 77 11 20 D5 7F 7B E2 6B 67 6C 73 C2 E3 EF 00 31 CA A6 AC E5 28 8D 82 9F 50 B3 41 B8 8F 2C 40 6F 12 E9 55 95 23 5D 53 EB BA FF C0 DF 48 5C 5A 29 AE DB 7A 4B A1 EC 30 FD 10 C1 43 94 3F F3 39 A3 C6 2B 42 B0 4A 7E 0B 0A 3C 93 19 18 BE 6A 75 FA E4 46 7C B9 5E C5 9D 7D 27 D8 F7 69 F4 85 81 72 BC C3 D2 4C 34 16 59 1A 2A 22 F0 CB 1B 4E CE 04 A8 FE 56 98 80 3A 32 CC 5F 91 70 63 09 4D 74 2D 6E B7 D4 07 54 87 4F FC 03 1C DD 06 AB 44 A0 1F 3D 89 51 78 52 F6 AF 1D 99 B1 9C CF 38 45 DE F9 97 0E 8B 84 9E C9 79 01 88 E8 F1 8E 0D D1 96 A9 47 25 71 1E E6 13 58 76 A5 2E 60 9A 9B AD 5B 0F 64 CD F8 D6 A4 B6 0C 3E 35 68 AA 52 D1 C9 8E 18 F6 2E 7A B9 41 07 4C FA 29 3F 71 C4 C5 04 F2 3B 50 A7 92 FB 89 53 E9 6A 61 F5 37 F4 59 FF 1B 62 40 0E D6 0D 27 F0 A9 C6 42 C3 EE 67 90 81 1A C8 A6 D4 51 C1 DB 26 96 D7 5E AE B7 44 94 91 11 F7 5B 09 A1 DF C7 6D 65 00 93 2F CE 56 3C 2B 12 31 72 8B E8 0B 58 10 D8 5C A3 82 43 E1 47 2A 35 BB A5 23 19 01 E6 C2 9A 78 22 A8 87 AB 36 DE DA E3 2D 8D 9C 6B 13 06 49 75 45 AF 7D 17 80 05 03 F1 76 25 84 FE 14 6F B3 4F A2 1C 9E 60 CB 66 AC 99 FC 1D 74 15 EF 54 21 63 55 46 CC BC 9D 5F B0 95 6E F3 F9 77 BA DD D2 0F C0 1E EC D0 E7 1F 73 4D 30 0A B6 7C CA 0C 02 E5 B4 9F A0 3D 8F D3 EB ED E0 E2 9B 08 BF B5 16 86 32 85 CD E4 39 B1 98 28 64 7F 4E 20 8A BD 24 38 34 2C 33 FD 3A A4 68 CF AD 48 5D 4A D5 57 D9 6C 8C 4B 88 7E 5A 3E 97 AA BE 7B EA B8 83 79 70 DC 69 F8 B2 0D D5 9B B9 C0 24 82 2F 35 18 99 1D 72 2B FC D6 8A 0F 7D 13 C1 5A 4B BC 6C 75 85 0C 4D FD 00 1A A1 F5 2D C3 55 12 0A 89 AA E4 F2 21 97 DC 9A 62 49 7C 8B E0 29 DF 1E 1F EC 2E BA B1 32 88 52 20 C2 F8 7E 60 EE F1 9C 3A 5C 73 F9 A3 41 19 3D DA 47 56 F6 38 01 05 ED 70 A6 74 9E AE 92 DD C8 B0 7A D2 80 2C CA 4A 4F 9F 15 F4 48 DB BE B6 1C 04 33 50 A9 EA C9 F0 E7 8D 98 59 78 87 03 CB 83 D0 22 28 B5 4E 6B 84 46 67 37 C5 1B D4 09 06 61 AC 6D D1 EB 96 A8 C4 3C 0B 7B 44 6F 3E D9 D7 11 A7 5F FE AD 2A D8 DE 5B CC 45 C7 79 94 68 B4 CF 25 AF C6 27 42 77 BD 10 BB 17 9D 8E B8 FA 8F 34 CE 86 93 76 14 B3 7F E1 26 53 90 57 B7 02 8C 0E 91 31 A0 65 71 4C E5 81 A5 69 23 B2 07 AB A2 58 63 40 39 3B 36 30 08 54 E6 16 5E E9 5D CD 6E 64 D3 95 A4 BF F3 43 6A E2 3F E8 F7 EF E3 FF 66 51 FB 01 EE E2 C3 AD A7 CB 30 83 8C 29 E4 40 B2 51 9E 41 2D 8E B9 54 E8 13 6E 52 5C 22 94 C1 FE BB EA 5B 5D 49 DE 7B DA AF 28 31 ED A0 4A 42 C0 11 FC 38 F2 3E 95 43 2A C7 A2 0A 7F 4B B1 18 92 3D 0B FA 36 A3 64 16 03 91 F3 09 87 14 8B 15 D6 32 D2 60 C9 20 04 25 B4 F4 E0 27 2E E6 DD A6 EC 82 37 8D B5 63 D1 BC C5 B3 BE EB 48 56 E1 DB 93 D8 6C EF C6 BA 67 21 10 76 3A E3 7A 7E D4 72 6D 66 6A A1 45 AA 07 50 88 3C 1E AE F7 53 79 9D B0 98 1C DF 44 39 CE 8A 0F 96 F8 78 C8 9F 85 F0 E9 89 00 97 D0 0C 8F 70 24 46 A8 59 12 E7 1F 61 2F A4 77 5A AC 9A 9B F9 CC 65 0E 0D B7 A5 D7 AB 69 34 3F 74 6B BF 19 7D 47 E5 FB 9C C4 5F B8 F6 D9 26 7C 80 84 F5 68 D3 C2 BD 73 58 17 35 4D F1 23 2B 1B CF 4F 1A CA 57 FF A9 05 33 3B 81 99 71 90 5E CD 75 4C 08 62 D5 B6 6F 2C 4E 86 55 06 DC 1D 02 FD 03 87 AF 82 66 4C E8 B1 01 23 97 4F 18 B5 5A BE 1F 96 F6 EF 9A 80 D7 67 E7 89 10 95 D1 26 5B C0 68 BB 30 7E 00 F8 0D 46 B7 59 3B 6F 90 13 CF 88 20 2B 76 B4 C8 BA A8 12 11 7A D3 E6 84 85 B3 45 63 39 C6 E9 A7 40 DB 83 E4 FA 58 62 06 A0 74 6B 04 34 3C EE 52 2A 08 47 6C A2 DD CC 77 EA 9B 9F D2 41 8F 6E 86 9E 24 2C 1A B6 E0 48 D5 05 50 D0 E2 1D 02 C3 19 4A 99 51 33 70 A9 CA 7D 17 53 6A 81 4E AD 5F FB 36 93 9C 2F D4 B8 B2 DC FD F1 1E F5 A4 E1 DE 8B 3D 43 4D 71 0C F7 4B A6 91 32 5E E3 0E DF 5D 55 BF F2 2E 37 B0 C5 64 C1 56 42 44 14 22 8D 07 AE 54 60 15 BD D8 35 5C 8A 21 ED 27 CD 2D C9 0A 94 0B 98 16 EC 8E 1C 09 7B BC 29 E5 28 9D F3 B9 C2 F9 31 38 FF EB AB 3A 1B 3F D6 7F 73 C7 8C C4 FE 49 57 F4 A1 AC DA A3 CE 7C AA 92 75 79 72 6D CB 61 65 FC 25 69 0F 3E 78 A5 D9 F0 48 42 DF 24 01 EE 2C 0D 5D AF 71 BE 63 6C 0B C6 07 BB 81 FC C2 AE 56 61 11 2E 05 54 B3 BD 7B CD 35 94 C7 40 B2 B4 31 A6 2F AD 13 FE 02 DE A5 4F C5 AC 4D 28 1D D7 7A D1 7D F7 E4 D2 90 E5 5E A4 EC F9 1C 7E D9 15 8B 4C 39 FA 3D DD 68 E6 64 FB 5B CA 0F 1B 26 8F EB CF 03 49 D8 6D C1 C8 32 09 2A 53 51 5C 5A 62 3E 8C 7C 34 83 37 A7 04 0E B9 FF CE D5 99 29 00 88 55 82 9D 85 89 95 0C 3B 91 67 BF F1 D3 AA 4E E8 45 5F 72 F3 77 18 41 96 BC E0 65 17 79 AB 30 21 D6 06 1F EF 66 27 97 6A 70 CB 9F 47 A9 3F 78 60 E3 C0 8E 98 4B FD B6 F0 08 23 16 E1 8A 43 B5 74 75 86 44 D0 DB 58 E2 38 4A A8 92 14 0A 84 9B F6 50 36 19 93 C9 2B 73 57 B0 2D 3C 9C 52 6B 6F 87 1A CC 1E F4 C4 F8 B7 A2 DA 10 B8 EA 46 A0 20 25 F5 7F 9E 22 B1 D4 DC 76 6E 59 3A C3 80 A3 9A 8D E7 F2 33 12 ED 69 A1 E9 BA 75 7A DF 12 B6 44 A7 68 F7 18 14 35 5B 51 3D C6 A4 AA D4 62 37 08 4D 1C B7 DB 78 4F A2 1E E5 98 C7 1B 56 BC B4 36 E7 0A AD AB BF 28 8D 2C 59 DE FC 89 BD 47 EE 64 CB FD CE 04 C8 63 B5 DC 31 54 FF 71 E2 7D E3 20 C4 24 0C C0 55 92 E0 F5 67 05 D1 D8 10 2B 50 1A 74 C1 96 3F D6 F2 D3 42 02 16 1D BE A0 17 2D 65 2E 9A 7B 43 95 27 4A 33 45 48 15 8C 88 22 84 9B 90 9C 19 30 4C 91 D7 E6 80 CC 58 01 A5 8F 6B 46 6E EA 57 B3 5C F1 A6 7E CA E8 8E 3E 69 73 06 1F 7F F6 29 B2 CF 38 7C F9 60 0E AF E4 11 E9 97 D9 52 81 61 26 FA 79 86 D2 B0 5E FB 41 53 21 5D 9F C2 C9 AC 5A 6C 6D 0F 3A 93 F8 6A 32 A9 4E 00 2F D0 8A 82 9D 49 EF 8B B1 13 0D AE E1 C3 BB 07 D5 DD ED 76 72 03 9E 25 34 4B 85 C5 CD 77 6F 87 66 A8 3B 39 B9 EC 3C A1 09 5F F3 B8 70 A3 F0 2A EB F4 0B 83 BA FE 94 23 40 99 DA C9 B1 A4 EB D7 E7 0D DF 09 94 7C 78 41 8F 2F 3E A3 44 60 38 DA 80 0A 25 43 E5 88 97 19 07 81 BB A9 FA B2 7A FE 01 20 E1 F4 9E 89 B0 93 D0 29 4A 7D 65 CF C7 A2 31 8D 6C E6 36 33 B3 55 F9 AB 03 63 79 84 34 75 FC 0C 15 C5 32 23 B8 6A 04 76 F3 AF 85 52 0B 64 E0 61 4C 56 FB 5D B9 C0 E2 AC 74 59 2B F1 4B C8 C3 57 95 66 67 A6 50 99 F2 05 30 1B E3 A5 EE 58 8B 9D D3 F0 73 6B 2C BA 54 8C D8 1A 21 DB D2 7E CB 5A 10 DC F8 9C 35 08 1C D9 48 E8 77 F5 7B CE 2E E9 2A 5F 98 06 CA 6D 0F EA FF 82 28 1F 86 9A 96 8E 91 46 9B 13 3A 8A C6 DD EC AA 1D 17 B4 24 90 27 6F 9F 2D 71 49 4F 42 40 39 DE 68 AE A0 47 16 3D 02 72 45 BD D1 EF 92 A8 14 D5 18 7F 70 AD 62 BC 4E 1E 3F FD 12 37 CC 51 5B B7 4D F6 83 C1 F7 E4 6E C2 69 C4 0E 3B 5E BF D6 5C B6 CD 11 ED 00 BE 3C B5 22 A7 A1 53 D4 87 26 E8 3A 32 02 41 0E 2C 54 CA DB A4 6A 99 9D EC 71 EF C0 3F 65 85 DD 46 A1 64 5E FC E2 6D 72 A6 00 C5 04 1B E4 57 9F 4C 1F CC AF 76 35 6C 55 11 7B 68 89 47 D4 2A 22 98 80 4E E6 B0 1C D6 56 03 D3 E9 F0 90 19 61 D1 86 9C 93 16 8F E1 C6 5D 20 D7 84 A9 81 05 B7 EE 4A 60 49 91 25 07 B8 5C B3 1E B2 70 2D 26 14 AE BC CE E0 D5 7C 17 43 B5 83 82 78 36 BD 6E 40 0B FE 06 69 3D 5F B1 8E C9 15 96 BF F5 9B 2E 3E 37 FF C4 3C AD ED F9 79 D0 39 1D 0C CF 2B CB 10 9E 0D 92 0F 1A 88 EA E3 2F BA 7D 6B 74 7F 73 FA 63 67 CD 38 09 6F 23 F6 DF A3 7E C2 8A C1 75 F2 51 4F F8 A5 DC AA A7 94 AC 7A C8 D8 E7 A2 F3 4B 45 3B 8D 4D F1 0A 77 58 34 97 A0 59 AB 48 87 9A 95 30 FD B4 BE D2 29 18 F7 FB DA 01 8B 24 12 13 66 52 A8 5A 33 DE BB 21 EB 27 8C 5B D9 08 E5 28 F4 B9 53 62 C3 B6 31 42 44 50 C7 BD D7 93 AA F3 B0 69 0A D9 8A 59 91 22 DD C2 03 15 C5 90 10 DA 76 20 88 46 5E E4 EC 12 81 4F AE B7 2A 5B 5F AC 62 1D 0C 92 EA C8 87 C4 F4 FC 2E C6 60 B4 AB 24 3A 98 A2 67 80 1B 43 A3 F9 06 29 44 45 73 85 D1 BA 13 26 08 7A 68 D2 E0 EB B6 74 50 D3 0F 48 77 99 FB AF C0 38 CD 86 A8 7B F0 BE 11 E6 9B 00 27 49 D0 55 5A 40 17 A7 DF 56 36 2F D8 75 9A 7E C1 E3 57 8F A6 8C 28 71 C3 47 6F 42 B8 65 19 30 E5 A9 CF FE 0B A1 A5 3C B5 B9 B2 AD 0E BC 6A 52 61 6C 1A 63 3E 89 97 34 B3 07 4C 04 DB FF 16 BF 3F 2B 6B FA 02 39 F1 F8 E8 5D 33 79 BB 7C E9 25 2C 4E DC C9 54 CB 58 D6 0D ED 09 CA 4A E1 2D E7 7D 18 F5 9C 6E 94 A0 D5 D4 E2 4D C7 01 96 82 84 F7 70 05 A4 95 7F 32 EE 23 CE 1F 9D 66 51 F2 9E B1 CC 37 8B 4B FD 83 8D 35 64 21 1E 1C 3D 31 DE EF 14 78 72 3B F6 53 5C 41 8E 6D 9F A0 72 7A 4A 09 46 64 1C 82 93 EC 22 D1 D5 A4 39 A7 88 77 2D CD 95 0E E9 2C 16 B4 AA 25 3A EE 48 8D 4C 53 AC 1F D7 04 57 84 E7 3E 7D 24 1D 59 33 20 C1 0F 9C 62 6A D0 C8 06 AE F8 54 9E 1E 4B 9B A1 B8 D8 51 29 99 CE D4 DB 5E C7 A9 8E 15 68 9F CC E1 C9 4D FF A6 02 28 01 D9 6D 4F F0 14 FB 56 FA 38 65 6E 5C E6 F4 86 A8 9D 34 5F 0B FD CB CA 30 7E F5 26 08 43 B6 4E 21 75 17 F9 C6 81 5D DE F7 BD D3 66 76 7F B7 8C 74 E5 A5 B1 31 98 71 55 44 87 63 83 58 D6 45 DA 47 52 C0 A2 AB 67 F2 35 23 3C 37 3B B2 2B 2F 85 70 41 27 6B BE 97 EB 36 8A C2 89 3D BA 19 07 B0 ED 94 E2 EF DC E4 32 80 90 AF EA BB 03 0D 73 C5 05 B9 42 3F 10 7C DF E8 11 E3 00 CF D2 DD 78 B5 FC F6 9A 61 50 BF B3 92 49 C3 6C 5A 5B 2E 1A E0 12 7B 96 F3 69 A3 6F C4 13 91 40 AD 60 BC F1 1B 2A 8B FE 79 0A 0C 18 8F 41 B3 6D A2 7F 70 17 DA 54 5E C3 38 1D F2 30 11 0D 32 19 48 AF A1 67 D1 1B A7 9D E0 DE B2 4A 7D 33 B1 0F E2 1E C2 B9 53 29 88 DB 5C AE A8 2D BA 61 EB F8 CE 8C F9 42 B8 D9 B0 51 34 01 CB 66 CD 25 E6 21 C1 74 FA 78 E7 F0 E5 00 62 C5 09 97 50 1F 55 C4 71 DD D4 2E 15 47 D6 13 07 3A 93 F7 D3 60 28 9F 2B BB 18 12 A5 36 4F 4D 40 46 7E 22 90 9E 81 99 95 89 10 27 8D E3 D2 C9 85 35 1C 94 49 43 6E EF 6B 04 5D 8A A0 7B A3 ED CF B6 52 F4 59 1A 03 F3 7A 3B 8B 76 6C FC 79 0B 65 B7 2C 3D CA DC 92 84 57 E1 AA EC 14 D7 83 5B B5 23 64 7C FF 9A 58 CC C7 44 FE 24 56 3F 0A FD 96 5F A9 68 69 2A 05 8F D5 37 6F 4B AC B4 8E 08 16 98 87 EA 4C D0 02 E8 D8 E4 AB BE C6 31 20 80 4E 77 73 9B 06 63 82 3E AD C8 C0 6A 72 0C A4 F6 5A BC 3C 39 E9 EE 2F 0E F1 75 BD F5 A6 45 26 DF 9C BF 86 91 FB 96 D8 CE 1D AB E0 A6 5E 9D C9 11 FF 69 2E 36 B5 D0 12 86 8D 0E B4 6E 1C 75 40 B7 DC 15 E3 22 23 09 24 A5 21 4E 17 C0 EA 31 E9 A7 85 FC 18 BE 13 50 49 B9 30 71 C1 3C 26 B6 33 41 2F FD 66 77 80 29 C8 74 E7 82 8A 20 38 46 EE BC 10 F6 76 73 A3 A4 65 44 BB 3F F7 BF EC 0F 6C 95 D6 F5 CC DB B1 60 4F C5 9F 7D 25 01 E6 FE C4 42 5C D2 CD A0 06 9A 48 A2 92 AE E1 F4 8C 7B 6A CA 04 3D 39 D1 4C 79 FB 45 A8 54 88 F3 19 63 C2 91 16 E4 E2 67 F0 2B A1 B2 84 C6 B3 08 F2 93 FA 1B 7E 4B 81 2C 87 0B F9 27 E8 35 3A 5D 90 1E 14 89 72 57 B8 7A 5B 47 78 53 02 E5 EB 2D 9B 51 ED D7 AA 94 F8 00 37 2A 62 D5 61 F1 52 58 EF 7C 05 07 0A 0C 34 68 DA D4 CB D3 DF C3 5A 6D C7 A9 98 83 CF 7F 56 DE 03 6F AC 6B 8B 3E B0 32 AD BA AF 4A 28 8F 43 DD 1A 55 1F 8E 3B 97 9E 64 5F 0D 9C 59 4D 70 D9 BD 99 45 E9 BF 17 8A 5A 0F 8F 8D 1E D0 31 D9 C1 7B 73 6C 2F F6 95 22 48 0C 35 BD 42 5D 9C 46 15 C6 0E BB A5 07 3D 59 FF 2B 34 3C 66 99 B6 F8 1F 84 DC 33 FD 82 93 28 B5 C4 C0 5B 6B 63 B1 0D 75 57 18 E8 06 64 30 CF 4C 90 D7 37 E4 6F 21 5F A7 52 19 4E 25 8C B9 DB DA EC 1A 7F 74 29 EB 97 E5 F7 4D 5E 7C C8 10 47 EA 05 E1 5C D8 F0 DD 39 13 B7 EE B8 D6 4F CA 8E 79 04 9F 40 C9 A9 B0 C5 DF 88 38 FE F3 85 FC 91 23 F5 CD 2C 98 D3 9B A1 16 08 AB 7A 36 50 61 27 FA 86 AF 2A 26 2D 32 94 3E 3A A3 B3 D1 43 56 24 E3 76 BA 92 72 96 55 CB 54 C7 49 A0 B4 F4 65 44 60 89 20 77 C2 AC E6 9D A6 6E 67 68 EF 9A 3B 9E 09 1D 1B BC 51 80 02 0A E0 AD 71 E2 87 6A 03 D5 7E B2 78 4B 7D D2 58 F1 0B 3F 4A 70 8B E7 ED 83 A2 AE 41 DE 11 F2 00 A4 69 CC C3 2E 53 A8 14 F9 CE 6D 01 AA FB BE 81 D4 62 1C 12 5F C4 B9 4E 0A 8F 16 78 F8 48 1F 05 70 69 09 80 21 C5 2A 87 D0 08 BC 9E 2E 77 D3 F9 1D 30 18 9C DA 2C 1A 1B 79 4C E5 8E 8D 37 25 57 2B E9 B4 BF 17 50 8C 0F F0 A4 C6 28 D9 92 67 9F E1 AF 24 F7 00 04 75 E8 53 42 3D F3 D8 97 B5 CD 71 A3 AB 9B F4 EB 3F 99 FD C7 65 7B 1C 44 DF 38 76 59 A6 FC F5 CC 88 E2 55 36 EF AC CE 06 D5 86 5C 9D 82 7D 4F CF 9A 4A D7 7F 29 85 B3 BB 01 19 F1 10 DE 4D C1 AD 0E 39 D4 68 93 EE D2 DC A2 14 41 7E 3B 6A 81 6E 62 43 2D 27 4B B0 03 0C A9 64 C0 32 D1 1E B8 72 BE 15 C3 AA 47 22 8A FF CB 31 98 12 BD 8B DB DD C9 5E FB 5A 2F A8 B1 6D 20 CA C2 40 91 7C E0 49 A0 84 A5 34 74 60 A7 AE 66 5D 26 6C 02 B7 7A B6 23 E4 96 83 11 73 89 07 94 0B 95 56 B2 52 6F 46 3A E7 A1 90 F6 BA 63 FA FE 54 F2 ED E6 EA 0D 35 E3 51 3C 45 33 3E 6B C8 D6 61 5B 13 58 EC 1F 9F 9A 4A AF 07 55 F9 6B 63 C9 D1 C0 21 9D 0E 1C 25 32 58 E6 85 7C 3F D6 1E 56 05 4D 8C AD 52 3B 24 49 EF 17 2D AB B5 94 CC E8 0F 89 A6 2C 76 D4 D0 38 A5 92 83 23 ED 47 08 1D 65 73 A1 4B 7B 80 C7 DF 5C 74 20 F8 16 42 09 4F B7 7F 31 27 F4 FC 0A CB CA 9C A9 5E 35 E7 5D 87 F5 39 FB 6F 64 15 F1 57 FA D8 00 4E 6C A7 FE 29 03 E0 CD 4C C8 14 8F 9E 69 5F DA A8 C6 98 28 D5 CF B9 A0 50 D9 E5 DD 81 33 95 EC EE E3 18 BB B1 06 C3 8B 3C 88 96 BF 37 EA 40 71 6A 26 2A B3 84 2E 3D 22 3A 36 66 AA 34 F3 53 46 A3 C1 D7 59 DB 44 86 45 82 62 99 30 54 70 E4 75 B0 A4 7E 77 8D B6 BC F6 67 D2 0D 0B 8E 19 8A 2B 78 FF BD 61 1A F0 90 12 AC 41 A2 68 C5 6E 7A 13 F2 97 2F 5A E1 1B C2 48 5B 6D BE 51 93 B2 F7 FD 60 9B DC D3 B4 79 E2 10 CE 01 7D 11 E9 DE B8 04 3E 43 0C 02 C4 72 AE 91 BA EB F7 F8 5D 90 34 C6 25 EA 75 9A 96 B7 D9 D3 BF 44 26 28 56 E0 B5 8A CF 9E 35 59 FA CD 20 9C 67 1A 45 99 D4 3E 36 B4 65 88 2F 29 3D AA 0F AE DB 5C 7E 0B 3F C5 6C E6 49 7F 4C 86 4A E1 37 5E B3 D6 7D F3 60 FF 61 A2 46 A6 8E 42 D7 10 62 77 E5 87 53 5A 92 A9 D2 98 F6 43 14 BD 54 70 51 C0 80 94 9F 3C 22 95 AF E7 AC 18 F9 C1 17 A5 C8 B1 C7 CA 97 0E 0A A0 06 19 12 1E 9B B2 CE 13 55 64 02 4E DA 83 27 0D E9 C4 EC 68 D5 31 DE 73 24 FC 48 6A 0C BC EB F1 84 9D FD 74 AB 30 4D BA FE 7B E2 8C 2D 66 93 6B 15 5B D0 03 E3 A4 78 FB 04 50 32 DC 79 C3 D1 A3 DF 1D 40 4B 2E D8 EE EF 8D B8 11 7A E8 B0 2B CC 82 AD 52 08 00 1F CB 6D 09 33 91 8F 2C 63 41 39 85 57 5F 6F F4 F0 81 1C A7 B6 C9 07 47 4F F5 ED 05 E4 2A B9 BB 3B 6E BE 23 8B DD 71 3A F2 21 72 A8 69 76 89 01 38 7C 16 A1 C2 1B 58 B7 F4 2D 4E F9 93 D7 EE 66 99 86 47 9D CE 1D D5 9E 32 64 CC 51 81 D4 54 56 C5 0B EA 02 1A A0 A8 E8 26 59 48 F3 6E 1F 1B 80 B0 B8 6A D6 AE 8C C3 60 7E DC E6 82 24 F0 EF E7 BD 42 6D 23 C4 5F 07 95 FE 57 62 00 01 37 C1 A4 AF F2 30 4C 3E 2C 96 33 DD BF EB 14 97 4B 0C EC 3F B4 FA 84 7C 89 C2 63 0D 94 11 55 A2 DF 44 9B 12 72 6B 1E 04 53 E3 85 A7 13 CB 9C 31 DE 3A 87 03 2B 06 E2 C8 6C 35 A1 ED 8B BA FC 21 5D 74 F1 FD F6 E9 4F E5 E1 78 25 28 5E 27 4A F8 2E 16 F7 43 08 40 7A CD D3 70 7B 6F 2F BE 9F BB 52 FB AC 19 77 3D 46 7D B5 BC 68 0A 98 8D FF 38 AD 61 49 A9 4D 8E 10 8F 1C 92 39 5C B1 D8 0E A5 69 A3 90 A6 09 83 2A D0 E4 91 B3 34 41 E0 45 D2 C6 C0 67 8A 5B D9 D1 3B 76 AA F5 88 73 CF 22 15 B6 DA 71 20 65 5A 0F B9 C7 C9 AB 50 3C 36 58 79 75 9A 05 CA 29 DB 7F B2 17 18 22 8A D8 74 92 12 17 C7 4D AC 10 83 E6 EE 44 5C 6B 08 F1 B2 91 A8 BF D5 C0 01 20 DF 5B 93 DB 88 9A A0 26 38 B6 A9 C4 62 04 2B A1 FB 19 41 65 82 1F 0E AE 60 59 5D B5 28 FE 2C C6 F6 CA 85 90 E8 F9 AD 75 9B 0D 4A 52 D1 F2 BC AA 79 CF 84 C2 3A 11 24 D3 B8 71 87 46 47 B4 76 E2 E9 6A D0 0A 78 55 8D C3 E1 98 7C DA 77 6D 40 C1 45 2A 73 A4 8E D2 57 25 4B 99 02 13 E4 34 2D DD 54 15 A5 58 42 18 61 63 6E 68 50 0C BE 4E 06 B1 05 95 36 3C 8B CD FC E7 AB 1B 32 BA 67 B0 AF B7 BB A7 3E 09 A3 DE CB 2E 4C EB 27 B9 7E 0B C8 0F EF 5A D4 56 C9 69 F8 3D 29 14 BD D9 FD 31 7B EA 5F F3 FA 00 3B 07 A6 F5 72 80 86 03 94 1D 9F 21 CC 30 EC 97 7D F7 9E 7F 1A 2F E5 48 E3 4F C5 D6 E0 A2 D7 6C 96 7A 70 ED 16 33 DC 1E 3F 6F 9D 43 8C 51 5E 39 F4 35 89 B3 CE F0 9C 64 53 23 1C 37 66 81 8F 49 FF 4A A0 DB 07 FB 16 A8 2A A3 34 B1 B7 45 C2 91 30 A1 5B E0 95 D7 E1 F2 78 D4 7F D2 18 2D 48 A9 C0 C3 0E 69 66 BB 74 AA 58 08 29 EB 04 21 DA 47 4D C8 7E B8 B6 51 00 2B 14 64 53 AB C7 F9 84 BE 02 BC 0B 01 A2 32 86 31 79 89 3B 67 5F 59 54 56 2F 94 3E 09 90 8C 80 98 87 50 8D 05 2C 9C D0 CB FA FE 61 E3 6D D8 38 FF 3C 49 8E 10 DC 7B 19 FC E9 0C 37 CD C4 68 DD 4C 06 CA EE 8A 23 1E 0A CF 5E 0D F5 B3 F8 4E 9D 8B C5 E6 65 7D 3A AC 42 9A CE 4F 3D E7 5D DE D5 41 83 70 71 B0 46 8F E4 13 26 B9 93 44 1D 72 F6 77 5A 40 ED 4B AF D6 F4 BA 62 75 6F 92 22 63 EA 1A 03 D3 24 35 AE 7C 12 60 E5 6B 73 D9 D1 B4 27 9B 7A F0 20 25 A5 43 EF BD 15 BF EC A4 6C E8 17 36 F7 E2 88 9F A6 85 C6 3F 5C B5 52 76 2E CC 96 1C 33 55 F3 9E 81 0F 11 97 AD DF A7 B2 FD C1 F1 1B C9 1F 82 6A 6E 57 99 39 28 27 12 E5 8E 47 B1 70 71 82 40 D4 DF 5C E6 3C 4E CF 9B 43 AD 3B 7C 64 E7 C4 8A 9C 4F F9 B2 F4 0C E4 61 13 7D AF 34 25 D2 02 1B EB 62 23 93 6E 74 63 BB F5 D7 AE 4A EC 41 5B 76 F7 73 1C 45 92 B8 5D 3E C7 84 A7 9E 89 E3 F6 37 16 E9 6D A5 ED BE 14 BC EE 42 A4 24 21 F1 7B 9A 26 B5 D0 D8 72 6A 29 38 98 56 6F 6B 83 1E C8 1A F0 C0 FC B3 A6 DE AC 96 10 0E 80 9F F2 54 32 1D 97 CD 2F 77 53 B4 C1 A8 49 2C 19 D3 7E D5 79 F3 E0 D6 94 E1 5A A0 31 90 C3 44 B6 B0 35 A2 2B A9 17 FA 06 DA A1 4B 03 BF 85 F8 C6 AA 52 65 15 2A 01 50 B7 B9 7F C9 4C 46 DB 20 05 EA 28 09 59 AB 75 BA 67 68 0F C2 FB CA D1 9D 2D 04 8C 51 86 99 81 8D 91 08 3F 95 2E 57 55 58 5E 66 3A 88 78 30 87 33 A3 00 0A BD 5F CE 0B 1F 22 8B EF CB 07 4D DC 69 C5 CC 36 0D E8 FD 18 7A DD 11 8F 48 3D FE 39 D9 6C E2 60 FF FF CF C7 15 A9 D1 F3 BC 97 59 26 37 8C 11 60 64 98 C2 3D 12 5C BB 20 78 1F 01 A3 99 FD 5B 8F 90 19 E6 F9 38 E2 B1 62 AA C8 8B 52 31 86 EC A8 91 29 BA 74 95 7D 65 DF D7 E1 4D 1B B3 2E FE AB 2B E4 6D 0D 14 61 7B 2C 9C 1C 72 EB 6E 2A DD A0 3B F8 7C 54 79 9D B7 13 4A FA D8 6C B4 E3 4E A1 45 DB D0 8D 4F 33 41 53 E9 EA 81 28 1D 7F 7E 48 BE 93 40 CB 85 FB 03 F6 BD 4C A2 C0 94 6B E8 34 73 D3 66 08 42 39 02 CA C3 04 10 50 C1 E0 C4 2D 84 36 D6 32 F1 6F F0 63 ED 17 75 E7 F2 80 47 D2 1E 8E 82 89 96 30 9A 9E 07 DE 92 F4 C5 83 5E 22 0B 88 3C 77 3F 05 B2 AC 0F 5A 57 21 58 35 87 51 69 0E 5F 1A 25 70 C6 B8 B6 8A F7 0C B0 5D 6A C9 A5 7A B5 56 A4 00 CD 68 67 D4 2F 43 49 27 06 0A E5 EF D9 76 FC 55 AF 9B EE 46 23 CE A7 71 DA 16 DC 18 F5 24 A6 AE 44 09 D5 CC 4B 3E 9F 3A AD B9 BF 03 5B C0 27 69 46 B9 E3 EB F4 20 86 E2 D8 7A 64 C7 88 AA D2 6E BC B4 84 1F 1B 6A F7 4C 5D 22 EC AC A4 1E 06 EE 0F C1 52 50 D0 85 55 C8 60 36 9A D1 19 CA 99 43 82 9D 62 EA D3 97 FD 4A 29 F0 B3 31 68 CC E6 02 2F 07 83 3E DA 35 98 CF 17 A3 81 E7 57 00 1A 6F 76 16 9F 40 DB A6 51 15 90 09 67 C6 8D 78 80 FE B0 3B E8 08 4F 93 10 EF BB D9 37 92 28 3A 48 34 F6 AB A0 C5 33 05 04 66 53 FA 91 96 18 8B 14 8A 49 AD 4D 65 A9 3C FB 89 9C 0E 6C B8 B1 79 42 39 73 1D A8 FF 56 BF 9B BA 2B 6B 7F 74 D7 C9 7E 44 0C 47 F3 12 2A FC 4E 23 5A 2C 21 7C E5 E1 4B ED F2 F9 F5 70 59 25 F8 BE 8F E9 A5 1C 13 B6 7B DF 2D CE 01 9E 71 7D 5C 32 38 54 AF CD C3 BD 0B 5E 61 24 75 DE B2 11 26 CB 77 8C F1 AE 72 3F D5 DD 5F 8E 63 C4 C2 D6 41 E4 45 30 B7 95 E0 D4 2E 87 0D A2 94 A7 6D A1 0A DC B5 58 3D CB 2F 89 24 06 DE 90 B2 79 20 F7 DD 3E 13 92 16 CA 51 40 B7 81 04 76 18 46 F6 0B 11 67 7E 8E 07 5E 19 01 82 AA FE 26 C8 9C D7 91 69 A1 EF F9 2A 22 D4 15 14 42 77 80 EB 39 83 59 2B E7 25 B1 BA E5 FA 97 31 C9 F3 75 6B 4A 12 36 D1 57 78 F2 A8 0A 0E E6 7B 4C 5D FD 33 99 D6 C3 BB AD 7F 95 A5 C1 41 44 94 71 D9 8B 27 B5 BD 17 0F 1E FF 43 D0 C2 FB EC 86 38 5B A2 E1 08 C0 88 DB 93 52 73 8C 60 8F 4D 6C 29 23 BE 45 02 0D 6A A7 3C CE 10 DF A3 CF 37 00 66 DA E0 9D D2 DC 1A AC 70 4F 64 35 D3 D5 50 C7 54 F5 A6 21 63 BF C4 2E 4E CC 72 9F 7C B6 1B B0 A4 CD 2C 49 F1 84 3F C5 1C 96 85 B3 B8 74 EA 2D 8D 98 7D 1F 09 87 05 9A 58 9B 5C BC 47 EE 8A AE 3A AB 6E 7A A0 A9 53 68 62 28 B9 0C 3B 03 5F ED 4B 32 30 3D C6 65 6F D8 1D 55 E2 56 48 61 E9 34 9E AF B4 F8 F4 6D 5A F0 E3 FC E4 E8 32 57 BA D3 05 AE 62 A8 9B AD 02 88 21 DB EF 9A B8 3F 4A EB 4E D9 CD CB 6C 81 50 D2 DA 30 7D A1 FE 83 78 C4 29 1E BD D1 7A 2B 6E 51 04 B2 CC C2 A0 5B 37 3D 53 72 7E 91 0E C1 22 D0 74 B9 1C 13 AA E6 80 B1 F7 2A 56 7F FA F6 FD E2 44 EE EA 73 2E 23 55 2C 41 F3 25 1D FC 48 03 4B 71 C6 D8 7B 70 64 24 B5 94 B0 59 F0 A7 12 7C 36 4D 76 BE B7 63 01 93 86 F4 33 A6 6A 42 A2 46 85 1B 84 17 99 9E F5 5C 69 0B 0A 3C CA AF A4 F9 3B 47 35 27 9D 38 D6 B4 E0 1F 9C 40 07 E7 34 BF F1 8F 77 82 C9 68 06 9F 1A 5E A9 D4 4F 90 19 79 60 15 0F 58 E8 8E AC 18 C0 97 3A D5 31 8C 08 20 0D E9 C3 67 3E BC FF 26 45 F2 98 DC E5 6D 92 8D 4C 96 C5 16 DE 95 39 6F C7 5A 8A DF 5F 5D CE 00 E1 09 11 AB A3 E3 2D 52 43 F8 65 14 10 8B BB B3 61 DD A5 87 C8 6B 75 D7 ED 89 2F FB E4 EC B6 49 66 28 CF 54 0C 94 05 C0 D4 E9 40 24 00 CC 86 17 A2 0E 07 FD C6 23 36 D3 B1 16 DA 44 83 F6 35 F2 12 A7 29 AB 34 30 01 1A 56 E6 CF 47 9A 4D 52 4A 46 5A C3 F4 5E E5 9C 9E 93 95 AD F1 43 B3 FB 4C F8 68 CB C1 76 C8 74 4E 33 0D 61 99 AE DE E1 CA 9B 7C 72 B4 02 87 8D 10 EB CE 21 E3 C2 92 60 BE 71 AC A3 C4 09 0A 63 82 E7 D2 18 B5 1E B2 38 2B 1D 5F 2A 91 6B FA 5B 08 8F 7D 7B FE 69 E0 62 DC 31 CD 11 6A 80 E2 F3 53 9D A4 A0 48 D5 03 D1 3B 0B 37 78 6D 15 67 5D DB C5 4B 54 39 9F F9 D6 5C 06 E4 BC 98 7F 96 F5 0C 4F 6C 55 42 28 3D FC DD 22 A6 6E 26 75 DF 77 25 89 6F EF EA 3A B0 51 ED 7E 1B 13 B9 A1 2F AA D8 B6 64 FF EE 19 C9 D0 20 A9 E8 58 A5 BF A8 70 3E 1C 65 81 27 8A 90 BD 3C B8 D7 8E 59 73 EC D9 2E 45 8C 7A BB BA 49 8B 1F 14 97 2D F7 85 04 50 88 66 F0 B7 AF 2C 0F 41 57 84 32 79 3F C7 86 5E EA C8 77 93 7C D1 4B 66 4E CA 78 21 85 AF 5C D9 40 2E 09 92 EF 18 26 3F 5F D6 AE 1E 49 53 A6 F2 90 7E 41 06 DA 59 B7 F9 72 A1 8F C4 31 C9 2F 1A B3 D8 8C 7A 4C 4D 7D BF E2 E9 DB 61 73 01 AB 91 33 2D A2 BD 69 CF 20 0F F0 AA 4A 12 89 6E 05 14 6B A5 56 52 23 BE 27 F5 FD CD 8E C1 E3 9B 81 29 7F D3 19 99 CC 1C A7 46 88 1B E5 ED 57 4F 03 60 B9 FA A3 9A DE B4 0A CB D4 2B 98 50 83 D0 7B 71 1D E6 D7 38 34 15 96 64 87 48 55 5A FF 32 82 3E C5 B8 97 FB 58 6F 17 28 6D 3C 84 8A F4 42 AD 0C 79 FE 8D 8B 9F 08 94 16 C7 2A E7 3B 76 9C 95 FC 11 74 EE 24 E8 43 CE 44 EB DD DC A9 9D 67 C0 D5 47 25 2C E0 75 B2 C3 00 E4 04 DF 51 C2 5D F3 62 22 36 B6 1F F6 D2 70 3A 54 E1 F1 F8 30 0B 6A 13 65 68 5B 63 B5 07 0D 45 0E BA 3D 9E 80 37 F7 C6 A0 EC 39 10 6C B1 A4 BB B0 BC 35 AC A8 02 9E 1D C1 86 B9 57 35 61 0E F6 03 48 66 B5 3E 70 8A 8B BD 4B 1F 74 DD E8 C6 B4 A6 1C 2E 25 78 BA 16 BB 54 B0 0F 2D 99 41 68 42 E6 BF 0D 89 A1 8C DF 28 55 CE E9 87 1E 9B 94 8E D9 69 11 98 F8 E1 DB 0B 5E DE 14 B8 EE 46 88 90 2A 22 DC 4F 81 60 73 19 5D 64 3D 7E A7 C4 17 44 97 5F EC 13 0C CD 08 AE 7A 65 EA F4 56 6C A9 4E D5 8D 6D 37 C8 E7 79 E4 95 91 62 AC D3 C2 5C 24 06 49 0A 3A 32 E0 CF 58 4C 4A 39 BE CB 6A 5B B1 FC 20 ED 00 D1 53 84 2F E3 29 B3 D6 3B 52 A0 5A 6E 1B 1A 2C 83 09 D2 F3 FF 10 21 DA B6 BC F5 38 9D 92 8F 40 A3 51 A8 9F 3C 50 7F 02 F9 45 85 33 4D 43 FB AA EF D0 C0 72 A4 9C AF A2 D4 AD F0 47 59 FA 7D C9 82 CA 76 AB D7 FE 2B 67 01 30 C5 6F 6B F2 7B 77 7C 63 75 B2 27 EB E2 80 12 07 9A 05 96 18 C3 23 C7 04 15 31 D8 71 F1 E5 A5 34 CC F7 3F 36 26 93 FD B7 D9 0B E1 D1 ED A2 B7 CF 38 29 89 47 7E 7A 92 0F 23 0C 86 DC 3E 66 42 A5 BD 87 01 1F 91 8E E3 45 E7 26 07 F8 7C B4 FC AF 4C 2F D6 95 B6 8F 98 F2 6A 8B 37 A4 C1 C9 63 7B 05 AD FF 53 B5 35 30 E0 13 0A FA 73 32 82 7F 65 F5 70 02 6C BE 25 34 C3 4A 67 E6 62 0D 54 83 A9 72 AA E4 C6 BF 5B FD 50 93 51 C5 CE 4D F7 2D 5F 36 03 F4 9F 56 A0 61 60 D5 9B 8D 5E E8 A3 E5 1D DE 8A 52 BC 2A 6D 75 F6 16 5C CD 78 D4 DD 27 1C 4E DF 1A 0E 33 9A FE DA 2C EF 28 C8 7D F3 71 EE F9 EC 09 6B CC 00 9E 59 97 88 90 9C 80 19 2E 84 EA DB C0 8C 3C 15 9D 40 69 21 96 22 B2 11 1B AC 3F 46 44 49 4F 77 2B 99 04 3B 10 41 A6 A8 6E D8 12 AE 94 E9 D7 BB 43 74 48 BA 64 AB 76 79 1E D3 5D 57 CA 31 14 FB 39 18 68 E2 F1 C7 85 F0 4B B1 D0 B9 58 3D 08 C2 6F C4 3A B8 06 EB 17 CB B0 5A 20 81 D2 55 A7 A1 24 B3 E4 0B 07 26 48 42 2E D5 66 69 CC 01 A5 57 B4 7B A4 C8 6B 5C B1 0D F6 8B B7 B9 C7 71 24 1B 5E 0F BE B8 AC 3B 9E 3F 4A CD D4 08 45 AF A7 25 F4 19 DD 17 DB 70 A6 CF 22 47 EF 9A AE 54 FD 77 D8 EE 1F D3 46 81 F3 E6 74 16 EC 62 F1 6E F0 33 D7 37 85 2C C5 E1 C0 51 11 05 C2 CB 03 38 43 09 67 D2 68 50 86 34 59 20 56 5B 0E AD B3 04 3E 76 3D 89 0A 23 5F 82 C4 F5 93 DF 06 9F 9B 31 97 88 83 8F 44 A0 4F E2 B5 6D D9 FB 4B 12 B6 9C 78 55 7D F9 3A A1 DC 2B 6F EA 73 1D 9D 2D 7A 60 15 0C 6C E5 72 35 E9 6A 95 C1 A3 4D BC F7 02 FA 84 CA 41 92 BF 49 7F 7E 1C 29 80 EB E8 52 40 32 4E 8C D1 DA 91 8E 5A FC 98 A2 00 1E 79 21 BA 5D 13 3C C3 99 65 61 10 8D 36 27 58 96 BD F2 D0 A8 14 C6 CE FE 2A AA FF 2F B2 1A 4C E0 D6 DE 64 7C 94 75 BB 28 90 A9 ED 87 30 53 8A C9 AB 63 B0 E3 39 F8 E7 18 24 8C DA 76 BC 3C 69 B9 02 E3 2D BE 40 48 F2 EA A6 C5 1C 5F 06 3F 7B 11 AF 6E 71 8E 3D F5 26 75 0E 34 96 88 07 18 CC 6A 85 AA 55 0F EF B7 2C CB A0 B1 CE 00 F3 F7 86 1B 82 50 58 68 2B 64 46 3E 03 57 35 DB E4 A3 7F FC 12 5C D7 04 2A 61 94 6C 8A BF 16 7D 29 DF E9 E8 D8 1A 47 4C 7E C4 D6 A4 23 FB 4F 6D D2 36 D9 74 EE C3 EB 6F DD 84 20 0A F9 7C E5 8B AC 37 4A BD 83 9A FA 73 0B BB EC F6 CF B6 C0 CD FE C6 10 A2 A8 E0 AB 1F 98 3B 25 92 52 63 05 49 9C B5 C9 14 01 1E 15 19 90 09 0D A7 65 70 E2 80 89 45 D0 17 66 A5 41 A1 7A F4 67 F8 56 C7 87 93 13 BA 53 77 D5 9F F1 44 54 5D 95 AE 08 A9 DC 5B 28 2E 3A AD 31 B3 62 8F 42 9E D3 39 30 59 B4 D1 4B 81 4D E6 6B E1 4E 78 79 0C 38 C2 DE D4 B8 43 72 9D 91 B0 33 C1 22 ED F0 FF 5A 97 27 9B 60 1D 32 5E FD CA B2 8D C8 99 21 2F 51 E7 F4 AD 7A 50 B3 9E 1F 9B 46 A2 04 A9 8B 53 1D 3F CB 7B 86 9C EA F3 03 8A 47 DC CD 3A 0C 89 FB 95 11 5A 1C E4 2C 62 74 A7 D3 94 8C 0F 27 73 AB 45 B4 0E D4 A6 6A A8 3C 37 AF 59 98 99 CF FA 0D 66 C7 9F BB 5C DA F5 7F 25 68 77 1A BC 44 7E F8 E6 14 5B 4E 36 20 F2 18 28 87 83 6B F6 C1 D0 70 BE 38 30 9A 82 93 72 CE 5D 4C CC C9 19 FC 54 06 AA 85 4D 05 56 1E DF FE 01 4F 76 61 0B B5 D6 2F 6C 8F 80 E7 2A B1 43 9D 52 ED 02 C0 E1 A4 AE 33 C8 5F 51 97 21 FD C2 E9 B8 2E 42 BA 8D EB 57 6D 10 EE 32 49 A3 C3 41 FF 12 5E 58 DD 4A D9 78 2B AC 7C 09 B2 48 91 1B 08 3E F1 3B 96 3D 29 40 A1 C4 84 0A 88 17 D5 16 D1 31 35 F9 67 A0 00 15 F0 92 2D 24 DE E5 EF A5 34 81 CA 63 07 23 B7 26 E3 F7 4B E8 E2 55 90 D8 6F DB B6 8E D2 60 C6 BF BD B0 79 E0 D7 7D 6E 71 69 65 C5 EC 64 B9 13 22 39 75 0B A7 F1 59 C4 14 41 C1 C3 50 9E 7F 97 8F 35 3D 22 61 B8 DB 6C 06 42 7B F3 0C 13 D2 08 5B 88 40 F5 EB 49 73 17 B1 65 7A 72 28 D7 F8 B6 51 CA 92 7D B3 CC DD 66 FB 8A 8E 15 25 2D FF 43 3B 19 56 A6 48 2A 7E 81 02 DE 99 79 AA 21 6F 11 E9 1C 57 00 6B C2 F7 95 94 A2 54 31 3A 67 A5 D9 AB B9 03 10 32 86 5E 09 A4 4B AF 12 96 BE 93 77 5D F9 A0 F6 98 01 84 C0 37 4A D1 0E 87 E7 FE 8B 91 C6 76 B0 BD CB B2 DF 6D BB 83 62 D6 9D D5 EF 58 46 E5 34 78 1E 2F 69 B4 C8 E1 64 68 63 7C DA 70 74 ED FD 9F 0D 18 6A AD 38 F4 DC 3C D8 1B 85 1A 89 07 EE FA BA 2B 0A 2E C7 6E 39 8C E2 A8 D3 E8 20 29 26 A1 D4 75 D0 47 53 55 F2 1F CE 4C 44 AE E3 3F AC C9 24 4D 9B 30 FC 36 05 33 9C 16 BF 45 71 04 3E C5 A9 A3 CD EC E0 0F 90 5F BC 4E EA 27 82 8D 60 1D E6 5A B7 80 23 4F E4 B5 F0 CF 9A 2C 52 5C DB A3 B6 F9 C5 F5 1F CD 1B 86 6E 6A 53 9D 3D 2C B1 56 72 2A C8 92 18 37 51 F7 9A 85 0B 15 93 A9 BB E8 A0 68 EC 13 32 F3 E6 8C 9B A2 81 C2 3B 58 6F 77 DD D5 B0 23 9F 7E F4 24 21 A1 47 EB B9 11 71 6B 96 26 67 EE 1E 07 D7 20 31 AA 78 16 64 E1 BD 97 40 19 76 F2 73 5E 44 E9 4F AB D2 F0 BE 66 4B 39 E3 59 DA D1 45 87 74 75 B4 42 8B E0 17 22 09 F1 B7 FC 4A 99 8F C1 E2 61 79 3E A8 46 9E CA 08 33 C9 C0 6C D9 48 02 CE EA 8E 27 1A 0E CB 5A FA 65 E7 69 DC 3C FB 38 4D 8A 14 D8 7F 1D F8 ED 90 3A 0D 94 88 84 9C 83 54 89 01 28 98 D4 CF FE B8 0F 05 A6 36 82 35 7D 8D 3F 63 5B 5D 50 52 2B CC 7A BC B2 55 04 2F 10 60 57 AF C3 FD 80 BA 06 C7 0A 6D 62 BF 70 AE 5C 0C 2D EF 00 25 DE 43 49 A5 5F E4 91 D3 E5 F6 7C D0 7B D6 1C 29 4C AD C4 4E A4 DF 03 FF 12 AC 2E A7 30 B5 B3 41 C6 95 34 61 C0 B5 32 41 47 53 C4 58 DA 0B E6 2B F7 BA 50 59 30 DD B8 22 E8 24 8F 02 88 27 11 10 65 51 AB B7 BD D1 2A 1B F4 F8 D9 5A A8 4B 84 99 96 33 FE 4E F2 09 74 5B 37 94 A3 DB E4 A1 F0 48 46 38 8E A6 DF A9 A4 97 AF 79 CB C1 89 C2 76 F1 52 4C FB 3B 0A 6C 20 F5 DC A0 7D 68 77 7C 70 F9 60 64 CE 0C 19 8B E9 E0 2C B9 7E 0F CC 28 C8 13 9D 0E 91 3F AE EE FA 7A D3 3A 1E BC F6 98 2D 3D 34 FC C7 6A 3E 5C B2 8D CA 16 95 7B 35 BE 6D 43 08 FD 05 E3 D6 7F 14 40 B6 80 81 B1 73 2E 25 17 AD BF CD 4A 92 26 04 BB 5F B0 1D 87 AA 82 06 B4 ED 49 63 90 15 8C E2 C5 5E 23 D4 EA F3 93 1A 62 D2 85 9F 4D E5 B3 1F D5 55 00 D0 6B 8A 44 D7 29 21 9B 83 CF AC 75 36 6F 56 12 78 C6 07 18 E7 54 9C 4F 1C 67 5D FF E1 6E 71 A5 03 EC C3 3C 66 86 DE 45 A2 C9 D8 A7 69 9A 9E EF 72 EB 39 31 01 42 0D 2F 57 1F 82 6A 6E 57 99 39 28 DF A7 B2 FD C1 F1 1B C9 55 F3 9E 81 0F 11 97 AD B5 52 76 2E CC 96 1C 33 E2 88 9F A6 85 C6 3F 5C BF EC A4 6C E8 17 36 F7 F0 20 25 A5 43 EF BD 15 6B 73 D9 D1 B4 27 9B 7A D3 24 35 AE 7C 12 60 E5 75 6F 92 22 63 EA 1A 03 40 ED 4B AF D6 F4 BA 62 B9 93 44 1D 72 F6 77 5A 70 71 B0 46 8F E4 13 26 4F 3D E7 5D DE D5 41 83 E6 65 7D 3A AC 42 9A CE 0D F5 B3 F8 4E 9D 8B C5 CA EE 8A 23 1E 0A CF 5E 0C 37 CD C4 68 DD 4C 06 49 8E 10 DC 7B 19 FC E9 FE 61 E3 6D D8 38 FF 3C 50 8D 05 2C 9C D0 CB FA 94 3E 09 90 8C 80 98 87 89 3B 67 5F 59 54 56 2F BC 0B 01 A2 32 86 31 79 64 53 AB C7 F9 84 BE 02 C8 7E B8 B6 51 00 2B 14 08 29 EB 04 21 DA 47 4D C3 0E 69 66 BB 74 AA 58 D4 7F D2 18 2D 48 A9 C0 A1 5B E0 95 D7 E1 F2 78 A3 34 B1 B7 45 C2 91 30 4A A0 DB 07 FB 16 A8 2A 12 E0 03 CC D1 DE 7B B6 FF F5 99 62 53 BC B0 91 93 AC E9 B8 00 0E 70 C6 06 BA 41 3C 13 7F DC EB 10 92 43 AE 63 BF F2 18 29 88 FD 7A 09 0F 1B 8C 4A C0 6F 59 58 2D 19 E3 11 78 95 F0 6A A0 6C C7 47 84 60 80 5B D5 46 D9 44 51 C3 A1 A8 64 F1 36 F4 BE D0 65 75 7C B4 8F 77 E6 A6 B2 32 9B 72 56 89 C1 8A 3E B9 1A 04 B3 EE 97 E1 EC DF E7 31 83 20 3F 34 38 B1 28 2C 86 73 42 24 68 BD 94 E8 35 CF E2 CA 4E FC A5 01 2B 02 DA 6E 4C F3 17 F8 55 A2 BB DB 52 2A 9A CD D7 D8 5D C4 AA 8D 16 6B 9C 33 7D F6 25 0B 40 B5 4D 22 76 14 FA C5 82 5E DD F9 3B 66 6D 5F E5 F7 85 AB 9E 37 5C 08 FE C8 C9 A4 8B 74 2E CE 96 0D EA 2F 15 B7 A9 26 39 ED 4B A3 71 79 49 0A 45 67 1F 81 90 EF 21 D2 D6 A7 3A 23 C2 0C 9F 61 69 D3 CB 05 AD FB 57 9D 1D 48 98 8E 4F 50 AF 1C D4 07 54 87 E4 3D 7E 27 1E 5A 30 54 40 00 91 B0 94 7D D4 83 36 58 12 69 52 9A 93 47 25 B7 A2 D0 17 82 4E 66 86 62 A1 3F A0 33 BD 8E C2 A4 95 D3 0E 72 5B DE D2 D9 C6 60 CA CE 57 0A 07 71 08 65 D7 01 39 D8 6C 27 6F 55 E2 FC 5F DA A7 5C E0 0D 3A 99 F5 5E 0F 4A 75 20 96 E8 E6 84 7F 13 19 77 56 5A B5 2A E5 06 F4 50 9D 38 37 16 73 9E F7 21 8A 46 8C BF 89 26 AC 05 FF CB BE 9C 1B 6E CF 6A FD E9 EF 48 A5 74 F6 FE 14 59 85 C7 09 76 67 DC 41 30 34 AF 9F 97 45 F9 81 A3 EC 4F 51 F3 C9 AD 0B DF C0 C8 92 6D 42 0C EB 70 28 98 DB 02 61 D6 BC F8 C1 49 B6 A9 68 B2 E1 32 FA B1 1D 4B E3 7E AE FB 7B 79 EA 24 C5 2D 35 8F 87 4C 22 BB 3E 7A 8D F0 6B B4 3D 5D 44 31 2B 7C CC AA 88 3C E4 B3 1E F1 15 A8 2C 04 29 CD E7 43 1A BA D1 78 4D 2F 2E 18 EE 8B 80 DD 1F 63 11 03 B9 1C F2 90 C4 3B B8 64 23 C3 10 9B D5 AB 53 A6 ED 34 F7 30 D0 65 EB 69 F6 E1 F4 11 73 D4 18 86 41 0E 44 D5 60 CC C5 3F 04 56 C7 02 16 2B 82 E6 C2 71 39 8E 3A AA 09 03 B4 27 5E 5C 51 57 6F 33 81 8F 90 88 84 98 01 36 9C F2 C3 D8 94 24 0D 85 58 50 A2 7C B3 6E 61 06 CB 45 4F D2 29 0C E3 21 00 1C 23 08 59 BE B0 76 C0 0A B6 8C F1 CF A3 5B 6C 22 A0 1E F3 0F D3 A8 42 38 99 CA 4D BF B9 3C AB 70 FA E9 DF 9D E8 53 A9 C8 A1 40 25 10 DA 77 DC 3B 14 9E C4 26 7E 5A BD A5 9F 19 07 89 96 FB 5D C1 13 F9 C9 F5 BA AF D7 20 31 91 5F 66 62 8A 17 72 93 2F BC D9 D1 7B 63 1D B5 E7 4B AD 2D 28 F8 FF 3E 1F E0 64 AC E4 B7 54 37 CE 8D AE 97 80 EA 52 7F FE 7A 15 4C 9B B1 6A B2 FC DE A7 43 E5 48 0B 12 E2 6B 2A 9A 67 7D ED 68 1A 74 A6 3D 2C DB CD 83 95 46 F0 BB FD 05 C6 92 4A A4 32 75 6D EE 8B 49 DD D6 55 EF 35 47 2E 1B EC 87 4E B8 79 78 B2 BB 41 7A 70 3A AB 1E 55 FC 98 BC 28 B9 7C 68 1B 95 17 88 4A 89 4E AE AA 66 F8 3F 9F 8A 6F 0D E6 7F 48 E2 F1 EE F6 FA 5A 73 FB 26 8C BD A6 EA D4 77 7D CA 0F 47 F0 44 29 11 4D FF 59 20 22 2F C0 CE 08 BE 62 5D 76 27 B1 DD 25 12 74 C8 F2 8F 10 1F 78 B5 2E DC 02 CD 72 9D 5F 7E 3B 31 AC 57 E3 96 2D D7 0E 84 97 A1 6E A4 09 A2 B6 DF 3E 5B 71 AD D6 3C 5C DE 60 8D C1 C7 42 D5 46 E7 B4 33 8B C4 D1 A9 BF 6D 87 B7 18 1C F4 69 5E 4F EF 21 58 00 24 C3 45 6A E0 BA F7 E8 85 23 DB E1 67 79 1A D2 9A C9 81 40 61 9E D0 E9 FE 94 2A 49 B0 F3 A7 AF 05 1D 0C ED 51 C2 D3 53 56 86 63 CB 99 35 54 E4 19 03 75 6C 9C 15 D8 43 52 A5 93 16 64 0A 6B 32 E5 CF 2C 01 80 04 D9 3D 9B 36 14 CC 82 A0 2B 91 4B 39 F5 37 A3 A8 30 C6 07 06 50 65 92 F9 8E C5 83 7B B3 FD EB 38 4C 0B 13 90 B8 EC 34 DA 5B F1 F5 6C E5 E9 E2 FD E8 35 49 60 B5 F9 9F AE 6E D9 C7 64 E3 57 1C 54 5E EC 3A 02 31 3C 4A 33 52 69 A1 A8 B8 0D 63 29 8B AF 46 EF 6F 7B 3B AA 04 9B 08 86 5D BD 59 9A EB 2C B9 75 7C 1E 8C 99 3E C4 F0 85 84 B2 1D 97 1A B1 7D B7 2D 48 A5 CC C5 2F 62 BE 73 9E 4F CD 51 C6 D2 D4 A7 20 55 F4 1B AD D3 DD 65 34 71 4E 36 01 A2 CE E1 9C 67 DB 6B A6 03 0C 11 DE 3D CF 4C 6D 61 8E BF 44 28 22 89 DA 09 C1 72 8D 92 53 ED 87 C3 FA A3 E0 39 5A 16 0E B4 BC 42 D1 1F FE 45 95 C0 40 8A 26 70 D8 C2 BA 98 D7 94 A4 AC 7E E7 7A 0B 0F FC 32 4D 5C 37 D0 4B 13 F3 A9 56 79 96 30 E4 FB 74 6A C8 F2 58 2A 38 82 B0 BB E6 24 14 15 23 D5 81 EA 43 76 90 68 9D D6 F8 2B A0 EE 00 83 5F 18 27 C9 AB FF 0A 10 47 F7 8F 06 66 7F 41 B6 CB 50 77 19 80 05 F6 DC 78 21 93 17 3F 12 88 25 CA 2E 91 B3 07 DF EC 56 8C FE 32 F0 64 6F F7 01 C0 C1 97 A2 55 3E 49 02 44 BC 74 3A 2C FF 8B CC D4 57 7F 2B F3 1D 93 23 DE C4 B2 AB 5B D2 1F 84 95 62 54 D1 A3 CD AC F5 22 08 EB C6 47 C3 1E FA 5C F1 D3 0B 45 67 DD 15 5D 0E 46 87 A6 59 17 2E 39 53 ED 8E 77 34 60 68 C2 DA CB 2A 96 05 14 94 91 41 A4 0C 5E F2 4C 03 16 6E 78 AA 40 70 DF DB 33 AE 99 88 28 E6 9F C7 E3 04 82 AD 27 7D 30 2F 42 E4 1C 26 A0 BE 24 51 EA 10 C9 43 50 66 A9 63 CE 65 71 18 F9 9C B6 6A 11 FB 9B 19 A7 4A 06 00 85 12 81 20 73 F4 07 09 CF 79 A5 9A B1 E0 76 1A E2 D5 B3 0F 35 48 D7 D8 BF 72 E9 1B C5 0A B5 5A 98 B9 FC F6 6B 90 21 B8 8F 25 36 29 31 3D 9D B4 3C E1 4B 7A 61 2D 13 B0 BA 0D C8 80 37 83 EE D6 8A 38 9E E7 E5 E8 75 7C 86 BD B7 FD 6C D9 92 3B 5F 7B EF 7E BB AF DC 52 D0 4F 8D 4E 89 69 6D A1 3F F8 58 4D A8 CA A9 EE F6 75 5D 09 D1 3F 6B 20 66 9E 56 18 0E DD D5 23 E2 E3 B5 80 77 1C CE 74 AE DC 10 D2 46 4D 3C D8 7E D3 F1 29 67 45 8E D7 00 2A C9 E4 65 E1 3D A6 B7 40 76 F3 81 EF B1 01 FC E6 90 89 79 F0 36 B6 B3 63 86 2E 7C D0 42 4A E0 F8 E9 08 B4 27 35 0C 1B 71 CF AC 55 16 FF 37 7F 2C 64 A5 84 7B 12 0D 60 C6 3E 04 82 9C BD E5 C1 26 A0 8F 05 5F FD F9 11 8C BB AA 0A C4 6E 21 34 4C 5A 88 62 52 24 22 A7 30 A3 02 51 D6 94 48 33 D9 B9 3B 85 68 8B 41 EC 47 53 3A DB BE 06 73 C8 32 EB 61 72 44 97 78 BA 9B DE D4 49 B2 F5 FA 9D 50 CB 39 E7 28 54 38 C0 F7 91 2D 17 6A 25 2B ED 5B 87 B8 93 C2 CC F4 A8 1A BC C5 C7 CA 31 92 98 2F EA A2 15 A1 BF 96 1E C3 69 58 43 0F 03 9A AD 07 14 0B 13 1F 4F 83 1D DA 7A 6F 8A E8 FE 70 F2 6D AF 6C AB 4B B0 19 7D 59 CD 5C 99 8D 57 5E A4 9F 95 DF 4E FB 47 4D D0 2B 0E E1 23 02 52 A0 7E B1 6C 63 04 C9 08 B4 8E F3 CD A1 59 6E 1E 21 0A 5B BC B2 74 C2 3A 9B C8 4F BD BB 3E A9 20 A2 1C F1 0D D1 AA 40 CA A3 42 27 12 D8 75 DE 72 F8 EB DD 9F EA 51 AB E3 F6 13 71 D6 1A 84 43 36 F5 32 D2 67 E9 6B F4 54 C5 00 14 29 80 E4 C0 0C 46 D7 62 CE C7 3D 06 25 5C 5E 53 55 6D 31 83 73 3B 8C 38 A8 0B 01 B6 F0 C1 DA 96 26 0F 87 5A 8D 92 8A 86 9A 03 34 9E 68 B0 FE DC A5 41 E7 4A 50 7D FC 78 17 4E 99 B3 EF 6A 18 76 A4 3F 2E D9 09 10 E0 69 28 98 65 7F C4 90 48 A6 30 77 6F EC CF 81 97 44 F2 B9 FF 07 2C 19 EE 85 4C BA 7B 7A 89 4B DF D4 57 ED 37 45 A7 9D 1B 05 8B 94 F9 5F 39 16 9C C6 24 7C 58 BF 22 33 93 5D 64 60 88 15 C3 11 FB CB F7 B8 AD D5 1F B7 E5 49 AF 2F 2A FA 70 91 2D BE DB D3 79 61 56 35 CC 8F AC 95 82 E8 FD 3C 1D E2 66 AE E6 B5 14 BE BA 23 AA A6 AD B2 A7 7A 06 2F FA B6 D0 E1 21 96 88 2B AC 18 53 1B 11 A3 75 4D 7E 73 05 7C 1D 26 EE E7 F7 42 2C 66 C4 E0 09 A0 20 34 74 E5 4B D4 47 C9 12 F2 16 D5 A4 63 F6 3A 33 51 C3 D6 71 8B BF CA CB FD 52 D8 55 FE 32 F8 62 07 EA 83 8A 60 2D F1 3C D1 00 82 1E 89 9D 9B E8 6F 1A BB 54 E2 9C 92 2A 7B 3E 01 79 4E ED 81 AE D3 28 94 24 E9 4C 43 5E 91 72 80 03 22 2E C1 F0 0B 67 6D C6 95 46 8E 3D C2 DD 1C A2 C8 8C B5 EC AF 76 15 59 41 FB F3 0D 9E 50 B1 0A DA 8F 0F C5 69 3F 97 8D F5 D7 98 DB EB E3 31 A8 35 44 40 B3 7D 02 13 78 9F 04 5C BC E6 19 36 D9 7F AB B4 3B 25 87 BD 17 65 77 CD FF F4 A9 6B 5B 5A 6C 9A CE A5 0C 39 DF 27 D2 99 B7 64 EF A1 4F CC 10 57 68 86 E4 B0 45 5F 08 B8 C0 49 29 30 0E F9 84 1F 38 56 CF 4A B9 93 37 6E DC 58 70 5D C7 6A 85 61 DE FC 48 90 62 6C 12 A4 F1 CE 8B DA 71 1D BE 89 64 D8 23 5E B3 BC 19 D4 70 82 61 AE 31 DE D2 F3 9D 97 FB 00 3A 4F 7B 81 28 A2 0D 3B 08 C2 0E A5 73 1A F7 92 01 DD 90 7A 72 F0 21 CC 6B 6D 79 EE 4B EA 9F 18 17 1E D6 ED 96 DC B2 07 50 F9 10 34 15 84 C4 D0 39 B7 24 BB 25 E6 02 E2 CA 06 93 54 26 33 A1 C3 D3 4A 4E E4 42 5D 56 5A DF F6 8A 57 11 20 46 0A DB 78 66 D1 EB A3 E8 5C BD 85 53 E1 8C F5 83 8E 48 F8 AF B5 C0 D9 B9 30 EF 74 09 FE BA 3F A6 C8 9E C7 63 49 AD 80 A8 2C 91 75 9A 37 60 B8 0C 2E 3D 87 95 E7 9B 59 04 0F 6A 9C AA AB C9 FC 55 3E 69 22 D7 2F 51 1F 94 47 A7 E0 3C BF 40 14 76 98 68 27 05 7D C1 13 1B 2B B0 B4 C5 58 E3 F2 8D 43 AC F4 6F 88 C6 E9 16 4C 44 5B 8F 29 4D 77 D5 CB 7E B6 65 36 EC 2D 32 CD 45 7C 38 52 E5 86 5F 1C 03 0B B1 A9 41 A0 6E FD FF 7F 2A FA 67 CF 99 35 9D 4F 47 77 34 7B 59 21 BF AE D1 1F EC E8 99 04 9A B5 4A 10 F0 A8 33 D4 11 2B 89 97 18 07 D3 75 B0 71 6E 91 22 EA 39 6A B9 DA 03 40 19 20 64 0E 1D FC 32 A1 5F 57 ED F5 3B 93 C5 69 A3 23 76 A6 9C 85 E5 6C 14 A4 F3 E9 E6 63 FA 94 B3 28 55 A2 F1 DC F4 70 C2 9B 3F 15 3C E4 50 72 CD 29 C6 6B C7 05 58 53 61 DB C9 BB 95 A0 09 62 36 C0 F6 F7 0D 43 C8 1B 35 7E 8B 73 1C 48 2A C4 FB BC 60 E3 CA 80 EE 5B 4B 42 8A B1 49 D8 98 8C 0C A5 4C 68 79 BA 5E BE 65 EB 78 E7 7A 6F FD 9F 96 5A CF 08 1E 01 0A 06 8F 16 12 B8 4D 7C 1A 56 83 AA D6 0B B7 FF B4 00 87 24 3A 8D D0 A9 DF D2 E1 D9 0F BD AD 92 D7 86 3E 30 4E F8 38 84 7F 02 2D 41 E2 D5 2C DE 3D F2 EF E0 45 88 C1 CB A7 5C 6D 82 8E AF 74 FE 51 67 66 13 27 DD 2F 46 AB CE 54 9E 52 F9 2E AC 7D 90 5D 81 CC 26 17 B6 C3 44 37 31 25 B2 A4 85 47 A8 8D 76 EB E1 6F A2 C5 CA 17 D8 06 F4 C8 FF 07 6B 55 28 12 AE 64 D2 14 1A FD AC 87 B8 0F 98 1D 1B E9 6E 3D 9C E6 0C 77 AB 57 BA 04 86 78 D3 7E B4 81 E4 05 6C 0D F7 4C 39 7B 4D 5E D4 E5 22 BC 70 D7 B5 50 45 52 CD 4F C1 74 94 53 90 66 42 26 8F B2 A6 63 F2 A0 9B 61 68 C4 71 E0 AA 25 97 CB F3 F5 F8 FA 83 10 A7 AD 0E 9E 2A 9D D5 FC 21 A9 80 30 7C 67 56 38 92 A5 3C 20 2C 34 2B EC 41 E7 03 7A 58 16 CE 15 3F E8 B1 DE 5A DB F6 7F 88 99 02 D0 BE CC 49 D9 C3 3E 8E CF 46 B6 AF 4A C9 D1 96 00 EE 36 62 A1 59 1F 54 E2 31 27 69 DC DD 1C EA 23 48 BF 8A E3 91 4B F1 72 79 ED 2F F9 5F 32 2D A3 BD 3B 01 19 FE DA 82 60 3A B0 9F B3 2E C6 C2 FB 35 95 84 73 0B 1E 51 6D 5D B7 65 5C 8C 89 09 EF 43 11 B9 C7 DF 75 7D 18 8B 37 D6 4E 24 33 0A 29 6A 93 F0 13 40 08 C0 44 BB 9A 5B BC D2 A0 25 13 E4 F5 6E A3 2A DA C3 B5 AF 52 E2 16 34 7A A2 80 2D 8B 6F B2 36 B7 9A 79 53 84 DD 4F 24 D3 E6 B0 B1 70 86 1E 15 81 43 8F FD 27 9D 6C 82 5A 0E 26 A5 BD FA 8E 5D 4B 05 CD 35 73 38 97 59 F9 E8 DF 42 AA AE 01 31 DB 09 1F 67 72 3D CF D1 57 6D 95 33 5E 41 0C 56 DC F3 75 92 B6 EE 45 06 FF 9C 22 48 5F 66 28 D7 F6 37 7F 2C 64 AC 83 2F 7D D5 30 E0 E5 65 74 E7 5B BA AB B3 19 11 39 44 7E C2 A4 93 6B 07 91 C0 EB D4 08 BE 78 76 E1 1A 87 8D C8 E9 2B C4 7B B4 6A 98 03 CE A9 A6 ED 88 69 00 14 BF 12 D8 17 21 32 B8 61 9B 20 55 85 02 51 F0 63 F4 71 77 3B D6 68 EA 8A 60 1B C7 DE CA 0F 9E 0A 2E 4A E3 A8 1D 8C C6 CC F7 0D 04 BB D9 3C 29 89 4E D0 1C 18 F8 3F FC 3E A1 23 AD 5C 10 0B 3A 90 4D C5 EC 4C 40 58 47 54 FE C9 50 99 94 96 EF 49 FB A7 9F F2 46 F1 B9 7C CB C1 62 8B 10 6D 9A DE 5B C2 AC 2C 9C CB D1 A4 BD DD 54 F5 11 FE 53 04 DC 68 4A FA A3 07 2D C9 E4 CC 48 0E F8 CE CF AD 98 31 5A 59 E3 F1 83 FF 3D 60 6B C3 84 58 DB 24 70 12 FC 0D 46 B3 4B 35 7B F0 23 D4 D0 A1 3C 87 96 E9 27 0C 43 61 19 A5 77 7F 4F 20 3F EB 4D 29 13 B1 AF C8 90 0B EC A2 8D 72 28 21 18 5C 36 81 E2 3B 78 1A D2 01 52 88 49 56 A9 9B 1B 4E 9E 03 AB FD 51 67 6F D5 CD 25 C4 0A 99 15 79 DA ED 00 BC 47 3A 06 08 76 C0 95 AA EF BE 55 BA B6 97 F9 F3 9F 64 D7 D8 7D B0 14 E6 05 CA 6C A6 6A C1 17 7E 93 F6 5E 2B 1F E5 4C C6 69 5F 0F 09 1D 8A 2F 8E FB 7C 65 B9 F4 1E 16 94 45 A8 34 9D 74 50 71 E0 A0 B4 73 7A B2 89 F2 B8 D6 63 AE 62 F7 30 42 57 C5 A7 5D D3 40 DF 41 82 66 86 BB 92 EE 33 75 44 22 6E B7 2E 2A 80 26 39 32 3E D9 E1 37 85 E8 91 E7 EA BF 1C 02 B5 8F C7 8C 38 D2 DB 21 1A 10 5A CB 7E 35 9C F8 DC 48 D9 1C 08 7B F5 77 E8 2A E9 2E CE CA 06 98 5F FF EA 0F 6D 86 1F 28 82 91 8E 96 9A 3A 13 9B 46 EC DD C6 8A B4 17 1D AA 6F 27 90 24 49 71 2D 9F 39 40 42 4F A0 AE 68 DE 02 3D 16 47 D1 BD 45 72 14 A8 92 EF 70 7F 18 D5 4E BC 62 AD 12 FD 3F 1E 5B 51 CC 37 83 F6 4D B7 6E E4 F7 C1 0E C4 69 C2 D6 BF 5E 3B 11 CD B6 5C 3C BE 00 ED A1 A7 22 B5 26 87 D4 53 EB A4 B1 C9 DF 0D E7 D7 78 7C 94 09 3E 2F 8F 41 38 60 44 A3 25 0A 80 DA 97 88 E5 43 BB 81 07 19 7A B2 FA A9 E1 20 01 FE B0 89 9E F4 4A 29 D0 93 C7 CF 65 7D 6C 8D 31 A2 B3 33 36 E6 03 AB F9 55 34 84 79 63 15 0C FC 75 B8 23 32 C5 F3 76 04 6A 0B 52 85 AF 4C 61 E0 64 B9 5D FB 56 74 AC E2 C0 4B F1 2B 59 95 57 C3 C8 50 A6 67 66 30 05 F2 99 EE A5 E3 1B D3 9D 8B 58 2C 6B 73 F0 D8 8C 54 BA 2C 54 41 0E 32 02 E8 3A EC 71 99 9D A4 6A CA DB 46 A1 85 DD 3F 65 EF C0 A6 00 6D 72 FC E2 64 5E 4C 1F 57 9F 1B E4 C5 04 11 7B 6C 55 76 35 CC AF 98 80 2A 22 47 D4 68 89 03 D3 D6 56 B0 1C 4E E6 86 9C 61 D1 90 19 E9 F0 20 D7 C6 5D 8F E1 93 16 4A 60 B7 EE 81 05 84 A9 B3 1E B8 5C 25 07 49 91 BC CE 14 AE 2D 26 B2 70 83 82 43 B5 7C 17 E0 D5 FE 06 40 0B BD 6E 78 36 15 96 8E C9 5F B1 69 3D FF C4 3E 37 9B 2E BF F5 39 1D 79 D0 ED F9 3C AD 0D 92 10 9E 2B CB 0C CF BA 7D E3 2F 88 EA 0F 1A 67 CD FA 63 7F 73 6B 74 A3 7E F6 DF 6F 23 38 09 4F F8 F2 51 C1 75 C2 8A 7A C8 94 AC AA A7 A5 DC 3B 8D 4B 45 A2 F3 D8 E7 97 A0 58 34 0A 77 4D F1 30 FD 9A 95 48 87 59 AB FB DA 18 F7 D2 29 B4 BE 52 A8 13 66 24 12 01 8B 27 8C 21 EB DE BB 5A 33 B9 53 28 F4 08 E5 5B D9 50 C7 42 44 B6 31 62 C3 B9 C1 D4 9B A7 97 7D AF 79 E4 0C 08 31 FF 5F 4E D3 34 10 48 AA F0 7A 55 33 95 F8 E7 69 77 F1 CB D9 8A C2 0A 8E 71 50 91 84 EE F9 C0 E3 A0 59 3A 0D 15 BF B7 D2 41 FD 1C 96 46 43 C3 25 89 DB 73 13 09 F4 44 05 8C 7C 65 B5 42 53 C8 1A 74 06 83 DF F5 22 7B 14 90 11 3C 26 8B 2D C9 B0 92 DC 04 29 5B 81 3B B8 B3 27 E5 16 17 D6 20 E9 82 75 40 6B 93 D5 9E 28 FB ED A3 80 03 1B 5C CA 24 FC A8 6A 51 AB A2 0E BB 2A 60 AC 88 EC 45 78 6C A9 38 98 07 85 0B BE 5E 99 5A 2F E8 76 BA 1D 7F 9A 8F F2 58 6F F6 EA E6 FE E1 36 EB 63 4A FA B6 AD 9C DA 6D 67 C4 54 E0 57 1F EF 5D 01 39 3F 32 30 49 AE 18 DE D0 37 66 4D 72 02 35 CD A1 9F E2 D8 64 A5 68 0F 00 DD 12 CC 3E 6E 4F 8D 62 47 BC 21 2B C7 3D 86 F3 B1 87 94 1E B2 19 B4 7E 4B 2E CF A6 2C C6 BD 61 9D 70 CE 4C C5 52 D7 D1 23 A4 F7 56 04 7D 0B 06 35 0D DB 69 63 2B 60 D4 53 F0 EE 59 99 A8 CE 82 57 7E 02 DF CA D5 DE D2 5B C2 C6 6C AE BB 29 4B 42 8E 1B DC AD 6E 8A 6A B1 3F AC 33 9D 0C 4C 58 D8 71 98 BC 1E 54 3A 8F 9F 96 5E 65 C3 62 17 90 E3 E5 F1 66 FA 78 A9 44 89 55 18 F2 FB 92 7F 1A 80 4A 86 2D A0 2A 85 B3 B2 C7 F3 09 15 1F 73 88 B9 56 5A 7B F8 0A E9 26 3B 34 91 5C EC 50 AB D6 F9 95 36 01 79 46 03 52 EA E4 9A 2C EF 47 11 BD 77 F7 A2 72 C9 28 E6 75 8B 83 39 21 6D 0E D7 94 CD F4 B0 DA 64 A5 BA 45 F6 3E ED BE C5 FF 5D 43 CC D3 07 A1 4E 61 9E C4 24 7C E7 00 6B 7A 05 CB 38 3C 4D D0 49 9B 93 A3 E0 AF 8D F5 C8 9C FE 10 2F 68 B4 37 D9 97 1C CF E1 AA 5F A7 41 74 DD B6 E2 14 22 23 13 D1 8C 87 B5 0F 1D 6F E8 30 84 A6 19 FD 12 BF 25 08 20 A4 16 4F EB C1 32 B7 2E 40 67 FC 81 76 48 51 31 B8 C0 70 27 3D 4A 5F CD AF A6 6A FF 38 49 8A 6E 8E 55 DB 48 D7 79 E8 A8 BC 3C 95 7C 58 FA B0 DE 6B 7B 72 BA 81 E0 99 EF E2 D1 E9 3F 8D 87 CF 84 30 B7 14 0A BD 7D 4C 2A 66 B3 9A E6 3B 2E 31 3A 36 BF 26 22 88 F1 FB 97 6C 5D B2 BE 9F 1C EE 0D C2 DF D0 75 B8 08 B4 4F 32 1D 71 D2 E5 9D A2 E7 B6 0E 00 7E C8 27 86 F3 74 07 01 15 82 1E 9C 4D A0 6D B1 FC 16 1F 76 9B FE 64 AE 62 C9 44 CE 61 57 56 23 17 ED 21 1B B9 A7 28 37 E3 45 AA 85 7A 20 C0 98 03 E4 8F 9E E1 2F DC D8 A9 34 AD 7F 77 47 04 4B 69 11 0B A3 F5 59 93 13 46 96 2D CC 02 91 6F 67 DD C5 89 EA 33 70 29 10 54 3E 80 41 5E A1 12 DA 09 5A 0C D4 60 42 FD 19 F6 5B C1 EC C4 40 F2 AB 0F 25 D6 53 CA A4 83 18 65 92 AC B5 D5 5C 24 94 C3 D9 2C 78 1A F4 CB 8C 50 D3 3D 73 F8 2B 05 4E BB 43 A5 90 39 52 06 F0 C6 C7 F7 35 68 63 51 EB F9 8B B2 F1 28 4B FC 96 D2 EB 63 9C 83 42 98 CB 18 D0 9B 37 61 C9 54 84 D1 51 53 C0 0E EF 07 1F A5 AD ED 23 5C 4D F6 6B 1A 1E 85 B5 BD 6F D3 AB 89 C6 65 7B D9 E3 87 21 F5 EA E2 B8 47 68 26 C1 5A 02 90 FB 52 67 05 04 32 C4 A1 AA F7 35 49 3B 29 93 36 D8 BA EE 11 92 4E 09 E9 3A B1 FF 81 79 8C C7 66 08 91 14 50 A7 DA 41 9E 17 77 6E 1B 01 56 E6 80 A2 16 CE 99 34 DB 3F 82 06 2E 03 E7 CD 69 30 A4 E8 8E BF F9 24 58 71 F4 F8 F3 EC 4A E0 E4 7D 20 2D 5B 22 4F FD 2B 13 F2 46 0D 45 7F C8 D6 75 7E 6A 2A BB 9A BE 57 FE A9 1C 72 38 43 78 B0 B9 6D 0F 9D 88 FA 3D A8 64 4C AC 48 8B 15 8A 19 97 3C 59 B4 DD 0B A0 6C A6 95 A3 0C 86 2F D5 E1 94 B6 31 44 E5 40 D7 C3 C5 62 8F 5E DC D4 3E 73 AF F0 8D 76 CA 27 10 B3 DF 74 25 60 5F 0A BC C2 CC AE 55 39 33 5D 7C 70 9F 00 CF 2C DE 7A B7 12 1D 75 87 59 96 4B 44 23 EE 60 6A F7 0C 29 C6 04 25 39 06 2D 7C 9B 95 53 E5 2F 93 A9 D4 EA 86 7E 49 07 85 3B D6 2A F6 8D 67 1D BC EF 68 9A 9C 19 8E 55 DF CC FA B8 CD 76 8C ED 84 65 00 35 FF 52 F9 11 D2 15 F5 40 CE 4C D3 C4 D1 34 56 F1 3D A3 64 2B 61 F0 45 E9 E0 1A 21 73 E2 27 33 0E A7 C3 E7 54 1C AB 1F 8F 2C 26 91 02 7B 79 74 72 4A 16 A4 AA B5 AD A1 BD 24 13 B9 D7 E6 FD B1 01 28 A0 7D 77 5A DB 5F 30 69 BE 94 4F 97 D9 FB 82 66 C0 6D 2E 37 C7 4E 0F BF 42 58 C8 4D 3F 51 83 18 09 FE E8 A6 B0 63 D5 9E D8 20 E3 B7 6F 81 17 50 48 CB AE 6C F8 F3 70 CA 10 62 0B 3E C9 A2 6B 9D 5C 5D 1E 31 BB E1 03 5B 7F 98 80 BA 3C 22 AC B3 DE 78 E4 36 DC EC D0 9F 8A F2 05 14 B4 7A 43 47 AF 32 57 B6 0A 99 FC F4 5E 46 38 90 C2 6E 88 08 0D DD DA 1B 3A C5 41 89 C1 92 71 12 EB A8 8B B2 A5 CF) */;

	internal static readonly Struct4 struct4_0/* Not supported: data(A9 4A 41 95 E2 01 43 2D 9B CB 46 04 05 D8 4A 21 C9 9C BC FE 2B 9D FF D3 B0 56 B9 D7 B5 8E F3 F6 D2 91 FE 2B F9 0C 01 F8 49 5A B8 2F FC D4 4B D9 9E 22 CB 9B 67 2E CA 63 2E 74 72 4C D2 A0 39 95 05 30 E1 2E 11 1E 2B 4D 3F 6A 59 01 ED CA 60 94 12 E0 C3 7B 03 FE E8 36 3C 94 B1 37 D1 5E D1 A3 63 DE C9 45 69 20 21 73 55 B4 90 44 84 EA 41 E7 AD 5D 5D 1A C4 7D 7C 69 91 C9 EC 2D 15 23 AD CA EF C8 29 43 CF B5 55 2A 5E 7C B9 07 4B 5F 14 CD DF 32 94 F0 10 87 C1 DA 4E FB 78 DD 05 A4 6C 10 A0 62 5E 9B B0 E5 9F 41 FE 1E E7 9C FB BA 8B 8C) */;

	internal static readonly Struct1 struct1_0/* Not supported: data(CD 7E 79 6F 2A B2 5D CB 55 FF C8 EF 83 64 C4 70) */;

	internal static uint smethod_0(string string_0)
	{
		uint num = 2166136261u;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				num = (string_0[i] ^ num) * 16777619;
			}
		}
		return num;
	}
}
namespace AutoPico.Activador
{
	public class Backup
	{
		internal static void smethod_0(ref bool bool_0, ref Variables variables_0)
		{
			string text = variables_0.DirectorioBackupTokens + "\\Windows";
			string text2 = variables_0.DirectorioBackupTokens + "\\Office";
			string string_ = variables_0.DirectorioBackupTokens + "\\Keys.txt";
			try
			{
				FileSystemProxy fileSystem = ((ServerComputer)Class79.smethod_0()).get_FileSystem();
				if (!fileSystem.DirectoryExists(variables_0.DirectorioBackupTokens))
				{
					fileSystem.CreateDirectory(variables_0.DirectorioBackupTokens);
					goto IL_0068;
				}
				if (bool_0)
				{
					goto IL_0068;
				}
				goto end_IL_0036;
				IL_0068:
				string text3 = string.Empty;
				string text4 = string.Empty;
				string text5 = string.Empty;
				string text6 = string.Empty;
				FileLogger logger = variables_0.Logger;
				string message = "Making tokens backup...";
				logger.LogMessage(ref message);
				message = "sppsvc";
				bool bool_ = false;
				bool bool_2 = true;
				Class2.smethod_1(ref message, ref bool_, ref variables_0, ref bool_2);
				message = "osppsvc";
				bool_2 = false;
				bool_ = true;
				Class2.smethod_1(ref message, ref bool_2, ref variables_0, ref bool_);
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows8)
					{
						if (variables_0.IsServer)
						{
							text3 = Environment.GetEnvironmentVariable("SystemRoot") + "\\Sysnative\\spp\\store";
							text5 = Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
						}
						else
						{
							text3 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\spp\\store";
							text5 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
						}
						text4 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
						text6 = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Common Files\\Microsoft Shared\\OFFICE15\\Office Setup Controller\\pkeyconfig-office.xrm-ms";
					}
					else if (variables_0.IsWindows7)
					{
						text3 = Environment.GetEnvironmentVariable("SystemRoot") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform";
						text4 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
						text5 = ((!variables_0.IsServer) ? (Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms") : (Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms"));
						text6 = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Common Files\\Microsoft Shared\\OFFICE15\\Office Setup Controller\\pkeyconfig-office.xrm-ms";
					}
					else if (variables_0.IsWindowsVista)
					{
						text3 = Environment.GetEnvironmentVariable("SystemRoot") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareLicensing";
						text4 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
						text5 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\Licensingpkeyconfig\\pkeyconfig.xrm-ms";
					}
				}
				else
				{
					if (variables_0.IsServer)
					{
						text3 = Environment.GetEnvironmentVariable("SystemRoot") + "\\Sysnative\\spp\\store\\2.0";
						text5 = Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
					}
					else
					{
						text3 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\spp\\store\\2.0";
						text5 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
					}
					text4 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
					text6 = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Common Files\\Microsoft Shared\\OFFICE15\\Office Setup Controller\\pkeyconfig-office.xrm-ms";
				}
				FileLogger logger2 = variables_0.Logger;
				message = "Taking backup of: " + text3 + " " + text4;
				logger2.LogMessage(ref message);
				try
				{
					if (!string.IsNullOrEmpty(text3) && fileSystem.DirectoryExists(text3))
					{
						if (!fileSystem.DirectoryExists(text))
						{
							fileSystem.CreateDirectory(text);
						}
						fileSystem.CopyDirectory(text3, text);
					}
					if (!string.IsNullOrEmpty(text5) && fileSystem.FileExists(text5))
					{
						File.Copy(text5, text + "\\pkeyconfig.xrm-ms", true);
					}
					if (!string.IsNullOrEmpty(text4) && fileSystem.DirectoryExists(text4))
					{
						if (!fileSystem.DirectoryExists(text2))
						{
							fileSystem.CreateDirectory(text2);
						}
						fileSystem.CopyDirectory(text4, text2);
					}
					if (!string.IsNullOrEmpty(text6) && fileSystem.FileExists(text6))
					{
						if (!fileSystem.DirectoryExists(text2))
						{
							fileSystem.CreateDirectory(text2);
						}
						File.Copy(text6, text2 + "\\pkeyconfig-office.xrm-ms", true);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
					FileLogger logger3 = variables_0.Logger;
					message = "Error: " + str;
					logger3.LogMessage(ref message);
					ProjectData.ClearProjectError();
				}
				smethod_3(ref string_, ref variables_0);
				FileLogger logger4 = variables_0.Logger;
				message = "Backup made in: " + variables_0.DirectorioBackupTokens;
				logger4.LogMessage(ref message);
				Class3.smethod_24(ref variables_0, ref variables_0.AudioTransfer);
				fileSystem = null;
				end_IL_0036:;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger5 = variables_0.Logger;
				string message = "Error: " + str2;
				logger5.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}

		internal static void smethod_1(ref Variables variables_0)
		{
			string string_ = variables_0.DirectorioBackupTokens + "\\Windows";
			string text = variables_0.DirectorioBackupTokens + "\\Office";
			_ = variables_0.DirectorioBackupTokens + "\\Keys.txt";
			try
			{
				FileSystemProxy fileSystem = ((ServerComputer)Class79.smethod_0()).get_FileSystem();
				string string_2 = string.Empty;
				string string_3 = string.Empty;
				string string_4 = string.Empty;
				string string_5 = string.Empty;
				if (!variables_0.IsWindows10 && !variables_0.IsWindows81)
				{
					if (variables_0.IsWindows8)
					{
						if (variables_0.IsServer)
						{
							string_2 = Environment.GetEnvironmentVariable("SystemRoot") + "\\Sysnative\\spp\\store";
							string_4 = Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
						}
						else
						{
							string_2 = Environment.GetEnvironmentVariable("SystemRoot") + "\\System32\\spp\\store";
							string_4 = Environment.GetEnvironmentVariable("WinDir") + "\\System32\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
						}
						string_3 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
						string_5 = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Common Files\\Microsoft Shared\\OFFICE15\\Office Setup Controller\\pkeyconfig-office.xrm-ms";
					}
					else if (variables_0.IsWindows7)
					{
						string_2 = Environment.GetEnvironmentVariable("SystemRoot") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform";
						string_3 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
						string_4 = ((!variables_0.IsServer) ? (Environment.GetEnvironmentVariable("WinDir") + "\\System32\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms") : (Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms"));
						string_5 = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Common Files\\Microsoft Shared\\OFFICE15\\Office Setup Controller\\pkeyconfig-office.xrm-ms";
					}
					else if (variables_0.IsWindowsVista)
					{
						string_2 = Environment.GetEnvironmentVariable("SystemRoot") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareLicensing";
						string_4 = Environment.GetEnvironmentVariable("WinDir") + "\\System32\\Licensingpkeyconfig\\pkeyconfig.xrm-ms";
						string_3 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
					}
				}
				else
				{
					if (variables_0.IsServer)
					{
						string_2 = Environment.GetEnvironmentVariable("SystemRoot") + "\\Sysnative\\spp\\store\\2.0";
						string_4 = Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
					}
					else
					{
						string_2 = Environment.GetEnvironmentVariable("SystemRoot") + "\\System32\\spp\\store\\2.0";
						string_4 = Environment.GetEnvironmentVariable("WinDir") + "\\System32\\spp\\tokens\\pkeyconfig\\pkeyconfig.xrm-ms";
					}
					string_3 = Environment.GetEnvironmentVariable("SystemDrive") + "\\ProgramData\\Microsoft\\OfficeSoftwareProtectionPlatform";
					string_5 = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Common Files\\Microsoft Shared\\OFFICE15\\Office Setup Controller\\pkeyconfig-office.xrm-ms";
				}
				if (variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8 || variables_0.IsWindows7)
				{
					SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
					Class17.smethod_37(ref softwareLicensingService_, ref variables_0);
				}
				FileLogger logger = variables_0.Logger;
				string message = "Restoring tokens backup...";
				logger.LogMessage(ref message);
				message = "sppsvc";
				bool bool_ = false;
				bool bool_2 = true;
				Class2.smethod_1(ref message, ref bool_, ref variables_0, ref bool_2);
				message = "osppsvc";
				bool_2 = false;
				bool_ = true;
				Class2.smethod_1(ref message, ref bool_2, ref variables_0, ref bool_);
				FileLogger logger2 = variables_0.Logger;
				message = "Taking backup of: " + variables_0.DirectorioBackupTokens;
				logger2.LogMessage(ref message);
				if (!string.IsNullOrEmpty(string_2) && fileSystem.DirectoryExists(string_))
				{
					TakeOwner.smethod_0(ref string_2, ref variables_0);
					smethod_2(ref string_, ref string_2, ref variables_0);
					if (!string.IsNullOrEmpty(string_4) && fileSystem.FileExists(string_ + "\\pkeyconfig-office.xrm-ms"))
					{
						TakeOwner.smethod_1(ref string_4, ref variables_0);
						File.Copy(string_ + "\\pkeyconfig.xrm-ms", string_4, true);
					}
					FileLogger logger3 = variables_0.Logger;
					message = "Restore for Windows made in: " + string_2;
					logger3.LogMessage(ref message);
				}
				if (!string.IsNullOrEmpty(string_3) && fileSystem.DirectoryExists(text))
				{
					TakeOwner.smethod_0(ref string_3, ref variables_0);
					smethod_2(ref string_, ref string_3, ref variables_0);
					if (!string.IsNullOrEmpty(string_5) && fileSystem.FileExists(text + "\\pkeyconfig-office.xrm-ms"))
					{
						TakeOwner.smethod_1(ref string_5, ref variables_0);
						File.Copy(text + "\\pkeyconfig-office.xrm-ms", string_5, true);
					}
					FileLogger logger4 = variables_0.Logger;
					message = "Restore for Office made in: " + string_3;
					logger4.LogMessage(ref message);
				}
				Class3.smethod_24(ref variables_0, ref variables_0.AudioTransfer);
				variables_0.IsWindowsListo.Value = true;
				variables_0.IsOffice2013Listo.Value = true;
				variables_0.IsOffice2010Listo.Value = true;
				variables_0.IsGui = false;
				Class3.smethod_6(ref variables_0);
				fileSystem = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger5 = variables_0.Logger;
				string message = "Error: " + str;
				logger5.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}

		private static void smethod_2(ref string string_0, ref string string_1, ref Variables variables_0)
		{
			string oldValue = variables_0.DirectorioBackupTokens + "\\Windows";
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_1))
			{
				return;
			}
			try
			{
				ReadOnlyCollection<string> files = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)3, new string[1]
				{
					"*.dat"
				});
				foreach (string item in files)
				{
					try
					{
						string text = item.Replace(oldValue, string_1);
						if (File.Exists(text))
						{
							File.Delete(text);
						}
						File.Copy(item, text, true);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception exception_ = ex;
						string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
						FileLogger logger = variables_0.Logger;
						string message = "Error: " + str;
						logger.LogMessage(ref message);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger2 = variables_0.Logger;
				string message = "Error: " + str2;
				logger2.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
		}

		private static void smethod_3(ref string string_0, ref Variables variables_0)
		{
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			FileLogger logger = variables_0.Logger;
			string message = "Backuping Product Keys...";
			logger.LogMessage(ref message);
			try
			{
				if (File.Exists(string_0))
				{
					File.Delete(string_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger2 = variables_0.Logger;
				message = "Error: " + str;
				logger2.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			try
			{
				bool bool_ = true;
				bool bool_2 = false;
				ArrayList arrayList = Class10.smethod_12(ref bool_, ref bool_2, ref variables_0);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = arrayList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text = Conversions.ToString(enumerator.Current);
						File.AppendAllText(string_0, text + Environment.NewLine);
						FileLogger logger3 = variables_0.Logger;
						message = "Key Found: " + Class2.smethod_5(text);
						logger3.LogMessage(ref message);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (!variables_0.IsOffice2013PermanentActivate)
				{
					bool_2 = false;
					bool_ = true;
					arrayList = Class10.smethod_12(ref bool_2, ref bool_, ref variables_0);
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = arrayList.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text2 = Conversions.ToString(enumerator2.Current);
							File.AppendAllText(string_0, text2 + Environment.NewLine);
							FileLogger logger4 = variables_0.Logger;
							message = "Key Found: " + Class2.smethod_5(text2);
							logger4.LogMessage(ref message);
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				else if (variables_0.IsGui)
				{
					string text3 = string.Empty;
					int num = 0;
					while (string.IsNullOrEmpty(text3) && num < 2)
					{
						text3 = Interaction.InputBox("Enter your Office 2013 Key Activation" + Environment.NewLine + "example: XXXXX-XXXXX-XXXXX-XXXXX-" + variables_0.PartialPermanentOffice2013Key, "Office 2013 Jey Backup", "", -1, -1);
						if (text3.Length != 29)
						{
							text3 = string.Empty;
						}
						else if (!new Regex("^([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})-([A-Z1-9]{5})$").IsMatch(text3))
						{
							text3 = string.Empty;
						}
						num = checked(num + 1);
					}
					File.AppendAllText(string_0, "Office 2013: " + text3 + Environment.NewLine);
					FileLogger logger5 = variables_0.Logger;
					message = "Key entered: " + Class2.smethod_5(text3);
					logger5.LogMessage(ref message);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger6 = variables_0.Logger;
				message = "Error: " + str2;
				logger6.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			FileLogger logger7 = variables_0.Logger;
			message = "Product Keys Saved";
			logger7.LogMessage(ref message);
		}
	}
	public class Check
	{
		[CompilerGenerated]
		internal sealed class Class84
		{
			public Variables variables_0;

			internal void method_0()
			{
				smethod_2(ref variables_0);
			}

			internal void method_1()
			{
				smethod_3(ref variables_0);
			}

			internal void method_2()
			{
				smethod_4(ref variables_0);
			}

			internal void method_3()
			{
				smethod_6(ref variables_0);
			}
		}

		private const string string_0 = "Name: ";

		private const string string_1 = "Description: ";

		private const string string_2 = "Activation ID: ";

		private const string string_3 = "Application ID: ";

		private const string string_4 = "Extended PID: ";

		private const string string_5 = "Partial Product Key: ";

		private const int int_0 = -1073418231;

		private const int int_1 = -1073417728;

		private const string string_6 = "License Status: Unlicensed";

		private const string string_7 = "License Status: Licensed";

		private const string string_8 = "Volume activation expiration: %MINUTE% minute(s) (%DAY% day(s))";

		private const string string_9 = "Timebased activation expiration: %MINUTE% minute(s) (%DAY% day(s))";

		private const string string_10 = "License Status: Initial grace period";

		private const string string_11 = "License Status: Additional grace period (KMS license expired or hardware out of tolerance)";

		private const string string_12 = "License Status: Non-genuine grace period.";

		private const string string_13 = "License Status: Notification";

		private const string string_14 = "License Status: Extended grace period";

		private const string string_15 = "Time remaining: %MINUTE% minute(s) (%DAY% day(s))";

		private const string string_16 = "Notification Reason: 0x%ERRCODE% (non-genuine).";

		private const string string_17 = "Notification Reason: 0x%ERRCODE% (grace time expired).";

		private const string string_18 = "Notification Reason: 0x%ERRCODE%.";

		private const string string_19 = "License Status: Unknown";

		private const string string_20 = "Evaluation End Date: ";

		private const string string_21 = "Configured Activation Type: All";

		private const string string_22 = "Configured Activation Type: AD";

		private const string string_23 = "Configured Activation Type: KMS";

		private const string string_24 = "Configured Activation Type: Token";

		private const string string_25 = "Please use slmgr.vbs /ato to activate and update KMS client information in order to update values.";

		private const string string_26 = "Activating %PRODUCTNAME%";

		private const string string_27 = "Error: product not found.";

		private const string string_28 = "This system is configured for Token-based activation only. Use slmgr.vbs /fta to initiate Token-based activation, or slmgr.vbs /act-type to change the activation type setting.";

		private const string string_29 = "Product activated successfully.";

		private const string string_30 = "Error: Product activation failed.";

		private const string string_31 = "The machine is running within the non-genuine grace period. Run 'slui.exe' to go online and make the machine genuine.";

		private const string string_32 = "Windows is running within the non-genuine notification period. Run 'slui.exe' to go online and validate Windows.";

		private const string string_33 = "Error: ";

		internal static void smethod_0(ref Variables variables_0)
		{
			string text = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\sppsvc";
			Class10.smethod_5(ref text, ref variables_0);
			text = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\osppsvc";
			Class10.smethod_5(ref text, ref variables_0);
		}

		internal static void smethod_1(ref Variables variables_0)
		{
			Variables variables_ = variables_0;
			new Thread((ThreadStart)delegate
			{
				smethod_2(ref variables_);
			}).Start();
			new Thread((ThreadStart)delegate
			{
				smethod_3(ref variables_);
			}).Start();
			new Thread((ThreadStart)delegate
			{
				smethod_4(ref variables_);
			}).Start();
			new Thread((ThreadStart)delegate
			{
				smethod_6(ref variables_);
			}).Start();
			Class3.smethod_24(ref variables_0, ref variables_0.AudioDiagnostic);
		}

		internal static void smethod_2(ref Variables variables_0)
		{
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Invalid comparison between Unknown and I4
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Invalid comparison between Unknown and I4
			variables_0.IsWindowsActivable.Value = false;
			checked
			{
				variables_0.IntentosCheckWindows++;
				Class3.smethod_24(ref variables_0, ref variables_0.AudioProcessing);
			}
			string message;
			if (!variables_0.IsWindowsXP)
			{
				try
				{
					if (variables_0.IntentosCheckWindows <= 1 && new Class8().method_0(ref variables_0))
					{
						FileLogger logger = variables_0.Logger;
						message = "OEM Key Found: Version Windows Skipped";
						logger.LogMessage(ref message);
						FileLogger logger2 = variables_0.Logger;
						message = "OEM Activation needs Internet Connection";
						logger2.LogMessage(ref message);
						variables_0.IsWindowsActivable.Value = false;
						variables_0.IsWindowsListo.Value = true;
						variables_0.IsWindowsChecked.Value = true;
						Class3.smethod_6(ref variables_0);
						return;
					}
					if (variables_0.IntentosCheckWindows < 5 && variables_0.EditionID != null)
					{
						bool bool_ = true;
						bool bool_2 = false;
						bool bool_3 = false;
						bool bool_4 = false;
						Class17.smethod_46(ref variables_0, ref bool_, ref bool_2, ref bool_3, ref bool_4);
						if (variables_0.ColeccionWindows.Count > 0)
						{
							FileLogger logger3 = variables_0.Logger;
							message = "Found Windows Products: " + Conversions.ToString(variables_0.ColeccionWindows.Count);
							logger3.LogMessage(ref message);
							SoftwareLicensingProduct softwareLicensingProduct_ = variables_0.ColeccionWindows[0];
							smethod_11(ref softwareLicensingProduct_, ref variables_0);
							if (Class17.smethod_27(softwareLicensingProduct_.Description))
							{
								variables_0.IsWindowsActivable.Value = true;
								Class3.smethod_27(ref variables_0.ColeccionWindowsActivable, ref softwareLicensingProduct_);
							}
							else if (!Class17.smethod_29(softwareLicensingProduct_.Description) && !Class17.smethod_30(softwareLicensingProduct_.Description))
							{
								if (Class17.smethod_31(softwareLicensingProduct_.Description))
								{
									string message2 = softwareLicensingProduct_.Name + ": is Evaluation Version. You must upgrade to Full Version";
									variables_0.Logger.LogMessage(ref message2);
									if (variables_0.IsGui)
									{
										variables_0.ShowMessage.Show(message2, "Not Supported by KMS", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
									}
								}
								else if (Class17.smethod_28(softwareLicensingProduct_.Description) && (long)softwareLicensingProduct_.LicenseStatus != 1L)
								{
									if ((long)softwareLicensingProduct_.LicenseStatus != 2L && (long)softwareLicensingProduct_.LicenseStatus != 3L && (long)softwareLicensingProduct_.LicenseStatus != 4L)
									{
										string message3 = "This " + softwareLicensingProduct_.Name + " has a OEM KEY, if you wish activate it with KMS, then install a GVLK KEY";
										variables_0.Logger.LogMessage(ref message3);
										if (variables_0.IsGui)
										{
											variables_0.ShowMessage.Show(message3, "Not Supported by KMS", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
										}
										message3 = softwareLicensingProduct_.Name + ". (OEM) --> VL  ?";
										variables_0.Logger.LogMessage(ref message3);
										if (variables_0.IsGui && (int)variables_0.ShowMessage.Show(message3, "Convert OEM Key", IFrmShowMessage.enumMessageIcon.Question, IFrmShowMessage.enumMessageButton.YesNo, variables_0.iactivateMetroForm_0) == 6)
										{
											BooleanEvent isWindowsActivable = variables_0.IsWindowsActivable;
											bool_4 = isWindowsActivable.Value;
											RT2VL.smethod_8(ref bool_4, softwareLicensingProduct_, ref variables_0);
											isWindowsActivable.Value = bool_4;
										}
									}
									else
									{
										BooleanEvent isWindowsActivable2 = variables_0.IsWindowsActivable;
										bool_4 = isWindowsActivable2.Value;
										RT2VL.smethod_8(ref bool_4, softwareLicensingProduct_, ref variables_0);
										isWindowsActivable2.Value = bool_4;
									}
								}
							}
							else if ((long)softwareLicensingProduct_.LicenseStatus != 1L)
							{
								if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
								{
									BooleanEvent isWindowsActivable3 = variables_0.IsWindowsActivable;
									bool_4 = isWindowsActivable3.Value;
									RT2VL.smethod_8(ref bool_4, softwareLicensingProduct_, ref variables_0);
									isWindowsActivable3.Value = bool_4;
								}
								else if ((long)softwareLicensingProduct_.LicenseStatus != 2L && (long)softwareLicensingProduct_.LicenseStatus != 3L && (long)softwareLicensingProduct_.LicenseStatus != 4L)
								{
									if ((long)softwareLicensingProduct_.GracePeriodRemaining >= 0L && (long)softwareLicensingProduct_.GenuineStatus == 1L)
									{
										BooleanEvent isWindowsActivable4 = variables_0.IsWindowsActivable;
										bool_4 = isWindowsActivable4.Value;
										RT2VL.smethod_8(ref bool_4, softwareLicensingProduct_, ref variables_0);
										isWindowsActivable4.Value = bool_4;
									}
									else if ((long)softwareLicensingProduct_.GracePeriodRemaining >= 1L && (long)softwareLicensingProduct_.GenuineStatus == 0L)
									{
										BooleanEvent isWindowsActivable5 = variables_0.IsWindowsActivable;
										bool_4 = isWindowsActivable5.Value;
										RT2VL.smethod_8(ref bool_4, softwareLicensingProduct_, ref variables_0);
										isWindowsActivable5.Value = bool_4;
									}
									else
									{
										string message4 = "This " + softwareLicensingProduct_.Name + " has a RETAIL/MAK KEY, if you wish activate it with KMS, then install a GVLK KEY";
										variables_0.Logger.LogMessage(ref message4);
										if (variables_0.IsGui)
										{
											variables_0.ShowMessage.Show(message4, "Not Supported by KMS", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
										}
										message4 = softwareLicensingProduct_.Name + ". (RETAIL/MAK) --> VL  ?";
										variables_0.Logger.LogMessage(ref message4);
										if (variables_0.IsGui && (int)variables_0.ShowMessage.Show(message4, "Convert RETAIL/MAK Key", IFrmShowMessage.enumMessageIcon.Question, IFrmShowMessage.enumMessageButton.YesNo, variables_0.iactivateMetroForm_0) == 6)
										{
											BooleanEvent isWindowsActivable6 = variables_0.IsWindowsActivable;
											bool_4 = isWindowsActivable6.Value;
											RT2VL.smethod_8(ref bool_4, softwareLicensingProduct_, ref variables_0);
											isWindowsActivable6.Value = bool_4;
										}
									}
								}
								else
								{
									BooleanEvent isWindowsActivable7 = variables_0.IsWindowsActivable;
									bool_4 = isWindowsActivable7.Value;
									RT2VL.smethod_8(ref bool_4, softwareLicensingProduct_, ref variables_0);
									isWindowsActivable7.Value = bool_4;
								}
							}
							else
							{
								variables_0.IsWindowsPermanentActivate = true;
							}
						}
						else if (variables_0.ColeccionWindows.Count == 0 && !variables_0.IsWindowsXP && (variables_0.EditionID.Contains("Core") || variables_0.EditionID.Contains("Professional") || variables_0.EditionID.Contains("Enterprise") || variables_0.EditionID.Contains("Education") || variables_0.EditionID.Contains("Essentials") || variables_0.EditionID.Contains("Embedded") || variables_0.EditionID.Contains("Standard") || variables_0.EditionID.Contains("Datacenter") || variables_0.EditionID.Contains("HI") || variables_0.EditionID.Contains("Solution") || variables_0.EditionID.Contains("CloudStorage") || variables_0.EditionID.Contains("Country") || variables_0.EditionID.Contains("Premium") || variables_0.EditionID.Contains("HPC") || variables_0.EditionID.Contains("Business") || variables_0.EditionID.Contains("Web")))
						{
							message = "Windows " + variables_0.EditionID;
							Key.smethod_12(ref message, ref variables_0);
							smethod_2(ref variables_0);
						}
						if (variables_0.ColeccionWindowsActivable.Count > 0 && variables_0.IsWindowsActivable.Value && variables_0.ColeccionWindowsActivable.Count > 0)
						{
							Class3.smethod_24(ref variables_0, ref variables_0.AudioInputOk);
							bool_4 = true;
							Class10.smethod_7(ref bool_4, ref variables_0);
							variables_0.IsWindowsChecked.Value = true;
							Activador.smethod_0(ref variables_0);
							return;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
					FileLogger logger4 = variables_0.Logger;
					message = "Error: " + str;
					logger4.LogMessage(ref message);
					ProjectData.ClearProjectError();
				}
			}
			FileLogger logger5 = variables_0.Logger;
			message = "Version Windows Skipped";
			logger5.LogMessage(ref message);
			variables_0.IsWindowsActivable.Value = false;
			variables_0.IsWindowsListo.Value = true;
			variables_0.IsWindowsChecked.Value = true;
			Class3.smethod_6(ref variables_0);
		}

		internal static void smethod_3(ref Variables variables_0)
		{
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Invalid comparison between Unknown and I4
			variables_0.IsOffice2016Activable.Value = false;
			int num;
			bool bool_;
			bool bool_2;
			bool bool_3;
			bool bool_4;
			checked
			{
				variables_0.IntentosCheckOffice2016++;
				num = 0;
				bool_ = true;
				bool_2 = false;
				bool_3 = false;
				bool_4 = false;
				Class3.smethod_24(ref variables_0, ref variables_0.AudioProcessing);
			}
			string message;
			try
			{
				if (variables_0.IntentosCheckOffice2016 < 10)
				{
					smethod_8(ref variables_0);
					if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Conversions.ToString(variables_0.RutaOffice2016)))
					{
						FileLogger logger = variables_0.Logger;
						message = Conversions.ToString(Operators.ConcatenateObject((object)"Office 2016 Found: ", variables_0.RutaOffice2016));
						logger.LogMessage(ref message);
						Class17.smethod_46(ref variables_0, ref bool_4, ref bool_3, ref bool_2, ref bool_);
						if (variables_0.ColeccionOffice2016W8.Count <= 0 && variables_0.ColeccionOffice2016W7.Count <= 0)
						{
							if (variables_0.ColeccionOffice2016W8.Count == 0 && variables_0.ColeccionOffice2016W7.Count == 0)
							{
								string message2 = "Error: You need Reinstall Office 2016 or Open It the firts time";
								variables_0.Logger.LogMessage(ref message2);
								if (variables_0.IsGui)
								{
									variables_0.ShowMessage.Show(message2, "KEY no found", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
								}
								message2 = "Office 2016. (non KEY) --> ProPlus KEY ?";
								variables_0.Logger.LogMessage(ref message2);
								if (variables_0.IsGui)
								{
									if ((int)variables_0.ShowMessage.Show(message2, "Install KEY", IFrmShowMessage.enumMessageIcon.Question, IFrmShowMessage.enumMessageButton.YesNo, variables_0.iactivateMetroForm_0) == 6)
									{
										message = "Office 16, Office16ProPlus";
										RT2VL.smethod_15(ref message, ref variables_0);
									}
								}
								else
								{
									message = "Office 16, Office16ProPlus";
									RT2VL.smethod_15(ref message, ref variables_0);
								}
							}
						}
						else
						{
							if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
							{
								if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
								{
									FileLogger logger2 = variables_0.Logger;
									message = "Found Office 2016 Products: " + Conversions.ToString(variables_0.ColeccionOffice2016W7.Count);
									logger2.LogMessage(ref message);
									foreach (OfficeSoftwareProtectionProduct item in variables_0.ColeccionOffice2016W7)
									{
										OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_ = item;
										smethod_12(ref officeSoftwareProtectionProduct_, ref variables_0);
										if (Class17.smethod_27(officeSoftwareProtectionProduct_.Description))
										{
											variables_0.IsOffice2016Activable.Value = true;
											Class3.smethod_28(ref variables_0.ColeccionOffice2016ActivableW7, ref officeSoftwareProtectionProduct_);
										}
										else if (!Class17.smethod_29(officeSoftwareProtectionProduct_.Description) && !Class17.smethod_30(officeSoftwareProtectionProduct_.Description))
										{
											if (Class17.smethod_31(officeSoftwareProtectionProduct_.Description))
											{
												string message3 = officeSoftwareProtectionProduct_.Name + ": is Evaluation Version. You must upgrade to Full Version";
												variables_0.Logger.LogMessage(ref message3);
												num = checked(num + 1);
												if (officeSoftwareProtectionProduct_.Name.Contains("Grace") || officeSoftwareProtectionProduct_.Name.Contains("Trial") || officeSoftwareProtectionProduct_.Name.Contains("Demo"))
												{
													BooleanEvent isOffice2016Activable = variables_0.IsOffice2016Activable;
													bool bool_5 = isOffice2016Activable.Value;
													RT2VL.smethod_6(ref bool_5, ref officeSoftwareProtectionProduct_, ref bool_, ref bool_2, ref bool_3, ref variables_0.ColeccionRetailOffice2016W7, ref variables_0);
													isOffice2016Activable.Value = bool_5;
												}
											}
										}
										else if ((long)officeSoftwareProtectionProduct_.LicenseStatus != 1L)
										{
											BooleanEvent isOffice2016Activable2 = variables_0.IsOffice2016Activable;
											bool bool_5 = isOffice2016Activable2.Value;
											RT2VL.smethod_6(ref bool_5, ref officeSoftwareProtectionProduct_, ref bool_, ref bool_2, ref bool_3, ref variables_0.ColeccionRetailOffice2016W7, ref variables_0);
											isOffice2016Activable2.Value = bool_5;
										}
										else
										{
											variables_0.PartialPermanentOffice2016Key = officeSoftwareProtectionProduct_.PartialProductKey;
											variables_0.IsOffice2016PermanentActivate = true;
										}
									}
								}
							}
							else
							{
								FileLogger logger3 = variables_0.Logger;
								message = "Found Office 2016 Products: " + Conversions.ToString(variables_0.ColeccionOffice2016W8.Count);
								logger3.LogMessage(ref message);
								foreach (SoftwareLicensingProduct item2 in variables_0.ColeccionOffice2016W8)
								{
									SoftwareLicensingProduct softwareLicensingProduct_ = item2;
									smethod_11(ref softwareLicensingProduct_, ref variables_0);
									if (Class17.smethod_27(softwareLicensingProduct_.Description))
									{
										variables_0.IsOffice2016Activable.Value = true;
										Class3.smethod_27(ref variables_0.ColeccionOffice2016ActivableW8, ref softwareLicensingProduct_);
									}
									else if (!Class17.smethod_29(softwareLicensingProduct_.Description) && !Class17.smethod_30(softwareLicensingProduct_.Description))
									{
										if (Class17.smethod_31(softwareLicensingProduct_.Description))
										{
											string message4 = softwareLicensingProduct_.Name + ": is Evaluation Version. You must upgrade to Full Version";
											variables_0.Logger.LogMessage(ref message4);
											num = checked(num + 1);
											if (softwareLicensingProduct_.Name.Contains("Grace") || softwareLicensingProduct_.Name.Contains("Trial") || softwareLicensingProduct_.Name.Contains("Demo"))
											{
												ref List<SoftwareLicensingProduct> coleccionRetailOffice2016W = ref variables_0.ColeccionRetailOffice2016W8;
												BooleanEvent isOffice2016Activable3;
												bool bool_5 = (isOffice2016Activable3 = variables_0.IsOffice2016Activable).Value;
												smethod_5(ref softwareLicensingProduct_, ref coleccionRetailOffice2016W, ref bool_5, bool_, bool_2, variables_0);
												isOffice2016Activable3.Value = bool_5;
											}
										}
									}
									else if ((long)softwareLicensingProduct_.LicenseStatus != 1L)
									{
										ref List<SoftwareLicensingProduct> coleccionRetailOffice2016W2 = ref variables_0.ColeccionRetailOffice2016W8;
										BooleanEvent isOffice2016Activable3;
										bool bool_5 = (isOffice2016Activable3 = variables_0.IsOffice2016Activable).Value;
										smethod_5(ref softwareLicensingProduct_, ref coleccionRetailOffice2016W2, ref bool_5, bool_, bool_2, variables_0);
										isOffice2016Activable3.Value = bool_5;
									}
									else
									{
										variables_0.PartialPermanentOffice2016Key = softwareLicensingProduct_.PartialProductKey;
										variables_0.IsOffice2016PermanentActivate = true;
									}
								}
							}
							if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
							{
								if ((variables_0.IsWindows7 || variables_0.IsWindowsVista) && variables_0.ColeccionRetailOffice2016W7.Count > 0 && variables_0.IntentosCheckOffice2016 < 7)
								{
									RT2VL.smethod_10(ref variables_0.ColeccionRetailOffice2016W7, ref variables_0);
								}
							}
							else if (variables_0.ColeccionRetailOffice2016W8.Count > 0 && variables_0.IntentosCheckOffice2016 < 7)
							{
								RT2VL.smethod_9(ref variables_0.ColeccionRetailOffice2016W8, ref variables_0);
							}
							if ((variables_0.ColeccionOffice2016ActivableW8.Count > 0 || variables_0.ColeccionOffice2016ActivableW7.Count > 0) && variables_0.IsOffice2016Activable.Value)
							{
								Class3.smethod_24(ref variables_0, ref variables_0.AudioInputOk);
								bool bool_5 = true;
								Class10.smethod_8(ref bool_5, ref variables_0);
								variables_0.IsOffice2016Checked.Value = true;
								Activador.smethod_0(ref variables_0);
								return;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger4 = variables_0.Logger;
				message = "Error: " + str;
				logger4.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			FileLogger logger5 = variables_0.Logger;
			message = "Office 2016 Skipped";
			logger5.LogMessage(ref message);
			variables_0.IsOffice2016Activable.Value = false;
			variables_0.IsOffice2016Listo.Value = true;
			variables_0.IsOffice2016Checked.Value = true;
			Class3.smethod_6(ref variables_0);
		}

		internal static void smethod_4(ref Variables variables_0)
		{
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Invalid comparison between Unknown and I4
			variables_0.IsOffice2013Activable.Value = false;
			int num;
			bool bool_;
			bool bool_2;
			bool bool_3;
			bool bool_4;
			checked
			{
				variables_0.IntentosCheckOffice2013++;
				num = 0;
				bool_ = false;
				bool_2 = true;
				bool_3 = false;
				bool_4 = false;
				Class3.smethod_24(ref variables_0, ref variables_0.AudioProcessing);
			}
			string message;
			try
			{
				if (variables_0.IntentosCheckOffice2013 < 10)
				{
					smethod_9(ref variables_0);
					if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Conversions.ToString(variables_0.RutaOffice2013)))
					{
						FileLogger logger = variables_0.Logger;
						message = Conversions.ToString(Operators.ConcatenateObject((object)"Office 2013 Found: ", variables_0.RutaOffice2013));
						logger.LogMessage(ref message);
						Class17.smethod_46(ref variables_0, ref bool_4, ref bool_3, ref bool_2, ref bool_);
						if (variables_0.ColeccionOffice2013W8.Count <= 0 && variables_0.ColeccionOffice2013W7.Count <= 0)
						{
							if (variables_0.ColeccionOffice2013W8.Count == 0 && variables_0.ColeccionOffice2013W7.Count == 0)
							{
								string message2 = "Error: You need Reinstall Office 2013 or Open It the firts time";
								variables_0.Logger.LogMessage(ref message2);
								if (variables_0.IsGui)
								{
									variables_0.ShowMessage.Show(message2, "KEY no found", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
								}
								message2 = "Office 2013. (non KEY) --> ProPlus KEY ?";
								variables_0.Logger.LogMessage(ref message2);
								if (variables_0.IsGui)
								{
									if ((int)variables_0.ShowMessage.Show(message2, "Install KEY", IFrmShowMessage.enumMessageIcon.Question, IFrmShowMessage.enumMessageButton.YesNo, variables_0.iactivateMetroForm_0) == 6)
									{
										message = "Office 15, OfficeProPlus";
										RT2VL.smethod_22(ref message, ref variables_0);
									}
								}
								else
								{
									message = "Office 15, OfficeProPlus";
									RT2VL.smethod_22(ref message, ref variables_0);
								}
							}
						}
						else
						{
							if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
							{
								if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
								{
									FileLogger logger2 = variables_0.Logger;
									message = "Found Office 2013 Products: " + Conversions.ToString(variables_0.ColeccionOffice2013W7.Count);
									logger2.LogMessage(ref message);
									foreach (OfficeSoftwareProtectionProduct item in variables_0.ColeccionOffice2013W7)
									{
										OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_ = item;
										smethod_12(ref officeSoftwareProtectionProduct_, ref variables_0);
										if (Class17.smethod_27(officeSoftwareProtectionProduct_.Description))
										{
											variables_0.IsOffice2013Activable.Value = true;
											Class3.smethod_28(ref variables_0.ColeccionOffice2013ActivableW7, ref officeSoftwareProtectionProduct_);
										}
										else if (!Class17.smethod_29(officeSoftwareProtectionProduct_.Description) && !Class17.smethod_30(officeSoftwareProtectionProduct_.Description))
										{
											if (Class17.smethod_31(officeSoftwareProtectionProduct_.Description))
											{
												string message3 = officeSoftwareProtectionProduct_.Name + ": is Evaluation Version. You must upgrade to Full Version";
												variables_0.Logger.LogMessage(ref message3);
												num = checked(num + 1);
												if (officeSoftwareProtectionProduct_.Name.Contains("Grace") || officeSoftwareProtectionProduct_.Name.Contains("Trial") || officeSoftwareProtectionProduct_.Name.Contains("Demo"))
												{
													BooleanEvent isOffice2013Activable = variables_0.IsOffice2013Activable;
													bool bool_5 = isOffice2013Activable.Value;
													RT2VL.smethod_6(ref bool_5, ref officeSoftwareProtectionProduct_, ref bool_, ref bool_2, ref bool_3, ref variables_0.ColeccionRetailOffice2013W7, ref variables_0);
													isOffice2013Activable.Value = bool_5;
												}
											}
										}
										else if ((long)officeSoftwareProtectionProduct_.LicenseStatus != 1L)
										{
											BooleanEvent isOffice2013Activable2 = variables_0.IsOffice2013Activable;
											bool bool_5 = isOffice2013Activable2.Value;
											RT2VL.smethod_6(ref bool_5, ref officeSoftwareProtectionProduct_, ref bool_, ref bool_2, ref bool_3, ref variables_0.ColeccionRetailOffice2013W7, ref variables_0);
											isOffice2013Activable2.Value = bool_5;
										}
										else
										{
											variables_0.PartialPermanentOffice2013Key = officeSoftwareProtectionProduct_.PartialProductKey;
											variables_0.IsOffice2013PermanentActivate = true;
										}
									}
								}
							}
							else
							{
								FileLogger logger3 = variables_0.Logger;
								message = "Found Office 2013 Products: " + Conversions.ToString(variables_0.ColeccionOffice2013W8.Count);
								logger3.LogMessage(ref message);
								foreach (SoftwareLicensingProduct item2 in variables_0.ColeccionOffice2013W8)
								{
									SoftwareLicensingProduct softwareLicensingProduct_ = item2;
									smethod_11(ref softwareLicensingProduct_, ref variables_0);
									if (Class17.smethod_27(softwareLicensingProduct_.Description))
									{
										variables_0.IsOffice2013Activable.Value = true;
										Class3.smethod_27(ref variables_0.ColeccionOffice2013ActivableW8, ref softwareLicensingProduct_);
									}
									else if (!Class17.smethod_29(softwareLicensingProduct_.Description) && !Class17.smethod_30(softwareLicensingProduct_.Description))
									{
										if (Class17.smethod_31(softwareLicensingProduct_.Description))
										{
											string message4 = softwareLicensingProduct_.Name + ": is Evaluation Version. You must upgrade to Full Version";
											variables_0.Logger.LogMessage(ref message4);
											num = checked(num + 1);
											if (softwareLicensingProduct_.Name.Contains("Grace") || softwareLicensingProduct_.Name.Contains("Trial") || softwareLicensingProduct_.Name.Contains("Demo"))
											{
												ref List<SoftwareLicensingProduct> coleccionRetailOffice2013W = ref variables_0.ColeccionRetailOffice2013W8;
												BooleanEvent isOffice2013Activable3;
												bool bool_5 = (isOffice2013Activable3 = variables_0.IsOffice2013Activable).Value;
												smethod_5(ref softwareLicensingProduct_, ref coleccionRetailOffice2013W, ref bool_5, bool_, bool_2, variables_0);
												isOffice2013Activable3.Value = bool_5;
											}
										}
									}
									else if ((long)softwareLicensingProduct_.LicenseStatus != 1L)
									{
										ref List<SoftwareLicensingProduct> coleccionRetailOffice2013W2 = ref variables_0.ColeccionRetailOffice2013W8;
										BooleanEvent isOffice2013Activable3;
										bool bool_5 = (isOffice2013Activable3 = variables_0.IsOffice2013Activable).Value;
										smethod_5(ref softwareLicensingProduct_, ref coleccionRetailOffice2013W2, ref bool_5, bool_, bool_2, variables_0);
										isOffice2013Activable3.Value = bool_5;
									}
									else
									{
										variables_0.PartialPermanentOffice2013Key = softwareLicensingProduct_.PartialProductKey;
										variables_0.IsOffice2013PermanentActivate = true;
									}
								}
							}
							if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
							{
								if ((variables_0.IsWindows7 || variables_0.IsWindowsVista) && variables_0.ColeccionRetailOffice2013W7.Count > 0 && variables_0.IntentosCheckOffice2013 < 7)
								{
									RT2VL.smethod_17(ref variables_0.ColeccionRetailOffice2013W7, ref variables_0);
								}
							}
							else if (variables_0.ColeccionRetailOffice2013W8.Count > 0 && variables_0.IntentosCheckOffice2013 < 7)
							{
								RT2VL.smethod_16(ref variables_0.ColeccionRetailOffice2013W8, ref variables_0);
							}
							if ((variables_0.ColeccionOffice2013ActivableW8.Count > 0 || variables_0.ColeccionOffice2013ActivableW7.Count > 0) && variables_0.IsOffice2013Activable.Value)
							{
								Class3.smethod_24(ref variables_0, ref variables_0.AudioInputOk);
								bool bool_5 = true;
								Class10.smethod_9(ref bool_5, ref variables_0);
								variables_0.IsOffice2013Checked.Value = true;
								Activador.smethod_0(ref variables_0);
								return;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger4 = variables_0.Logger;
				message = "Error: " + str;
				logger4.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			FileLogger logger5 = variables_0.Logger;
			message = "Office 2013 Skipped";
			logger5.LogMessage(ref message);
			variables_0.IsOffice2013Activable.Value = false;
			variables_0.IsOffice2013Listo.Value = true;
			variables_0.IsOffice2013Checked.Value = true;
			Class3.smethod_6(ref variables_0);
		}

		private static void smethod_5(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref List<SoftwareLicensingProduct> list_0, ref bool bool_0, bool bool_1, bool bool_2, Variables variables_0)
		{
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Invalid comparison between Unknown and I4
			if (!softwareLicensingProduct_0.Name.Contains("Grace") && !softwareLicensingProduct_0.Name.Contains("Trial") && !softwareLicensingProduct_0.Name.Contains("Demo"))
			{
				if ((long)softwareLicensingProduct_0.LicenseStatus != 2L && (long)softwareLicensingProduct_0.LicenseStatus != 3L && (long)softwareLicensingProduct_0.LicenseStatus != 4L)
				{
					if ((long)softwareLicensingProduct_0.GracePeriodRemaining >= 0L && (long)softwareLicensingProduct_0.GenuineStatus == 1L)
					{
						RT2VL.smethod_7(ref bool_0, softwareLicensingProduct_0, ref bool_1, ref bool_2, ref list_0, ref variables_0);
						return;
					}
					if ((long)softwareLicensingProduct_0.GracePeriodRemaining >= 1L && (long)softwareLicensingProduct_0.GenuineStatus == 0L)
					{
						RT2VL.smethod_7(ref bool_0, softwareLicensingProduct_0, ref bool_1, ref bool_2, ref list_0, ref variables_0);
						return;
					}
					string message = "This " + softwareLicensingProduct_0.Name + " has a RETAIL/MAK KEY, if you wish activate it with KMS, then install a GVLK KEY";
					variables_0.Logger.LogMessage(ref message);
					if (variables_0.IsGui)
					{
						variables_0.ShowMessage.Show(message, "Not Supported by KMS", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
					}
					message = softwareLicensingProduct_0.Name + ". (RETAIL/MAK) --> VL  ?";
					variables_0.Logger.LogMessage(ref message);
					if (variables_0.IsGui && (int)variables_0.ShowMessage.Show(message, "Convert RETAIL/MAK Key", IFrmShowMessage.enumMessageIcon.Question, IFrmShowMessage.enumMessageButton.YesNo, variables_0.iactivateMetroForm_0) == 6)
					{
						RT2VL.smethod_7(ref bool_0, softwareLicensingProduct_0, ref bool_1, ref bool_2, ref list_0, ref variables_0);
					}
				}
				else
				{
					RT2VL.smethod_7(ref bool_0, softwareLicensingProduct_0, ref bool_1, ref bool_2, ref list_0, ref variables_0);
				}
			}
			else
			{
				RT2VL.smethod_7(ref bool_0, softwareLicensingProduct_0, ref bool_1, ref bool_2, ref list_0, ref variables_0);
			}
		}

		internal static void smethod_6(ref Variables variables_0)
		{
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Invalid comparison between Unknown and I4
			variables_0.IsOffice2010Activable.Value = false;
			int num;
			bool bool_;
			bool bool_2;
			bool bool_3;
			bool bool_4;
			checked
			{
				variables_0.IntentosCheckOffice2010++;
				num = 0;
				bool_ = false;
				bool_2 = false;
				bool_3 = true;
				bool_4 = false;
				Class3.smethod_24(ref variables_0, ref variables_0.AudioProcessing);
			}
			string message;
			try
			{
				if (variables_0.IntentosCheckOffice2010 < 10)
				{
					smethod_10(ref variables_0);
					if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Conversions.ToString(variables_0.RutaOffice2010)))
					{
						FileLogger logger = variables_0.Logger;
						message = Conversions.ToString(Operators.ConcatenateObject((object)"Office 2010 Found: ", variables_0.RutaOffice2010));
						logger.LogMessage(ref message);
						Class17.smethod_46(ref variables_0, ref bool_4, ref bool_3, ref bool_2, ref bool_);
						if (variables_0.ColeccionOffice2010.Count > 0)
						{
							FileLogger logger2 = variables_0.Logger;
							message = "Found Office 2010 Products: " + Conversions.ToString(variables_0.ColeccionOffice2010.Count);
							logger2.LogMessage(ref message);
							foreach (OfficeSoftwareProtectionProduct item in variables_0.ColeccionOffice2010)
							{
								OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_ = item;
								smethod_12(ref officeSoftwareProtectionProduct_, ref variables_0);
								if (Class17.smethod_27(officeSoftwareProtectionProduct_.Description))
								{
									variables_0.IsOffice2010Activable.Value = true;
									Class3.smethod_28(ref variables_0.ColeccionOffice2010Activable, ref officeSoftwareProtectionProduct_);
								}
								else if (!Class17.smethod_29(officeSoftwareProtectionProduct_.Description) && !Class17.smethod_30(officeSoftwareProtectionProduct_.Description))
								{
									if (Class17.smethod_31(officeSoftwareProtectionProduct_.Description))
									{
										string message2 = officeSoftwareProtectionProduct_.Name + ": is Evaluation Version. You must upgrade to Full Version";
										variables_0.Logger.LogMessage(ref message2);
										if (variables_0.IsGui)
										{
											variables_0.ShowMessage.Show(message2, "Not Supported by KMS", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
										}
										num = checked(num + 1);
										BooleanEvent isOffice2010Activable = variables_0.IsOffice2010Activable;
										bool bool_5 = isOffice2010Activable.Value;
										RT2VL.smethod_6(ref bool_5, ref officeSoftwareProtectionProduct_, ref bool_, ref bool_2, ref bool_3, ref variables_0.ColeccionRetailOffice2010, ref variables_0);
										isOffice2010Activable.Value = bool_5;
									}
								}
								else if ((long)officeSoftwareProtectionProduct_.LicenseStatus != 1L)
								{
									BooleanEvent isOffice2010Activable2 = variables_0.IsOffice2010Activable;
									bool bool_5 = isOffice2010Activable2.Value;
									RT2VL.smethod_6(ref bool_5, ref officeSoftwareProtectionProduct_, ref bool_, ref bool_2, ref bool_3, ref variables_0.ColeccionRetailOffice2010, ref variables_0);
									isOffice2010Activable2.Value = bool_5;
								}
							}
							if (variables_0.ColeccionRetailOffice2010.Count > 0 && variables_0.ColeccionRetailOffice2010.Count > 0 && variables_0.IntentosCheckOffice2010 < 7)
							{
								bool bool_5 = true;
								Class10.smethod_6(ref bool_5, ref variables_0);
								RT2VL.smethod_23(ref variables_0.ColeccionRetailOffice2010, ref variables_0);
							}
							if (variables_0.ColeccionOffice2010Activable.Count > 0 && variables_0.IsOffice2010Activable.Value && variables_0.ColeccionOffice2010Activable.Count > 0)
							{
								Class3.smethod_24(ref variables_0, ref variables_0.AudioInputOk);
								bool bool_5 = true;
								Class10.smethod_6(ref bool_5, ref variables_0);
								variables_0.IsOffice2010Checked.Value = true;
								Activador.smethod_0(ref variables_0);
								return;
							}
						}
						else if (variables_0.ColeccionOffice2010.Count == 0)
						{
							string message3 = "Error: You need Reinstall Office 2010 or Open It the firts time";
							variables_0.Logger.LogMessage(ref message3);
							if (variables_0.IsGui)
							{
								variables_0.ShowMessage.Show(message3, "KEY no found", IFrmShowMessage.enumMessageIcon.Error, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
							}
							message3 = "Office 2010. (non KEY) --> ProPlus KEY ?";
							variables_0.Logger.LogMessage(ref message3);
							if (variables_0.IsGui)
							{
								if ((int)variables_0.ShowMessage.Show(message3, "Install KEY", IFrmShowMessage.enumMessageIcon.Question, IFrmShowMessage.enumMessageButton.YesNo, variables_0.iactivateMetroForm_0) == 6)
								{
									message = "Office 14, OfficeProPlus";
									RT2VL.smethod_25(ref message, ref variables_0);
								}
							}
							else
							{
								message = "Office 14, OfficeProPlus";
								RT2VL.smethod_25(ref message, ref variables_0);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger3 = variables_0.Logger;
				message = "Error: " + str;
				logger3.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			FileLogger logger4 = variables_0.Logger;
			message = "Office 2010 Skipped";
			logger4.LogMessage(ref message);
			variables_0.IsOffice2010Activable.Value = false;
			variables_0.IsOffice2010Listo.Value = true;
			variables_0.IsOffice2010Checked.Value = true;
			Class3.smethod_6(ref variables_0);
		}

		internal static void smethod_7(ref Variables variables_0)
		{
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			ArrayList arrayList = new ArrayList();
			StringBuilder stringBuilder = new StringBuilder();
			Class3.smethod_24(ref variables_0, ref variables_0.AudioProcessing);
			if (!variables_0.IsWindowsXP)
			{
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				Class17.smethod_36(ref softwareLicensingService_, ref variables_0);
			}
			string text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			variables_0.EditionID = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "EditionID", (object)null));
			variables_0.ProductName = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "ProductName", (object)null));
			variables_0.CurrentVersion = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "CurrentVersion", (object)null));
			variables_0.CurrentBuild = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "CurrentBuild", (object)null));
			string text2 = Conversions.ToString(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "BuildLabEx", (object)null));
			string[] array = text2.Split(new char[1]
			{
				'.'
			});
			text2 = Enumerable.ElementAt<string>((IEnumerable<string>)array, 0) + "." + Enumerable.ElementAt<string>((IEnumerable<string>)array, 1);
			stringBuilder.AppendLine("Windows Detected: " + variables_0.ProductName + " : " + variables_0.EditionID + " : " + variables_0.CurrentVersion + " : " + text2);
			stringBuilder.AppendLine(string.Empty);
			bool bool_3;
			bool bool_2;
			bool bool_;
			if (!variables_0.IsWindowsXP)
			{
				List<SoftwareLicensingProduct> list_ = Class17.smethod_17(ref variables_0);
				bool_ = true;
				bool_2 = false;
				bool_3 = false;
				arrayList.AddRange(Class17.smethod_25(ref list_, ref bool_, ref bool_2, ref bool_3, ref variables_0));
			}
			bool bool_4;
			List<OfficeSoftwareProtectionProduct> list_2;
			if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
			{
				if (variables_0.IsWindows7)
				{
					bool_4 = false;
					list_2 = Class17.smethod_19(ref variables_0, ref bool_4);
					bool_3 = false;
					bool_2 = false;
					bool_ = true;
					arrayList.AddRange(Class17.smethod_26(ref list_2, ref bool_3, ref bool_2, ref bool_, ref variables_0));
					bool_4 = false;
					list_2 = Class17.smethod_19(ref variables_0, ref bool_4);
					bool_ = false;
					bool_2 = true;
					bool_3 = false;
					arrayList.AddRange(Class17.smethod_26(ref list_2, ref bool_, ref bool_2, ref bool_3, ref variables_0));
				}
			}
			else
			{
				List<SoftwareLicensingProduct> list_ = Class17.smethod_17(ref variables_0);
				bool_3 = false;
				bool_2 = false;
				bool_ = true;
				arrayList.AddRange(Class17.smethod_25(ref list_, ref bool_3, ref bool_2, ref bool_, ref variables_0));
				list_ = Class17.smethod_17(ref variables_0);
				bool_ = false;
				bool_2 = true;
				bool_3 = false;
				arrayList.AddRange(Class17.smethod_25(ref list_, ref bool_, ref bool_2, ref bool_3, ref variables_0));
			}
			bool_4 = true;
			list_2 = Class17.smethod_19(ref variables_0, ref bool_4);
			bool_3 = true;
			bool_2 = false;
			bool_ = false;
			arrayList.AddRange(Class17.smethod_26(ref list_2, ref bool_3, ref bool_2, ref bool_, ref variables_0));
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct = new OfficeSoftwareProtectionProduct();
					SoftwareLicensingProduct softwareLicensingProduct = new SoftwareLicensingProduct();
					if (objectValue.GetType() == ((object)officeSoftwareProtectionProduct).GetType())
					{
						officeSoftwareProtectionProduct = (OfficeSoftwareProtectionProduct)objectValue;
						stringBuilder.AppendLine("Name: " + officeSoftwareProtectionProduct.Name);
						stringBuilder.AppendLine("Description: " + officeSoftwareProtectionProduct.Description);
						stringBuilder.AppendLine(smethod_15(officeSoftwareProtectionProduct));
						stringBuilder.AppendLine("LicenseStatus: " + smethod_16(officeSoftwareProtectionProduct.LicenseStatus));
						stringBuilder.AppendLine("PartialProductKey: " + officeSoftwareProtectionProduct.PartialProductKey);
					}
					else if (objectValue.GetType() == ((object)softwareLicensingProduct).GetType())
					{
						softwareLicensingProduct = (SoftwareLicensingProduct)objectValue;
						stringBuilder.AppendLine("Name: " + softwareLicensingProduct.Name);
						stringBuilder.AppendLine("Description: " + softwareLicensingProduct.Description);
						stringBuilder.AppendLine(smethod_14(ref softwareLicensingProduct));
						stringBuilder.AppendLine("LicenseStatus: " + smethod_16(softwareLicensingProduct.LicenseStatus));
						stringBuilder.AppendLine("PartialProductKey: " + softwareLicensingProduct.PartialProductKey);
						if (variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8)
						{
							stringBuilder.AppendLine("GenuineStatus: " + smethod_17(softwareLicensingProduct.GenuineStatus));
						}
					}
					stringBuilder.AppendLine(string.Empty);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			variables_0.ShowMessage.Show(stringBuilder.ToString(), "Status Info", IFrmShowMessage.enumMessageIcon.Information, IFrmShowMessage.enumMessageButton.OK, variables_0.iactivateMetroForm_0);
		}

		private static void smethod_8(ref Variables variables_0)
		{
			string text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Office\\16.0\\Common\\InstallRoot";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null) != null)
			{
				variables_0.RutaOffice2016 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null));
				return;
			}
			text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Office\\16.0\\Common\\InstallRoot";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null) != null)
			{
				variables_0.RutaOffice2016 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null));
				return;
			}
			text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Office\\16.0\\ClickToRunStore\\Applications";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "", (object)null) != null)
			{
				variables_0.RutaOffice2016 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "", (object)null));
				return;
			}
			text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Office\\16.0\\ClickToRunStore\\Applications";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "", (object)null) != null)
			{
				variables_0.RutaOffice2016 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "", (object)null));
				return;
			}
			variables_0.RutaOffice2016 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Microsoft Office\\Office16";
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Conversions.ToString(variables_0.RutaOffice2016)))
			{
				variables_0.RutaOffice2016 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft Office\\Office16";
			}
		}

		private static void smethod_9(ref Variables variables_0)
		{
			string text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Office\\15.0\\Common\\InstallRoot";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null) != null)
			{
				variables_0.RutaOffice2013 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null));
				return;
			}
			text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Office\\15.0\\Common\\InstallRoot";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null) != null)
			{
				variables_0.RutaOffice2013 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null));
				return;
			}
			text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Office\\15.0\\ClickToRun";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "InstallPath", (object)null) != null)
			{
				variables_0.RutaOffice2013 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "InstallPath", (object)null));
				return;
			}
			text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Office\\15.0\\ClickToRun";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "InstallPath", (object)null) != null)
			{
				variables_0.RutaOffice2013 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "InstallPath", (object)null));
				return;
			}
			variables_0.RutaOffice2013 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Microsoft Office\\Office15";
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Conversions.ToString(variables_0.RutaOffice2013)))
			{
				variables_0.RutaOffice2013 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft Office\\Office15";
			}
		}

		private static void smethod_10(ref Variables variables_0)
		{
			string text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Office\\14.0\\Common\\InstallRoot";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null) != null)
			{
				variables_0.RutaOffice2010 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null));
				return;
			}
			text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Office\\14.0\\Common\\InstallRoot";
			if (((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null) != null)
			{
				variables_0.RutaOffice2010 = RuntimeHelpers.GetObjectValue(((ServerComputer)Class79.smethod_0()).get_Registry().GetValue(text, "Path", (object)null));
				return;
			}
			variables_0.RutaOffice2010 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Microsoft Office\\Office14";
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Conversions.ToString(variables_0.RutaOffice2010)))
			{
				variables_0.RutaOffice2010 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft Office\\Office14";
			}
		}

		private static void smethod_11(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Name: " + softwareLicensingProduct_0.Name);
			stringBuilder.AppendLine("Description: " + softwareLicensingProduct_0.Description);
			stringBuilder.AppendLine("GracePeriodRemaining: " + Conversions.ToString(softwareLicensingProduct_0.GracePeriodRemaining));
			stringBuilder.AppendLine("LicenseStatus: " + Conversions.ToString(softwareLicensingProduct_0.LicenseStatus));
			stringBuilder.AppendLine("PartialProductKey: " + softwareLicensingProduct_0.PartialProductKey);
			if (variables_0.IsWindows10 || variables_0.IsWindows81 || variables_0.IsWindows8)
			{
				stringBuilder.AppendLine("GenuineStatus: " + Conversions.ToString(softwareLicensingProduct_0.GenuineStatus));
			}
			FileLogger logger = variables_0.Logger;
			string message = stringBuilder.ToString();
			logger.LogMessage(ref message);
		}

		private static void smethod_12(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Name: " + officeSoftwareProtectionProduct_0.Name);
			stringBuilder.AppendLine("Description: " + officeSoftwareProtectionProduct_0.Description);
			stringBuilder.AppendLine("GracePeriodRemaining: " + Conversions.ToString(officeSoftwareProtectionProduct_0.GracePeriodRemaining));
			stringBuilder.AppendLine("LicenseStatus: " + Conversions.ToString(officeSoftwareProtectionProduct_0.LicenseStatus));
			stringBuilder.AppendLine("PartialProductKey: " + officeSoftwareProtectionProduct_0.PartialProductKey);
			FileLogger logger = variables_0.Logger;
			string message = stringBuilder.ToString();
			logger.LogMessage(ref message);
		}

		private static uint smethod_13(uint uint_0)
		{
			object obj = 1440;
			return Conversions.ToUInteger(Conversion.Int(Operators.DivideObject(Operators.SubtractObject(Operators.AddObject((object)uint_0, obj), (object)1), obj)));
		}

		private static string smethod_14(ref SoftwareLicensingProduct softwareLicensingProduct_0)
		{
			uint gracePeriodRemaining = softwareLicensingProduct_0.GracePeriodRemaining;
			uint num = smethod_13(gracePeriodRemaining);
			bool flag = Class17.smethod_31(softwareLicensingProduct_0.Description);
			string empty = string.Empty;
			uint licenseStatus = softwareLicensingProduct_0.LicenseStatus;
			if ((long)licenseStatus == 0L)
			{
				return "License Status: Unlicensed";
			}
			if ((long)licenseStatus == 1L)
			{
				if ((long)gracePeriodRemaining == 0L)
				{
					return "Permanent Activated";
				}
				empty = ((!flag) ? Strings.Replace("Volume activation expiration: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0) : Strings.Replace("Timebased activation expiration: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0));
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 2L)
			{
				empty = "License Status: Initial grace period";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 3L)
			{
				empty = "License Status: Additional grace period (KMS license expired or hardware out of tolerance)";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 4L)
			{
				empty = "License Status: Non-genuine grace period.";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 5L)
			{
				empty = "License Status: Notification";
				string text = Conversion.Hex(softwareLicensingProduct_0.LicenseStatusReason);
				_ = softwareLicensingProduct_0.LicenseStatusReason;
				_ = softwareLicensingProduct_0.LicenseStatusReason;
				return Strings.Replace("Notification Reason: 0x%ERRCODE%.", "%ERRCODE%", text, 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 6L)
			{
				empty = "License Status: Extended grace period";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			return "License Status: Unknown";
		}

		private static string smethod_15(OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0)
		{
			uint gracePeriodRemaining = officeSoftwareProtectionProduct_0.GracePeriodRemaining;
			uint num = smethod_13(gracePeriodRemaining);
			bool flag = Class17.smethod_31(officeSoftwareProtectionProduct_0.Description);
			string empty = string.Empty;
			uint licenseStatus = officeSoftwareProtectionProduct_0.LicenseStatus;
			if ((long)licenseStatus == 0L)
			{
				return "License Status: Unlicensed";
			}
			if ((long)licenseStatus == 1L)
			{
				if ((long)gracePeriodRemaining == 0L)
				{
					return "Permanent Activated";
				}
				empty = ((!flag) ? Strings.Replace("Volume activation expiration: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0) : Strings.Replace("Timebased activation expiration: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0));
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 2L)
			{
				empty = "License Status: Initial grace period";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 3L)
			{
				empty = "License Status: Additional grace period (KMS license expired or hardware out of tolerance)";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 4L)
			{
				empty = "License Status: Non-genuine grace period.";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 5L)
			{
				empty = "License Status: Notification";
				string text = Conversion.Hex(officeSoftwareProtectionProduct_0.LicenseStatusReason);
				_ = officeSoftwareProtectionProduct_0.LicenseStatusReason;
				_ = officeSoftwareProtectionProduct_0.LicenseStatusReason;
				return Strings.Replace("Notification Reason: 0x%ERRCODE%.", "%ERRCODE%", text, 1, -1, (CompareMethod)0);
			}
			if ((long)licenseStatus == 6L)
			{
				empty = "License Status: Extended grace period";
				empty = Strings.Replace("Time remaining: %MINUTE% minute(s) (%DAY% day(s))", "%MINUTE%", Conversions.ToString(gracePeriodRemaining), 1, -1, (CompareMethod)0);
				return Strings.Replace(empty, "%DAY%", Conversions.ToString(num), 1, -1, (CompareMethod)0);
			}
			return "License Status: Unknown";
		}

		private static string smethod_16(uint uint_0)
		{
			return uint_0 switch
			{
				0u => "Unlicensed", 
				1u => "Licensed", 
				2u => "Out-Of-Box Grace Period", 
				3u => "Out-Of-Tolerance Grace Period", 
				4u => "Non-Genuine Grace Period", 
				5u => "Notification", 
				6u => "Extended Grace", 
				_ => "Unknown value", 
			};
		}

		private static string smethod_17(uint uint_0)
		{
			return uint_0 switch
			{
				1u => "Non Activated", 
				0u => "Genuine Activated", 
				_ => "Unknown value", 
			};
		}
	}
	public class Cliente
	{
		private delegate void Delegate0(IKMSClientSettings ikmsclientSettings_0);

		private readonly ILogger ilogger_0;

		private readonly IKMSClientSettings ikmsclientSettings_0;

		private bool bool_0;

		public bool Success
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public Cliente(IKMSClientSettings settings, ILogger logger)
		{
			ikmsclientSettings_0 = settings;
			ilogger_0 = logger;
			Success = false;
		}

		public void Start()
		{
			KMSNetworkClient kMSNetworkClient = new KMSNetworkClient(ilogger_0);
			kMSNetworkClient.Execute(ikmsclientSettings_0);
			Success = kMSNetworkClient.Success;
		}
	}
	public class HostServer
	{
		public delegate void IpAddressChangedEventHandler(string mvalue);

		private readonly Class2 class2_0;

		private string string_0;

		[CompilerGenerated]
		private uint uint_0;

		[CompilerGenerated]
		private IpAddressChangedEventHandler ipAddressChangedEventHandler_0;

		public uint Port
		{
			[CompilerGenerated]
			get
			{
				return uint_0;
			}
			[CompilerGenerated]
			set
			{
				uint_0 = value;
			}
		}

		public string IpAddress
		{
			get
			{
				return string_0;
			}
			set
			{
				string text = string_0;
				string_0 = value;
				if (!text.Contains(string_0))
				{
					try
					{
						ipAddressChangedEventHandler_0?.Invoke(string_0);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public event IpAddressChangedEventHandler IpAddressChanged
		{
			[CompilerGenerated]
			add
			{
				IpAddressChangedEventHandler ipAddressChangedEventHandler = ipAddressChangedEventHandler_0;
				IpAddressChangedEventHandler ipAddressChangedEventHandler2;
				do
				{
					ipAddressChangedEventHandler2 = ipAddressChangedEventHandler;
					IpAddressChangedEventHandler value2 = (IpAddressChangedEventHandler)Delegate.Combine(ipAddressChangedEventHandler2, value);
					ipAddressChangedEventHandler = Interlocked.CompareExchange(ref ipAddressChangedEventHandler_0, value2, ipAddressChangedEventHandler2);
				}
				while ((object)ipAddressChangedEventHandler != ipAddressChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				IpAddressChangedEventHandler ipAddressChangedEventHandler = ipAddressChangedEventHandler_0;
				IpAddressChangedEventHandler ipAddressChangedEventHandler2;
				do
				{
					ipAddressChangedEventHandler2 = ipAddressChangedEventHandler;
					IpAddressChangedEventHandler value2 = (IpAddressChangedEventHandler)Delegate.Remove(ipAddressChangedEventHandler2, value);
					ipAddressChangedEventHandler = Interlocked.CompareExchange(ref ipAddressChangedEventHandler_0, value2, ipAddressChangedEventHandler2);
				}
				while ((object)ipAddressChangedEventHandler != ipAddressChangedEventHandler2);
			}
		}

		public HostServer(string string_1, uint puerto)
		{
			class2_0 = null;
			string_0 = string_1;
			Port = puerto;
			class2_0 = class2_0;
		}

		public HostServer()
		{
			class2_0 = null;
			ResetIpForward();
		}

		public void ResetIpLocal()
		{
			string text = Conversions.ToString(127);
			string text2 = Conversions.ToString(Class2.smethod_2(0, 254));
			string text3 = Conversions.ToString(Class2.smethod_2(0, 254));
			string text4 = Conversions.ToString(Class2.smethod_2(2, 254));
			string_0 = $"{text:D3}.{text2:D3}.{text3:D3}.{text4:D3}";
			Port = 1688u;
		}

		public void ResetIpForward()
		{
			string text = Conversions.ToString(10);
			string text2 = Conversions.ToString(Class2.smethod_2(0, 254));
			string text3 = Conversions.ToString(Class2.smethod_2(0, 254));
			string text4 = Conversions.ToString(Class2.smethod_2(2, 254));
			string_0 = $"{text:D3}.{text2:D3}.{text3:D3}.{text4:D3}";
			Port = 1688u;
		}
	}
	public class RT2VL
	{
		private static bool smethod_0(ref string string_0, ref int int_0, ref bool bool_0, ref Variables variables_0)
		{
			try
			{
				ReadOnlyCollection<string> files = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)2, new string[1]
				{
					"*.xrm-ms"
				});
				foreach (string item in files)
				{
					try
					{
						string string_ = ((ServerComputer)Class79.smethod_0()).get_FileSystem().ReadAllText(item);
						checked
						{
							int_0++;
							FileLogger logger = variables_0.Logger;
							string message = "Installing License " + Conversions.ToString(int_0) + " for Windows";
							logger.LogMessage(ref message);
							SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
							bool_0 = Conversions.ToBoolean(Class17.smethod_44(ref softwareLicensingService_, ref string_, ref variables_0));
						}
						if (0u - (bool_0 ? 1u : 0u) != 0)
						{
							return false;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception exception_ = ex;
						string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
						FileLogger logger2 = variables_0.Logger;
						string message = "Error: " + str;
						logger2.LogMessage(ref message);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger3 = variables_0.Logger;
				string message = "Error: " + str2;
				logger3.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			return true;
		}

		internal static bool smethod_1(ref Variables variables_0)
		{
			int int_ = 0;
			uint num = 1u;
			string text = "kmscertW";
			if (variables_0.IsWindows10)
			{
				text += "10";
			}
			else if (variables_0.IsWindows81)
			{
				text += "81";
			}
			else if (variables_0.IsWindows8)
			{
				text += "8";
			}
			else if (variables_0.IsWindows7)
			{
				text += "7";
			}
			else if (variables_0.IsWindowsVista)
			{
				text += "6";
			}
			string string_ = variables_0.DirectorioActual + "\\cert\\" + text;
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_))
			{
				bool bool_ = num != 0;
				bool num2 = smethod_0(ref string_, ref int_, ref bool_, ref variables_0);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num2)
				{
					return false;
				}
			}
			else
			{
				string_ = Environment.GetEnvironmentVariable("SystemRoot") + "\\System32\\spp\\tokens\\pkeyconfig";
				bool bool_ = num != 0;
				bool num3 = smethod_0(ref string_, ref int_, ref bool_, ref variables_0);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num3)
				{
					return false;
				}
			}
			string_ = variables_0.DirectorioActual + "\\cert\\" + text + "\\" + variables_0.EditionID;
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_))
			{
				bool bool_ = num != 0;
				bool num4 = smethod_0(ref string_, ref int_, ref bool_, ref variables_0);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num4)
				{
					return false;
				}
			}
			else
			{
				string_ = Environment.GetEnvironmentVariable("SystemRoot") + "\\System32\\spp\\tokens\\skus\\" + variables_0.EditionID;
				bool bool_ = num != 0;
				bool num5 = smethod_0(ref string_, ref int_, ref bool_, ref variables_0);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num5)
				{
					return false;
				}
			}
			return true;
		}

		private static bool smethod_2(ref string string_0, ref string string_1, ref int int_0, ref bool bool_0, ref Variables variables_0, bool bool_1 = false, ref string string_2 = "")
		{
			try
			{
				ReadOnlyCollection<string> readOnlyCollection = (string.IsNullOrEmpty(string_2) ? ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)2, new string[1]
				{
					"*.xrm-ms"
				}) : ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)2, new string[1]
				{
					smethod_27(ref string_2) + "*.xrm-ms"
				}));
				foreach (string item in readOnlyCollection)
				{
					try
					{
						string string_3 = ((ServerComputer)Class79.smethod_0()).get_FileSystem().ReadAllText(item);
						checked
						{
							int_0++;
							FileLogger logger = variables_0.Logger;
							string message = "Installing License " + Conversions.ToString(int_0) + " for :" + string_1;
							logger.LogMessage(ref message);
							if (!bool_1)
							{
								if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
								{
									if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
									{
										OfficeSoftwareProtectionService officeSoftwareProtectionService_ = Class17.smethod_50(ref variables_0);
										bool_0 = Conversions.ToBoolean(Class17.smethod_45(ref officeSoftwareProtectionService_, ref string_3, ref variables_0));
									}
								}
								else
								{
									SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
									bool_0 = Conversions.ToBoolean(Class17.smethod_44(ref softwareLicensingService_, ref string_3, ref variables_0));
								}
							}
							else
							{
								OfficeSoftwareProtectionService officeSoftwareProtectionService_ = Class17.smethod_50(ref variables_0);
								bool_0 = Conversions.ToBoolean(Class17.smethod_45(ref officeSoftwareProtectionService_, ref string_3, ref variables_0));
							}
						}
						if (0u - (bool_0 ? 1u : 0u) != 0)
						{
							return false;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception exception_ = ex;
						string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
						FileLogger logger2 = variables_0.Logger;
						string message = "Error: " + str;
						logger2.LogMessage(ref message);
						ProjectData.ClearProjectError();
					}
				}
				smethod_26(ref string_0, ref variables_0);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger3 = variables_0.Logger;
				string message = "Error: " + str2;
				logger3.LogMessage(ref message);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}

		internal static bool smethod_3(ref string string_0, ref Variables variables_0, ref string string_1 = "")
		{
			int int_ = 0;
			uint num = 1u;
			string string_2 = variables_0.DirectorioActual + "\\cert\\kmscert2016";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_2))
			{
				bool bool_ = num != 0;
				string string_3 = "";
				bool num2 = smethod_2(ref string_2, ref string_0, ref int_, ref bool_, ref variables_0, bool_1: false, ref string_3);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num2)
				{
					return false;
				}
			}
			string_2 = variables_0.DirectorioActual + "\\cert\\kmscert2016\\" + string_0;
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_2))
			{
				bool bool_ = num != 0;
				string string_3 = "";
				bool num3 = smethod_2(ref string_2, ref string_0, ref int_, ref bool_, ref variables_0, bool_1: false, ref string_3);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num3)
				{
					return false;
				}
			}
			if (!string.IsNullOrEmpty(string_1))
			{
				string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Microsoft Office\\root\\Licenses16";
				if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_2))
				{
					string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft Office\\root\\Licenses16";
				}
				if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_2))
				{
					bool bool_ = num != 0;
					bool num4 = smethod_2(ref string_2, ref string_0, ref int_, ref bool_, ref variables_0, bool_1: false, ref string_1);
					num = 0u - (bool_ ? 1u : 0u);
					if (!num4)
					{
						return false;
					}
				}
			}
			return true;
		}

		internal static bool smethod_4(ref string string_0, ref Variables variables_0)
		{
			int int_ = 0;
			uint num = 1u;
			string string_ = variables_0.DirectorioActual + "\\cert\\kmscert2013";
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_))
			{
				bool bool_ = num != 0;
				string string_2 = "";
				bool num2 = smethod_2(ref string_, ref string_0, ref int_, ref bool_, ref variables_0, bool_1: false, ref string_2);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num2)
				{
					return false;
				}
			}
			string_ = variables_0.DirectorioActual + "\\cert\\kmscert2013\\" + string_0;
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_))
			{
				bool bool_ = num != 0;
				string string_2 = "";
				bool num3 = smethod_2(ref string_, ref string_0, ref int_, ref bool_, ref variables_0, bool_1: false, ref string_2);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num3)
				{
					return false;
				}
			}
			return true;
		}

		public static bool InstallCertVLOffice2010(ref string folder, ref Variables variables)
		{
			int int_ = 0;
			uint num = 1u;
			string string_ = variables.DirectorioActual + "\\cert\\kmscert2010\\" + folder;
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_))
			{
				bool bool_ = num != 0;
				string string_2 = "";
				bool num2 = smethod_2(ref string_, ref folder, ref int_, ref bool_, ref variables, bool_1: true, ref string_2);
				num = 0u - (bool_ ? 1u : 0u);
				if (!num2)
				{
					return false;
				}
			}
			return true;
		}

		internal static bool smethod_5(ref string string_0, ref bool bool_0, ref bool bool_1, ref bool bool_2, ref Variables variables_0)
		{
			string text = string.Empty;
			if (bool_0)
			{
				text = variables_0.DirectorioActual + "\\cert\\kmscert2016\\" + string_0;
			}
			else if (bool_1)
			{
				text = variables_0.DirectorioActual + "\\cert\\kmscert2013\\" + string_0;
			}
			else if (bool_2)
			{
				text = variables_0.DirectorioActual + "\\cert\\kmscert2010\\" + string_0;
			}
			bool num = ((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(text);
			string message;
			if (num)
			{
				FileLogger logger = variables_0.Logger;
				message = "Folder Found: " + text;
				logger.LogMessage(ref message);
				return num;
			}
			FileLogger logger2 = variables_0.Logger;
			message = "Error: Folder Not Found: " + text + " cant convert to VL";
			logger2.LogMessage(ref message);
			return num;
		}

		internal static void smethod_6(ref bool bool_0, ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref bool bool_1, ref bool bool_2, ref bool bool_3, ref List<OfficeSoftwareProtectionProduct> list_0, ref Variables variables_0)
		{
			string string_ = string.Empty;
			if (bool_1)
			{
				string string_2 = officeSoftwareProtectionProduct_0.Name;
				string_ = smethod_27(ref string_2);
			}
			else if (bool_2)
			{
				string string_2 = officeSoftwareProtectionProduct_0.Name;
				string_ = smethod_28(ref string_2);
			}
			else if (bool_3)
			{
				string string_2 = officeSoftwareProtectionProduct_0.Name;
				string_ = smethod_29(ref string_2);
			}
			if (smethod_5(ref string_, ref bool_1, ref bool_2, ref bool_3, ref variables_0))
			{
				Class3.smethod_28(ref list_0, ref officeSoftwareProtectionProduct_0);
				bool_0 = true;
			}
		}

		internal static void smethod_7(ref bool bool_0, SoftwareLicensingProduct softwareLicensingProduct_0, ref bool bool_1, ref bool bool_2, ref List<SoftwareLicensingProduct> list_0, ref Variables variables_0)
		{
			string string_ = string.Empty;
			if (bool_1)
			{
				string string_2 = softwareLicensingProduct_0.Name;
				string_ = smethod_27(ref string_2);
			}
			else if (bool_2)
			{
				string string_2 = softwareLicensingProduct_0.Name;
				string_ = smethod_28(ref string_2);
			}
			bool bool_3 = false;
			if (smethod_5(ref string_, ref bool_1, ref bool_2, ref bool_3, ref variables_0))
			{
				Class3.smethod_27(ref list_0, ref softwareLicensingProduct_0);
				bool_0 = true;
			}
		}

		internal static void smethod_8(ref bool bool_0, SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
		{
			string string_ = softwareLicensingProduct_0.Name;
			if (!string_.Contains("Core") && !string_.Contains("Professional") && !string_.Contains("Enterprise") && !string_.Contains("Essentials") && !string_.Contains("Embedded") && !string_.Contains("Business") && !string_.Contains("Standard") && !string_.Contains("Datacenter") && !string_.Contains("Country") && !string_.Contains("Premium") && !string_.Contains("HPC") && !string_.Contains("ServerCloudStorageCore") && !string_.Contains("ServerCloudStorage") && !string_.Contains("ServerSolutionCore") && !string_.Contains("ServerSolution") && !string_.Contains("Web"))
			{
				Class3.smethod_15(ref variables_0, ref string_);
			}
			else
			{
				if (!Class17.smethod_27(softwareLicensingProduct_0.Description))
				{
					Key.smethod_11(ref softwareLicensingProduct_0, bool_0: true, ref variables_0);
				}
				bool_0 = true;
			}
			if (bool_0)
			{
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				Class17.smethod_36(ref softwareLicensingService_, ref variables_0);
				Check.smethod_2(ref variables_0);
			}
		}

		internal static void smethod_9(ref List<SoftwareLicensingProduct> list_0, ref Variables variables_0)
		{
			FileLogger logger = variables_0.Logger;
			string message = "Converting Office 2016 products: " + Conversions.ToString(list_0.Count);
			logger.LogMessage(ref message);
			bool bool_ = true;
			Class10.smethod_8(ref bool_, ref variables_0);
			smethod_11(ref list_0, ref variables_0);
			list_0.Clear();
			Check.smethod_3(ref variables_0);
		}

		internal static void smethod_10(ref List<OfficeSoftwareProtectionProduct> list_0, ref Variables variables_0)
		{
			FileLogger logger = variables_0.Logger;
			string message = "Converting Office 2016 products: " + Conversions.ToString(list_0.Count);
			logger.LogMessage(ref message);
			bool bool_ = true;
			Class10.smethod_8(ref bool_, ref variables_0);
			smethod_12(ref list_0, ref variables_0);
			list_0.Clear();
			Check.smethod_3(ref variables_0);
		}

		internal static void smethod_11(ref List<SoftwareLicensingProduct> list_0, ref Variables variables_0)
		{
			while (list_0.Count > 0)
			{
				SoftwareLicensingProduct softwareLicensingProduct_ = Enumerable.ElementAt<SoftwareLicensingProduct>((IEnumerable<SoftwareLicensingProduct>)list_0, 0);
				string string_ = softwareLicensingProduct_.Name;
				string string_2 = smethod_27(ref string_);
				bool bool_ = true;
				bool bool_2 = false;
				bool bool_3 = false;
				if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(softwareLicensingProduct_.Description))
				{
					FileLogger logger = variables_0.Logger;
					string_ = "Converting " + softwareLicensingProduct_.Name + " ...";
					logger.LogMessage(ref string_);
					string_ = softwareLicensingProduct_.Name;
					if (smethod_3(ref string_2, ref variables_0, ref string_))
					{
						Key.smethod_11(ref softwareLicensingProduct_, bool_0: false, ref variables_0);
					}
				}
				list_0.Remove(softwareLicensingProduct_);
			}
		}

		internal static void smethod_12(ref List<OfficeSoftwareProtectionProduct> list_0, ref Variables variables_0)
		{
			while (list_0.Count > 0)
			{
				OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_ = Enumerable.ElementAt<OfficeSoftwareProtectionProduct>((IEnumerable<OfficeSoftwareProtectionProduct>)list_0, 0);
				string string_ = officeSoftwareProtectionProduct_.Name;
				string string_2 = smethod_27(ref string_);
				bool bool_ = true;
				bool bool_2 = false;
				bool bool_3 = false;
				if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(officeSoftwareProtectionProduct_.Description))
				{
					FileLogger logger = variables_0.Logger;
					string_ = "Converting " + officeSoftwareProtectionProduct_.Name + " ...";
					logger.LogMessage(ref string_);
					string_ = officeSoftwareProtectionProduct_.Name;
					if (smethod_3(ref string_2, ref variables_0, ref string_))
					{
						Key.smethod_14(ref officeSoftwareProtectionProduct_, ref variables_0);
					}
				}
				list_0.Remove(officeSoftwareProtectionProduct_);
			}
		}

		internal static void smethod_13(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
		{
			string string_ = softwareLicensingProduct_0.Name;
			string string_2 = smethod_27(ref string_);
			bool bool_ = true;
			bool bool_2 = false;
			bool bool_3 = false;
			if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(softwareLicensingProduct_0.Description))
			{
				FileLogger logger = variables_0.Logger;
				string_ = "Converting " + softwareLicensingProduct_0.Name + " ...";
				logger.LogMessage(ref string_);
				string_ = softwareLicensingProduct_0.Name;
				if (smethod_3(ref string_2, ref variables_0, ref string_))
				{
					Key.smethod_11(ref softwareLicensingProduct_0, bool_0: false, ref variables_0);
				}
			}
			Check.smethod_3(ref variables_0);
		}

		internal static void smethod_14(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
		{
			string string_ = officeSoftwareProtectionProduct_0.Name;
			string string_2 = smethod_27(ref string_);
			bool bool_ = true;
			bool bool_2 = false;
			bool bool_3 = false;
			if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(officeSoftwareProtectionProduct_0.Description))
			{
				FileLogger logger = variables_0.Logger;
				string_ = "Converting " + officeSoftwareProtectionProduct_0.Name + " ...";
				logger.LogMessage(ref string_);
				string_ = officeSoftwareProtectionProduct_0.Name;
				smethod_3(ref string_2, ref variables_0, ref string_);
				Key.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
			}
			Check.smethod_3(ref variables_0);
		}

		internal static void smethod_15(ref string string_0, ref Variables variables_0)
		{
			string string_ = smethod_27(ref string_0);
			bool bool_ = true;
			bool bool_2 = false;
			bool bool_3 = false;
			if (smethod_5(ref string_, ref bool_, ref bool_2, ref bool_3, ref variables_0))
			{
				FileLogger logger = variables_0.Logger;
				string message = "Converting " + string_0 + " ...";
				logger.LogMessage(ref message);
				smethod_3(ref string_, ref variables_0, ref string_0);
				Key.smethod_12(ref string_0, ref variables_0);
			}
			Check.smethod_3(ref variables_0);
		}

		internal static void smethod_16(ref List<SoftwareLicensingProduct> list_0, ref Variables variables_0)
		{
			FileLogger logger = variables_0.Logger;
			string message = "Converting Office 2013 products: " + Conversions.ToString(list_0.Count);
			logger.LogMessage(ref message);
			bool bool_ = true;
			Class10.smethod_9(ref bool_, ref variables_0);
			smethod_18(ref list_0, ref variables_0);
			list_0.Clear();
			Check.smethod_4(ref variables_0);
		}

		internal static void smethod_17(ref List<OfficeSoftwareProtectionProduct> list_0, ref Variables variables_0)
		{
			FileLogger logger = variables_0.Logger;
			string message = "Converting Office 2013 products: " + Conversions.ToString(list_0.Count);
			logger.LogMessage(ref message);
			bool bool_ = true;
			Class10.smethod_9(ref bool_, ref variables_0);
			smethod_19(ref list_0, ref variables_0);
			list_0.Clear();
			Check.smethod_4(ref variables_0);
		}

		internal static void smethod_18(ref List<SoftwareLicensingProduct> list_0, ref Variables variables_0)
		{
			while (list_0.Count > 0)
			{
				SoftwareLicensingProduct softwareLicensingProduct_ = Enumerable.ElementAt<SoftwareLicensingProduct>((IEnumerable<SoftwareLicensingProduct>)list_0, 0);
				string string_ = softwareLicensingProduct_.Name;
				string string_2 = smethod_28(ref string_);
				bool bool_ = false;
				bool bool_2 = true;
				bool bool_3 = false;
				if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(softwareLicensingProduct_.Description))
				{
					FileLogger logger = variables_0.Logger;
					string_ = "Converting " + softwareLicensingProduct_.Name + " ...";
					logger.LogMessage(ref string_);
					if (smethod_4(ref string_2, ref variables_0))
					{
						Key.smethod_11(ref softwareLicensingProduct_, bool_0: false, ref variables_0);
					}
				}
				list_0.Remove(softwareLicensingProduct_);
			}
		}

		internal static void smethod_19(ref List<OfficeSoftwareProtectionProduct> list_0, ref Variables variables_0)
		{
			while (list_0.Count > 0)
			{
				OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_ = Enumerable.ElementAt<OfficeSoftwareProtectionProduct>((IEnumerable<OfficeSoftwareProtectionProduct>)list_0, 0);
				string string_ = officeSoftwareProtectionProduct_.Name;
				string string_2 = smethod_28(ref string_);
				bool bool_ = false;
				bool bool_2 = true;
				bool bool_3 = false;
				if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(officeSoftwareProtectionProduct_.Description))
				{
					FileLogger logger = variables_0.Logger;
					string_ = "Converting " + officeSoftwareProtectionProduct_.Name + " ...";
					logger.LogMessage(ref string_);
					if (smethod_4(ref string_2, ref variables_0))
					{
						Key.smethod_14(ref officeSoftwareProtectionProduct_, ref variables_0);
					}
				}
				list_0.Remove(officeSoftwareProtectionProduct_);
			}
		}

		internal static void smethod_20(ref SoftwareLicensingProduct softwareLicensingProduct_0, ref Variables variables_0)
		{
			string string_ = softwareLicensingProduct_0.Name;
			string string_2 = smethod_28(ref string_);
			bool bool_ = false;
			bool bool_2 = true;
			bool bool_3 = false;
			if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(softwareLicensingProduct_0.Description))
			{
				FileLogger logger = variables_0.Logger;
				string_ = "Converting " + softwareLicensingProduct_0.Name + " ...";
				logger.LogMessage(ref string_);
				if (smethod_4(ref string_2, ref variables_0))
				{
					Key.smethod_11(ref softwareLicensingProduct_0, bool_0: false, ref variables_0);
				}
			}
			Check.smethod_4(ref variables_0);
		}

		internal static void smethod_21(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
		{
			string string_ = officeSoftwareProtectionProduct_0.Name;
			string string_2 = smethod_28(ref string_);
			bool bool_ = false;
			bool bool_2 = true;
			bool bool_3 = false;
			if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(officeSoftwareProtectionProduct_0.Description))
			{
				FileLogger logger = variables_0.Logger;
				string_ = "Converting " + officeSoftwareProtectionProduct_0.Name + " ...";
				logger.LogMessage(ref string_);
				smethod_4(ref string_2, ref variables_0);
				Key.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
			}
			Check.smethod_4(ref variables_0);
		}

		internal static void smethod_22(ref string string_0, ref Variables variables_0)
		{
			string string_ = smethod_28(ref string_0);
			bool bool_ = false;
			bool bool_2 = true;
			bool bool_3 = false;
			if (smethod_5(ref string_, ref bool_, ref bool_2, ref bool_3, ref variables_0))
			{
				FileLogger logger = variables_0.Logger;
				string message = "Converting " + string_0 + " ...";
				logger.LogMessage(ref message);
				smethod_4(ref string_, ref variables_0);
				Key.smethod_12(ref string_0, ref variables_0);
			}
			Check.smethod_4(ref variables_0);
		}

		internal static void smethod_23(ref List<OfficeSoftwareProtectionProduct> list_0, ref Variables variables_0)
		{
			while (list_0.Count > 0)
			{
				OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_ = Enumerable.ElementAt<OfficeSoftwareProtectionProduct>((IEnumerable<OfficeSoftwareProtectionProduct>)list_0, 0);
				string string_ = officeSoftwareProtectionProduct_.Name;
				string string_2 = smethod_29(ref string_);
				bool bool_ = false;
				bool bool_2 = false;
				bool bool_3 = true;
				if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(officeSoftwareProtectionProduct_.Description))
				{
					FileLogger logger = variables_0.Logger;
					string_ = "Converting " + officeSoftwareProtectionProduct_.Name + " ...";
					logger.LogMessage(ref string_);
					InstallCertVLOffice2010(ref string_2, ref variables_0);
					Key.smethod_14(ref officeSoftwareProtectionProduct_, ref variables_0);
				}
				list_0.Remove(officeSoftwareProtectionProduct_);
			}
			list_0.Clear();
			Check.smethod_6(ref variables_0);
		}

		internal static void smethod_24(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
		{
			string string_ = officeSoftwareProtectionProduct_0.Name;
			string string_2 = smethod_29(ref string_);
			bool bool_ = false;
			bool bool_2 = false;
			bool bool_3 = true;
			if (smethod_5(ref string_2, ref bool_, ref bool_2, ref bool_3, ref variables_0) && !Class17.smethod_27(officeSoftwareProtectionProduct_0.Description))
			{
				FileLogger logger = variables_0.Logger;
				string_ = "Converting " + officeSoftwareProtectionProduct_0.Name + " ...";
				logger.LogMessage(ref string_);
				InstallCertVLOffice2010(ref string_2, ref variables_0);
				Key.smethod_14(ref officeSoftwareProtectionProduct_0, ref variables_0);
			}
			Check.smethod_6(ref variables_0);
		}

		internal static void smethod_25(ref string string_0, ref Variables variables_0)
		{
			string string_ = smethod_29(ref string_0);
			bool bool_ = false;
			bool bool_2 = false;
			bool bool_3 = true;
			if (smethod_5(ref string_, ref bool_, ref bool_2, ref bool_3, ref variables_0))
			{
				FileLogger logger = variables_0.Logger;
				string message = "Converting " + string_0 + " ...";
				logger.LogMessage(ref message);
				InstallCertVLOffice2010(ref string_, ref variables_0);
				Key.smethod_12(ref string_0, ref variables_0);
			}
			Check.smethod_6(ref variables_0);
		}

		private static void smethod_26(ref string string_0, ref Variables variables_0)
		{
			ReadOnlyCollection<string> files = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)2, new string[1]
			{
				"*.reg"
			});
			FileLogger logger = variables_0.Logger;
			string message = "Installing .reg files";
			logger.LogMessage(ref message);
			foreach (string item in files)
			{
				try
				{
					ArrayList arrayList_ = new ArrayList();
					arrayList_.Add("/S");
					arrayList_.Add("\"" + item + "\"");
					message = "regedit.exe";
					string[] string_ = Class2.smethod_0(ref variables_0, ref message);
					bool bool_ = true;
					Class3.smethod_1(ref string_, ref arrayList_, ref variables_0, ref bool_);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
					FileLogger logger2 = variables_0.Logger;
					message = "Error: " + str;
					logger2.LogMessage(ref message);
					ProjectData.ClearProjectError();
				}
			}
		}

		internal static string smethod_27(ref string string_0)
		{
			string empty = string.Empty;
			if (string_0.Contains("Office16ProPlus"))
			{
				return "ProPlus";
			}
			if (string_0.Contains("Office16Std"))
			{
				return "Standard";
			}
			if (string_0.Contains("Office16Professional"))
			{
				return "ProPlus";
			}
			if (string_0.Contains("Office16ProjectPro"))
			{
				return "ProjectPro";
			}
			if (string_0.Contains("Office16ProjectStd"))
			{
				return "ProjectStd";
			}
			if (string_0.Contains("Office16VisioPro"))
			{
				return "VisioPro";
			}
			if (string_0.Contains("Office16VisioStd"))
			{
				return "VisioStd";
			}
			if (string_0.Contains("Office16Access"))
			{
				return "Access";
			}
			if (string_0.Contains("Office16Excel"))
			{
				return "Excel";
			}
			if (string_0.Contains("Office16InfoPath"))
			{
				return "InfoPath";
			}
			if (string_0.Contains("Office16Lync"))
			{
				return "Lync";
			}
			if (string_0.Contains("Office16OneNote"))
			{
				return "OneNote";
			}
			if (string_0.Contains("Office16Outlook"))
			{
				return "Outlook";
			}
			if (string_0.Contains("Office16PowerPoint"))
			{
				return "PowerPoint";
			}
			if (string_0.Contains("Office16Publisher"))
			{
				return "Publisher";
			}
			if (string_0.Contains("Office16Word"))
			{
				return "Word";
			}
			if (string_0.Contains("Office16Mondo"))
			{
				return "Mondo";
			}
			if (string_0.Contains("Office16SkypeforBusiness"))
			{
				return "SkypeforBusiness";
			}
			return "NonSupported";
		}

		internal static string smethod_28(ref string string_0)
		{
			string empty = string.Empty;
			if (string_0.Contains("OfficeProPlus"))
			{
				return "ProPlus";
			}
			if (string_0.Contains("OfficeStd"))
			{
				return "Standard";
			}
			if (string_0.Contains("OfficeProfessional"))
			{
				return "ProPlus";
			}
			if (string_0.Contains("OfficeProjectPro"))
			{
				return "ProjectPro";
			}
			if (string_0.Contains("OfficeProjectStd"))
			{
				return "ProjectStd";
			}
			if (string_0.Contains("OfficeVisioPro"))
			{
				return "VisioPro";
			}
			if (string_0.Contains("OfficeVisioStd"))
			{
				return "VisioStd";
			}
			if (string_0.Contains("OfficeAccess"))
			{
				return "Access";
			}
			if (string_0.Contains("OfficeExcel"))
			{
				return "Excel";
			}
			if (string_0.Contains("OfficeInfoPath"))
			{
				return "InfoPath";
			}
			if (string_0.Contains("OfficeLync"))
			{
				return "Lync";
			}
			if (string_0.Contains("OfficeOneNote"))
			{
				return "OneNote";
			}
			if (string_0.Contains("OfficeOutlook"))
			{
				return "Outlook";
			}
			if (string_0.Contains("OfficePowerPoint"))
			{
				return "PowerPoint";
			}
			if (string_0.Contains("OfficePublisher"))
			{
				return "Publisher";
			}
			if (string_0.Contains("OfficeWord"))
			{
				return "Word";
			}
			return "NonSupported";
		}

		internal static string smethod_29(ref string string_0)
		{
			string empty = string.Empty;
			if (string_0.Contains("OfficeProPlus"))
			{
				return "ProPlus";
			}
			if (string_0.Contains("OfficeStd"))
			{
				return "Standard";
			}
			if (string_0.Contains("OfficeProjectPro"))
			{
				return "ProjectPro";
			}
			if (string_0.Contains("OfficeProjectStd"))
			{
				return "ProjectStd";
			}
			if (string_0.Contains("OfficeVisioPro"))
			{
				return "Visio";
			}
			if (string_0.Contains("OfficeVisioStd"))
			{
				return "Visio";
			}
			if (string_0.Contains("OfficeVisioPrem"))
			{
				return "Visio";
			}
			if (string_0.Contains("OfficeAccess"))
			{
				return "Access";
			}
			if (string_0.Contains("OfficeExcel"))
			{
				return "Excel";
			}
			if (string_0.Contains("OfficeInfoPath"))
			{
				return "InfoPath";
			}
			if (string_0.Contains("OfficeGroove"))
			{
				return "Groove";
			}
			if (string_0.Contains("OfficeOneNote"))
			{
				return "OneNote";
			}
			if (string_0.Contains("OfficeOutlook"))
			{
				return "Outlook";
			}
			if (string_0.Contains("OfficePowerPoint"))
			{
				return "PowerPoint";
			}
			if (string_0.Contains("OfficePublisher"))
			{
				return "Publisher";
			}
			if (string_0.Contains("OfficeWord"))
			{
				return "Word";
			}
			if (string_0.Contains("OfficeSmallBusBasics"))
			{
				return "SmallBusBasics";
			}
			return "NonSupported";
		}
	}
	public class TakeOwner
	{
		internal static void smethod_0(ref string string_0, ref Variables variables_0)
		{
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_0))
			{
				return;
			}
			try
			{
				ReadOnlyCollection<string> files = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)3, new string[1]
				{
					"*.dat"
				});
				string string_ = "takeown.exe";
				string[] string_2 = Class2.smethod_0(ref variables_0, ref string_);
				string_ = "icacls.exe";
				string[] string_3 = Class2.smethod_0(ref variables_0, ref string_);
				foreach (string item in files)
				{
					try
					{
						ArrayList arrayList_ = new ArrayList();
						arrayList_.Add("/f");
						arrayList_.Add(item);
						bool bool_ = true;
						Class3.smethod_1(ref string_2, ref arrayList_, ref variables_0, ref bool_);
						arrayList_.Clear();
						arrayList_.Add(item);
						arrayList_.Add("/grant :r");
						arrayList_.Add("administrators:(d,f)");
						bool_ = true;
						Class3.smethod_1(ref string_3, ref arrayList_, ref variables_0, ref bool_);
						arrayList_.Clear();
						arrayList_.Add(item);
						arrayList_.Add("/grant :r");
						arrayList_.Add("*S-1-1-0:(d,f)");
						bool_ = true;
						Class3.smethod_1(ref string_3, ref arrayList_, ref variables_0, ref bool_);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception exception_ = ex;
						string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
						FileLogger logger = variables_0.Logger;
						string_ = "Error: " + str;
						logger.LogMessage(ref string_);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception_2 = ex2;
				string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
				FileLogger logger2 = variables_0.Logger;
				string string_ = "Error: " + str2;
				logger2.LogMessage(ref string_);
				ProjectData.ClearProjectError();
			}
		}

		internal static void smethod_1(ref string string_0, ref Variables variables_0)
		{
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Invalid comparison between Unknown and I4
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			if (!((ServerComputer)Class79.smethod_0()).get_FileSystem().FileExists(string_0))
			{
				return;
			}
			try
			{
				string string_ = "takeown.exe";
				string[] string_2 = Class2.smethod_0(ref variables_0, ref string_);
				string_ = "icacls.exe";
				string[] string_3 = Class2.smethod_0(ref variables_0, ref string_);
				ArrayList arrayList_ = new ArrayList();
				arrayList_.Add("/f");
				arrayList_.Add(string_0);
				bool bool_ = true;
				Class3.smethod_1(ref string_2, ref arrayList_, ref variables_0, ref bool_);
				arrayList_.Clear();
				arrayList_.Add(string_0);
				arrayList_.Add("/grant :r");
				arrayList_.Add("administrators:(d,f)");
				bool_ = true;
				Class3.smethod_1(ref string_3, ref arrayList_, ref variables_0, ref bool_);
				arrayList_.Clear();
				arrayList_.Add(string_0);
				arrayList_.Add("/grant :r");
				arrayList_.Add("*S-1-1-0:(d,f)");
				bool_ = true;
				Class3.smethod_1(ref string_3, ref arrayList_, ref variables_0, ref bool_);
				FileAttributes attributes = File.GetAttributes(string_0);
				if ((attributes & 1) == 1)
				{
					attributes = smethod_2(attributes, (FileAttributes)1);
					File.SetAttributes(string_0, attributes);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger = variables_0.Logger;
				string string_ = "Error: " + str;
				logger.LogMessage(ref string_);
				ProjectData.ClearProjectError();
			}
		}

		private static FileAttributes smethod_2(FileAttributes fileAttributes_0, FileAttributes fileAttributes_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			return (FileAttributes)(fileAttributes_0 & ~fileAttributes_1);
		}
	}
	public class UndoGenuine
	{
		internal static void smethod_0(ref Variables variables_0)
		{
			if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
			{
				string string_ = "sppsvc";
				bool bool_ = false;
				bool bool_2 = true;
				Class2.smethod_1(ref string_, ref bool_, ref variables_0, ref bool_2);
				if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Environment.GetEnvironmentVariable("WinDir") + "\\System32"))
				{
					string_ = Environment.GetEnvironmentVariable("WinDir") + "\\System32";
					smethod_1(ref string_, ref variables_0);
				}
				if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Environment.GetEnvironmentVariable("WinDir") + "\\SysWOW64"))
				{
					string_ = Environment.GetEnvironmentVariable("WinDir") + "\\SysWOW64";
					smethod_1(ref string_, ref variables_0);
				}
				if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative"))
				{
					string_ = Environment.GetEnvironmentVariable("WinDir") + "\\Sysnative";
					smethod_1(ref string_, ref variables_0);
				}
				string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows Activation Technologies";
				string string_2 = null;
				Class10.smethod_3(ref string_, ref string_2, ref variables_0);
				if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Environment.GetEnvironmentVariable("WinDir") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform"))
				{
					string_2 = Environment.GetEnvironmentVariable("WinDir") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform";
					Class3.smethod_5(ref string_2, ref variables_0);
				}
				if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(Environment.GetEnvironmentVariable("WinDir") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareLicensing"))
				{
					string_2 = Environment.GetEnvironmentVariable("WinDir") + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareLicensing";
					Class3.smethod_5(ref string_2, ref variables_0);
				}
				string_2 = "Windows";
				Key.smethod_12(ref string_2, ref variables_0);
			}
		}

		private static bool smethod_1(ref string string_0, ref Variables variables_0)
		{
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Invalid comparison between Unknown and I4
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_0))
			{
				try
				{
					ReadOnlyCollection<string> files = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)2, new string[1]
					{
						"*.*"
					});
					if (files.Count > 0)
					{
						int num = 0;
						foreach (string item in files)
						{
							try
							{
								if (((FileSystemInfo)((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFileInfo(item)).get_Extension().Length == 37 && (int)((FileSystemInfo)((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFileInfo(item)).get_Attributes() == 34)
								{
									((ServerComputer)Class79.smethod_0()).get_FileSystem().DeleteFile(item, (UIOption)2, (RecycleOption)2, (UICancelOption)2);
									num = checked(num + 1);
								}
								if (num == 2)
								{
									return true;
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception exception_ = ex;
								string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
								FileLogger logger = variables_0.Logger;
								string message = "Error: " + str;
								logger.LogMessage(ref message);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			return false;
		}

		private static bool smethod_2(ref string string_0, ref Variables variables_0)
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Invalid comparison between Unknown and I4
			if (((ServerComputer)Class79.smethod_0()).get_FileSystem().DirectoryExists(string_0))
			{
				try
				{
					ReadOnlyCollection<string> files = ((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFiles(string_0, (SearchOption)2, new string[1]
					{
						"*.*"
					});
					if (files.Count > 0)
					{
						foreach (string item in files)
						{
							try
							{
								if ((int)((FileSystemInfo)((ServerComputer)Class79.smethod_0()).get_FileSystem().GetFileInfo(item)).get_Attributes() == 34)
								{
									((ServerComputer)Class79.smethod_0()).get_FileSystem().DeleteFile(item, (UIOption)2, (RecycleOption)2, (UICancelOption)2);
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception exception_ = ex;
								string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
								FileLogger logger = variables_0.Logger;
								string message = "Error: " + str;
								logger.LogMessage(ref message);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception exception_2 = ex2;
					string str2 = exception_2.Message + " " + Class2.smethod_4(ref exception_2);
					FileLogger logger2 = variables_0.Logger;
					string message = "Error: " + str2;
					logger2.LogMessage(ref message);
					ProjectData.ClearProjectError();
				}
			}
			return false;
		}
	}
	public class Variables
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Programas
		{
			public const string RegEdit = "regedit.exe";

			public const string OsppRearm = "OSPPREARM.EXE";

			public const string Netstat = "NETSTAT.EXE";

			public const string Takeown = "takeown.exe";

			public const string Icacls = "icacls.exe";

			public const string SC = "sc.exe";

			public const string Route = "route.exe";

			public const string OpenVpnCert = "OpenVPN.cer";

			public const string OpenVpnExe = "tap-windows-9.21.0.exe";

			public const string Explorer = "explorer.exe";

			public const string McBuilder = "mcbuilder.exe";
		}

		public string DirectorioActual;

		public List<SoftwareLicensingProduct> ColeccionWindows;

		public List<SoftwareLicensingProduct> ColeccionOffice2016W8;

		public List<OfficeSoftwareProtectionProduct> ColeccionOffice2016W7;

		public List<SoftwareLicensingProduct> ColeccionOffice2013W8;

		public List<OfficeSoftwareProtectionProduct> ColeccionOffice2013W7;

		public List<OfficeSoftwareProtectionProduct> ColeccionOffice2010;

		public List<SoftwareLicensingProduct> ColeccionWindowsActivable;

		public List<SoftwareLicensingProduct> ColeccionOffice2016ActivableW8;

		public List<OfficeSoftwareProtectionProduct> ColeccionOffice2016ActivableW7;

		public List<SoftwareLicensingProduct> ColeccionOffice2013ActivableW8;

		public List<OfficeSoftwareProtectionProduct> ColeccionOffice2013ActivableW7;

		public List<OfficeSoftwareProtectionProduct> ColeccionOffice2010Activable;

		public List<SoftwareLicensingProduct> ColeccionRetailOffice2016W8;

		public List<OfficeSoftwareProtectionProduct> ColeccionRetailOffice2016W7;

		public List<SoftwareLicensingProduct> ColeccionRetailOffice2013W8;

		public List<OfficeSoftwareProtectionProduct> ColeccionRetailOffice2013W7;

		public List<OfficeSoftwareProtectionProduct> ColeccionRetailOffice2010;

		public bool IsWindows10;

		public bool IsWindows81;

		public bool IsWindows8;

		public bool IsWindows7;

		public bool IsWindowsVista;

		public bool IsWindowsXP;

		public bool IsServer;

		public bool IsPreview;

		public bool IsWindowsPermanentActivate;

		public bool IsOffice2016PermanentActivate;

		public bool IsOffice2013PermanentActivate;

		public bool IsOffice2010PermanentActivate;

		public string PartialPermanentOffice2016Key;

		public string PartialPermanentOffice2013Key;

		[AccessedThroughProperty("IsWindowsListo")]
		[CompilerGenerated]
		private BooleanEvent _IsWindowsListo;

		[AccessedThroughProperty("IsOffice2016Listo")]
		[CompilerGenerated]
		private BooleanEvent _IsOffice2016Listo;

		[AccessedThroughProperty("IsOffice2013Listo")]
		[CompilerGenerated]
		private BooleanEvent _IsOffice2013Listo;

		[AccessedThroughProperty("IsOffice2010Listo")]
		[CompilerGenerated]
		private BooleanEvent _IsOffice2010Listo;

		[AccessedThroughProperty("LogString")]
		[CompilerGenerated]
		private static StringEvent _LogString;

		public bool MoveCircularProgress;

		[AccessedThroughProperty("IsWindowsActivable")]
		[CompilerGenerated]
		private BooleanEvent _IsWindowsActivable;

		[AccessedThroughProperty("IsOffice2016Activable")]
		[CompilerGenerated]
		private BooleanEvent _IsOffice2016Activable;

		[AccessedThroughProperty("IsOffice2013Activable")]
		[CompilerGenerated]
		private BooleanEvent _IsOffice2013Activable;

		[CompilerGenerated]
		[AccessedThroughProperty("IsOffice2010Activable")]
		private BooleanEvent _IsOffice2010Activable;

		public BooleanEvent IsWindowsChecked;

		public BooleanEvent IsOffice2016Checked;

		public BooleanEvent IsOffice2013Checked;

		public BooleanEvent IsOffice2010Checked;

		public DateTime Tiempo;

		public const string Comilla = "\"";

		internal IActivateMetroForm iactivateMetroForm_0;

		public ArrayList RetailKeysWindows;

		public ArrayList RetailKeysOffice2016;

		public ArrayList RetailKeysOffice2013;

		public object RutaOffice2016;

		public object RutaOffice2013;

		public object RutaOffice2010;

		public bool PlaySound;

		public AudioFile AudioVerified;

		public AudioFile AudioTransfer;

		public AudioFile AudioComplete;

		public AudioFile AudioBegin;

		public AudioFile AudioWarning;

		public AudioFile AudioDiagnostic;

		public AudioFile AudioAffirmative;

		public AudioFile AudioEnterAuthorizationCode;

		public AudioFile AudioIncomingTransmission;

		public AudioFile AudioProcessing;

		public AudioFile AudioInputOk;

		public AudioFile AudioInputFailed;

		public Stack<AudioFile> Sonidos;

		public string[] ArgumentosConsola;

		public bool IsSilent;

		public bool IsBackup;

		public bool IsPaused;

		public bool IsCheckStatus;

		public bool IsGui;

		public bool ActivadorIniciado;

		public string DirectorioBackupTokens;

		public const uint VLActivationInterval = 43200u;

		public const uint VLRenewalInterval = 43200u;

		public const string WindowsAppId = "55c92734-d682-4d71-983e-d6ec3f16059f";

		public const string Office2016AppId = "0ff1ce15-a989-479d-af46-f275c6370663";

		public const string Office2013AppId = "0ff1ce15-a989-479d-af46-f275c6370663";

		public const string Office2010AppId = "59a52881-a989-479d-af46-f275c6370663";

		public readonly FileLogger Logger;

		public IFrmShowMessage ShowMessage;

		public string ProductName;

		public string EditionID;

		public string CurrentVersion;

		public string CurrentBuild;

		public bool makeTask;

		public bool noWin;

		public bool no2016;

		public bool no2013;

		public bool no2010;

		public bool InternetConnection;

		public bool RunAsService;

		public ManagementScope GObjWmiService;

		[CompilerGenerated]
		[AccessedThroughProperty("KmsHostForward")]
		private HostServer _KmsHostForward;

		[AccessedThroughProperty("KmsHostLocal")]
		[CompilerGenerated]
		private HostServer _KmsHostLocal;

		public HostServer[] ServersOnline;

		public int IntentosActivacion;

		public int IntentosCheckWindows;

		public int IntentosCheckOffice2016;

		public int IntentosCheckOffice2013;

		public int IntentosCheckOffice2010;

		public int IntentosWinDivert;

		public int IntentosTunTap;

		public int IntentosSecoh;

		public BooleanEvent IsTapDriver;

		public bool IsTapDriverLoaded;

		public BooleanEvent IsWinDivert;

		public bool IsWinDivertLoaded;

		public BooleanEvent IsSecohQad;

		public bool IsSecohQadLoaded;

		public string SystemRoot;

		public BooleanEvent IsOnline;

		public IKMSClientSettings ClientSettings;

		public bool firewallPortOpened;

		public bool firewallAppAdded;

		public TCPServer listener;

		public bool WaterMarkBasebrd;

		public bool WaterMarkShell32;

		public bool IsWaterMarkRemove;

		public bool IsWaterMarkRestore;

		public bool Closing;

		[field: AccessedThroughProperty("IsWindowsListo")]
		public virtual BooleanEvent IsWindowsListo
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("IsOffice2016Listo")]
		public virtual BooleanEvent IsOffice2016Listo
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("IsOffice2013Listo")]
		public virtual BooleanEvent IsOffice2013Listo
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("IsOffice2010Listo")]
		public virtual BooleanEvent IsOffice2010Listo
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogString")]
		public static StringEvent LogString
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		} = new StringEvent();


		[field: AccessedThroughProperty("IsWindowsActivable")]
		public virtual BooleanEvent IsWindowsActivable
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("IsOffice2016Activable")]
		public virtual BooleanEvent IsOffice2016Activable
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("IsOffice2013Activable")]
		public virtual BooleanEvent IsOffice2013Activable
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("IsOffice2010Activable")]
		public virtual BooleanEvent IsOffice2010Activable
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("KmsHostForward")]
		public virtual HostServer KmsHostForward
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("KmsHostLocal")]
		public virtual HostServer KmsHostLocal
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Variables()
		{
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected O, but got Unknown
			DirectorioActual = Class2.smethod_6();
			ColeccionWindows = new List<SoftwareLicensingProduct>();
			ColeccionOffice2016W8 = new List<SoftwareLicensingProduct>();
			ColeccionOffice2016W7 = new List<OfficeSoftwareProtectionProduct>();
			ColeccionOffice2013W8 = new List<SoftwareLicensingProduct>();
			ColeccionOffice2013W7 = new List<OfficeSoftwareProtectionProduct>();
			ColeccionOffice2010 = new List<OfficeSoftwareProtectionProduct>();
			ColeccionWindowsActivable = new List<SoftwareLicensingProduct>();
			ColeccionOffice2016ActivableW8 = new List<SoftwareLicensingProduct>();
			ColeccionOffice2016ActivableW7 = new List<OfficeSoftwareProtectionProduct>();
			ColeccionOffice2013ActivableW8 = new List<SoftwareLicensingProduct>();
			ColeccionOffice2013ActivableW7 = new List<OfficeSoftwareProtectionProduct>();
			ColeccionOffice2010Activable = new List<OfficeSoftwareProtectionProduct>();
			ColeccionRetailOffice2016W8 = new List<SoftwareLicensingProduct>();
			ColeccionRetailOffice2016W7 = new List<OfficeSoftwareProtectionProduct>();
			ColeccionRetailOffice2013W8 = new List<SoftwareLicensingProduct>();
			ColeccionRetailOffice2013W7 = new List<OfficeSoftwareProtectionProduct>();
			ColeccionRetailOffice2010 = new List<OfficeSoftwareProtectionProduct>();
			IsWindows10 = false;
			IsWindows81 = false;
			IsWindows8 = false;
			IsWindows7 = false;
			IsWindowsVista = false;
			IsWindowsXP = false;
			IsServer = false;
			IsPreview = false;
			IsWindowsPermanentActivate = false;
			IsOffice2016PermanentActivate = false;
			IsOffice2013PermanentActivate = false;
			IsOffice2010PermanentActivate = false;
			PartialPermanentOffice2016Key = string.Empty;
			PartialPermanentOffice2013Key = string.Empty;
			IsWindowsListo = new BooleanEvent();
			IsOffice2016Listo = new BooleanEvent();
			IsOffice2013Listo = new BooleanEvent();
			IsOffice2010Listo = new BooleanEvent();
			MoveCircularProgress = false;
			IsWindowsActivable = new BooleanEvent();
			IsOffice2016Activable = new BooleanEvent();
			IsOffice2013Activable = new BooleanEvent();
			IsOffice2010Activable = new BooleanEvent();
			IsWindowsChecked = new BooleanEvent();
			IsOffice2016Checked = new BooleanEvent();
			IsOffice2013Checked = new BooleanEvent();
			IsOffice2010Checked = new BooleanEvent();
			Tiempo = DateAndTime.get_Now();
			iactivateMetroForm_0 = null;
			RetailKeysWindows = new ArrayList();
			RetailKeysOffice2016 = new ArrayList();
			RetailKeysOffice2013 = new ArrayList();
			RutaOffice2016 = string.Empty;
			RutaOffice2013 = string.Empty;
			RutaOffice2010 = string.Empty;
			PlaySound = false;
			AudioVerified = null;
			AudioTransfer = null;
			AudioComplete = null;
			AudioBegin = null;
			AudioWarning = null;
			AudioDiagnostic = null;
			AudioAffirmative = null;
			AudioEnterAuthorizationCode = null;
			AudioIncomingTransmission = null;
			AudioProcessing = null;
			AudioInputOk = null;
			AudioInputFailed = null;
			Sonidos = new Stack<AudioFile>();
			ArgumentosConsola = Environment.GetCommandLineArgs();
			IsSilent = false;
			IsBackup = false;
			IsPaused = false;
			IsCheckStatus = false;
			IsGui = false;
			ActivadorIniciado = false;
			DirectorioBackupTokens = DirectorioActual + "\\TokensBackup";
			Logger = new FileLogger();
			ShowMessage = null;
			ProductName = string.Empty;
			EditionID = string.Empty;
			CurrentVersion = string.Empty;
			CurrentBuild = string.Empty;
			makeTask = false;
			noWin = false;
			no2016 = false;
			no2013 = false;
			no2010 = false;
			InternetConnection = false;
			RunAsService = false;
			GObjWmiService = new ManagementScope();
			KmsHostForward = new HostServer();
			KmsHostLocal = new HostServer();
			IntentosActivacion = 0;
			IntentosCheckWindows = 0;
			IntentosCheckOffice2016 = 0;
			IntentosCheckOffice2013 = 0;
			IntentosCheckOffice2010 = 0;
			IntentosWinDivert = 0;
			IntentosTunTap = 0;
			IntentosSecoh = 0;
			IsTapDriver = new BooleanEvent();
			IsTapDriverLoaded = false;
			IsWinDivert = new BooleanEvent();
			IsWinDivertLoaded = false;
			IsSecohQad = new BooleanEvent();
			IsSecohQadLoaded = false;
			SystemRoot = null;
			IsOnline = new BooleanEvent();
			ClientSettings = null;
			firewallPortOpened = false;
			firewallAppAdded = false;
			WaterMarkBasebrd = false;
			WaterMarkShell32 = false;
			IsWaterMarkRemove = false;
			IsWaterMarkRestore = false;
			Closing = false;
		}
	}
}
namespace AutoPico.Activador.WMI
{
	public class OfficeSoftwareProtectionProduct : Component
	{
		public class OfficeSoftwareProtectionProductCollection : ICollection
		{
			public class OfficeSoftwareProtectionProductEnumerator : IEnumerator
			{
				private ManagementObjectEnumerator managementObjectEnumerator_0;

				virtual object IEnumerator.Current => new OfficeSoftwareProtectionProduct((ManagementObject)managementObjectEnumerator_0.get_Current());

				public OfficeSoftwareProtectionProductEnumerator(ManagementObjectEnumerator objEnum)
				{
					managementObjectEnumerator_0 = objEnum;
				}

				public virtual bool MoveNext()
				{
					return managementObjectEnumerator_0.MoveNext();
				}

				public virtual void Reset()
				{
					managementObjectEnumerator_0.Reset();
				}
			}

			private ManagementObjectCollection managementObjectCollection_0;

			virtual int ICollection.Count => managementObjectCollection_0.get_Count();

			virtual bool ICollection.IsSynchronized => managementObjectCollection_0.get_IsSynchronized();

			virtual object ICollection.SyncRoot => this;

			public OfficeSoftwareProtectionProductCollection(ManagementObjectCollection objCollection)
			{
				managementObjectCollection_0 = objCollection;
			}

			public virtual void CopyTo(Array array, int index)
			{
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				managementObjectCollection_0.CopyTo(array, index);
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					array.SetValue(new OfficeSoftwareProtectionProduct((ManagementObject)array.GetValue(i)), i);
				}
			}

			public virtual IEnumerator GetEnumerator()
			{
				return new OfficeSoftwareProtectionProductEnumerator(managementObjectCollection_0.GetEnumerator());
			}
		}

		public class WMIValueTypeConverter : TypeConverter
		{
			private TypeConverter typeConverter_0;

			private Type type_0;

			public WMIValueTypeConverter(Type inBaseType)
				: this()
			{
				typeConverter_0 = TypeDescriptor.GetConverter(inBaseType);
				type_0 = inBaseType;
			}

			public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
			{
				return typeConverter_0.CanConvertFrom(context, srcType);
			}

			public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			{
				return typeConverter_0.CanConvertTo(context, destinationType);
			}

			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				return typeConverter_0.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value));
			}

			public override object CreateInstance(ITypeDescriptorContext context, IDictionary dictionary)
			{
				return typeConverter_0.CreateInstance(context, dictionary);
			}

			public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetCreateInstanceSupported(context);
			}

			public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributeVar)
			{
				return typeConverter_0.GetProperties(context, RuntimeHelpers.GetObjectValue(value), attributeVar);
			}

			public override bool GetPropertiesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetPropertiesSupported(context);
			}

			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValues(context);
			}

			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesExclusive(context);
			}

			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesSupported(context);
			}

			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if ((object)type_0.BaseType == typeof(Enum))
				{
					if ((object)value.GetType() == destinationType)
					{
						return value;
					}
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "NULL_ENUM_VALUE";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if ((object)type_0 == typeof(bool) && (object)type_0.BaseType == typeof(ValueType))
				{
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if (context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
				{
					return "";
				}
				return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
			}
		}

		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class ManagementSystemProperties
		{
			private ManagementBaseObject managementBaseObject_0;

			[Browsable(true)]
			public int GENUS => Conversions.ToInteger(managementBaseObject_0.get_Item("__GENUS"));

			[Browsable(true)]
			public string CLASS => Conversions.ToString(managementBaseObject_0.get_Item("__CLASS"));

			[Browsable(true)]
			public string SUPERCLASS => Conversions.ToString(managementBaseObject_0.get_Item("__SUPERCLASS"));

			[Browsable(true)]
			public string DYNASTY => Conversions.ToString(managementBaseObject_0.get_Item("__DYNASTY"));

			[Browsable(true)]
			public string RELPATH => Conversions.ToString(managementBaseObject_0.get_Item("__RELPATH"));

			[Browsable(true)]
			public int PROPERTY_COUNT => Conversions.ToInteger(managementBaseObject_0.get_Item("__PROPERTY_COUNT"));

			[Browsable(true)]
			public string[] DERIVATION => (string[])managementBaseObject_0.get_Item("__DERIVATION");

			[Browsable(true)]
			public string SERVER => Conversions.ToString(managementBaseObject_0.get_Item("__SERVER"));

			[Browsable(true)]
			public string NAMESPACE => Conversions.ToString(managementBaseObject_0.get_Item("__NAMESPACE"));

			[Browsable(true)]
			public string PATH => Conversions.ToString(managementBaseObject_0.get_Item("__PATH"));

			public ManagementSystemProperties(ManagementBaseObject ManagedObject)
			{
				managementBaseObject_0 = ManagedObject;
			}
		}

		private static string string_0 = "root\\CimV2";

		private static string string_1 = "OfficeSoftwareProtectionProduct";

		private static ManagementScope managementScope_0 = null;

		private ManagementSystemProperties managementSystemProperties_0;

		private ManagementObject managementObject_0;

		private bool bool_0;

		private ManagementBaseObject managementBaseObject_0;

		private ManagementBaseObject managementBaseObject_1;

		private bool bool_1;

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string OriginatingNamespace => "root\\CimV2";

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string ManagementClassName
		{
			get
			{
				string text = string_1;
				if (managementBaseObject_1 != null && managementBaseObject_1.get_ClassPath() != null)
				{
					text = Conversions.ToString(managementBaseObject_1.get_Item("__CLASS"));
					if (text == null || (object)text == string.Empty)
					{
						text = string_1;
					}
				}
				return text;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementSystemProperties SystemProperties => managementSystemProperties_0;

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementBaseObject LateBoundObject => managementBaseObject_1;

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementScope Scope
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Scope();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					managementObject_0.set_Scope(value);
				}
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool AutoCommit
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		[Browsable(true)]
		public ManagementPath Path
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Path();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					if (!method_0(null, value, null))
					{
						throw new ArgumentException("El nombre de clase no coincide.");
					}
					managementObject_0.set_Path(value);
				}
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public static ManagementScope StaticScope
		{
			get
			{
				return managementScope_0;
			}
			set
			{
				managementScope_0 = value;
			}
		}

		[Browsable(true)]
		[Description("ID of current product's Application")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ApplicationID => Conversions.ToString(managementBaseObject_1.get_Item("ApplicationID"));

		[Description("Product Description")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string Description => Conversions.ToString(managementBaseObject_1.get_Item("Description"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Last discovered KMS host name through DNS.")]
		public string DiscoveredKeyManagementServiceMachineName => Conversions.ToString(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachineName"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsDiscoveredKeyManagementServiceMachinePortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Last discovered KMS host port through DNS.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		public uint DiscoveredKeyManagementServiceMachinePort
		{
			get
			{
				if (managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsEvaluationEndDateNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("EvaluationEndDate") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The expiration date of this product's application.  After this date, the LicenseStatus will be Unlicensed, and cannot be Activated.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public DateTime EvaluationEndDate
		{
			get
			{
				if (managementBaseObject_1.get_Item("EvaluationEndDate") != null)
				{
					return ToDateTime(Conversions.ToString(managementBaseObject_1.get_Item("EvaluationEndDate")));
				}
				return DateTime.MinValue;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsExtendedGraceNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("ExtendedGrace") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Extended grace time in minutes before the parent application becomes unlicensed.")]
		[Browsable(true)]
		public uint ExtendedGrace
		{
			get
			{
				if (managementBaseObject_1.get_Item("ExtendedGrace") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("ExtendedGrace"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsGenuineStatusNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("GenuineStatus") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Genuine status for this product.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint GenuineStatus
		{
			get
			{
				if (managementBaseObject_1.get_Item("GenuineStatus") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("GenuineStatus"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsGracePeriodRemainingNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("GracePeriodRemaining") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Remaining time in minutes before the parent application becomes unlicensed.  For KMS clients, this is the remaining time before re-Activation is required.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint GracePeriodRemaining
		{
			get
			{
				if (managementBaseObject_1.get_Item("GracePeriodRemaining") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("GracePeriodRemaining"));
			}
		}

		[Description("Product Identifier")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ID => Conversions.ToString(managementBaseObject_1.get_Item("ID"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsIsKeyManagementServiceMachineNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Indicates if KMS is enabled on the computer: 1 if true, 0 if false.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint IsKeyManagementServiceMachine
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("IsKeyManagementServiceMachine"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceCurrentCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The count of currently active KMS clients on the KMS host. -1 indicates the host is not enabled as a KMS, or has not received any client licensing-requests.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceCurrentCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceFailedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The total count of failed KMS requests.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceFailedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceLicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("The count of KMS requests from clients with License Status=1 (Licensed).")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceLicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests"));
			}
		}

		[Description("The name of the KMS host. Returns null if SetKeyManagementServiceMachine has not been called.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string KeyManagementServiceMachine => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceMachine"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceNonGenuineGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[Description("The count of KMS requests from clients with License Status=4 (NonGenuineGrace).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint KeyManagementServiceNonGenuineGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceNotificationRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The count of KMS requests from clients with License Status=5 (Notification).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceNotificationRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceOOBGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[Description("The count of KMS requests from clients with License Status=2 (OOBGrace).")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint KeyManagementServiceOOBGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceOOTGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("The count of KMS requests from clients with License Status=3 (OOTGrace).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceOOTGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServicePortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("The TCP port used by clients to send KMS-activation requests. Returns 0 if SetKeyManagementServicePort has not been called.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServicePort
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServicePort"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("KMS product key ID. Returns null if not applicable.")]
		[Browsable(true)]
		public string KeyManagementServiceProductKeyID => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceProductKeyID"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceTotalRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The total count of valid KMS requests.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceTotalRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceUnlicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("The count of KMS requests from clients with License Status=0 (Unlicensed).")]
		public uint KeyManagementServiceUnlicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests"));
			}
		}

		[Browsable(true)]
		[Description("The dependency identifier for the family of SKUs used to determine license relationships for add-ons.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string LicenseDependsOn => Conversions.ToString(managementBaseObject_1.get_Item("LicenseDependsOn"));

		[Description("The family identifier for the SKU used to determine license relationships for add-ons.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string LicenseFamily => Conversions.ToString(managementBaseObject_1.get_Item("LicenseFamily"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsLicenseIsAddonNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseIsAddon") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Returns True if the product is identified as an add-on license.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public bool LicenseIsAddon
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseIsAddon") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("LicenseIsAddon"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsLicenseStatusNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatus") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("License status of this product's application.  0=Unlicensed, 1=Licensed, 2=OOBGrace, 3=OOTGrace, 4=NonGenuineGrace, 5=Notification.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint LicenseStatus
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatus") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("LicenseStatus"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsLicenseStatusReasonNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatusReason") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("A diagnostic code which indicates why a computer is in a specific licensing state.")]
		public uint LicenseStatusReason
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatusReason") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("LicenseStatusReason"));
			}
		}

		[Description("Software licensing server URL for the binding certificate")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string MachineURL => Conversions.ToString(managementBaseObject_1.get_Item("MachineURL"));

		[Browsable(true)]
		[Description("Product Name")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string Name => Conversions.ToString(managementBaseObject_1.get_Item("Name"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("An identifier for this product's application that can be used for telephone or offline activation. Returns null if a product key is not installed.")]
		public string OfflineInstallationId => Conversions.ToString(managementBaseObject_1.get_Item("OfflineInstallationId"));

		[Description("Last five characters of this product's key. Returns null if a product key is not installed.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string PartialProductKey => Conversions.ToString(managementBaseObject_1.get_Item("PartialProductKey"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Software licensing server URL for the process certificate")]
		public string ProcessorURL => Conversions.ToString(managementBaseObject_1.get_Item("ProcessorURL"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Product key ID. Returns null if a product key is not installed.")]
		public string ProductKeyID => Conversions.ToString(managementBaseObject_1.get_Item("ProductKeyID"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Software licensing server URL for the product certificate")]
		public string ProductKeyURL => Conversions.ToString(managementBaseObject_1.get_Item("ProductKeyURL"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsRequiredClientCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("The minimum number of clients required to connect to a KMS host in order to enable volume licensing.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint RequiredClientCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("RequiredClientCount"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Additional information for token-based activation.")]
		[Browsable(true)]
		public string TokenActivationAdditionalInfo => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationAdditionalInfo"));

		[Description("Thumbprint of the certificate that activated the product.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string TokenActivationCertificateThumbprint => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationCertificateThumbprint"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsTokenActivationGrantNumberNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationGrantNumber") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Grant number in the token-based activation license that activated the product.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		public uint TokenActivationGrantNumber
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationGrantNumber") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("TokenActivationGrantNumber"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("ID of the token-based activation license that activated the product.")]
		[Browsable(true)]
		public string TokenActivationILID => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationILID"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsTokenActivationILVIDNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationILVID") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[Description("Version of the token-based activation license that activated the product.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint TokenActivationILVID
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationILVID") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("TokenActivationILVID"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsTrustedTimeNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TrustedTime") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("The trusted time for the product.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public DateTime TrustedTime
		{
			get
			{
				if (managementBaseObject_1.get_Item("TrustedTime") != null)
				{
					return ToDateTime(Conversions.ToString(managementBaseObject_1.get_Item("TrustedTime")));
				}
				return DateTime.MinValue;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Software licensing server URL for the user license")]
		public string UseLicenseURL => Conversions.ToString(managementBaseObject_1.get_Item("UseLicenseURL"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsVLActivationIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The frequency, in minutes, of how often a client will contact the KMS host before the product is licensed.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLActivationInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLActivationInterval"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsVLRenewalIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("The frequency, in minutes, of how often a client will contact the KMS host after the product is licensed.")]
		public uint VLRenewalInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLRenewalInterval"));
			}
		}

		public OfficeSoftwareProtectionProduct()
			: this()
		{
			method_28(null, null, null);
		}

		public OfficeSoftwareProtectionProduct(string keyID)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_28(null, new ManagementPath(smethod_0(keyID)), null);
		}

		public OfficeSoftwareProtectionProduct(ManagementScope mgmtScope, string keyID)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_28(mgmtScope, new ManagementPath(smethod_0(keyID)), null);
		}

		public OfficeSoftwareProtectionProduct(ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_28(null, path, getOptions);
		}

		public OfficeSoftwareProtectionProduct(ManagementScope mgmtScope, ManagementPath path)
			: this()
		{
			method_28(mgmtScope, path, null);
		}

		public OfficeSoftwareProtectionProduct(ManagementPath path)
			: this()
		{
			method_28(null, path, null);
		}

		public OfficeSoftwareProtectionProduct(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_28(mgmtScope, path, getOptions);
		}

		public OfficeSoftwareProtectionProduct(ManagementObject theObject)
			: this()
		{
			method_27();
			if (!method_1((ManagementBaseObject)(object)theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public OfficeSoftwareProtectionProduct(ManagementBaseObject theObject)
			: this()
		{
			method_27();
			if (!method_1(theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementBaseObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties(theObject);
			managementBaseObject_1 = managementBaseObject_0;
			bool_1 = true;
		}

		private bool method_0(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			if (managementPath_0 != null && string.Compare(managementPath_0.get_ClassName(), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			return method_1((ManagementBaseObject)new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0));
		}

		private bool method_1(ManagementBaseObject managementBaseObject_2)
		{
			if (managementBaseObject_2 != null && string.Compare(Conversions.ToString(managementBaseObject_2.get_Item("__CLASS")), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			Array array = (Array)managementBaseObject_2.get_Item("__DERIVATION");
			if (array != null)
			{
				int num = 0;
				for (num = 0; num < array.Length; num = checked(num + 1))
				{
					if (string.Compare(Conversions.ToString(array.GetValue(num)), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool method_2()
		{
			if (!IsDiscoveredKeyManagementServiceMachinePortNull)
			{
				return true;
			}
			return false;
		}

		public static DateTime ToDateTime(string dmtfDate)
		{
			DateTime minValue = DateTime.MinValue;
			int num = minValue.Year;
			int num2 = minValue.Month;
			int num3 = minValue.Day;
			int num4 = minValue.Hour;
			int num5 = minValue.Minute;
			int num6 = minValue.Second;
			long num7 = 0L;
			DateTime minValue2 = DateTime.MinValue;
			string empty = string.Empty;
			if (dmtfDate == null)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (dmtfDate.Length == 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (dmtfDate.Length != 25)
			{
				throw new ArgumentOutOfRangeException();
			}
			checked
			{
				try
				{
					empty = dmtfDate.Substring(0, 4);
					if (Operators.CompareString("****", empty, false) != 0)
					{
						num = int.Parse(empty);
					}
					empty = dmtfDate.Substring(4, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num2 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(6, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num3 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(8, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num4 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(10, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num5 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(12, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num6 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(15, 6);
					if (Operators.CompareString("******", empty, false) != 0)
					{
						num7 = long.Parse(empty) * 10L;
					}
					if (num < 0 || num2 < 0 || num3 < 0 || num4 < 0 || num5 < 0 || num5 < 0 || num6 < 0 || num7 < 0L)
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					throw new ArgumentOutOfRangeException(null, ex2.Message);
				}
				minValue2 = new DateTime(num, num2, num3, num4, num5, num6, 0).AddTicks(num7);
				TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(minValue2);
				int num8 = 0;
				int num9 = 0;
				long num10 = (long)Math.Round((double)utcOffset.Ticks / 600000000.0);
				empty = dmtfDate.Substring(22, 3);
				if (Operators.CompareString(empty, "******", false) != 0)
				{
					empty = dmtfDate.Substring(21, 4);
					try
					{
						num8 = int.Parse(empty);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						throw new ArgumentOutOfRangeException(null, ex4.Message);
					}
					num9 = (int)(num10 - num8);
					minValue2 = minValue2.AddMinutes(num9);
				}
				return minValue2;
			}
		}

		public static string ToDmtfDateTime(DateTime date)
		{
			string empty = string.Empty;
			TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(date);
			checked
			{
				long value = (long)Math.Round((double)utcOffset.Ticks / 600000000.0);
				if (Math.Abs(value) > 999L)
				{
					date = date.ToUniversalTime();
					empty = "+000";
				}
				else if (utcOffset.Ticks >= 0L)
				{
					empty = "+" + ((long)Math.Round((double)utcOffset.Ticks / 600000000.0)).ToString().PadLeft(3, '0');
				}
				else
				{
					string text = value.ToString();
					empty = "-" + text.Substring(1, text.Length - 1).PadLeft(3, '0');
				}
				string str = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(date.Year.ToString().PadLeft(4, '0') + date.Month.ToString().PadLeft(2, '0'), date.Day.ToString().PadLeft(2, '0')), date.Hour.ToString().PadLeft(2, '0')), date.Minute.ToString().PadLeft(2, '0')), date.Second.ToString().PadLeft(2, '0')), ".");
				DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
				string text2 = ((long)Math.Round((double)((date.Ticks - dateTime.Ticks) * 1000L) / 10000.0)).ToString();
				if (text2.Length > 6)
				{
					text2 = text2.Substring(0, 6);
				}
				return string.Concat(str + text2.PadLeft(6, '0'), empty);
			}
		}

		private bool method_3()
		{
			if (!IsEvaluationEndDateNull)
			{
				return true;
			}
			return false;
		}

		private bool method_4()
		{
			if (!IsExtendedGraceNull)
			{
				return true;
			}
			return false;
		}

		private bool method_5()
		{
			if (!IsGenuineStatusNull)
			{
				return true;
			}
			return false;
		}

		private bool method_6()
		{
			if (!IsGracePeriodRemainingNull)
			{
				return true;
			}
			return false;
		}

		private bool method_7()
		{
			if (!IsIsKeyManagementServiceMachineNull)
			{
				return true;
			}
			return false;
		}

		private bool method_8()
		{
			if (!IsKeyManagementServiceCurrentCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_9()
		{
			if (!IsKeyManagementServiceFailedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_10()
		{
			if (!IsKeyManagementServiceLicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_11()
		{
			if (!IsKeyManagementServiceNonGenuineGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_12()
		{
			if (!IsKeyManagementServiceNotificationRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_13()
		{
			if (!IsKeyManagementServiceOOBGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_14()
		{
			if (!IsKeyManagementServiceOOTGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_15()
		{
			if (!IsKeyManagementServicePortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_16()
		{
			if (!IsKeyManagementServiceTotalRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_17()
		{
			if (!IsKeyManagementServiceUnlicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_18()
		{
			if (!IsLicenseIsAddonNull)
			{
				return true;
			}
			return false;
		}

		private bool method_19()
		{
			if (!IsLicenseStatusNull)
			{
				return true;
			}
			return false;
		}

		private bool method_20()
		{
			if (!IsLicenseStatusReasonNull)
			{
				return true;
			}
			return false;
		}

		private bool method_21()
		{
			if (!IsRequiredClientCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_22()
		{
			if (!IsTokenActivationGrantNumberNull)
			{
				return true;
			}
			return false;
		}

		private bool method_23()
		{
			if (!IsTokenActivationILVIDNull)
			{
				return true;
			}
			return false;
		}

		private bool method_24()
		{
			if (!IsTrustedTimeNull)
			{
				return true;
			}
			return false;
		}

		private bool method_25()
		{
			if (!IsVLActivationIntervalNull)
			{
				return true;
			}
			return false;
		}

		private bool method_26()
		{
			if (!IsVLRenewalIntervalNull)
			{
				return true;
			}
			return false;
		}

		[Browsable(true)]
		public void CommitObject()
		{
			if (!bool_1)
			{
				managementObject_0.Put();
			}
		}

		[Browsable(true)]
		public void CommitObject(PutOptions putOptions)
		{
			if (!bool_1)
			{
				managementObject_0.Put(putOptions);
			}
		}

		private void method_27()
		{
			bool_0 = true;
			bool_1 = false;
		}

		private static string smethod_0(string string_2)
		{
			return string.Concat("root\\CimV2:OfficeSoftwareProtectionProduct", string.Concat(".ID=", string.Concat("\"", string_2 + "\"")));
		}

		private void method_28(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			method_27();
			if (managementPath_0 != null && !method_0(managementScope_1, managementPath_0, objectGetOptions_0))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0);
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances()
		{
			return GetInstances(null, null, null);
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances(string condition)
		{
			return GetInstances(null, condition, null);
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances(string[] selectedProperties)
		{
			return GetInstances(null, null, selectedProperties);
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances(string condition, string[] selectedProperties)
		{
			return GetInstances(null, condition, selectedProperties);
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementPath val = new ManagementPath();
			val.set_ClassName("OfficeSoftwareProtectionProduct");
			val.set_NamespacePath("root\\CimV2");
			ManagementClass val2 = new ManagementClass(mgmtScope, val, (ObjectGetOptions)null);
			if (enumOptions == null)
			{
				enumOptions = new EnumerationOptions();
				enumOptions.set_EnsureLocatable(true);
			}
			return new OfficeSoftwareProtectionProductCollection(val2.GetInstances(enumOptions));
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances(ManagementScope mgmtScope, string condition)
		{
			return GetInstances(mgmtScope, condition, null);
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances(ManagementScope mgmtScope, string[] selectedProperties)
		{
			return GetInstances(mgmtScope, null, selectedProperties);
		}

		public static OfficeSoftwareProtectionProductCollection GetInstances(ManagementScope mgmtScope, string condition, string[] selectedProperties)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementObjectSearcher val = new ManagementObjectSearcher(mgmtScope, (ObjectQuery)new SelectQuery("OfficeSoftwareProtectionProduct", condition, selectedProperties));
			EnumerationOptions val2 = new EnumerationOptions();
			val2.set_EnsureLocatable(true);
			val.set_Options(val2);
			return new OfficeSoftwareProtectionProductCollection(val.Get());
		}

		[Browsable(true)]
		public static OfficeSoftwareProtectionProduct CreateInstance()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			ManagementScope val = null;
			if (managementScope_0 == null)
			{
				val = new ManagementScope();
				val.get_Path().set_NamespacePath(string_0);
			}
			else
			{
				val = managementScope_0;
			}
			ManagementPath val2 = new ManagementPath(string_1);
			ManagementClass val3 = new ManagementClass(val, val2, (ObjectGetOptions)null);
			return new OfficeSoftwareProtectionProduct(val3.CreateInstance());
		}

		[Browsable(true)]
		public void Delete()
		{
			managementObject_0.Delete();
		}

		public uint Activate()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("Activate", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceMachine()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServicePort()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DepositOfflineConfirmationId(string ConfirmationId, string InstallationId)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DepositOfflineConfirmationId");
				val.set_Item("ConfirmationId", (object)ConfirmationId);
				val.set_Item("InstallationId", (object)InstallationId);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DepositOfflineConfirmationId", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DepositTokenActivationResponse(string CertChain, string Challenge, string Response)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DepositTokenActivationResponse");
				val.set_Item("CertChain", (object)CertChain);
				val.set_Item("Challenge", (object)Challenge);
				val.set_Item("Response", (object)Response);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DepositTokenActivationResponse", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint GenerateTokenActivationChallenge(ref string Challenge)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GenerateTokenActivationChallenge", val, (InvokeMethodOptions)null);
				Challenge = Convert.ToString(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("Challenge").get_Value()));
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			Challenge = null;
			return Convert.ToUInt32(0);
		}

		public uint GetPolicyInformationDWord(string PolicyName, ref uint PolicyValue)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("GetPolicyInformationDWord");
				val.set_Item("PolicyName", (object)PolicyName);
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GetPolicyInformationDWord", val, (InvokeMethodOptions)null);
				PolicyValue = Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("PolicyValue").get_Value()));
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			PolicyValue = Convert.ToUInt32(0);
			return Convert.ToUInt32(0);
		}

		public uint GetPolicyInformationString(string PolicyName, ref string PolicyValue)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("GetPolicyInformationString");
				val.set_Item("PolicyName", (object)PolicyName);
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GetPolicyInformationString", val, (InvokeMethodOptions)null);
				PolicyValue = Convert.ToString(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("PolicyValue").get_Value()));
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			PolicyValue = null;
			return Convert.ToUInt32(0);
		}

		public uint GetTokenActivationGrants(ref string[] Grants)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GetTokenActivationGrants", val, (InvokeMethodOptions)null);
				Grants = (string[])val2.get_Properties().get_Item("Grants").get_Value();
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			Grants = null;
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceMachine(string MachineName)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceMachine");
				val.set_Item("MachineName", (object)MachineName);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServicePort(uint PortNumber)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServicePort");
				val.set_Item("PortNumber", (object)PortNumber);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint UninstallProductKey()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("UninstallProductKey", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}
	}
	public class OfficeSoftwareProtectionService : Component
	{
		public class OfficeSoftwareProtectionServiceCollection : ICollection
		{
			public class OfficeSoftwareProtectionServiceEnumerator : IEnumerator
			{
				private ManagementObjectEnumerator managementObjectEnumerator_0;

				virtual object IEnumerator.Current => new OfficeSoftwareProtectionService((ManagementObject)managementObjectEnumerator_0.get_Current());

				public OfficeSoftwareProtectionServiceEnumerator(ManagementObjectEnumerator objEnum)
				{
					managementObjectEnumerator_0 = objEnum;
				}

				public virtual bool MoveNext()
				{
					return managementObjectEnumerator_0.MoveNext();
				}

				public virtual void Reset()
				{
					managementObjectEnumerator_0.Reset();
				}
			}

			private ManagementObjectCollection managementObjectCollection_0;

			virtual int ICollection.Count => managementObjectCollection_0.get_Count();

			virtual bool ICollection.IsSynchronized => managementObjectCollection_0.get_IsSynchronized();

			virtual object ICollection.SyncRoot => this;

			public OfficeSoftwareProtectionServiceCollection(ManagementObjectCollection objCollection)
			{
				managementObjectCollection_0 = objCollection;
			}

			public virtual void CopyTo(Array array, int index)
			{
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				managementObjectCollection_0.CopyTo(array, index);
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					array.SetValue(new OfficeSoftwareProtectionService((ManagementObject)array.GetValue(i)), i);
				}
			}

			public virtual IEnumerator GetEnumerator()
			{
				return new OfficeSoftwareProtectionServiceEnumerator(managementObjectCollection_0.GetEnumerator());
			}
		}

		public class WMIValueTypeConverter : TypeConverter
		{
			private TypeConverter typeConverter_0;

			private Type type_0;

			public WMIValueTypeConverter(Type inBaseType)
				: this()
			{
				typeConverter_0 = TypeDescriptor.GetConverter(inBaseType);
				type_0 = inBaseType;
			}

			public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
			{
				return typeConverter_0.CanConvertFrom(context, srcType);
			}

			public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			{
				return typeConverter_0.CanConvertTo(context, destinationType);
			}

			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				return typeConverter_0.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value));
			}

			public override object CreateInstance(ITypeDescriptorContext context, IDictionary dictionary)
			{
				return typeConverter_0.CreateInstance(context, dictionary);
			}

			public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetCreateInstanceSupported(context);
			}

			public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributeVar)
			{
				return typeConverter_0.GetProperties(context, RuntimeHelpers.GetObjectValue(value), attributeVar);
			}

			public override bool GetPropertiesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetPropertiesSupported(context);
			}

			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValues(context);
			}

			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesExclusive(context);
			}

			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesSupported(context);
			}

			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if ((object)type_0.BaseType == typeof(Enum))
				{
					if ((object)value.GetType() == destinationType)
					{
						return value;
					}
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "NULL_ENUM_VALUE";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if ((object)type_0 == typeof(bool) && (object)type_0.BaseType == typeof(ValueType))
				{
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if (context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
				{
					return "";
				}
				return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
			}
		}

		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class ManagementSystemProperties
		{
			private ManagementBaseObject managementBaseObject_0;

			[Browsable(true)]
			public int GENUS => Conversions.ToInteger(managementBaseObject_0.get_Item("__GENUS"));

			[Browsable(true)]
			public string CLASS => Conversions.ToString(managementBaseObject_0.get_Item("__CLASS"));

			[Browsable(true)]
			public string SUPERCLASS => Conversions.ToString(managementBaseObject_0.get_Item("__SUPERCLASS"));

			[Browsable(true)]
			public string DYNASTY => Conversions.ToString(managementBaseObject_0.get_Item("__DYNASTY"));

			[Browsable(true)]
			public string RELPATH => Conversions.ToString(managementBaseObject_0.get_Item("__RELPATH"));

			[Browsable(true)]
			public int PROPERTY_COUNT => Conversions.ToInteger(managementBaseObject_0.get_Item("__PROPERTY_COUNT"));

			[Browsable(true)]
			public string[] DERIVATION => (string[])managementBaseObject_0.get_Item("__DERIVATION");

			[Browsable(true)]
			public string SERVER => Conversions.ToString(managementBaseObject_0.get_Item("__SERVER"));

			[Browsable(true)]
			public string NAMESPACE => Conversions.ToString(managementBaseObject_0.get_Item("__NAMESPACE"));

			[Browsable(true)]
			public string PATH => Conversions.ToString(managementBaseObject_0.get_Item("__PATH"));

			public ManagementSystemProperties(ManagementBaseObject ManagedObject)
			{
				managementBaseObject_0 = ManagedObject;
			}
		}

		private static string string_0 = "root\\CimV2";

		private static string string_1 = "OfficeSoftwareProtectionService";

		private static ManagementScope managementScope_0 = null;

		private ManagementSystemProperties managementSystemProperties_0;

		private ManagementObject managementObject_0;

		private bool bool_0;

		private ManagementBaseObject managementBaseObject_0;

		private ManagementBaseObject managementBaseObject_1;

		private bool bool_1;

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string OriginatingNamespace => "root\\CimV2";

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ManagementClassName
		{
			get
			{
				string text = string_1;
				if (managementBaseObject_1 != null && managementBaseObject_1.get_ClassPath() != null)
				{
					text = Conversions.ToString(managementBaseObject_1.get_Item("__CLASS"));
					if (text == null || (object)text == string.Empty)
					{
						text = string_1;
					}
				}
				return text;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementSystemProperties SystemProperties => managementSystemProperties_0;

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementBaseObject LateBoundObject => managementBaseObject_1;

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementScope Scope
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Scope();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					managementObject_0.set_Scope(value);
				}
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool AutoCommit
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		[Browsable(true)]
		public ManagementPath Path
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Path();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					if (!method_0(null, value, null))
					{
						throw new ArgumentException("El nombre de clase no coincide.");
					}
					managementObject_0.set_Path(value);
				}
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public static ManagementScope StaticScope
		{
			get
			{
				return managementScope_0;
			}
			set
			{
				managementScope_0 = value;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("The GUID that identifies a KMS client to a KMS host. The client includes this in requests it sends to the KMS.")]
		public string ClientMachineID => Conversions.ToString(managementBaseObject_1.get_Item("ClientMachineID"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsIsKeyManagementServiceMachineNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[Description("Indicates whether KMS is enabled on the computer: 0 if false, 1 if true.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint IsKeyManagementServiceMachine
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("IsKeyManagementServiceMachine"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceActivationDisabledNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceActivationDisabled") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Indicates whether the volume activation through key management service is disabled.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool KeyManagementServiceActivationDisabled
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceActivationDisabled") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("KeyManagementServiceActivationDisabled"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceCurrentCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("The count of currently active KMS clients on the KMS host. -1 indicates the computer is not enabled as a KMS, or has not received any client licensing-requests.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		public uint KeyManagementServiceCurrentCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceDnsPublishingNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceDnsPublishing") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Indicates the DNS publishing status of a KMS host: 0=Disabled, 1=Auto publish enabled (default).")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool KeyManagementServiceDnsPublishing
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceDnsPublishing") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("KeyManagementServiceDnsPublishing"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceFailedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("The count of invalid KMS requests.")]
		public uint KeyManagementServiceFailedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceHostCachingNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceHostCaching") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Indicates the caching status of KMS host name and port: 0=Caching disabled, 1=Caching enabled (default).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public bool KeyManagementServiceHostCaching
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceHostCaching") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("KeyManagementServiceHostCaching"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceLicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The count of KMS requests from clients with License Status=1 (Licensed).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceLicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceListeningPortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceListeningPort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The TCP port the KMS host uses to listen for activation requests.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceListeningPort
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceListeningPort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceListeningPort"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceLowPriorityNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLowPriority") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Indicates the thread priority status of KMS service: 0=Normal Priority (default), 1=Low priority.")]
		public bool KeyManagementServiceLowPriority
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLowPriority") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("KeyManagementServiceLowPriority"));
			}
		}

		[Description("The name of the KMS host. Returns null if SetKeyManagementServiceMachine has not been called.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string KeyManagementServiceMachine => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceMachine"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceNonGenuineGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The count of KMS requests from clients with License Status=4 (NonGenuineGrace).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceNonGenuineGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceNotificationRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("The count of KMS requests from clients with License Status=5 (Notification).")]
		public uint KeyManagementServiceNotificationRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceOOBGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The count of KMS requests from clients with License Status=2 (OOBGrace).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceOOBGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceOOTGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The count of KMS requests from clients with License Status=3 (OOTGrace).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceOOTGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServicePortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The TCP port used by clients to send KMS-activation requests. Returns 0 if SetKeyManagementServicePort has not been called.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServicePort
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServicePort"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceTotalRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("The total count of valid KMS requests.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		public uint KeyManagementServiceTotalRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceUnlicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("The count of KMS requests from clients with License Status=0 (Unlicensed).")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceUnlicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsPolicyCacheRefreshRequiredNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("PolicyCacheRefreshRequired") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Indicates whether the licensing policy-cache needs to be updated: 0=not required, 1=Refresh required.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint PolicyCacheRefreshRequired
		{
			get
			{
				if (managementBaseObject_1.get_Item("PolicyCacheRefreshRequired") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("PolicyCacheRefreshRequired"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsRequiredClientCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The minimum number of clients required to connect to a KMS host in order to enable volume licensing.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint RequiredClientCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("RequiredClientCount"));
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Version of the Software Licensing service")]
		public string Version => Conversions.ToString(managementBaseObject_1.get_Item("Version"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsVLActivationIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("The frequency, in minutes, of how often a client will contact the KMS host before the client is licensed.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLActivationInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLActivationInterval"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsVLRenewalIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("The frequency, in minutes, of how often a client will contact the KMS host after the client is licensed.")]
		public uint VLRenewalInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLRenewalInterval"));
			}
		}

		public OfficeSoftwareProtectionService()
			: this()
		{
			method_23(null, null, null);
		}

		public OfficeSoftwareProtectionService(string keyVersion)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_23(null, new ManagementPath(smethod_0(keyVersion)), null);
		}

		public OfficeSoftwareProtectionService(ManagementScope mgmtScope, string keyVersion)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_23(mgmtScope, new ManagementPath(smethod_0(keyVersion)), null);
		}

		public OfficeSoftwareProtectionService(ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_23(null, path, getOptions);
		}

		public OfficeSoftwareProtectionService(ManagementScope mgmtScope, ManagementPath path)
			: this()
		{
			method_23(mgmtScope, path, null);
		}

		public OfficeSoftwareProtectionService(ManagementPath path)
			: this()
		{
			method_23(null, path, null);
		}

		public OfficeSoftwareProtectionService(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_23(mgmtScope, path, getOptions);
		}

		public OfficeSoftwareProtectionService(ManagementObject theObject)
			: this()
		{
			method_22();
			if (!method_1((ManagementBaseObject)(object)theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public OfficeSoftwareProtectionService(ManagementBaseObject theObject)
			: this()
		{
			method_22();
			if (!method_1(theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementBaseObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties(theObject);
			managementBaseObject_1 = managementBaseObject_0;
			bool_1 = true;
		}

		private bool method_0(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			if (managementPath_0 != null && string.Compare(managementPath_0.get_ClassName(), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			return method_1((ManagementBaseObject)new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0));
		}

		private bool method_1(ManagementBaseObject managementBaseObject_2)
		{
			if (managementBaseObject_2 != null && string.Compare(Conversions.ToString(managementBaseObject_2.get_Item("__CLASS")), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			Array array = (Array)managementBaseObject_2.get_Item("__DERIVATION");
			if (array != null)
			{
				int num = 0;
				for (num = 0; num < array.Length; num = checked(num + 1))
				{
					if (string.Compare(Conversions.ToString(array.GetValue(num)), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool method_2()
		{
			if (!IsIsKeyManagementServiceMachineNull)
			{
				return true;
			}
			return false;
		}

		private bool method_3()
		{
			if (!IsKeyManagementServiceActivationDisabledNull)
			{
				return true;
			}
			return false;
		}

		private bool method_4()
		{
			if (!IsKeyManagementServiceCurrentCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_5()
		{
			if (!IsKeyManagementServiceDnsPublishingNull)
			{
				return true;
			}
			return false;
		}

		private bool method_6()
		{
			if (!IsKeyManagementServiceFailedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_7()
		{
			if (!IsKeyManagementServiceHostCachingNull)
			{
				return true;
			}
			return false;
		}

		private bool method_8()
		{
			if (!IsKeyManagementServiceLicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_9()
		{
			if (!IsKeyManagementServiceListeningPortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_10()
		{
			if (!IsKeyManagementServiceLowPriorityNull)
			{
				return true;
			}
			return false;
		}

		private bool method_11()
		{
			if (!IsKeyManagementServiceNonGenuineGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_12()
		{
			if (!IsKeyManagementServiceNotificationRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_13()
		{
			if (!IsKeyManagementServiceOOBGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_14()
		{
			if (!IsKeyManagementServiceOOTGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_15()
		{
			if (!IsKeyManagementServicePortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_16()
		{
			if (!IsKeyManagementServiceTotalRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_17()
		{
			if (!IsKeyManagementServiceUnlicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_18()
		{
			if (!IsPolicyCacheRefreshRequiredNull)
			{
				return true;
			}
			return false;
		}

		private bool method_19()
		{
			if (!IsRequiredClientCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_20()
		{
			if (!IsVLActivationIntervalNull)
			{
				return true;
			}
			return false;
		}

		private bool method_21()
		{
			if (!IsVLRenewalIntervalNull)
			{
				return true;
			}
			return false;
		}

		[Browsable(true)]
		public void CommitObject()
		{
			if (!bool_1)
			{
				managementObject_0.Put();
			}
		}

		[Browsable(true)]
		public void CommitObject(PutOptions putOptions)
		{
			if (!bool_1)
			{
				managementObject_0.Put(putOptions);
			}
		}

		private void method_22()
		{
			bool_0 = true;
			bool_1 = false;
		}

		private static string smethod_0(string string_2)
		{
			return string.Concat("root\\CimV2:OfficeSoftwareProtectionService", string.Concat(".Version=", string.Concat("\"", string_2 + "\"")));
		}

		private void method_23(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			method_22();
			if (managementPath_0 != null && !method_0(managementScope_1, managementPath_0, objectGetOptions_0))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0);
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances()
		{
			return GetInstances(null, null, null);
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances(string condition)
		{
			return GetInstances(null, condition, null);
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances(string[] selectedProperties)
		{
			return GetInstances(null, null, selectedProperties);
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances(string condition, string[] selectedProperties)
		{
			return GetInstances(null, condition, selectedProperties);
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementPath val = new ManagementPath();
			val.set_ClassName("OfficeSoftwareProtectionService");
			val.set_NamespacePath("root\\CimV2");
			ManagementClass val2 = new ManagementClass(mgmtScope, val, (ObjectGetOptions)null);
			if (enumOptions == null)
			{
				enumOptions = new EnumerationOptions();
				enumOptions.set_EnsureLocatable(true);
			}
			return new OfficeSoftwareProtectionServiceCollection(val2.GetInstances(enumOptions));
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances(ManagementScope mgmtScope, string condition)
		{
			return GetInstances(mgmtScope, condition, null);
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances(ManagementScope mgmtScope, string[] selectedProperties)
		{
			return GetInstances(mgmtScope, null, selectedProperties);
		}

		public static OfficeSoftwareProtectionServiceCollection GetInstances(ManagementScope mgmtScope, string condition, string[] selectedProperties)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementObjectSearcher val = new ManagementObjectSearcher(mgmtScope, (ObjectQuery)new SelectQuery("OfficeSoftwareProtectionService", condition, selectedProperties));
			EnumerationOptions val2 = new EnumerationOptions();
			val2.set_EnsureLocatable(true);
			val.set_Options(val2);
			return new OfficeSoftwareProtectionServiceCollection(val.Get());
		}

		[Browsable(true)]
		public static OfficeSoftwareProtectionService CreateInstance()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			ManagementScope val = null;
			if (managementScope_0 == null)
			{
				val = new ManagementScope();
				val.get_Path().set_NamespacePath(string_0);
			}
			else
			{
				val = managementScope_0;
			}
			ManagementPath val2 = new ManagementPath(string_1);
			ManagementClass val3 = new ManagementClass(val, val2, (ObjectGetOptions)null);
			return new OfficeSoftwareProtectionService(val3.CreateInstance());
		}

		[Browsable(true)]
		public void Delete()
		{
			managementObject_0.Delete();
		}

		public uint AcquireGenuineTicket(string ServerUrl, string TemplateId)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("AcquireGenuineTicket");
				val.set_Item("ServerUrl", (object)ServerUrl);
				val.set_Item("TemplateId", (object)TemplateId);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("AcquireGenuineTicket", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceListeningPort()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceListeningPort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceMachine()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServicePort()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearProductKeyFromRegistry()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearProductKeyFromRegistry", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DisableKeyManagementServiceActivation(bool DisableActivation)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DisableKeyManagementServiceActivation");
				val.set_Item("DisableActivation", (object)DisableActivation);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DisableKeyManagementServiceActivation", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DisableKeyManagementServiceDnsPublishing(bool DisablePublishing)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DisableKeyManagementServiceDnsPublishing");
				val.set_Item("DisablePublishing", (object)DisablePublishing);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DisableKeyManagementServiceDnsPublishing", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DisableKeyManagementServiceHostCaching(bool DisableCaching)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DisableKeyManagementServiceHostCaching");
				val.set_Item("DisableCaching", (object)DisableCaching);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DisableKeyManagementServiceHostCaching", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint EnableKeyManagementServiceLowPriority(bool EnableLowPriority)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("EnableKeyManagementServiceLowPriority");
				val.set_Item("EnableLowPriority", (object)EnableLowPriority);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("EnableKeyManagementServiceLowPriority", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint InstallLicense(string License)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("InstallLicense");
				val.set_Item("License", (object)License);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("InstallLicense", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint InstallLicensePackage(string LicensePackage)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("InstallLicensePackage");
				val.set_Item("LicensePackage", (object)LicensePackage);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("InstallLicensePackage", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint InstallProductKey(string ProductKey)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("InstallProductKey");
				val.set_Item("ProductKey", (object)ProductKey);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("InstallProductKey", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceListeningPort(uint PortNumber)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceListeningPort");
				val.set_Item("PortNumber", (object)PortNumber);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceListeningPort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceMachine(string MachineName)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceMachine");
				val.set_Item("MachineName", (object)MachineName);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServicePort(uint PortNumber)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServicePort");
				val.set_Item("PortNumber", (object)PortNumber);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetVLActivationInterval(uint ActivationInterval)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetVLActivationInterval");
				val.set_Item("ActivationInterval", (object)ActivationInterval);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetVLActivationInterval", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetVLRenewalInterval(uint RenewalInterval)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetVLRenewalInterval");
				val.set_Item("RenewalInterval", (object)RenewalInterval);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetVLRenewalInterval", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}
	}
	public class SoftwareLicensingProduct : Component
	{
		public class SoftwareLicensingProductCollection : ICollection
		{
			public class SoftwareLicensingProductEnumerator : IEnumerator
			{
				private ManagementObjectEnumerator managementObjectEnumerator_0;

				virtual object IEnumerator.Current => new SoftwareLicensingProduct((ManagementObject)managementObjectEnumerator_0.get_Current());

				public SoftwareLicensingProductEnumerator(ManagementObjectEnumerator objEnum)
				{
					managementObjectEnumerator_0 = objEnum;
				}

				public virtual bool MoveNext()
				{
					return managementObjectEnumerator_0.MoveNext();
				}

				public virtual void Reset()
				{
					managementObjectEnumerator_0.Reset();
				}
			}

			private ManagementObjectCollection managementObjectCollection_0;

			virtual int ICollection.Count => managementObjectCollection_0.get_Count();

			virtual bool ICollection.IsSynchronized => managementObjectCollection_0.get_IsSynchronized();

			virtual object ICollection.SyncRoot => this;

			public SoftwareLicensingProductCollection(ManagementObjectCollection objCollection)
			{
				managementObjectCollection_0 = objCollection;
			}

			public virtual void CopyTo(Array array, int index)
			{
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				managementObjectCollection_0.CopyTo(array, index);
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					array.SetValue(new SoftwareLicensingProduct((ManagementObject)array.GetValue(i)), i);
				}
			}

			public virtual IEnumerator GetEnumerator()
			{
				return new SoftwareLicensingProductEnumerator(managementObjectCollection_0.GetEnumerator());
			}
		}

		public class WMIValueTypeConverter : TypeConverter
		{
			private TypeConverter typeConverter_0;

			private Type type_0;

			public WMIValueTypeConverter(Type inBaseType)
				: this()
			{
				typeConverter_0 = TypeDescriptor.GetConverter(inBaseType);
				type_0 = inBaseType;
			}

			public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
			{
				return typeConverter_0.CanConvertFrom(context, srcType);
			}

			public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			{
				return typeConverter_0.CanConvertTo(context, destinationType);
			}

			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				return typeConverter_0.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value));
			}

			public override object CreateInstance(ITypeDescriptorContext context, IDictionary dictionary)
			{
				return typeConverter_0.CreateInstance(context, dictionary);
			}

			public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetCreateInstanceSupported(context);
			}

			public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributeVar)
			{
				return typeConverter_0.GetProperties(context, RuntimeHelpers.GetObjectValue(value), attributeVar);
			}

			public override bool GetPropertiesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetPropertiesSupported(context);
			}

			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValues(context);
			}

			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesExclusive(context);
			}

			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesSupported(context);
			}

			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if ((object)type_0.BaseType == typeof(Enum))
				{
					if ((object)value.GetType() == destinationType)
					{
						return value;
					}
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "NULL_ENUM_VALUE";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if ((object)type_0 == typeof(bool) && (object)type_0.BaseType == typeof(ValueType))
				{
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if (context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
				{
					return "";
				}
				return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
			}
		}

		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class ManagementSystemProperties
		{
			private ManagementBaseObject managementBaseObject_0;

			[Browsable(true)]
			public int GENUS => Conversions.ToInteger(managementBaseObject_0.get_Item("__GENUS"));

			[Browsable(true)]
			public string CLASS => Conversions.ToString(managementBaseObject_0.get_Item("__CLASS"));

			[Browsable(true)]
			public string SUPERCLASS => Conversions.ToString(managementBaseObject_0.get_Item("__SUPERCLASS"));

			[Browsable(true)]
			public string DYNASTY => Conversions.ToString(managementBaseObject_0.get_Item("__DYNASTY"));

			[Browsable(true)]
			public string RELPATH => Conversions.ToString(managementBaseObject_0.get_Item("__RELPATH"));

			[Browsable(true)]
			public int PROPERTY_COUNT => Conversions.ToInteger(managementBaseObject_0.get_Item("__PROPERTY_COUNT"));

			[Browsable(true)]
			public string[] DERIVATION => (string[])managementBaseObject_0.get_Item("__DERIVATION");

			[Browsable(true)]
			public string SERVER => Conversions.ToString(managementBaseObject_0.get_Item("__SERVER"));

			[Browsable(true)]
			public string NAMESPACE => Conversions.ToString(managementBaseObject_0.get_Item("__NAMESPACE"));

			[Browsable(true)]
			public string PATH => Conversions.ToString(managementBaseObject_0.get_Item("__PATH"));

			public ManagementSystemProperties(ManagementBaseObject ManagedObject)
			{
				managementBaseObject_0 = ManagedObject;
			}
		}

		private static string string_0 = "root\\CimV2";

		private static string string_1 = "SoftwareLicensingProduct";

		private static ManagementScope managementScope_0 = null;

		private ManagementSystemProperties managementSystemProperties_0;

		private ManagementObject managementObject_0;

		private bool bool_0;

		private ManagementBaseObject managementBaseObject_0;

		private ManagementBaseObject managementBaseObject_1;

		private bool bool_1;

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string OriginatingNamespace => "root\\CimV2";

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string ManagementClassName
		{
			get
			{
				string text = string_1;
				if (managementBaseObject_1 != null && managementBaseObject_1.get_ClassPath() != null)
				{
					text = Conversions.ToString(managementBaseObject_1.get_Item("__CLASS"));
					if (text == null || (object)text == string.Empty)
					{
						text = string_1;
					}
				}
				return text;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public ManagementSystemProperties SystemProperties => managementSystemProperties_0;

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public ManagementBaseObject LateBoundObject => managementBaseObject_1;

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementScope Scope
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Scope();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					managementObject_0.set_Scope(value);
				}
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool AutoCommit
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		[Browsable(true)]
		public ManagementPath Path
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Path();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					if (!method_0(null, value, null))
					{
						throw new ArgumentException("El nombre de clase no coincide.");
					}
					managementObject_0.set_Path(value);
				}
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public static ManagementScope StaticScope
		{
			get
			{
				return managementScope_0;
			}
			set
			{
				managementScope_0 = value;
			}
		}

		[Description("PID de host KMS en el objeto de activación usado para la última activación de AD.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ADActivationCsvlkPid => Conversions.ToString(managementBaseObject_1.get_Item("ADActivationCsvlkPid"));

		[Browsable(true)]
		[Description("SkuId de host KMS en el objeto de activación usado para la última activación de AD.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ADActivationCsvlkSkuId => Conversions.ToString(managementBaseObject_1.get_Item("ADActivationCsvlkSkuId"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Nombre completo del objeto de activación usado para la última activación de AD.")]
		public string ADActivationObjectDN => Conversions.ToString(managementBaseObject_1.get_Item("ADActivationObjectDN"));

		[Browsable(true)]
		[Description("Nombre de objeto de activación usado para la última activación de AD.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ADActivationObjectName => Conversions.ToString(managementBaseObject_1.get_Item("ADActivationObjectName"));

		[Description("Identificador de la aplicación del producto actual")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ApplicationID => Conversions.ToString(managementBaseObject_1.get_Item("ApplicationID"));

		[Browsable(true)]
		[Description("PID2 de clave de producto del host AVMA.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string AutomaticVMActivationHostDigitalPid2 => Conversions.ToString(managementBaseObject_1.get_Item("AutomaticVMActivationHostDigitalPid2"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Nombre de máquina del host AVMA.")]
		public string AutomaticVMActivationHostMachineName => Conversions.ToString(managementBaseObject_1.get_Item("AutomaticVMActivationHostMachineName"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsAutomaticVMActivationLastActivationTimeNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("AutomaticVMActivationLastActivationTime") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Hora de la última activación del producto.")]
		public DateTime AutomaticVMActivationLastActivationTime
		{
			get
			{
				if (managementBaseObject_1.get_Item("AutomaticVMActivationLastActivationTime") != null)
				{
					return ToDateTime(Conversions.ToString(managementBaseObject_1.get_Item("AutomaticVMActivationLastActivationTime")));
				}
				return DateTime.MinValue;
			}
		}

		[Description("Descripción del producto")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string Description => Conversions.ToString(managementBaseObject_1.get_Item("Description"));

		[Browsable(true)]
		[Description("Última dirección IP de host de KMS detectada mediante DNS.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string DiscoveredKeyManagementServiceMachineIpAddress => Conversions.ToString(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachineIpAddress"));

		[Browsable(true)]
		[Description("Último nombre de host KMS detectado a través de DNS.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string DiscoveredKeyManagementServiceMachineName => Conversions.ToString(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachineName"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsDiscoveredKeyManagementServiceMachinePortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Último puerto de host KMS detectado a través de DNS.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint DiscoveredKeyManagementServiceMachinePort
		{
			get
			{
				if (managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsEvaluationEndDateNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("EvaluationEndDate") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Fecha de expiración de la aplicación de este producto. Una vez pasada esta fecha, Estado de la licencia será Sin licencia y no se podrá activar.")]
		[Browsable(true)]
		public DateTime EvaluationEndDate
		{
			get
			{
				if (managementBaseObject_1.get_Item("EvaluationEndDate") != null)
				{
					return ToDateTime(Conversions.ToString(managementBaseObject_1.get_Item("EvaluationEndDate")));
				}
				return DateTime.MinValue;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsExtendedGraceNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("ExtendedGrace") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Período de gracia ampliado en minutos antes de que la aplicación principal se quede sin licencia.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint ExtendedGrace
		{
			get
			{
				if (managementBaseObject_1.get_Item("ExtendedGrace") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("ExtendedGrace"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsGenuineStatusNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("GenuineStatus") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[Description("Estado de autenticidad de este producto.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint GenuineStatus
		{
			get
			{
				if (managementBaseObject_1.get_Item("GenuineStatus") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("GenuineStatus"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsGracePeriodRemainingNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("GracePeriodRemaining") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Tiempo restante en minutos antes de que la aplicación primaria pase a modo de notificación. Para los clientes de volumen, se trata del período restante antes de que sea necesaria la reactivación.")]
		public uint GracePeriodRemaining
		{
			get
			{
				if (managementBaseObject_1.get_Item("GracePeriodRemaining") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("GracePeriodRemaining"));
			}
		}

		[Browsable(true)]
		[Description("Se requiere IAID en el host para evitar que esta máquina virtual escriba notificaciones.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string IAID => Conversions.ToString(managementBaseObject_1.get_Item("IAID"));

		[Description("Identificador del producto")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ID => Conversions.ToString(managementBaseObject_1.get_Item("ID"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsIsKeyManagementServiceMachineNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Indica si KMS está habilitado en el equipo: 1 si lo está, 0 si no lo está.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint IsKeyManagementServiceMachine
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("IsKeyManagementServiceMachine"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceCurrentCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número de clientes KMS activos actualmente en el host KMS. -1 indica que el host no está habilitado como KMS o que no recibió ninguna solicitud de licencia de cliente.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		public uint KeyManagementServiceCurrentCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceFailedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número total de solicitudes KMS no válidas.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint KeyManagementServiceFailedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceLicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=1 (con licencia).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceLicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests"));
			}
		}

		[Description("Nombre completo del dominio del recurso que contiene los registros SRV de KMS de la organización. Devuelve NULL si no se ha llamado a SetKeyManagementServiceLookupDomain.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string KeyManagementServiceLookupDomain => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceLookupDomain"));

		[Description("Nombre del host KMS. Devuelve null si no se llamó a SetKeyManagementServiceMachine.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string KeyManagementServiceMachine => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceMachine"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceNonGenuineGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=4 (período de gracia para software no original).")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public uint KeyManagementServiceNonGenuineGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceNotificationRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=5 (notificación).")]
		[Browsable(true)]
		public uint KeyManagementServiceNotificationRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceOOBGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=2 (período de gracia inicial).")]
		public uint KeyManagementServiceOOBGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceOOTGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=3 (período de gracia fuera de tolerancia).")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint KeyManagementServiceOOTGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServicePortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Puerto TCP usado por clientes para enviar solicitudes de activación de KMS. Devuelve 0 si no se llamó a SetKeyManagementServicePort.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServicePort
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServicePort"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Identificador de la clave de producto KMS. Devuelve null si no es aplicable.")]
		[Browsable(true)]
		public string KeyManagementServiceProductKeyID => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceProductKeyID"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceTotalRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número total de solicitudes KMS válidas.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		public uint KeyManagementServiceTotalRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceUnlicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=0 (sin licencia).")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint KeyManagementServiceUnlicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests"));
			}
		}

		[Description("Identificador de dependencia de la familia de SKU empleado para determinar las relaciones de licencias para complementos.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string LicenseDependsOn => Conversions.ToString(managementBaseObject_1.get_Item("LicenseDependsOn"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Identificador de familia de SKU empleado para determinar las relaciones de licencias para complementos.")]
		public string LicenseFamily => Conversions.ToString(managementBaseObject_1.get_Item("LicenseFamily"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsLicenseIsAddonNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseIsAddon") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Devuelve True si se identifica el producto como licencia de complemento.")]
		public bool LicenseIsAddon
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseIsAddon") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("LicenseIsAddon"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsLicenseStatusNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatus") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Estado de licencia de la aplicación de este producto.  0=sin licencia, 1=con licencia, 2=período de gracia inicial, 3=período de gracia fuera de tolerancia, 4=período de gracia para software no original, 5=notificación, 6=período de gracia extendido.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint LicenseStatus
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatus") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("LicenseStatus"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsLicenseStatusReasonNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatusReason") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Código diagnóstico que indica por qué un equipo está en un estado de licencia específico.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		public uint LicenseStatusReason
		{
			get
			{
				if (managementBaseObject_1.get_Item("LicenseStatusReason") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("LicenseStatusReason"));
			}
		}

		[Browsable(true)]
		[Description("Dirección URL del Servidor de licencias de software para el certificado de enlace")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string MachineURL => Conversions.ToString(managementBaseObject_1.get_Item("MachineURL"));

		[Description("Nombre del producto")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string Name => Conversions.ToString(managementBaseObject_1.get_Item("Name"));

		[Description("Identificador de la aplicación de este producto que sirve para realizar la activación por teléfono o sin conexión. Devuelve null si no está instalada una clave de producto.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string OfflineInstallationId => Conversions.ToString(managementBaseObject_1.get_Item("OfflineInstallationId"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Últimos cinco caracteres de la clave de este producto. Devuelve null si no está instalada una clave de producto.")]
		[Browsable(true)]
		public string PartialProductKey => Conversions.ToString(managementBaseObject_1.get_Item("PartialProductKey"));

		[Description("Dirección URL del Servidor de licencias de software para el certificado de proceso")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ProcessorURL => Conversions.ToString(managementBaseObject_1.get_Item("ProcessorURL"));

		[Description("Cadena de canales de clave de producto. Devuelve null si no hay instalada ninguna clave de producto.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string ProductKeyChannel => Conversions.ToString(managementBaseObject_1.get_Item("ProductKeyChannel"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Identificador de la clave de producto. Devuelve null si no está instalada una clave de producto.")]
		public string ProductKeyID => Conversions.ToString(managementBaseObject_1.get_Item("ProductKeyID"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Clave de producto ID2, PID2, cadena. Devuelve null si no hay instalada una clave de producto.")]
		public string ProductKeyID2 => Conversions.ToString(managementBaseObject_1.get_Item("ProductKeyID2"));

		[Description("Dirección URL del Servidor de licencias de software para el certificado de producto")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string ProductKeyURL => Conversions.ToString(managementBaseObject_1.get_Item("ProductKeyURL"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsRemainingAppReArmCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("RemainingAppReArmCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Número de veces restantes que se puede rearmar correctamente la aplicación.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint RemainingAppReArmCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("RemainingAppReArmCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("RemainingAppReArmCount"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsRemainingSkuReArmCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("RemainingSkuReArmCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Número de veces restantes que se puede rearmar correctamente el SKU.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint RemainingSkuReArmCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("RemainingSkuReArmCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("RemainingSkuReArmCount"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsRequiredClientCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número mínimo de clientes necesarios para conectarse a un host KMS y habilitar las licencias por volumen.")]
		public uint RequiredClientCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("RequiredClientCount"));
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Información adicional para la activación basada en token.")]
		public string TokenActivationAdditionalInfo => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationAdditionalInfo"));

		[Description("Huella digital del certificado que activó el producto.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string TokenActivationCertificateThumbprint => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationCertificateThumbprint"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsTokenActivationGrantNumberNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationGrantNumber") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número de concesión de la licencia de activación basada en token que activó el producto.")]
		public uint TokenActivationGrantNumber
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationGrantNumber") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("TokenActivationGrantNumber"));
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Identificador de la licencia de activación basada en token que activó el producto.")]
		public string TokenActivationILID => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationILID"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsTokenActivationILVIDNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationILVID") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Versión de la licencia de activación basada en token que activó el producto.")]
		public uint TokenActivationILVID
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationILVID") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("TokenActivationILVID"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsTrustedTimeNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TrustedTime") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Hora de confianza del producto.")]
		[Browsable(true)]
		public DateTime TrustedTime
		{
			get
			{
				if (managementBaseObject_1.get_Item("TrustedTime") != null)
				{
					return ToDateTime(Conversions.ToString(managementBaseObject_1.get_Item("TrustedTime")));
				}
				return DateTime.MinValue;
			}
		}

		[Description("Dirección URL del Servidor de licencias de software para la licencia de usuario")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public string UseLicenseURL => Conversions.ToString(managementBaseObject_1.get_Item("UseLicenseURL"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Dirección URL del servidor de licencias de software para validación original")]
		public string ValidationURL => Conversions.ToString(managementBaseObject_1.get_Item("ValidationURL"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsVLActivationIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Frecuencia de contacto en minutos de un cliente con el host KMS antes de que tenga licencia el producto.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLActivationInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLActivationInterval"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsVLActivationTypeNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationType") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Tipo de activación usado para la última activación de cliente de VL correcta.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLActivationType
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationType") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLActivationType"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsVLActivationTypeEnabledNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationTypeEnabled") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Tipo de activación configurada para el cliente de VL.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLActivationTypeEnabled
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationTypeEnabled") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLActivationTypeEnabled"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsVLRenewalIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Frecuencia de contacto en minutos de un cliente con el host KMS una vez que tenga licencia el producto.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLRenewalInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLRenewalInterval"));
			}
		}

		public SoftwareLicensingProduct()
			: this()
		{
			method_33(null, null, null);
		}

		public SoftwareLicensingProduct(string keyID)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_33(null, new ManagementPath(smethod_0(keyID)), null);
		}

		public SoftwareLicensingProduct(ManagementScope mgmtScope, string keyID)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_33(mgmtScope, new ManagementPath(smethod_0(keyID)), null);
		}

		public SoftwareLicensingProduct(ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_33(null, path, getOptions);
		}

		public SoftwareLicensingProduct(ManagementScope mgmtScope, ManagementPath path)
			: this()
		{
			method_33(mgmtScope, path, null);
		}

		public SoftwareLicensingProduct(ManagementPath path)
			: this()
		{
			method_33(null, path, null);
		}

		public SoftwareLicensingProduct(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_33(mgmtScope, path, getOptions);
		}

		public SoftwareLicensingProduct(ManagementObject theObject)
			: this()
		{
			method_32();
			if (!method_1((ManagementBaseObject)(object)theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public SoftwareLicensingProduct(ManagementBaseObject theObject)
			: this()
		{
			method_32();
			if (!method_1(theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementBaseObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties(theObject);
			managementBaseObject_1 = managementBaseObject_0;
			bool_1 = true;
		}

		private bool method_0(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			if (managementPath_0 != null && string.Compare(managementPath_0.get_ClassName(), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			return method_1((ManagementBaseObject)new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0));
		}

		private bool method_1(ManagementBaseObject managementBaseObject_2)
		{
			if (managementBaseObject_2 != null && string.Compare(Conversions.ToString(managementBaseObject_2.get_Item("__CLASS")), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			Array array = (Array)managementBaseObject_2.get_Item("__DERIVATION");
			if (array != null)
			{
				int num = 0;
				for (num = 0; num < array.Length; num = checked(num + 1))
				{
					if (string.Compare(Conversions.ToString(array.GetValue(num)), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		public static DateTime ToDateTime(string dmtfDate)
		{
			DateTime minValue = DateTime.MinValue;
			int num = minValue.Year;
			int num2 = minValue.Month;
			int num3 = minValue.Day;
			int num4 = minValue.Hour;
			int num5 = minValue.Minute;
			int num6 = minValue.Second;
			long num7 = 0L;
			DateTime minValue2 = DateTime.MinValue;
			string empty = string.Empty;
			if (dmtfDate == null)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (dmtfDate.Length == 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (dmtfDate.Length != 25)
			{
				throw new ArgumentOutOfRangeException();
			}
			checked
			{
				try
				{
					empty = dmtfDate.Substring(0, 4);
					if (Operators.CompareString("****", empty, false) != 0)
					{
						num = int.Parse(empty);
					}
					empty = dmtfDate.Substring(4, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num2 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(6, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num3 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(8, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num4 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(10, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num5 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(12, 2);
					if (Operators.CompareString("**", empty, false) != 0)
					{
						num6 = int.Parse(empty);
					}
					empty = dmtfDate.Substring(15, 6);
					if (Operators.CompareString("******", empty, false) != 0)
					{
						num7 = long.Parse(empty) * 10L;
					}
					if (num < 0 || num2 < 0 || num3 < 0 || num4 < 0 || num5 < 0 || num5 < 0 || num6 < 0 || num7 < 0L)
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					throw new ArgumentOutOfRangeException(null, ex2.Message);
				}
				minValue2 = new DateTime(num, num2, num3, num4, num5, num6, 0).AddTicks(num7);
				TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(minValue2);
				int num8 = 0;
				int num9 = 0;
				long num10 = (long)Math.Round((double)utcOffset.Ticks / 600000000.0);
				empty = dmtfDate.Substring(22, 3);
				if (Operators.CompareString(empty, "******", false) != 0)
				{
					empty = dmtfDate.Substring(21, 4);
					try
					{
						num8 = int.Parse(empty);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						throw new ArgumentOutOfRangeException(null, ex4.Message);
					}
					num9 = (int)(num10 - num8);
					minValue2 = minValue2.AddMinutes(num9);
				}
				return minValue2;
			}
		}

		public static string ToDmtfDateTime(DateTime date)
		{
			string empty = string.Empty;
			TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(date);
			checked
			{
				long value = (long)Math.Round((double)utcOffset.Ticks / 600000000.0);
				if (Math.Abs(value) > 999L)
				{
					date = date.ToUniversalTime();
					empty = "+000";
				}
				else if (utcOffset.Ticks >= 0L)
				{
					empty = "+" + ((long)Math.Round((double)utcOffset.Ticks / 600000000.0)).ToString().PadLeft(3, '0');
				}
				else
				{
					string text = value.ToString();
					empty = "-" + text.Substring(1, text.Length - 1).PadLeft(3, '0');
				}
				string str = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(date.Year.ToString().PadLeft(4, '0') + date.Month.ToString().PadLeft(2, '0'), date.Day.ToString().PadLeft(2, '0')), date.Hour.ToString().PadLeft(2, '0')), date.Minute.ToString().PadLeft(2, '0')), date.Second.ToString().PadLeft(2, '0')), ".");
				DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
				string text2 = ((long)Math.Round((double)((date.Ticks - dateTime.Ticks) * 1000L) / 10000.0)).ToString();
				if (text2.Length > 6)
				{
					text2 = text2.Substring(0, 6);
				}
				return string.Concat(str + text2.PadLeft(6, '0'), empty);
			}
		}

		private bool method_2()
		{
			if (!IsAutomaticVMActivationLastActivationTimeNull)
			{
				return true;
			}
			return false;
		}

		private bool method_3()
		{
			if (!IsDiscoveredKeyManagementServiceMachinePortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_4()
		{
			if (!IsEvaluationEndDateNull)
			{
				return true;
			}
			return false;
		}

		private bool method_5()
		{
			if (!IsExtendedGraceNull)
			{
				return true;
			}
			return false;
		}

		private bool method_6()
		{
			if (!IsGenuineStatusNull)
			{
				return true;
			}
			return false;
		}

		private bool method_7()
		{
			if (!IsGracePeriodRemainingNull)
			{
				return true;
			}
			return false;
		}

		private bool method_8()
		{
			if (!IsIsKeyManagementServiceMachineNull)
			{
				return true;
			}
			return false;
		}

		private bool method_9()
		{
			if (!IsKeyManagementServiceCurrentCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_10()
		{
			if (!IsKeyManagementServiceFailedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_11()
		{
			if (!IsKeyManagementServiceLicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_12()
		{
			if (!IsKeyManagementServiceNonGenuineGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_13()
		{
			if (!IsKeyManagementServiceNotificationRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_14()
		{
			if (!IsKeyManagementServiceOOBGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_15()
		{
			if (!IsKeyManagementServiceOOTGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_16()
		{
			if (!IsKeyManagementServicePortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_17()
		{
			if (!IsKeyManagementServiceTotalRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_18()
		{
			if (!IsKeyManagementServiceUnlicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_19()
		{
			if (!IsLicenseIsAddonNull)
			{
				return true;
			}
			return false;
		}

		private bool method_20()
		{
			if (!IsLicenseStatusNull)
			{
				return true;
			}
			return false;
		}

		private bool method_21()
		{
			if (!IsLicenseStatusReasonNull)
			{
				return true;
			}
			return false;
		}

		private bool method_22()
		{
			if (!IsRemainingAppReArmCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_23()
		{
			if (!IsRemainingSkuReArmCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_24()
		{
			if (!IsRequiredClientCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_25()
		{
			if (!IsTokenActivationGrantNumberNull)
			{
				return true;
			}
			return false;
		}

		private bool method_26()
		{
			if (!IsTokenActivationILVIDNull)
			{
				return true;
			}
			return false;
		}

		private bool method_27()
		{
			if (!IsTrustedTimeNull)
			{
				return true;
			}
			return false;
		}

		private bool method_28()
		{
			if (!IsVLActivationIntervalNull)
			{
				return true;
			}
			return false;
		}

		private bool method_29()
		{
			if (!IsVLActivationTypeNull)
			{
				return true;
			}
			return false;
		}

		private bool method_30()
		{
			if (!IsVLActivationTypeEnabledNull)
			{
				return true;
			}
			return false;
		}

		private bool method_31()
		{
			if (!IsVLRenewalIntervalNull)
			{
				return true;
			}
			return false;
		}

		[Browsable(true)]
		public void CommitObject()
		{
			if (!bool_1)
			{
				managementObject_0.Put();
			}
		}

		[Browsable(true)]
		public void CommitObject(PutOptions putOptions)
		{
			if (!bool_1)
			{
				managementObject_0.Put(putOptions);
			}
		}

		private void method_32()
		{
			bool_0 = true;
			bool_1 = false;
		}

		private static string smethod_0(string string_2)
		{
			return string.Concat("root\\CimV2:SoftwareLicensingProduct", string.Concat(".ID=", string.Concat("\"", string_2 + "\"")));
		}

		private void method_33(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			method_32();
			if (managementPath_0 != null && !method_0(managementScope_1, managementPath_0, objectGetOptions_0))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0);
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public static SoftwareLicensingProductCollection GetInstances()
		{
			return GetInstances(null, null, null);
		}

		public static SoftwareLicensingProductCollection GetInstances(string condition)
		{
			return GetInstances(null, condition, null);
		}

		public static SoftwareLicensingProductCollection GetInstances(string[] selectedProperties)
		{
			return GetInstances(null, null, selectedProperties);
		}

		public static SoftwareLicensingProductCollection GetInstances(string condition, string[] selectedProperties)
		{
			return GetInstances(null, condition, selectedProperties);
		}

		public static SoftwareLicensingProductCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementPath val = new ManagementPath();
			val.set_ClassName("SoftwareLicensingProduct");
			val.set_NamespacePath("root\\CimV2");
			ManagementClass val2 = new ManagementClass(mgmtScope, val, (ObjectGetOptions)null);
			if (enumOptions == null)
			{
				enumOptions = new EnumerationOptions();
				enumOptions.set_EnsureLocatable(true);
			}
			return new SoftwareLicensingProductCollection(val2.GetInstances(enumOptions));
		}

		public static SoftwareLicensingProductCollection GetInstances(ManagementScope mgmtScope, string condition)
		{
			return GetInstances(mgmtScope, condition, null);
		}

		public static SoftwareLicensingProductCollection GetInstances(ManagementScope mgmtScope, string[] selectedProperties)
		{
			return GetInstances(mgmtScope, null, selectedProperties);
		}

		public static SoftwareLicensingProductCollection GetInstances(ManagementScope mgmtScope, string condition, string[] selectedProperties)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementObjectSearcher val = new ManagementObjectSearcher(mgmtScope, (ObjectQuery)new SelectQuery("SoftwareLicensingProduct", condition, selectedProperties));
			EnumerationOptions val2 = new EnumerationOptions();
			val2.set_EnsureLocatable(true);
			val.set_Options(val2);
			return new SoftwareLicensingProductCollection(val.Get());
		}

		[Browsable(true)]
		public static SoftwareLicensingProduct CreateInstance()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			ManagementScope val = null;
			if (managementScope_0 == null)
			{
				val = new ManagementScope();
				val.get_Path().set_NamespacePath(string_0);
			}
			else
			{
				val = managementScope_0;
			}
			ManagementPath val2 = new ManagementPath(string_1);
			ManagementClass val3 = new ManagementClass(val, val2, (ObjectGetOptions)null);
			return new SoftwareLicensingProduct(val3.CreateInstance());
		}

		[Browsable(true)]
		public void Delete()
		{
			managementObject_0.Delete();
		}

		public uint Activate()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("Activate", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceLookupDomain()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceLookupDomain", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceMachine()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServicePort()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearVLActivationTypeEnabled()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearVLActivationTypeEnabled", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DepositOfflineConfirmationId(string ConfirmationId, string InstallationId)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DepositOfflineConfirmationId");
				val.set_Item("ConfirmationId", (object)ConfirmationId);
				val.set_Item("InstallationId", (object)InstallationId);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DepositOfflineConfirmationId", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DepositTokenActivationResponse(string CertChain, string Challenge, string Response)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DepositTokenActivationResponse");
				val.set_Item("CertChain", (object)CertChain);
				val.set_Item("Challenge", (object)Challenge);
				val.set_Item("Response", (object)Response);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DepositTokenActivationResponse", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint GenerateTokenActivationChallenge(ref string Challenge)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GenerateTokenActivationChallenge", val, (InvokeMethodOptions)null);
				Challenge = Convert.ToString(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("Challenge").get_Value()));
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			Challenge = null;
			return Convert.ToUInt32(0);
		}

		public uint GetPolicyInformationDWord(string PolicyName, ref uint PolicyValue)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("GetPolicyInformationDWord");
				val.set_Item("PolicyName", (object)PolicyName);
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GetPolicyInformationDWord", val, (InvokeMethodOptions)null);
				PolicyValue = Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("PolicyValue").get_Value()));
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			PolicyValue = Convert.ToUInt32(0);
			return Convert.ToUInt32(0);
		}

		public uint GetPolicyInformationString(string PolicyName, ref string PolicyValue)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("GetPolicyInformationString");
				val.set_Item("PolicyName", (object)PolicyName);
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GetPolicyInformationString", val, (InvokeMethodOptions)null);
				PolicyValue = Convert.ToString(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("PolicyValue").get_Value()));
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			PolicyValue = null;
			return Convert.ToUInt32(0);
		}

		public uint GetTokenActivationGrants(ref string[] Grants)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GetTokenActivationGrants", val, (InvokeMethodOptions)null);
				Grants = (string[])val2.get_Properties().get_Item("Grants").get_Value();
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			Grants = null;
			return Convert.ToUInt32(0);
		}

		public uint ReArmSku()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ReArmSku", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceLookupDomain(string LookupDomain)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceLookupDomain");
				val.set_Item("LookupDomain", (object)LookupDomain);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceLookupDomain", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceMachine(string MachineName)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceMachine");
				val.set_Item("MachineName", (object)MachineName);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServicePort(uint PortNumber)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServicePort");
				val.set_Item("PortNumber", (object)PortNumber);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetVLActivationTypeEnabled(uint ActivationType)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetVLActivationTypeEnabled");
				val.set_Item("ActivationType", (object)ActivationType);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetVLActivationTypeEnabled", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint UninstallProductKey()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("UninstallProductKey", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}
	}
	public class SoftwareLicensingService : Component
	{
		public class SoftwareLicensingServiceCollection : ICollection
		{
			public class SoftwareLicensingServiceEnumerator : IEnumerator
			{
				private ManagementObjectEnumerator managementObjectEnumerator_0;

				virtual object IEnumerator.Current => new SoftwareLicensingService((ManagementObject)managementObjectEnumerator_0.get_Current());

				public SoftwareLicensingServiceEnumerator(ManagementObjectEnumerator objEnum)
				{
					managementObjectEnumerator_0 = objEnum;
				}

				public virtual bool MoveNext()
				{
					return managementObjectEnumerator_0.MoveNext();
				}

				public virtual void Reset()
				{
					managementObjectEnumerator_0.Reset();
				}
			}

			private ManagementObjectCollection managementObjectCollection_0;

			virtual int ICollection.Count => managementObjectCollection_0.get_Count();

			virtual bool ICollection.IsSynchronized => managementObjectCollection_0.get_IsSynchronized();

			virtual object ICollection.SyncRoot => this;

			public SoftwareLicensingServiceCollection(ManagementObjectCollection objCollection)
			{
				managementObjectCollection_0 = objCollection;
			}

			public virtual void CopyTo(Array array, int index)
			{
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				managementObjectCollection_0.CopyTo(array, index);
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					array.SetValue(new SoftwareLicensingService((ManagementObject)array.GetValue(i)), i);
				}
			}

			public virtual IEnumerator GetEnumerator()
			{
				return new SoftwareLicensingServiceEnumerator(managementObjectCollection_0.GetEnumerator());
			}
		}

		public class WMIValueTypeConverter : TypeConverter
		{
			private TypeConverter typeConverter_0;

			private Type type_0;

			public WMIValueTypeConverter(Type inBaseType)
				: this()
			{
				typeConverter_0 = TypeDescriptor.GetConverter(inBaseType);
				type_0 = inBaseType;
			}

			public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
			{
				return typeConverter_0.CanConvertFrom(context, srcType);
			}

			public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			{
				return typeConverter_0.CanConvertTo(context, destinationType);
			}

			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				return typeConverter_0.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value));
			}

			public override object CreateInstance(ITypeDescriptorContext context, IDictionary dictionary)
			{
				return typeConverter_0.CreateInstance(context, dictionary);
			}

			public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetCreateInstanceSupported(context);
			}

			public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributeVar)
			{
				return typeConverter_0.GetProperties(context, RuntimeHelpers.GetObjectValue(value), attributeVar);
			}

			public override bool GetPropertiesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetPropertiesSupported(context);
			}

			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValues(context);
			}

			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesExclusive(context);
			}

			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return typeConverter_0.GetStandardValuesSupported(context);
			}

			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if ((object)type_0.BaseType == typeof(Enum))
				{
					if ((object)value.GetType() == destinationType)
					{
						return value;
					}
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "NULL_ENUM_VALUE";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if ((object)type_0 == typeof(bool) && (object)type_0.BaseType == typeof(ValueType))
				{
					if (value == null && context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
					{
						return "";
					}
					return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
				}
				if (context != null && !context.get_PropertyDescriptor().ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.get_Instance())))
				{
					return "";
				}
				return typeConverter_0.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
			}
		}

		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class ManagementSystemProperties
		{
			private ManagementBaseObject managementBaseObject_0;

			[Browsable(true)]
			public int GENUS => Conversions.ToInteger(managementBaseObject_0.get_Item("__GENUS"));

			[Browsable(true)]
			public string CLASS => Conversions.ToString(managementBaseObject_0.get_Item("__CLASS"));

			[Browsable(true)]
			public string SUPERCLASS => Conversions.ToString(managementBaseObject_0.get_Item("__SUPERCLASS"));

			[Browsable(true)]
			public string DYNASTY => Conversions.ToString(managementBaseObject_0.get_Item("__DYNASTY"));

			[Browsable(true)]
			public string RELPATH => Conversions.ToString(managementBaseObject_0.get_Item("__RELPATH"));

			[Browsable(true)]
			public int PROPERTY_COUNT => Conversions.ToInteger(managementBaseObject_0.get_Item("__PROPERTY_COUNT"));

			[Browsable(true)]
			public string[] DERIVATION => (string[])managementBaseObject_0.get_Item("__DERIVATION");

			[Browsable(true)]
			public string SERVER => Conversions.ToString(managementBaseObject_0.get_Item("__SERVER"));

			[Browsable(true)]
			public string NAMESPACE => Conversions.ToString(managementBaseObject_0.get_Item("__NAMESPACE"));

			[Browsable(true)]
			public string PATH => Conversions.ToString(managementBaseObject_0.get_Item("__PATH"));

			public ManagementSystemProperties(ManagementBaseObject ManagedObject)
			{
				managementBaseObject_0 = ManagedObject;
			}
		}

		private static string string_0 = "root\\CimV2";

		private static string string_1 = "SoftwareLicensingService";

		private static ManagementScope managementScope_0 = null;

		private ManagementSystemProperties managementSystemProperties_0;

		private ManagementObject managementObject_0;

		private bool bool_0;

		private ManagementBaseObject managementBaseObject_0;

		private ManagementBaseObject managementBaseObject_1;

		private bool bool_1;

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string OriginatingNamespace => "root\\CimV2";

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ManagementClassName
		{
			get
			{
				string text = string_1;
				if (managementBaseObject_1 != null && managementBaseObject_1.get_ClassPath() != null)
				{
					text = Conversions.ToString(managementBaseObject_1.get_Item("__CLASS"));
					if (text == null || (object)text == string.Empty)
					{
						text = string_1;
					}
				}
				return text;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		public ManagementSystemProperties SystemProperties => managementSystemProperties_0;

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public ManagementBaseObject LateBoundObject => managementBaseObject_1;

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public ManagementScope Scope
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Scope();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					managementObject_0.set_Scope(value);
				}
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool AutoCommit
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		[Browsable(true)]
		public ManagementPath Path
		{
			get
			{
				if (!bool_1)
				{
					return managementObject_0.get_Path();
				}
				return null;
			}
			set
			{
				if (!bool_1)
				{
					if (!method_0(null, value, null))
					{
						throw new ArgumentException("El nombre de clase no coincide.");
					}
					managementObject_0.set_Path(value);
				}
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public static ManagementScope StaticScope
		{
			get
			{
				return managementScope_0;
			}
			set
			{
				managementScope_0 = value;
			}
		}

		[Browsable(true)]
		[Description("GUID que identifica un cliente KMS a un host KMS. El cliente lo incluye en las solicitudes que envía al KMS.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string ClientMachineID => Conversions.ToString(managementBaseObject_1.get_Item("ClientMachineID"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Última dirección IP de host de KMS detectada mediante DNS.")]
		public string DiscoveredKeyManagementServiceMachineIpAddress => Conversions.ToString(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachineIpAddress"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Último nombre de host KMS detectado a través de DNS.")]
		public string DiscoveredKeyManagementServiceMachineName => Conversions.ToString(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachineName"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsDiscoveredKeyManagementServiceMachinePortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Último puerto de host KMS detectado a través de DNS.")]
		[Browsable(true)]
		public uint DiscoveredKeyManagementServiceMachinePort
		{
			get
			{
				if (managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("DiscoveredKeyManagementServiceMachinePort"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsIsKeyManagementServiceMachineNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Indica si KMS está habilitado en el equipo: 0 si no lo está, 1 si lo está.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint IsKeyManagementServiceMachine
		{
			get
			{
				if (managementBaseObject_1.get_Item("IsKeyManagementServiceMachine") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("IsKeyManagementServiceMachine"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceCurrentCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Número de clientes KMS activos actualmente en el host KMS. -1 indica que el equipo no está habilitado como KMS o que no recibió ninguna solicitud de licencia de cliente.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceCurrentCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceCurrentCount"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceDnsPublishingNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceDnsPublishing") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Indica el estado de publicación de DNS de un host KMS: 0=deshabilitado, 1=publicación automática habilitada (predeterminado).")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool KeyManagementServiceDnsPublishing
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceDnsPublishing") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("KeyManagementServiceDnsPublishing"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceFailedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Número total de solicitudes KMS no válidas.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceFailedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceFailedRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceHostCachingNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceHostCaching") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[Description("Indica el estado de caché del nombre y el puerto del host KMS: 0=caché deshabilitada, 1=caché habilitada (predeterminado).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool KeyManagementServiceHostCaching
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceHostCaching") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("KeyManagementServiceHostCaching"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceLicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=1 (con licencia).")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint KeyManagementServiceLicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceLicensedRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceListeningPortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceListeningPort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[Description("Puerto TCP que emplea el host KMS para escuchar solicitudes de activación.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public uint KeyManagementServiceListeningPort
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceListeningPort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceListeningPort"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Nombre completo del dominio del recurso que contiene los registros SRV de KMS de la organización. Devuelve NULL si no se ha llamado a SetKeyManagementServiceLookupDomain.")]
		[Browsable(true)]
		public string KeyManagementServiceLookupDomain => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceLookupDomain"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceLowPriorityNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLowPriority") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Indica el estado de prioridad de subproceso del servicio KMS: 0=prioridad normal (predeterminado), 1=baja prioridad.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public bool KeyManagementServiceLowPriority
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceLowPriority") == null)
				{
					return Convert.ToBoolean(0);
				}
				return Conversions.ToBoolean(managementBaseObject_1.get_Item("KeyManagementServiceLowPriority"));
			}
		}

		[Description("Nombre del host KMS. Devuelve null si no se llamó a SetKeyManagementServiceMachine.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public string KeyManagementServiceMachine => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceMachine"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceNonGenuineGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=4 (período de gracia para software no original).")]
		public uint KeyManagementServiceNonGenuineGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNonGenuineGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceNotificationRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=5 (notificación).")]
		public uint KeyManagementServiceNotificationRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceNotificationRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceOOBGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=2 (período de gracia inicial).")]
		public uint KeyManagementServiceOOBGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOBGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServiceOOTGraceRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Número de solicitudes KMS de clientes con estado de licencia=3 (período de gracia fuera de tolerancia).")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceOOTGraceRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceOOTGraceRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsKeyManagementServicePortNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Puerto TCP usado por clientes para enviar solicitudes de activación de KMS. Devuelve 0 si no se llamó a SetKeyManagementServicePort.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServicePort
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServicePort") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServicePort"));
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Identificador de la clave de producto KMS. Devuelve null si no es aplicable.")]
		public string KeyManagementServiceProductKeyID => Conversions.ToString(managementBaseObject_1.get_Item("KeyManagementServiceProductKeyID"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceTotalRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número total de solicitudes KMS válidas.")]
		[Browsable(true)]
		public uint KeyManagementServiceTotalRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceTotalRequests"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsKeyManagementServiceUnlicensedRequestsNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Número de solicitudes KMS de clientes con estado de licencia=0 (sin licencia).")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint KeyManagementServiceUnlicensedRequests
		{
			get
			{
				if (managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("KeyManagementServiceUnlicensedRequests"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsOA2xBiosMarkerMinorVersionNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("OA2xBiosMarkerMinorVersion") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Número de versión secundaria del marcador BIOS OA2.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint OA2xBiosMarkerMinorVersion
		{
			get
			{
				if (managementBaseObject_1.get_Item("OA2xBiosMarkerMinorVersion") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("OA2xBiosMarkerMinorVersion"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsOA2xBiosMarkerStatusNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("OA2xBiosMarkerStatus") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Description("Estado del marcador BIOS OA2.  0=Sin tabla SLIC, 1=Tabla SLIC con marcador de Windows, 2=Tabla SLIC sin marcador de Windows, 3=Tabla SLIC dañada o no válida")]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint OA2xBiosMarkerStatus
		{
			get
			{
				if (managementBaseObject_1.get_Item("OA2xBiosMarkerStatus") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("OA2xBiosMarkerStatus"));
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Clave de producto del marcador BIOS OA3.")]
		public string OA3xOriginalProductKey => Conversions.ToString(managementBaseObject_1.get_Item("OA3xOriginalProductKey"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsPolicyCacheRefreshRequiredNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("PolicyCacheRefreshRequired") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Indica si es necesario actualizar la memoria caché de la directiva de licencias: 0=no es necesario, 1=actualización necesaria.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint PolicyCacheRefreshRequired
		{
			get
			{
				if (managementBaseObject_1.get_Item("PolicyCacheRefreshRequired") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("PolicyCacheRefreshRequired"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsRemainingWindowsReArmCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("RemainingWindowsReArmCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Número de veces restantes que se puede rearmar correctamente el cliente.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint RemainingWindowsReArmCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("RemainingWindowsReArmCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("RemainingWindowsReArmCount"));
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsRequiredClientCountNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Número mínimo de clientes necesarios para conectarse a un host KMS y habilitar las licencias por volumen.")]
		public uint RequiredClientCount
		{
			get
			{
				if (managementBaseObject_1.get_Item("RequiredClientCount") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("RequiredClientCount"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Información adicional para la activación basada en token.")]
		[Browsable(true)]
		public string TokenActivationAdditionalInfo => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationAdditionalInfo"));

		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Huella digital del certificado que activó el equipo.")]
		public string TokenActivationCertificateThumbprint => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationCertificateThumbprint"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsTokenActivationGrantNumberNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationGrantNumber") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Número de concesión de la licencia de activación basada en token que activó el equipo.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint TokenActivationGrantNumber
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationGrantNumber") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("TokenActivationGrantNumber"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Identificador de la licencia de activación basada en token que activó el equipo.")]
		public string TokenActivationILID => Conversions.ToString(managementBaseObject_1.get_Item("TokenActivationILID"));

		[Browsable(false)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		public bool IsTokenActivationILVIDNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationILVID") == null)
				{
					return true;
				}
				return false;
			}
		}

		[TypeConverter(typeof(WMIValueTypeConverter))]
		[Browsable(true)]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Versión de la licencia de activación basada en token que activó el equipo.")]
		public uint TokenActivationILVID
		{
			get
			{
				if (managementBaseObject_1.get_Item("TokenActivationILVID") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("TokenActivationILVID"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Description("Versión del Servicio de licencias de software")]
		[Browsable(true)]
		public string Version => Conversions.ToString(managementBaseObject_1.get_Item("Version"));

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsVLActivationIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(true)]
		[Description("Frecuencia de contacto en minutos de un cliente con el host KMS antes de que tenga licencia el cliente.")]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLActivationInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLActivationInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLActivationInterval"));
			}
		}

		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[Browsable(false)]
		public bool IsVLRenewalIntervalNull
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return true;
				}
				return false;
			}
		}

		[Browsable(true)]
		[Description("Frecuencia de contacto en minutos de un cliente con el host KMS una vez que tenga licencia el cliente.")]
		[DesignerSerializationVisibility(/*Could not decode attribute arguments.*/)]
		[TypeConverter(typeof(WMIValueTypeConverter))]
		public uint VLRenewalInterval
		{
			get
			{
				if (managementBaseObject_1.get_Item("VLRenewalInterval") == null)
				{
					return Convert.ToUInt32(0);
				}
				return Conversions.ToUInteger(managementBaseObject_1.get_Item("VLRenewalInterval"));
			}
		}

		public SoftwareLicensingService()
			: this()
		{
			method_28(null, null, null);
		}

		public SoftwareLicensingService(string keyVersion)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_28(null, new ManagementPath(smethod_0(keyVersion)), null);
		}

		public SoftwareLicensingService(ManagementScope mgmtScope, string keyVersion)
			: this()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			method_28(mgmtScope, new ManagementPath(smethod_0(keyVersion)), null);
		}

		public SoftwareLicensingService(ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_28(null, path, getOptions);
		}

		public SoftwareLicensingService(ManagementScope mgmtScope, ManagementPath path)
			: this()
		{
			method_28(mgmtScope, path, null);
		}

		public SoftwareLicensingService(ManagementPath path)
			: this()
		{
			method_28(null, path, null);
		}

		public SoftwareLicensingService(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions)
			: this()
		{
			method_28(mgmtScope, path, getOptions);
		}

		public SoftwareLicensingService(ManagementObject theObject)
			: this()
		{
			method_27();
			if (!method_1((ManagementBaseObject)(object)theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public SoftwareLicensingService(ManagementBaseObject theObject)
			: this()
		{
			method_27();
			if (!method_1(theObject))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementBaseObject_0 = theObject;
			managementSystemProperties_0 = new ManagementSystemProperties(theObject);
			managementBaseObject_1 = managementBaseObject_0;
			bool_1 = true;
		}

		private bool method_0(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			if (managementPath_0 != null && string.Compare(managementPath_0.get_ClassName(), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			return method_1((ManagementBaseObject)new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0));
		}

		private bool method_1(ManagementBaseObject managementBaseObject_2)
		{
			if (managementBaseObject_2 != null && string.Compare(Conversions.ToString(managementBaseObject_2.get_Item("__CLASS")), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return true;
			}
			Array array = (Array)managementBaseObject_2.get_Item("__DERIVATION");
			if (array != null)
			{
				int num = 0;
				for (num = 0; num < array.Length; num = checked(num + 1))
				{
					if (string.Compare(Conversions.ToString(array.GetValue(num)), ManagementClassName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool method_2()
		{
			if (!IsDiscoveredKeyManagementServiceMachinePortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_3()
		{
			if (!IsIsKeyManagementServiceMachineNull)
			{
				return true;
			}
			return false;
		}

		private bool method_4()
		{
			if (!IsKeyManagementServiceCurrentCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_5()
		{
			if (!IsKeyManagementServiceDnsPublishingNull)
			{
				return true;
			}
			return false;
		}

		private bool method_6()
		{
			if (!IsKeyManagementServiceFailedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_7()
		{
			if (!IsKeyManagementServiceHostCachingNull)
			{
				return true;
			}
			return false;
		}

		private bool method_8()
		{
			if (!IsKeyManagementServiceLicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_9()
		{
			if (!IsKeyManagementServiceListeningPortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_10()
		{
			if (!IsKeyManagementServiceLowPriorityNull)
			{
				return true;
			}
			return false;
		}

		private bool method_11()
		{
			if (!IsKeyManagementServiceNonGenuineGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_12()
		{
			if (!IsKeyManagementServiceNotificationRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_13()
		{
			if (!IsKeyManagementServiceOOBGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_14()
		{
			if (!IsKeyManagementServiceOOTGraceRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_15()
		{
			if (!IsKeyManagementServicePortNull)
			{
				return true;
			}
			return false;
		}

		private bool method_16()
		{
			if (!IsKeyManagementServiceTotalRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_17()
		{
			if (!IsKeyManagementServiceUnlicensedRequestsNull)
			{
				return true;
			}
			return false;
		}

		private bool method_18()
		{
			if (!IsOA2xBiosMarkerMinorVersionNull)
			{
				return true;
			}
			return false;
		}

		private bool method_19()
		{
			if (!IsOA2xBiosMarkerStatusNull)
			{
				return true;
			}
			return false;
		}

		private bool method_20()
		{
			if (!IsPolicyCacheRefreshRequiredNull)
			{
				return true;
			}
			return false;
		}

		private bool method_21()
		{
			if (!IsRemainingWindowsReArmCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_22()
		{
			if (!IsRequiredClientCountNull)
			{
				return true;
			}
			return false;
		}

		private bool method_23()
		{
			if (!IsTokenActivationGrantNumberNull)
			{
				return true;
			}
			return false;
		}

		private bool method_24()
		{
			if (!IsTokenActivationILVIDNull)
			{
				return true;
			}
			return false;
		}

		private bool method_25()
		{
			if (!IsVLActivationIntervalNull)
			{
				return true;
			}
			return false;
		}

		private bool method_26()
		{
			if (!IsVLRenewalIntervalNull)
			{
				return true;
			}
			return false;
		}

		[Browsable(true)]
		public void CommitObject()
		{
			if (!bool_1)
			{
				managementObject_0.Put();
			}
		}

		[Browsable(true)]
		public void CommitObject(PutOptions putOptions)
		{
			if (!bool_1)
			{
				managementObject_0.Put(putOptions);
			}
		}

		private void method_27()
		{
			bool_0 = true;
			bool_1 = false;
		}

		private static string smethod_0(string string_2)
		{
			return string.Concat("root\\CimV2:SoftwareLicensingService", string.Concat(".Version=", string.Concat("\"", string_2 + "\"")));
		}

		private void method_28(ManagementScope managementScope_1, ManagementPath managementPath_0, ObjectGetOptions objectGetOptions_0)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			method_27();
			if (managementPath_0 != null && !method_0(managementScope_1, managementPath_0, objectGetOptions_0))
			{
				throw new ArgumentException("El nombre de clase no coincide.");
			}
			managementObject_0 = new ManagementObject(managementScope_1, managementPath_0, objectGetOptions_0);
			managementSystemProperties_0 = new ManagementSystemProperties((ManagementBaseObject)(object)managementObject_0);
			managementBaseObject_1 = (ManagementBaseObject)(object)managementObject_0;
		}

		public static SoftwareLicensingServiceCollection GetInstances()
		{
			return GetInstances(null, null, null);
		}

		public static SoftwareLicensingServiceCollection GetInstances(string condition)
		{
			return GetInstances(null, condition, null);
		}

		public static SoftwareLicensingServiceCollection GetInstances(string[] selectedProperties)
		{
			return GetInstances(null, null, selectedProperties);
		}

		public static SoftwareLicensingServiceCollection GetInstances(string condition, string[] selectedProperties)
		{
			return GetInstances(null, condition, selectedProperties);
		}

		public static SoftwareLicensingServiceCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementPath val = new ManagementPath();
			val.set_ClassName("SoftwareLicensingService");
			val.set_NamespacePath("root\\CimV2");
			ManagementClass val2 = new ManagementClass(mgmtScope, val, (ObjectGetOptions)null);
			if (enumOptions == null)
			{
				enumOptions = new EnumerationOptions();
				enumOptions.set_EnsureLocatable(true);
			}
			return new SoftwareLicensingServiceCollection(val2.GetInstances(enumOptions));
		}

		public static SoftwareLicensingServiceCollection GetInstances(ManagementScope mgmtScope, string condition)
		{
			return GetInstances(mgmtScope, condition, null);
		}

		public static SoftwareLicensingServiceCollection GetInstances(ManagementScope mgmtScope, string[] selectedProperties)
		{
			return GetInstances(mgmtScope, null, selectedProperties);
		}

		public static SoftwareLicensingServiceCollection GetInstances(ManagementScope mgmtScope, string condition, string[] selectedProperties)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			if (mgmtScope == null)
			{
				if (managementScope_0 == null)
				{
					mgmtScope = new ManagementScope();
					mgmtScope.get_Path().set_NamespacePath("root\\CimV2");
				}
				else
				{
					mgmtScope = managementScope_0;
				}
			}
			ManagementObjectSearcher val = new ManagementObjectSearcher(mgmtScope, (ObjectQuery)new SelectQuery("SoftwareLicensingService", condition, selectedProperties));
			EnumerationOptions val2 = new EnumerationOptions();
			val2.set_EnsureLocatable(true);
			val.set_Options(val2);
			return new SoftwareLicensingServiceCollection(val.Get());
		}

		[Browsable(true)]
		public static SoftwareLicensingService CreateInstance()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			ManagementScope val = null;
			if (managementScope_0 == null)
			{
				val = new ManagementScope();
				val.get_Path().set_NamespacePath(string_0);
			}
			else
			{
				val = managementScope_0;
			}
			ManagementPath val2 = new ManagementPath(string_1);
			ManagementClass val3 = new ManagementClass(val, val2, (ObjectGetOptions)null);
			return new SoftwareLicensingService(val3.CreateInstance());
		}

		[Browsable(true)]
		public void Delete()
		{
			managementObject_0.Delete();
		}

		public uint AcquireGenuineTicket(string ServerUrl, string TemplateId)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("AcquireGenuineTicket");
				val.set_Item("ServerUrl", (object)ServerUrl);
				val.set_Item("TemplateId", (object)TemplateId);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("AcquireGenuineTicket", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceListeningPort()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceListeningPort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceLookupDomain()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceLookupDomain", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServiceMachine()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearKeyManagementServicePort()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearProductKeyFromRegistry()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearProductKeyFromRegistry", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ClearVLActivationTypeEnabled()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ClearVLActivationTypeEnabled", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DepositActiveDirectoryOfflineActivationConfirmation(string ActivationObjectName, string ConfirmationID, string ProductKey)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DepositActiveDirectoryOfflineActivationConfirmation");
				val.set_Item("ActivationObjectName", (object)ActivationObjectName);
				val.set_Item("ConfirmationID", (object)ConfirmationID);
				val.set_Item("ProductKey", (object)ProductKey);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DepositActiveDirectoryOfflineActivationConfirmation", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DisableKeyManagementServiceDnsPublishing(bool DisablePublishing)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DisableKeyManagementServiceDnsPublishing");
				val.set_Item("DisablePublishing", (object)DisablePublishing);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DisableKeyManagementServiceDnsPublishing", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DisableKeyManagementServiceHostCaching(bool DisableCaching)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DisableKeyManagementServiceHostCaching");
				val.set_Item("DisableCaching", (object)DisableCaching);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DisableKeyManagementServiceHostCaching", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint DoActiveDirectoryOnlineActivation(string ActivationObjectName, string ProductKey)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("DoActiveDirectoryOnlineActivation");
				val.set_Item("ActivationObjectName", (object)ActivationObjectName);
				val.set_Item("ProductKey", (object)ProductKey);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("DoActiveDirectoryOnlineActivation", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint EnableKeyManagementServiceLowPriority(bool EnableLowPriority)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("EnableKeyManagementServiceLowPriority");
				val.set_Item("EnableLowPriority", (object)EnableLowPriority);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("EnableKeyManagementServiceLowPriority", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint GenerateActiveDirectoryOfflineActivationId(string ProductKey, ref string InstallationID)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("GenerateActiveDirectoryOfflineActivationId");
				val.set_Item("ProductKey", (object)ProductKey);
				ManagementBaseObject val2 = managementObject_0.InvokeMethod("GenerateActiveDirectoryOfflineActivationId", val, (InvokeMethodOptions)null);
				InstallationID = Convert.ToString(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("InstallationID").get_Value()));
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(val2.get_Properties().get_Item("ReturnValue").get_Value()));
			}
			InstallationID = null;
			return Convert.ToUInt32(0);
		}

		public uint InstallLicense(string License)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("InstallLicense");
				val.set_Item("License", (object)License);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("InstallLicense", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint InstallLicensePackage(string LicensePackage)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("InstallLicensePackage");
				val.set_Item("LicensePackage", (object)LicensePackage);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("InstallLicensePackage", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint InstallProductKey(string ProductKey)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("InstallProductKey");
				val.set_Item("ProductKey", (object)ProductKey);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("InstallProductKey", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ReArmApp(string ApplicationId)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("ReArmApp");
				val.set_Item("ApplicationId", (object)ApplicationId);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ReArmApp", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint ReArmWindows()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("ReArmWindows", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint RefreshLicenseStatus()
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("RefreshLicenseStatus", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceListeningPort(uint PortNumber)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceListeningPort");
				val.set_Item("PortNumber", (object)PortNumber);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceListeningPort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceLookupDomain(string LookupDomain)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceLookupDomain");
				val.set_Item("LookupDomain", (object)LookupDomain);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceLookupDomain", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServiceMachine(string MachineName)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServiceMachine");
				val.set_Item("MachineName", (object)MachineName);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServiceMachine", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetKeyManagementServicePort(uint PortNumber)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetKeyManagementServicePort");
				val.set_Item("PortNumber", (object)PortNumber);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetKeyManagementServicePort", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetVLActivationInterval(uint ActivationInterval)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetVLActivationInterval");
				val.set_Item("ActivationInterval", (object)ActivationInterval);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetVLActivationInterval", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetVLActivationTypeEnabled(uint ActivationType)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetVLActivationTypeEnabled");
				val.set_Item("ActivationType", (object)ActivationType);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetVLActivationTypeEnabled", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}

		public uint SetVLRenewalInterval(uint RenewalInterval)
		{
			if (!bool_1)
			{
				ManagementBaseObject val = null;
				val = managementObject_0.GetMethodParameters("SetVLRenewalInterval");
				val.set_Item("RenewalInterval", (object)RenewalInterval);
				return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementObject_0.InvokeMethod("SetVLRenewalInterval", val, (InvokeMethodOptions)null).get_Properties().get_Item("ReturnValue")
					.get_Value()));
			}
			return Convert.ToUInt32(0);
		}
	}
}
namespace AutoPico.Activador.Keys
{
	public interface IPIDCheck
	{
		string CheckProductKey(string strKey);

		string CheckProductKeyEx(string strKey, bool semicolonExport);

		void ConfigPath(string strFile);

		string GetCount(string string_0);
	}
	public class Key
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindows10
		{
			public const string Professional = "W269N-WFGWX-YVC9B-4J6C9-T83GX";

			public const string ProfessionalN = "MH37W-N47XK-V7XM9-C7227-GCQG9";

			public const string Enterprise = "NPPR9-FWDCX-D2C8J-H872K-2YT43";

			public const string EnterpriseN = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";

			public const string Education = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";

			public const string EducationN = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";

			public const string Core = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";

			public const string CoreN = "3KHY7-WNT83-DGQKR-F7HPR-844BM";

			public const string CoreSingleLanguage = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";

			public const string CoreCountrySpecific = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";

			public const string EnterpriseS = "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";

			public const string EnterpriseSN = "2F77B-TNFGY-69QQF-B8YKP-D69TJ";

			public const string ProfessionalPreview = "43BNY-B3MHX-37RT3-HT88J-33XGM";

			public const string EnterprisePreview = "MFY6B-WNCVR-9KWQ4-9CGGM-QJ3YW";

			public const string CorePreview = "JTJ43-TNBFV-YDGKB-92WGV-GCQXV";

			public const string EducationPreview = "YVKRN-H6QFQ-JQGG3-T7BF3-2WGQ7";

			public const string CoreARM = "7NX88-X6YM3-9Q3YT-CCGBF-KBVQF";

			public const string EmbeddedIndustryA = "GN2X2-KXTK6-P92FR-VBB9G-PDJFP";

			public const string ProfessionalS = "NFDD9-FX3VM-DYCKP-B8HT8-D9M2C";

			public const string CoreConnectedCountrySpecific = "FTNXM-J4RGP-MYQCV-RVM8R-TVH24";

			public const string EmbeddedIndustry = "XY4TQ-CXNVJ-YCT73-HH6R7-R897X";

			public const string CoreConnected = "DJMYQ-WN6HG-YJ2YX-82JDB-CWFCW";

			public const string CoreConnectedSingleLanguage = "QQMNF-GPVQ6-BFXGG-GWRCX-7XKT7";

			public const string ProfessionalStudent = "YNXW3-HV3VB-Y83VG-KPBXM-6VH3Q";

			public const string CoreConnectedN = "JQNT7-W63G4-WX4QX-RD9M9-6CPKM";

			public const string ProfessionalSN = "8Q36Y-N2F39-HRMHT-4XW33-TCQR4";

			public const string EmbeddedIndustryE = "XCNC9-BPK3C-KCCMD-FTDTC-KWY4G";

			public const string ProfessionalStudentN = "8G9XJ-GN6PJ-GW787-MVV7G-GMR99";

			public const string ProfessionalWMC = "NKPM6-TCVPT-3HRFX-Q4H9B-QJ34Y";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindows81
		{
			public const string Professional = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";

			public const string ProfessionalPreview = "MTWNQ-CKDHJ-3HXW9-Q2PFX-WB2HQ";

			public const string ProfessionalStudent = "NQHYK-WGWJH-DQJT7-XB68G-BPYG9";

			public const string ProfessionalStudentN = "TNFGH-2R6PB-8XM3K-QYHX2-J4296";

			public const string Preview = "YNB3T-VHW8P-72P6K-BQHCB-DM92V";

			public const string ProfessionalWMC = "789NJ-TQK6T-6XTH8-J39CJ-J8D3P";

			public const string ProfessionalWMCPreview = "MY4N9-TGH34-4X4VY-8FG2T-RRDPV";

			public const string Enterprise = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";

			public const string EnterprisePreview = "2MP7K-98NK8-WPVF3-Q2WDG-VMD98";

			public const string ProfessionalN = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";

			public const string EnterpriseN = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";

			public const string CoreARM = "XYTND-K6QKT-K2MRH-66RTM-43JKP";

			public const string Core = "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";

			public const string CoreN = "7B9N3-D94CG-YTVHR-QBPX3-RJP64";

			public const string CoreSingleLanguage = "BB6NG-PQ82V-VRDPW-8XVD2-V8P66";

			public const string CoreCountrySpecific = "NCTT7-2RGK8-WMHRF-RY7YQ-JTXG3";

			public const string CoreConnected = "3PY8R-QHNP9-W7XQD-G6DPH-3J2C9";

			public const string CoreConnectedN = "Q6HTR-N24GM-PMJFP-69CD8-2GXKR";

			public const string CoreConnectedSingleLanguage = "KF37N-VDV38-GRRTV-XH8X6-6F3BB";

			public const string CoreConnectedCountrySpecific = "R962J-37N87-9VVK2-WJ74P-XTMHR";

			public const string EmbeddedIndustry = "NMMPB-38DD4-R2823-62W8D-VXKJB";

			public const string EmbeddedIndustryE = "FNFKF-PWTVT-9RC8H-32HB2-JB34X";

			public const string EmbeddedIndustryA = "VHXM3-NR6FT-RY6RT-CK882-KW2CJ";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindows8
		{
			public const string Professional = "NG4HW-VH26C-733KW-K6F98-J8CK4";

			public const string ProfessionalPreview = "TK8TP-9JN6P-7X7WW-RFFTV-B7QPF";

			public const string PreRelease = "DNJXJ-7XBW8-2378T-X22TX-BKG7J";

			public const string ProfessionalWMC = "GNBB8-YVD74-QJHX6-27H4K-8QHDG";

			public const string Enterprise = "32JNW-9KQ84-P47T8-D8GGY-CWCK7";

			public const string ProfessionalN = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";

			public const string EnterpriseN = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";

			public const string CoreARM = "DXHJF-N9KQX-MFPVR-GHGQK-Y7RKV";

			public const string Core = "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";

			public const string CoreN = "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY";

			public const string CoreSingleLanguage = "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";

			public const string CoreCountrySpecific = "4K36P-JN4VD-GDC6V-KDT89-DYFKP";

			public const string EmbeddedProfessional = "RYXVT-BNQG7-VD29F-DBMRY-HT73M";

			public const string EmbeddedEnterprise = "NKB3R-R2F8T-3XCDP-7Q2KW-XWYQ2";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindows7
		{
			public const string Professional = "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";

			public const string Enterprise = "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";

			public const string ProfessionalN = "MRPKT-YTG23-K7D7T-X2JMM-QY7MG";

			public const string EnterpriseN = "YDRBP-3D83W-TY26F-D46B2-XCKRJ";

			public const string ProfessionalE = "W82YF-2Q76Y-63HXB-FGJG9-GF7QX";

			public const string EnterpriseE = "C29WB-22CC8-VJ326-GHFJW-H9DH4";

			public const string Embedded = "73KQT-CD9G6-K7TQG-66MRP-CQ22C";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindowsVista
		{
			public const string Business = "YFKBB-PQJJV-G996G-VWGXY-2V3X8";

			public const string BusinessN = "HMBQG-8H2RH-C77VX-27R82-VMQBT";

			public const string Enterprise = "VKK3X-68KWM-X2YGT-QR4M6-4BWMV";

			public const string EnterpriseN = "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindowsServer2016
		{
			public const string ServerHICore = "7VX4N-3VDHQ-VYGHB-JXJVP-9QB26";

			public const string ServerHI = "7VX4N-3VDHQ-VYGHB-JXJVP-9QB26";

			public const string ServerSolutionCore = "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";

			public const string ServerSolution = "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";

			public const string ServerStandard = "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";

			public const string ServerCloudStorage = "3NPTF-33KPT-GGBPR-YX76B-39KDD";

			public const string ServerCloudStorageCore = "3NPTF-33KPT-GGBPR-YX76B-39KDD";

			public const string ServerDatacenter = "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9";

			public const string ServerStandardCore = "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";

			public const string ServerDatacenterPreview = "VRDD2-NVGDP-K7QG8-69BR4-TVFHB";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindowsServer2012R2
		{
			public const string ServerStandard = "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";

			public const string ServerDatacenter = "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9";

			public const string ServerDatacenterPreview = "VRDD2-NVGDP-K7QG8-69BR4-TVFHB";

			public const string ServerStandardCore = "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";

			public const string ServerDatacenterCore = "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9";

			public const string ServerCore = "";

			public const string ServerCoreN = "";

			public const string ServerMultiPointStandard = "";

			public const string ServerMultiPointPremium = "";

			public const string ServerCloudStorageCore = "3NPTF-33KPT-GGBPR-YX76B-39KDD";

			public const string ServerCloudStorage = "3NPTF-33KPT-GGBPR-YX76B-39KDD";

			public const string ServerSolutionCore = "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";

			public const string ServerSolution = "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindowsServer2012
		{
			public const string ServerStandard = "XC9B7-NBPP2-83J2H-RHMBY-92BT4";

			public const string ServerDatacenter = "48HP8-DN98B-MYWDG-T2DCC-8W83P";

			public const string ServerStandardCore = "XC9B7-NBPP2-83J2H-RHMBY-92BT4";

			public const string ServerDatacenterCore = "48HP8-DN98B-MYWDG-T2DCC-8W83P";

			public const string ServerCore = "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";

			public const string ServerCoreN = "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY";

			public const string ServerMultiPointStandard = "HM7DN-YVMH3-46JC3-XYTG7-CYQJJ";

			public const string ServerMultiPointPremium = "XNH6W-2V9GX-RGJ4K-Y8X6F-QGJ2G";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindowsServer2008R2
		{
			public const string ServerStandard = "YC6KT-GKW9T-YTKYR-T4X34-R7VHC";

			public const string ServerEnterprise = "489J6-VHDMP-X63PK-3K798-CPX3Y";

			public const string ServerDataCenter = "74YFP-3QFB3-KQT8W-PMXWJ-7M648";

			public const string ServerHPC = "TT8MH-CG224-D3D7Q-498W2-9QCTX";

			public const string ServerWeb = "6TPJF-RBVHG-WBW2R-86QPH-6RTM4";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysWindowsServer2008
		{
			public const string ServerStandard = "TM24T-X9RMF-VWXK6-X8JC9-BFGM2";

			public const string ServerEnterprise = "YQGMW-MPWTJ-34KDK-48M3W-X4Q6V";

			public const string ServerDataCenter = "7M67G-PC374-GR742-YH8V4-TCBY3";

			public const string ServerHPC = "RCTX3-KWVHP-BR6TB-RB6DM-6X7HP";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct KeysOffice
		{
			public const string Office2010ProPlus = "VYBBJ-TRJPB-QFQRF-QFT4D-H3GVB";

			public const string Office2010Std = "V7QKV-4XVVR-XYV4D-F7DFM-8R6BM";

			public const string Office2010Access = "V7Y44-9T38C-R2VJK-666HK-T7DDX";

			public const string Office2010Excel = "H62QG-HXVKF-PP4HP-66KMR-CW9BM";

			public const string Office2010SharePoint = "QYYW6-QP4CB-MBV6G-HYMCJ-4T3J4";

			public const string Office2010InfoPath = "K96W8-67RPQ-62T9Y-J8FQJ-BT37T";

			public const string Office2010OneNote = "Q4Y4M-RHWJM-PY37F-MTKWH-D3XHX";

			public const string Office2010Outlook = "7YDC2-CWM8M-RRTJC-8MDVC-X3DWQ";

			public const string Office2010PowerPoint = "RC8FX-88JRY-3PF7C-X8P67-P4VTT";

			public const string Office2010ProjectPro = "YGX6F-PGV49-PGW3J-9BTGG-VHKC6";

			public const string Office2010ProjectStd = "4HP3K-88W3F-W2K3D-6677X-F9PGB";

			public const string Office2010Publisher = "BFK7F-9MYHM-V68C7-DRQ66-83YTP";

			public const string Office2010VisioPro = "7MCW8-VRQVK-G677T-PDJCM-Q8TCP";

			public const string Office2010VisioPrem = "D9DWC-HPYVV-JGF4P-BTWQB-WX8BJ";

			public const string Office2010VisioStd = "767HD-QGMWX-8QTDB-9G3R2-KHFGJ";

			public const string Office2010Word = "HVHB3-C6FV7-KQX9W-YQG79-CRY7T";

			public const string Office2013ProPlus = "YC7DK-G2NP3-2QQC3-J6H88-GVGXT";

			public const string Office2013Std = "KBKQT-2NMXY-JJWGP-M62JB-92CD4";

			public const string Office2013Mondo = "42QTK-RN8M7-J3C4G-BBGYM-88CYV";

			public const string Office2013Access = "NG2JY-H4JBT-HQXYP-78QH9-4JM2D";

			public const string Office2013Excel = "VGPNG-Y7HQW-9RHP7-TKPV3-BG7GB";

			public const string Office2013InfoPath = "DKT8B-N7VXH-D963P-Q4PHY-F8894";

			public const string Office2013Lync = "2MG3G-3BNTT-3MFW9-KDQW3-TCK7R";

			public const string Office2013OneNote = "TGN6P-8MMBC-37P2F-XHXXK-P34VW";

			public const string Office2013Outlook = "QPN8Q-BJBTJ-334K3-93TGY-2PMBT";

			public const string Office2013PowerPoint = "4NT99-8RJFH-Q2VDH-KYG2C-4RD4F";

			public const string Office2013ProjectPro = "FN8TT-7WMH6-2D4X9-M337T-2342K";

			public const string Office2013ProjectStd = "6NTH3-CW976-3G3Y2-JK3TX-8QHTT";

			public const string Office2013Publisher = "PN2WF-29XG2-T9HJ7-JQPJR-FCXK4";

			public const string Office2013VisioPro = "C2FG9-N6J68-H8BTJ-BW3QX-RM3B3";

			public const string Office2013VisioStd = "J484Y-4NKBF-W2HMG-DBMJC-PGWR7";

			public const string Office2013Word = "6Q7VD-NX8JD-WJ2VH-88V73-4GBJ7";

			public const string Office2016ProPlus = "XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99";

			public const string Office2016Std = "JNRGM-WHDWX-FJJG3-K47QV-DRTFM";

			public const string Office2016Mondo = "42QTK-RN8M7-J3C4G-BBGYM-88CYV";

			public const string Office2016Access = "GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW";

			public const string Office2016Excel = "9C2PK-NWTVB-JMPW8-BFT28-7FTBF";

			public const string Office2016InfoPath = "DKT8B-N7VXH-D963P-Q4PHY-F8894";

			public const string Office2016Lync = "2MG3G-3BNTT-3MFW9-KDQW3-TCK7R";

			public const string Office2016OneNote = "DR92N-9HTF2-97XKM-XW2WJ-XW3J6";

			public const string Office2016Outlook = "R69KK-NTPKF-7M3Q4-QYBHW-6MT9B";

			public const string Office2016PowerPoint = "J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6";

			public const string Office2016ProjectPro = "YG9NW-3K39V-2T3HJ-93F3Q-G83KT";

			public const string Office2016ProjectStd = "GNFHQ-F6YQM-KQDGJ-327XX-KQBVC";

			public const string Office2016Publisher = "F47MM-N3XJP-TQXJ9-BP99D-8K837";

			public const string Office2016VisioPro = "PD3PC-RHNGV-FXJ29-8JK7D-RJRJK";

			public const string Office2016VisioStd = "7WHWN-4T7MP-G96JF-G33KR-W8GF4";

			public const string Office2016Word = "WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6";

			public const string Office2016Skype = "869NQ-FJ69K-466HW-QYCP2-DDBV6";
		}

		private static string smethod_0(ref Variables variables_0)
		{
			try
			{
				if (variables_0.IsWindows10)
				{
					if (!variables_0.IsServer)
					{
						return smethod_1(ref variables_0.EditionID, ref variables_0);
					}
					return smethod_4(ref variables_0.EditionID, ref variables_0);
				}
				if (variables_0.IsWindows81)
				{
					if (!variables_0.IsServer)
					{
						return smethod_2(ref variables_0.EditionID, ref variables_0);
					}
					return smethod_5(ref variables_0.EditionID);
				}
				if (variables_0.IsWindows8)
				{
					if (!variables_0.IsServer)
					{
						return smethod_3(ref variables_0.EditionID);
					}
					return smethod_6(ref variables_0.EditionID);
				}
				if (variables_0.IsWindows7)
				{
					if (!variables_0.IsServer)
					{
						return smethod_7(ref variables_0.EditionID);
					}
					return smethod_8(ref variables_0.EditionID);
				}
				if (variables_0.IsWindowsVista)
				{
					if (!variables_0.IsServer)
					{
						return smethod_10(ref variables_0.EditionID);
					}
					return smethod_9(ref variables_0.EditionID);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string str = exception_.Message + " " + Class2.smethod_4(ref exception_);
				FileLogger logger = variables_0.Logger;
				string message = "Error: " + str;
				logger.LogMessage(ref message);
				ProjectData.ClearProjectError();
			}
			return string.Empty;
		}

		private static string smethod_1(ref string string_0, ref Variables variables_0)
		{
			if (!variables_0.IsPreview)
			{
				string text = string_0;
				switch (Class83.smethod_0(text))
				{
				case 284165279u:
					if (Operators.CompareString(text, "ProfessionalWMC", false) == 0)
					{
						return "NKPM6-TCVPT-3HRFX-Q4H9B-QJ34Y";
					}
					break;
				case 279320640u:
					if (Operators.CompareString(text, "CoreARM", false) == 0)
					{
						return "7NX88-X6YM3-9Q3YT-CCGBF-KBVQF";
					}
					break;
				case 201349025u:
					if (Operators.CompareString(text, "EducationN", false) == 0)
					{
						return "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
					}
					break;
				case 290327408u:
					if (Operators.CompareString(text, "CoreN", false) == 0)
					{
						return "3KHY7-WNT83-DGQKR-F7HPR-844BM";
					}
					break;
				case 286266594u:
					if (Operators.CompareString(text, "Enterprise", false) == 0)
					{
						return "NPPR9-FWDCX-D2C8J-H872K-2YT43";
					}
					break;
				case 379705053u:
					if (Operators.CompareString(text, "EmbeddedIndustry", false) == 0)
					{
						return "XY4TQ-CXNVJ-YCT73-HH6R7-R897X";
					}
					break;
				case 379048501u:
					if (Operators.CompareString(text, "Education", false) == 0)
					{
						return "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
					}
					break;
				case 1040237652u:
					if (Operators.CompareString(text, "CoreSingleLanguage", false) == 0)
					{
						return "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
					}
					break;
				case 1019533204u:
					if (Operators.CompareString(text, "EmbeddedIndustryA", false) == 0)
					{
						return "GN2X2-KXTK6-P92FR-VBB9G-PDJFP";
					}
					break;
				case 952422728u:
					if (Operators.CompareString(text, "EmbeddedIndustryE", false) == 0)
					{
						return "XCNC9-BPK3C-KCCMD-FTDTC-KWY4G";
					}
					break;
				case 1569369246u:
					if (Operators.CompareString(text, "Core", false) == 0)
					{
						return "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
					}
					break;
				case 1391791790u:
					if (Operators.CompareString(text, "Home", false) == 0)
					{
						return "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
					}
					break;
				case 1694854857u:
					if (Operators.CompareString(text, "CoreConnectedN", false) == 0)
					{
						return "JQNT7-W63G4-WX4QX-RD9M9-6CPKM";
					}
					break;
				case 1658276631u:
					if (Operators.CompareString(text, "EnterpriseSN", false) == 0)
					{
						return "2F77B-TNFGY-69QQF-B8YKP-D69TJ";
					}
					break;
				case 2009492128u:
					if (Operators.CompareString(text, "HomeN", false) == 0)
					{
						return "3KHY7-WNT83-DGQKR-F7HPR-844BM";
					}
					break;
				case 1916366243u:
					if (Operators.CompareString(text, "ProfessionalS", false) == 0)
					{
						return "NFDD9-FX3VM-DYCKP-B8HT8-D9M2C";
					}
					break;
				case 1832478148u:
					if (Operators.CompareString(text, "ProfessionalN", false) == 0)
					{
						return "MH37W-N47XK-V7XM9-C7227-GCQG9";
					}
					break;
				case 2235990957u:
					if (Operators.CompareString(text, "ProfessionalStudentN", false) == 0)
					{
						return "8G9XJ-GN6PJ-GW787-MVV7G-GMR99";
					}
					break;
				case 2065149425u:
					if (Operators.CompareString(text, "ProfessionalStudent", false) == 0)
					{
						return "YNXW3-HV3VB-Y83VG-KPBXM-6VH3Q";
					}
					break;
				case 2370867875u:
					if (Operators.CompareString(text, "EnterpriseS", false) == 0)
					{
						return "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";
					}
					break;
				case 2286979780u:
					if (Operators.CompareString(text, "EnterpriseN", false) == 0)
					{
						return "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
					}
					break;
				case 3025581156u:
					if (Operators.CompareString(text, "HomeSingleLanguage", false) == 0)
					{
						return "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
					}
					break;
				case 2935940669u:
					if (Operators.CompareString(text, "CoreConnectedCountrySpecific", false) == 0)
					{
						return "FTNXM-J4RGP-MYQCV-RVM8R-TVH24";
					}
					break;
				case 3177712663u:
					if (Operators.CompareString(text, "ProfessionalSN", false) == 0)
					{
						return "8Q36Y-N2F39-HRMHT-4XW33-TCQR4";
					}
					break;
				case 3140712445u:
					if (Operators.CompareString(text, "CoreConnected", false) == 0)
					{
						return "DJMYQ-WN6HG-YJ2YX-82JDB-CWFCW";
					}
					break;
				case 3885129284u:
					if (Operators.CompareString(text, "HomeCountrySpecific", false) == 0)
					{
						return "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
					}
					break;
				case 3364771207u:
					if (Operators.CompareString(text, "CoreConnectedSingleLanguage", false) == 0)
					{
						return "QQMNF-GPVQ6-BFXGG-GWRCX-7XKT7";
					}
					break;
				case 4272272020u:
					if (Operators.CompareString(text, "CoreCountrySpecific", false) == 0)
					{
						return "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
					}
					break;
				case 4164464098u:
					if (Operators.CompareString(text, "Professional", false) == 0)
					{
						return "W269N-WFGWX-YVC9B-4J6C9-T83GX";
					}
					break;
				}
			}
			else
			{
				switch (string_0)
				{
				case "Education":
					return "YVKRN-H6QFQ-JQGG3-T7BF3-2WGQ7";
				case "Core":
					return "JTJ43-TNBFV-YDGKB-92WGV-GCQXV";
				case "Home":
					return "JTJ43-TNBFV-YDGKB-92WGV-GCQXV";
				case "Enterprise":
					return "MFY6B-WNCVR-9KWQ4-9CGGM-QJ3YW";
				case "Professional":
					return "43BNY-B3MHX-37RT3-HT88J-33XGM";
				}
			}
			return string.Empty;
		}

		private static string smethod_2(ref string string_0, ref Variables variables_0)
		{
			if (!variables_0.IsPreview)
			{
				string text = string_0;
				switch (Class83.smethod_0(text))
				{
				case 284165279u:
					if (Operators.CompareString(text, "ProfessionalWMC", false) == 0)
					{
						return "789NJ-TQK6T-6XTH8-J39CJ-J8D3P";
					}
					break;
				case 279320640u:
					if (Operators.CompareString(text, "CoreARM", false) == 0)
					{
						return "XYTND-K6QKT-K2MRH-66RTM-43JKP";
					}
					break;
				case 290327408u:
					if (Operators.CompareString(text, "CoreN", false) == 0)
					{
						return "7B9N3-D94CG-YTVHR-QBPX3-RJP64";
					}
					break;
				case 286266594u:
					if (Operators.CompareString(text, "Enterprise", false) == 0)
					{
						return "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
					}
					break;
				case 952422728u:
					if (Operators.CompareString(text, "EmbeddedIndustryE", false) == 0)
					{
						return "FNFKF-PWTVT-9RC8H-32HB2-JB34X";
					}
					break;
				case 379705053u:
					if (Operators.CompareString(text, "EmbeddedIndustry", false) == 0)
					{
						return "NMMPB-38DD4-R2823-62W8D-VXKJB";
					}
					break;
				case 1569369246u:
					if (Operators.CompareString(text, "Core", false) == 0)
					{
						return "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";
					}
					break;
				case 1040237652u:
					if (Operators.CompareString(text, "CoreSingleLanguage", false) == 0)
					{
						return "BB6NG-PQ82V-VRDPW-8XVD2-V8P66";
					}
					break;
				case 1019533204u:
					if (Operators.CompareString(text, "EmbeddedIndustryA", false) == 0)
					{
						return "VHXM3-NR6FT-RY6RT-CK882-KW2CJ";
					}
					break;
				case 1832478148u:
					if (Operators.CompareString(text, "ProfessionalN", false) == 0)
					{
						return "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
					}
					break;
				case 1694854857u:
					if (Operators.CompareString(text, "CoreConnectedN", false) == 0)
					{
						return "Q6HTR-N24GM-PMJFP-69CD8-2GXKR";
					}
					break;
				case 2286979780u:
					if (Operators.CompareString(text, "EnterpriseN", false) == 0)
					{
						return "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
					}
					break;
				case 2235990957u:
					if (Operators.CompareString(text, "ProfessionalStudentN", false) == 0)
					{
						return "TNFGH-2R6PB-8XM3K-QYHX2-J4296";
					}
					break;
				case 2065149425u:
					if (Operators.CompareString(text, "ProfessionalStudent", false) == 0)
					{
						return "NQHYK-WGWJH-DQJT7-XB68G-BPYG9";
					}
					break;
				case 3140712445u:
					if (Operators.CompareString(text, "CoreConnected", false) == 0)
					{
						return "3PY8R-QHNP9-W7XQD-G6DPH-3J2C9";
					}
					break;
				case 2935940669u:
					if (Operators.CompareString(text, "CoreConnectedCountrySpecific", false) == 0)
					{
						return "R962J-37N87-9VVK2-WJ74P-XTMHR";
					}
					break;
				case 4272272020u:
					if (Operators.CompareString(text, "CoreCountrySpecific", false) == 0)
					{
						return "NCTT7-2RGK8-WMHRF-RY7YQ-JTXG3";
					}
					break;
				case 4164464098u:
					if (Operators.CompareString(text, "Professional", false) == 0)
					{
						return "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
					}
					break;
				case 3364771207u:
					if (Operators.CompareString(text, "CoreConnectedSingleLanguage", false) == 0)
					{
						return "KF37N-VDV38-GRRTV-XH8X6-6F3BB";
					}
					break;
				}
			}
			else
			{
				switch (string_0)
				{
				case "Enterprise":
					return "2MP7K-98NK8-WPVF3-Q2WDG-VMD98";
				case "ProfessionalWMC":
					return "MY4N9-TGH34-4X4VY-8FG2T-RRDPV";
				case "Professional":
					return "MTWNQ-CKDHJ-3HXW9-Q2PFX-WB2HQ";
				}
			}
			return string.Empty;
		}

		private static string smethod_3(ref string string_0)
		{
			string text = string_0;
			switch (Class83.smethod_0(text))
			{
			case 284165279u:
				if (Operators.CompareString(text, "ProfessionalWMC", false) == 0)
				{
					return "GNBB8-YVD74-QJHX6-27H4K-8QHDG";
				}
				goto default;
			case 279320640u:
				if (Operators.CompareString(text, "CoreARM", false) == 0)
				{
					return "DXHJF-N9KQX-MFPVR-GHGQK-Y7RKV";
				}
				goto default;
			case 1040237652u:
				if (Operators.CompareString(text, "CoreSingleLanguage", false) == 0)
				{
					return "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";
				}
				goto default;
			case 290327408u:
				if (Operators.CompareString(text, "CoreN", false) == 0)
				{
					return "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY";
				}
				goto default;
			case 286266594u:
				if (Operators.CompareString(text, "Enterprise", false) == 0)
				{
					return "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
				}
				goto default;
			case 2286979780u:
				if (Operators.CompareString(text, "EnterpriseN", false) == 0)
				{
					return "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
				}
				goto default;
			case 1832478148u:
				if (Operators.CompareString(text, "ProfessionalN", false) == 0)
				{
					return "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
				}
				goto default;
			case 1569369246u:
				if (Operators.CompareString(text, "Core", false) == 0)
				{
					return "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
				}
				goto default;
			case 4272272020u:
				if (Operators.CompareString(text, "CoreCountrySpecific", false) == 0)
				{
					return "4K36P-JN4VD-GDC6V-KDT89-DYFKP";
				}
				goto default;
			case 4164464098u:
				if (Operators.CompareString(text, "Professional", false) == 0)
				{
					return "NG4HW-VH26C-733KW-K6F98-J8CK4";
				}
				goto default;
			case 3011034031u:
				if (Operators.CompareString(text, "Prerelease", false) == 0)
				{
					return "DNJXJ-7XBW8-2378T-X22TX-BKG7J";
				}
				goto default;
			default:
				return string.Empty;
			}
		}

		private static string smethod_4(ref string string_0, ref Variables variables_0)
		{
			if (!variables_0.IsPreview)
			{
				string text = string_0;
				switch (Class83.smethod_0(text))
				{
				case 527056604u:
					if (Operators.CompareString(text, "ServerCloudStorage", false) == 0)
					{
						return "3NPTF-33KPT-GGBPR-YX76B-39KDD";
					}
					break;
				case 233591429u:
					if (Operators.CompareString(text, "ServerHI", false) == 0)
					{
						return "7VX4N-3VDHQ-VYGHB-JXJVP-9QB26";
					}
					break;
				case 3455999176u:
					if (Operators.CompareString(text, "ServerStandardCore", false) == 0)
					{
						return "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";
					}
					break;
				case 3401765283u:
					if (Operators.CompareString(text, "ServerStandard", false) == 0)
					{
						return "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";
					}
					break;
				case 3649601129u:
					if (Operators.CompareString(text, "ServerSolution", false) == 0)
					{
						return "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";
					}
					break;
				case 3491518331u:
					if (Operators.CompareString(text, "ServerCloudStorageCore", false) == 0)
					{
						return "3NPTF-33KPT-GGBPR-YX76B-39KDD";
					}
					break;
				case 4082463954u:
					if (Operators.CompareString(text, "ServerSolutionCore", false) == 0)
					{
						return "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";
					}
					break;
				case 3993874526u:
					if (Operators.CompareString(text, "ServerHICore", false) == 0)
					{
						return "7VX4N-3VDHQ-VYGHB-JXJVP-9QB26";
					}
					break;
				case 3824071431u:
					if (Operators.CompareString(text, "ServerDatacenter", false) == 0)
					{
						return "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9";
					}
					break;
				}
			}
			else
			{
				string text2 = string_0;
				if (Operators.CompareString(text2, "ServerDatacenter", false) == 0)
				{
					if (variables_0.CurrentBuild.StartsWith("98"))
					{
						return "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9";
					}
					return "VRDD2-NVGDP-K7QG8-69BR4-TVFHB";
				}
			}
			return string.Empty;
		}

		private static string smethod_5(ref string string_0)
		{
			string text = string_0;
			switch (Class83.smethod_0(text))
			{
			case 1326787857u:
				if (Operators.CompareString(text, "ServerCoreN", false) == 0)
				{
					return "";
				}
				goto default;
			case 527056604u:
				if (Operators.CompareString(text, "ServerCloudStorage", false) == 0)
				{
					return "3NPTF-33KPT-GGBPR-YX76B-39KDD";
				}
				goto default;
			case 268379036u:
				if (Operators.CompareString(text, "ServerMultiPointPremium", false) == 0)
				{
					return "";
				}
				goto default;
			case 2677852732u:
				if (Operators.CompareString(text, "ServerDatacenterCore", false) == 0)
				{
					return "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9";
				}
				goto default;
			case 2280928442u:
				if (Operators.CompareString(text, "ServerMultiPointStandard", false) == 0)
				{
					return "";
				}
				goto default;
			case 2099694853u:
				if (Operators.CompareString(text, "ServerCore", false) == 0)
				{
					return "";
				}
				goto default;
			case 3491518331u:
				if (Operators.CompareString(text, "ServerCloudStorageCore", false) == 0)
				{
					return "3NPTF-33KPT-GGBPR-YX76B-39KDD";
				}
				goto default;
			case 3455999176u:
				if (Operators.CompareString(text, "ServerStandardCore", false) == 0)
				{
					return "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";
				}
				goto default;
			case 3401765283u:
				if (Operators.CompareString(text, "ServerStandard", false) == 0)
				{
					return "D2N9P-3P6X9-2R39C-7RTCD-MDVJX";
				}
				goto default;
			case 4082463954u:
				if (Operators.CompareString(text, "ServerSolutionCore", false) == 0)
				{
					return "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";
				}
				goto default;
			case 3824071431u:
				if (Operators.CompareString(text, "ServerDatacenter", false) == 0)
				{
					return "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9";
				}
				goto default;
			case 3649601129u:
				if (Operators.CompareString(text, "ServerSolution", false) == 0)
				{
					return "KNC87-3J2TX-XB4WP-VCPJV-M4FWM";
				}
				goto default;
			default:
				return string.Empty;
			}
		}

		private static string smethod_6(ref string string_0)
		{
			string text = string_0;
			switch (Class83.smethod_0(text))
			{
			case 1326787857u:
				if (Operators.CompareString(text, "ServerCoreN", false) == 0)
				{
					return "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY";
				}
				goto default;
			case 268379036u:
				if (Operators.CompareString(text, "ServerMultiPointPremium", false) == 0)
				{
					return "XNH6W-2V9GX-RGJ4K-Y8X6F-QGJ2G";
				}
				goto default;
			case 2280928442u:
				if (Operators.CompareString(text, "ServerMultiPointStandard", false) == 0)
				{
					return "HM7DN-YVMH3-46JC3-XYTG7-CYQJJ";
				}
				goto default;
			case 2099694853u:
				if (Operators.CompareString(text, "ServerCore", false) == 0)
				{
					return "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
				}
				goto default;
			case 3401765283u:
				if (Operators.CompareString(text, "ServerStandard", false) == 0)
				{
					return "XC9B7-NBPP2-83J2H-RHMBY-92BT4";
				}
				goto default;
			case 2677852732u:
				if (Operators.CompareString(text, "ServerDatacenterCore", false) == 0)
				{
					return "48HP8-DN98B-MYWDG-T2DCC-8W83P";
				}
				goto default;
			case 3824071431u:
				if (Operators.CompareString(text, "ServerDatacenter", false) == 0)
				{
					return "48HP8-DN98B-MYWDG-T2DCC-8W83P";
				}
				goto default;
			case 3455999176u:
				if (Operators.CompareString(text, "ServerStandardCore", false) == 0)
				{
					return "XC9B7-NBPP2-83J2H-RHMBY-92BT4";
				}
				goto default;
			default:
				return string.Empty;
			}
		}

		private static string smethod_7(ref string string_0)
		{
			string text = string_0;
			switch (Class83.smethod_0(text))
			{
			case 1748590053u:
				if (Operators.CompareString(text, "ProfessionalE", false) == 0)
				{
					return "W82YF-2Q76Y-63HXB-FGJG9-GF7QX";
				}
				goto default;
			case 588384575u:
				if (Operators.CompareString(text, "Embedded", false) == 0)
				{
					return "73KQT-CD9G6-K7TQG-66MRP-CQ22C";
				}
				goto default;
			case 286266594u:
				if (Operators.CompareString(text, "Enterprise", false) == 0)
				{
					return "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";
				}
				goto default;
			case 2203091685u:
				if (Operators.CompareString(text, "EnterpriseE", false) == 0)
				{
					return "C29WB-22CC8-VJ326-GHFJW-H9DH4";
				}
				goto default;
			case 1832478148u:
				if (Operators.CompareString(text, "ProfessionalN", false) == 0)
				{
					return "MRPKT-YTG23-K7D7T-X2JMM-QY7MG";
				}
				goto default;
			case 4164464098u:
				if (Operators.CompareString(text, "Professional", false) == 0)
				{
					return "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";
				}
				goto default;
			case 2286979780u:
				if (Operators.CompareString(text, "EnterpriseN", false) == 0)
				{
					return "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
				}
				goto default;
			default:
				return string.Empty;
			}
		}

		private static string smethod_8(ref string string_0)
		{
			return string_0 switch
			{
				"ServerWeb" => "6TPJF-RBVHG-WBW2R-86QPH-6RTM4", 
				"ServerHPC" => "TT8MH-CG224-D3D7Q-498W2-9QCTX", 
				"ServerEnterprise" => "489J6-VHDMP-X63PK-3K798-CPX3Y", 
				"ServerDatacenter" => "74YFP-3QFB3-KQT8W-PMXWJ-7M648", 
				"ServerStandard" => "YC6KT-GKW9T-YTKYR-T4X34-R7VHC", 
				_ => string.Empty, 
			};
		}

		private static string smethod_9(ref string string_0)
		{
			return string_0 switch
			{
				"ServerHPC" => "RCTX3-KWVHP-BR6TB-RB6DM-6X7HP", 
				"ServerEnterprise" => "YQGMW-MPWTJ-34KDK-48M3W-X4Q6V", 
				"ServerDatacenter" => "7M67G-PC374-GR742-YH8V4-TCBY3", 
				"ServerStandard" => "TM24T-X9RMF-VWXK6-X8JC9-BFGM2", 
				_ => string.Empty, 
			};
		}

		private static string smethod_10(ref string string_0)
		{
			string text = string_0;
			switch (Class83.smethod_0(text))
			{
			case 198782180u:
				if (Operators.CompareString(text, "ENTERPRISEN", false) == 0)
				{
					return "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
				}
				goto default;
			case 131837803u:
				if (Operators.CompareString(text, "Business", false) == 0)
				{
					return "YFKBB-PQJJV-G996G-VWGXY-2V3X8";
				}
				goto default;
			case 1801109058u:
				if (Operators.CompareString(text, "ENTERPRISE", false) == 0)
				{
					return "VKK3X-68KWM-X2YGT-QR4M6-4BWMV";
				}
				goto default;
			case 286266594u:
				if (Operators.CompareString(text, "Enterprise", false) == 0)
				{
					return "VKK3X-68KWM-X2YGT-QR4M6-4BWMV";
				}
				goto default;
			case 2211755839u:
				if (Operators.CompareString(text, "BusinessN", false) == 0)
				{
					return "HMBQG-8H2RH-C77VX-27R82-VMQBT";
				}
				goto default;
			case 1997556511u:
				if (Operators.CompareString(text, "BUSINESSN", false) == 0)
				{
					return "HMBQG-8H2RH-C77VX-27R82-VMQBT";
				}
				goto default;
			case 2629154699u:
				if (Operators.CompareString(text, "BUSINESS", false) == 0)
				{
					return "YFKBB-PQJJV-G996G-VWGXY-2V3X8";
				}
				goto default;
			case 2286979780u:
				if (Operators.CompareString(text, "EnterpriseN", false) == 0)
				{
					return "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
				}
				goto default;
			default:
				return string.Empty;
			}
		}

		internal static bool smethod_11(ref SoftwareLicensingProduct softwareLicensingProduct_0, bool bool_0, ref Variables variables_0)
		{
			string empty = string.Empty;
			uint num = 1u;
			string string_ = null;
			empty = ((!bool_0 || variables_0.IsWindowsPermanentActivate) ? smethod_16(softwareLicensingProduct_0.Name) : smethod_0(ref variables_0));
			if (!string.IsNullOrEmpty(empty) && softwareLicensingProduct_0 != null)
			{
				string partialProductKey = softwareLicensingProduct_0.PartialProductKey;
				if (empty.Contains(partialProductKey))
				{
					return true;
				}
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				num = Class17.smethod_34(ref softwareLicensingService_, ref empty, ref variables_0, ref string_);
				if ((long)num == 0L && string_ == null)
				{
					if (!Class17.smethod_27(softwareLicensingProduct_0.Description) && (!bool_0 || !variables_0.IsPreview))
					{
						FileLogger logger = variables_0.Logger;
						string message = "Converting: " + softwareLicensingProduct_0.Name;
						logger.LogMessage(ref message);
						FileLogger logger2 = variables_0.Logger;
						message = "UnInstalling Key";
						logger2.LogMessage(ref message);
						Class17.smethod_39(ref softwareLicensingProduct_0, ref variables_0);
						return true;
					}
				}
				else if (((long)num == 1L && string_.Contains("C004E016")) || string_.Contains("C004F069"))
				{
					if (bool_0)
					{
						RT2VL.smethod_1(ref variables_0);
					}
					else if (softwareLicensingProduct_0.Name.Contains("Office 15"))
					{
						string message = string.Empty;
						RT2VL.smethod_4(ref message, ref variables_0);
					}
					else if (softwareLicensingProduct_0.Name.Contains("Office 16"))
					{
						string message = string.Empty;
						string string_2 = softwareLicensingProduct_0.Name;
						RT2VL.smethod_3(ref message, ref variables_0, ref string_2);
					}
				}
			}
			return false;
		}

		internal static bool smethod_12(ref string string_0, ref Variables variables_0)
		{
			string empty = string.Empty;
			uint num = 1u;
			string string_ = null;
			bool num2 = string_0.Contains("Windows");
			bool flag = string_0.Contains("Office 16");
			bool flag2 = string_0.Contains("Office 15");
			bool flag3 = string_0.Contains("Office 14");
			empty = ((!num2) ? smethod_16(string_0) : smethod_0(ref variables_0));
			if (num2)
			{
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				num = Class17.smethod_34(ref softwareLicensingService_, ref empty, ref variables_0, ref string_);
			}
			else if (!flag2 && !flag)
			{
				if (flag3)
				{
					OfficeSoftwareProtectionService officeSoftwareProtectionService_ = Class17.smethod_50(ref variables_0);
					num = Class17.smethod_35(ref officeSoftwareProtectionService_, ref empty, ref variables_0, ref string_);
				}
			}
			else if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
			{
				if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
				{
					OfficeSoftwareProtectionService officeSoftwareProtectionService_ = Class17.smethod_50(ref variables_0);
					num = Class17.smethod_35(ref officeSoftwareProtectionService_, ref empty, ref variables_0, ref string_);
				}
			}
			else
			{
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				num = Class17.smethod_34(ref softwareLicensingService_, ref empty, ref variables_0, ref string_);
			}
			if ((long)num == 0L && string_ == null)
			{
				return true;
			}
			return false;
		}

		internal static bool smethod_13(ref string string_0, ref bool bool_0, ref bool bool_1, ref bool bool_2, ref bool bool_3, ref Variables variables_0)
		{
			uint num = 1u;
			string string_ = null;
			if (bool_0)
			{
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				num = Class17.smethod_34(ref softwareLicensingService_, ref string_0, ref variables_0, ref string_);
			}
			else if (!bool_2 && !bool_1)
			{
				if (bool_3)
				{
					OfficeSoftwareProtectionService officeSoftwareProtectionService_ = Class17.smethod_50(ref variables_0);
					num = Class17.smethod_35(ref officeSoftwareProtectionService_, ref string_0, ref variables_0, ref string_);
				}
			}
			else if (!variables_0.IsWindows10 && !variables_0.IsWindows81 && !variables_0.IsWindows8)
			{
				if (variables_0.IsWindows7 || variables_0.IsWindowsVista)
				{
					OfficeSoftwareProtectionService officeSoftwareProtectionService_ = Class17.smethod_50(ref variables_0);
					num = Class17.smethod_35(ref officeSoftwareProtectionService_, ref string_0, ref variables_0, ref string_);
				}
			}
			else
			{
				SoftwareLicensingService softwareLicensingService_ = Class17.smethod_49(ref variables_0);
				num = Class17.smethod_34(ref softwareLicensingService_, ref string_0, ref variables_0, ref string_);
			}
			if ((long)num == 0L && string_ == null)
			{
				return true;
			}
			return false;
		}

		internal static bool smethod_14(ref OfficeSoftwareProtectionProduct officeSoftwareProtectionProduct_0, ref Variables variables_0)
		{
			string string_ = smethod_16(officeSoftwareProtectionProduct_0.Name);
			uint num = 1u;
			string string_2 = null;
			if (officeSoftwareProtectionProduct_0 != null)
			{
				if (string_.Contains(officeSoftwareProtectionProduct_0.PartialProductKey))
				{
					return true;
				}
				OfficeSoftwareProtectionService officeSoftwareProtectionService_ = Class17.smethod_50(ref variables_0);
				num = Class17.smethod_35(ref officeSoftwareProtectionService_, ref string_, ref variables_0, ref string_2);
				if ((long)num == 0L && string_2 == null)
				{
					if (!Class17.smethod_27(officeSoftwareProtectionProduct_0.Description))
					{
						FileLogger logger = variables_0.Logger;
						string message = "Converting: " + officeSoftwareProtectionProduct_0.Name;
						logger.LogMessage(ref message);
						Class17.smethod_40(ref officeSoftwareProtectionProduct_0, ref variables_0);
						return true;
					}
				}
				else if ((long)num == 1L && string_2.Contains("C004E016"))
				{

