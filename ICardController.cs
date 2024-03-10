using System.Drawing;

namespace HQHomebrewCards
{
    public interface ICardController
    {
        bool Setup_HasOldPaper { get; }
        bool Setup_HasScroll { get; }
        bool Setup_CanAddBorder { get; }        
      
        bool ShowOldPaper { get; set; }
        bool ShowScroll { get; set; }
        bool ShowBorder { get; set; }
        int ScrollY { get; set; }
        StatsType TypeOfStats { get; set; }  
        TextElement Title { get; }
        TextElement CardText { get; }
        ImageCardHandler BackgroundImage{ get; }
        ImageCardHandler OverlyImage { get; }
        float ZoomOverlay { get; set; }        
        void AddOverlyImage(Image image);                        
        void RemoveOverlyImage();        
        void UpdateOverlyImage(float amount);
        Rectangle GetOverlayImageBoundaries();
        void UpdateUI();
        CardDefaults Defaults { get; }
        HeroStats HeroStats { get; }
    }
}