using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShoeSlot.Common.Systems;

public class ShoeSystem : ModSystem
{
	public static ShoeSystem Instance => ModContent.GetInstance<ShoeSystem>();

	public static List<int> Shoes { get; } = new();

	public override void PostSetupContent() {
		foreach (Item item in ContentSamples.ItemsByType.Values) {
			if (item.shoeSlot > 0) {
				Shoes.Add(item.type);
			}
		}

		base.PostSetupContent();
	}

	public void RegisterShoe(int type) {
		if (!Shoes.Contains(type)) {
			Shoes.Add(type);
		}
	}
}