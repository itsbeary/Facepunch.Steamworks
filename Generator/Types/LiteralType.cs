/// <summary>
///     Used to replace a variable with a literal.
///     This is used when we can determine a parameter ourselves. For example
///     if you're passing a buffer and a paramter is the buffer length
/// </summary>
internal class LiteralType : BaseType
{
	private readonly BaseType baseType;
	private readonly string Value;

	public LiteralType( BaseType baseType, string value )
	{
		this.baseType = baseType;
		Value = value;

		VarName = baseType.VarName;
	}

	public bool IsOutValue => !string.IsNullOrEmpty( Ref );
	public string OutVarDeclaration => IsOutValue ? $"{baseType.TypeName} sz{VarName} = {Value};" : null;

	public override bool ShouldSkipAsArgument => true;

	public override string Ref => baseType.Ref;
	public override bool IsVector => false;

	public override string AsArgument()
	{
		return baseType.AsArgument();
	}

	public override string AsCallArgument()
	{
		return string.IsNullOrEmpty( Ref ) ? Value : $"{Ref}sz{VarName}";
	}
}
