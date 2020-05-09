using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Применяется на объекте GroundChecker
public class GroundCheckerBehavior : MonoBehaviour
{
	public int countOfGrounds; //Количество земли, на которой присутствует шар
	[SerializeField]
	private Rigidbody2D rb;
	public Transform ball; //Сам шар, точнее его позиция
	
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update()
	{
		//Помещение детектора коллизий под шар
		rb.MovePosition(ball.position + new Vector3(0, -0.1f, 0));
	}
	
    void OnTriggerEnter2D(Collider2D other)
	{
		//Шар стоит на земле
		if (other.gameObject.tag == "Ground")
		{
			countOfGrounds += 1;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		//Земля под шаром ушла
		if (other.gameObject.tag == "Ground")
		{
			countOfGrounds -= 1;
		}
	}
}
