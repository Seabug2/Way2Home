using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;

public class Road : MonoBehaviour
{
    public readonly static Dictionary<Vector2Int, Road> Grid = new();

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void InitGrid()
    {
        SceneManager.sceneUnloaded += ClearGrid;
    }

    static void ClearGrid(Scene _)
    {
        Grid.Clear();
    }

    public bool[] RoadSide { get; private set; }

    public void Set(Vector2Int position)
    {
        Grid[position] = this;
        transform.position = new Vector3(position.x, 0, position.y);
    }

    public bool TrySet(Vector2Int position)
    {
        if (Grid.TryGetValue(position, out Road road))
        {
            return false;
        }

        Grid[position] = this;
        transform.position = new Vector3(position.x, 0, position.y);

        return true;
    }
}
