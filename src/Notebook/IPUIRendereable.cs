using PeterHan.PLib.UI;
using UnityEngine;

namespace Notebook;

public interface IPUIRendereable
{
    RectOffset padding { get; }

    void BuildPUI(ref PPanel root);
}