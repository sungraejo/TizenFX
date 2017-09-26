﻿/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.System.Usb
{
    /// <summary>
    /// Device information for USB device.
    /// </summary>
    public class UsbDeviceInformation
    {
        private readonly UsbDevice _device;

        internal UsbDeviceInformation(UsbDevice device)
        {
            _device = device;
        }

        /// <summary>
        /// USB specification release number as binary-coded decimal.
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">Throws exception if user has insufficient permission on device.</exception>
        public int UsbVersion
        {
            get
            {
                _device.ThrowIfDisposed();
                return Interop.NativeGet<int>(_device._handle.GetBcdUsb);
            }
        }

        /// <summary>
        /// Gets device class.
        /// </summary>
        public int Class
        {
            get
            {
                _device.ThrowIfDisposed();
                return Interop.NativeGet<int>(_device._handle.GetClass);
            }
        }

        /// <summary>
        /// Gets device sub class.
        /// </summary>
        public int Subclass
        {
            get
            {
                _device.ThrowIfDisposed();
                return Interop.NativeGet<int>(_device._handle.GetSubClass);
            }
        }

        /// <summary>
        /// Gets device protocol.
        /// </summary>
        public int Protocol
        {
            get
            {
                _device.ThrowIfDisposed();
                return Interop.NativeGet<int>(_device._handle.GetProtocol);
            }
        }

        /// <summary>
        /// Gets vendor id.
        /// </summary>
        public int VendorId
        {
            get
            {
                _device.ThrowIfDisposed();
                return Interop.NativeGet<int>(_device._handle.GetIdVendor);
            }
        }

        /// <summary>
        /// Gets product id.
        /// </summary>
        public int ProductId
        {
            get
            {
                _device.ThrowIfDisposed();
                return Interop.NativeGet<int>(_device._handle.GetIdProduct);
            }
        }

        /// <summary>
        /// Gets device release number in binary-coded decimal.
        /// </summary>
        public int DeviceVersion
        {
            get
            {
                _device.ThrowIfDisposed();
                return Interop.NativeGet<int>(_device._handle.GetBcdDevice);
            }
        }
    }
}