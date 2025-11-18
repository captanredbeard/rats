using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;

namespace rats.src.behaviors
{
    public class RatDenBlockBehavior : BlockBehavior
    {
        public RatDenBlockBehavior(Block block) : base(block)
        {

        }

        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer byPlayer, BlockSelection blockSel, ref EnumHandling handling)
        {
            return base.OnBlockInteractStart(world, byPlayer, blockSel, ref handling);
        }
    }
}
