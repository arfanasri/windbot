using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;
using System.Linq;

namespace WindBot.Game.AI.Decks
{
    [Deck("LOCoSS", "AI_LimitOneCoalitionofSagaciousSpellcasters", "Master Duel")]
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

            AddExecutor(ExecutorType.Activate, CardId.HarpiesFeatherDuster, DefaultHarpiesFeatherDusterFirst);
            AddExecutor(ExecutorType.Activate, CardId.InfiniteImpermanence, DefaultInfiniteImpermanence);
            AddExecutor(ExecutorType.Activate, CardId.Raigeki, DefaultRaigeki);
            AddExecutor(ExecutorType.Activate, CardId.AleistertheInvoker, AAleister);
            AddExecutor(ExecutorType.Activate, CardId.FairyTailLuna, AFairyTailLuna);
            AddExecutor(ExecutorType.Activate, CardId.FairyTailSnow, AFairyTailSnow);
            AddExecutor(ExecutorType.Activate, CardId.OrbitalHydralander, AOrbitalHydralander);
            AddExecutor(ExecutorType.Activate, CardId.ChickenGame, DefaultChickenGame);
            AddExecutor(ExecutorType.Activate, CardId.FallenofAlbaz);
            AddExecutor(ExecutorType.Activate, CardId.TheGoldenSwordsoul);
            AddExecutor(ExecutorType.Activate, CardId.TitanikladtheAshDragon);
            AddExecutor(ExecutorType.Activate, CardId.BlazingCartesiatheVirtuous);
            AddExecutor(ExecutorType.Activate, CardId.TheIrisSwordsoul);
            AddExecutor(ExecutorType.Activate, CardId.GranguignoltheDuskDragon, AGranguignol);
            AddExecutor(ExecutorType.Activate, CardId.AlbiontheSanctifireDragon, AAlbion);
            AddExecutor(ExecutorType.Activate, CardId.InvokedMechaba, DefaultDontChainMyself);
            AddExecutor(ExecutorType.Activate, CardId.InvokedAugoeides, DefaultDontChainMyself);
            AddExecutor(ExecutorType.Activate, CardId.PSYFramelordOmega);

            // Combo AccesscodeTalker
            AddExecutor(ExecutorType.Activate, CardId.SeleneQueenoftheMasterMagicians);
            AddExecutor(ExecutorType.SpSummon, CardId.SeleneQueenoftheMasterMagicians);
            AddExecutor(ExecutorType.Activate, CardId.AccesscodeTalker, AAccesscodeTalker);
            AddExecutor(ExecutorType.SpSummon, CardId.AccesscodeTalker);

            // Combo Aleister
            AddExecutor(ExecutorType.Activate, CardId.Metaverse, AMetaverse);
            AddExecutor(ExecutorType.Activate, CardId.MagicalMeltdown, AMeltdown);
            AddExecutor(ExecutorType.Summon, CardId.AleistertheInvoker, SMonster);
            AddExecutor(ExecutorType.SpSummon, CardId.ArtemistheMagistusMoonMaiden, SpArtemis);
            AddExecutor(ExecutorType.Activate, CardId.Invocation, AInvocation);

