using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseMod;

namespace lorwiki_withmoresex
{
    public class PassiveAbility_LandMe2 : PassiveAbilityBase
    {
        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            this.owner.bufListDetail.AddBufByCard<BattleUnitBuf_Cross>(1, owner, BufReadyType.ThisRound);

        }
    }
}
