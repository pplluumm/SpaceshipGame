﻿using System;
using System.Collections.Generic;
using TextGame.Choices;

namespace TextGame.SpaceShip
{
    internal class AirRecycler : ShipStation
    {
        private int v;

        public AirRecycler(int v)
        {
            this.v = v;
        }

        public void fix(int repairLevel)
        {
            throw new NotImplementedException();
        }

        public List<Choice> getChoices()
        {
            throw new NotImplementedException();
        }

        public int getDamageCanTakeBeforeDestroyed()
        {
            throw new NotImplementedException();
        }

        public int getDamageCanTakeBeforeDisabled()
        {
            throw new NotImplementedException();
        }

        public bool hasChoices()
        {
            throw new NotImplementedException();
        }
    }
}