            // Combo Spellbook
            AddExecutor(ExecutorType.SpSummon, CardId.HighPriestessofProphecy);
            AddExecutor(ExecutorType.Summon, CardId.SpellbookMagicianofProphecy, SMonster);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofJudgment,ASpeelbookJudgment);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofSecrets, ASpellbookSecrets);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofKnowledge, DefaultDontChainMyself);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofLife, ASpellbookLife);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookoftheMaster, ASpellbookMaster);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofPower, ASpellbookPower);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofEternity, DefaultDontChainMyself);
            AddExecutor(ExecutorType.Activate, CardId.TheGrandSpellbookTower,ASpeelbookTower);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofWisdom, DefaultDontChainMyself);
            AddExecutor(ExecutorType.Activate, CardId.SpellbookofFate, ASpeelbookFate);
            AddExecutor(ExecutorType.Activate, CardId.HighPriestessofProphecy, AHighPriest);

            // Combo Dogmatika
            AddExecutor(ExecutorType.SpSummon, CardId.DogmatikaAdintheEnlightened);
            AddExecutor(ExecutorType.Activate, CardId.DogmatikaAdintheEnlightened, ADogmaticaAdin);
            AddExecutor(ExecutorType.SpSummon, CardId.DogmatikaEcclesiatheVirtuous);
            AddExecutor(ExecutorType.Activate, CardId.DogmatikaEcclesiatheVirtuous, ADogmaticaEcclesia);
            AddExecutor(ExecutorType.SpSummon, CardId.DogmatikaTheotheIronPunch);
            AddExecutor(ExecutorType.Activate, CardId.DogmatikaTheotheIronPunch, ADogmaticaIron);
            AddExecutor(ExecutorType.SpSummon, CardId.DogmatikaFleurdelistheKnighted, ADogmaticaFleurde);
            AddExecutor(ExecutorType.Activate, CardId.DogmatikaFleurdelistheKnighted);
            AddExecutor(ExecutorType.SpSummon, CardId.DogmatikaMaximus);
            AddExecutor(ExecutorType.SpSummon, CardId.DogmatikaAshiyan);
            AddExecutor(ExecutorType.Activate, CardId.DogmatikaAshiyan, ADogmaticaAshiyan);
            AddExecutor(ExecutorType.Activate, CardId.DogmatikaPunishment, ADogmanicaPunishment);
            

            // Other Follow Up
            AddExecutor(ExecutorType.Activate, CardId.TheBookoftheLaw, ABookofLaw);
            AddExecutor(ExecutorType.Activate, CardId.NadirServant, ANadirServant);

            // Special Summon
            AddExecutor(ExecutorType.SpSummon, CardId.OrbitalHydralander);
            AddExecutor(ExecutorType.SpSummon, CardId.IncredibleEcclesiatheVirtuous);
            AddExecutor(ExecutorType.SpSummon, CardId.TheGoldenSwordsoul);
            AddExecutor(ExecutorType.SpSummon, CardId.BlazingCartesiatheVirtuous);
            AddExecutor(ExecutorType.SpSummon, CardId.TheIrisSwordsoul);
            AddExecutor(ExecutorType.SpSummon, CardId.ArtemistheMagistusMoonMaiden);
            AddExecutor(ExecutorType.SpSummon, CardId.PSYFramelordOmega);

            // Summon Monster
            AddExecutor(ExecutorType.Summon, CardId.FallenofAlbaz, SAlbaz);
            AddExecutor(ExecutorType.Summon, CardId.IncredibleEcclesiatheVirtuous,SMonster);
            AddExecutor(ExecutorType.Summon, CardId.DogmatikaTheotheIronPunch,SMonster);
            AddExecutor(ExecutorType.Summon, CardId.FairyTailLuna, SMonster);
            AddExecutor(ExecutorType.Summon, CardId.FairyTailSnow, SMonster);
            AddExecutor(ExecutorType.Summon, CardId.DogmatikaEcclesiatheVirtuous, SMonster);
            AddExecutor(ExecutorType.Summon, CardId.BlazingCartesiatheVirtuous, SMonster);

            // More Follow Up
            AddExecutor(ExecutorType.Activate, CardId.WonderWand, AWonderWand);
            AddExecutor(ExecutorType.Activate, CardId.MonsterReborn, AMonsterReborn);


            AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
            AddExecutor(ExecutorType.SpellSet, DefaultSpellSet);
        }

        bool alreadySummon = false;

        // Not Implemented yet
        bool judgementActivate = false;
        int counterJudgement = 0;

        readonly List<int> SpellbookCards = new List<int> {
            CardId.SpellbookofSecrets,
            CardId.SpellbookMagicianofProphecy,
            CardId.SpellbookofJudgment,
            CardId.SpellbookofLife,
            CardId.SpellbookofFate,
            CardId.SpellbookofKnowledge,
            CardId.SpellbookoftheMaster,
            CardId.SpellbookofPower,
            CardId.SpellbookofWisdom,
            CardId.SpellbookofEternity,
            CardId.TheGrandSpellbookTower,
        };

        readonly List<int> DogmaticaCards = new List<int> {
            CardId.DogmatikaEcclesiatheVirtuous,
            CardId.DogmatikaFleurdelistheKnighted,
            CardId.DogmatikaMaximus,
            CardId.DogmatikaTheotheIronPunch,
            CardId.DogmatikaAdintheEnlightened,
            CardId.DogmatikaAshiyan,
        };

        readonly List<int> FieldCards = new List<int> {
            CardId.MagicalMeltdown,
            CardId.TheGrandSpellbookTower,
            CardId.ChickenGame
        };

        readonly List<int> InvokedMonsters = new List<int> {
            CardId.InvokedMechaba,
            CardId.InvokedAugoeides,
            CardId.InvokedMagellanica,
            CardId.InvokedPurgatrio,
            CardId.InvokedCaliga
        };

        public override void OnNewTurn() {
            alreadySummon = false;
            base.OnNewTurn();
        }

        private bool SMonster() {
            alreadySummon = true;
            return true;
        }

        private bool AAleister() {
            // Search effect
            if (Card.Location == CardLocation.MonsterZone) {
                return true;
            }

            // Activate only in Damage Calculation
            if (Duel.Phase != DuelPhase.DamageCal) {
                return false;
            }

            ClientCard myMonster = Bot.BattlingMonster;
            if (!myMonster.HasType(CardType.Fusion)) {
                return false;
            }

            ClientCard enemyMonster = Enemy.BattlingMonster;
            if (enemyMonster != null) {
                int diff = enemyMonster.GetDefensePower() - myMonster.Attack;
                if (diff > 0 && (diff < 1000 || Bot.LifePoints - diff < 0)) {
                    AI.SelectCard(myMonster);
                    return true;
                }
            }

            if (Enemy.LifePoints - myMonster.Attack <= 1000) {
                AI.SelectCard(myMonster);
                return true;
            }

            return false;
        }

        private bool AMeltdown() {
            AI.SelectYesNo(true);
            return true;
        }

        private bool SpArtemis() {
            if (Bot.HasInMonstersZone(CardId.AleistertheInvoker)) {
                AI.SelectMaterials(CardId.AleistertheInvoker);
                return true;
            }
            return false;
        }

        private bool AInvocation() {
            // Shuffle
            if(Card.Location == CardLocation.Grave) {
                return true;
            }

            IList<ClientCard> enemyLights = Enemy.Graveyard.GetMatchingCards(card => card.HasAttribute(CardAttribute.Light));
            if (enemyLights.Count > 0) {
                AI.SelectCard(CardId.InvokedMechaba);
                AI.SelectMaterials(enemyLights);
                return true;
            }

            if (Bot.HasInMonstersZoneOrInGraveyard(CardId.ArtemistheMagistusMoonMaiden)) {
                AI.SelectCard(CardId.InvokedMechaba);
                AI.SelectMaterials(CardId.ArtemistheMagistusMoonMaiden);
                return true;
            }

            IList<ClientCard> enemyFusion = Enemy.Graveyard.GetMatchingCards(card => card.HasType(CardType.Fusion));
            if (enemyFusion.Count > 0) {
                AI.SelectCard(CardId.InvokedAugoeides);
                AI.SelectMaterials(enemyFusion);
                return true;
            }

            if (Bot.Graveyard.GetMatchingCardsCount(card => card.HasAttribute(CardAttribute.Light)) > 0) {
                AI.SelectCard(CardId.InvokedMechaba);
                return true;
            }

            IList<ClientCard> enemyDarks = Enemy.Graveyard.GetMatchingCards(card => card.HasAttribute(CardAttribute.Dark));
            if (enemyDarks.Count > 0) {
                AI.SelectCard(CardId.InvokedCaliga);
                AI.SelectMaterials(enemyDarks);
                return true;
            }

            IList<ClientCard> enemyFires = Enemy.Graveyard.GetMatchingCards(card => card.HasAttribute(CardAttribute.Dark));
            if (enemyFires.Count > 0) {
                AI.SelectCard(CardId.InvokedPurgatrio);
                AI.SelectMaterials(enemyFires);
                return true;
            }

            IList<ClientCard> enemyEarths = Enemy.Graveyard.GetMatchingCards(card => card.HasAttribute(CardAttribute.Dark));
            if (enemyEarths.Count > 0) {
                AI.SelectCard(CardId.InvokedMagellanica);
                AI.SelectMaterials(enemyEarths);
                return true;
            }

            return false;
        }

        private bool ASpellbookSecrets() {
            if (alreadySummon) {
                // Have Other Spellbook
                if (Bot.HasInHand(SpellbookCards)) {
                    AI.SelectCard(SpellbookCards);
                    return true;
                }
            } else {
                AI.SelectCard(CardId.SpellbookMagicianofProphecy);
                return true;
            }
            return false;
        }

        private bool ASpellbookPower() {
            ClientCard bestSpellcaster = Bot.MonsterZone.GetMonsters().Where(card => card.HasRace(CardRace.SpellCaster)).OrderBy(card => card.Attack).LastOrDefault();
            if(bestSpellcaster != null) {
                AI.SelectCard(bestSpellcaster);
                return true;
            }
            return false;
        }

        private bool ASpellbookMaster() {
            if (Bot.HasInGraveyard(CardId.SpellbookofSecrets)) {
                AI.SelectCard(CardId.SpellbookofSecrets);
            }
            return true;
        }

        private bool ASpellbookLife() {
            int[] bestSummon = new int[] {
                CardId.BlazingCartesiatheVirtuous,
                CardId.DogmatikaEcclesiatheVirtuous,
                CardId.FairyTailLuna,
                CardId.FairyTailSnow,
            };
            int banyakKartu = Bot.Graveyard.GetMatchingCardsCount(card => card.IsCode(bestSummon));
            if (banyakKartu > 0) {
                IList<ClientCard> notBestSummon = Bot.Graveyard.GetMatchingCards(card => !card.IsCode(bestSummon));
                if (notBestSummon.Count > 0) {
                    AI.SelectCard(notBestSummon);
                } else {
                    if ( banyakKartu >= 2) {
                        AI.SelectCard(bestSummon);
                    } else {
                        return false;
                    }
                }
            }

            AI.SelectNextCard(bestSummon);

            return true;
        }

        private bool ASpeelbookTower() {
            // Draw and Return
            if(Duel.Phase == DuelPhase.Standby) {
                AI.SelectCard(SpellbookCards);
            }
            if(Card.Location == CardLocation.Grave) {
                AI.SelectCard(
                    CardId.DogmatikaEcclesiatheVirtuous,
                    CardId.FairyTailLuna,
                    CardId.FairyTailSnow,
                    CardId.BlazingCartesiatheVirtuous,
                    CardId.SpellbookMagicianofProphecy);
            }
            
            return false;
        }

        private bool ASpeelbookFate() {
            int spellbookInGy = Bot.Graveyard.GetMatchingCardsCount(card => card.IsCode(SpellbookCards));
            if(spellbookInGy == 1) {
                AI.SelectCard(Util.GetBestEnemySpell());
                return true;
            } else if (spellbookInGy > 1) {
                AI.SelectCard(Util.GetBestEnemyMonster());
                return true;
            }
            return false;
        }

        private bool ASpeelbookJudgment() {
            if(Duel.Phase == DuelPhase.End) {
                AI.SelectCard(SpellbookCards);
                if(counterJudgement >= 4) {
                    AI.SelectNextCard(CardId.DogmatikaEcclesiatheVirtuous, CardId.FairyTailLuna);
                } else {
                    AI.SelectNextCard(CardId.SpellbookMagicianofProphecy);
                }
            }
            if(Duel.Player == 0) {
                judgementActivate = true;
                return true;
            }
            return false;
        }

        private bool AHighPriest() {
            if (Util.IsOneEnemyBetter()) {
                List<int> worstSpellbook = SpellbookCards;
                worstSpellbook.Reverse();
                AI.SelectCard(worstSpellbook);
                AI.SelectNextCard(Util.GetBestEnemyMonster());
                return true;
            }
            return false;
        }

        private bool AMetaverse() {
            AI.SelectCard(FieldCards);
            return true;
        }

        private bool ABookofLaw() {
            if(Enemy.MonsterZone.GetMonsters().Count == 0) {
                ClientCard tributedCard = Bot.MonsterZone.GetFirstMatchingFaceupCard(card=>card.IsCode(InvokedMonsters));
                ClientCard summonedCard = Bot.ExtraDeck.GetMatchingCards(card => card.IsCode(InvokedMonsters) && card.Attribute != tributedCard.Attribute).OrderBy(card => card.Attack).LastOrDefault();
                if(Enemy.LifePoints <= summonedCard.Attack) {
                    AI.SelectCard(tributedCard);
                    AI.SelectNextCard(summonedCard);
                    return true;
                }
            }
            return false;
        }

        private bool AFairyTailLuna() {
            if(Enemy.GetMonsterCount() > 0) {
                AI.SelectCard(Util.GetBestEnemyMonster());
            }
            return true;
        }

        private bool AFairyTailSnow() {
            if(Card.Location == CardLocation.MonsterZone) {
                AI.SelectCard(Util.GetBestEnemyMonster());
                return true;
            }
            return false;
        }

        private bool AOrbitalHydralander() {
            if(Util.GetBestEnemyCard() != null) {
                AI.SelectCard(Util.GetBestEnemyCard());
                return true;
            }
            return false;
        }

        private bool AWonderWand() {
            if(Card.Location == CardLocation.Hand) {
                ClientCard myBest = Bot.MonsterZone.GetMonsters().GetMatchingCards(card => card.HasRace(CardRace.SpellCaster)).OrderBy(card => card.Attack).LastOrDefault();
                ClientCard enemyBest = Util.GetBestEnemyMonster();
                if (Util.IsOneEnemyBetter() && myBest.Attack + 500 > enemyBest.GetDefensePower()) {
                    AI.SelectCard(myBest);
                    return true;
                } else {
                    ClientCard myWorst = Bot.MonsterZone.GetMonsters().GetMatchingCards(card => card.HasRace(CardRace.SpellCaster)).OrderBy(card => card.Attack).FirstOrDefault();
                    AI.SelectCard(myWorst);
                    return true;
                }
            }

            if(Card.Location == CardLocation.SpellZone) {
                ClientCard target = Card.EquipTarget;
                if(Enemy.GetMonsterCount() == 0) {
                    return true;
                }

                ClientCard enemyBest = Util.GetBestEnemyMonster();
                ClientCard myBest = Util.GetBestBotMonster();
                if (myBest.Id != target.Id) {
                    return true;
                }

                if (Util.IsAllEnemyBetterThanValue(target.Attack, true)) {
                    return true;
                }
            }
            return false;
        }

        private bool AMonsterReborn() {
            int[] monster = new int[] {
                CardId.DogmatikaEcclesiatheVirtuous,
                CardId.FairyTailLuna
            };
            if (Bot.HasInGraveyard(monster)) {
                AI.SelectCard(monster);
                return true;
            }
            return false;
        }

        private bool ADogmaticaAdin() {
            if(Card.Location == CardLocation.Hand) {
                return true;
            }
            AI.SelectCard(DogmaticaCards);
            return true;
        }

        private bool ADogmaticaEcclesia() {
            if (Card.Location == CardLocation.Hand) {
                return true;
            }
            AI.SelectCard(DogmaticaCards);
            return true;
        }

        private bool ADogmaticaIron() {
            if (Card.Location == CardLocation.Hand) {
                return true;
            }
            ClientCard enemyExtra = Enemy.MonsterZone.GetMonsters().GetMatchingCards(card => card.HasType(CardType.Fusion) || card.HasType(CardType.Synchro) || card.HasType(CardType.Xyz) || card.HasType(CardType.Link)).OrderBy(card => card.Attack).LastOrDefault();
            if(enemyExtra != null) {
                AI.SelectCard(enemyExtra);
                return true;
            }
            return false;
        }

        private bool SAlbaz() {
            if(Enemy.MonsterZone.GetMatchingCardsCount(card=>(card.HasRace(CardRace.SpellCaster) && card.HasAttribute(CardAttribute.Light) || card.Attack >= 2500)) > 0) {
                return true;
            }
            return false;
        }

        private bool ADogmaticaFleurde() {
            AI.SelectCard(Util.GetBestEnemyMonster());
            return true;
        }

        private bool ADogmaticaAshiyan() {
            AI.SelectCard(DogmaticaCards);
            return true;
        }

        private bool ANadirServant() {
            int[] selectCard = new int[] {
                CardId.TitanikladtheAshDragon,
                CardId.AlbiontheSanctifireDragon,
                CardId.GranguignoltheDuskDragon,
                CardId.AleistertheInvokerofMadness,
            };

            if(Bot.ExtraDeck.GetMatchingCardsCount(card=>card.IsCode(selectCard)) > 0) {
                AI.SelectCard(selectCard);
                return true;
            }

            return false;
        }

        private bool ADogmanicaPunishment() {
            if (Util.IsOneEnemyBetter()) {
                AI.SelectCard(Util.GetBestEnemyMonster());
                AI.SelectNextCard(
                    CardId.TitanikladtheAshDragon,
                    CardId.AlbiontheSanctifireDragon,
                    CardId.GranguignoltheDuskDragon);
                return true;
            }
            return false;
        }

        private bool AGranguignol() {
            AI.SelectCard(
                CardId.TitanikladtheAshDragon,
                CardId.AlbiontheSanctifireDragon,
                CardId.GranguignoltheDuskDragon);
            return true;
        }

        private bool AAlbion() {
            if(Card.Location != CardLocation.Grave) {
                return true;
            }
            return false;
        }

        private bool AAccesscodeTalker() {
            if(Bot.Graveyard.GetMatchingCardsCount(card=>card.HasType(CardType.Link)) > 0) {
                return true;
            }
            return false;
        }
    }
}
