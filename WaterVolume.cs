using UnityEngine;
using SDG.Unturned;

namespace SDG.Framework.Water
{
    // Generate the water of the BoxCollider on the base Game Object
    // BoxCollider must have 'isTrigger' set to True
    // Game Object Layer is set to 4 at runtime and cannot be overriden
    public class WaterVolume : MonoBehaviour
    {       
        public ERefillWaterType waterType;
    }
}

namespace SDG.Unturned
{
  public enum ERefillWaterType
  {
    EMPTY,
    CLEAN,
    SALTY,
    DIRTY,
  }
}
