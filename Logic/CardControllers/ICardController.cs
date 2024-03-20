using System;
using System.Drawing;
using HQHomebrewCards.Logic;

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
        ImageElement BackgroundImage{ get; }
        ImageElement OverlyImage { get; } 
        void AddOverlyImage(Image image);                        
        void RemoveOverlyImage();
        //void MoveOverlyImage(int X, int Y);

        void UpdateUI();
        void MoveElement(IMovableElement element,  int X, int Y);

        CardDefaults Defaults { get; }
        HeroStats HeroStats { get; }

        event EventHandler ImageUpdated;
    }
}