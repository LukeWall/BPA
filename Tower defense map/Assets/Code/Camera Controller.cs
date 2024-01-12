using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float panSpeed = 30f;
	public float panBorderThickness = 10f;

	public float scrollSpeed = 5f;
	public float minY = 10f;
	public float maxY = 80f;

	
	void Update()
	{

		if (Gamemanager.GameIsOver==true)
		{
			this.enabled = false;
			return;
		}//disable script if tje game is over
		
		if (Input.GetKey("w"))
		{
			transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
		}//when user clicks the W key camera moves up
		if (Input.GetKey("s"))
		{
			transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
		}//when user clicks the S key camera moves down
		if (Input.GetKey("d"))
		{
			transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
		}//when user clicks the D key camera moves right
		if (Input.GetKey("a"))
		{
			transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
		}//when user clicks the A key camera moves left

		float scroll = Input.GetAxis("Mouse ScrollWheel");

		Vector3 pos = transform.position;

		pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, minY, maxY);

		transform.position = pos;
		//when user scrolls up with scroll wheel camera zooms in
		//when user scrolls down with scroll wheel camera zooms out
	}
}
