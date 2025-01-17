﻿using System;
using System.Collections.Generic;
using NeoServer.Game.Common.Contracts.Creatures;
using NeoServer.Game.Common.Contracts.Inspection;
using NeoServer.Game.Common.Contracts.Items;
using NeoServer.Game.Common.Contracts.Items.Types;
using NeoServer.Game.Common.Item;
using NeoServer.Game.Common.Location.Structs;

namespace NeoServer.Game.Items.Items;

public struct TeleportItem : ITeleport, IItem
{
    public TeleportItem(IItemType metadata, Location location,
        IDictionary<ItemAttribute, IConvertible> attributes)
    {
        Metadata = metadata;
        Location = location;

        Destination = Location.Zero;

        if (attributes is not null)
            Destination = attributes.TryGetValue(ItemAttribute.TeleportDestination, out var destination) &&
                          destination is Location destLocation
                ? destLocation
                : Location.Zero;

        OnTransform = default;
        ActionId = default;
        UniqueId = default;
    }

    public void SetActionId(ushort actionId)
    {
        ActionId = actionId;
    }

    public void SetUniqueId(uint uniqueId)
    {
        UniqueId = uniqueId;
    }

    public ushort ActionId { get; private set; }
    public uint UniqueId { get; private set; }
    public Location Location { get; set; }

    public string GetLookText(IInspectionTextBuilder inspectionTextBuilder, IPlayer player, bool isClose = false)
    {
        return inspectionTextBuilder is null
            ? $"You see {Metadata.Article} {Metadata.Name}."
            : inspectionTextBuilder.Build(this, player, isClose);
    }

    public bool HasDestination => Destination != Location.Zero;
    public Location Destination { get; }

    public IItemType Metadata { get; }

    public bool Teleport(IWalkableCreature player)
    {
        if (!HasDestination) return false;
        player.TeleportTo(Destination);
        return true;
    }

    public void Transform(IPlayer by)
    {
        OnTransform?.Invoke(by, this, Metadata.Attributes.GetTransformationItem());
    }

    public void Transform(IPlayer by, ushort to)
    {
        OnTransform?.Invoke(by, this, to);
    }

    public event Transform OnTransform;

    public static bool IsApplicable(IItemType type)
    {
        return type
            .Attributes
            .GetAttribute(ItemAttribute.Type)
            ?.Equals("teleport", StringComparison.InvariantCultureIgnoreCase) ?? false;
    }

    public void Use(IPlayer usedBy)
    {
    }
}