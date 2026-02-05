using Vintagestory.API.Common;

namespace LitGroundStorageLib;

public class LitGroundStorageLibModSystem : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        base.Start(api);

        api.RegisterBlockClass("LitBlockGroundStorage", typeof(LitBlockGroundStorage));
        api.RegisterBlockEntityClass("LitBlockEntityGroundStorage", typeof(LitBlockEntityGroundStorage));
    }

}
