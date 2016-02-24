namespace FishTankApp.ViewModels
{
    public class DashboardViewModel
    {
        public SensorTileViewModel WaterTemperatureTile { get; set; }

        public SensorTileViewModel FishMotionTile { get; set; }

        public SensorTileViewModel WaterOpacityTile { get; set; }

        public SensorTileViewModel LightIntensityTile { get; set; }
    }
}
