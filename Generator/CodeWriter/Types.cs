using System.Linq;

namespace Generator;

public partial class CodeWriter
{
	//
	// Don't give a fuck about these types
	//
	public static readonly string[] SkipTypes =
	{
		"ValvePackingSentinel_t", "SteamAPIWarningMessageHook_t", "Salt_t", "SteamAPI_CheckCallbackRegistered_t",
		"compile_time_assert_type", "SteamErrMsg"
	};

	//
	// Native types and function defs
	//
	public static readonly string[] SkipTypesStartingWith = { "uint", "int", "ulint", "lint", "PFN" };

	private void Types()
	{
		foreach ( var o in def.typedefs.Where( x => !x.Name.Contains( "::" ) ) )
		{
			if ( !Cleanup.ShouldCreate( o.Name ) )
			{
				continue;
			}

			var typeName = Cleanup.ConvertType( o.Name );

			if ( !Cleanup.ShouldCreate( typeName ) )
			{
				continue;
			}

			if ( SkipTypes.Contains( o.Name ) )
			{
				continue;
			}

			if ( SkipTypesStartingWith.Any( x => o.Name.StartsWith( x ) ) )
			{
				continue;
			}

			StartBlock(
				$"{Cleanup.Expose( typeName )} struct {typeName} : IEquatable<{typeName}>, IComparable<{typeName}>" );
			{
				WriteLine( $"// Name: {o.Name}, Type: {o.Type}" );

				if ( o.Type == "char [1024]" )
				{
					WriteLine( "public fixed char[1024] Value;" );
				}
				else
				{
					WriteLine( $"public {ToManagedType( o.Type )} Value;" );
				}

				WriteLine();
				WriteLine(
					$"public static implicit operator {typeName}( {ToManagedType( o.Type )} value ) => new {typeName}(){{ Value = value }};" );
				WriteLine(
					$"public static implicit operator {ToManagedType( o.Type )}( {typeName} value ) => value.Value;" );
				WriteLine( "public override string ToString() => Value.ToString();" );
				WriteLine( "public override int GetHashCode() => Value.GetHashCode();" );
				WriteLine( $"public override bool Equals( object p ) => this.Equals( ({typeName}) p );" );
				WriteLine( $"public bool Equals( {typeName} p ) => p.Value == Value;" );
				WriteLine( $"public static bool operator ==( {typeName} a, {typeName} b ) => a.Equals( b );" );
				WriteLine( $"public static bool operator !=( {typeName} a, {typeName} b ) => !a.Equals( b );" );

				if ( ToManagedType( o.Type ) == "IntPtr" )
				{
					WriteLine(
						$"public int CompareTo( {typeName} other ) => Value.ToInt64().CompareTo( other.Value.ToInt64() );" );
				}
				else
				{
					WriteLine( $"public int CompareTo( {typeName} other ) => Value.CompareTo( other.Value );" );
				}
			}
			EndBlock();
			WriteLine();
		}
	}
}
