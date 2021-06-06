using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public abstract class Character : MonoBehaviour
{
	private Vector2 direction;
	public Vector2 Direction { get => direction; set => direction = value; }

	private static readonly float V = 10f;
    [SerializeField] private float spd = V;
	public float Spd { get => spd; set => spd = value; }
	public Transform MyTarget { get; set; }
    public Animator Animation { get; set; }

    protected Rigidbody2D physic;
	// Start is called before the first frame update
	protected virtual void Start()
    {
        physic = GetComponent<Rigidbody2D>();
        Animation = GetComponent<Animator>();
    }
	private void FixedUpdate()
	{
		Moving();
	}
	// Update is called once per frame
	protected virtual void Update()
    {
        AnimationHandle();
    }
	public void Moving()
	{
		physic.velocity = Direction.normalized * Spd;
	}
	public bool IsMoving
	{
		get
		{
			return Direction.x != 0 || Direction.y != 0;
		}
	}
	public void AnimationHandle()
	{
		if (IsMoving)
		{
			ActiveLayers("Walking");
			Animation.SetFloat("x", Direction.x);
			Animation.SetFloat("y", Direction.y);	
		}
		else
		{
			ActiveLayers("Idle");
		}
	}

	public void ActiveLayers(string Aniname)
	{
		for (int i = 0; i < Animation.layerCount; i++)
		{
			Animation.SetLayerWeight(i, 0);
		}
		Animation.SetLayerWeight(Animation.GetLayerIndex(Aniname), 1);
	}
}
