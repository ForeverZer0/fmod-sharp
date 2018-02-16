﻿using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using FMOD.Enumerations;

namespace FMOD.Core
{
	[SuppressUnmanagedCodeSecurity][SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public partial class DspConnection
	{
		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		// TODO: The mix matrix can't be right, need some testing...
		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels,
			int inchannels, int inChannelHop);

		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix,
			out int outchannels, out int inchannels, int inChannelHop);

		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_GetType(IntPtr dspconnection, out DspConnectionType type);

		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[DllImport(Constants.LIBRARY)]
		private static extern Result FMOD_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);
	}
}