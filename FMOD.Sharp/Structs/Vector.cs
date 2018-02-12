﻿using System;
using System.Runtime.InteropServices;

namespace FMOD.Sharp.Structs
{
	[StructLayout(LayoutKind.Sequential)][Serializable]
	public struct Vector
	{

		public float X;
		public float Y;
		public float Z;

		public static Vector Zero { get => new Vector(); }
	}
}