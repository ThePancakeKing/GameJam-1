using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSorter : MonoBehaviour
{
	private SpriteRenderer parentRender;
	private List<Obstacle> obstacles = new List<Obstacle>();
	private List<Passable> passable = new List<Passable>();
    // Start is called before the first frame update
    void Start()
    {
		parentRender = transform.parent.GetComponent < SpriteRenderer > ();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Vatcan")
		{
			Obstacle o = collision.GetComponent<Obstacle>();
			o.FadedOut();
			if (obstacles.Count == 0 || o.M_SpriteRender.sortingOrder -1 < parentRender.sortingOrder)
			{
				parentRender.sortingOrder = o.M_SpriteRender.sortingOrder - 1;
			}
			obstacles.Add(o);
		}
		if (collision.tag == "Passable")
		{
			Passable i = collision.GetComponent<Passable>();
			i.trigger();
			passable.Add(i);
		}
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Vatcan")
		{
			Obstacle o = collision.GetComponent<Obstacle>();
			o.FadeIn();
			obstacles.Remove(o);
			if (obstacles.Count == 0)
			{
				parentRender.sortingOrder = 200;
			}
			else
			{
				obstacles.Sort();
				parentRender.sortingOrder = obstacles[0].M_SpriteRender.sortingOrder - 1;
			}
		}
		if (collision.tag == "Passable")
		{
			Passable i = collision.GetComponent<Passable>();
			i.nottrigger();
			passable.Remove(i);
		}
	}
}
