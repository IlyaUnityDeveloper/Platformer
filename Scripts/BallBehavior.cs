using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Применяется на объекте Ball
public class BallBehavior : MonoBehaviour
{
    public GroundCheckerBehavior grounds; //Объект GroundChecker
	[SerializeField]
	private Rigidbody2D rb;
	public float speed = 50f;
	public float jumpSpeed = 10f;
	
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update()
	{
		//Если шар на земле и нажат Пробел, то шар прыгает
		if ((Input.GetButtonDown("Jump")) && (grounds.countOfGrounds>0))
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
		}
		
		//Перемещение шара с помощью стрелок
		rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, rb.velocity.y);
		
		//Если шар далеко упал, перезапуск уровня
		if (transform.position.y < -10)
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
