using System.IO;
using Newtonsoft.Json;

namespace Generator;

internal class Program
{
	public static SteamApiDefinition Definitions;

	private static void Main( string[] args )
	{
		var content = File.ReadAllText( "steam_sdk/steam_api.json" );
		var def = JsonConvert.DeserializeObject<SteamApiDefinition>( content );

		Definitions = def;

		var generator = new CodeWriter( def );

		generator.ToFolder( "../Facepunch.Steamworks/Generated/" );
	}
}
