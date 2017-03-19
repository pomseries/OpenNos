﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNos.Core;
using OpenNos.GameObject;
using OpenNos.GameObject.Packets.ServerPackets;
using OpenNos.GameObject.Helpers;
using CloneExtensions;

namespace OpenNos.Handler
{
    class ScriptedInstancePacketHandler : IPacketHandler
    {
        #region Instantiation

        public ScriptedInstancePacketHandler(ClientSession session)
        {
            Session = session;
        }

        #endregion

        #region Properties

        private ClientSession Session { get; }

        /// <summary>
        /// treq packet
        /// </summary>
        /// <param name="treqPacket"></param>
        public void GetTreq(TreqPacket treqPacket)
        {

            ScriptedInstance timespace = Session.CurrentMapInstance.TimeSpaces.FirstOrDefault(s => treqPacket.X == s.PositionX && treqPacket.Y == s.PositionY);

            if (timespace != null)
            {
               
                if (treqPacket.StartPress != 1 || treqPacket.RecordPress != 1)
                {
                    timespace.LoadScript();
                    if (timespace.FirstMap == null) return;
                    ServerManager.Instance.TeleportOnRandomPlaceInMap(Session, timespace.FirstMap.MapInstanceId);
                    Session.SendPackets(timespace.GenerateMinimap());

                }
                else
                {
                    Session.SendPacket(timespace.GenerateRbr());
                }
            }

        }

        /// <summary>
        /// GitPacket packet
        /// </summary>
        /// <param name="packet"></param>
        public void Git(GitPacket packet)
        {
            MapButton button = Session.CurrentMapInstance.Buttons.FirstOrDefault(s => s.MapButtonId == packet.ButtonId);
            if (button != null)
            {
                Session.CurrentMapInstance.Broadcast(button.GenerateOut());
                button.RunAction();
                Session.CurrentMapInstance.Broadcast(button.GenerateIn());
            }
        }
        /// <summary>
        /// wreq packet
        /// </summary>
        /// <param name="packet"></param>
        public void GetWreq(WreqPacket packet)
        {


        }


        #endregion
    }
}
