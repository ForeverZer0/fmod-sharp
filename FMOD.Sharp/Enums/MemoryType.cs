﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FMOD.Sharp.Enums
{
	[Flags]
    public enum MemoryType : uint
    {
        Normal             = 0x00000000,  
        StreamFile        = 0x00000001,   
        StreamDecode      = 0x00000002,   
        SampleData         = 0x00000004,  
        DspBuffer         = 0x00000008,   
        Plugin             = 0x00000010,  
        Xbox360Physical   = 0x00100000,   
        Persistent         = 0x00200000,  
        Secondary          = 0x00400000,  
        All                = 0xFFFFFFFF
    }


}
