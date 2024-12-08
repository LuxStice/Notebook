// using TUNING;
// using UnityEngine;
//
// namespace Notebook;
//
// public class NotebookConfig : IBuildingConfig
// {
//     public const string ID = "Notebook";
//
//     public override BuildingDef CreateBuildingDef()
//     {
//         int width = 1;
//         int height = 1;
//         string anim = "";
//         int hitpoints = 10;
//         float construction_time = 10f;
//         float[] tieR1 = BUILDINGS.CONSTRUCTION_MASS_KG.TIER1;
//         string[] anyBuildable = MATERIALS.ANY_BUILDABLE;
//         float melting_point = 800f;
//         BuildLocationRule build_location_rule = BuildLocationRule.Anywhere;
//         EffectorValues none = NOISE_POLLUTION.NONE;
//         BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("Notepad", width, height, anim, hitpoints,
//             construction_time, tieR1, anyBuildable, melting_point, build_location_rule, BUILDINGS.DECOR.NONE, none);
//         buildingDef.ViewMode = OverlayModes.Decor.ID;
//         buildingDef.Floodable = false;
//         buildingDef.Overheatable = false;
//         buildingDef.AudioCategory = "Metal";
//         return buildingDef;
//     }
//
//     public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
//     {
//         base.ConfigureBuildingTemplate(go, prefab_tag);
//         go.AddOrGet<NotebookComponent>();
//     }
//
//     public override void DoPostConfigurePreview(BuildingDef def, GameObject go)
//     {
//         base.DoPostConfigurePreview(def, go);
//     }
//
//     public override void DoPostConfigureComplete(GameObject go)
//     {
//     }
// }