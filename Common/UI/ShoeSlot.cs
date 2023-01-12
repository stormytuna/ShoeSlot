using ShoeSlot.Common.Systems;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShoeSlot.Common.UI
{
    public class ShoeSlot : ModAccessorySlot
    {
        public override string Name => "ShoeSlot";

        public override string FunctionalTexture => "Terraria/Images/Item_" + ItemID.SpectreBoots;

        public override string VanityTexture => "Terraria/Images/Item_" + ItemID.SpectreBoots;

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context) {
            return ShoeSystem.Shoes.Contains(checkItem.type);
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo) {
            return ShoeSystem.Shoes.Contains(item.type);
        }

        public override bool IsVisibleWhenNotEnabled() {
            return false;
        }

        public override void OnMouseHover(AccessorySlotType context) {
            Main.hoverItemName = context switch {
                AccessorySlotType.FunctionalSlot => "Shoe",
                AccessorySlotType.VanitySlot => "Vanity Shoe",
                AccessorySlotType.DyeSlot => "Dye"
            };

            base.OnMouseHover(context);
        }
    }
}