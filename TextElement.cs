using System;
using System.Drawing;
using System.Xml.Serialization;

namespace HQHomebrewCards
{
    [Serializable]
    public class TextElement
    {
        private string fontName;
        private int fontSize;
        private Color fontColor;
        private string text;
        private int positionX;
        private int positionY;
        private int spaceBetweenLines;
        private int maxLenghtLine;

        public string Text { get => text; set => text = value; }
        public int PositionY { get => positionY; set => positionY = value; }
        public int PositionX { get => positionX; set => positionX = value; }    
        public int FontSize { get => fontSize; set => fontSize = value; }
        public string FontName { get => fontName; set => fontName = value; }

        [XmlIgnore]
        public Color FontColor { get => fontColor; set => fontColor = value; }
        [XmlElement("TitleFontColor")]
        public string FontColorString
        {
            get { return ColorTranslator.ToHtml(fontColor); }
            set { fontColor = ColorTranslator.FromHtml(value); }
        }

        public int SpaceBetweenLines { get => spaceBetweenLines; set => spaceBetweenLines = value; }
        public int MaxLenghtLine { get => maxLenghtLine; set => maxLenghtLine = value; }
    }
}
