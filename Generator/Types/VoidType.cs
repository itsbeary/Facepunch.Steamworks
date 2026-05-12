/// <summary>
///     Nothing - just priny void
/// </summary>
internal class VoidType : BaseType
{
	public override string TypeName => "void";
	public override string TypeNameFrom => "void";
	public override bool IsVoid => true;

	public override string Return( string varname )
	{
		return "";
	}
}
