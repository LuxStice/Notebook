using System.Reflection;
using HarmonyLib;
using KMod;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Notebook;

public class NotebookMod : UserMod2
{
    public const int DEFAULT_SPACING = 8;

    public static readonly RectOffset DEFAULT_PADDING = new RectOffset
    {
        top = 8, bottom = 6,
        left = 4, right = 4
    };
}