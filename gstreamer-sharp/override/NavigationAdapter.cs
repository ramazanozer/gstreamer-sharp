// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Interfaces {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class NavigationAdapter : GLib.GInterfaceAdapter, Gst.Interfaces.Navigation {

		[StructLayout (LayoutKind.Sequential)]
		struct GstNavigationInterface {
			public SendEventNativeDelegate SendEvent;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			public IntPtr[] GstReserved;
		}

		static GstNavigationInterface iface;

		static NavigationAdapter ()
		{
			GLib.GType.Register (_gtype, typeof(NavigationAdapter));
			iface.SendEvent = new SendEventNativeDelegate (SendEvent_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SendEventNativeDelegate (IntPtr inst, IntPtr structure);

		static void SendEvent_cb (IntPtr inst, IntPtr structure)
		{
			try {
				NavigationImplementor __obj = GLib.Object.GetObject (inst, false) as NavigationImplementor;
				__obj.SendEvent (structure == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (structure, typeof (Gst.Structure), true));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GstNavigationInterface native_iface = (GstNavigationInterface) Marshal.PtrToStructure (ifaceptr, typeof (GstNavigationInterface));
			native_iface.SendEvent = iface.SendEvent;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
			GCHandle gch = (GCHandle) data;
			gch.Free ();
		}

		GLib.Object implementor;

		public NavigationAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public NavigationAdapter (NavigationImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public NavigationAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_navigation_get_type();

		private static GLib.GType _gtype = new GLib.GType (gst_navigation_get_type ());

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

		public static Navigation GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static Navigation GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is NavigationImplementor)
				return new NavigationAdapter (obj as NavigationImplementor);
			else if (obj as Navigation == null)
				return new NavigationAdapter (obj.Handle);
			else
				return obj as Navigation;
		}

		public NavigationImplementor Implementor {
			get {
				return implementor as NavigationImplementor;
			}
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_navigation_send_event(IntPtr raw, IntPtr structure);

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_copy (IntPtr raw);

		public void SendEvent(Gst.Structure structure) {
			gst_navigation_send_event(Handle, structure == null ? IntPtr.Zero : gst_structure_copy (structure.Handle));
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_navigation_send_mouse_event(IntPtr raw, IntPtr evnt, int button, double x, double y);

		public void SendMouseEvent(string evnt, int button, double x, double y) {
			IntPtr native_evnt = GLib.Marshaller.StringToPtrGStrdup (evnt);
			gst_navigation_send_mouse_event(Handle, native_evnt, button, x, y);
			GLib.Marshaller.Free (native_evnt);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_navigation_send_key_event(IntPtr raw, IntPtr evnt, IntPtr key);

		public void SendKeyEvent(string evnt, string key) {
			IntPtr native_evnt = GLib.Marshaller.StringToPtrGStrdup (evnt);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			gst_navigation_send_key_event(Handle, native_evnt, native_key);
			GLib.Marshaller.Free (native_evnt);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_navigation_send_command(IntPtr raw, int command);

		public void SendCommand(Gst.Interfaces.NavigationCommand command) {
			gst_navigation_send_command(Handle, (int) command);
		}

#endregion
	}
}
