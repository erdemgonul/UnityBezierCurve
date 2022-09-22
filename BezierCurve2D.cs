using UnityEngine;

namespace beziercurve
{

    public class BezierCurve2D : MonoBehaviour
    {
        public  void drawQuadraticCurve(LineRenderer line, int numPoint, Vector3 startPoint, Vector3 edgePoint, Vector3 endPoint)
        {
            //edge point means handler point 
            Vector3[] positions = new Vector3[numPoint];
            for (int i = 0; i < numPoint; i++)
            {
                float t = i / (float)numPoint;
                positions[i] = CalculateQuadraticCurve2D(startPoint, edgePoint, endPoint, t);
            }
            line.SetPositions(positions);
        }

        private static Vector2 CalculateQuadraticCurve2D(Vector3 pos0, Vector3 pos1, Vector3 pos2, float t)
        {
            //2 points with ONE control Points means Quadratic
            // Mathematical Formula of Quadratic Curves
            Vector3 res = ((1 - t) * (1 - t) * pos0) + (2 * (1 - t) * t * pos1) + t * t * pos2;

            return new Vector2(res.x, res.y);

        }

        //B(t) = (1-t)3P0 + 3(1-t)2tP1 + 3(1-t)t2P2 + t3P3 , 0 < t< 1 
        private Vector3 CalculateQubicCurve3D(Vector3 pos0, Vector3 pos1, Vector3 pos2, Vector3 pos3, float t)
        {
            //2 points with TWO control Points means Qubic
            // Mathematical Formula of Qubic Curves
            //B(t) = (1-t)3P0 + 3(1-t)2tP1 + 3(1-t)t2P2 + t3P3 , 0 < t< 1  
            Vector3 res = ((1 - t) * (1 - t) * (1 - t) * pos0) + (3 * (1 - t) * (1 - t) * t * pos1) + (3 * (1 - t) * t * t * pos2) + (t * t * t * pos3);

            return res;
        }

        private Vector2 CalculateQubicCurve2D(Vector3 pos0, Vector3 pos1, Vector3 pos2, Vector3 pos3, float t)
        {
            // Mathematical Formula of Qubic Curves
            //B(t) = (1-t)3P0 + 3(1-t)2tP1 + 3(1-t)t2P2 + t3P3 , 0 < t< 1  
            Vector3 res = ((1 - t) * (1 - t) * (1 - t) * pos0) + (3 * (1 - t) * (1 - t) * t * pos1) + (3 * (1 - t) * t * t * pos2) + (t * t * t * pos3);

            return new Vector2(res.x, res.y);
        }
    }
}
