using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace PopsMods
{
    public class GlobalNPCDrops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            // Check if this is an Undead Miner
            if (npc.type == NPCID.UndeadMiner)
            {
                // 100% chance to drop one Miner's Sack
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MinersSack>(), 1));
                
                // 25% chance to drop a second Miner's Sack
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MinersSack>(), 4));
            }
            else
            {
                // 1% chance for all other mobs to drop Miner's Sack
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MinersSack>(), 50));
            }
        }
    }
}