namespace GildedRoseKata;

public class AgedBrie : ItemWrapper
{
    public AgedBrie(Item item) : base(item)
    {
    }

    public override void UpdateQuality()
    {
        if (_item.Quality < 50)
        {
            _item.Quality += 1;
        }

        _item.SellIn -= 1;

        if (_item.SellIn < 0)
        {
            if (_item.Quality < 50)
            {
                _item.Quality += 1;
            }
        }
    }
}