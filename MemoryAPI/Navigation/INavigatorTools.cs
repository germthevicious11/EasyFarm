﻿using System;

namespace MemoryAPI
{
    public interface INavigatorTools
    {
        double DistanceTolerance { get; set; }
                
        double DistanceTo(IPosition position);
        bool FaceHeading(IPosition position);        
        void Goto(IPosition position, bool KeepRunning);
        void GotoNPC(int ID);
        void Reset();        
    }
}