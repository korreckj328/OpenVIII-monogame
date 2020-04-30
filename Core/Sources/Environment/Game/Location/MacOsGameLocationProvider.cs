using System.IO;

namespace OpenVIII
{
    public sealed class MacOsGameLocationProvider : IGameLocationProvider
    {
        public GameLocation GetGameLocation()
        {
            if (_hardcoded.FindGameLocation(out var gameLocation))
                return gameLocation;

            throw new DirectoryNotFoundException($"Cannot find game directory." +
                                                 $"Add your own path to the {nameof(LinuxGameLocationProvider)} type.");
        }

        private readonly HardcodedGameLocationProvider _hardcoded = new HardcodedGameLocationProvider(new[]
        {
            Path.Combine (System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal), "Library/Application Support/Steam/steamapps/common/FINAL FANTASY VIII")
        });
    }
}
