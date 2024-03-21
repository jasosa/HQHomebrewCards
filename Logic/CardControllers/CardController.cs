using System;
using System.Drawing;

namespace HQHomebrewCards.Logic
{
    public abstract class CardController : ICardController
    {

        public event EventHandler ImageUpdated;        

        //Image Handlers
        internal ImageElement overlayCardHandler;
        internal ImageElement backgroundImageHandler;
        internal ImageElement scrollImageHandler;

        //Text Elements
        internal TextElement title;
        internal TextElement bodytext;

        //Default Values
        internal CardDefaults defaults;

        // ICardController Methods & Properties
        public ImageElement BackgroundImage => backgroundImageHandler;
        public ImageElement OverlyImage => overlayCardHandler;
        public ImageElement ScrollImage => scrollImageHandler;
        public TextElement Title { get => title; }
        public TextElement CardText { get => bodytext; }

        //Setup
        public abstract bool Setup_HasOldPaper { get; }
        public abstract bool Setup_HasScroll { get; }
        public abstract bool Setup_CanAddBorder { get; }
        public abstract bool ShowOldPaper { get; set; }
        public abstract bool ShowScroll { get; set; }
        public abstract bool ShowBorder { get; set; }
        public abstract StatsType TypeOfStats { get; set; }
        public abstract CardDefaults Defaults { get; }
        //public abstract int ScrollY { get; set; }        
        public abstract HeroStats HeroStats { get; }                

        public CardController()
        { 
        }        

        public abstract void AddOverlyImage(Image image);

        public void RemoveOverlyImage()
        {
            overlayCardHandler = null;
            OnImageUpdated(new EventArgs());
        }       

        public abstract void UpdateUI();

        internal virtual void OnImageUpdated(EventArgs e)
        {
            UpdateUI();
            ImageUpdated?.Invoke(this, e);
        }

        public void MoveOverlyImage(int X, int Y)
        {
            this.overlayCardHandler.PositionX = X;
            this.overlayCardHandler.PositionY = Y;
            OnImageUpdated(new EventArgs());
        }

        public void MoveElement(IMovableElement element, int X, int Y)
        {   
            ((IMovableElement)element).PositionX = X;
            ((IMovableElement)element).PositionY = Y;
            OnImageUpdated(new EventArgs());
        }

        internal void Bodytext_TextUpdated(object sender, EventArgs e)
        {
            OnImageUpdated(e);
        }

        internal void Title_TextUpdated(object sender, EventArgs e)
        {
            OnImageUpdated(e);
        }

        internal void OverlayCardHandler_ImageHandlerUpdated(object sender, EventArgs e)
        {
            OnImageUpdated(e);
        }
    }
}
