using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : Character
{
	private static Player instance;
	public static Player Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<Player>();
			}
			return instance;
		}
	}
	// Start is called before the first frame update
	[SerializeField] private Tilemap tilemap;
    private Vector3 min, max;
	protected override void Start()
    {
        Vector3 mintile = tilemap.CellToWorld(tilemap.cellBounds.min);
        Vector3 maxtile = tilemap.CellToWorld(tilemap.cellBounds.max);
        SetLimints(mintile, maxtile);
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        GetInput();
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, min.x, max.x), Mathf.Clamp(transform.position.y, min.y, max.y), transform.position.y);
        base.Update();
    }

    public void SetLimints(Vector3 min, Vector3 max)
    {
        this.min = min;
        this.max = max;
    }

	private void GetInput()
	{
		Direction = Vector2.zero;
		if (Input.GetKey(KeyBindManager.MyInstance.Keybinds["UP"]))
		{
			Direction += Vector2.up;
		}
		if (Input.GetKey(KeyBindManager.MyInstance.Keybinds["DOWN"]))
		{
			Direction += Vector2.down;
		}
		if (Input.GetKey(KeyBindManager.MyInstance.Keybinds["LEFT"]))
		{
			Direction += Vector2.left;
		}
		if (Input.GetKey(KeyBindManager.MyInstance.Keybinds["RIGHT"]))
		{
			Direction += Vector2.right;
		}
	}
}
