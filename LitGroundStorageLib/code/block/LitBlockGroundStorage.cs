using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace LitGroundStorageLib;

public class LitBlockGroundStorage : BlockGroundStorage
{

    public override byte[] GetLightHsv(IBlockAccessor blockAccessor, BlockPos pos, ItemStack stack = null)
    {
        BlockEntityGroundStorage? beg = blockAccessor.GetBlockEntity(pos) as BlockEntityGroundStorage;
        if (beg == null)
        {
            return base.GetLightHsv(blockAccessor, pos, stack);
        }

        ItemStack itemstack = beg.Inventory[0].Itemstack;
        if (itemstack == null)
        {
            return base.GetLightHsv(blockAccessor, pos, stack);
        }

        return itemstack.Collectible.LightHsv;
    }


}
