using System.Reflection.Emit;
using HarmonyLib;
using UnityEngine.Diagnostics;

namespace Notebook;

[HarmonyPatch(typeof(Game))]
public static class Game_Patcher
{
}

[HarmonyPatch(typeof(ManagementMenu))]
public static class ManagmentMenu_Patch
{

    public static ManagementMenu.ManagementMenuToggleInfo mmi = new ManagementMenu.ManagementMenuToggleInfo("Notebook Manager", "");
    public static KIconToggleMenu.ToggleInfo ti = (KIconToggleMenu.ToggleInfo)mmi;

    public static ManagementMenu.ManagementMenuToggleInfo GetManagementMenuToggleInfo()
    {
        return mmi;
    }
    
    public static ManagementMenu.ScreenData GetScreenData()
    {
        return new ManagementMenu.ScreenData
        {
            screen = GameScreenManager.Instance.InstantiateScreen(NotebookManagerScreen.GetOrCreateUI()),
            toggleInfo = mmi,
            cancelHandler = null,
            tabIdx = -1
        };;
    }
    
    
    [HarmonyTranspiler]
    [HarmonyPatch(nameof(ManagementMenu.OnPrefabInit))]
    static IEnumerable<CodeInstruction> AddNotesKToggle(IEnumerable<CodeInstruction> instructions)
    {
        var enumerator = instructions.GetEnumerator();
        int index = -1;

        while (enumerator.MoveNext())
        {
            var instruction = enumerator.Current;
            index++;
            yield return instruction;

            if (index == 446)
            {
                yield return new CodeInstruction(OpCodes.Ldarg_0);
                yield return new CodeInstruction(OpCodes.Ldfld,
                    AccessTools.Field(typeof(ManagementMenu), nameof(ManagementMenu.ScreenInfoMatch)));
                //load ToggleInfo
                yield return new CodeInstruction(OpCodes.Callvirt,
                    AccessTools.Method(typeof(ManagmentMenu_Patch), nameof(GetManagementMenuToggleInfo)));
                //load ScreenInfoMatchItem
                yield return new CodeInstruction(OpCodes.Callvirt,
                    AccessTools.Method(typeof(ManagmentMenu_Patch), nameof(GetScreenData)));
                yield return new CodeInstruction(OpCodes.Callvirt,
                    AccessTools.Method(typeof(Dictionary<ManagementMenu.ManagementMenuToggleInfo, ManagementMenu.ScreenData>),
                        nameof(Dictionary<ManagementMenu.ManagementMenuToggleInfo, ManagementMenu.ScreenData>.Add)));
            }
            if (index == 472)
            {
                yield return new CodeInstruction(OpCodes.Ldloc_1);
                yield return new CodeInstruction(OpCodes.Ldsfld,
                    typeof(ManagmentMenu_Patch).GetField(nameof(ti), AccessTools.all));
                yield return new CodeInstruction(OpCodes.Callvirt,
                    AccessTools.Method(typeof(List<KIconToggleMenu.ToggleInfo>),
                        nameof(List<KIconToggleMenu.ToggleInfo>.Add)));
            }
        }
    }
}