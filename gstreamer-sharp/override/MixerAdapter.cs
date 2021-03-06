// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Interfaces {

	using System;
	using System.Runtime.InteropServices;
	using System.Reflection;

#region Autogenerated code
	public partial class MixerAdapter : GLib.GInterfaceAdapter, Gst.Interfaces.Mixer {

		[StructLayout (LayoutKind.Sequential)]
		struct GstMixerClass {
			public Gst.Interfaces.MixerType MixerType;
			public ListTracksNativeDelegate ListTracks;
			public SetVolumeNativeDelegate SetVolume;
			public GetVolumeNativeDelegate GetVolume;
			public SetMuteNativeDelegate SetMute;
			public SetRecordNativeDelegate SetRecord;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=3)]
			private IntPtr[] Padding1;
			public SetOptionNativeDelegate SetOption;
			public GetOptionNativeDelegate GetOption;
			private IntPtr _padding2;
			public GetMixerFlagsNativeDelegate GetMixerFlags;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=3)]
			public IntPtr[] GstReserved;
		}

		static GstMixerClass iface;

		static MixerAdapter ()
		{
			GLib.GType.Register (_gtype, typeof(MixerAdapter));
			iface.ListTracks = new ListTracksNativeDelegate (ListTracks_cb);
			iface.SetVolume = new SetVolumeNativeDelegate (SetVolume_cb);
			iface.GetVolume = new GetVolumeNativeDelegate (GetVolume_cb);
			iface.SetMute = new SetMuteNativeDelegate (SetMute_cb);
			iface.SetRecord = new SetRecordNativeDelegate (SetRecord_cb);
			iface.SetOption = new SetOptionNativeDelegate (SetOption_cb);
			iface.GetOption = new GetOptionNativeDelegate (GetOption_cb);
			iface.GetMixerFlags = new GetMixerFlagsNativeDelegate (GetMixerFlags_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr ListTracksNativeDelegate (IntPtr inst);

		static IntPtr ListTracks_cb (IntPtr inst)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				Gst.Interfaces.MixerTrack[] __result = __obj.ListTracks ();
				return new GLib.List(__result, typeof (Gst.Interfaces.MixerTrack), false, false) == null ? IntPtr.Zero : new GLib.List(__result, typeof (Gst.Interfaces.MixerTrack), false, false).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetVolumeNativeDelegate (IntPtr inst, IntPtr track, IntPtr volumes);

		static void SetVolume_cb (IntPtr inst, IntPtr track, IntPtr volumes)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				MixerTrack managed_track = GLib.Object.GetObject (track) as MixerTrack;
				int[] managed_volumes = new int[managed_track.NumChannels];
				Marshal.Copy (volumes, managed_volumes, 0, managed_track.NumChannels);
				__obj.SetVolume (managed_track, managed_volumes);

			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetVolumeNativeDelegate (IntPtr inst, IntPtr track, IntPtr volumes);

		static void GetVolume_cb (IntPtr inst, IntPtr track, IntPtr volumes)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				MixerTrack managed_track = GLib.Object.GetObject (track) as MixerTrack;

				int[] managed_volumes = __obj.GetVolume (managed_track);

				volumes = GLib.Marshaller.Malloc ((ulong) (4 * managed_track.NumChannels));
				Marshal.Copy (managed_volumes, 0, volumes, managed_track.NumChannels);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetMuteNativeDelegate (IntPtr inst, IntPtr track, bool mute);

		static void SetMute_cb (IntPtr inst, IntPtr track, bool mute)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				__obj.SetMute (GLib.Object.GetObject(track) as Gst.Interfaces.MixerTrack, mute);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetRecordNativeDelegate (IntPtr inst, IntPtr track, bool record);

		static void SetRecord_cb (IntPtr inst, IntPtr track, bool record)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				__obj.SetRecord (GLib.Object.GetObject(track) as Gst.Interfaces.MixerTrack, record);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetOptionNativeDelegate (IntPtr inst, IntPtr opts, IntPtr value);

		static void SetOption_cb (IntPtr inst, IntPtr opts, IntPtr value)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				__obj.SetOption (GLib.Object.GetObject(opts) as Gst.Interfaces.MixerOptions, GLib.Marshaller.PtrToStringGFree(value));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetOptionNativeDelegate (IntPtr inst, IntPtr opts);

		static IntPtr GetOption_cb (IntPtr inst, IntPtr opts)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				string __result = __obj.GetOption (GLib.Object.GetObject(opts) as Gst.Interfaces.MixerOptions);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetMixerFlagsNativeDelegate (IntPtr inst);

		static int GetMixerFlags_cb (IntPtr inst)
		{
			try {
				MixerImplementor __obj = GLib.Object.GetObject (inst, false) as MixerImplementor;
				Gst.Interfaces.MixerFlags __result = __obj.MixerFlags;
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GstMixerClass native_iface = (GstMixerClass) Marshal.PtrToStructure (ifaceptr, typeof (GstMixerClass));
			native_iface.ListTracks = iface.ListTracks;
			native_iface.SetVolume = iface.SetVolume;
			native_iface.GetVolume = iface.GetVolume;
			native_iface.SetMute = iface.SetMute;
			native_iface.SetRecord = iface.SetRecord;
			native_iface.SetOption = iface.SetOption;
			native_iface.GetOption = iface.GetOption;
			native_iface.GetMixerFlags = iface.GetMixerFlags;

			GCHandle gch = (GCHandle) data;

			MixerAdapter adapter = gch.Target as MixerAdapter;
			MixerImplementor implementor = adapter.Implementor;
			
			if (implementor != null) {
				PropertyInfo pi = implementor.GetType().GetProperty ("MixerType", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
				if (pi != null && pi.PropertyType == typeof (Gst.Interfaces.MixerType))
					native_iface.MixerType = (Gst.Interfaces.MixerType) pi.GetValue (null, null);
			}

			Marshal.StructureToPtr (native_iface, ifaceptr, false);
			gch.Free ();
		}

		GLib.Object implementor;

		public MixerAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public MixerAdapter (MixerImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public MixerAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_mixer_get_type();

		private static GLib.GType _gtype = new GLib.GType (gst_mixer_get_type ());

		public override GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static Mixer GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static Mixer GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is MixerImplementor)
				return new MixerAdapter (obj as MixerImplementor);
			else if (obj as Mixer == null)
				return new MixerAdapter (obj.Handle);
			else
				return obj as Mixer;
		}

		public MixerImplementor Implementor {
			get {
				return implementor as MixerImplementor;
			}
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_volume_changed(IntPtr raw, IntPtr track, IntPtr volumes);
 
		public void VolumeChanged(Gst.Interfaces.MixerTrack track, int[] volumes) {
			if (track == null)
				return;

			if (volumes.Length != track.NumChannels)
				throw new ArgumentOutOfRangeException ();

			IntPtr native_volumes = GLib.Marshaller.Malloc ((ulong) (4 * track.NumChannels));
			Marshal.Copy (volumes, 0, native_volumes, track.NumChannels);
			gst_mixer_volume_changed(Handle, track.Handle, native_volumes);
			GLib.Marshaller.Free (native_volumes);
 		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_mixer_list_tracks(IntPtr raw);

		public Gst.Interfaces.MixerTrack[] ListTracks() {
			IntPtr raw_ret = gst_mixer_list_tracks(Handle);
			Gst.Interfaces.MixerTrack[] ret = (Gst.Interfaces.MixerTrack[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(Gst.Interfaces.MixerTrack));
			return ret;
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_set_option(IntPtr raw, IntPtr opts, IntPtr value);

		public void SetOption(Gst.Interfaces.MixerOptions opts, string value) {
			gst_mixer_set_option(Handle, opts == null ? IntPtr.Zero : opts.Handle, GLib.Marshaller.StringToPtrGStrdup(value));
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_set_volume(IntPtr raw, IntPtr track, IntPtr volumes);

		public void SetVolume(Gst.Interfaces.MixerTrack track, int[] volumes) {
			if (track == null)
				return;

			if (volumes.Length != track.NumChannels)
				throw new ArgumentOutOfRangeException ();
			IntPtr volumes_native = GLib.Marshaller.Malloc ((ulong) (4 * track.NumChannels));
			Marshal.Copy (volumes, 0, volumes_native, track.NumChannels);
			gst_mixer_set_volume(Handle, track.Handle, volumes_native);
			GLib.Marshaller.Free (volumes_native);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_mixer_get_mixer_type(IntPtr raw);

		public Gst.Interfaces.MixerType MixerType { 
			get {
				int raw_ret = gst_mixer_get_mixer_type(Handle);
				Gst.Interfaces.MixerType ret = (Gst.Interfaces.MixerType) raw_ret;
				return ret;
			}
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_option_changed(IntPtr raw, IntPtr opts, IntPtr value);

		public void OptionChanged(Gst.Interfaces.MixerOptions opts, string value) {
			gst_mixer_option_changed(Handle, opts == null ? IntPtr.Zero : opts.Handle, GLib.Marshaller.StringToPtrGStrdup(value));
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_mixer_get_option(IntPtr raw, IntPtr opts);

		public string GetOption(Gst.Interfaces.MixerOptions opts) {
			IntPtr raw_ret = gst_mixer_get_option(Handle, opts == null ? IntPtr.Zero : opts.Handle);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_set_record(IntPtr raw, IntPtr track, bool record);

		public void SetRecord(Gst.Interfaces.MixerTrack track, bool record) {
			gst_mixer_set_record(Handle, track == null ? IntPtr.Zero : track.Handle, record);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_options_list_changed(IntPtr raw, IntPtr opts);

		public void ListChanged(Gst.Interfaces.MixerOptions opts) {
			gst_mixer_options_list_changed(Handle, opts == null ? IntPtr.Zero : opts.Handle);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_record_toggled(IntPtr raw, IntPtr track, bool record);

		public void RecordToggled(Gst.Interfaces.MixerTrack track, bool record) {
			gst_mixer_record_toggled(Handle, track == null ? IntPtr.Zero : track.Handle, record);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_mute_toggled(IntPtr raw, IntPtr track, bool mute);

		public void MuteToggled(Gst.Interfaces.MixerTrack track, bool mute) {
			gst_mixer_mute_toggled(Handle, track == null ? IntPtr.Zero : track.Handle, mute);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_get_volume(IntPtr raw, IntPtr track, ref IntPtr volumes);

		public int[] GetVolume(Gst.Interfaces.MixerTrack track) {
			if (track == null)
				return null;

			IntPtr native_volumes = GLib.Marshaller.Malloc ((ulong) (4 * track.NumChannels));
			gst_mixer_get_volume(Handle, track.Handle, ref native_volumes);

			int[] volumes = new int[track.NumChannels];
			Marshal.Copy (native_volumes, volumes, 0, track.NumChannels);
			GLib.Marshaller.Free (native_volumes);
			return volumes;
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_mixer_get_mixer_flags(IntPtr raw);

		public Gst.Interfaces.MixerFlags MixerFlags { 
			get {
				int raw_ret = gst_mixer_get_mixer_flags(Handle);
				Gst.Interfaces.MixerFlags ret = (Gst.Interfaces.MixerFlags) raw_ret;
				return ret;
			}
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_mixer_changed(IntPtr raw);

		public void MixerChanged() {
			gst_mixer_mixer_changed(Handle);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mixer_set_mute(IntPtr raw, IntPtr track, bool mute);

		public void SetMute(Gst.Interfaces.MixerTrack track, bool mute) {
			gst_mixer_set_mute(Handle, track == null ? IntPtr.Zero : track.Handle, mute);
		}

#endregion
	}
}
