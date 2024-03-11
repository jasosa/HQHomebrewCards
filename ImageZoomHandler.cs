using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public class ImageZoomHandler 
    {
        List<float> zoomValues = new List<float>{ 0.10f, 0.20f, 0.30f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f, 1f, 1.1f, 1.2f, 1.3f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f, 2.1f, 2.2f};
        int currentZoomIndex = 9;
        int defaultZoomIndex = 9;
        
        public void SetDefaultZoom()
        {
            currentZoomIndex = defaultZoomIndex;         
        }

        public void ZoomIn()
        {
            if (currentZoomIndex + 1 < zoomValues.Count)
            {
                currentZoomIndex++;                
            }
        }

        public void ZoomOut()
        {
            if (currentZoomIndex -1 >= 0)
            {
                currentZoomIndex--;
            }
        }

        public void SetZoom (float zoom)
        {
            int index = zoomValues.FindIndex(f => f == zoom);
            if (index > -1)
            {
                currentZoomIndex = index;
            }
        }

        public float GetCurrentZoomLevel()
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
