using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public bool isPortal;

	public bool isPellet;
	public bool isSuperPellet;
	
	public bool didConsumePlayerOne;
	public bool didConsumePlayerTwo;

	public bool isGhostHouse;
	public bool isGhostHouseEntrance;

	public bool isBonusItem;
	public int pointValue;

	public GameObject portalReceiver;
}
