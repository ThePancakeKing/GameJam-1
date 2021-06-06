using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Watertile : Tile
{
	[SerializeField] private Sprite[] watersprites;
	[SerializeField] private Sprite preview;

	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
	{
		return base.StartUp(position, tilemap, go);
	}
	public override void RefreshTile(Vector3Int position, ITilemap tilemap)
	{
		for (int x = -1; x <= 1; x++)
		{
			for (int y = -1; y <= 1; y++)
			{
				Vector3Int nPos = new Vector3Int(position.x + x, position.y + y, position.z);
				if (HasWater(tilemap, nPos))
				{
					tilemap.RefreshTile(nPos);
				}
			}
		}
	}

	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
	{
		base.GetTileData(position, tilemap, ref tileData);
		string composition = string.Empty;
		for (int x = -1; x <= 1; x++)
		{
			for (int y = -1; y <= 1; y++)
			{
				if (x != 0 || y != 0)
				{
					if (HasWater(tilemap, new Vector3Int(position.x + x, position.y + y, position.z)))
					{
						composition += 'W';
					}
					else
					{
						composition += 'E';
					}
				}
			}
		}
		int random = Random.Range(0, 100);

		if (random < 10)
		{
			tileData.sprite = watersprites[49];
		}
		else if (random >= 10 && random < 20)
		{

			tileData.sprite = watersprites[47];
		}
		else if (random >= 20 && random < 40)
		{

			tileData.sprite = watersprites[46];
		}
		else if (random >= 40 && random < 50)
		{

			tileData.sprite = watersprites[50];
		}
		else
		{
			tileData.sprite = watersprites[48];
		}

		if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 10)
			{
				tileData.sprite = watersprites[53];
			}
			else if (randomVal >= 10 && randomVal < 20)
			{
				tileData.sprite = watersprites[54];
			}
			else if (randomVal >= 20 && randomVal < 30)
			{
				tileData.sprite = watersprites[52];
			}
			else if (randomVal >= 30 && randomVal < 40)
			{
				tileData.sprite = watersprites[51];
			}
			else
			{
				tileData.sprite = watersprites[0];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[6] == 'W' && composition[4] == 'E' && composition[5] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[55];
			}
			else
			{
				tileData.sprite = watersprites[1];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[6] == 'W' && composition[4] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[65];
			}
			else
			{
				tileData.sprite = watersprites[2];
			}
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'W' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[68];
			}
			else
			{
				tileData.sprite = watersprites[3];
			}
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'E' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[69];
			}
			else
			{
				tileData.sprite = watersprites[4];
			}
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'E' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[66];
			}
			else
			{
				tileData.sprite = watersprites[5];
			}
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[67];
			}
			else
			{
				tileData.sprite = watersprites[6];
			}
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[70];
			}
			else
			{
				tileData.sprite = watersprites[7];
			}
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'W' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[64];
			}
			else
			{
				tileData.sprite = watersprites[8];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			tileData.sprite = watersprites[9];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'W' && composition[5] == 'E' && composition[7] == 'W')
		{
			tileData.sprite = watersprites[10];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = watersprites[11];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'E' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = watersprites[12];
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = watersprites[13];
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = watersprites[14];
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = watersprites[15];
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = watersprites[16];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[56];
			}
			else
			{
				tileData.sprite = watersprites[17];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[60];
			}
			else
			{
				tileData.sprite = watersprites[18];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[4] == 'W' && composition[3] == 'E' && composition[6] == 'W' && composition[7] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[59];
			}
			else
			{
				tileData.sprite = watersprites[19];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[63];
			}
			else
			{
				tileData.sprite = watersprites[20];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[57];
			}
			else
			{
				tileData.sprite = watersprites[21];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[62];
			}
			else
			{
				tileData.sprite = watersprites[22];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[58];
			}
			else
			{
				tileData.sprite = watersprites[23];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = watersprites[61];
			}
			else
			{
				tileData.sprite = watersprites[24];
			}
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[6] == 'E' && composition[4] == 'E')
		{
			tileData.sprite = watersprites[25];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[6] == 'W' && composition[4] == 'E')
		{
			tileData.sprite = watersprites[26];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[6] == 'E' && composition[4] == 'W')
		{
			tileData.sprite = watersprites[27];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[6] == 'E' && composition[4] == 'E')
		{
			tileData.sprite = watersprites[28];
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[6] == 'W' && composition[4] == 'E')
		{
			tileData.sprite = watersprites[29];
		}
		else if (composition[1] == 'E' && composition[4] == 'W' && composition[3] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = watersprites[30];
		}
		else if (composition == "EWWWWEWW")
		{
			tileData.sprite = watersprites[31];
		}
		else if (composition == "EWEWWWWE")
		{
			tileData.sprite = watersprites[32];
		}
		else if (composition == "EWEWWWWW")
		{
			tileData.sprite = watersprites[33];
		}
		else if (composition == "WWWWWEWW")
		{
			tileData.sprite = watersprites[34];
		}
		else if (composition == "WWEWWWWE")
		{
			tileData.sprite = watersprites[35];
		}
		else if (composition == "WWWWWWWE")
		{
			tileData.sprite = watersprites[36];
		}
		else if (composition == "EWWWWWWW")
		{
			tileData.sprite = watersprites[37];
		}
		else if (composition == "WWEWWWWW")
		{
			tileData.sprite = watersprites[38];
		}
		else if (composition == "EWWWWWWE")
		{
			tileData.sprite = watersprites[39];
		}
		else if (composition == "EWWWWEWE")
		{
			tileData.sprite = watersprites[40];
		}
		else if (composition == "WWWWWEWE")
		{
			tileData.sprite = watersprites[41];
		}
		else if (composition == "WWEWWEWW")
		{
			tileData.sprite = watersprites[42];
		}
		else if (composition == "EWEWWEWW")
		{
			tileData.sprite = watersprites[43];
		}
		else if (composition == "WWEWWEWE")
		{
			tileData.sprite = watersprites[44];
		}
		else if (composition == "EWEWWEWE")
		{
			tileData.sprite = watersprites[45];
		}
	}

	private bool HasWater(ITilemap tilemap, Vector3Int Pos)
	{
		return tilemap.GetTile(Pos) == this;
	}

#if UNITY_EDITOR
	[MenuItem("Assets/Create/Tiles/Watertile")]
	public static void CreateTile()
	{
		string path = EditorUtility.SaveFilePanelInProject("Save Watertile", "New Watertile", "asset", "Save watertile", "Assets");
		if (path == "")
		{
			return;
		}
		AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<Watertile>(), path);
	}
#endif
}
