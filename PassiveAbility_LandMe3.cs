using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lorwiki_withmoresex
{
    public class PassiveAbility_LandMe3 : PassiveAbilityBase
    {
        public override bool IsImmune(KeywordBuf buf)
        {
            return buf == KeywordBuf.Weak || buf == KeywordBuf.Disarm || buf == KeywordBuf.Binding || buf == KeywordBuf.Paralysis || base.IsImmune(buf);
        }
    }
}
