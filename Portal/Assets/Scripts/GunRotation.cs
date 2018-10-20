
using UnityEngine;

public class GunRotation : MonoBehaviour {

	// Update is called once per frame
	private void Update () {
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}
