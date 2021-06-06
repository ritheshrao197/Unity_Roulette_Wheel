using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static bool isSpinning;

    public static int selectedNumber=-1;

    public static List<int> numberList = new List<int>  { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };

    public const float section = 36f;
    public static float wheelRoatationDuration= 5f;
    public static float ballRoatationDuration = 150;
    public static float wheelAngle;
    public static float ballAngle;
    internal static Vector3 ballPosition;
    internal static Transform wheelTransform;
    internal static Transform ballTransform;

    public static bool StopTheBall { get; internal set; }
}
