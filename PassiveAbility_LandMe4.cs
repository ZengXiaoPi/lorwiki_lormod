using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lorwiki_withmoresex
{
    public class PassiveAbility_LandMe4 : PassiveAbilityBase
    {
        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            BattlePlayingCardDataInUnitModel card = behavior.card;
            BattleUnitModel target = card.target;
            target.TakeDamage(4, DamageType.Passive, null, KeywordBuf.None);
        }
    }
}
