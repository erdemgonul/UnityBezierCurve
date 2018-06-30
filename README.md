# Unity 2D Curve Draw & Collider



 Unity 2D Curve Draw & Collider is a component for drawing Bezier Curves and colliding them automatically from Script.



# Preview

 [Tinypic.com Preview Image of Collider](http://tinypic.com/view.php?pic=1z48sjs&s=9#.WzeCtbjYWUm)

# Installation:

### Method 1:



    * Open your Unity project
    * Go to Assets > Import Package > Custom Package > Browse 
    * Select beziercurve.unitypackage 
    * Select all the files
    * Click on Import



### Method 2:

    * Simply drag the Unity Bezier Curve folder to your project


# Usage



### From Script

You can add the Bezier Curve  Drawer and Bezier Curve Collider2D from script

```csharp
    EdgeCollider2D collider=lineRenderer.AddComponent<EdgeCollider2D>();
    BezierCurve2D curveDrawer = lineRenderer.AddComponent<BezierCurve2D>();
    curveDrawer.drawQuadraticCurve(lineRenderer, 500, startPoint, edgePoint, endPoint);
    BezierCurve2DCollider curveCollider = linePart.AddComponent<BezierCurve2DCollider>();
    curveCollider.CreateColliderQuadraticCurve2D(collider,500,startPoint,edgePoint,endPoint);
```
drawQuadraticCurve() draws a line according to given parameters.
##### Parameters of drawQuadraticCurve()
* LineRenderer
* Point number between the start point and end point
* Starting Vector3 of the Line
* EdgePoint Vector3 of the Line
* EndPoint Vector3 of the Line

CreateColliderQuadraticCurve2D() creates  a EdgeCollider2D according to given parameters at the specified line.
##### Parameters of CreateColliderQuadraticCurve2D()
* EdgeCollider2D of the lineRenderer
* Point number between the start point and end point
* Starting Vector3 of the Line
* EdgePoint Vector3 of the Line
* EndPoint Vector3 of the Line
