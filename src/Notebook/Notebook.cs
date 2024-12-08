using System.Collections.Generic;
using PeterHan.PLib.UI;
using UnityEngine;

namespace Notebook;

public class Notebook : IPUIRendereable
{
    public GameObject rootPanel;
    public string name = "Book of Notes";
    public List<Note> notes = new List<Note>() { Note.TestInstance };
    public RectOffset padding { get; set; } = new RectOffset(4,4,12,8);
    public void BuildPUI(ref PPanel root)
    {
        var pPanel = new PPanel($"Notebook {name}")
        {
            Direction = PanelDirection.Vertical,
            Margin = padding,
            Spacing = NotebookMod.DEFAULT_SPACING
        };
        pPanel.SetKleiPinkColor();

        foreach (var note in notes)
        {
            note.BuildPUI(ref pPanel);
        }

        rootPanel = pPanel.Build();
    }
}