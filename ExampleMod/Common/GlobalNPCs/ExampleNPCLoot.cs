using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using ExampleMod.Content.Items;

namespace ExampleMod.Common.GlobalNPCs
{
	// This file shows numerous examples of what you can do with the extensive NPC Loot lootable system. 
	// Despite this file being GlobalNPC, everything here can be used with a ModNPC as well! See examples of this in the Content/NPCs folder.
	public class ExampleNPCLoot : GlobalNPC
	{
		//ModifyNPCLoot uses a unique system called the ItemDropDatabase, which has many different rules for many different drop use cases.
		//Here we go through all of them, and how they can be used.
		//There are tons of other examples in vanilla! In a decompiled vanilla build, GameContent/ItemDropRules/ItemDropDatabase adds item drops to every single vanilla NPC, which can be a good resource.
		public override void ModifyNPCLoot(NPC npc, ItemDropDatabase database) {
			if ( npc.lifeMax > 5 && npc.value > 0f) { //If npc has health higher than 5 and drops money (aka is not a critter)
				database.RegisterToNPC(npc.type, ItemDropRule.Common(ModContent.ItemType<ExampleItem>(), 1)); //Make it drop ExampleItem
			}
			if (npc.type == NPCID.Guide) {
				//add more stuff here
			}
		}
	}
}
