/// <summary>
///     Passes a pointer to a buffer as an argument, then converts
///     it into a string which is returned via an out param.
///     This is used of "char *" parameters which expect you to pass in
///     a buffer to retrieve the text. Usually \0 terminated.
/// </summary>
internal class FetchStringType : BaseType
{
	public string BufferSizeParamName; // optional, use next parameter if not set

	public override string TypeName => "string";
	public override string Ref => "";

	public override string AsArgument()
	{
		return $"out string {VarName}";
	}

	public override string AsNativeArgument()
	{
		return $"IntPtr {VarName}";
	}

	public override string AsCallArgument()
	{
		return $"mem__{VarName}";
	}
}
