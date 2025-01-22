using UnityEngine;

public class BubbleTea
{
    public bool hasCup { get; private set; }
    public bool hasBase { get; private set; }
    public bool hasSyrup { get; private set; }
    public bool hasBubble { get; private set; }

    public CupType cup { get; private set; }
    public BaseType baseType { get; private set; }
    public SyrupType syrup { get; private set; }
    public BubbleType bubble { get; private set; }

    public BubbleTea(CupType cup)
    {
        this.cup = cup;
        hasCup = true;
        hasBase = false;
        hasSyrup = false;
        hasBubble = false;
        baseType = BaseType.Null;
        syrup = SyrupType.Null;
        bubble = BubbleType.Null;
    }

    public void AddBase(BaseType baseType)
    {
        this.baseType = baseType;
        hasBase = true;
    }

    public void AddSyrup(SyrupType syrup)
    {
        this.syrup = syrup;
        hasSyrup = true;
    }

    public void AddBubble(BubbleType bubble)
    {
        this.bubble = bubble;
        hasBubble = true;
    }
}
