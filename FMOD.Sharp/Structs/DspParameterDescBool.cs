﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using FMOD.Sharp.Enums;

namespace FMOD.Sharp.Structs
{
	[StructLayout(LayoutKind.Sequential)]
    public struct DspParameterDescBool
    {
        public bool                      DefaultValues;             
        public IntPtr                    ValueNames;             																																																																																																																																		   
    }
}
