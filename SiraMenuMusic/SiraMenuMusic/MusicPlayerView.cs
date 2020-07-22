using UnityEngine;
using UnityEngine.UI;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;

namespace SiraMenuMusic
{
    [HotReload]
    public class MusicPlayerView : BSMLAutomaticViewController
    {
        [UIComponent("background-bar")]
        public Image backgroundBar;

        [UIComponent("progress-bar")]
        public Image progressBar;

        protected override void DidActivate(bool firstActivation, ActivationType type)
        {
            base.DidActivate(firstActivation, type);
            backgroundBar.color = Color.gray;
            progressBar.color = Color.white;
            progressBar.type = Image.Type.Filled;
            progressBar.fillMethod = Image.FillMethod.Horizontal;
            progressBar.fillAmount = 0.75f;
        }
    }
}