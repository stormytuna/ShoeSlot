using ShoeSlot.Common.Systems;
using System;
using Terraria.ModLoader;

namespace ShoeSlot
{
    public class ShoeSlot : Mod
    {
        public override object Call(params object[] args) {
            if (args[0] is int shoeType) {
                ShoeSystem.Instance.RegisterShoe(shoeType);
                return true;
            }

            throw new Exception($"Expected int for args[0] but got {args[0].GetType()} instead");
        }
    }
}