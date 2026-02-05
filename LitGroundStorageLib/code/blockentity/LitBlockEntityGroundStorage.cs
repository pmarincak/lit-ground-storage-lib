using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace LitGroundStorageLib;

public class LitBlockEntityGroundStorage : BlockEntityGroundStorage
{
    byte[] lightHSV = [0,0,0];

    public override void Initialize(ICoreAPI api)
    {
        base.Initialize(api);

        if (!inventory.Empty)
        {
            lightHSV = Block.GetLightHsv(Api.World.BlockAccessor, Pos);
        }
    }

    public override bool OnPlayerInteractStart(IPlayer player, BlockSelection bs)
    {
        var result = base.OnPlayerInteractStart(player, bs);

        if (!inventory.Empty)
        {
            lightHSV = Block.GetLightHsv(Api.World.BlockAccessor, Pos);
        }
        else
        {
            Api.World.BlockAccessor.RemoveBlockLight(lightHSV, Pos);
        }
        
        return result;
    }


    public override void OnBlockBroken(IPlayer byPlayer = null)
    {
        base.OnBlockBroken(byPlayer);

        Api.World.BlockAccessor.RemoveBlockLight(lightHSV, Pos);
    }

}
