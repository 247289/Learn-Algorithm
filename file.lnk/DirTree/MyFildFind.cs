﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lnkFile.DirTree
{
    // Declares a class member for structure element.
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class FindData
    {
        public int fileAttributes = 0;
        // creationTime was an embedded FILETIME structure.
        public int creationTime_lowDateTime = 0;
        public int creationTime_highDateTime = 0;
        // lastAccessTime was an embedded FILETIME structure.
        public int lastAccessTime_lowDateTime = 0;
        public int lastAccessTime_highDateTime = 0;
        // lastWriteTime was an embedded FILETIME structure.
        public int lastWriteTime_lowDateTime = 0;
        public int lastWriteTime_highDateTime = 0;
        public int nFileSizeHigh = 0;
        public int nFileSizeLow = 0;
        public int dwReserved0 = 0;
        public int dwReserved1 = 0;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public String fileName = null;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public String alternateFileName = null;
    }

    public class MyFileFind
    {
        // Declares a managed prototype for the unmanaged function.
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindFirstFile(String fileName, [In, Out] FindData findFileData);
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern Boolean FindNextFile(IntPtr handle, [In, Out] FindData findFileData);
    }
}
