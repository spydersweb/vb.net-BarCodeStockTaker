Imports Microsoft.Win32
Imports System.Drawing
Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class LockDown
    Implements IDisposable

    Private hardwareDoneKeyEnabled As Integer
    Private hardwareStartKeyEnabled As Integer
    Private MENUBAR As String
    Private textModeEnabled As Integer


    Public Enum FullScreenStates
        SHFS_SHOWTASKBAR = 1
        SHFS_HIDETASKBAR = 2
        SHFS_SHOWSIPBUTTON = 4
        SHFS_HIDESIPBUTTON = 8
        SHFS_SHOWSTARTICON = 16
        SHFS_HIDESTARTICON = 32
    End Enum

    Public Enum GetWindowFlags
        GW_HWNDFIRST = 0
        GW_HWNDLAST = 1
        GW_HWNDNEXT = 2
        GW_HWNDPREV = 3
        GW_OWNER = 4
        GW_CHILD = 5
        GW_MAX = 5
    End Enum

    <System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)> _
    Public Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    Public Enum ShowWindowFlags
        SW_HIDE = 0
        SW_SHOWNORMAL = 1
        SW_SHOWNOACTIVATE = 4
        SW_SHOW = 5
        SW_MINIMIZE = 6
        SW_SHOWNA = 8
        SW_SHOWMAXIMIZED = 11
        SW_MAXIMIZE = 12
        SW_RESTORE = 13
    End Enum

    Public Sub New()
        MENUBAR = "SOFTWARE\\Microsoft\\Shell\\BubbleTiles"
        SaveRegistryFullScreen()
        textModeEnabled = -1
        hardwareStartKeyEnabled = -1
        hardwareDoneKeyEnabled = -1
    End Sub

<DllImportAttribute("coredll.dll", EntryPoint = "AllKeys", SetLastError = true, PreserveSig = true, CallingConvention = CallingConvention.Winapi)>
        <PreserveSigAttribute()> _
        public static extern bool AllKeys(bool bAllKeys)

        [DllImportAttribute("coredll.dll", EntryPoint = "FindWindow", SetLastError = true, PreserveSig = true, CallingConvention = CallingConvention.Winapi)]
        [PreserveSigAttribute()]
        private static extern IntPtr FindWindow(string className, string wndName);
        [DllImportAttribute]("coredll.dll", EntryPoint = "GetCapture", SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi)]
        [PreserveSigAttribute()]
        private static extern IntPtr GetCapture();
        [DllImportAttribute("coredll.dll", EntryPoint = "GetWindow", SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi)]
        [PreserveSigAttribute()]
        private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);
        [DllImportAttribute("coredll.dll", EntryPoint = "MoveWindow", SetLastError = true, PreserveSig = true, CallingConvention = CallingConvention.Winapi)]
        [PreserveSigAttribute()]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        public static bool RestoreRegistryFullScreen()
        {
            Exception exception1;
            RegistryKey registryKey1 = ((RegistryKey)null);
            try
            {
                registryKey1 = Registry.LocalMachine.OpenSubKey(LockDown.MENUBAR, true);
                if (LockDown.textModeEnabled >= 0)
                {
                    registryKey1.SetValue("TextmodeEnabled", LockDown.textModeEnabled, RegistryValueKind.DWord);
                }
                else
                {
                    registryKey1.DeleteValue("TextmodeEnabled", false);
                }
                if (LockDown.hardwareStartKeyEnabled >= 0)
                {
                    registryKey1.SetValue("HardwareStartKeyEnabled", LockDown.hardwareStartKeyEnabled, RegistryValueKind.DWord);
                }
                else
                {
                    registryKey1.DeleteValue("HardwareStartKeyEnabled", false);
                }
                if (LockDown.hardwareDoneKeyEnabled >= 0)
                {
                    registryKey1.SetValue("HardwareDoneKeyEnabled", LockDown.hardwareDoneKeyEnabled, RegistryValueKind.DWord);
                }
                else
                {
                    registryKey1.DeleteValue("HardwareDoneKeyEnabled", false);
                }
                registryKey1.Close();
            }
            catch (Exception exception2)
            {
                exception1 = exception2;
                if (registryKey1 != null)
                {
                    registryKey1.Close();
                }
                DialogResult dialogResult1 = MessageBox.Show(("Error in RestoreRegistryFullScreen: " + exception1.Message));
                return false;
            }
            return true;
        }

        public static bool SaveRegistryFullScreen()
        {
            RegistryKey registryKey1 = ((RegistryKey)null);
            try
            {
                registryKey1 = Registry.LocalMachine.OpenSubKey(LockDown.MENUBAR, true);
                try
                {
                    LockDown.textModeEnabled = ((int)registryKey1.GetValue("TextmodeEnabled", -1));
                }
                catch
                {
                    textModeEnabled = -1;
                }
                try
                {
                    LockDown.hardwareStartKeyEnabled = ((int)registryKey1.GetValue("HardwareStartKeyEnabled", -1));
                }
                catch
                {
                    LockDown.hardwareStartKeyEnabled = -1;
                }
                try
                {
                    LockDown.hardwareDoneKeyEnabled = ((int)registryKey1.GetValue("HardwareDoneKeyEnabled", -1));
                }
                catch
                {
                    LockDown.hardwareDoneKeyEnabled = -1;
                }
                registryKey1.Close();
            }
            catch
            {
                if (registryKey1 != null)
                {
                    registryKey1.Close();
                }
                return false;
            }
            return true;
        }



    Sub Dispose()
        RestoreRegistryFullScreen()
    End Sub

End Class
