using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GPMDP_MSNMessenger
{
    public enum MsnIconTypes
    {
        None,
        Music,
        Games,
        Office
    }

    static class MSNStatus
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hwnd, uint wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "FindWindowExA")]
        private static extern IntPtr FindWindowEx(IntPtr hWnd1, IntPtr hWnd2, string lpsz1, string lpsz2);

        [StructLayout(LayoutKind.Sequential)]
        private struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            public IntPtr lpData;
        }
        private const int WM_COPYDATA = 0x4A;

        private static IntPtr VarPtr(object e)
        {
            GCHandle GC = GCHandle.Alloc(e, GCHandleType.Pinned);
            IntPtr gc = GC.AddrOfPinnedObject();
            GC.Free();
            return gc;
        }

        public static void Set(bool enable, MsnIconTypes icon, string str1, string str2, string str3, string str4)
        {
            string format;
            if (icon == MsnIconTypes.Music)
            {
                format = "{0} - {1}";
            }
            else
            {
                format = "{0}";
            }

            string buffer = "\\0" + icon.ToString() + "\\0" + (enable ? "1" : "0") + "\\0" + format + "\\0" + str1 + "\\0" + str2 + "\\0" + str3 + "\\0" + str4 + "\\0\0";

            int handle = 0;
            IntPtr handlePtr = new IntPtr(handle);

            COPYDATASTRUCT data;
            data.dwData = (IntPtr)0x0547;
            data.lpData = VarPtr(buffer);
            data.cbData = buffer.Length * 2;

            handlePtr = FindWindowEx(IntPtr.Zero, handlePtr, "MsnMsgrUIManager", null);
            if (handlePtr.ToInt32() > 0)
                SendMessage(handlePtr, WM_COPYDATA, IntPtr.Zero, VarPtr(data));
        }

        public static void SetGame(string name)
        {
            Set(true, MsnIconTypes.Games, name, "", "", "");
        }

        public static void SetMusic(string artist, string title, string album)
        {
            Set(true, MsnIconTypes.Music, artist, title, album, null);
        }

        public static void SetOffice(string msg)
        {
            Set(true, MsnIconTypes.Office, msg, "", "", "");
        }

        public static void Clear()
        {
            Set(false, MsnIconTypes.Music, "", "", "", "");
        }
    }

}
