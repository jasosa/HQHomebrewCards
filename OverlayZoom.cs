using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public static class OverlayZoom 
    {
        static List<float> zoomValues = new List<float>{ 0.10f, 0.20f, 0.30f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f, 1f, 1.1f, 1.2f, 1.3f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f, 2.1f, 2.2f};
        static int currentZoomIndex = 9;
        static int defaultZoomIndex = 9;

        public static void SetDefaultZoom()
        {
            currentZoomIndex = defaultZoomIndex;
        }

        public static float GoToNextZoom()
        {
            if (currentZoomIndex + 1 < zoomValues.Count)
            {
                currentZoomIndex++;                
            }

            return zoomValues[currentZoomIndex];
        }

        public static float GoToPreviousZoom()
        {
            if (currentZoomIndex -1 >= 0)
            {
                currentZoomIndex--;
            }

            return zoomValues[currentZoomIndex];
        }

        public static void SetZoom (float zoom)
        {
            int index = zoomValues.FindIndex(f => f == zoom);
            if (index > -1)
            {
                currentZoomIndex = index;
            }
        }

        public static float GetCurrentZoom()
        {            
            return zoomValues[currentZoomIndex];
        }  
        
    }

    public enum ZoomValue
    {
        X10,
        X25,
        X50,
        X75,
        X90,
        X100,
        X125,
        X150,
        X175,
        X2,
        X3,
    }
}
