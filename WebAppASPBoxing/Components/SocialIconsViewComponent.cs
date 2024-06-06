using Microsoft.AspNetCore.Mvc;

namespace WebAppASPBoxing.Components
{
    public class SocialIconsViewComponent:ViewComponent
    {
        private List<KeyValuePair<string, string>> _socialIcons;

        public SocialIconsViewComponent() 
        {
            _socialIcons = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("https://uk-ua.facebook.com/","images/facebook.png"),
                new KeyValuePair<string, string>("https://x.com/?lang=ru","images/twitter.png"),
                new KeyValuePair<string, string>("https://ua.linkedin.com/","images/linkedin.png"),
                new KeyValuePair<string, string>("https://www.instagram.com/","images/instagram.png"),
                new KeyValuePair<string, string>("https://www.youtube.com/","images/youtube.png")
            };
        }

        public IViewComponentResult Invoke()
        {
            return View("SocialIcons", _socialIcons);
        }
    }
}
