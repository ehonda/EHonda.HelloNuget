using JetBrains.Annotations;

namespace EHonda.HelloNuget;

[PublicAPI]
public static class Another
{
    [Pure]
    public static string PureFunction() => "another pure function";
}
