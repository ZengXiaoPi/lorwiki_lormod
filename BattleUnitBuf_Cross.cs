using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseMod;

namespace lorwiki_withmoresex
{
	public class BattleUnitBuf_Cross : BattleUnitBuf
	{
		protected override string keywordId
		{
			get
			{
				return "Cross";
			}
		}

		protected override string keywordIconId
		{
			get
			{
				return "Cross";
			}
		}

		public override bool independentBufIcon
		{
			get
			{
				return false;
			}
		}
        public void Add(int add)
		{
			this.stack += add;
		}
		public override void OnRoundEnd()
        {
			this.stack -= 3;
			if (this.stack <= 0)
			{
				this.Destroy();
			}
		}
        public override void BeforeRollDice(BattleDiceBehavior behavior)
		{
			if (this._owner != null && this._owner.passiveDetail.HasPassive<PassiveAbility_LandMe1>())
			{
				min = this.stack * 2;
				if(min >= 7)
                {
					min = 6;
                }
            }
            else
            {
				min = this.stack;
                if(min >= 4)
                {
					min = 3;
                }
            }
			behavior.ApplyDiceStatBonus(new DiceStatBonus
			{
				min = min,
			});
		}
        public override void OnSuccessAttack(BattleDiceBehavior behavior)
        {
            if(this.stack >= 10)
            {
				if (this._owner != null && this._owner.passiveDetail.HasPassive<PassiveAbility_LandMe1>())
				{
					this._owner.RecoverHP(3);
					this._owner.RecoverBreakLife(2);
                }
					this._owner.RecoverHP(3);
					this._owner.RecoverBreakLife(2);
            }
        }
        public override void AfterDiceAction(BattleDiceBehavior behavior)
        {
			if (this._owner != null && this._owner.passiveDetail.HasPassive<PassiveAbility_LandMe1>())
            {
				this._owner.RecoverHP(2);
			}

		}
        private int min;
    }
}
