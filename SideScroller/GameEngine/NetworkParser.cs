﻿using Lidgren.Network;
using Microsoft.Xna.Framework;
using RPG2D.GameEngine.World;
using RPG2D.SGame.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2D.GameEngine
{
    public class NetworkParser
    {
        bool isServer;
        NetServer server;
        NetClient client;
        public float X;
        public float Y;
        public string IP;

        public NetworkParser(NetServer _server)
        {
            this.server = _server;
            isServer = true;

            InitCommands();
        }

        private void InitCommands()
        {
            if (isServer)
            {
                GameManager.Game.ConsoleInterpreter.RegisterCommand("kick", (args) =>
                {
                    SendMessage("kick()");

                    return "Kicked CO-Player.";
                });
            }
        }

        public NetworkParser(NetClient _client)
        {
            this.client = _client;
            isServer = false;

            InitCommands();
        }

        public void Update(GameTime gameTime)
        {
            NetIncomingMessage msg;

            if (isServer)
            {
                SendPos();

                while ((msg = server.ReadMessage()) != null)
                {
                    if (msg.MessageType == NetIncomingMessageType.Data)
                        Parse(msg.ReadString());
                }
            }
            else
            {
                SendPos();

                while ((msg = client.ReadMessage()) != null)
                {
                    if (msg.MessageType == NetIncomingMessageType.Data)
                        Parse(msg.ReadString());
                }
            }
        }

        private void SendPos()
        {
            SendMessage($"move({GameManager.Game.Player.X},{GameManager.Game.Player.Y})");
        }

        public void SendMessage(string messageText)
        {
            if (isServer)
            {
                if (server.Connections.Count > 0)
                {
                    NetOutgoingMessage message = server.CreateMessage(messageText);
                    server.SendMessage(message, server.Connections[0], NetDeliveryMethod.ReliableOrdered);
                    server.FlushSendQueue();
                }
            }
            else
            {
                NetOutgoingMessage message = client.CreateMessage(messageText);
                client.SendMessage(message, NetDeliveryMethod.ReliableOrdered);
                client.FlushSendQueue();
            }
        }

        public void InteractWith(Tile tile)
        {
            SendMessage($"interact({tile.X},{tile.Y})");
        }

        public void Parse(string message)
        {
            string messageType = message.Split('(')[0];
            string messageData = message.Split('(', ')')[1];

            if (messageType == "move")
            {
                X = float.Parse(messageData.Split(',')[0]);
                Y = float.Parse(messageData.Split(',')[1]);
            }
            else if (messageType == "interact")
            {
                float x = float.Parse(messageData.Split(',')[0]);
                float y = float.Parse(messageData.Split(',')[1]);

                foreach (var tile in GameManager.Game.World.Tiles)
                {
                    if (tile.X == x && tile.Y == y)
                        tile.TileInfo?.OnInteract.Invoke(tile);
                }
            }
            else if (messageType == "kick")
            {
                JoinCOOPGameScreen screen = new JoinCOOPGameScreen();
                screen.showingDiag = true;
                screen.messageLog.AppendLine("You Have Been Kicked From The Game.");
                screen.ip = IP;

                GameManager.Game.ChangeScreen(screen);
            }
        }
    }
}
