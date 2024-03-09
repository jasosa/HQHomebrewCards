using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQHomebrewCards
{
    public class TextFormatter
    {
        public static List<FormattedSegment> Format(Graphics graphics, string cardMainText, string fontName, int fontSize, Color fontColor)
        {
            List<FormattedSegment> fonts = new List<FormattedSegment>();
            string pattern = @"<[s\d+, b, i, \/b, \/i, c, \/c]+>|\w+|\s|\p{P}|\D";

            // Match text using the pattern
            MatchCollection matches = Regex.Matches(cardMainText, pattern);
            FontStyle fontStyle = FontStyle.Regular;
            int currentFontSize = fontSize;
            bool startCenteredSegment = false;
            bool continueCenteredSegment = false;

            bool addBreakLine = false;
            foreach (Match match in matches)
            {
                string matchText = match.Value;
                if (matchText.Contains("\n"))
                {
                    addBreakLine = true;
                }
                else if (matchText.StartsWith("<s") && matchText.Length == 5)
                {
                    int.TryParse(matchText.Substring(2, 2), out currentFontSize);
                    continue;
                }
                else
                {
                    switch (matchText)
                    {
                        case "<b>":
                            fontStyle |= FontStyle.Bold;
                            continue;
                        case "<i>":
                            fontStyle |= FontStyle.Italic;
                            continue;
                        case "<c>":
                            startCenteredSegment = true;
                            break;
                        case "</b>":
                            fontStyle &= ~FontStyle.Bold;
                            continue;
                        case "</i>":
                            fontStyle &= ~FontStyle.Italic;
                            continue;
                        case "</c>":
                            continueCenteredSegment = false;
                            continue;
                        case "</s>":
                            currentFontSize = fontSize;
                            continue;
                    }
                }

                if (addBreakLine)
                {
                    for (int i = 0; i < match.Length; i++)
                    {
                        if (matchText[i] == '\n')
                        {
                            fonts.Add(new BreaklineSegment(graphics, "breakline", new FontFamily(fontName), fontStyle, fontColor, currentFontSize));
                        }
                    }

                    addBreakLine = false;
                }
                else if (startCenteredSegment)
                {
                    startCenteredSegment = false;
                    fonts.Add(new FormattedSegment(graphics, string.Empty, new FontFamily(fontName), fontStyle, fontColor, currentFontSize, true));
                    continueCenteredSegment = true;
                }
                else if (continueCenteredSegment)
                {
                    fonts.Last().Text += matchText;
                }
                else
                {
                    fonts.Add(new FormattedSegment(graphics, matchText, new FontFamily(fontName), fontStyle, fontColor, currentFontSize, false));
                }

                Console.WriteLine(matchText);
            }

            return fonts;
        }

        public static void Write(Graphics graphics, int X, int Y, Brush titleBrush, List<FormattedSegment> segments, int maxLenght, int imageWidth, int lineSpace)
        {
            Point initialTextPosition = new Point(X, Y);
            Point currentTextPosition = initialTextPosition;

            foreach (FormattedSegment textSegment in segments)
            {
                int segmentTextSize = GetSegmentTextWidth(graphics, textSegment);

                if (textSegment.BreakLine)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, initialTextPosition, lineSpace);
                    continue;
                }

                if (segmentTextSize + currentTextPosition.X > maxLenght)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, initialTextPosition, lineSpace);
                }

                if (textSegment.Centered)
                {
                    currentTextPosition.X = (imageWidth - (int)graphics.MeasureString(textSegment.Text, textSegment.Font).Width) / 2;
                }

                graphics.DrawString(textSegment.Text, textSegment.Font, titleBrush, currentTextPosition.X, currentTextPosition.Y - textSegment.BaseLine);
                currentTextPosition.X += segmentTextSize;
            }
        }

        private static int GetSegmentTextWidth(Graphics graphics, FormattedSegment textSegment)
        {
            return TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Width;
        }

        private static Point GoToNextLine(Graphics graphics, FormattedSegment textSegment, Point currentPosition, Point originalPosition, int lineSpace)
        {
            Point nextLinePosition = new Point(
                originalPosition.X,
                currentPosition.Y + TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Height - lineSpace
                );
            return nextLinePosition;
        }
    }
}
