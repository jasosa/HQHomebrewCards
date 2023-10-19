using System.Drawing;

namespace HQHomebrewCards
{
    public interface ICardController
    {
        Color CardFontColor { get; set; }
        string CardFontColorString { get; set; }
        string CardFontName { get; set; }
        int CardFontSize { get; set; }
        string CardText { get; set; }        
        int OverlayX { get; set; }
        int OverlayY { get; set; }
        bool ShowOldPaper { get; set; }
        Color TitleFontColor { get; set; }
        string TitleFontColorString { get; set; }
        string TitleFontName { get; set; }
        int TitleFontSize { get; set; }
        int TitlePositionY { get; set; }
        string TitleText { get; set; }
        Image OriginalCardImage { get; }
        Image UdpatedCardImage { get; }
        float OverlayZoom { get; set; }        

        void AddOverlyImage(Image image);        
        Image GetOriginalOverlyImage();
        Image GetUpdatedOverlyImage();
        void UpdateUI();
        void RemoveOverlyImage();
        //void UpdateOverlyImage(Image newOverlayImage);
        void UpdateOverlyImage(float amount);
        Rectangle GetOverlayImageBoundaries();
    }
}