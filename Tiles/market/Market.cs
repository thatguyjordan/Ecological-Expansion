using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using TAPI.UIKit;
using Terraria;

namespace EcoExp
{
    [GlobalMod]
    public class Market : TAPI.ModTileType
    {
        public override bool RightClick(int x, int y)
        {
            if (Main.tile[x, y].type == ItemDef.byName["EcoExp:Market"].createTile)
            {
                new TradingInterface(modBase).SetPosition(x, y).Open(new InterfaceAnchor(x, y));
                return true;
            }
            return false;
        }
    }

    public class TradingInterface : Interface
    {
        int startPx = 310;
        int startPy = 330;
        public const int OwnerItem = 0;
        public const int TradePrice = 1;
        public const int TradedItem = 2;
        public const int OwnerItem2 = 3;
        public const int TradePrice2 = 4;
        public const int TradedItem2 = 5;
        public const int OwnerItem3 = 6;
        public const int TradePrice3 = 7;
        public const int TradedItem3 = 8;
        public const int OwnerItem4 = 9;
        public const int TradePrice4 = 10;
        public const int TradedItem4 = 11;
        public const int OwnerItem5 = 12;
        public const int TradePrice5 = 13;
        public const int TradedItem5 = 14;
        public const int OwnerItem6 = 15;
        public const int TradePrice6 = 16;
        public const int TradedItem6 = 17;
        public const int OwnerItem7 = 18;
        public const int TradePrice7 = 19;
        public const int TradedItem7 = 20;
        public ModBase modBase;
        public Item[] item = new Item[21];
        public MarketSlot[] itemSlot = new MarketSlot[21];
        public Vector2 position;

