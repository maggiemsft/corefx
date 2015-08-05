// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class NtDll
    {
        [DllImport(Interop.Libraries.NtDll, ExactSpelling = true, CharSet = CharSet.Unicode)]
        internal extern static uint RtlIpv4StringToAddressExW(
            [In] string s,
            [In] bool strict,
            [Out] byte[] address,
            [Out] out ushort port);
    }
}