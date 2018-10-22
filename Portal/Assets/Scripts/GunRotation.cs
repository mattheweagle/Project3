
using UnityEngine;

public class GunRotation : MonoBehaviour {

	// Update is called once per frame
    //pre: game starts
    //post: gun will points in the direction of the location of the mouse pointer
	private void Update () {
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}
