using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Roadtile : Tile
{
	[SerializeField] private Sprite[] roadsprites;
	[SerializeField] private Sprite preview;

/*	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
	{
		return base.StartUp(position, tilemap, go);
	}*/
	public override void RefreshTile(Vector3Int position, ITilemap tilemap)
	{
		for (int x = -1; x <= 1; x++)
		{
			for (int y = -1; y <= 1; y++)
			{
				Vector3Int nPos = new Vector3Int(position.x + x, position.y + y, position.z);
				if (HasRoad(tilemap, nPos))
				{
					tilemap.RefreshTile(nPos);
				}
			}
		}
	}

	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
	{
		//base.GetTileData(position, tilemap, ref tileData);
		string composition = string.Empty;
		for (int x = -1; x <= 1; x++)
		{
			for (int y = -1; y <= 1; y++)
			{
				if (x != 0 || y != 0)
				{
					if (HasRoad(tilemap, new Vector3Int(position.x + x, position.y + y, position.z)))
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
			tileData.sprite = roadsprites[49];
		}
		else if (random >= 10 && random < 20)
		{

			tileData.sprite = roadsprites[47];
		}
		else if (random >= 20 && random < 40)
		{

			tileData.sprite = roadsprites[46];
		}
		else if (random >= 40 && random < 50)
		{

			tileData.sprite = roadsprites[50];
		}
		else if (random >= 50 && random < 60)
		{

			tileData.sprite = roadsprites[71];
		}
		else
		{
			tileData.sprite = roadsprites[48];
		}

		if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 10)
			{
				tileData.sprite = roadsprites[53];
			}
			else if (randomVal >= 10 && randomVal < 20)
			{
				tileData.sprite = roadsprites[54];
			}
			else if (randomVal >= 20 && randomVal < 30)
			{
				tileData.sprite = roadsprites[52];
			}
			else if (randomVal >= 30 && randomVal < 40)
			{
				tileData.sprite = roadsprites[51];
			}
			else if (random >= 50 && random < 70)
			{

				tileData.sprite = roadsprites[72];
			}
			else
			{
				tileData.sprite = roadsprites[0];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[6] == 'W' && composition[4] == 'E' && composition[5] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[55];
			}
			else
			{
				tileData.sprite = roadsprites[1];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[6] == 'W' && composition[4] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[65];
			}
			else
			{
				tileData.sprite = roadsprites[2];
			}
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'W' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[68];
			}
			else
			{
				tileData.sprite = roadsprites[3];
			}
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'E' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[69];
			}
			else
			{
				tileData.sprite = roadsprites[4];
			}
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'E' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[66];
			}
			else
			{
				tileData.sprite = roadsprites[5];
			}
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[67];
			}
			else
			{
				tileData.sprite = roadsprites[6];
			}
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[70];
			}
			else
			{
				tileData.sprite = roadsprites[7];
			}
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'W' && composition[6] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[64];
			}
			else
			{
				tileData.sprite = roadsprites[8];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			tileData.sprite = roadsprites[9];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'W' && composition[5] == 'E' && composition[7] == 'W')
		{
			tileData.sprite = roadsprites[10];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = roadsprites[11];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'E' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = roadsprites[12];
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = roadsprites[13];
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = roadsprites[14];
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = roadsprites[15];
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = roadsprites[16];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[56];
			}
			else
			{
				tileData.sprite = roadsprites[17];
			}
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[60];
			}
			else
			{
				tileData.sprite = roadsprites[18];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[4] == 'W' && composition[3] == 'E' && composition[6] == 'W' && composition[7] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[59];
			}
			else
			{
				tileData.sprite = roadsprites[19];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[63];
			}
			else
			{
				tileData.sprite = roadsprites[20];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[57];
			}
			else
			{
				tileData.sprite = roadsprites[21];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[62];
			}
			else
			{
				tileData.sprite = roadsprites[22];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[58];
			}
			else
			{
				tileData.sprite = roadsprites[23];
			}
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'E')
		{
			int randomVal = Random.Range(0, 100);
			if (randomVal < 20)
			{
				tileData.sprite = roadsprites[61];
			}
			else
			{
				tileData.sprite = roadsprites[24];
			}
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[6] == 'E' && composition[4] == 'E')
		{
			tileData.sprite = roadsprites[25];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[6] == 'W' && composition[4] == 'E')
		{
			tileData.sprite = roadsprites[26];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[6] == 'E' && composition[4] == 'W')
		{
			tileData.sprite = roadsprites[27];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[6] == 'E' && composition[4] == 'E')
		{
			tileData.sprite = roadsprites[28];
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[6] == 'W' && composition[4] == 'E')
		{
			tileData.sprite = roadsprites[29];
		}
		else if (composition[1] == 'E' && composition[4] == 'W' && composition[3] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = roadsprites[30];
		}
		else if (composition == "EWWWWEWW")
		{
			tileData.sprite = roadsprites[31];
		}
		else if (composition == "EWEWWWWE")
		{
			tileData.sprite = roadsprites[32];
		}
		else if (composition == "EWEWWWWW")
		{
			tileData.sprite = roadsprites[33];
		}
		else if (composition == "WWWWWEWW")
		{
			tileData.sprite = roadsprites[34];
		}
		else if (composition == "WWEWWWWE")
		{
			tileData.sprite = roadsprites[35];
		}
		else if (composition == "WWWWWWWE")
		{
			tileData.sprite = roadsprites[36];
		}
		else if (composition == "EWWWWWWW")
		{
			tileData.sprite = roadsprites[37];
		}
		else if (composition == "WWEWWWWW")
		{
			tileData.sprite = roadsprites[38];
		}
		else if (composition == "EWWWWWWE")
		{
			tileData.sprite = roadsprites[39];
		}
		else if (composition == "EWWWWEWE")
		{
			tileData.sprite = roadsprites[40];
		}
		else if (composition == "WWWWWEWE")
		{
			tileData.sprite = roadsprites[41];
		}
		else if (composition == "WWEWWEWW")
		{
			tileData.sprite = roadsprites[42];
		}
		else if (composition == "EWEWWEWW")
		{
			tileData.sprite = roadsprites[43];
		}
		else if (composition == "WWEWWEWE")
		{
			tileData.sprite = roadsprites[44];
		}
		else if (composition == "EWEWWEWE")
		{
			tileData.sprite = roadsprites[45];
		}
	}

	private bool HasRoad(ITilemap tilemap, Vector3Int Pos)
	{
		return tilemap.GetTile(Pos) == this;
	}

#if UNITY_EDITOR
	[MenuItem("Assets/Create/Tiles/RoadTile")]
	public static void CreateTile()
	{
		string path = EditorUtility.SaveFilePanelInProject("Save Roadtile", "New Roadtile", "asset", "Save roadtile", "Assets");
		if (path == "")
		{
			return;
		}
		AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<Roadtile>(), path);
	}
#endif
}
