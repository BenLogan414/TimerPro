namespace TimerPro.Custom;

public class TimerLogic
{
    private int _intSec;
    private int _intMin;
    private int _intHours;

    public TimerLogic()
    {
        Reset();
    }

    public void SetTickCount()
    {
        _intSec++;
        if (_intSec==59)
        {
            _intSec = 0;
            _intMin++;
            
            if (_intMin==59)
            {
                _intMin = 0;
                _intHours++;
            }
        }
    }

    public void Reset()
    {
        _intSec = 0;
        _intMin = 0;
        _intHours = 0;
    }

    public string GetFormattedStrong()
    {
        return _intHours.ToString().PadLeft(2, '0') + ":" + _intMin.ToString().PadLeft(2, '0') + ":" + _intSec.ToString().PadLeft(2, '0');
    }
    
}