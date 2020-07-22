using HMUI;
using UnityEngine;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.FloatingScreen;
using IPA.Utilities;

namespace SiraMenuMusic
{
    public class MusicPlayer
    {
        private readonly ScreenSystem _screenSystem;
        private readonly FloatingScreen _floatingScreen;
        private readonly MusicPlayerView _musicPlayerView;

        public MusicPlayer(HierarchyManager hierarchyManager)
        {
            _screenSystem = hierarchyManager.GetField<ScreenSystem, HierarchyManager>("_screenSystem");
            _floatingScreen = FloatingScreen.CreateFloatingScreen(new Vector2(120f, 35f), false, Vector3.zero, Quaternion.identity);
            _musicPlayerView = BeatSaberUI.CreateViewController<MusicPlayerView>();
            _floatingScreen.SetRootViewController(_musicPlayerView, true);
            _floatingScreen.transform.SetParent(_screenSystem.transform, false);
            _floatingScreen.transform.localPosition = new Vector3(-2.08f, 2.8f, 1.45f);
            _floatingScreen.transform.localRotation = Quaternion.Euler(new Vector3(335f, 300f, 0f));
        }
    }
}