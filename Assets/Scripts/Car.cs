using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	private float speed = Menu.carSpeed;

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

}



//public float minSpeed = 6f;
//public float maxSpeed = 12f;

//void Start ()
//{
//speed = Random.Range(minSpeed, maxSpeed);
//}