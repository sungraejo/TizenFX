/*
 * Copyright(c) 2017 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Tizen.NUI
{
    internal class LanguageChangedSignalType : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        /// <summary>
        /// LanguageChangedSignalType
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        protected bool swigCMemOwn;

        internal LanguageChangedSignalType(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LanguageChangedSignalType obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        /// <summary>
        /// A Flat to check if it is already disposed.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        protected bool disposed = false;

        /// <summary>
        /// Dispose
        /// </summary>
        ~LanguageChangedSignalType()
        {
            if (!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    Interop.LanguageChangedSignalType.delete_LanguageChangedSignalType(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            disposed = true;
        }

        /// <summary>
        /// Queries whether there are any connected slots.
        /// </summary>
        /// <returns>True if there are any slots connected to the signal</returns>
        /// <since_tizen> 4 </since_tizen>
        public bool Empty()
        {
            bool ret = Interop.LanguageChangedSignalType.LanguageChangedSignalType_Empty(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Queries the number of slots.
        /// </summary>
        /// <returns>The number of slots connected to this signal</returns>
        /// <since_tizen> 4 </since_tizen>
        public uint GetConnectionCount()
        {
            uint ret = Interop.LanguageChangedSignalType.LanguageChangedSignalType_GetConnectionCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Connects a member function.
        /// </summary>
        /// <param name="func">The member function to connect</param>
        /// <since_tizen> 4 </since_tizen>
        public void Connect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                Interop.LanguageChangedSignalType.LanguageChangedSignalType_Connect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        /// <summary>
        /// Disconnects a function.
        /// </summary>
        /// <param name="func">The function to disconnect</param>
        /// <since_tizen> 4 </since_tizen>
        public void Disconnect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                Interop.LanguageChangedSignalType.LanguageChangedSignalType_Disconnect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        /// <summary>
        /// Emits the signal.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public void Emit(int arg)
        {
            Interop.LanguageChangedSignalType.LanguageChangedSignalType_Emit(swigCPtr, arg);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// The contructor.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public LanguageChangedSignalType() : this(Interop.LanguageChangedSignalType.new_LanguageChangedSignalType(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
