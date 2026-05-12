using System.Collections.Generic;
using System.Text;

namespace Generator;

public partial class CodeWriter
{
	private int indent;
	private StringBuilder sb = new();
	private bool skipIndent;

	public string Indent
	{
		get
		{
			if ( skipIndent ) { return ""; }

			return new string( '\t', indent );
		}
	}

	private void EndBlock( string end = "" )
	{
		indent--;
		WriteLine( "}" + end );
	}


	private void WriteLine( string v = "" )
	{
		sb.AppendLine( $"{Indent}{v}" );
		skipIndent = false;
	}

	private void Write( string v = "" )
	{
		sb.Append( $"{Indent}{v}" );
		skipIndent = true;
	}

	private void StartBlock( string v )
	{
		WriteLine( v );
		WriteLine( "{" );

		indent++;
	}

	private void Else( string v = "" )
	{
		indent--;

		WriteLine( "}" );
		WriteLine( "else" + v );
		WriteLine( "{" );

		indent++;
	}

	private void WriteLines( List<string> beforeLines )
	{
		foreach ( var line in beforeLines )
		{
			if ( line == "}" )
			{
				indent--;
			}

			WriteLine( line );

			if ( line == "{" )
			{
				indent++;
			}
		}
	}
}
