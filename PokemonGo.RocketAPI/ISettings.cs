﻿using PokemonGo.RocketAPI.Enums;
using PokemonGo.RocketAPI.GeneratedCode;
using System.Collections.Generic;

namespace PokemonGo.RocketAPI
{
    public interface ISettings
    {
        AuthType AuthType { get; }
        double DefaultLatitude { get; }
        double DefaultLongitude { get; }
        double DefaultAltitude { get; }
        string GoogleRefreshToken { get; set; }
        string PtcPassword { get; }
        string PtcUsername { get; }
        float KeepMinIVPercentage { get; }
        int KeepMinCP { get; }
        double WalkingSpeedInKilometerPerHour { get; }
        bool AllowTeleporting { get; }

        ICollection<KeyValuePair<AllEnum.ItemId, int>> ItemRecycleFilter { get; }

        ICollection<AllEnum.PokemonId> PokemonsToEvolve { get; }
    }
}