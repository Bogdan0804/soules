﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using RPG2D.GameEngine;
using RPG2D.GameEngine.Screens;
using RPG2D.GameEngine.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2D.SGame.Screens
{
    public class MainGameScreen : IGameScreen
    {
        Camera2D camera;
        FrameCounter fpsCounter;

        public void Init(ContentManager content)
        {
            GameManager.Game.World = new World("world1.xml");
            camera = new Camera2D(GameManager.Game.GraphicsDevice);
            GameManager.Game.Player = new Player.Player();
            GameManager.Game.Player.Init(content);
            fpsCounter = new FrameCounter();
            
        }

        public void Update(GameTime gameTime)
        {
            GameManager.Game.Player.Update(gameTime);
            camera.LookAt(GameManager.Game.Player.Position + (GameManager.Game.Player.Size / 2));
            GameManager.Game.World.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            fpsCounter.Update(deltaTime);

            spriteBatch.Begin(samplerState: SamplerState.PointWrap, transformMatrix: camera.GetViewMatrix());


            var fps = string.Format("FPS: {0}", fpsCounter.AverageFramesPerSecond);
            GameManager.Game.World.Draw(gameTime, spriteBatch);


            spriteBatch.End();

            spriteBatch.Begin(samplerState: SamplerState.PointWrap);

            spriteBatch.DrawString(GlobalAssets.Arial12, fps, new Vector2(1, 1), Color.White);

            spriteBatch.DrawString(GlobalAssets.Arial24, GameManager.Game.Tooltip, new Vector2(GameManager.Game.ScreenSize.X / 2 - GlobalAssets.Arial24.MeasureString(GameManager.Game.Tooltip).X / 2, GameManager.Game.ScreenSize.Y - GlobalAssets.Arial24.MeasureString(GameManager.Game.Tooltip).Y), Color.White);

            spriteBatch.End();
        }
    }
}
