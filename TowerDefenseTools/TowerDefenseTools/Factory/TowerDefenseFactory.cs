﻿using System;
using TowerDefenseTools.Classes;

namespace TowerDefenseTools.Factory
{
    public class TowerDefenseFactory
    {
        public static AbstractTowerMob buildMobOrTower(String nom, String type, int hp, int vitesse, int degat, int range)
        {
            if(String.Equals(nom, "Tower",StringComparison.OrdinalIgnoreCase))
            {
                return new Tower(nom, type, hp, degat, range);
            }
            if (String.Equals(nom, "Mob", StringComparison.OrdinalIgnoreCase))
            {
                return new Mob(nom, type, hp, vitesse);
            }
            return null;
        }
    }
}
