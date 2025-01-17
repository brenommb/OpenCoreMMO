﻿using System;
using System.Collections;
using System.Collections.Generic;
using NeoServer.Game.Common.Contracts.Creatures;
using NeoServer.Game.Common.Contracts.Items;
using NeoServer.Game.Common.Contracts.Items.Types;
using NeoServer.Game.Common.Contracts.Items.Types.Usable;
using NeoServer.Game.Common.Item;
using NeoServer.Game.Common.Location.Structs;
using NeoServer.Game.Items.Items.Cumulatives;

namespace NeoServer.Game.Items.Items.UsableItems;

public abstract class CumulativeUsableOnItem : Cumulative, IUsableOnItem
{
    public CumulativeUsableOnItem(IItemType type, Location location,
        IDictionary<ItemAttribute, IConvertible> attributes) : base(type, location, attributes)
    {
    }

    public abstract bool Use(ICreature usedBy, IItem onItem);

    public virtual bool CanUseOn(IItem onItem)
    {
        var useOnItems = Metadata.OnUse?.GetAttributeArray<ushort>(ItemAttribute.UseOn);
        return CanUseOn(useOnItems, onItem);
    }

    public bool CanUseOn(ushort[] items, IItem onItem)
    {
        return ((IList)items)?.Contains(onItem.Metadata.TypeId) ?? false;
    }

    public static bool IsApplicable(IItemType type)
    {
        return UsableOnItem.IsApplicable(type) && ICumulative.IsApplicable(type);
    }
}