using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityCoreLibrary;
using RimWorld;
using Verse;

namespace Fluffy_AnimalIncest
{
    public class Injector : SpecialInjector
    {
        public override bool Inject()
        {
            // set all animalIncest flags to false on all relationdefs.
            foreach ( PawnRelationDef def in DefDatabase<PawnRelationDef>.AllDefsListForReading )
                def.incestForAnimals = false;

            return true;
        }
    }
}
