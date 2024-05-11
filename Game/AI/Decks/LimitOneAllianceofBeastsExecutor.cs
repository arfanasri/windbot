using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;

namespace WindBot.Game.AI.Decks
{
    [Deck("Alliance of Beasts", "AI_LimitOneAllianceofBeasts", "Master Duel")]
    public class LimitOneAllianceofBeastsExecutor : DefaultExecutor
    {
        public class CardId {
            // Effect Monster
            public const int TriBrigadeNervall = 14816857;
            public const int TriBrigadeKerass = 50810455;
            public const int TriBrigadeKitt = 56196385;
            public const int DangerJackalope = 43694650;
            public const int ZoodiacBunnyblast = 4367330;
            public const int ZoodiacRamram = 4145852;
            public const int ZoodiacRatpier = 78872731;
            public const int ZoodiacThoroughblade = 77150143;
            public const int ZoodiacWhiptail = 31755044;
            public const int ZoodiacKataroost = 20155904;
            public const int AncientWarriorsMasterfulSunMou = 40140448;
            public const int AncientWarriorsVirtuousLiuXuan = 40428851;
            public const int AncientWarriorsIngeniousZhugeKong = 32422602;
            public const int TriBrigadeFraktall = 87209160;
            public const int LaughingPuffin = 80275707;
            public const int AncientWarriorsFearsomeZhangYuan = 60033398;
            public const int AncientWarriorsLoyalGuanYun = 76416959;
            public const int OrbitalHydralander = 44009443;
            public const int DangerBigfoot = 43316238;
            public const int AncientWarriorsAmbitiousCaoDe = 33545259;
            public const int AlphatheMasterofBeasts = 73304257;
            public const int AncientWarriorsRebelliousLuFeng = 82791472;

            // Normal Spell
            public const int Raigeki = 12580477;
            public const int MonsterReborn = 83764719;
            public const int HarpiesFeatherDuster = 18144507;
            public const int PotofAvarice = 67169062;
            public const int LightningStorm = 14532163;
            public const int FoolishBurial = 81439174;

            // Field Spell
            public const int ZodiacSign = 675319;

            // Continuous Spell
            public const int ZoodiacBarrage = 46060017;
            public const int AncientWarriorsSagaThreeVisits = 11711438;
            public const int TriBrigadeStandOff = 25908748;
            public const int TriBrigadeShowdown = 7889323;

            // Quick-play Spell
            public const int Scapegoat = 73915051;
            public const int TriBrigadeAirborneAssault = 51097887;
            public const int TriBrigadeRoar = 10793085;

            // Normal Trap
            public const int InfiniteImpermanence = 10045474;
            public const int TriBrigadeOath = 86379342;
            public const int TriBrigadeRevolt = 40975243;

            // Continuous Trap
            public const int AncientWarriorsSagaChivalrousPath = 82255872;

            // Xyz Monster
            public const int NumberF0UtopicFuture = 65305468;
            public const int NumberF0UtopicDracoFuture = 26973555;
            public const int ZoodiacBoarbow = 74393852;
            public const int ZoodiacDrident = 48905153;
            public const int ZoodiacTigermortar = 11510448;
            public const int ZoodiacChakanine = 41375811;
            public const int ZoodiacHammerkong = 14970113;
            public const int DrillDriverVespenato = 39317553;
            public const int DivineArsenalAAZEUSSkyThunder = 90448279;

            // Link Monster
            public const int AncientWarriorsOathDoubleDragonLords = 65711558;
            public const int TriBrigadeFerrijittheBarrenBlossom = 26847978;
            public const int TriBrigadeBearbrummtheRampantRampager = 47163170;
            public const int HraesvelgrtheDesperateDoomEagle = 49105782;
            public const int TriBrigadeRugaltheSilverSheller = 52331012;
            public const int TriBrigadeShuraigtheOminousOmen = 99726621;
        }

        public LimitOneAllianceofBeastsExecutor(GameAI ai, Duel duel)
            : base(ai, duel) {
            AddExecutor(ExecutorType.SpSummon);
            AddExecutor(ExecutorType.Activate, DefaultDontChainMyself);
            AddExecutor(ExecutorType.SummonOrSet, DefaultMonsterSummon);
            AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
            AddExecutor(ExecutorType.SpellSet);
        }
    }
}
