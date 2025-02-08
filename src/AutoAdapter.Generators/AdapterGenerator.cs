using Microsoft.CodeAnalysis;

namespace AutoAdapter.Generators;

[Generator]
public class AdapterGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(postInitializationContext =>
        {
        });
    }
}
