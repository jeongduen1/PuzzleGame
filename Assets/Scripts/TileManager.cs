using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static TileManager Instance;
    public GameObject lightPrefab, switchPrefab, emptyPrefab;
    public Transform tileParent;
    public Camera camera;
    string[] mapData = new string[] {};

    private Tile[,] tiles;

    void Awake() => Instance = this;

    void Start()
    {
        GenerateMap(GameManager.Instance.selectedStageIndex);
    }

    void GenerateMap(int index)
    {
        mapData = StageManager.Instance.stages[index];

        int height = mapData.Length;
        int width = mapData[0].Length;
        tiles = new Tile[width, height];

        if (height % 2 == 0)
        {
            camera.transform.position = new Vector3((width + 1) / 2 - 0.5f, -((height + 1) / 2 - 0.5f), -10);
        }
        else
        {
            camera.transform.position = new Vector3((width - 1) / 2, -((height - 1) / 2), -10);
        }

        for (int y = 0; y < height; y++)
        {
            string row = mapData[y];
            for (int x = 0; x < row.Length; x++)
            {
                char tileType = row[x];
                GameObject prefab = tileType switch
                {
                    'L' => lightPrefab,
                    'S' => switchPrefab,
                    _ => emptyPrefab,
                };

                GameObject go = Instantiate(prefab, new Vector3(x, -y, 0), Quaternion.identity, tileParent);
                Tile tile = go.GetComponent<Tile>();
                tile.x = x;
                tile.y = y;
                tiles[x, y] = tile;
            }
        }
    }

    public void ToggleLightsAround(int x, int y)
    {
        Vector2Int[] directions = {
            new Vector2Int(0, 0),
            new Vector2Int(0, 1),
            new Vector2Int(1, 0),
            new Vector2Int(0, -1),
            new Vector2Int(-1, 0)
        };

        foreach (var dir in directions)
        {
            int tx = x + dir.x, ty = y + dir.y;
            if (IsInBounds(tx, ty) && tiles[tx, ty] is LightTile lt)
                lt.Toggle();
        };

        GameManager.Instance.CheckClearCondition();
    }

    bool IsInBounds(int x, int y) =>
        x >= 0 && x < tiles.GetLength(0) && y >= 0 && y < tiles.GetLength(1);
}