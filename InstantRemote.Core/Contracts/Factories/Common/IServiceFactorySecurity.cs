using InstantRemote.Core.Contracts.Services;

namespace InstantRemote.Core.Contracts.Factories.Common
{
    public interface IServiceFactorySecurity
    {
        IServiceAuth ServiceAuth { get; }
    }
}
