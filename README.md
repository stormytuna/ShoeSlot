# ShoeSlot

## Mod call template

```
    public override void PostSetupContent() {
        if (ModLoader.TryGetMod("ShoeSlot", out Mod shoeSlot)) {
            shoeSlot.Call(arg1);
            // arg1 should be an int equal to the item type of the shoe/boot/foot accessory you want to register
            // For registering multiple accessories, you can either use multiple mod calls or pass an int[]
            // Please note that if your accessory has the AutoloadEquip(EquipType.Shoes) attribute you do not need to make a mod call for that accessory
        }
    }
```
