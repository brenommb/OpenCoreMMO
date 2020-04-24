﻿using NeoServer.Game.Contracts.World;
using NeoServer.Game.Enums.Location.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoServer.Game.Contracts.Items
{
    public interface IMoveableThing : IThing
    {
        void SetNewLocation(Location location);
    }
}
