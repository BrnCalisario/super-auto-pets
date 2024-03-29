namespace SuperAutoPets;

public class EffectArgs
{
    private EffectArgs empty = new EffectArgs();
    public EffectArgs Empty => empty;
}

public class SellArgs : EffectArgs
{
    public Player Owner { get; set; }
}

public class FightArgs : EffectArgs
{
    public Player Caller { get; set; }
    public Player Enemy { get; set; }

    public Pet CallerMachine { get; set; }
    public Pet EnemyMachine { get; set; }

    public FightArgs Switch()
    {
        FightArgs args = new FightArgs();

        args.Caller = this.Enemy;
        args.Enemy = this.Caller;
        
        args.CallerMachine = this.EnemyMachine;
        args.EnemyMachine = this.CallerMachine;

        return args;
    }
}

public class ShopArgs : EffectArgs
{
    public Shop Shop { get; set; }
    public Player Player { get; set; }
}