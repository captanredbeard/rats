using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;

namespace rats.src.behaviors
{
    public class RatDenBlockEntityBehavior : BlockEntityBehavior
    {
        private int ratpopulation;

        private int ratsinden;

        private int foodlevel;

        private int popgrowchance;

        public RatDenBlockEntityBehavior(BlockEntity blockEntity) : base(blockEntity)
        {

        }

        
    }
}
