#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Canvas {

/// <summary>Native X11 surface for Efl canvas</summary>
[Efl.Canvas.SurfaceX11.NativeMethods]
public class SurfaceX11 : Efl.Canvas.Surface, Efl.Eo.IWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(SurfaceX11))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Evas)] internal static extern System.IntPtr
        efl_canvas_surface_x11_class_get();
    /// <summary>Initializes a new instance of the <see cref="SurfaceX11"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public SurfaceX11(Efl.Object parent= null
            ) : base(efl_canvas_surface_x11_class_get(), typeof(SurfaceX11), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="SurfaceX11"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected SurfaceX11(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="SurfaceX11"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected SurfaceX11(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
    }

    /// <summary>Verifies if the given object is equal to this one.</summary>
    /// <param name="instance">The object to compare to.</param>
    /// <returns>True if both objects point to the same native object.</returns>
    public override bool Equals(object instance)
    {
        var other = instance as Efl.Object;
        if (other == null)
        {
            return false;
        }
        return this.NativeHandle == other.NativeHandle;
    }

    /// <summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    /// <returns>The value of the pointer, to be used as the hash code of this object.</returns>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }

    /// <summary>Turns the native pointer into a string representation.</summary>
    /// <returns>A string with the type and the native pointer for this object.</returns>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }

    /// <summary>This is a helper for <see cref="Efl.Canvas.Surface.NativeBuffer"/>.</summary>
    /// <param name="visual">X11 Visual for this Pixmap.</param>
    /// <param name="pixmap">X11 Pixmap ID.</param>
    virtual public void GetPixmap(out System.IntPtr visual, out uint pixmap) {
                                                         Efl.Canvas.SurfaceX11.NativeMethods.efl_canvas_surface_x11_pixmap_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),out visual, out pixmap);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>This is a helper for <see cref="Efl.Canvas.Surface.NativeBuffer"/>.</summary>
    /// <param name="visual">X11 Visual for this Pixmap.</param>
    /// <param name="pixmap">X11 Pixmap ID.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    virtual public bool SetPixmap(System.IntPtr visual, uint pixmap) {
                                                         var _ret_var = Efl.Canvas.SurfaceX11.NativeMethods.efl_canvas_surface_x11_pixmap_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),visual, pixmap);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Canvas.SurfaceX11.efl_canvas_surface_x11_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Canvas.Surface.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Evas);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_canvas_surface_x11_pixmap_get_static_delegate == null)
            {
                efl_canvas_surface_x11_pixmap_get_static_delegate = new efl_canvas_surface_x11_pixmap_get_delegate(pixmap_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPixmap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_surface_x11_pixmap_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_surface_x11_pixmap_get_static_delegate) });
            }

            if (efl_canvas_surface_x11_pixmap_set_static_delegate == null)
            {
                efl_canvas_surface_x11_pixmap_set_static_delegate = new efl_canvas_surface_x11_pixmap_set_delegate(pixmap_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetPixmap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_surface_x11_pixmap_set"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_surface_x11_pixmap_set_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Canvas.SurfaceX11.efl_canvas_surface_x11_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        
        private delegate void efl_canvas_surface_x11_pixmap_get_delegate(System.IntPtr obj, System.IntPtr pd,  out System.IntPtr visual,  out uint pixmap);

        
        public delegate void efl_canvas_surface_x11_pixmap_get_api_delegate(System.IntPtr obj,  out System.IntPtr visual,  out uint pixmap);

        public static Efl.Eo.FunctionWrapper<efl_canvas_surface_x11_pixmap_get_api_delegate> efl_canvas_surface_x11_pixmap_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_surface_x11_pixmap_get_api_delegate>(Module, "efl_canvas_surface_x11_pixmap_get");

        private static void pixmap_get(System.IntPtr obj, System.IntPtr pd, out System.IntPtr visual, out uint pixmap)
        {
            Eina.Log.Debug("function efl_canvas_surface_x11_pixmap_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        visual = default(System.IntPtr);        pixmap = default(uint);                            
                try
                {
                    ((SurfaceX11)wrapper).GetPixmap(out visual, out pixmap);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_canvas_surface_x11_pixmap_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out visual, out pixmap);
            }
        }

        private static efl_canvas_surface_x11_pixmap_get_delegate efl_canvas_surface_x11_pixmap_get_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_canvas_surface_x11_pixmap_set_delegate(System.IntPtr obj, System.IntPtr pd,  System.IntPtr visual,  uint pixmap);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_canvas_surface_x11_pixmap_set_api_delegate(System.IntPtr obj,  System.IntPtr visual,  uint pixmap);

        public static Efl.Eo.FunctionWrapper<efl_canvas_surface_x11_pixmap_set_api_delegate> efl_canvas_surface_x11_pixmap_set_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_surface_x11_pixmap_set_api_delegate>(Module, "efl_canvas_surface_x11_pixmap_set");

        private static bool pixmap_set(System.IntPtr obj, System.IntPtr pd, System.IntPtr visual, uint pixmap)
        {
            Eina.Log.Debug("function efl_canvas_surface_x11_pixmap_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((SurfaceX11)wrapper).SetPixmap(visual, pixmap);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        return _ret_var;

            }
            else
            {
                return efl_canvas_surface_x11_pixmap_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), visual, pixmap);
            }
        }

        private static efl_canvas_surface_x11_pixmap_set_delegate efl_canvas_surface_x11_pixmap_set_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

namespace Efl {

namespace Canvas {

/// <summary>The type used by <see cref="Efl.Canvas.Surface.NativeBuffer"/>.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct SurfaceX11Pixmap
{
    /// <summary>X11 Visual for this Pixmap.</summary>
    public System.IntPtr Visual;
    /// <summary>X11 Pixmap ID.</summary>
    public uint Pixmap;
    ///<summary>Constructor for SurfaceX11Pixmap.</summary>
    public SurfaceX11Pixmap(
        System.IntPtr Visual = default(System.IntPtr),
        uint Pixmap = default(uint)    )
    {
        this.Visual = Visual;
        this.Pixmap = Pixmap;
    }

    public static implicit operator SurfaceX11Pixmap(IntPtr ptr)
    {
        var tmp = (SurfaceX11Pixmap.NativeStruct)Marshal.PtrToStructure(ptr, typeof(SurfaceX11Pixmap.NativeStruct));
        return tmp;
    }

    ///<summary>Internal wrapper for struct SurfaceX11Pixmap.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        
        public System.IntPtr Visual;
        
        public uint Pixmap;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator SurfaceX11Pixmap.NativeStruct(SurfaceX11Pixmap _external_struct)
        {
            var _internal_struct = new SurfaceX11Pixmap.NativeStruct();
            _internal_struct.Visual = _external_struct.Visual;
            _internal_struct.Pixmap = _external_struct.Pixmap;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator SurfaceX11Pixmap(SurfaceX11Pixmap.NativeStruct _internal_struct)
        {
            var _external_struct = new SurfaceX11Pixmap();
            _external_struct.Visual = _internal_struct.Visual;
            _external_struct.Pixmap = _internal_struct.Pixmap;
            return _external_struct;
        }

    }

}

}

}

