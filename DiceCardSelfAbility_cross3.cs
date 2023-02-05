using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseMod;

namespace lorwiki_withmoresex
{
    public class DiceCardSelfAbility_cross3 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            this.owner.bufListDetail.AddBufByCard<BattleUnitBuf_Cross>(3, owner, BufReadyType.ThisRound);
        }
        public static string Desc = "[使用时]使自身获得3层[十字]";
    }
}
