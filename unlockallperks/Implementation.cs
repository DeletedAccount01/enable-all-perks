// Decompiled with JetBrains decompiler
// Type: AnxietyAtNight.Implementation
// Assembly: AnxietyAtNight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D7F874-26C7-4DBB-83B7-F81F26BF6D91
// Assembly location: F:\games\The Long Dark\Mods\AnxietyAtNight.dll

using hungerboostdamage;
using Il2CppSystem;
using MelonLoader;
using UnityEngine;

namespace temp
{
    internal class Implementation : MelonMod
  {
        public override void OnApplicationStart()
        {
            tempoption.Instance = new tempoption();
            tempoption.Instance.AddToModSettings("all perks active");
            Debug.Log("[" + this.InfoAttribute.Name + "] version " + this.InfoAttribute.Version + " loaded!");
        }
 
    }
    }
//if (GameManager.m_Hunger.m_CurrentReserveCalories == 0)
//{
//    GameManager.m_Condition.m_CurrentHP -= temp.Instance.HungerDamageMultiplier / 50f;

// }
