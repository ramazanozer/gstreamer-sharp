		[DllImport("libgstinterfaces-0.10.dll")]
		static extern void gst_x_overlay_expose(IntPtr raw);

		void Gst.Interfaces.XOverlay.Expose() {
			gst_x_overlay_expose(Handle);
		}

		[DllImport("libgstinterfaces-0.10.dll")]
		static extern void gst_x_overlay_handle_events(IntPtr raw, bool handle_events);

		void Gst.Interfaces.XOverlay.HandleEvents(bool handle_events) {
			gst_x_overlay_handle_events(Handle, handle_events);
		}

		[DllImport("libgstinterfaces-0.10.dll")]
		static extern void gst_x_overlay_got_window_handle(IntPtr raw, ulong handle);

		void Gst.Interfaces.XOverlay.GotWindowHandle(ulong handle) {
			gst_x_overlay_got_window_handle(Handle, handle);
		}

		[DllImport("libgstinterfaces-0.10.dll")]
		static extern void gst_x_overlay_prepare_xwindow_id(IntPtr raw);

		void Gst.Interfaces.XOverlay.PrepareXwindowId() {
			gst_x_overlay_prepare_xwindow_id(Handle);
		}

/*
		[DllImport("libgstinterfaces-0.10.dll")]
		static extern void gst_x_overlay_set_xwindow_id_disabled(IntPtr raw, UIntPtr xwindow_id);

		ulong Gst.Interfaces.XOverlay.XwindowIdDisabled { 
			set {
				gst_x_overlay_set_xwindow_id_disabled(Handle, new UIntPtr (value));
			}
		}
*/
		
		[DllImport("libgstinterfaces-0.10.dll")]
		static extern bool gst_x_overlay_set_render_rectangle(IntPtr raw, int x, int y, int width, int height);

		bool Gst.Interfaces.XOverlay.SetRenderRectangle(int x, int y, int width, int height) {
			bool raw_ret = gst_x_overlay_set_render_rectangle(Handle, x, y, width, height);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstinterfaces-0.10.dll")]
		static extern void gst_x_overlay_set_window_handle(IntPtr raw, ulong handle);

		ulong Gst.Interfaces.XOverlay.WindowHandle {
			set {
				gst_x_overlay_set_window_handle(Handle, value);
 			}
 		}
