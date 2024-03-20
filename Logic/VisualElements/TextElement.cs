using System;
using System.Drawing;
using System.Windows.Media.TextFormatting;
using System.Xml.Serialization;

namespace HQHomebrewCards.Logic
{
    [Serializable]
    public class TextElement: IMovableElement
    {
        public event EventHandler TextUpdated;
        public event EventHandler PositionChanged;

        private string fontName;
        private int fontSize;
        private Color fontColor;
        private string text;
        private int positionX;
        private int positionY;
        private int spaceBetweenLines;
        private int maxLenghtLine;

        public TextElement(string fontName, int fontSize, int positioX, int positionY, Color fontColor, int spaceBetweenLines, int maxLenghtLine, string text)
        {
            this.fontName = fontName;
            this.fontSize = fontSize;
            this.positionX = positioX;
            this.positionY = positionY;
            this.fontColor = fontColor;
            this.spaceBetweenLines = spaceBetweenLines;
            this.maxLenghtLine = maxLenghtLine;
            this.text = text;
        }

        public string Text { get => text; set { text = value; OnTextUpdated(new EventArgs()); } }
        public int PositionY { get => positionY; set { positionY = value; OnTextUpdated(new EventArgs()); } }
        public int PositionX { get => positionX; set { positionX = value; OnTextUpdated(new EventArgs()); } }   
        public int FontSize { get => fontSize; set { fontSize = value; OnTextUpdated(new EventArgs()); } }
        public string FontName { get => fontName; set { fontName = value; OnTextUpdated(new EventArgs()); } }

        [XmlIgnore]
        public Color FontColor { get => fontColor; set { fontColor = value; OnTextUpdated(new EventArgs()); } }
        [XmlElement("TitleFontColor")]
        public string FontColorString
        {
            get { return ColorTranslator.ToHtml(fontColor); }
            set { fontColor = ColorTranslator.FromHtml(value); OnTextUpdated(new EventArgs()); }
        }

        public int SpaceBetweenLines { get => spaceBetweenLines; set { spaceBetweenLines = value; OnTextUpdated(new EventArgs()); } }
        public int MaxLenghtLine { get => maxLenghtLine; set { maxLenghtLine = value; OnTextUpdated(new EventArgs()); } }

        internal virtual void OnTextUpdated(EventArgs e)
        {   
            TextUpdated?.Invoke(this, e);
        }

        internal virtual void OnImageMoved()
        {
            PositionChanged?.Invoke(this, new EventArgs());
        }
    }
}
