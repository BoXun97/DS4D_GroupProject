using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class NewRotation : MonoBehaviour, IDragHandler
{

	public Transform target;
	float speed = .3f;

	public void OnDrag(PointerEventData eventData)
	{
		Vector3 Vec3rote = new Vector3(eventData.delta.y, -eventData.delta.x);
		target.Rotate(Vec3rote * speed, Space.World);

	}
}
