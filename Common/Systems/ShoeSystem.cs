using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShoeSlot.Common.Systems
{
    public class ShoeSystem : ModSystem
    {
        public static ShoeSystem Instance => ModContent.GetInstance<ShoeSystem>();

        private static List<int> _shoes = new List<int>();
        public static List<int> Shoes { get => _shoes; }

        public override void PostSetupContent() {
            foreach (var item in ContentSamples.ItemsByType.Values) {
                if (item.shoeSlot > 0) {
                    _shoes.Add(item.type);
                }
            }

            base.PostSetupContent();
        }

        public void RegisterShoe(int type) {
            if (!_shoes.Contains(type)) {
                _shoes.Add(type);
            }
        }
    }
}
