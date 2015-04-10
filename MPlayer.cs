 using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;


namespace EcoExp
{
    public class MPlayer : ModPlayer
    {
        public override void Initialize()
        {
            base.Initialize();
        }

        public override void MidUpdate()
        {
            if (Main.tile[Player.tileTargetX, Player.tileTargetY].type == ItemDef.byName["EcoExp:Market"].createTile)
            {
                player.showItemIcon = true;
                player.showItemIcon2 = ItemDef.byName["EcoExp:Market"].type;
            }
        }
    }
}