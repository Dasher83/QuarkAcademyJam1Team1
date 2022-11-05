using UnityEngine;

namespace QuarkAcademyJam1Team1.Scripts.Utils
{
    public static class CameraUtils
    {
        public static Bounds OrthographicBounds()
        {
            Camera camera = Camera.main;
            float cameraHeight = camera.orthographicSize * 2;
            float screenAspect = (float)Screen.width / (float)Screen.height;
            Bounds bounds = new Bounds(
                camera.transform.position,
                new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
            return bounds;
        }

        public static float RightEdgeInRealWorldUnits
        {
            get
            {
                return Camera.main.orthographicSize * 2 * Camera.main.aspect;
            }
        }

        public static float LeftEdgeInRealWorldUnits
        {
            get
            {
                return Camera.main.orthographicSize * 2 * Camera.main.aspect * -1;
            }
        }

        public static float UpperEdgeInRealWorldUnits
        {
            get
            {
                return Camera.main.orthographicSize;
            }
        }

        public static float LowerEdgeInRealWorldUnits
        {
            get
            {
                return Camera.main.orthographicSize * -1;
            }
        }
    }
}
