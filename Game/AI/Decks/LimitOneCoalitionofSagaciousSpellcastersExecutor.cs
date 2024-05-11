using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;

namespace WindBot.Game.AI.Decks
{
    [Deck("Coalition of Sagacious Spellcasters", "AI_LimitOneCoalitionofSagaciousSpellcasters", "Master Duel")]
    public class LimitOneCoalitionofSagaciousSpellcastersExecutor : DefaultExecutor
    {
        public class CardId {
            // Effect Monster
            public const int SpellbookMagicianofProphecy = 14824019;
            public const int FairyTailSnow = 55623480;
            public const int AleistertheInvoker = 86120751;
            public const int FairyTailLuna = 86937530;
            public const int DogmatikaAdintheEnlightened = 33296432;
            public const int DogmatikaEcclesiatheVirtuous = 60303688;
            public const int DogmatikaTheotheIronPunch = 96891787;
            public const int FallenofAlbaz = 68468459;
            public const int IncredibleEcclesiatheVirtuous = 55273560;
            public const int TheGoldenSwordsoul = 82489470;
            public const int BlazingCartesiatheVirtuous = 95515789;
            public const int HighPriestessofProphecy = 86585274;
            public const int OrbitalHydralander = 44009443;
            public const int DogmatikaFleurdelistheKnighted = 69680031;
            public const int DogmatikaMaximus = 95679145;
            public const int DogmatikaAshiyan = 13694209;
            public const int TheIrisSwordsoul = 62849088;

            // Normal Spell
            public const int Raigeki = 12580477;
            public const int MonsterReborn = 83764719;
            public const int HarpiesFeatherDuster = 18144507;
            public const int SpellbookofPower = 25123082;
            public const int SpellbookofSecrets = 89739383;
            public const int SpellbookofEternity = 61592395;
            public const int SpellbookoftheMaster = 56981417;
            public const int Invocation = 74063034;
            public const int SpellbookofKnowledge = 23314220;

            // Equip Spell
            public const int NadirServant = 1984618;
            public const int WonderWand = 67775894;
            public const int SpellbookofLife = 52628687;

            // Field Spell
            public const int TheGrandSpellbookTower = 33981008;
            public const int ChickenGame = 67616300;
            public const int MagicalMeltdown = 47679935;

            // Quick-Play Spell
            public const int SuperPolymerization = 48130397;
            public const int SpellbookofWisdom = 88616795;
            public const int SpellbookofFate = 97997309;
            public const int SpellbookofJudgment = 46448938;
            public const int TheBookoftheLaw = 458748;

            // Trap
            public const int Metaverse = 89208725;
            public const int InfiniteImpermanence = 10045474;
            public const int DogmatikaPunishment = 82956214;

            // Fusion Monster
            public const int InvokedCaliga = 13529466;
            public const int InvokedPurgatrio = 12307878;
            public const int InvokedMagellanica = 48791583;
            public const int InvokedAugoeides = 97300502;
            public const int TitanikladtheAshDragon = 41373230;
            public const int GranguignoltheDuskDragon = 24915933;
            public const int AlbiontheSanctifireDragon = 38811586;
            public const int InvokedMechaba = 75286621;

            // Synchro Monster
            public const int PSYFramelordOmega = 74586817;
            public const int DespianLuluwalilith = 53971455;

            // Link Monster
            public const int SalamangreatAlmiraj = 60303245;
            public const int ArtemistheMagistusMoonMaiden = 34755994;
            public const int AleistertheInvokerofMadness = 97973962;
            public const int SeleneQueenoftheMasterMagicians = 45819647;
            public const int AccesscodeTalker = 86066372;
        }

        public LimitOneCoalitionofSagaciousSpellcastersExecutor(GameAI ai, Duel duel)
            : base(ai, duel) {
            AddExecutor(ExecutorType.SpSummon);
            AddExecutor(ExecutorType.Activate, DefaultDontChainMyself);
            AddExecutor(ExecutorType.SummonOrSet, DefaultMonsterSummon);
            AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
            AddExecutor(ExecutorType.SpellSet);
        }
    }
}
