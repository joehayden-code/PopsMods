# Pop's Mods

A Terraria tModLoader mod that adds exciting new mechanics!

## Features

### 🎒 Miner's Sack
A special consumable bag that drops from enemies and contains randomized ore, gems, and mining supplies from underground expeditions.

### 📊 Drop Mechanics
- **Regular Enemies**: 1% chance to drop a Miner's Sack
- **Undead Miners**: 100% chance to drop one sack + 25% chance for a bonus second sack

### 💎 Loot Tables

#### Pre-Hardmode Ore Drops
- **10%** - No ore drops
- **35%** - 5-11 pieces of Copper or Tin Ore (50/50 chance)
- **30%** - 5-11 pieces of Iron or Lead Ore (50/50 chance)
- **25%** - 5-11 pieces of Gold or Platinum Ore (50/50 chance)

#### Hardmode Ore Drops
- **8%** - No ore drops
- **2%** - 8-16 pieces of Chlorophyte Ore
- **35%** - 5-11 pieces of Cobalt or Palladium Ore (50/50 chance)
- **30%** - 5-11 pieces of Mythril or Orichalcum Ore (50/50 chance)
- **25%** - 5-11 pieces of Adamantite or Titanium Ore (50/50 chance)

#### Gem Drops
- **10%** - No gem drops
- **15%** each - 1-3 pieces of:
  - Diamond
  - Amber
  - Ruby
  - Emerald
  - Sapphire
  - Topaz
  - Amethyst

#### Extra Mining Loot
- **50%** - No extra loot
- **25%** - 2-5 Torches
- **25%** - 1-3 Bombs

## Installation

### Requirements
- Terraria (latest version)
- tModLoader (latest version)

### Manual Installation
1. Download the latest release from the [Releases](../../releases) page
2. Place the `.tmod` file in your tModLoader `Mods` folder
3. Enable the mod in tModLoader's Mod Browser
4. Reload your mods

### Steam Workshop (if available)
Subscribe to the mod through tModLoader's in-game Mod Browser.

## Usage

1. **Hunt for Miner's Sacks**: Kill enemies to get a chance at finding a Miner's Sack
2. **Target Undead Miners**: These guaranteed drops make them valuable targets
3. **Use the Sack**: Right-click to consume and receive randomized loot
4. **Collect Resources**: Gather ore, gems, and supplies for your mining expeditions

## Development

### Building from Source

#### Prerequisites
- Visual Studio 2022 (or VS Code with C# extension)
- tModLoader installed
- .NET 6.0 SDK

#### Setup
1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/pops-mods.git
   cd pops-mods
   ```

2. Open the project in your preferred IDE

3. Build through tModLoader's mod development tools

#### File Structure
```
PopsMods/
├── build.txt              # Mod metadata
├── description.txt         # Mod description
├── icon.png               # Mod icon (80x80px)
├── PopsMods.cs            # Main mod class
├── GlobalNPCDrops.cs      # NPC drop handler
├── Items/
│   ├── MinersSack.cs      # Miner's Sack item
│   └── MinersSack.png     # Item texture (32x32px)
└── Localization/
    └── en-US.hjson        # English localization
```

### Contributing
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## Compatibility

- **tModLoader Version**: Latest stable release
- **Terraria Version**: 1.4.4+
- **Mod Conflicts**: None known

## Changelog

### v1.0.0
- Initial release
- Added Miner's Sack with full loot table system
- Implemented NPC drop mechanics
- Added support for both Pre-Hardmode and Hardmode progression

## FAQ

**Q: Can I get ore types that didn't generate in my world?**
A: Yes! The Miner's Sack has a 50/50 chance to drop either ore variant (e.g., Copper or Tin), regardless of what generated in your world.

**Q: Do Miner's Sacks stack?**
A: Yes, they stack up to 999 in a single inventory slot.

**Q: What's the best way to farm Miner's Sacks?**
A: Focus on areas with Undead Miners for guaranteed drops, or set up enemy farms for the 1% chance from regular mobs.

**Q: Does this work in multiplayer?**
A: Yes, the mod works perfectly in multiplayer servers.

## Support

- **Issues**: Report bugs or request features through [GitHub Issues](../../issues)
- **Discussions**: Join the conversation in [GitHub Discussions](../../discussions)
- **Steam Workshop**: Rate and comment on the mod page

## Credits

- **Author**: [Your Name]
- **Special Thanks**: The tModLoader team and Terraria modding community

---

*Happy mining! 🗸⚡*