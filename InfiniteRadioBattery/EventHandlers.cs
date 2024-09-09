using Exiled.Events.EventArgs.Player;

namespace InfiniteRadioBattery
{
    public class EventHandlers
    {
        public void UsingRadioBattery(UsingRadioBatteryEventArgs ev)
        {
            ev.Radio.Base.BatteryPercent = 100;
            ev.Drain = 0;
        }
    }
}