﻿namespace StardewMods.BetterChests;

using StardewMods.BetterChests.Features;
using StardewMods.BetterChests.Models;
using StardewMods.Common.Enums;

/// <summary>
///     Mod config data.
/// </summary>
internal class ModConfig
{
    /// <summary>
    ///     Gets or sets a value indicating whether shipping bin will be relaunched as a regular chest inventory menu.
    /// </summary>
    public bool BetterShippingBin { get; set; } = true;

    /// <summary>
    ///     Gets or sets a value indicating how many chests containing items can be carried at once.
    /// </summary>
    public int CarryChestLimit { get; set; } = 1;

    /// <summary>
    ///     Gets or sets a value indicating whether carrying a chest containing items will apply a slowness effect.
    /// </summary>
    public int CarryChestSlowAmount { get; set; } = 1;

    /// <summary>
    ///     Gets or sets a value indicating whether chests can be categorized.
    /// </summary>
    public bool CategorizeChest { get; set; } = true;

    /// <summary>
    ///     Gets or sets a value indicating whether Configurator will be enabled.
    /// </summary>
    public bool Configurator { get; set; } = true;

    /// <summary>
    ///     Gets or sets the control scheme.
    /// </summary>
    public Controls ControlScheme { get; set; } = new();

    /// <summary>
    ///     Gets or sets the <see cref="ComponentArea" /> that the <see cref="BetterColorPicker" /> will be aligned to.
    /// </summary>
    public ComponentArea CustomColorPickerArea { get; set; } = ComponentArea.Right;

    /// <summary>
    ///     Gets or sets the default storage configuration.
    /// </summary>
    public StorageData DefaultChest { get; set; } = new()
    {
        CarryChest = FeatureOption.Enabled,
        CarryChestSlow = FeatureOption.Enabled,
        ChestMenuTabs = FeatureOption.Enabled,
        CraftFromChest = FeatureOptionRange.Location,
        CraftFromChestDistance = -1,
        CustomColorPicker = FeatureOption.Enabled,
        FilterItems = FeatureOption.Enabled,
        OpenHeldChest = FeatureOption.Enabled,
        ResizeChest = FeatureOption.Enabled,
        ResizeChestCapacity = 60,
        ResizeChestMenu = FeatureOption.Enabled,
        ResizeChestMenuRows = 5,
        SearchItems = FeatureOption.Enabled,
        StashToChest = FeatureOptionRange.Location,
        StashToChestDistance = -1,
    };

    /// <summary>
    ///     Gets or sets a value indicating whether chests can be labeled.
    /// </summary>
    public bool LabelChest { get; set; } = true;

    /// <summary>
    ///     Gets or sets a value indicating whether chests can be locked.
    /// </summary>
    public bool LockedChests { get; set; } = true;

    /// <summary>
    ///     Gets or sets the symbol used to denote context tags in searches.
    /// </summary>
    public char SearchTagSymbol { get; set; } = '#';

    /// <summary>
    ///     Gets or sets a value indicating whether the slot lock feature is enabled.
    /// </summary>
    public bool SlotLock { get; set; } = true;

    /// <summary>
    ///     Gets or sets a value indicating whether the slot lock button needs to be held down.
    /// </summary>
    public bool SlotLockHold { get; set; } = true;
}