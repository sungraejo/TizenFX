#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>Efl Ui Layout Factory class</summary>
[Efl.Ui.LayoutFactory.NativeMethods]
public class LayoutFactory : Efl.Ui.CachingFactory, Efl.Eo.IWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(LayoutFactory))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_layout_factory_class_get();
    /// <summary>Initializes a new instance of the <see cref="LayoutFactory"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    /// <param name="itemClass">Define the class of the item returned by this factory. See <see cref="Efl.Ui.WidgetFactory.SetItemClass"/></param>
    public LayoutFactory(Efl.Object parent
            , Type itemClass = null) : base(efl_ui_layout_factory_class_get(), typeof(LayoutFactory), parent)
    {
        if (Efl.Eo.Globals.ParamHelperCheck(itemClass))
        {
            SetItemClass(Efl.Eo.Globals.GetParamHelper(itemClass));
        }

        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="LayoutFactory"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected LayoutFactory(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="LayoutFactory"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected LayoutFactory(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
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

    /// <summary>No description supplied.</summary>
    /// <param name="klass">The class of the group.</param>
    /// <param name="group">The group.</param>
    /// <param name="style">The style to used.</param>
    virtual public void ThemeConfig(System.String klass, System.String group, System.String style) {
                                                                                 Efl.Ui.LayoutFactory.NativeMethods.efl_ui_layout_factory_theme_config_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),klass, group, style);
        Eina.Error.RaiseIfUnhandledException();
                                                         }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.LayoutFactory.efl_ui_layout_factory_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Ui.CachingFactory.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_layout_factory_theme_config_static_delegate == null)
            {
                efl_ui_layout_factory_theme_config_static_delegate = new efl_ui_layout_factory_theme_config_delegate(theme_config);
            }

            if (methods.FirstOrDefault(m => m.Name == "ThemeConfig") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_layout_factory_theme_config"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_layout_factory_theme_config_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.LayoutFactory.efl_ui_layout_factory_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        
        private delegate void efl_ui_layout_factory_theme_config_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String klass, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String style);

        
        public delegate void efl_ui_layout_factory_theme_config_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String klass, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String style);

        public static Efl.Eo.FunctionWrapper<efl_ui_layout_factory_theme_config_api_delegate> efl_ui_layout_factory_theme_config_ptr = new Efl.Eo.FunctionWrapper<efl_ui_layout_factory_theme_config_api_delegate>(Module, "efl_ui_layout_factory_theme_config");

        private static void theme_config(System.IntPtr obj, System.IntPtr pd, System.String klass, System.String group, System.String style)
        {
            Eina.Log.Debug("function efl_ui_layout_factory_theme_config was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                                                    
                try
                {
                    ((LayoutFactory)wrapper).ThemeConfig(klass, group, style);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                                        
            }
            else
            {
                efl_ui_layout_factory_theme_config_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), klass, group, style);
            }
        }

        private static efl_ui_layout_factory_theme_config_delegate efl_ui_layout_factory_theme_config_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

