using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
	public GameObject ui;

	public Text upgradeCost;
	public Button upgradeButton;

	public Text sellAmount;
	public Button sellButton;

	public Vector3 UIoffset;

	private NODE target;

    
    public void SetTarget(NODE _target)
	{
		target = _target;

		transform.position = target.GetBuildPosition() + UIoffset;

		if (!target.isUpgraded)
		{
			upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
			upgradeButton.interactable = true;
		}
		else
		{
			upgradeCost.text = "DONE";
			upgradeButton.interactable = false;
		}

		sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();

		ui.SetActive(true);
	}

	public void Hide()
	{
		ui.SetActive(false);
	}

	public void Upgrade()
	{
		target.UpgradeTurret();
		BuildManager.instance.DeselectNode();
	}

	public void Sell()
	{
		target.SellTurret();
		BuildManager.instance.DeselectNode();
	}

}