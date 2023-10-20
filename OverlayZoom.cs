using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public static class OverlayZoom 
    {
        static List<float> zoomValues = new List<float>{ 0.10f, 0.25f, 0.5f, 0.75f, 0.90f, 1f, 1.25f, 1.5f, 1.75f, 2f, 3f};
        static int currentZoomIndex = 5;
        static int defaultZoomIndex = 5;

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
