using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;

    public void UpdateVale(float amount)
    {

        value += amount;

    }

    public void UpdateValueLimitZero(float amount)
    {

        if (value < 0)
        {
            value = 0;
        }

        else
        {
            UpdateVale(amount);
        }
    }

    /*public void UpdateValueLimitZeroAndMaxValue(float amount)
    {

        if (value < maxValue)
        {
            UpdateVale(amount);
        }
        else
        {
            value = maxValue;
        }
        UpdateValueLimitZero(amount);

    }*/

    public void changeValue(float amount)
    {
        value = amount;
    }

}