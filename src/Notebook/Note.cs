using System.Collections.Generic;
using PeterHan.PLib.UI;
using UnityEngine;

namespace Notebook;

public partial class Note : IPUIRendereable
{
    public static Note TestInstance = new Note()
    {
        blocks = new List<Block>()
        {
            new Block()
            {
                label = "label1",
                paragraphs = new List<string>()
                {
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                }
            },
            new Block()
            {
                label = "label2",
                paragraphs = new List<string>()
                {
                    LoremIpsumLibrary.GetRandomParagraph(),
                }
            },
            new Block()
            {
                label = "label3",
                paragraphs = new List<string>()
                {
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                }
            },
            new Block()
            {
                label = "label4",
                paragraphs = new List<string>()
                {
                    "",
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                    "",
                    LoremIpsumLibrary.GetRandomParagraph(),
                    LoremIpsumLibrary.GetRandomParagraph(),
                }
            },
        }
    };


    public List<Block> blocks = new List<Block>();

    public RectOffset padding { get; set; } = new RectOffset(4,4,8,8);

    public void BuildPUI(ref PPanel root)
    {
        var mainPanel = new PPanel()
        {
            Direction = PanelDirection.Vertical,
            Spacing = 12,
            Margin = padding,
            Alignment = TextAnchor.MiddleLeft,
            DynamicSize = true,
            FlexSize = Vector2.one
        };

        mainPanel.AddChild(new PLabel()
        {
            Text = "Notebook Manager".ToUpper()
        });

        mainPanel.SetKleiPinkColor();
        
        var notesPanel = new PPanel()
        {
            Direction = PanelDirection.Vertical,
            Spacing = 4,
            Margin = padding,
            Alignment = TextAnchor.MiddleLeft,
            DynamicSize = true,
            FlexSize = Vector2.one
            
        };
        notesPanel.SetKleiBlueColor();
        
        mainPanel.AddChild(notesPanel);
        
        foreach (var block in blocks)
        {
            block.BuildPUI(ref notesPanel);
        }

        root.AddChild(mainPanel);
    }
}