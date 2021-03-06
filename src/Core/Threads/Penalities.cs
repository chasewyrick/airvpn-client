﻿// <airvpn_source_header>
// This file is part of AirVPN Client software.
// Copyright (C)2014-2014 AirVPN (support@airvpn.org) / https://airvpn.org )
//
// AirVPN Client is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AirVPN Client is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AirVPN Client. If not, see <http://www.gnu.org/licenses/>.
// </airvpn_source_header>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using AirVPN.Core;

namespace AirVPN.Core.Threads
{
	public class Penalities : AirVPN.Core.Thread
    {
        public override ThreadPriority GetPriority()
        {
            return ThreadPriority.Lowest;
        }

        public override void OnRun()
        {
			for (; ; )
            {
                lock (Engine.Servers)
                {
                    
                    foreach (ServerInfo infoServer in Engine.Servers.Values)
                    {
                        if(infoServer.Penality>0)
                            infoServer.Penality--;                    

                        if (CancelRequested)
                            return;
                    }
                }

                for(int i=0;i<600;i++) // Every minute
                {
                    Sleep(100);

                    if (CancelRequested)
                        return;
                }
            }
        }
    }
}
