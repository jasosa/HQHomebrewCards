using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public class FormattedSegment
    {
        public Font Font { get; set; }
        public Color Color { get; set; }
        public float BaseLine { get; set; }
        public string Text { get; set; }
        public bool BreakLine { get; set; }
        public bool Centered{ get; set; }

        public FormattedSegment(Graphics graphics, string text, FontFamily fontFamily, FontStyle style, Color color, float height, bool centered)
        {
            Font = new Font(fontFamily, height, style);
            Color = color;
            Text = text;            
            float lineSpace = fontFamily.GetLineSpacing(Font.Style);
            float ascent = fontFamily.GetCellAscent(Font.Style);
            BaseLine = Font.GetHeight(graphics) * ascent / lineSpace;
            Centered= centered;
            BreakLine = false;
        }
    }

    public class BreaklineSegment : FormattedSegment
    {
        public BreaklineSegment(Graphics graphics, string text, FontFamily fontFamily, FontStyle style, Color color, float height):base(graphics, text, fontFamily, style, color, height, false)
        {
            BreakLine = true;
        }
    }
}
