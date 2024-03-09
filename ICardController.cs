using System.Drawing;

namespace HQHomebrewCards
{
    public interface ICardController
    {
        bool Setup_HasOldPaper { get; }
        bool Setup_HasScroll { get; }
        bool Setup_CanAddBorder { get; }
        //Color CardFontColor { get; set; }
        //string CardFontColorString { get; set; }
        //string TextFontName { get; set; }
        //int TextFontSize { get; set; }
        //string Text { get; set; }        
        int OverlayX { get; set; }
        int OverlayY { get; set; }
        bool ShowOldPaper { get; set; }
        bool ShowScroll { get; set; }
        bool ShowBorder { get; set; }
        int ScrollY { get; set; }
        StatsType TypeOfStats { get; set; }  
        TextElement Title { get; }
        TextElement CardText { get; }
        Image OriginalCardImage { get; }
        Image UdpatedCardImage { get; }
        float ZoomOverlay { get; set; }        
        
        void AddOverlyImage(Image image);        
        Image GetOriginalOverlyImage();
        Image GetUpdatedOverlyImage();
        void UpdateUI();
        void RemoveOverlyImage();
        //void UpdateOverlyImage(Image newOverlayImage);
        void UpdateOverlyImage(float amount);
        Rectangle GetOverlayImageBoundaries();
        CardDefaults Defaults { get; }

        HeroStats HeroStats { get; }
    }
}