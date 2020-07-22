using Zenject;

namespace SiraMenuMusic.Installers
{
    public class SiraMenuMusicInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<MusicPlayer>().AsSingle().NonLazy();
        }
    }
}