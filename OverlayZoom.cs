using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public static class OverlayZoom 
    {
        static float[] zoomValues = { 0.5f, 0.75f, 0.90f, 1f, 1.25f, 1.5f, 1.75f, 2f, 3f};
        static int currentZoomIndex = 3;

        public static float GetNextZoom()
        {
            if (currentZoomIndex + 1 < zoomValues.Length)
            {
                currentZoomIndex++;                
            }

            return zoomValues[currentZoomIndex];
        }

        public static float GetPreviousZoom()
        {
            if (currentZoomIndex -1 > 0)
            {
                currentZoomIndex--;
            }

            return zoomValues[currentZoomIndex];
        }

        public static float GetZoom (ZoomValue zoom)
        {
            currentZoomIndex = (int)zoom;
            return zoomValues[currentZoomIndex];
        }
        
    }

    public enum ZoomValue
    {
        X50,
        X75,
        X90,
        X100,
        X5125,
        X150,
        X175,
        X2,
        X3,
    }
}
