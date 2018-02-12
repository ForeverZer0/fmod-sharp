﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using FMOD.Sharp.Enums;

namespace FMOD.Sharp.Structs
{
	[StructLayout(LayoutKind.Sequential)]
    public struct AsyncReadInfo
    {
        public IntPtr   Handle;                    
        public uint     Offset;                    
        public uint     SizeBytes;                 
        public int      Priority;                  

        public IntPtr   UserData;                  
        public IntPtr   Buffer;                    
        public uint     BytesRead;                 
        public AsyncReadInfoDoneCallback   done; 
    }																																																																
}
