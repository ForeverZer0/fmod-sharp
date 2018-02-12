﻿		/* >> Code generated by FMOD# DspFactory << */

using System;

namespace FMOD.Sharp.Dsps
{




	public class Fft : Dsp
	{
		public Fft(IntPtr handle) : base(handle)
		{
		}

		public int Size
		{
			get => GetParameterInt(0);
			set => SetParameterInt(0, value.Clamp(128, 16384));
		}

		public int Type
		{
			get => GetParameterInt(1);
			set => SetParameterInt(1, value.Clamp(0, 5));
		}

		public byte[] GetSpectrumData()
		{
			return GetParameterData(2);
		}

		public float DominantFreq
		{
			get => GetParameterFloat(3);
			set => SetParameterFloat(3, value.Clamp(0.0f, 5.0f));
		}
	}
}
