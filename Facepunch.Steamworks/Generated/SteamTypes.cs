using System;

namespace Steamworks.Data;

internal struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
{
	// Name: DepotId_t, Type: unsigned int
	public uint Value;

	public static implicit operator DepotId_t( uint value )
	{
		return new DepotId_t { Value = value };
	}

	public static implicit operator uint( DepotId_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (DepotId_t)p );
	}

	public bool Equals( DepotId_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( DepotId_t a, DepotId_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( DepotId_t a, DepotId_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( DepotId_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct RTime32 : IEquatable<RTime32>, IComparable<RTime32>
{
	// Name: RTime32, Type: unsigned int
	public uint Value;

	public static implicit operator RTime32( uint value )
	{
		return new RTime32 { Value = value };
	}

	public static implicit operator uint( RTime32 value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (RTime32)p );
	}

	public bool Equals( RTime32 p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( RTime32 a, RTime32 b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( RTime32 a, RTime32 b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( RTime32 other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
{
	// Name: SteamAPICall_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator SteamAPICall_t( ulong value )
	{
		return new SteamAPICall_t { Value = value };
	}

	public static implicit operator ulong( SteamAPICall_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SteamAPICall_t)p );
	}

	public bool Equals( SteamAPICall_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SteamAPICall_t a, SteamAPICall_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SteamAPICall_t a, SteamAPICall_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SteamAPICall_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
{
	// Name: AccountID_t, Type: unsigned int
	public uint Value;

	public static implicit operator AccountID_t( uint value )
	{
		return new AccountID_t { Value = value };
	}

	public static implicit operator uint( AccountID_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (AccountID_t)p );
	}

	public bool Equals( AccountID_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( AccountID_t a, AccountID_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( AccountID_t a, AccountID_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( AccountID_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
{
	// Name: PartyBeaconID_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator PartyBeaconID_t( ulong value )
	{
		return new PartyBeaconID_t { Value = value };
	}

	public static implicit operator ulong( PartyBeaconID_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (PartyBeaconID_t)p );
	}

	public bool Equals( PartyBeaconID_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( PartyBeaconID_t a, PartyBeaconID_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( PartyBeaconID_t a, PartyBeaconID_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( PartyBeaconID_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
{
	// Name: HAuthTicket, Type: unsigned int
	public uint Value;

	public static implicit operator HAuthTicket( uint value )
	{
		return new HAuthTicket { Value = value };
	}

	public static implicit operator uint( HAuthTicket value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HAuthTicket)p );
	}

	public bool Equals( HAuthTicket p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HAuthTicket a, HAuthTicket b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HAuthTicket a, HAuthTicket b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HAuthTicket other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
{
	// Name: HSteamPipe, Type: int
	public int Value;

	public static implicit operator HSteamPipe( int value )
	{
		return new HSteamPipe { Value = value };
	}

	public static implicit operator int( HSteamPipe value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HSteamPipe)p );
	}

	public bool Equals( HSteamPipe p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HSteamPipe a, HSteamPipe b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HSteamPipe a, HSteamPipe b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HSteamPipe other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
{
	// Name: HSteamUser, Type: int
	public int Value;

	public static implicit operator HSteamUser( int value )
	{
		return new HSteamUser { Value = value };
	}

	public static implicit operator int( HSteamUser value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HSteamUser)p );
	}

	public bool Equals( HSteamUser p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HSteamUser a, HSteamUser b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HSteamUser a, HSteamUser b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HSteamUser other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
{
	// Name: FriendsGroupID_t, Type: short
	public short Value;

	public static implicit operator FriendsGroupID_t( short value )
	{
		return new FriendsGroupID_t { Value = value };
	}

	public static implicit operator short( FriendsGroupID_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (FriendsGroupID_t)p );
	}

	public bool Equals( FriendsGroupID_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( FriendsGroupID_t a, FriendsGroupID_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( FriendsGroupID_t a, FriendsGroupID_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( FriendsGroupID_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HServerListRequest : IEquatable<HServerListRequest>, IComparable<HServerListRequest>
{
	// Name: HServerListRequest, Type: void *
	public IntPtr Value;

	public static implicit operator HServerListRequest( IntPtr value )
	{
		return new HServerListRequest { Value = value };
	}

	public static implicit operator IntPtr( HServerListRequest value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HServerListRequest)p );
	}

	public bool Equals( HServerListRequest p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HServerListRequest a, HServerListRequest b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HServerListRequest a, HServerListRequest b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HServerListRequest other )
	{
		return Value.ToInt64().CompareTo( other.Value.ToInt64() );
	}
}

internal struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
{
	// Name: HServerQuery, Type: int
	public int Value;

	public static implicit operator HServerQuery( int value )
	{
		return new HServerQuery { Value = value };
	}

	public static implicit operator int( HServerQuery value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HServerQuery)p );
	}

	public bool Equals( HServerQuery p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HServerQuery a, HServerQuery b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HServerQuery a, HServerQuery b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HServerQuery other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
{
	// Name: UGCHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator UGCHandle_t( ulong value )
	{
		return new UGCHandle_t { Value = value };
	}

	public static implicit operator ulong( UGCHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (UGCHandle_t)p );
	}

	public bool Equals( UGCHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( UGCHandle_t a, UGCHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( UGCHandle_t a, UGCHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( UGCHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>,
	IComparable<PublishedFileUpdateHandle_t>
{
	// Name: PublishedFileUpdateHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator PublishedFileUpdateHandle_t( ulong value )
	{
		return new PublishedFileUpdateHandle_t { Value = value };
	}

	public static implicit operator ulong( PublishedFileUpdateHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (PublishedFileUpdateHandle_t)p );
	}

	public bool Equals( PublishedFileUpdateHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( PublishedFileUpdateHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

public struct PublishedFileId : IEquatable<PublishedFileId>, IComparable<PublishedFileId>
{
	// Name: PublishedFileId_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator PublishedFileId( ulong value )
	{
		return new PublishedFileId { Value = value };
	}

	public static implicit operator ulong( PublishedFileId value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (PublishedFileId)p );
	}

	public bool Equals( PublishedFileId p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( PublishedFileId a, PublishedFileId b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( PublishedFileId a, PublishedFileId b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( PublishedFileId other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>,
	IComparable<UGCFileWriteStreamHandle_t>
{
	// Name: UGCFileWriteStreamHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator UGCFileWriteStreamHandle_t( ulong value )
	{
		return new UGCFileWriteStreamHandle_t { Value = value };
	}

	public static implicit operator ulong( UGCFileWriteStreamHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (UGCFileWriteStreamHandle_t)p );
	}

	public bool Equals( UGCFileWriteStreamHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( UGCFileWriteStreamHandle_t a, UGCFileWriteStreamHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( UGCFileWriteStreamHandle_t a, UGCFileWriteStreamHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( UGCFileWriteStreamHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
{
	// Name: SteamLeaderboard_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator SteamLeaderboard_t( ulong value )
	{
		return new SteamLeaderboard_t { Value = value };
	}

	public static implicit operator ulong( SteamLeaderboard_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SteamLeaderboard_t)p );
	}

	public bool Equals( SteamLeaderboard_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SteamLeaderboard_t a, SteamLeaderboard_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SteamLeaderboard_t a, SteamLeaderboard_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SteamLeaderboard_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>,
	IComparable<SteamLeaderboardEntries_t>
{
	// Name: SteamLeaderboardEntries_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator SteamLeaderboardEntries_t( ulong value )
	{
		return new SteamLeaderboardEntries_t { Value = value };
	}

	public static implicit operator ulong( SteamLeaderboardEntries_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SteamLeaderboardEntries_t)p );
	}

	public bool Equals( SteamLeaderboardEntries_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SteamLeaderboardEntries_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
{
	// Name: SNetSocket_t, Type: unsigned int
	public uint Value;

	public static implicit operator SNetSocket_t( uint value )
	{
		return new SNetSocket_t { Value = value };
	}

	public static implicit operator uint( SNetSocket_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SNetSocket_t)p );
	}

	public bool Equals( SNetSocket_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SNetSocket_t a, SNetSocket_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SNetSocket_t a, SNetSocket_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SNetSocket_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
{
	// Name: SNetListenSocket_t, Type: unsigned int
	public uint Value;

	public static implicit operator SNetListenSocket_t( uint value )
	{
		return new SNetListenSocket_t { Value = value };
	}

	public static implicit operator uint( SNetListenSocket_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SNetListenSocket_t)p );
	}

	public bool Equals( SNetListenSocket_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SNetListenSocket_t a, SNetListenSocket_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SNetListenSocket_t a, SNetListenSocket_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SNetListenSocket_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
{
	// Name: ScreenshotHandle, Type: unsigned int
	public uint Value;

	public static implicit operator ScreenshotHandle( uint value )
	{
		return new ScreenshotHandle { Value = value };
	}

	public static implicit operator uint( ScreenshotHandle value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (ScreenshotHandle)p );
	}

	public bool Equals( ScreenshotHandle p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( ScreenshotHandle a, ScreenshotHandle b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( ScreenshotHandle a, ScreenshotHandle b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( ScreenshotHandle other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
{
	// Name: HTTPRequestHandle, Type: unsigned int
	public uint Value;

	public static implicit operator HTTPRequestHandle( uint value )
	{
		return new HTTPRequestHandle { Value = value };
	}

	public static implicit operator uint( HTTPRequestHandle value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HTTPRequestHandle)p );
	}

	public bool Equals( HTTPRequestHandle p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HTTPRequestHandle a, HTTPRequestHandle b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HTTPRequestHandle a, HTTPRequestHandle b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HTTPRequestHandle other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>,
	IComparable<HTTPCookieContainerHandle>
{
	// Name: HTTPCookieContainerHandle, Type: unsigned int
	public uint Value;

	public static implicit operator HTTPCookieContainerHandle( uint value )
	{
		return new HTTPCookieContainerHandle { Value = value };
	}

	public static implicit operator uint( HTTPCookieContainerHandle value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HTTPCookieContainerHandle)p );
	}

	public bool Equals( HTTPCookieContainerHandle p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HTTPCookieContainerHandle a, HTTPCookieContainerHandle b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HTTPCookieContainerHandle a, HTTPCookieContainerHandle b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HTTPCookieContainerHandle other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
{
	// Name: InputHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator InputHandle_t( ulong value )
	{
		return new InputHandle_t { Value = value };
	}

	public static implicit operator ulong( InputHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (InputHandle_t)p );
	}

	public bool Equals( InputHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( InputHandle_t a, InputHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( InputHandle_t a, InputHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( InputHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t>
{
	// Name: InputActionSetHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator InputActionSetHandle_t( ulong value )
	{
		return new InputActionSetHandle_t { Value = value };
	}

	public static implicit operator ulong( InputActionSetHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (InputActionSetHandle_t)p );
	}

	public bool Equals( InputActionSetHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( InputActionSetHandle_t a, InputActionSetHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( InputActionSetHandle_t a, InputActionSetHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( InputActionSetHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>,
	IComparable<InputDigitalActionHandle_t>
{
	// Name: InputDigitalActionHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator InputDigitalActionHandle_t( ulong value )
	{
		return new InputDigitalActionHandle_t { Value = value };
	}

	public static implicit operator ulong( InputDigitalActionHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (InputDigitalActionHandle_t)p );
	}

	public bool Equals( InputDigitalActionHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( InputDigitalActionHandle_t a, InputDigitalActionHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( InputDigitalActionHandle_t a, InputDigitalActionHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( InputDigitalActionHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>,
	IComparable<InputAnalogActionHandle_t>
{
	// Name: InputAnalogActionHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator InputAnalogActionHandle_t( ulong value )
	{
		return new InputAnalogActionHandle_t { Value = value };
	}

	public static implicit operator ulong( InputAnalogActionHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (InputAnalogActionHandle_t)p );
	}

	public bool Equals( InputAnalogActionHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( InputAnalogActionHandle_t a, InputAnalogActionHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( InputAnalogActionHandle_t a, InputAnalogActionHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( InputAnalogActionHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct ControllerHandle_t : IEquatable<ControllerHandle_t>, IComparable<ControllerHandle_t>
{
	// Name: ControllerHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator ControllerHandle_t( ulong value )
	{
		return new ControllerHandle_t { Value = value };
	}

	public static implicit operator ulong( ControllerHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (ControllerHandle_t)p );
	}

	public bool Equals( ControllerHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( ControllerHandle_t a, ControllerHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( ControllerHandle_t a, ControllerHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( ControllerHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct ControllerActionSetHandle_t : IEquatable<ControllerActionSetHandle_t>,
	IComparable<ControllerActionSetHandle_t>
{
	// Name: ControllerActionSetHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator ControllerActionSetHandle_t( ulong value )
	{
		return new ControllerActionSetHandle_t { Value = value };
	}

	public static implicit operator ulong( ControllerActionSetHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (ControllerActionSetHandle_t)p );
	}

	public bool Equals( ControllerActionSetHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( ControllerActionSetHandle_t a, ControllerActionSetHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( ControllerActionSetHandle_t a, ControllerActionSetHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( ControllerActionSetHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct ControllerDigitalActionHandle_t : IEquatable<ControllerDigitalActionHandle_t>,
	IComparable<ControllerDigitalActionHandle_t>
{
	// Name: ControllerDigitalActionHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator ControllerDigitalActionHandle_t( ulong value )
	{
		return new ControllerDigitalActionHandle_t { Value = value };
	}

	public static implicit operator ulong( ControllerDigitalActionHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (ControllerDigitalActionHandle_t)p );
	}

	public bool Equals( ControllerDigitalActionHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( ControllerDigitalActionHandle_t a, ControllerDigitalActionHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( ControllerDigitalActionHandle_t a, ControllerDigitalActionHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( ControllerDigitalActionHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct ControllerAnalogActionHandle_t : IEquatable<ControllerAnalogActionHandle_t>,
	IComparable<ControllerAnalogActionHandle_t>
{
	// Name: ControllerAnalogActionHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator ControllerAnalogActionHandle_t( ulong value )
	{
		return new ControllerAnalogActionHandle_t { Value = value };
	}

	public static implicit operator ulong( ControllerAnalogActionHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (ControllerAnalogActionHandle_t)p );
	}

	public bool Equals( ControllerAnalogActionHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( ControllerAnalogActionHandle_t a, ControllerAnalogActionHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( ControllerAnalogActionHandle_t a, ControllerAnalogActionHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( ControllerAnalogActionHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
{
	// Name: UGCQueryHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator UGCQueryHandle_t( ulong value )
	{
		return new UGCQueryHandle_t { Value = value };
	}

	public static implicit operator ulong( UGCQueryHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (UGCQueryHandle_t)p );
	}

	public bool Equals( UGCQueryHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( UGCQueryHandle_t a, UGCQueryHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( UGCQueryHandle_t a, UGCQueryHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( UGCQueryHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
{
	// Name: UGCUpdateHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator UGCUpdateHandle_t( ulong value )
	{
		return new UGCUpdateHandle_t { Value = value };
	}

	public static implicit operator ulong( UGCUpdateHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (UGCUpdateHandle_t)p );
	}

	public bool Equals( UGCUpdateHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( UGCUpdateHandle_t a, UGCUpdateHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( UGCUpdateHandle_t a, UGCUpdateHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( UGCUpdateHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
{
	// Name: HHTMLBrowser, Type: unsigned int
	public uint Value;

	public static implicit operator HHTMLBrowser( uint value )
	{
		return new HHTMLBrowser { Value = value };
	}

	public static implicit operator uint( HHTMLBrowser value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HHTMLBrowser)p );
	}

	public bool Equals( HHTMLBrowser p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HHTMLBrowser a, HHTMLBrowser b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HHTMLBrowser a, HHTMLBrowser b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HHTMLBrowser other )
	{
		return Value.CompareTo( other.Value );
	}
}

public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId>
{
	// Name: SteamItemInstanceID_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator InventoryItemId( ulong value )
	{
		return new InventoryItemId { Value = value };
	}

	public static implicit operator ulong( InventoryItemId value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (InventoryItemId)p );
	}

	public bool Equals( InventoryItemId p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( InventoryItemId a, InventoryItemId b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( InventoryItemId a, InventoryItemId b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( InventoryItemId other )
	{
		return Value.CompareTo( other.Value );
	}
}

public struct InventoryDefId : IEquatable<InventoryDefId>, IComparable<InventoryDefId>
{
	// Name: SteamItemDef_t, Type: int
	public int Value;

	public static implicit operator InventoryDefId( int value )
	{
		return new InventoryDefId { Value = value };
	}

	public static implicit operator int( InventoryDefId value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (InventoryDefId)p );
	}

	public bool Equals( InventoryDefId p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( InventoryDefId a, InventoryDefId b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( InventoryDefId a, InventoryDefId b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( InventoryDefId other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
{
	// Name: SteamInventoryResult_t, Type: int
	public int Value;

	public static implicit operator SteamInventoryResult_t( int value )
	{
		return new SteamInventoryResult_t { Value = value };
	}

	public static implicit operator int( SteamInventoryResult_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SteamInventoryResult_t)p );
	}

	public bool Equals( SteamInventoryResult_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SteamInventoryResult_t a, SteamInventoryResult_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SteamInventoryResult_t a, SteamInventoryResult_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SteamInventoryResult_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>,
	IComparable<SteamInventoryUpdateHandle_t>
{
	// Name: SteamInventoryUpdateHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator SteamInventoryUpdateHandle_t( ulong value )
	{
		return new SteamInventoryUpdateHandle_t { Value = value };
	}

	public static implicit operator ulong( SteamInventoryUpdateHandle_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SteamInventoryUpdateHandle_t)p );
	}

	public bool Equals( SteamInventoryUpdateHandle_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SteamInventoryUpdateHandle_t a, SteamInventoryUpdateHandle_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SteamInventoryUpdateHandle_t a, SteamInventoryUpdateHandle_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SteamInventoryUpdateHandle_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

public struct TimelineEventHandle : IEquatable<TimelineEventHandle>, IComparable<TimelineEventHandle>
{
	// Name: TimelineEventHandle_t, Type: unsigned long long
	public ulong Value;

	public static implicit operator TimelineEventHandle( ulong value )
	{
		return new TimelineEventHandle { Value = value };
	}

	public static implicit operator ulong( TimelineEventHandle value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (TimelineEventHandle)p );
	}

	public bool Equals( TimelineEventHandle p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( TimelineEventHandle a, TimelineEventHandle b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( TimelineEventHandle a, TimelineEventHandle b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( TimelineEventHandle other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
{
	// Name: RemotePlaySessionID_t, Type: unsigned int
	public uint Value;

	public static implicit operator RemotePlaySessionID_t( uint value )
	{
		return new RemotePlaySessionID_t { Value = value };
	}

	public static implicit operator uint( RemotePlaySessionID_t value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (RemotePlaySessionID_t)p );
	}

	public bool Equals( RemotePlaySessionID_t p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( RemotePlaySessionID_t a, RemotePlaySessionID_t b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( RemotePlaySessionID_t a, RemotePlaySessionID_t b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( RemotePlaySessionID_t other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
{
	// Name: HSteamNetPollGroup, Type: unsigned int
	public uint Value;

	public static implicit operator HSteamNetPollGroup( uint value )
	{
		return new HSteamNetPollGroup { Value = value };
	}

	public static implicit operator uint( HSteamNetPollGroup value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (HSteamNetPollGroup)p );
	}

	public bool Equals( HSteamNetPollGroup p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( HSteamNetPollGroup a, HSteamNetPollGroup b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( HSteamNetPollGroup a, HSteamNetPollGroup b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( HSteamNetPollGroup other )
	{
		return Value.CompareTo( other.Value );
	}
}

internal struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
{
	// Name: SteamNetworkingPOPID, Type: unsigned int
	public uint Value;

	public static implicit operator SteamNetworkingPOPID( uint value )
	{
		return new SteamNetworkingPOPID { Value = value };
	}

	public static implicit operator uint( SteamNetworkingPOPID value )
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals( object p )
	{
		return Equals( (SteamNetworkingPOPID)p );
	}

	public bool Equals( SteamNetworkingPOPID p )
	{
		return p.Value == Value;
	}

	public static bool operator ==( SteamNetworkingPOPID a, SteamNetworkingPOPID b )
	{
		return a.Equals( b );
	}

	public static bool operator !=( SteamNetworkingPOPID a, SteamNetworkingPOPID b )
	{
		return !a.Equals( b );
	}

	public int CompareTo( SteamNetworkingPOPID other )
	{
		return Value.CompareTo( other.Value );
	}
}
