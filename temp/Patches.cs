// Decompiled with JetBrains decompiler
// Type: AnxietyAtNight.Patches
// Assembly: AnxietyAtNight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D7F874-26C7-4DBB-83B7-F81F26BF6D91
// Assembly location: F:\games\The Long Dark\Mods\AnxietyAtNight.dll

using HarmonyLib;
using Il2CppSystem;
using UnityEngine;
using ModSettings;
using temp;

[HarmonyPatch(typeof(Feat), "IsUnlockedAndEnabled")]
class Patch2
{
    static void Postfix(ref bool __result)
    {
        if (tempoption.Instance.turnallperks)
        {
            __result = true;
        }
    }
}