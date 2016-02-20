using FishTankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FishTankApp.Services
{
    public class SensorDataService : ISensorDataService
    {
        private readonly Random _random = new Random();
        private IEnumerable<IntHistoryModel> _waterTemperatureHistory;
        private IEnumerable<IntHistoryModel> _fishMotionHistory;
        private IEnumerable<IntHistoryModel> _waterOpacityHistory;
        private IEnumerable<IntHistoryModel> _lightOpacityHistory;

        public IntHistoryModel GetWaterTemperatureFahrenheit()
        {
            return GetWaterTemperatureFahrenheitHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetWaterTemperatureFahrenheitHistory()
        {
            return _waterTemperatureHistory ?? (_waterTemperatureHistory = GetHistory(70, 90));
        }

        public IntHistoryModel GetFishMotionPercentage()
        {
            return GetFishMotionPercentageHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory()
        {
            return _fishMotionHistory ?? (_fishMotionHistory = GetHistory(0, 100));
        }

        public IntHistoryModel GetWaterOpacityPercentage()
        {
            return GetWaterOpacityPercentageHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory()
        {
            return _waterOpacityHistory ?? (_waterOpacityHistory = GetHistory(0, 90));
        }

        public IntHistoryModel GetLightIntensityLumens()
        {
            return GetLightIntensityLumensHistory().Last();
        }
        public IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory()
        {
            return _lightOpacityHistory ?? (_lightOpacityHistory = GetHistory(0, 5000));
        }

        private IEnumerable<IntHistoryModel> GetHistory(int min, int max)
        {
            var result = new List<IntHistoryModel>();
            for (var i = -10; i < 1; i++)
            {
                result.Add(new IntHistoryModel(DateTime.Now.AddHours(i), _random.Next(min, max)));
            }
            return result;
        }
    }
}

