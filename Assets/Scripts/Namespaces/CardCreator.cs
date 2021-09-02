using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardCreator
{
	static class InstantiateCard
	{
		public static void InitializeCard(Card card)
		{
			if (card.actionData != null)
			{
				card.title = card.actionData.title;
				card.ID = card.actionData.ID;
				card.energyCost = card.actionData.energyCost;
				card.description = card.actionData.description;
				card.image.texture = card.actionData.image;

				card.gameObject.name = card.title;
				card.healthPointsDisplay.SetActive(false);
				card.damageAmountDisplay.SetActive(false);

				card.creatureData = null;
			}
			else if (card.creatureData)
			{
				card.title = card.creatureData.title;
				card.ID = card.creatureData.ID;
				card.healthPoints = card.creatureData.healthPoints + card.healthPointModifier;
				card.damageAmount = card.creatureData.damageAmount + card.damageAmountModifier;
				card.description = card.creatureData.description;
				card.image.texture = card.creatureData.image;
                
				card.gameObject.name = card.title;
				card.healthPointsDisplay.SetActive(true);
				card.damageAmountDisplay.SetActive(true);
			}
		}
	}
}