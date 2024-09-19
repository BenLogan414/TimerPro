using TimerPro.Custom;

namespace TimerPro;

public partial class MainPage : ContentPage
{
    private TimerLogic oTimerLogic = new TimerLogic();

    public MainPage()
    {
        InitializeComponent();
        Title = "Timer Pro";
    }

    private void Start_OnClicked(object sender, EventArgs e)
    {
        btnStart.IsEnabled = false;
        btnStop.IsEnabled = true;
        Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (btnStop.IsEnabled)
            {
                oTimerLogic.SetTickCount();
                lblDisplay.Text = oTimerLogic.GetFormattedStrong();
            }
            
            return btnStop.IsEnabled;
        });
    }

    private void Stop_OnClicked(object sender, EventArgs e)
    {
        btnStart.IsEnabled = true;
        btnStop.IsEnabled = false;
    }

    private void Reset_OnClicked(object sender, EventArgs e)
    {
        oTimerLogic.Reset();
        lblDisplay.Text = oTimerLogic.GetFormattedStrong();
    }
}