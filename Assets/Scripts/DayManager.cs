using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class DayManager : MonoBehaviour
{

	public Text HourText;

	[Range(0.5f, 5f)]
	public float HourSpeed = 10;

	[Range(0, 24)]
	public float CurrentHour;

	private float _currentHour;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Application.isPlaying)
		{
			_currentHour += Time.deltaTime * HourSpeed;
			if (_currentHour > 24)
			{
				_currentHour = 0;
			}
			CurrentHour = _currentHour;
		}
		else
		{
			_currentHour = CurrentHour;
		}
		HourText.text = Mathf.FloorToInt(_currentHour).ToString();
	}
}
