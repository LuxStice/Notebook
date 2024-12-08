using PeterHan.PLib.UI;
using UnityEngine;

namespace Notebook;

public partial class Note
{
    public struct Block : IPUIRendereable
    {
        public string label;
        public List<string> paragraphs;

        public Block(string label, params string[] paragraphs)
        {
            label = string.IsNullOrEmpty(label) ? "Note block" : label;
            this.paragraphs = new List<string>(paragraphs);
            padding = NotebookMod.DEFAULT_PADDING;
        }

        public RectOffset padding { get; set; } = new RectOffset(2, 2, 4, 4);

        public void BuildPUI(ref PPanel root)
        {
            var pPanel = new PPanel($"{label} panel")
            {
                Direction = PanelDirection.Vertical,
                Spacing = NotebookMod.DEFAULT_SPACING,
                Margin = padding,
                DynamicSize = true,
                FlexSize = Vector2.one
            };
            pPanel.Direction = PanelDirection.Vertical;
            pPanel.SetKleiBlueColor();


            var pLabel = new PLabel($"block label")
            {
                Text = label
            };
            pLabel.SetKleiPinkColor();
            pPanel.AddChild(pLabel);
            
            var paragraphsPanel = new PPanel("paragraphs")
            {
                Direction = PanelDirection.Vertical,
                Spacing = NotebookMod.DEFAULT_SPACING,
                Margin = new RectOffset(6,6,8,12),
                DynamicSize = true,
                FlexSize = Vector2.one
            };

            paragraphsPanel.SetKleiBlueColor();
            pPanel.AddChild(paragraphsPanel);

            foreach (var paragraph in paragraphs)
            {
                var textField = new PTextField()
                {
                    FlexSize = Vector2.one,
                    PlaceholderText = paragraph,
                    TextAlignment = TextAnchor.UpperLeft
                };

                textField.TextStyle.enableWordWrapping = true;
                textField.PlaceholderStyle.enableWordWrapping = true;
                
                paragraphsPanel.AddChild(textField);
            }

            root.AddChild(pPanel);
        }
    }
}