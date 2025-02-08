using AutoAdapter.Attributes;

namespace AutoAdapter.Samples.Adapters
{
    [Adapter(typeof(System.Fabric.FabricClient))]
    public sealed partial class FabricClient
    {
    }
}
