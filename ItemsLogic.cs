using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    class ItemsLogic
    {
        public void AgedBrie(Item item)
        {
            SellInDecrease(item);
            IncreaseQuality(item);

            if (item.SellIn < 0) { IncreaseQuality(item); }
        }

        public void BackstagePass(Item item)
        {
            SellInDecrease(item);
            IncreaseQuality(item);

            if (item.SellIn < 11) { IncreaseQuality(item); }

            if (item.SellIn < 6) { IncreaseQuality(item); }

            if (item.SellIn < 0) { item.Quality = item.Quality - item.Quality; }
        }

        public void ConjuredItem(Item item)
        {
            SellInDecrease(item);
            DecreaseConjuredQuality(item);

            if (item.SellIn < 0)
            {
                DecreaseConjuredQuality(item);
            }
        }

        public void NormalItem(Item item)
        {
            SellInDecrease(item);
            DecreaseQuality(item);

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }

        public void IncreaseQuality(Item item)
        {
            if (item.Quality < 50) {
                item.Quality = item.Quality + 1; 
            }
        }

        public void DecreaseQuality(Item item)
        {
            if (item.Quality > 0) { 
                item.Quality = item.Quality - 1; 
            }
        }

        public void DecreaseConjuredQuality(Item item)
        {
            if (item.Quality > 0) {
                item.Quality = item.Quality - 2; 
            }
        }
        public void SellInDecrease(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}
