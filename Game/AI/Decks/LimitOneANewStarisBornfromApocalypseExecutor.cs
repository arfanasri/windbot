using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;

namespace WindBot.Game.AI.Decks
{
    [Deck("A New Star is Born from Apocalypse", "AI_LimitOneANewStarisBornfromApocalypse", "Master Duel")]
    public class LimitOneANewStarisBornfromApocalypseExecutor : DefaultExecutor
    {
        public class CardId {
            // Effect Monster
            public const int MannadiumFearless = 17272964;
            public const int MannadiumMeek = 44760562;
            public const int MannadiumTorrid = 80621253;
            public const int ScareclawAcro = 46877100;
            public const int ScareclawAstra = 83488497;
            public const int ScareclawBelone = 19882096;
            public const int TearlamentsHavnis = 37961969;
            public const int ScareclawReichheart = 82361809;
            public const int TearlamentsReinoheart = 73956664;
            public const int TearlamentsScheiren = 572850;
            public const int KashtiraRiseheart = 31149212;
            public const int MannadiumRiumheart = 71277255;
            public const int VisasSamsara = 14391625;
            public const int VisasStarfrost = 56099748;
            public const int KashtiraFenrir = 32909498;
            public const int ScareclawKashtira = 78534861;
            public const int TearlamentsKashtira = 4928565;
            public const int VedaKalanta = 27015862;

            // Normal Spell
            public const int MonsterReborn = 83764719;
            public const int CardDestruction = 72892473;
            public const int ReinforcementoftheArmy = 32807846;
            public const int FoolishBurialGoods = 35726888;
            public const int ClearNewWorld = 21570001;
            public const int ScareclawArrival = 83558891;
            public const int FoolishBurial = 81439174;
            public const int TearlamentsGrief = 33878367;
            public const int MannadiumAbscission = 45065541;
            public const int RealmElegy = 17462320;

            // Field Spell
            public const int PrimitivePlanetReichphobia = 56063182;
            public const int PrimevalPlanetPerlereino = 77103950;
            public const int PressuredPlanetWraitsoth = 71832012;
            public const int PeacefulPlanetCalarium = 82460246;

            // Quick-play Spell
            public const int TearlamentsHeartbeat = 60362066;

            // Normal Trap
            public const int NewWorldFormation = 58019984;
            public const int TearlamentsMetanoise = 38436986;
            public const int ScareclawTwinsaw = 95245571;
            public const int Trivikarma = 7436169;
            public const int MannadiumBreakheart = 71164684;
            public const int LokaSamsara = 2116237;

            // Continuous Trap
            public const int TearlamentsSulliek = 74920585;

            // Fusion Monster
            public const int TearlamentsKitkallos = 92731385;
            public const int TearlamentsRulkallos = 84330567;
            public const int ViciousAstraloud = 65815684;
            public const int TearlamentsKaleidoHeart = 28226490;

            // Synchro Monster
            public const int MuddyMudragon = 84040113;
            public const int MannadiumTrisukta = 21368273;
            public const int AncientFairyDragon = 25862681;
            public const int VisasAmritara = 821049;
            public const int MannadiumPrimeHeart = 90465153;

            // Xyz Monster
            public const int KashtiraShangriIra = 73542331;
            public const int KashtiraAriseHeart = 48626373;

            // Link Monster
            public const int ScareclawLightHeart = 53776969;
            public const int CrossSheep = 50277355;
            public const int BarricadeborgBlocker = 13117073;
            public const int ScareclawTriHeart = 59120809;
        }

        public LimitOneANewStarisBornfromApocalypseExecutor(GameAI ai, Duel duel)
            : base(ai, duel) {
            AddExecutor(ExecutorType.SpSummon);
            AddExecutor(ExecutorType.Activate, DefaultDontChainMyself);
            AddExecutor(ExecutorType.SummonOrSet, DefaultMonsterSummon);
            AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
            AddExecutor(ExecutorType.SpellSet);
        }
    }
}
