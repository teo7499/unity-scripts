using UnityEngine;

[ExecuteInEditMode]
public class PixelDensityCamera : MonoBehaviour {


	public int ScreenSize = 1080;
	public float pixelsToUnits = 100;

	void Update () {

		GetComponent<Camera>().orthographicSize = ScreenSize / pixelsToUnits / 2;
	}
}
