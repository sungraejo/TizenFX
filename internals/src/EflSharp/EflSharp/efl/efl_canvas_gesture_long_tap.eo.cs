#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Canvas {

///<summary>Event argument wrapper for event <see cref="Efl.Canvas.GestureLongTap.GestureLongTapEvt"/>.</summary>
public class GestureLongTapGestureLongTapEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Canvas.Gesture arg { get; set; }
}
/// <summary>EFL Gesture Long Tap class</summary>
[Efl.Canvas.GestureLongTap.NativeMethods]
public class GestureLongTap : Efl.Canvas.Gesture, Efl.Eo.IWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(GestureLongTap))
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
        efl_canvas_gesture_long_tap_class_get();
    /// <summary>Initializes a new instance of the <see cref="GestureLongTap"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public GestureLongTap(Efl.Object parent= null
            ) : base(efl_canvas_gesture_long_tap_class_get(), typeof(GestureLongTap), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="GestureLongTap"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected GestureLongTap(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="GestureLongTap"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected GestureLongTap(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
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

    /// <summary>Event for tap gesture</summary>
    public event EventHandler<Efl.Canvas.GestureLongTapGestureLongTapEvt_Args> GestureLongTapEvt
    {
        add
        {
            lock (eventLock)
            {
                var wRef = new WeakReference(this);
                Efl.EventCb callerCb = (IntPtr data, ref Efl.Event.NativeStruct evt) =>
                {
                    var obj = wRef.Target as Efl.Eo.IWrapper;
                    if (obj != null)
                    {
                                                Efl.Canvas.GestureLongTapGestureLongTapEvt_Args args = new Efl.Canvas.GestureLongTapGestureLongTapEvt_Args();
                        args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Canvas.Gesture);
                        try
                        {
                            value?.Invoke(obj, args);
                        }
                        catch (Exception e)
                        {
                            Eina.Log.Error(e.ToString());
                            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                        }
                    }
                };

                string key = "_EFL_EVENT_GESTURE_LONG_TAP";
                AddNativeEventHandler(efl.Libs.Evas, key, callerCb, value);
            }
        }

        remove
        {
            lock (eventLock)
            {
                string key = "_EFL_EVENT_GESTURE_LONG_TAP";
                RemoveNativeEventHandler(efl.Libs.Evas, key, value);
            }
        }
    }
    ///<summary>Method to raise event GestureLongTapEvt.</summary>
    public void OnGestureLongTapEvt(Efl.Canvas.GestureLongTapGestureLongTapEvt_Args e)
    {
        var key = "_EFL_EVENT_GESTURE_LONG_TAP";
        IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Evas, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
            return;
        }

        IntPtr info = e.arg.NativeHandle;
        Efl.Eo.Globals.efl_event_callback_call(this.NativeHandle, desc, info);
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Canvas.GestureLongTap.efl_canvas_gesture_long_tap_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Canvas.Gesture.NativeMethods
    {
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Canvas.GestureLongTap.efl_canvas_gesture_long_tap_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

