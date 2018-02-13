﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FMOD.Sharp.Enums;

namespace FMOD.Sharp.Data
{
	public class SyncPointInfo
	{
		public string Name { get; set; }

		public uint Offset { get; set; }

		public TimeUnit OffsetTimeUnit { get; set; }
	}
}
