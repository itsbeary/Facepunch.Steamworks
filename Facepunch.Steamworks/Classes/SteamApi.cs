using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks;

internal static class SteamAPI
{
	internal static SteamAPIInitResult Init( string pszInternalCheckInterfaceVersions, out string pOutErrMsg )
	{
		using var interfaceVersionsStr = new Utf8StringToNative( pszInternalCheckInterfaceVersions );
		using var buffer = Helpers.Memory.Take();
		var result = Native.SteamInternal_SteamAPI_Init( interfaceVersionsStr.Pointer, buffer.Ptr );
		pOutErrMsg = Helpers.MemoryToString( buffer.Ptr );
		return result;
	}

	internal static void Shutdown()
	{
		Native.SteamAPI_Shutdown();
	}

	internal static HSteamPipe GetHSteamPipe()
	{
		return Native.SteamAPI_GetHSteamPipe();
	}

	internal static bool RestartAppIfNecessary( uint unOwnAppID )
	{
		return Native.SteamAPI_RestartAppIfNecessary( unOwnAppID );
	}

	internal static class Native
	{
		[DllImport( Platform.LibraryName, EntryPoint = "SteamInternal_SteamAPI_Init",
			CallingConvention = CallingConvention.Cdecl )]
		public static extern SteamAPIInitResult SteamInternal_SteamAPI_Init( IntPtr pszInternalCheckInterfaceVersions,
			IntPtr pOutErrMsg );

		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_Shutdown",
			CallingConvention = CallingConvention.Cdecl )]
		public static extern void SteamAPI_Shutdown();

		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_GetHSteamPipe",
			CallingConvention = CallingConvention.Cdecl )]
		public static extern HSteamPipe SteamAPI_GetHSteamPipe();

		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_RestartAppIfNecessary",
			CallingConvention = CallingConvention.Cdecl )]
		[return: MarshalAs( UnmanagedType.I1 )]
		public static extern bool SteamAPI_RestartAppIfNecessary( uint unOwnAppID );
	}
}
