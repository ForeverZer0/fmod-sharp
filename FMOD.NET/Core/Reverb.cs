﻿using System;
using FMOD.NET.Data;
using FMOD.NET.Structures;

namespace FMOD.NET.Core
{ // TODO: Finish seealso tags once classes our complete
	/// <summary>
	///     Represents a reverberation effect within a 3D environment.
	/// </summary>
	/// <remarks>
	///     <para>
	///         The 3D reverb object is a sphere having 3D attributes (position, minimum distance, maximum distance) and
	///         reverb properties.
	///     </para>
	///     <para>
	///         The properties and 3D attributes of all reverb objects collectively determine, along with the listener's
	///         position, the settings of and input gains into a single 3D reverb DSP.
	///     </para>
	///     <para>
	///         When the listener is within the sphere of effect of one or more 3D reverbs, the listener's 3D reverb
	///         properties are a weighted combination of such 3D reverbs. When the listener is outside all of the reverbs, the
	///         3D reverb setting is set to the default ambient reverb setting.
	///     </para>
	/// </remarks>
	/// <seealso cref="HandleBase" />
	/// <seealso cref="FmodSystem.CreateReverb" />
	public partial class Reverb : HandleBase
	{

		#region Constructors & Destructor

		/// <summary>
		///     Initializes a new instance of the <see cref="Reverb" /> class.
		/// </summary>
		/// <param name="handle">The handle to the object.</param>
		internal Reverb(IntPtr handle) : base(handle)
		{
		}

		#endregion

		#region Properties & Indexers

		/// <summary>
		///     <para>
		///         Gets or sets a value indicating whether this <see cref="Reverb" /> is active and contributes to the 3D
		///         scene.
		///     </para>
		///     <para><c>true</c> = Active, <c>false</c> = Inactive. Default = <c>true</c>.</para>
		/// </summary>
		/// <value>
		///     <c>true</c> if active; otherwise, <c>false</c>.
		/// </value>
		public bool Active
		{
			get
			{
				NativeInvoke(FMOD_Reverb3D_GetActive(this, out var active));
				return active;
			}
			set
			{
				NativeInvoke(FMOD_Reverb3D_SetActive(this, value));
				OnActiveChanged();
			}
		}

		/// <summary>
		///     <para>Gets or sets the parameters defining the current reverb environment.</para>
		///     <para>
		///         Reverb parameters can be set manually, or automatically using the pre-defined presets given in the
		///         <see cref="ReverbPresets" /> class.
		///     </para>
		/// </summary>
		/// <value>
		///     The properties.
		/// </value>
		/// <seealso cref="ReverbProperties" />
		/// <seealso cref="ReverbPresets" />
		/// <seealso cref="FmodSystem.CreateReverb" />
		public ReverbProperties Properties
		{
			get
			{
				var properties = new ReverbProperties();
				NativeInvoke(FMOD_Reverb3D_GetProperties(this, ref properties));
				return properties;
			}
			set
			{
				NativeInvoke(FMOD_Reverb3D_SetProperties(this, ref value));
				OnPropertiesChanged();
			}
		}

		/// <summary>
		///     Gets or sets the 3D properties of a "virtual" reverb object.
		/// </summary>
		/// <value>
		///     The 3D attributes.
		/// </value>
		public Reverb3DAttributes Attributes3D
		{
			get
			{
				var vector = new Vector();
				var min = 0.0f;
				var max = 0.0f;
				NativeInvoke(FMOD_Reverb3D_Get3DAttributes(this, ref vector, ref min, ref max));
				return new Reverb3DAttributes
				{
					Position = vector,
					MinimumDistance = min,
					MaximumDistance = max
				};
			}
			set
			{
				var vector = value.Position;
				var min = value.MinimumDistance;
				var max = value.MaximumDistance;
				NativeInvoke(FMOD_Reverb3D_Set3DAttributes(this, ref vector, min, max));
				OnAttributes3DChanged();
			}
		}

		#endregion

		#region Methods

		/// <summary>
		///     Sets the 3D properties of the "virtual" reverb object.
		/// </summary>
		/// <param name="position">A <see cref="Vector" /> containing the 3D position of the center of the reverb in 3D space.</param>
		/// <param name="minDistance">The distance from the centerpoint that the reverb will have full effect at.</param>
		/// <param name="maxDistance">The distance from the centerpoint that the reverb will not have any effect.</param>
		public void Set3DAttributes(Vector position, float minDistance, float maxDistance)
		{
			NativeInvoke(FMOD_Reverb3D_Set3DAttributes(this, ref position, minDistance, maxDistance));
			OnAttributes3DChanged();
		}

		#endregion
	}
}