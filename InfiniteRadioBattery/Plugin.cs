using Exiled.API.Enums;
using Exiled.API.Features;
using System;

namespace InfiniteRadioBattery
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "InfiniteRadioBattery";
        public override string Prefix => "InfiniteRadioBattery";
        public override string Author => "aksueikava";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);
        public override PluginPriority Priority { get; } = PluginPriority.Default;

        public static Plugin Instance;
        private EventHandlers _handlers;

        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();

            Log.Debug("InfiniteRadioBattery has been enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnregisterEvents();

            Log.Debug("InfiniteRadioBattery has been disabled.");
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _handlers = new EventHandlers();
            Exiled.Events.Handlers.Player.UsingRadioBattery += _handlers.UsingRadioBattery;
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.UsingRadioBattery -= _handlers.UsingRadioBattery;
            _handlers = null;
        }
    }
}