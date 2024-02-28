using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShoeSlot.Common.Systems
{
    public class ShoeSystem : ModSystem
    {
        public static ShoeSystem Instance => ModContent.GetInstance<ShoeSystem>();

        private static List<int> _shoes = new();
        public static List<int> Shoes => _shoes;

        public override void PostSetupContent() {
            foreach (var item in ContentSamples.ItemsByType.Values) {
                if (item.shoeSlot > 0) {
                    _shoes.Add(item.type);
                }
            }

            // Manually adding some popular modded boots that don't work
            TryRegisterShoe("CalamityMod/AngelTreads");
            TryRegisterShoe("CalamityMod/TracersSeraph");
            TryRegisterShoe("CalamityMod/TracersCelestial");
            TryRegisterShoe("CalamityMod/TracersElysian");
            TryRegisterShoe("FargowiltasSouls/ZephyrBoots");

            base.PostSetupContent();
        }

        public void RegisterShoe(int type) {
            if (!_shoes.Contains(type)) {
                _shoes.Add(type);
            }
        }

        public void TryRegisterShoe(string fullName) {
            if (ModContent.TryFind(fullName, out ModItem item)) {
                RegisterShoe(item.Type);
            }
        }
    }
}
