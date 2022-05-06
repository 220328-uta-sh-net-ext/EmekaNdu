﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    public interface IMenu
    {
        void Display();
        string UserChoice();
    }

    interface IMoreMenu
    {
        void Exit();

        void Continue();
    }

}
