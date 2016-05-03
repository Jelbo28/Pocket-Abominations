using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class NextArrow : MonoBehaviour 
{
	private Text textComponent;

	public string[] DialogueStrings;

	public float SecondsBetweenCharacters = 0.15f;
	public float CharacterRateMultiplier = 0.5f;

	public KeyCode DialogueInput = KeyCode.Return;

	private bool isStringBeingRevealed = false;

	void Start()
	{
		textComponent = GetComponent<Text>();
		textComponent.text = "";
	}

	void Update()
	{
		if(Input.GetKeyDown (KeyCode.Return))
		{
			if(isStringBeingRevealed)
			{
				isStringBeingRevealed = true;
			
				StartCoroutine(DisplayString(DialogueStrings[0]));
			}
		}
	}

	private IEnumerator DisplayString(string stringToDisplay)
	{
		int stringLength = stringToDisplay.Length;
		int currentCharacterIndex = 0;

		textComponent.text = "";

		while(currentCharacterIndex < stringLength)
		{
			textComponent.text += stringToDisplay[currentCharacterIndex];
			currentCharacterIndex++;

			if(currentCharacterIndex < stringLength + 4)
			{
				if(Input.GetKey(DialogueInput))
				{
					yield return new WaitForSeconds(SecondsBetweenCharacters * CharacterRateMultiplier);
				}
				else
				{
					yield return new WaitForSeconds(SecondsBetweenCharacters);
				}

			}
			else
			{
				break;
			}
		}

		while(true)
		{
			if(Input.GetKeyDown(DialogueInput))
			{
				break;
			}

			yield return 0;
		}

		isStringBeingRevealed = false;
		textComponent.text = textComponent.text;
	}
}
