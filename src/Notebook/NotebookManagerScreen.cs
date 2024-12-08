using System;
using System.Collections.Generic;
using PeterHan.PLib.UI;
using UnityEngine;

namespace Notebook;

public class NotebookManagerScreen : KScreen
{
    public static NotebookManagerScreen Instance;
    public bool IsShowingUI;

    private void Start()
    {
        Instance = this;
    }
    
    public static void ShowWindow(bool value = true)
    {
        Instance.IsShowingUI = value;
        Instance.Show(Instance.IsShowingUI);
    }

    protected override void OnShow(bool show)
    {
        base.OnShow(show);
        IsShowingUI = show;
    }

    public static GameObject GetOrCreateUI()
    {
        var rootPanel = new PPanel("Notebook Manager")
        {
            Direction = PanelDirection.Vertical,
            Alignment = TextAnchor.MiddleCenter
        };
        Note.TestInstance.BuildPUI(ref rootPanel);
        var go = rootPanel.Build();
        go.AddComponent<NotebookManagerScreen>();

        return go;
    }
}