namespace GildedRoseKata;

public abstract class ItemWrapper
{
    protected readonly Item _item;

    public ItemWrapper(Item item)
    {
        _item = item;
    }

    public abstract void UpdateQuality();
}