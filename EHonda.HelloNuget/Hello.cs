using System.Diagnostics;
using JetBrains.Annotations;

namespace EHonda.HelloNuget;

[PublicAPI]
public static class Hello
{
    public static string Nuget => "Hello Nuget 0.9.0";

    // Function to test stepping into / stepping through functions
    public static int RandomSum()
    {
        var x = RandomInt(10);
        var y = RandomInt(20);
        return x + y;
    }

    [DebuggerStepThrough]
    private static int RandomInt(int upper) => Random.Shared.Next(upper);
    
    // Function to test what happens if we make JetBrains.Annotations private
    [Pure]
    public static string PureJetbrains() => nameof(PureJetbrains);
    
    // Compare with System.Diagnostics.Contracts.PureAttribute
    // Code contracts are not supported in .NET 5+, which is why we use the JetBrains attribute instead
    // See: https://learn.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts
    [System.Diagnostics.Contracts.Pure]
    public static string PureSystemDiagnostics() => nameof(PureSystemDiagnostics);

    public static string JetBrainsAssembly => typeof(PureAttribute).Assembly.FullName ?? string.Empty;
}
