		[GLib.Signal("child-added")]
		event Gst.ChildAddedHandler Gst.ChildProxy.ChildAdded {
			add {
				Gst.GLib.Object.GetObject (Handle).AddSignalHandler ("child-added", value, typeof (Gst.ChildAddedArgs));
			}
			remove {
				Gst.GLib.Object.GetObject (Handle).RemoveSignalHandler ("child-added", value);
			}
		}

		[GLib.Signal("child-removed")]
		event Gst.ChildRemovedHandler Gst.ChildProxy.ChildRemoved {
			add {
				Gst.GLib.Object.GetObject (Handle).AddSignalHandler ("child-removed", value, typeof (Gst.ChildRemovedArgs));
			}
			remove {
				Gst.GLib.Object.GetObject (Handle).RemoveSignalHandler ("child-removed", value);
			}
		}

		[DllImport("libgstreamer-0.10.dll")]
		static extern void gst_child_proxy_child_added(IntPtr raw, IntPtr child);

		void Gst.ChildProxy.EmitChildAdded(Gst.Object child) {
			gst_child_proxy_child_added(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[DllImport("libgstreamer-0.10.dll")]
		static extern IntPtr gst_child_proxy_get_child_by_name(IntPtr raw, IntPtr name);

		Gst.Object Gst.ChildProxy.GetChildByName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_child_proxy_get_child_by_name(Handle, native_name);
			Gst.Object ret = GLib.Object.GetObject(raw_ret, true) as Gst.Object;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgstreamer-0.10.dll")]
		static extern IntPtr gst_child_proxy_get_child_by_index(IntPtr raw, uint index);

		Gst.Object Gst.ChildProxy.GetChildByIndex(uint index) {
			IntPtr raw_ret = gst_child_proxy_get_child_by_index(Handle, index);
			Gst.Object ret = GLib.Object.GetObject(raw_ret, true) as Gst.Object;
			return ret;
		}

		[DllImport("libgstreamer-0.10.dll")]
		static extern uint gst_child_proxy_get_children_count(IntPtr raw);

		uint Gst.ChildProxy.ChildrenCount { 
			get {
				uint raw_ret = gst_child_proxy_get_children_count(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-0.10.dll")]
		static extern void gst_child_proxy_child_removed(IntPtr raw, IntPtr child);

		void Gst.ChildProxy.EmitChildRemoved(Gst.Object child) {
			gst_child_proxy_child_removed(Handle, child == null ? IntPtr.Zero : child.Handle);
		}


