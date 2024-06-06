using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        for(var i = 0; i < _items.Count; i++)
        {
            var isAgedBrie = _items[i].Name == "Aged Brie";

            if(isAgedBrie)
            {
                var agedBrie = new AgedBrie(_items[i]);
                agedBrie.UpdateQuality();
            }
            else
            {
                if(_items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if(_items[i].Quality < 50)
                    {
                        _items[i].Quality = _items[i].Quality + 1;

                        if(_items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if(_items[i].SellIn < 11)
                            {
                                if(_items[i].Quality < 50)
                                {
                                    _items[i].Quality = _items[i].Quality + 1;
                                }
                            }

                            if(_items[i].SellIn < 6)
                            {
                                if(_items[i].Quality < 50)
                                {
                                    _items[i].Quality = _items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if(_items[i].Quality > 0)
                    {
                        if(_items[i].Name == "Sulfuras, Hand of Ragnaros")
                        {
                        }
                        else
                        {
                            _items[i].Quality = _items[i].Quality - 1;
                        }
                    }
                }

                if(_items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                }
                else
                {
                    _items[i].SellIn = _items[i].SellIn - 1;
                }

                if(_items[i].SellIn < 0)
                {
                    if(_items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        _items[i].Quality = _items[i].Quality - _items[i].Quality;
                    }
                    else
                    {
                        if(_items[i].Quality > 0)
                        {
                            if(_items[i].Name == "Sulfuras, Hand of Ragnaros")
                            {
                            }
                            else
                            {
                                _items[i].Quality = _items[i].Quality - 1;
                            }
                        }
                    }
                }
            }
        }
    }
}