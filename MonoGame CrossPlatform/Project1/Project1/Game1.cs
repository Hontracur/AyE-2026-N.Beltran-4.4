using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

            arbol.Insertar(50);
            arbol.Insertar(30);
            arbol.Insertar(70);
            arbol.Insertar(20);
            arbol.Insertar(40);
            arbol.Insertar(60);
            arbol.Insertar(80);

            Console.WriteLine("Mínimo: " + arbol.ObtenerMinimo());
            Console.WriteLine("Máximo: " + arbol.ObtenerMaximo());
            Console.WriteLine("Cantidad de nodos: " + arbol.ObtenerCantidadNodos());
            Console.WriteLine("Altura: " + arbol.ObtenerAltura());
            Console.WriteLine("Cantidad de hojas: " + arbol.ContarHojas());
            Console.WriteLine("Es válido: " + arbol.EsValido());

            arbol.Eliminar(70);

            Console.WriteLine("Después de eliminar 70:");
            Console.WriteLine("Cantidad de nodos: " + arbol.ObtenerCantidadNodos());
            Console.WriteLine("Es válido: " + arbol.EsValido());

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
