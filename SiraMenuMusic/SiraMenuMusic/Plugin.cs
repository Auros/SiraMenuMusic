using IPA;
using SiraMenuMusic.Installers;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace SiraMenuMusic
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        public Plugin(IPALogger logger)
        {
            Log = logger;
            Instance = this;
        }

        [OnEnable]
        public void OnEnable()
        {
            Installer.RegisterMenuInstaller<SiraMenuMusicInstaller>();
        }

        [OnDisable]
        public void OnDisable()
        {
            Installer.UnregisterMenuInstaller<SiraMenuMusicInstaller>();
        }
    }
}