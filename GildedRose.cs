using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        ItemsLogic itemsLogic;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            itemsLogic = new ItemsLogic();
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                doUpdateQuality(item);
            }
        }

        private void doUpdateQuality(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    itemsLogic.AgedBrie(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    itemsLogic.BackstagePass(item);
                    break;
                case "Conjured Mana Cake":
                    itemsLogic.ConjuredItem(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    break;
                default:
                    itemsLogic.NormalItem(item);
                    break;
            }
        }
    }
}
