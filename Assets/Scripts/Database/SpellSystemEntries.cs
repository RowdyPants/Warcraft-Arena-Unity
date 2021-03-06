﻿public class TrinitySpellEffectInfoEntry
{
    public int Id { get; set; }

    public SpellEffectType Effect { get; set; }
    public AuraType AuraType { get; set; }
    public int ApplyAuraPeriod { get; set; }
    public int DieSides { get; set; }

    public TargetTypes TargetA { get; set; }
    public TargetTypes TargetB { get; set; }

    public int BasePoints { get; set; }
    public float PointsPerResource { get; set; }
    public float Amplitude { get; set; }
    public float ChainAmplitude { get; set; }
    public float BonusCoefficient { get; set; }

    public int MiscValue { get; set; }
    public int MiscValueB { get; set; }
    public Mechanics Mechanic { get; set; }

    public float PositionFacing { get; set; }
    public int RadiusEntryId { get; set; }

    public int TriggerSpell { get; set; }
    public float BonusCoefficientFromAP { get; set; }
}