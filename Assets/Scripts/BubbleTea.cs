using UnityEngine;

public class BubbleTea
{
    bool hasBase = false;
    bool hasSyrup = false;
    bool hasBubble = false;

    CupType cup = CupType.Null;
    BaseType baseType = BaseType.Null;
    SyrupType syrup = SyrupType.Null;
    BubbleType bubble = BubbleType.Null;

    public BubbleTea(CupType cup)
    {
        this.cup = cup;
    }
}
