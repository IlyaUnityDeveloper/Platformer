using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Применяется на объектах Enemy
public class EnemyBehavior : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
	{
		//Перезапуск уровня при столкновении с врагом
		if (other.gameObject.tag == "Player")
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