        #region inialization stuff
        public TradingInterface(ModBase modBase) : base()
        {
            for (int i = 0; i < item.Length; i++) { item[i] = new Item(); }

            this.modBase = modBase;

            itemSlot[OwnerItem] = new MarketSlot(this.modBase, OwnerItem, OwnerItem, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradePrice] = new MarketSlot(this.modBase, TradePrice, TradePrice, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradedItem] = new MarketSlot(this.modBase, TradedItem, TradedItem, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[OwnerItem2] = new MarketSlot(this.modBase, OwnerItem2, OwnerItem2, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradePrice2] = new MarketSlot(this.modBase, TradePrice2, TradePrice2, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradedItem2] = new MarketSlot(this.modBase, TradedItem2, TradedItem2, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);
            
            itemSlot[OwnerItem3] = new MarketSlot(this.modBase, OwnerItem3, OwnerItem3, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradePrice3] = new MarketSlot(this.modBase, TradePrice3, TradePrice3, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradedItem3] = new MarketSlot(this.modBase, TradedItem3, TradedItem3, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[OwnerItem4] = new MarketSlot(this.modBase, OwnerItem4, OwnerItem4, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradePrice4] = new MarketSlot(this.modBase, TradePrice4, TradePrice4, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradedItem4] = new MarketSlot(this.modBase, TradedItem4, TradedItem4, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[OwnerItem5] = new MarketSlot(this.modBase, OwnerItem5, OwnerItem5, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradePrice5] = new MarketSlot(this.modBase, TradePrice5, TradePrice5, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradedItem5] = new MarketSlot(this.modBase, TradedItem5, TradedItem5, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[OwnerItem6] = new MarketSlot(this.modBase, OwnerItem6, OwnerItem6, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradePrice6] = new MarketSlot(this.modBase, TradePrice6, TradePrice6, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradedItem6] = new MarketSlot(this.modBase, TradedItem6, TradedItem6, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[OwnerItem7] = new MarketSlot(this.modBase, OwnerItem7, OwnerItem7, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradePrice7] = new MarketSlot(this.modBase, TradePrice7, TradePrice7, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);

            itemSlot[TradedItem7] = new MarketSlot(this.modBase, TradedItem7, TradedItem7, delegate(ItemSlot slot, Item item)
            { this.item[((MarketSlot)slot).customIndex] = item; }, (ItemSlot slot) => this.item[((MarketSlot)slot).customIndex], this);
        }

        public override void Draw(InterfaceLayer layer, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            Main.inventoryScale = 0.85f;

            Drawing.DrawBox(sb, startPx - 235, startPy + 39, 415, 160); //h was 130

            sb.DrawString(Main.fontMouseText, "", new Vector2(startPx + 89, startPy + 3), Color.White);
            sb.DrawString(Main.fontMouseText, "", new Vector2(startPx + 53, startPy + 55), Color.White);
            sb.DrawString(Main.fontMouseText, "", new Vector2(startPx + 113, startPy + 55), Color.White);
            sb.DrawString(Main.fontMouseText, "", new Vector2(startPx + 12, startPy + 27), Color.White);
            sb.DrawString(Main.fontMouseText, "", new Vector2(startPx + 68, startPy + 27), Color.White);
            sb.DrawString(Main.fontMouseText, "", new Vector2(startPx + 127, startPy + 27), Color.White);

            itemSlot[0].UpdateAndDraw(sb, new Vector2(startPx - 223, startPy + 47), Main.inventoryScale);
            itemSlot[1].UpdateAndDraw(sb, new Vector2(startPx - 223, startPy + 97), Main.inventoryScale);
            itemSlot[2].UpdateAndDraw(sb, new Vector2(startPx - 223, startPy + 147), Main.inventoryScale);
            itemSlot[3].UpdateAndDraw(sb, new Vector2(startPx - 165, startPy + 47), Main.inventoryScale);
            itemSlot[4].UpdateAndDraw(sb, new Vector2(startPx - 165, startPy + 97), Main.inventoryScale);
            itemSlot[5].UpdateAndDraw(sb, new Vector2(startPx - 165, startPy + 147), Main.inventoryScale);
            itemSlot[6].UpdateAndDraw(sb, new Vector2(startPx - 107, startPy + 47), Main.inventoryScale);
            itemSlot[7].UpdateAndDraw(sb, new Vector2(startPx - 107, startPy + 97), Main.inventoryScale);
            itemSlot[8].UpdateAndDraw(sb, new Vector2(startPx - 107, startPy + 147), Main.inventoryScale);
            itemSlot[9].UpdateAndDraw(sb, new Vector2(startPx - 49, startPy + 47), Main.inventoryScale);
            itemSlot[10].UpdateAndDraw(sb, new Vector2(startPx - 49, startPy + 97), Main.inventoryScale);
            itemSlot[11].UpdateAndDraw(sb, new Vector2(startPx - 49, startPy + 147), Main.inventoryScale);
            itemSlot[12].UpdateAndDraw(sb, new Vector2(startPx + 9, startPy + 47), Main.inventoryScale);
            itemSlot[13].UpdateAndDraw(sb, new Vector2(startPx + 9, startPy + 97), Main.inventoryScale);
            itemSlot[14].UpdateAndDraw(sb, new Vector2(startPx + 9, startPy + 147), Main.inventoryScale);
            itemSlot[15].UpdateAndDraw(sb, new Vector2(startPx + 67, startPy + 47), Main.inventoryScale);
            itemSlot[16].UpdateAndDraw(sb, new Vector2(startPx + 67, startPy + 97), Main.inventoryScale);
            itemSlot[17].UpdateAndDraw(sb, new Vector2(startPx + 67, startPy + 147), Main.inventoryScale);
            itemSlot[18].UpdateAndDraw(sb, new Vector2(startPx + 125, startPy + 47), Main.inventoryScale);
            itemSlot[19].UpdateAndDraw(sb, new Vector2(startPx + 125, startPy + 97), Main.inventoryScale);
            itemSlot[20].UpdateAndDraw(sb, new Vector2(startPx + 125, startPy + 147), Main.inventoryScale);
        }

        public override void OnClose()
        {
            foreach (MarketSlot slot in itemSlot)
            {
                if (slot.index == TradedItem || slot.index == TradedItem2 || slot.index == TradedItem3 || slot.index == TradedItem4 || slot.index == TradedItem5 || slot.index == TradedItem || slot.index == TradedItem7) continue;
                 if (slot.MyItem.stack < 1) continue;
                 Item i = slot.MyItem;
                 Item.NewItem((int)position.X, (int)position.Y, i.width, i.height, i.type, i.stack);
            }
        }

        public TradingInterface SetPosition(int x, int y)
        {
            position = new Vector2(x * 18, y * 16);
            return this;
        }
        #endregion
    }

    public class MarketSlot : ItemSlot
    {
        public static int FoodType = -1;

        #region Boring stuff

        public const int TradePrice = 1;
        TradingInterface GI;
        private int slotIndex;
        public int customIndex;
        public MarketSlot(ModBase modBase, int index, int cIndex, Action<ItemSlot, Item> ActionSet,
            Func<ItemSlot, Item> ActionGet, TradingInterface si)
            : base(modBase, "Slot", index, ActionSet, ActionGet)
        {
            this.slotIndex = index;
            this.customIndex = cIndex;
            this.GI = si;
        }
        //(player.armor[0].name.Contains("Exo Headgear") && player.armor[1].name.Contains("Exo Chestplate") && player.armor[2].name.Contains("Exo Greaves") && player.inventory[player.selectedItem].name.Contains("Exo Minigun"))
        //itemSlot[5].UpdateAndDraw(sb, new Vector2(startPx - 165, startPy + 147), Main.inventoryScale);

/*        public Item ItemInSlot(MarketSlot[] itemSlot)
        {
            Item item = itemSlot.ToString();
            return item;
        }*/

        public override bool AllowsItem(Item item)
        {
            if (item.IsBlank()) return true; //Eventually this will be changed so that only the tradeditem is the available to place. The other two will only be able to be accessed by owner of the tile. Only owner can break as well
            //if (slotIndex == TradingInterface.TradePrice) return true;
            //if (slotIndex == TradingInterface.TradedItem && Item.isTheSameAs(ItemInSlot(itemSlot[1]))) return true; //Item.IsTheSameAs() Check to see if the item in tradeditem is the same as the item in tradeprice. Also check to see if they correct number, or more has been placed, otherwise no trade.
            else return false;
        }

        public override void DrawItemSlotBackground(SpriteBatch sb, Vector2 offset)
        {
            Main.inventoryScale = 0.85f;

            pos = position + offset;
            if (Hooks.Interface.PreDrawItemSlotBackground(sb, this))
            {
                Texture2D tradeblank = Main.inventoryBackTexture;
                Texture2D tradeavailable = Main.inventoryBack3Texture;
                if (!this.MyItem.IsBlank())
                {
                    sb.Draw(tradeavailable, pos, null, Main.inventoryBack * alpha, 0f, default(Vector2), scale, SpriteEffects.None, 0f);
                }
                else
                {
                    sb.Draw(tradeblank, pos, null, Main.inventoryBack * alpha, 0f, default(Vector2), scale, SpriteEffects.None, 0f);
                }
            }
            Hooks.Interface.PostDrawItemSlotBackground(sb, this);
        }
        #endregion
    }
}