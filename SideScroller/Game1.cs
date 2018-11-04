﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RPG2D
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            

            this.IsFixedTimeStep = false;//false;

            graphics.GraphicsProfile = GraphicsProfile.HiDef;
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";

            LogSpecs(graphics);

            this.Window.Title = "RPG2D Demo";
        }

        private void LogSpecs(GraphicsDeviceManager graphics)
        {
            Console.Title = "Game2D - RPG2D Graphics Tile Demo";
            Console.WriteLine("Detecting Graphics Hardware...");
            Console.WriteLine("Graphics Accelerator: {0}", graphics.GraphicsDevice.Adapter.Description);
            Console.WriteLine("Rendering Resolution: {0}x{1}", graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
            Console.WriteLine("VSynced: {0}", graphics.SynchronizeWithVerticalRetrace);
            Console.WriteLine("Desired Update Rate: {0}/60", this.TargetElapsedTime.Milliseconds);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            GameEngine.GameManager.Game.Init(Content, spriteBatch, graphics);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            GameEngine.GameManager.Game.Update(gameTime);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GameEngine.GameManager.Game.Draw(gameTime);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}