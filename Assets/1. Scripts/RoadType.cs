using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public enum RoadShape
{
    Corner_12to3 = 0,
    Corner_3to6 = 1,
    Corner_6to9 = 2,
    Corner_9to12 = 3,
    Straight_Horizontal = 4,
    Straight_Vertical = 5,
    None,
    Goal
}

public enum Direction
{
    North = 0,
    East = 1,
    South = 2,
    West = 3
}

public static class RoadRotation
{
    public static readonly Vector3[] Angles = new Vector3[]
    {
        new Vector3(0, 0, 0),
        new Vector3(0, 90, 0),
        new Vector3(0, 180, 0),
        new Vector3(0, 270, 0),
        new Vector3(0, 0, 180),
        new Vector3(0, 90, 180)
    };

    //북동남서
    public static readonly bool[,] Connections =
    {
        { true, true, false, false },
        { false, true, true, false },
        { false, false, true, true },
        { true, false, false, true },
        { true, false, true, false },
        { false, true, false, true },
        { false, false, false, false },
        { false, false, false, false }
    };

    public static readonly Vector2Int[] Directions = new[]
    {
        new Vector2Int(0, 1),   // North
        new Vector2Int(1, 0),   // East
        new Vector2Int(0, -1),  // South
        new Vector2Int(-1, 0)   // West
    };
}
