using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passablecheck : MonoBehaviour
{
	private List<Passable> pass = new List<Passable>();
	private void OnCollisionStay2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Water")
		{
			Passable o = collision.gameObject.GetComponent<Passable>();
			o.pass();
			Debug.Log("Pass B");
			pass.Add(o);
		}
	}
	
}
